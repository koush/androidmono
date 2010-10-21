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
		internal static global::MonoJavaBridge.MethodId _get20892;
		public static global::java.lang.Object get(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._get20892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getLength20893;
		public static int getLength(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getLength20893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean20894;
		public static bool getBoolean(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getBoolean20894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByte20895;
		public static byte getByte(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getByte20895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getShort20896;
		public static short getShort(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getShort20896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChar20897;
		public static char getChar(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getChar20897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt20898;
		public static int getInt(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getInt20898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong20899;
		public static long getLong(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getLong20899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat20900;
		public static float getFloat(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getFloat20900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble20901;
		public static double getDouble(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._getDouble20901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newInstance20902;
		public static global::java.lang.Object newInstance(java.lang.Class arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._newInstance20902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance20903;
		public static global::java.lang.Object newInstance(java.lang.Class arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._newInstance20903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set20904;
		public static void set(java.lang.Object arg0, int arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._set20904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean20905;
		public static void setBoolean(java.lang.Object arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setBoolean20905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setByte20906;
		public static void setByte(java.lang.Object arg0, int arg1, byte arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setByte20906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setChar20907;
		public static void setChar(java.lang.Object arg0, int arg1, char arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setChar20907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setShort20908;
		public static void setShort(java.lang.Object arg0, int arg1, short arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setShort20908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setInt20909;
		public static void setInt(java.lang.Object arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setInt20909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setLong20910;
		public static void setLong(java.lang.Object arg0, int arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setLong20910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat20911;
		public static void setFloat(java.lang.Object arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setFloat20911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble20912;
		public static void setDouble(java.lang.Object arg0, int arg1, double arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._setDouble20912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Array.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Array"));
			global::java.lang.reflect.Array._get20892 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "get", "(Ljava/lang/Object;I)Ljava/lang/Object;");
			global::java.lang.reflect.Array._getLength20893 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getLength", "(Ljava/lang/Object;)I");
			global::java.lang.reflect.Array._getBoolean20894 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getBoolean", "(Ljava/lang/Object;I)Z");
			global::java.lang.reflect.Array._getByte20895 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getByte", "(Ljava/lang/Object;I)B");
			global::java.lang.reflect.Array._getShort20896 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getShort", "(Ljava/lang/Object;I)S");
			global::java.lang.reflect.Array._getChar20897 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getChar", "(Ljava/lang/Object;I)C");
			global::java.lang.reflect.Array._getInt20898 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getInt", "(Ljava/lang/Object;I)I");
			global::java.lang.reflect.Array._getLong20899 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getLong", "(Ljava/lang/Object;I)J");
			global::java.lang.reflect.Array._getFloat20900 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getFloat", "(Ljava/lang/Object;I)F");
			global::java.lang.reflect.Array._getDouble20901 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getDouble", "(Ljava/lang/Object;I)D");
			global::java.lang.reflect.Array._newInstance20902 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "newInstance", "(Ljava/lang/Class;[I)Ljava/lang/Object;");
			global::java.lang.reflect.Array._newInstance20903 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "newInstance", "(Ljava/lang/Class;I)Ljava/lang/Object;");
			global::java.lang.reflect.Array._set20904 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "set", "(Ljava/lang/Object;ILjava/lang/Object;)V");
			global::java.lang.reflect.Array._setBoolean20905 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setBoolean", "(Ljava/lang/Object;IZ)V");
			global::java.lang.reflect.Array._setByte20906 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setByte", "(Ljava/lang/Object;IB)V");
			global::java.lang.reflect.Array._setChar20907 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setChar", "(Ljava/lang/Object;IC)V");
			global::java.lang.reflect.Array._setShort20908 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setShort", "(Ljava/lang/Object;IS)V");
			global::java.lang.reflect.Array._setInt20909 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setInt", "(Ljava/lang/Object;II)V");
			global::java.lang.reflect.Array._setLong20910 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setLong", "(Ljava/lang/Object;IJ)V");
			global::java.lang.reflect.Array._setFloat20911 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setFloat", "(Ljava/lang/Object;IF)V");
			global::java.lang.reflect.Array._setDouble20912 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setDouble", "(Ljava/lang/Object;ID)V");
		}
	}
}
