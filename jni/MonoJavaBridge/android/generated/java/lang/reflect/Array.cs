namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Array : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Array(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21011;
		public static global::java.lang.Object get(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._get21011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getLength21012;
		public static int getLength(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getLength21012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean21013;
		public static bool getBoolean(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getBoolean21013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByte21014;
		public static byte getByte(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getByte21014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getShort21015;
		public static short getShort(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getShort21015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChar21016;
		public static char getChar(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getChar21016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt21017;
		public static int getInt(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getInt21017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong21018;
		public static long getLong(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getLong21018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat21019;
		public static float getFloat(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getFloat21019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble21020;
		public static double getDouble(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getDouble21020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newInstance21021;
		public static global::java.lang.Object newInstance(java.lang.Class arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._newInstance21021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance21022;
		public static global::java.lang.Object newInstance(java.lang.Class arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._newInstance21022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set21023;
		public static void set(java.lang.Object arg0, int arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._set21023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean21024;
		public static void setBoolean(java.lang.Object arg0, int arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setBoolean21024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setByte21025;
		public static void setByte(java.lang.Object arg0, int arg1, byte arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setByte21025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setChar21026;
		public static void setChar(java.lang.Object arg0, int arg1, char arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setChar21026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setShort21027;
		public static void setShort(java.lang.Object arg0, int arg1, short arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setShort21027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setInt21028;
		public static void setInt(java.lang.Object arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setInt21028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setLong21029;
		public static void setLong(java.lang.Object arg0, int arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setLong21029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat21030;
		public static void setFloat(java.lang.Object arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setFloat21030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble21031;
		public static void setDouble(java.lang.Object arg0, int arg1, double arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setDouble21031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static Array()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Array.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Array"));
			global::java.lang.reflect.Array._get21011 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "get", "(Ljava/lang/Object;I)Ljava/lang/Object;");
			global::java.lang.reflect.Array._getLength21012 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getLength", "(Ljava/lang/Object;)I");
			global::java.lang.reflect.Array._getBoolean21013 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getBoolean", "(Ljava/lang/Object;I)Z");
			global::java.lang.reflect.Array._getByte21014 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getByte", "(Ljava/lang/Object;I)B");
			global::java.lang.reflect.Array._getShort21015 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getShort", "(Ljava/lang/Object;I)S");
			global::java.lang.reflect.Array._getChar21016 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getChar", "(Ljava/lang/Object;I)C");
			global::java.lang.reflect.Array._getInt21017 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getInt", "(Ljava/lang/Object;I)I");
			global::java.lang.reflect.Array._getLong21018 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getLong", "(Ljava/lang/Object;I)J");
			global::java.lang.reflect.Array._getFloat21019 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getFloat", "(Ljava/lang/Object;I)F");
			global::java.lang.reflect.Array._getDouble21020 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getDouble", "(Ljava/lang/Object;I)D");
			global::java.lang.reflect.Array._newInstance21021 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "newInstance", "(Ljava/lang/Class;[I)Ljava/lang/Object;");
			global::java.lang.reflect.Array._newInstance21022 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "newInstance", "(Ljava/lang/Class;I)Ljava/lang/Object;");
			global::java.lang.reflect.Array._set21023 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "set", "(Ljava/lang/Object;ILjava/lang/Object;)V");
			global::java.lang.reflect.Array._setBoolean21024 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setBoolean", "(Ljava/lang/Object;IZ)V");
			global::java.lang.reflect.Array._setByte21025 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setByte", "(Ljava/lang/Object;IB)V");
			global::java.lang.reflect.Array._setChar21026 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setChar", "(Ljava/lang/Object;IC)V");
			global::java.lang.reflect.Array._setShort21027 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setShort", "(Ljava/lang/Object;IS)V");
			global::java.lang.reflect.Array._setInt21028 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setInt", "(Ljava/lang/Object;II)V");
			global::java.lang.reflect.Array._setLong21029 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setLong", "(Ljava/lang/Object;IJ)V");
			global::java.lang.reflect.Array._setFloat21030 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setFloat", "(Ljava/lang/Object;IF)V");
			global::java.lang.reflect.Array._setDouble21031 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setDouble", "(Ljava/lang/Object;ID)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
