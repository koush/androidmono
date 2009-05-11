using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;
using System.Runtime.Remoting;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Collections;

namespace MonoDalvikBridge
{
    // intentionally keep signed and unsigned types next to eachother for quick size comparison
    public enum RuntimeType : byte
    {
        Default = 0,
        Char = 1,
        Byte = 2,
        Int16 = 3,
        UInt16 = 4,
        Int32 = 5,
        UInt32 = 6,
        Int64 = 7,
        UInt64 = 8,
        Single = 9,
        Double = 10,
        Boolean = 11,
        String = 12,
        MonoObject = 13,
        JavaObject = 14,
        Void = 15,
    }

    public class TestObject
    {
        public TestObject()
        {
            DalvikBridge.DebugLog("TestObject default Constructor");
        }

        string myThing = "default";
        public TestObject(string thing)
        {
            DalvikBridge.DebugLog("TestObject string Constructor {0}", thing);
            myThing = thing;
        }

        public void Foo()
        {
            DalvikBridge.DebugLog(myThing);
        }
    }

    public static class DalvikBridge
    {
        static Dictionary<Type, RuntimeType> mySerializationLookup = new Dictionary<Type, RuntimeType>();
        static Dictionary<RuntimeType, Type> myDeserializationLookup = new Dictionary<RuntimeType, Type>();
        delegate void SerializeHandler(object arg);
        static SerializeHandler[] mySerializeHandlers = new SerializeHandler[(byte)RuntimeType.Void + 1];
        delegate object DeserializeHandler();
        static DeserializeHandler[] myDeserializeHandlers = new DeserializeHandler[(byte)RuntimeType.Void + 1];

        [ThreadStatic]
        static MemoryStream myStream = new MemoryStream();
        [ThreadStatic]
        static BinaryWriter myWriter = new BinaryWriter(myStream);
        [ThreadStatic]
        static BinaryReader myReader = new BinaryReader(myStream);
        // The return buffer is used to return values to java
        // or to store return values from java.
        // It may be alloced/realloced in the Mono side prior to returning to Java,
        // Or in the JNI/unmanaged layer when copying the Java byte array
        // to memory. (in this case the pointer is passed in as a reference)
        [ThreadStatic]
        static IntPtr myMarshalBuffer = IntPtr.Zero;
        [ThreadStatic]
        static int myMarshalBufferLength = 0;

        static void EnsureThreadStatic()
        {
            if (myStream == null)
            {
                DebugLog("Calling in from unmanaged thread; initializing thread statics.");
                myStream = new MemoryStream();
                myWriter = new BinaryWriter(myStream);
                myReader = new BinaryReader(myStream);
                myMarshalBuffer = IntPtr.Zero;
                myMarshalBufferLength = 0;
            }
        }

        static void SerializeString(object o)
        {
            if (o == null)
                throw new Exception("Serializing null string. This could should not be reached.");
            
            string s = o as string;
            myWriter.Write(s.Length);
            myWriter.Write(Encoding.ASCII.GetBytes(s));
        }

        static string DeserializeString()
        {
            int length = myReader.ReadInt32();
            DebugLog("Deserializing String of Length: {0}", length);
            if (length < 0)
                return null;
            return new string(myReader.ReadChars(length));
        }

