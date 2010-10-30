namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SslErrorHandler : android.os.Handler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SslErrorHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _cancel16092;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.SslErrorHandler.staticClass, "cancel", "()V", ref global::android.webkit.SslErrorHandler._cancel16092);
		}
		internal static global::MonoJavaBridge.MethodId _handleMessage16093;
		public override void handleMessage(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.SslErrorHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V", ref global::android.webkit.SslErrorHandler._handleMessage16093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _proceed16094;
		public virtual void proceed()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.SslErrorHandler.staticClass, "proceed", "()V", ref global::android.webkit.SslErrorHandler._proceed16094);
		}
		static SslErrorHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.SslErrorHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/SslErrorHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
