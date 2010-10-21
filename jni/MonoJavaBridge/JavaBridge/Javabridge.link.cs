using System;
using System.Runtime.InteropServices;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

using System.IO;
using System.Text;

using System.Collections.Generic;

namespace MonoJavaBridge
{
    public class LogWriter : TextWriter
    {
        public override Encoding Encoding {
            get {
                return Encoding.ASCII;
            }
        }

        StringBuilder buffer = new StringBuilder();
        public override void Write (char value)
        {
            if (value == '\n')
            {
                JavaBridge.Log(buffer.ToString());
                buffer = new StringBuilder();
            }
            else
            {
                buffer.Append(value);
            }
        }
        
        private LogWriter()
        {
        }
        
        static LogWriter myInstance = new LogWriter();
        public static LogWriter Instance
        {
            get
            {
                return myInstance;
            }
        }
    }
    
    public static partial class JavaBridge
    {
        public static void Log(string format, params object[] args)
        {
            string s = String.Format(format, args);
            IntPtr p = Marshal.StringToHGlobalAnsi(s);
            log(p);
            Marshal.FreeHGlobal(p);
        }
        
        static JavaVM myVM;
        static List<Type> myActions = new List<Type>();
        static List<Type> myFuncs = new List<Type>();
        static MethodInfo mWrapJavaObject = null;
        static MethodInfo myCLRHandleToObject = null;
        static MethodInfo myExpressionLambda = null;
        static MethodInfo mWrapJavaArrayObject = null;
        static MethodInfo mWrapIJavaObject = null;
        
        // this is to prevent an ambiguous method when searching for the wrapped method
        // even with exact parameters provided, I was getting ambiguous method exceptions
        public static Expression<TDelegate> LambdaPassthrough<TDelegate>(Expression body, params ParameterExpression[] parameters)
        {
            return Expression.Lambda<TDelegate>(body, parameters);
        }
        
        static JavaBridge()
        {
            Console.SetOut(LogWriter.Instance);
            Console.SetError(LogWriter.Instance);
            Console.WriteLine("Mono initialized.");

            //myStrongJ2CpUntyped = null;//typeof(net.sf.jni4net.utils.Convertor).GetMethod("StrongJ2CpUntyped");
            mWrapJavaObject = typeof(JavaBridge).GetMethod("WrapJavaObject", new Type[] { typeof(JniLocalHandle) });
            mWrapJavaArrayObject = typeof(JavaBridge).GetMethod("WrapJavaArrayObject", new Type[] { typeof(JniLocalHandle) });
            mWrapIJavaObject = typeof(JavaBridge).GetMethod("WrapIJavaObject", new Type[] { typeof(JniLocalHandle) });
            myCLRHandleToObject = typeof(JavaBridge).GetMethod("CLRHandleToObject");
            myExpressionLambda = typeof(JavaBridge).GetMethod("LambdaPassthrough");
            //Console.WriteLine(myExpressionLambda);
            
            myActions.Add(typeof(JniAction));
            myActions.Add(typeof(JniAction<int>).GetGenericTypeDefinition());
            myActions.Add(typeof(JniAction<int, int>).GetGenericTypeDefinition());
            myActions.Add(typeof(JniAction<int, int, int>).GetGenericTypeDefinition());
            myActions.Add(typeof(JniAction<int, int, int, int>).GetGenericTypeDefinition());
            myActions.Add(typeof(JniAction<int, int, int, int, int>).GetGenericTypeDefinition());
            myActions.Add(typeof(JniAction<int, int, int, int, int, int>).GetGenericTypeDefinition());
            myActions.Add(typeof(JniAction<int, int, int, int, int, int, int>).GetGenericTypeDefinition());
            myActions.Add(typeof(JniAction<int, int, int, int, int, int, int, int>).GetGenericTypeDefinition());
            myActions.Add(typeof(JniAction<int, int, int, int, int, int, int, int, int>).GetGenericTypeDefinition());
            myActions.Add(typeof(JniAction<int, int, int, int, int, int, int, int, int, int>).GetGenericTypeDefinition());

            myFuncs.Add(typeof(JniFunc<int>).GetGenericTypeDefinition());
            myFuncs.Add(typeof(JniFunc<int, int>).GetGenericTypeDefinition());
            myFuncs.Add(typeof(JniFunc<int, int, int>).GetGenericTypeDefinition());
            myFuncs.Add(typeof(JniFunc<int, int, int, int>).GetGenericTypeDefinition());
            myFuncs.Add(typeof(JniFunc<int, int, int, int, int>).GetGenericTypeDefinition());
            myFuncs.Add(typeof(JniFunc<int, int, int, int, int, int>).GetGenericTypeDefinition());
            myFuncs.Add(typeof(JniFunc<int, int, int, int, int, int, int>).GetGenericTypeDefinition());
            myFuncs.Add(typeof(JniFunc<int, int, int, int, int, int, int, int>).GetGenericTypeDefinition());
            myFuncs.Add(typeof(JniFunc<int, int, int, int, int, int, int, int, int>).GetGenericTypeDefinition());
            myFuncs.Add(typeof(JniFunc<int, int, int, int, int, int, int, int, int, int>).GetGenericTypeDefinition());
            myFuncs.Add(typeof(JniFunc<int, int, int, int, int, int, int, int, int, int, int>).GetGenericTypeDefinition());
        }
        
