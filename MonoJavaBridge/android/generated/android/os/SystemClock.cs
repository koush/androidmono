namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SystemClock : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SystemClock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void sleep(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.SystemClock._m0.native == global::System.IntPtr.Zero)
				global::android.os.SystemClock._m0 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "sleep", "(J)V");
			@__env.CallStaticVoidMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static long uptimeMillis()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.SystemClock._m1.native == global::System.IntPtr.Zero)
				global::android.os.SystemClock._m1 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "uptimeMillis", "()J");
			return @__env.CallStaticLongMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._m1);
		}
		public static long CurrentTimeMillis
		{
			set
			{
				setCurrentTimeMillis(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static bool setCurrentTimeMillis(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.SystemClock._m2.native == global::System.IntPtr.Zero)
				global::android.os.SystemClock._m2 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "setCurrentTimeMillis", "(J)Z");
			return @__env.CallStaticBooleanMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static long elapsedRealtime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.SystemClock._m3.native == global::System.IntPtr.Zero)
				global::android.os.SystemClock._m3 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "elapsedRealtime", "()J");
			return @__env.CallStaticLongMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static long currentThreadTimeMillis()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.SystemClock._m4.native == global::System.IntPtr.Zero)
				global::android.os.SystemClock._m4 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "currentThreadTimeMillis", "()J");
			return @__env.CallStaticLongMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._m4);
		}
		static SystemClock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.SystemClock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/SystemClock"));
		}
		internal static void InitJNI()
		{
		}
	}
}
