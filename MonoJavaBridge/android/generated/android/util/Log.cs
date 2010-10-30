namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Log : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Log(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static int println(int arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m0.native == global::System.IntPtr.Zero)
				global::android.util.Log._m0 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "println", "(ILjava/lang/String;Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int i(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m1.native == global::System.IntPtr.Zero)
				global::android.util.Log._m1 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static int i(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m2.native == global::System.IntPtr.Zero)
				global::android.util.Log._m2 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "i", "(Ljava/lang/String;Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static int e(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m3.native == global::System.IntPtr.Zero)
				global::android.util.Log._m3 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int e(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m4.native == global::System.IntPtr.Zero)
				global::android.util.Log._m4 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "e", "(Ljava/lang/String;Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static int v(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m5.native == global::System.IntPtr.Zero)
				global::android.util.Log._m5 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static int v(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m6.native == global::System.IntPtr.Zero)
				global::android.util.Log._m6 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "v", "(Ljava/lang/String;Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static int w(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m7.native == global::System.IntPtr.Zero)
				global::android.util.Log._m7 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static int w(java.lang.String arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m8.native == global::System.IntPtr.Zero)
				global::android.util.Log._m8 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static int w(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m9.native == global::System.IntPtr.Zero)
				global::android.util.Log._m9 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static int d(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m10.native == global::System.IntPtr.Zero)
				global::android.util.Log._m10 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static int d(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m11.native == global::System.IntPtr.Zero)
				global::android.util.Log._m11 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "d", "(Ljava/lang/String;Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static bool isLoggable(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m12.native == global::System.IntPtr.Zero)
				global::android.util.Log._m12 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "isLoggable", "(Ljava/lang/String;I)Z");
			return @__env.CallStaticBooleanMethod(android.util.Log.staticClass, global::android.util.Log._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static int wtf(java.lang.String arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m13.native == global::System.IntPtr.Zero)
				global::android.util.Log._m13 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "wtf", "(Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static int wtf(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m14.native == global::System.IntPtr.Zero)
				global::android.util.Log._m14 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "wtf", "(Ljava/lang/String;Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static int wtf(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m15.native == global::System.IntPtr.Zero)
				global::android.util.Log._m15 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "wtf", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::java.lang.String getStackTraceString(java.lang.Throwable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._m16.native == global::System.IntPtr.Zero)
				global::android.util.Log._m16 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "getStackTraceString", "(Ljava/lang/Throwable;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.Log.staticClass, global::android.util.Log._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public static int VERBOSE
		{
			get
			{
				return 2;
			}
		}
		public static int DEBUG
		{
			get
			{
				return 3;
			}
		}
		public static int INFO
		{
			get
			{
				return 4;
			}
		}
		public static int WARN
		{
			get
			{
				return 5;
			}
		}
		public static int ERROR
		{
			get
			{
				return 6;
			}
		}
		public static int ASSERT
		{
			get
			{
				return 7;
			}
		}
		static Log()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Log.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Log"));
		}
		internal static void InitJNI()
		{
		}
	}
}
