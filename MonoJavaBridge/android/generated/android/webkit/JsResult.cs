namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JsResult : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JsResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.JsResult.staticClass, "cancel", "()V", ref global::android.webkit.JsResult._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void confirm()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.JsResult.staticClass, "confirm", "()V", ref global::android.webkit.JsResult._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual void wakeUp()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.JsResult.staticClass, "wakeUp", "()V", ref global::android.webkit.JsResult._m2);
		}
		static JsResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.JsResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/JsResult"));
		}
	}
}
