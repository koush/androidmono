namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Array : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Array()
		{
			InitJNI();
		}
		internal Array(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get15370;
		public static global::java.lang.Object get(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._get15370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getLength15371;
		public static int getLength(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getLength15371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean15372;
		public static bool getBoolean(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getBoolean15372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByte15373;
		public static byte getByte(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getByte15373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getShort15374;
		public static short getShort(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getShort15374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChar15375;
		public static char getChar(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getChar15375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt15376;
		public static int getInt(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getInt15376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong15377;
		public static long getLong(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getLong15377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat15378;
		public static float getFloat(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getFloat15378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble15379;
		public static double getDouble(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getDouble15379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newInstance15380;
		public static global::java.lang.Object newInstance(java.lang.Class arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._newInstance15380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance15381;
		public static global::java.lang.Object newInstance(java.lang.Class arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._newInstance15381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set15382;
		public static void set(java.lang.Object arg0, int arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._set15382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean15383;
		public static void setBoolean(java.lang.Object arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setBoolean15383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setByte15384;
		public static void setByte(java.lang.Object arg0, int arg1, byte arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setByte15384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setChar15385;
		public static void setChar(java.lang.Object arg0, int arg1, char arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setChar15385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setShort15386;
		public static void setShort(java.lang.Object arg0, int arg1, short arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setShort15386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setInt15387;
		public static void setInt(java.lang.Object arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setInt15387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setLong15388;
		public static void setLong(java.lang.Object arg0, int arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setLong15388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat15389;
		public static void setFloat(java.lang.Object arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setFloat15389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble15390;
		public static void setDouble(java.lang.Object arg0, int arg1, double arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setDouble15390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Array.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Array"));
			global::java.lang.reflect.Array._get15370 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "get", "(Ljava/lang/Object;I)Ljava/lang/Object;");
			global::java.lang.reflect.Array._getLength15371 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getLength", "(Ljava/lang/Object;)I");
			global::java.lang.reflect.Array._getBoolean15372 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getBoolean", "(Ljava/lang/Object;I)Z");
			global::java.lang.reflect.Array._getByte15373 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getByte", "(Ljava/lang/Object;I)B");
			global::java.lang.reflect.Array._getShort15374 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getShort", "(Ljava/lang/Object;I)S");
			global::java.lang.reflect.Array._getChar15375 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getChar", "(Ljava/lang/Object;I)C");
			global::java.lang.reflect.Array._getInt15376 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getInt", "(Ljava/lang/Object;I)I");
			global::java.lang.reflect.Array._getLong15377 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getLong", "(Ljava/lang/Object;I)J");
			global::java.lang.reflect.Array._getFloat15378 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getFloat", "(Ljava/lang/Object;I)F");
			global::java.lang.reflect.Array._getDouble15379 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getDouble", "(Ljava/lang/Object;I)D");
			global::java.lang.reflect.Array._newInstance15380 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "newInstance", "(Ljava/lang/Class;[I)Ljava/lang/Object;");
			global::java.lang.reflect.Array._newInstance15381 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "newInstance", "(Ljava/lang/Class;I)Ljava/lang/Object;");
			global::java.lang.reflect.Array._set15382 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "set", "(Ljava/lang/Object;ILjava/lang/Object;)V");
			global::java.lang.reflect.Array._setBoolean15383 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setBoolean", "(Ljava/lang/Object;IZ)V");
			global::java.lang.reflect.Array._setByte15384 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setByte", "(Ljava/lang/Object;IB)V");
			global::java.lang.reflect.Array._setChar15385 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setChar", "(Ljava/lang/Object;IC)V");
			global::java.lang.reflect.Array._setShort15386 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setShort", "(Ljava/lang/Object;IS)V");
			global::java.lang.reflect.Array._setInt15387 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setInt", "(Ljava/lang/Object;II)V");
			global::java.lang.reflect.Array._setLong15388 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setLong", "(Ljava/lang/Object;IJ)V");
			global::java.lang.reflect.Array._setFloat15389 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setFloat", "(Ljava/lang/Object;IF)V");
			global::java.lang.reflect.Array._setDouble15390 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setDouble", "(Ljava/lang/Object;ID)V");
		}
	}
}
