namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WindowManager_BadTokenException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WindowManager_BadTokenException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public WindowManager_BadTokenException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.WindowManager_BadTokenException._m0.native == global::System.IntPtr.Zero)
				global::android.view.WindowManager_BadTokenException._m0 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_BadTokenException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_BadTokenException.staticClass, global::android.view.WindowManager_BadTokenException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public WindowManager_BadTokenException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.WindowManager_BadTokenException._m1.native == global::System.IntPtr.Zero)
				global::android.view.WindowManager_BadTokenException._m1 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_BadTokenException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_BadTokenException.staticClass, global::android.view.WindowManager_BadTokenException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static WindowManager_BadTokenException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.WindowManager_BadTokenException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/WindowManager$BadTokenException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