        static DalvikBridge()
        {
            // set up the conversion dictionary
            mySerializationLookup.Add(typeof(char), RuntimeType.Char);
            mySerializationLookup.Add(typeof(byte), RuntimeType.Byte);
            mySerializationLookup.Add(typeof(short), RuntimeType.Int16);
            mySerializationLookup.Add(typeof(ushort), RuntimeType.UInt16);
            mySerializationLookup.Add(typeof(int), RuntimeType.Int32);
            mySerializationLookup.Add(typeof(uint), RuntimeType.UInt32);
            mySerializationLookup.Add(typeof(long), RuntimeType.Int64);
            mySerializationLookup.Add(typeof(ulong), RuntimeType.UInt64);
            mySerializationLookup.Add(typeof(float), RuntimeType.Single);
            mySerializationLookup.Add(typeof(double), RuntimeType.Double);
            mySerializationLookup.Add(typeof(bool), RuntimeType.Boolean);
            mySerializationLookup.Add(typeof(string), RuntimeType.String);
            mySerializationLookup.Add(typeof(DalvikObject), RuntimeType.JavaObject);
            mySerializationLookup.Add(typeof(void), RuntimeType.Void);

            foreach (var pair in mySerializationLookup)
            {
                myDeserializationLookup.Add(pair.Value, pair.Key);
            }
            myDeserializationLookup.Add(RuntimeType.MonoObject, typeof(object));

            // Convert is used when:
            //      * When passing arguments to a Java method
            //      * When returning a value from a Mono method call
            mySerializeHandlers[(byte)RuntimeType.Char] = (o) => { myWriter.Write((char)o); ; };
            mySerializeHandlers[(byte)RuntimeType.Byte] = (o) => { myWriter.Write((Byte)o); };
            mySerializeHandlers[(byte)RuntimeType.Int16] = (o) => { myWriter.Write((Int16)o); };
            mySerializeHandlers[(byte)RuntimeType.UInt16] = (o) => { myWriter.Write((UInt16)o); };
            mySerializeHandlers[(byte)RuntimeType.Int32] = (o) => { myWriter.Write((Int32)o); };
            mySerializeHandlers[(byte)RuntimeType.UInt32] = (o) => { myWriter.Write((UInt32)o); };
            mySerializeHandlers[(byte)RuntimeType.Int64] = (o) => { myWriter.Write((Int64)o); };
            mySerializeHandlers[(byte)RuntimeType.UInt64] = (o) => { myWriter.Write((UInt64)o); };
            mySerializeHandlers[(byte)RuntimeType.Single] = (o) => { myWriter.Write((Single)o); };
            mySerializeHandlers[(byte)RuntimeType.Double] = (o) => { myWriter.Write((Double)o); };
            mySerializeHandlers[(byte)RuntimeType.Boolean] = (o) => { myWriter.Write((byte)((Boolean)o ? 1 : 0)); };
            mySerializeHandlers[(byte)RuntimeType.String] = (o) => { SerializeString(o); };
            // Add the Mono object to the static reference table to keep it from being garbage collected.
            // When the "MonoObject" dies and get's garbage collected on the Java side, it will trigger the removal
            // of the object from the table on the Mono side.
            mySerializeHandlers[(byte)RuntimeType.MonoObject] = (o) => { myJavaReferences[myJavaReferenceCounter] = o; myWriter.Write(myJavaReferenceCounter++); };
            mySerializeHandlers[(byte)RuntimeType.JavaObject] = (o) => { myWriter.Write((o as DalvikObject).myObjectId); };

            // Unconvert is used when:
            //      * When receiving arguments from Java to a Mono method call
            //      * When receiving a return type from a Java method
            myDeserializeHandlers[(byte)RuntimeType.Char] = () => { return myReader.ReadChar(); };
            myDeserializeHandlers[(byte)RuntimeType.Byte] = () => { return myReader.ReadByte(); };
            myDeserializeHandlers[(byte)RuntimeType.Int16] = () => { return myReader.ReadInt16(); };
            myDeserializeHandlers[(byte)RuntimeType.UInt16] = () => { return myReader.ReadUInt16(); };
            myDeserializeHandlers[(byte)RuntimeType.Int32] = () => { return myReader.ReadInt32(); };
            myDeserializeHandlers[(byte)RuntimeType.UInt32] = () => { return myReader.ReadUInt32(); };
            myDeserializeHandlers[(byte)RuntimeType.Int64] = () => { return myReader.ReadInt64(); };
            myDeserializeHandlers[(byte)RuntimeType.UInt64] = () => { return myReader.ReadUInt64(); };
            myDeserializeHandlers[(byte)RuntimeType.Single] = () => { return myReader.ReadSingle(); };
            myDeserializeHandlers[(byte)RuntimeType.Double] = () => { return myReader.ReadDouble(); };
            myDeserializeHandlers[(byte)RuntimeType.Boolean] = () => { return myReader.ReadBoolean(); };
            myDeserializeHandlers[(byte)RuntimeType.String] = () => { return DeserializeString(); };
            // Mono objects are contained in the reference table, so let's return that reference
            myDeserializeHandlers[(byte)RuntimeType.MonoObject] = () => { int id = myReader.ReadInt32(); if (id == 0) return null; return myJavaReferences[id]; };
            myDeserializeHandlers[(byte)RuntimeType.JavaObject] = () => { int id = myReader.ReadInt32(); if (id == 0) return null; return new DalvikObject(id); };
        }