        static JNIEnv GetEnv() 
        {
            return JNIEnv.GetEnvForVm(myVM);
        }
        
        static void Initialize(IntPtr vm)
        {
            myVM = JNIEnv.defaultVM = new JavaVM(vm);
            Log("Setting JVM");
            var env = JNIEnv.GetEnvForVm(myVM);

            myMonoProxyClass = env.NewGlobalRef(env.FindClass("com/koushikdutta/monojavabridge/MonoProxy"));
            mySetGCHandle = env.GetMethodID(myMonoProxyClass, "setGCHandle", "(J)V");
            myGetGCHandle = env.GetMethodID(myMonoProxyClass, "getGCHandle", "()J");
        }
        
        static List<string> myAssemblies = new List<string>();

        static void LoadAssembly(IntPtr assemblyNamePtr)
        {
            String assemblyName = GetEnv().ConvertToString(assemblyNamePtr);
            Console.WriteLine("Loading Assembly: {0}", assemblyName);
            var assembly = Assembly.LoadFile(assemblyName);
            if (assembly != null)
                myAssemblies.Add(assembly.FullName);
            Console.WriteLine("Done loading assembly");
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        extern static void log(IntPtr p);

        [MethodImpl(MethodImplOptions.InternalCall)]
        extern static object mono_pointer_to_object(IntPtr ptr);
        
        [MethodImpl(MethodImplOptions.InternalCall)]
        extern static IntPtr mono_object_to_pointer(Object o);

        delegate void JniAction(IntPtr env, IntPtr obj);
        delegate void JniAction<T1>(IntPtr env, IntPtr obj, T1 t1);
        delegate void JniAction<T1, T2>(IntPtr env, IntPtr obj, T1 t1, T2 t2);
        delegate void JniAction<T1, T2, T3>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3);
        delegate void JniAction<T1, T2, T3, T4>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3, T4 t4);
        delegate void JniAction<T1, T2, T3, T4, T5>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
        delegate void JniAction<T1, T2, T3, T4, T5, T6>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6);
        delegate void JniAction<T1, T2, T3, T4, T5, T6, T7>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7);
        delegate void JniAction<T1, T2, T3, T4, T5, T6, T7, T8>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8);
        delegate void JniAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9);
        delegate void JniAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10);

        delegate TResult JniFunc<TResult>(IntPtr env, IntPtr obj);
        delegate TResult JniFunc<T1, TResult>(IntPtr env, IntPtr obj, T1 t1);
        delegate TResult JniFunc<T1, T2, TResult>(IntPtr env, IntPtr obj, T1 t1, T2 t2);
        delegate TResult JniFunc<T1, T2, T3, TResult>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3);
        delegate TResult JniFunc<T1, T2, T3, T4, TResult>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3, T4 t4);
        delegate TResult JniFunc<T1, T2, T3, T4, T5, TResult>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
        delegate TResult JniFunc<T1, T2, T3, T4, T5, T6, TResult>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6);
        delegate TResult JniFunc<T1, T2, T3, T4, T5, T6, T7, TResult>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7);
        delegate TResult JniFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8);
        delegate TResult JniFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9);
        delegate TResult JniFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(IntPtr env, IntPtr obj, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10);

        static Expression MarshalArgument(Type argumentType, ParameterExpression parameter)
        {
            // marshal if necessary, ie intptr to object
            if (argumentType == parameter.Type)
                return parameter;
            if (!argumentType.IsInterface)
                return Expression.Convert(Expression.Call(mWrapJavaObject, Expression.Convert(parameter, typeof(JniLocalHandle))), argumentType);
            var wrapObject = mWrapIJavaObject.MakeGenericMethod(argumentType);
            return Expression.Convert(Expression.Call(wrapObject, Expression.Convert(parameter, typeof(JniLocalHandle))), argumentType);
        }
        
        static JniGlobalHandle myMonoProxyClass;
        static MethodId myGetGCHandle;
        static MethodId mySetGCHandle;
        public static TRes CLRHandleToObject<TRes>(IntPtr obj) where TRes: JavaObject
        {
            var env = JNIEnv.ThreadEnv;
            long handleLong  = env.CallLongMethod(obj, myGetGCHandle);
            TRes ret;
            if (handleLong != 0)
            {
                ret = (TRes)GCHandle.FromIntPtr((IntPtr)handleLong).Target;
            }
            else
            {
                ret = (TRes)WrapJavaObject(obj);
                var handle = GCHandle.Alloc(ret, GCHandleType.Normal);
                env.CallVoidMethod(obj, mySetGCHandle, ConvertToValue((long)GCHandle.ToIntPtr(handle)));
            }
            return ret;
        }
        
        static Expression MarshalCLRHandle(ParameterExpression obj, Type type)
        {
            MethodInfo clrHandleToObject = myCLRHandleToObject.MakeGenericMethod(type);
            return Expression.Call(clrHandleToObject, obj);
        }
        
        static Type GetJNITypeForClrType(Type type)
        {
            if (type.IsPrimitive)
                return type;
            return typeof(IntPtr);
        }
        
        public static Delegate MakeWrapper(MethodInfo method)
        {
            // first lets figure out the delegate we need to implement, and the lambda expression that needs to be constructed
            Type delegateType = null;
            var clrParameters = (from par in method.GetParameters() select par.ParameterType).ToArray();
            var jniParameters = (from par in clrParameters select GetJNITypeForClrType(par)).ToArray();
            List<Type> genericArguments = new List<Type>();
            genericArguments.AddRange(jniParameters);
            if (method.ReturnType != typeof(void))
            {
                genericArguments.Add(method.ReturnType);
                delegateType = myFuncs[genericArguments.Count - 1];
            }
            else
            {
                delegateType = myActions[genericArguments.Count];
            }
            if (method.ReturnType != typeof(void) || genericArguments.Count > 0)
                delegateType = delegateType.MakeGenericType(genericArguments.ToArray());
            Console.WriteLine("Constructed delegate type: {0}", delegateType);
            MethodInfo expressionMethodInfo = myExpressionLambda.MakeGenericMethod(delegateType);
            Console.WriteLine("Constructed Expression.Lambda<T>: {0}", expressionMethodInfo);
            
            // now let's construct the parameter list to the expression lambda
            var parameterExpressions = (from par in method.GetParameters() select Expression.Parameter(GetJNITypeForClrType(par.ParameterType), par.Name)).ToArray();
            List<ParameterExpression> fullParameterList = new List<ParameterExpression>();
            ParameterExpression env;
            fullParameterList.Add(env = Expression.Parameter(typeof(IntPtr), "env"));
            ParameterExpression obj;
            fullParameterList.Add(obj = Expression.Parameter(typeof(IntPtr), "obj"));
            // and now we have it
            fullParameterList.AddRange(parameterExpressions);
            
            // we need to marshal the arguments in parameterExpressions to what the method expects.
            var marshaledParameterExpressions = new Expression[clrParameters.Length];
            for (int i = 0; i < clrParameters.Length; i++)
            {
                marshaledParameterExpressions[i] = MarshalArgument(clrParameters[i], parameterExpressions[i]);
            }
            
            var methodExpression = Expression.Call(MarshalCLRHandle(obj, method.DeclaringType), method, marshaledParameterExpressions);
            Console.WriteLine("Method Expression: {0}", methodExpression);
            //var lambdaExpression = expressionMethodInfo.Invoke(null, new object[] { methodExpression, fullParameterList.ToArray() });
            var lambdaExpression = Expression.Lambda(delegateType, methodExpression, fullParameterList.ToArray());
            Console.WriteLine("Lambda Expression: {0}", lambdaExpression);
            
            //var del = (Delegate)lambdaExpressionCompileMethod.Invoke(lambdaExpression, null);
            
            return lambdaExpression.Compile();
        }

        public static void Link(IntPtr classHandle, IntPtr methodNameHandle, IntPtr methodSignatureHandle, IntPtr methodParametersHandle)
        {
            JNIEnv env = JNIEnv.GetEnvForVm(myVM);

            var methodName = env.ConvertToString(methodNameHandle);
            var methodSig = env.ConvertToString(methodSignatureHandle);
            var methodPars = methodParametersHandle == IntPtr.Zero ? null : env.ConvertToString(methodParametersHandle);
            string classCanonicalName = GetClassCanonicalName(env, classHandle);
            //Console.WriteLine("Linking java class method: {0}.{1}", classCanonicalName, methodName);
            Type type = FindType(classCanonicalName);
            if (type == null)
            {
                Console.WriteLine("Could not find clr type.");
                return;
            }
            
            //Console.WriteLine("Found clr type: {0}", type);
            
            Type[] parameterTypes = null;
            if (!string.IsNullOrEmpty(methodPars))
            {
                var parameterTypeStrings = methodPars.Split(',');
                parameterTypes = new Type[parameterTypeStrings.Length];
                for (int i = 0; i < parameterTypeStrings.Length; i++)
                {
                    parameterTypes[i] = FindType(parameterTypeStrings[i]);
                    if (parameterTypes[i] == null)
                        Console.WriteLine("Could not find {0}", parameterTypeStrings[i]);
                    //else 
                    //    Console.WriteLine("Found type {0}", parameterTypes[i]);
                }
            }
            
            var method = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly | BindingFlags.Instance, null, parameterTypes ?? new Type[] {}, null);
            Console.WriteLine("Linking Method: {0} to {1}", method, methodSig);
            var del = MakeWrapper(method);
            myLinks.Add(del);
            
            JNINativeMethod m = JNINativeMethod.Create(del, methodName, methodSig);
            m.Register(classHandle, env);
            Console.WriteLine("Registration complete");
        }
        static List<Delegate> myLinks = new List<Delegate>();

        /*
        public static void Attach(java.lang.Object o, IJvmProxy obj)
        {
            Console.WriteLine("attaching {0}", o);
            var env = JNIEnv.ThreadEnv;
            var handle = GCHandle.Alloc(o, GCHandleType.WeakTrackResurrection);
            env.CallVoidMethod(obj, mySetGCHandle, Convertor.ParPrimC2J((long)GCHandle.ToIntPtr(handle)));
        }
        */
    }
}

