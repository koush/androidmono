using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Linq.Expressions;

namespace MonoJavaBridge
{
    public static partial class JavaBridge
    {
		private static bool mHasInitializedClassMethods = false;
        private static MethodId mGetName;
        private static MethodId mGetCanonicalName;
		private static MethodId mGetSuperclass; 

		private static void InitializeClassMethods(JNIEnv env)
		{
            if (!mHasInitializedClassMethods) {
                JniLocalHandle classClass = env.FindClass("java/lang/Class");
                mGetName = env.GetMethodID(classClass, "getName", "()Ljava/lang/String;");
                mGetCanonicalName = env.GetMethodID(classClass, "getCanonicalName", "()Ljava/lang/String;");
                mGetSuperclass = env.GetMethodID(classClass, "getSuperclass", "()Ljava/lang/Class;");
                mHasInitializedClassMethods = true;
            }
		}

		private static Dictionary<string, Wrapper> mWrappers = new Dictionary<string, Wrapper>();
		
		private class Wrapper
		{
			public Type Type;
			public ConstructorInfo Constructor;
		}

        private static string GetClassName(JNIEnv env, JniHandle clazz)
        {
            InitializeClassMethods(env);
            JniLocalHandle nameHandle = env.CallObjectMethod(clazz, mGetName);
            return env.ConvertToString(nameHandle);
        }

        private static string GetClassCanonicalName(JNIEnv env, JniHandle clazz)
        {
            InitializeClassMethods(env);
            JniLocalHandle nameHandle = env.CallObjectMethod(clazz, mGetCanonicalName);
            return env.ConvertToString(nameHandle);
        }

		private static JniLocalHandle GetSuperclass(JNIEnv env, JniHandle clazz)
		{
            InitializeClassMethods(env);
			return env.CallObjectMethod(clazz, mGetSuperclass);
		}

        public static string GetObjectClassName(JniHandle handle)
        {
            if (JniHandle.IsNull(handle))
                return null;
            
            JNIEnv env = JNIEnv.ThreadEnv;
            var classHandle = env.GetObjectClass(handle);
            return GetClassName(env, classHandle);
        }

        public static Type FindType(string typeName)
        {
            var type = Type.GetType(typeName);
            if (type != null)
                return type;
            foreach (string assembly in myAssemblies) {
                type = Type.GetType(typeName + "," + assembly);
                if (type != null)
                    return type;
            }
            return null;
        }
  
        // Convert a JavaObject or JavaException that is gauranteed to be a "final" class.
        // This does not introspect on the actual type of the returned value and search for a better match.
        public static T WrapJavaObjectSealedClass<T>(JniLocalHandle handle) where T: class, IJavaObject
        {
            if (JniHandle.IsNull(handle))
                return null;
            Wrapper wrapper = GetWrapper(typeof(T).FullName);
            var env = JNIEnv.ThreadEnv;
            var ret = wrapper.Constructor.Invoke(new object[] { env }) as T;
            ret.Init(env, handle);
            return ret;
        }
		