        static bool MatchesSignatureBase(string methodName, Type[] parameterTypes, MethodBase method)
        {
            if (method.Name != methodName)
            {
                DebugLog("Method name does not match {0} vs {1}", methodName, method.Name);
                return false;
            }
            ParameterInfo[] parameterInfos = method.GetParameters();
            if (parameterInfos.Length != parameterTypes.Length)
            {
                DebugLog("Parameter count does not match {0} vs {1}", parameterTypes.Length, parameterInfos.Length);
                return false;
            }
            bool match = true;
            for (int i = 0; i < parameterTypes.Length; i++)
            {
                ParameterInfo parameterInfo = parameterInfos[i];
                // if we don't know the type, that means it is null and not explicitly provided, just ignore it.
                // check for multiple matches later (ambiguous matches)
                if (parameterTypes[i] == null)
                    continue;
                if (parameterTypes[i] != parameterInfo.ParameterType)
                {
                    DebugLog("Parameter type {2} does not match {0} vs {1}", parameterTypes[i], parameterInfo.ParameterType, i);
                    match = false;
                    break;
                }
            }
            return match;
        }

        static bool MatchesSignature(string methodName, Type[] parameterTypes, Type returnType, MethodInfo method)
        {
            if (returnType != method.ReturnType)
            {
                DebugLog("Return type does not match {0} vs {1}", returnType, method.ReturnType);
                return false;
            }
            return MatchesSignatureBase(methodName, parameterTypes, method);
        }

