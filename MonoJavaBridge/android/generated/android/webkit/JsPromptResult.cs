namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JsPromptResult : android.webkit.JsResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JsPromptResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _confirm16055;
		public virtual void confirm(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.JsPromptResult.staticClass, global::android.webkit.JsPromptResult._confirm16055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static JsPromptResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.JsPromptResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/JsPromptResult"));
			global::android.webkit.JsPromptResult._confirm16055 = @__env.GetMethodIDNoThrow(global::android.webkit.JsPromptResult.staticClass, "confirm", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
