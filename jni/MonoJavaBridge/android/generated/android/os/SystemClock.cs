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
		internal static global::MonoJavaBridge.MethodId _sleep6728;
		public static void sleep(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._sleep6728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _uptimeMillis6729;
		public static long uptimeMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._uptimeMillis6729);
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentTimeMillis6730;
		public static bool setCurrentTimeMillis(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._setCurrentTimeMillis6730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elapsedRealtime6731;
		public static long elapsedRealtime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._elapsedRealtime6731);
		}
		internal static global::MonoJavaBridge.MethodId _currentThreadTimeMillis6732;
		public static long currentThreadTimeMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.SystemClock.staticClass, global::android.os.SystemClock._currentThreadTimeMillis6732);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.SystemClock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/SystemClock"));
			global::android.os.SystemClock._sleep6728 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "sleep", "(J)V");
			global::android.os.SystemClock._uptimeMillis6729 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "uptimeMillis", "()J");
			global::android.os.SystemClock._setCurrentTimeMillis6730 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "setCurrentTimeMillis", "(J)Z");
			global::android.os.SystemClock._elapsedRealtime6731 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "elapsedRealtime", "()J");
			global::android.os.SystemClock._currentThreadTimeMillis6732 = @__env.GetStaticMethodIDNoThrow(global::android.os.SystemClock.staticClass, "currentThreadTimeMillis", "()J");
		}
	}
}