        delegate IntPtr HandleInvokeHandler();
        static IntPtr HandleInvoke()
        {
            DebugLog("Handling Invoke from Dalvik", myMarshalBuffer);
            try
            {
                ResetStream();
                int parameterBufferLength = Marshal.ReadInt32(myMarshalBuffer);
                DebugLog("parameterBufferLength: {0}", parameterBufferLength);
                myStream.SetLength(parameterBufferLength);
                Marshal.Copy(myMarshalBuffer, myStream.GetBuffer(), 0, parameterBufferLength);

                // eat the buffer length that we already read
                Deserialize<int>();
                string assemblyQualifiedName = Deserialize<string>();
                int objectId = Deserialize<int>();
                bool isConstructor = Deserialize<bool>();
                RuntimeType returnType = (RuntimeType)Deserialize<byte>();
                Type realReturnType = GetTypeFromRuntimeType(returnType);
                string methodName = Deserialize<string>();
                int numParameters = Deserialize<int>();

                // figure out what type we are invoking on
                Type type;
                object target;
                if (assemblyQualifiedName == null)
                {
                    target = myJavaReferences[objectId];
                    type = target.GetType();
                }
                else
                {
                    target = null;
                    type = Type.GetType(assemblyQualifiedName);
                }

                if (type == null && target == null)
                    throw new InvalidOperationException("Unable to determine the target of the method invocation.");

                // deserialize the parameters
                object[] parameters = new object[numParameters];
                Type[] realTypes = new Type[numParameters];
                bool clueless = false;
                // grab all the parameter types from the values or explicitly given types in the null case
                for (int i = 0; i < numParameters; i++)
                {
                    RuntimeType runtimeType = (RuntimeType)Deserialize<byte>();
                    object parameter = parameters[i] = DeserializeObject(runtimeType);
                    if (parameter == null)
                    {
                        // if we have a null parameter, try to get it from the explicit parameter list
                        if (runtimeType != RuntimeType.Default && runtimeType != RuntimeType.MonoObject)
                        {
                            realTypes[i] = GetTypeFromRuntimeType(runtimeType);
                        }
                        else
                        {
                            // we have no idea what this is... 
                            // the parameter is null, and no explicit type was given
                            realTypes[i] = null;
                            clueless = true;
                        }
                    }
                    else
                    {
                        realTypes[i] = parameter.GetType();
                    }
                }

                {
                    string[] signatureArgs = new string[numParameters];
                    for (int i = 0; i < numParameters; i++)
                    {
                        signatureArgs[i] = realTypes[i].ToString();
                    }
                    string signature = string.Join(",", signatureArgs);
                    if (!isConstructor)
                        DebugLog("Desired method signature in {0}:\n{1} {2}({3})", type, returnType, methodName, signature);
                    else
                        DebugLog("Desired constructor signature:\n{0}{1}", type, signature);
                }

                bool needsConfirmation = true;
                MethodBase methodBase = null;
                MethodInfo methodInfo = null;
                ConstructorInfo constructorInfo = null;
                if (!clueless)
                {
                    DebugLog("Searching for explicit method/constructor signature");
                    needsConfirmation = !isConstructor;
                    if (isConstructor)
                        methodBase = constructorInfo = type.GetConstructor(realTypes);
                    else
                        methodBase = methodInfo = type.GetMethod(methodName, realTypes);
                }
                else
                {
                    DebugLog("Searching for ambiguous method/constructor signature");
                    if (!isConstructor)
                    {
                        try
                        {
                            // grab whatever we can that matches the name
                            methodInfo = type.GetMethod(methodName);
                            if (methodInfo == null || methodInfo.ReturnType != realReturnType)
                                throw new MissingMethodException("Unable to find desired method");
                            methodBase = methodInfo;
                            // need to confirm this, as no parameter type checking was done
                            needsConfirmation = true;
                        }
                        catch (AmbiguousMatchException)
                        {
                        }
                    }
                    // ambiguous, so find the one that sort of matches
                    if (methodInfo == null || isConstructor)
                    {
                        // explicit checking, so don't bother post confirming
                        needsConfirmation = false;
                        IEnumerable methods = null;
                        if (isConstructor)
                            methods = type.GetConstructors();
                        else
                            methods = type.GetMethods();
                        foreach (MethodBase methodCandidate in methods)
                        {
                            if (MatchesSignatureBase(methodName, realTypes, methodCandidate))
                            {
                                // preexisting match means it is ambiguous... ie
                                // intent.putExtra(string) and intent.putExtra(parcelable) and null passed in...
                                if (methodBase != null)
                                    throw new AmbiguousMatchException();
                                if (!isConstructor)
                                {
                                    MethodInfo methodInfoCandidate = methodCandidate as MethodInfo;
                                    if (methodInfoCandidate.ReturnType != realReturnType)
                                    {
                                        DebugLog("Return type does not match {0} vs {1}", returnType, methodInfoCandidate.ReturnType);
                                        continue;
                                    }
                                    methodInfo = methodInfoCandidate;
                                }
                                else
                                {
                                    constructorInfo = methodCandidate as ConstructorInfo;
                                }
                                methodBase = methodCandidate;
                            }
                        }
                    }
                }
                if (methodBase == null)
                    throw new ArgumentException("Unable to find matching method call.");
                if (needsConfirmation)
                {
                    if (!MatchesSignatureBase(methodName, realTypes, methodBase))
                        throw new ArgumentException("Unable to find matching method call.");
                }

                object ret = null;
                if (isConstructor)
                    ret = constructorInfo.Invoke(parameters);
                else
                    ret = methodInfo.Invoke(target, parameters);
                ResetStream();
                // flag the invocation success as true
                Serialize<bool>(true);
                if (!isConstructor && methodInfo.ReturnType == typeof(void))
                {
                    MarshalStream();
                    return myMarshalBuffer;
                }

                SerializeObject(ret, returnType);
                MarshalStream();
                return myMarshalBuffer;
            }
            catch (Exception e)
            {
                DebugLog("Caught unhandled exception.");

                Exception ie = e;
                string message = string.Empty;
                while (ie != null)
                {
                    string innerMessage = ie.Message != null ? ie.Message : "No Message";
                    message = string.Format("{0}\n{1}", message, innerMessage);
                    DebugLog("{0}: {1}", ie.GetType().Name, innerMessage);
                    ie = ie.InnerException;
                } 
                
                string stackTrace = string.Empty;
                if (e.StackTrace != null)
                {
                    DebugLog(e.StackTrace);
                    stackTrace = e.StackTrace;
                }
                else
                {
                    stackTrace = "No StackTrace";
                }

                // marshal the exception text into the buffer. the negative value will be the length of the string
                ResetStream();
                // flag the invocation success as false
                Serialize<bool>(false);
                Serialize<string>(string.Format("{0}\n{1}\n{2}", e.GetType(), message, stackTrace));
                MarshalStream();

                DebugLog("Exiting HandleInvoke");
                return myMarshalBuffer;
            }
        }