		private static Wrapper GetWrapper(string className)
		{
			Wrapper ret;
			if (mWrappers.TryGetValue(className, out ret))
				return ret;
			// see if we can register a wrapper
			Type type = FindType(className);
            if (type != null && type.IsAbstract)
            {
                type = FindType(className + "_");
            }
			if (type != null)
			{
				ret = new Wrapper();
				ret.Type = type;
				ret.Constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.CreateInstance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]{ typeof(JNIEnv) }, null);
				return ret;
			}
			return null;
		}

        private static Wrapper GetWrapper(JNIEnv env, JniHandle clazz)
		{
			// First see if we've already registered a wrapper or can register one now.
			string className = GetClassName(env, clazz);
			var ret = GetWrapper(className);
            if (ret != null)
                return ret;
            
            // We could not find an exact wrapper, so let's look up the type hierarchy.
            // The first one we find will be registered for this type.
            JniLocalHandle superclass = GetSuperclass(env, clazz);
            ret = GetWrapper(env, superclass);
            Wrapper thisWrapper = new Wrapper();
            thisWrapper.Constructor = ret.Constructor;
            thisWrapper.Type = ret.Type;
            mWrappers.Add(className, thisWrapper);
            return thisWrapper;
		}
        
        public static T[] WrapJavaArrayObject<T>(JniLocalHandle handle)
        {
            if (JniHandle.IsNull(handle))
                return null;
            
            JNIEnv env = JNIEnv.ThreadEnv;
            var length = env.GetArrayLength(handle);
            T[] ret = new T[length];
            
            Type type = typeof(T);
            if (type.IsPrimitive)
            {
                if (type == typeof (int) || type == typeof (uint))
                {
                    env.GetIntArrayRegion(handle, 0, length, ret as int[]);
                    return ret;
                }
                if (type == typeof (long) || type == typeof (ulong))
                {
                    env.GetLongArrayRegion(handle, 0, length, ret as long[]);
                    return ret;
                }
                if (type == typeof (bool))
                {
                    env.GetBooleanArrayRegion(handle, 0, length, ret as bool[]);
                    return ret;
                }
                if (type == typeof (double))
                {
                    env.GetDoubleArrayRegion(handle, 0, length, ret as double[]);
                    return ret;
                }
                if (type == typeof (byte) || type == typeof (sbyte))
                {
                    env.GetByteArrayRegion(handle, 0, length, ret as byte[]);
                    return ret;
                }
                if (type == typeof (char))
                {
                    env.GetCharArrayRegion(handle, 0, length, ret as char[]);
                    return ret;
                }
                if (type == typeof (short) || type == typeof (ushort))
                {
                    env.GetShortArrayRegion(handle, 0, length, ret as short[]);
                    return ret;
                }
                if (type == typeof (float))
                {
                    env.GetFloatArrayRegion(handle, 0, length, ret as float[]);
                    return ret;
                }
            }
            
            if (type.IsArray)
            {
                MethodInfo method = mWrapJavaArrayObject.MakeGenericMethod(type.GetElementType());
                for (int i = 0; i < length; i++)
                {
                    ret[i] = (T)method.Invoke(null, new object[] { env.GetObjectArrayElement(handle, i) });
                }
            }
            else if (type.IsInterface)
            {
                MethodInfo method = mWrapIJavaObject.MakeGenericMethod(type);
                for (int i = 0; i < length; i++)
                {
                    ret[i] = (T)method.Invoke(null, new object[] { env.GetObjectArrayElement(handle, i) });
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    ret.SetValue(WrapJavaObject(env.GetObjectArrayElement(handle, i)), i);
                }
            }
            
            return ret;
        }

        // Convert a JavaObject or JavaException to an instance.
        public static IJavaObject WrapJavaObject(JniLocalHandle handle)
        {
            if (JniHandle.IsNull(handle))
                return null;
            JNIEnv env = JNIEnv.ThreadEnv;
            JniLocalHandle clazz = env.GetObjectClass(handle);
            Wrapper wrapper = GetWrapper(env, clazz);
            var ret = wrapper.Constructor.Invoke(new object[] { env }) as IJavaObject;
            ret.Init(env, handle);
            return ret;
        }

        // Convert an interface type, T, to a JavaObject instance (if found). Otherwise, use an interface wrapper.
        public static T WrapIJavaObject<T>(JniLocalHandle handle) where T: class, IJavaObject
        {
            if (JniHandle.IsNull(handle))
                return null;

            // see if we can find the appropriate class instance
            Type type = typeof(T);
            string className = type.FullName;
            JNIEnv env = JNIEnv.ThreadEnv;
            
            JniLocalHandle clazz = env.GetObjectClass(handle);
            Wrapper wrapper = GetWrapper(env, clazz);
            if (!wrapper.Type.GetInterfaces().Contains(typeof(T)))
            {
                // failed to find the instance, so let's go with the interface wrapper
                wrapper = GetWrapper(className + "_");
            }
            
            var ret = wrapper.Constructor.Invoke(new object[] { env }) as T;
            ret.Init(env, handle);
            return ret;
        }

        public static Value ConvertToValue(IJavaObject o)
        {
			if (o == null)
				return Value.Null;

			Value ret = new Value();
            ret._object = o.JvmHandle;
            return ret;
        }
		
        public static string GetSignature(string typeName)
        {
            string low = typeName.ToLowerInvariant();
            int arr = low.LastIndexOf("[");
            string array = "";
            while (arr != -1)
            {
                array += "[";
                low = low.Substring(0, arr);
                arr = low.LastIndexOf("[");
            }
            switch (low)
            {
                case "bool":
                case "boolean":
                case "system.boolean":
                    return array + "Z";
                case "int":
                case "int32":
                case "system.int32":
                    return array + "I";
                case "double":
                case "system.double":
                    return array + "D";
                case "float":
                case "single":
                case "system.single":
                    return array + "F";
                case "short":
                case "int16":
                case "system.int16":
                    return array + "S";
                case "long":
                case "int64":
                case "system.int64":
                    return array + "J";
                case "char":
                case "system.char":
                    return array + "C";
                case "byte":
                case "system.byte":
                    return array + "B";
                case "void":
                case "system.void":
                    return array + "V";
                default:
                    return array + "L" + typeName.Substring(0, low.Length).Replace('.', '/') + ";";
            }
        }

        private static Value ConvertPrimitiveToValue(JNIEnv env, object obj, Type type)
        {
            if (type == typeof (int) || type == typeof (uint))
            {
                return ConvertToValue((int) obj);
            }
            if (type == typeof (long) || type == typeof (ulong))
            {
                return ConvertToValue((long) obj);
            }
            if (type == typeof (bool))
            {
                return ConvertToValue((bool) obj);
            }
            if (type == typeof (double))
            {
                return ConvertToValue((double) obj);
            }
            if (type == typeof (byte) || type == typeof (sbyte))
            {
                return ConvertToValue((byte) obj);
            }
            if (type == typeof (char))
            {
                return ConvertToValue((char) obj);
            }
            if (type == typeof (short) || type == typeof (ushort))
            {
                return ConvertToValue((short) obj);
            }
            if (type == typeof (float))
            {
                return ConvertToValue((float) obj);
            }
            throw new InvalidOperationException("Unknown simple type" + type);
        }
				
        private static Value ConvertToValue(JNIEnv env, object o)
        {
			// check if this is a primitive
			Type type = o.GetType();
			if (type.IsPrimitive)
			{
				return ConvertPrimitiveToValue(env, o, type);
			}
			
			// if it's not an array, cast to IJavaObject
			Array array = o as Array;
			if (array == null)
				return ConvertToValue(o);
			
			// it's an array, so create the proper array type and convert the individual elements recursively
			string classSignature = GetSignature(type.GetElementType().FullName);
			JniLocalHandle clazzHandle = env.FindClass(classSignature);
			JniLocalHandle arrayHandle = env.NewObjectArray(array.Length, clazzHandle, JniLocalHandle.Zero);
			for (int i = 0; i < array.Length; i++)
			{
				JniHandle element = new JniHandle();
				element.handle = ConvertToValue(env, array.GetValue(i))._object;
				env.SetObjectArrayElement(arrayHandle, i, element);
			}
			Value ret = new Value();
			ret._object = arrayHandle;
			return ret;
        }
		
		public static Value ConvertToValue(object o)
		{
			if (o == null)
				return Value.Null;

			IJavaObject i = o as IJavaObject;
            Value ret = new Value();
            ret._object = i.JvmHandle;
            return ret;
		}

        public static Value ConvertToValue<T>(T[] o)
        {
			if (o == null)
				return Value.Null;

			JNIEnv env = JNIEnv.ThreadEnv;
			return ConvertToValue(env, o);
        }

        public static Value ConvertToValue(int value)
        {
            var res = new Value { _int = value };
            return res;
        }

        public static Value ConvertToValue(bool value)
        {
            var res = new Value { _bool = value ? (byte)1 : (byte)0 };
            return res;
        }

        public static Value ConvertToValue(byte value)
        {
            var res = new Value { _byte = value };
            return res;
        }

        public static Value ConvertToValue(char value)
        {
            var res = new Value { _char = (short)value };
            return res;
        }

        public static Value ConvertToValue(short value)
        {
            var res = new Value { _short = value };
            return res;
        }

        public static Value ConvertToValue(long value)
        {
            var res = new Value { _long = value };
            return res;
        }

        public static Value ConvertToValue(float value)
        {
            var res = new Value { _float = value };
            return res;
        }

        public static Value ConvertToValue(double value)
        {
            var res = new Value { _double = value };
            return res;
        }

        public static Value ConvertToValue(JNIEnv env, int[] value)
        {
            if (value == null) {
                return Value.Null;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewIntArray(length);
            env.SetIntArrayRegion(res, 0, length, value);
            return new Value { _object = res };
        }

        public static Value ConvertToValue(JNIEnv env, long[] value)
        {
            if (value == null) {
                return Value.Null;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewLongArray(length);
            env.SetLongArrayRegion(res, 0, length, value);
            return new Value { _object = res };
        }

        public static Value ConvertToValue(JNIEnv env, short[] value)
        {
            if (value == null) {
                return Value.Null;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewShortArray(length);
            env.SetShortArrayRegion(res, 0, length, value);
            return new Value { _object = res };
        }

        public static Value ConvertToValue(JNIEnv env, byte[] value)
        {
            if (value == null) {
                return Value.Null;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewByteArray(length);
            env.SetByteArrayRegion(res, 0, length, value);
            return new Value { _object = res };
        }

        public static Value ConvertToValue(JNIEnv env, char[] value)
        {
            if (value == null) {
                return Value.Null;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewCharArray(length);
            env.SetCharArrayRegion(res, 0, length, value);
            return new Value { _object = res };
        }

        public static Value ConvertToValue(JNIEnv env, double[] value)
        {
            if (value == null) {
                return Value.Null;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewDoubleArray(length);
            env.SetDoubleArrayRegion(res, 0, length, value);
            return new Value { _object = res };
        }

        public static Value ConvertToValue(JNIEnv env, float[] value)
        {
            if (value == null) {
                return Value.Null;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewFloatArray(length);
            env.SetFloatArrayRegion(res, 0, length, value);
            return new Value { _object = res };
        }

        public static Value ConvertToValue(JNIEnv env, bool[] value)
        {
            if (value == null) {
                return Value.Null;
            }
            int length = value.Length;
            JniLocalHandle res = env.NewBooleanArray(length);
            env.SetBooleanArrayRegion(res, 0, length, value);
            return new Value { _object = res };
        }
    }
}
