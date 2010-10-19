namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WindowManager_BadTokenException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WindowManager_BadTokenException()
		{
			InitJNI();
		}
		protected WindowManager_BadTokenException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_BadTokenException10344;
		public WindowManager_BadTokenException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_BadTokenException.staticClass, global::android.view.WindowManager_BadTokenException._WindowManager_BadTokenException10344);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_BadTokenException10345;
		public WindowManager_BadTokenException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_BadTokenException.staticClass, global::android.view.WindowManager_BadTokenException._WindowManager_BadTokenException10345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.WindowManager_BadTokenException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/WindowManager_BadTokenException"));
			global::android.view.WindowManager_BadTokenException._WindowManager_BadTokenException10344 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_BadTokenException.staticClass, "<init>", "()V");
			global::android.view.WindowManager_BadTokenException._WindowManager_BadTokenException10345 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_BadTokenException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
