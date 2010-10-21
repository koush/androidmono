namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ActivityNotFoundException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ActivityNotFoundException()
		{
			InitJNI();
		}
		protected ActivityNotFoundException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ActivityNotFoundException2557;
		public ActivityNotFoundException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ActivityNotFoundException.staticClass, global::android.content.ActivityNotFoundException._ActivityNotFoundException2557);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ActivityNotFoundException2558;
		public ActivityNotFoundException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ActivityNotFoundException.staticClass, global::android.content.ActivityNotFoundException._ActivityNotFoundException2558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ActivityNotFoundException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ActivityNotFoundException"));
			global::android.content.ActivityNotFoundException._ActivityNotFoundException2557 = @__env.GetMethodIDNoThrow(global::android.content.ActivityNotFoundException.staticClass, "<init>", "()V");
			global::android.content.ActivityNotFoundException._ActivityNotFoundException2558 = @__env.GetMethodIDNoThrow(global::android.content.ActivityNotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
