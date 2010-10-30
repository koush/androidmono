namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SystemClock : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SystemClock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _sleep10209;
		public static void sleep(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.SystemClock._sleep10209.native == global::System.IntPtr.Zero)
				global::android.os.SystemClock._sleep10209 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "sleep", "(J)V");
			@__env.CallStaticVoidMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._sleep10209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _uptimeMillis10210;
		public static long uptimeMillis()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.SystemClock._uptimeMillis10210.native == global::System.IntPtr.Zero)
				global::android.os.SystemClock._uptimeMillis10210 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "uptimeMillis", "()J");
			return @__env.CallStaticLongMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._uptimeMillis10210);
		}
		public static long CurrentTimeMillis
		{
			set
			{
				setCurrentTimeMillis(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentTimeMillis10211;
		public static bool setCurrentTimeMillis(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.SystemClock._setCurrentTimeMillis10211.native == global::System.IntPtr.Zero)
				global::android.os.SystemClock._setCurrentTimeMillis10211 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "setCurrentTimeMillis", "(J)Z");
			return @__env.CallStaticBooleanMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._setCurrentTimeMillis10211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elapsedRealtime10212;
		public static long elapsedRealtime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.SystemClock._elapsedRealtime10212.native == global::System.IntPtr.Zero)
				global::android.os.SystemClock._elapsedRealtime10212 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "elapsedRealtime", "()J");
			return @__env.CallStaticLongMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._elapsedRealtime10212);
		}
		internal static global::MonoJavaBridge.MethodId _currentThreadTimeMillis10213;
		public static long currentThreadTimeMillis()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.SystemClock._currentThreadTimeMillis10213.native == global::System.IntPtr.Zero)
				global::android.os.SystemClock._currentThreadTimeMillis10213 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "currentThreadTimeMillis", "()J");
			return @__env.CallStaticLongMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._currentThreadTimeMillis10213);
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
