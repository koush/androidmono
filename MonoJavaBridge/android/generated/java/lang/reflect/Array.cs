namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Array : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Array(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.Object get(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m0.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m0 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "get", "(Ljava/lang/Object;I)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int getLength(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m1.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getLength", "(Ljava/lang/Object;)I");
			return @__env.CallStaticIntMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static bool getBoolean(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m2.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m2 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getBoolean", "(Ljava/lang/Object;I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static byte getByte(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m3.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m3 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getByte", "(Ljava/lang/Object;I)B");
			return @__env.CallStaticByteMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static short getShort(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m4.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m4 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getShort", "(Ljava/lang/Object;I)S");
			return @__env.CallStaticShortMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static char getChar(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m5.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m5 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getChar", "(Ljava/lang/Object;I)C");
			return @__env.CallStaticCharMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static int getInt(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m6.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m6 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getInt", "(Ljava/lang/Object;I)I");
			return @__env.CallStaticIntMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static long getLong(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m7.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m7 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getLong", "(Ljava/lang/Object;I)J");
			return @__env.CallStaticLongMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static float getFloat(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m8.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m8 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getFloat", "(Ljava/lang/Object;I)F");
			return @__env.CallStaticFloatMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static double getDouble(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m9.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m9 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "getDouble", "(Ljava/lang/Object;I)D");
			return @__env.CallStaticDoubleMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.lang.Object newInstance(java.lang.Class arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m10.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m10 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "newInstance", "(Ljava/lang/Class;[I)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.lang.Object newInstance(java.lang.Class arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m11.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m11 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "newInstance", "(Ljava/lang/Class;I)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void set(java.lang.Object arg0, int arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m12.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m12 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "set", "(Ljava/lang/Object;ILjava/lang/Object;)V");
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static void setBoolean(java.lang.Object arg0, int arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m13.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m13 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setBoolean", "(Ljava/lang/Object;IZ)V");
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static void setByte(java.lang.Object arg0, int arg1, byte arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m14.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m14 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setByte", "(Ljava/lang/Object;IB)V");
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static void setChar(java.lang.Object arg0, int arg1, char arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m15.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m15 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setChar", "(Ljava/lang/Object;IC)V");
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static void setShort(java.lang.Object arg0, int arg1, short arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m16.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m16 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setShort", "(Ljava/lang/Object;IS)V");
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static void setInt(java.lang.Object arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m17.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m17 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setInt", "(Ljava/lang/Object;II)V");
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static void setLong(java.lang.Object arg0, int arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m18.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m18 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setLong", "(Ljava/lang/Object;IJ)V");
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static void setFloat(java.lang.Object arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m19.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m19 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setFloat", "(Ljava/lang/Object;IF)V");
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static void setDouble(java.lang.Object arg0, int arg1, double arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Array._m20.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Array._m20 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Array.staticClass, "setDouble", "(Ljava/lang/Object;ID)V");
			@__env.CallStaticVoidMethod(java.lang.reflect.Array.staticClass, global::java.lang.reflect.Array._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static Array()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Array.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Array"));
		}
	}
}
