namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JsPromptResult : android.webkit.JsResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JsPromptResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void confirm(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.JsPromptResult.staticClass, "confirm", "(Ljava/lang/String;)V", ref global::android.webkit.JsPromptResult._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static JsPromptResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.JsPromptResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/JsPromptResult"));
		}
	}
}
