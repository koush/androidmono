namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SystemClock : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SystemClock()
		{
			InitJNI();
		}
		internal SystemClock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _sleep10209;
		public static void sleep(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._sleep10209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _uptimeMillis10210;
		public static long uptimeMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._uptimeMillis10210);
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentTimeMillis10211;
		public static bool setCurrentTimeMillis(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._setCurrentTimeMillis10211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elapsedRealtime10212;
		public static long elapsedRealtime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._elapsedRealtime10212);
		}
		internal static global::MonoJavaBridge.MethodId _currentThreadTimeMillis10213;
		public static long currentThreadTimeMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._currentThreadTimeMillis10213);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.SystemClock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/SystemClock"));
			global::android.os.SystemClock._sleep10209 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "sleep", "(J)V");
			global::android.os.SystemClock._uptimeMillis10210 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "uptimeMillis", "()J");
			global::android.os.SystemClock._setCurrentTimeMillis10211 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "setCurrentTimeMillis", "(J)Z");
			global::android.os.SystemClock._elapsedRealtime10212 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "elapsedRealtime", "()J");
			global::android.os.SystemClock._currentThreadTimeMillis10213 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "currentThreadTimeMillis", "()J");
		}
	}
}
