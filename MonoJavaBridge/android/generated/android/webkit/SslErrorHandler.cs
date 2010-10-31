namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SslErrorHandler : android.os.Handler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SslErrorHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.SslErrorHandler.staticClass, "cancel", "()V", ref global::android.webkit.SslErrorHandler._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void handleMessage(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.SslErrorHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V", ref global::android.webkit.SslErrorHandler._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void proceed()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.SslErrorHandler.staticClass, "proceed", "()V", ref global::android.webkit.SslErrorHandler._m2);
		}
		static SslErrorHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.SslErrorHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/SslErrorHandler"));
		}
	}
}