        static void MarshalStream()
        {
            int bufferLength = (int)myStream.Length + sizeof(int);
            EnsureBufferLength(bufferLength);
            DebugLog("Marshalling stream of length {0}", bufferLength);
            Marshal.WriteInt32(myMarshalBuffer, bufferLength);
            Marshal.Copy(myStream.GetBuffer(), 0, (IntPtr)((long)myMarshalBuffer + sizeof(int)), (int)myStream.Length);
        }

        static void ResetStream()
        {
            myStream.Seek(0, SeekOrigin.Begin);
            myStream.SetLength(0);
        }

        delegate IntPtr EnsureBufferLengthHandler(int length);
        // This function is used to ensure the buffer has enough room to hold whatever needs to be marshalled.
        // It will be called from the JNI/PInvoke layer before the call to HandleInvoke, 
        // or prior to marshalling the return value to Java.
        static IntPtr EnsureBufferLength(int length)
        {
            EnsureThreadStatic();
            if (myMarshalBufferLength < length)
            {
                if (myMarshalBuffer != IntPtr.Zero)
                    Marshal.FreeHGlobal(myMarshalBuffer);
                myMarshalBuffer = Marshal.AllocHGlobal(length);
            }
            return myMarshalBuffer;
        }

        static Type GetTypeFromRuntimeType(RuntimeType runtimeType)
        {
            return myDeserializationLookup[runtimeType];
        }

        static RuntimeType GetRuntimeTypeFromType(Type type)
        {
            RuntimeType paramType;
            if (mySerializationLookup.TryGetValue(type, out paramType))
                return paramType;
            return RuntimeType.MonoObject;
        }

        static RuntimeType GetRuntimeType(object arg)
        {
            if (arg == null)
                return RuntimeType.Default;
            Type type = arg.GetType();
            return GetRuntimeTypeFromType(type);
        }

        // convenience function for void returns
        public static void Invoke(string fullyQualifiedName, string methodName, params object[] args)
        {
            Invoke<int>(fullyQualifiedName, 0, false, typeof(void), methodName, args, null);
        }

