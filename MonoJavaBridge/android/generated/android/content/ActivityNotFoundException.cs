namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ActivityNotFoundException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ActivityNotFoundException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ActivityNotFoundException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ActivityNotFoundException._m0.native == global::System.IntPtr.Zero)
				global::android.content.ActivityNotFoundException._m0 = @__env.GetMethodIDNoThrow(global::android.content.ActivityNotFoundException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ActivityNotFoundException.staticClass, global::android.content.ActivityNotFoundException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ActivityNotFoundException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ActivityNotFoundException._m1.native == global::System.IntPtr.Zero)
				global::android.content.ActivityNotFoundException._m1 = @__env.GetMethodIDNoThrow(global::android.content.ActivityNotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ActivityNotFoundException.staticClass, global::android.content.ActivityNotFoundException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ActivityNotFoundException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ActivityNotFoundException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ActivityNotFoundException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
