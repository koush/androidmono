namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpAuthHandler : android.os.Handler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpAuthHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _cancel16051;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.HttpAuthHandler._cancel16051.native == global::System.IntPtr.Zero)
				global::android.webkit.HttpAuthHandler._cancel16051 = @__env.GetMethodIDNoThrow(global::android.webkit.HttpAuthHandler.staticClass, "cancel", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.HttpAuthHandler.staticClass, global::android.webkit.HttpAuthHandler._cancel16051);
		}
		internal static global::MonoJavaBridge.MethodId _handleMessage16052;
		public override void handleMessage(android.os.Message arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.HttpAuthHandler._handleMessage16052.native == global::System.IntPtr.Zero)
				global::android.webkit.HttpAuthHandler._handleMessage16052 = @__env.GetMethodIDNoThrow(global::android.webkit.HttpAuthHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.HttpAuthHandler.staticClass, global::android.webkit.HttpAuthHandler._handleMessage16052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _proceed16053;
		public virtual void proceed(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.HttpAuthHandler._proceed16053.native == global::System.IntPtr.Zero)
				global::android.webkit.HttpAuthHandler._proceed16053 = @__env.GetMethodIDNoThrow(global::android.webkit.HttpAuthHandler.staticClass, "proceed", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.HttpAuthHandler.staticClass, global::android.webkit.HttpAuthHandler._proceed16053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _useHttpAuthUsernamePassword16054;
		public virtual bool useHttpAuthUsernamePassword()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.HttpAuthHandler._useHttpAuthUsernamePassword16054.native == global::System.IntPtr.Zero)
				global::android.webkit.HttpAuthHandler._useHttpAuthUsernamePassword16054 = @__env.GetMethodIDNoThrow(global::android.webkit.HttpAuthHandler.staticClass, "useHttpAuthUsernamePassword", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.HttpAuthHandler.staticClass, global::android.webkit.HttpAuthHandler._useHttpAuthUsernamePassword16054);
		}
		static HttpAuthHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.HttpAuthHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/HttpAuthHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