        public static void Invoke(string fullyQualifiedName, string methodName, object[] args, RuntimeType[] runtimeTypes)
        {
            Invoke<int>(fullyQualifiedName, 0, false, typeof(void), methodName, args, runtimeTypes);
        }

        // convenience function for when null parameters can don't cause ambiguous calls on the Java type
        public static T Invoke<T>(string fullyQualifiedName, string methodName, params object[] args)
        {
            return Invoke<T>(fullyQualifiedName, 0, false, typeof(T), methodName, args, null);
        }

        // explicitly define the argument types being passed to resolve ambiguous method calls on the Java method
        // due to null arguments
        // Ie, void foo(int, Intent) and void foo(int, Activity) have different method signatures, but if null is passed in
        // to the second argument, the method call is ambiguous
        public static T Invoke<T>(string fullyQualifiedName, string methodName, object[] args, RuntimeType[] runtimeTypes)
        {
            return Invoke<T>(fullyQualifiedName, 0, false, typeof(T), methodName, args, runtimeTypes);
        }

        // ultimately all invokes come through here
        // parameterTypes may have been explicitly provided or inferred
        internal static T Invoke<T>(string fullyQualifiedName, int objectId, bool isConstructor, Type returnType, string methodName, object[] args, RuntimeType[] runtimeTypes)
        {
            DebugLog("Invoking Java method.");
            // figure out the runtime types from either the explicit typing of the argument values
            if (runtimeTypes == null)
                runtimeTypes = new RuntimeType[args.Length];
            // fix up any runtime types that weren't specified.
            // nulls without specified types stay as "Default".
            // They are defaulted to a matching method on the Java end.
            for (int i = 0; i < runtimeTypes.Length; i++)
            {
                if (args[i] != null && runtimeTypes[i] == RuntimeType.Default)
                    runtimeTypes[i] = GetRuntimeType(args[i]);
            }

            RuntimeType runtimeReturnType = GetRuntimeTypeFromType(returnType);
            ResetStream();
            Serialize<string>(fullyQualifiedName);
            Serialize<int>(objectId);
            Serialize<bool>(isConstructor);
            Serialize<byte>((byte)runtimeReturnType);
            Serialize<string>(methodName);
            Serialize<int>(args.Length);
            SerializeParameters(args, runtimeTypes);
            MarshalStream();
            // ret is the amount of the myReturnBufferLength that actually contains data
            DebugLog("Invoking Java method");
            InvokeInternal(myMarshalBuffer);
            DebugLog("Returned from Java invocation");
            
            // the return buffer between languages is as follows:
            // Normal:
            // length | error | return value 
            // Exception:
            // length | error | exception string 
            int returnBufferLength = Marshal.ReadInt32(myMarshalBuffer);

            ResetStream();
            myStream.SetLength(returnBufferLength);
            Marshal.Copy(myMarshalBuffer, myStream.GetBuffer(), 0, returnBufferLength);
            // skip the return value
            myReader.ReadInt32();

            // check for error and deserialize the exception string to throw it
            bool success = Deserialize<bool>();
            if (!success)
            {
                string remoteString = Deserialize<string>();
                DebugLog("Exception thrown from Dalvik: {0}", remoteString);
                if (remoteString == null)
                    throw new RemotingException();
                throw new RemotingException(remoteString);
            }

            if (returnType == typeof(void))
                return default(T);

            // deserialize whatever we got and return
            return (T)DeserializeObject(runtimeReturnType);
        }

        static object DeserializeObject(RuntimeType runtimeType)
        {
            if (runtimeType == RuntimeType.Default)
            {
                DebugLog("Deserializing {0}: null", runtimeType);
                return null;
            }
            object ret = myDeserializeHandlers[(byte)runtimeType]();
            DebugLog("Deserializing {0}: {1}", runtimeType, (object)ret != null ? (object)ret : "null");
            return ret;
        }

        static T Deserialize<T>()
        {
            RuntimeType type = GetRuntimeTypeFromType(typeof(T));
            return (T)DeserializeObject(type);
        }

        static void SerializeNull()
        {
            mySerializeHandlers[(byte)RuntimeType.Int32](-1);
        }

        static void SerializeObject(object o, RuntimeType objectType)
        {
            DebugLog("Serializing {0}: {1}", objectType, o != null ? o : "null");
            // Unknown types are nulls with no explicit type associated
            // they may be either java objects, strings, or mono objects...
            // We won't know until it reaches the java end for resolution.
            // Don't need to serialize anything. An unknown type is an implicit null.
            if (o == null)
                SerializeNull();
            else
                mySerializeHandlers[(byte)objectType](o);
        }

        static void Serialize<T>(T value)
        {
            RuntimeType type = GetRuntimeTypeFromType(typeof(T));
            SerializeObject(value, type);
        }

        internal static void SerializeParameters(object[] parameters, RuntimeType[] parameterTypes)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                object parameter = parameters[i];
                RuntimeType actualRuntimeType = GetRuntimeType(parameter);
                if (actualRuntimeType == RuntimeType.Void)
                    throw new ArgumentException("Can't have a void parameter.");
                if (actualRuntimeType != parameterTypes[i] && actualRuntimeType != RuntimeType.Default)
                {
                    byte maxType = Math.Max((byte)actualRuntimeType, (byte)parameterTypes[i]);
                    byte minType = Math.Min((byte)actualRuntimeType, (byte)parameterTypes[i]);
                    if (maxType > (byte)RuntimeType.UInt64 || minType != maxType - 1)
                        throw new ArgumentException(String.Format("Can't convert {0} to {1} due to differing size.", actualRuntimeType, parameterTypes[i]));
                }
                // we write the parameter type as specified
                Serialize<byte>((byte)parameterTypes[i]);
                // but we use the *actual* type when serializing
                SerializeObject(parameters[i], parameterTypes[i]);
            }
        }

        static int myJavaReferenceCounter = 1;
        static Dictionary<int, object> myJavaReferences = new Dictionary<int, object>();

        internal static void RemoveMonoReference(int objectId)
        {
            myJavaReferences.Remove(objectId);
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static void InvokeInternal(IntPtr buffer);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static void SetMonoHooks(IntPtr ensureBufferLength, IntPtr handleInvoke);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern private static void Log(int priority, string tag, string message);

        public static void DebugLog(string format, params object[] args)
        {
            Log(LogPriority.Debug, "DalvikBridge", format, args);
        }

        public static void Log(LogPriority priority, string tag, string format, params object[] args)
        {
            format += "\n";
            string message = string.Format(format, args);
            Log((int)priority, tag, message);
        }

        public static string Echo(string echo)
        {
            DebugLog(echo);
            string ret = Invoke<string>("com.koushikdutta.monodalvikbridge.MonoBridge", "echo", echo);
            DebugLog("Return value from Dalvik: {0}", ret);
            return ret;
        }

        public static object New(string assemblyQualifiedName, object[] args)
        {
            Type type = Type.GetType(assemblyQualifiedName);

            return null;
        }

        public static void Initialize()
        {
            // the act of calling initialize will invoke the static constructor
            // which does all the real initialization.
            // set the callback pointers
            SetMonoHooks(Marshal.GetFunctionPointerForDelegate(myEnsureBufferLength), Marshal.GetFunctionPointerForDelegate(myHandleInvoke));
        }

        static EnsureBufferLengthHandler myEnsureBufferLength = new EnsureBufferLengthHandler(EnsureBufferLength);
        static HandleInvokeHandler myHandleInvoke = new HandleInvokeHandler(HandleInvoke);
    }

    public enum LogPriority : int
    {
        Verbose = 2,
        Debug = 3,
        Info = 4,
        Warn = 5,
        Error = 6,
        Assert = 7,
    }
}
