namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JsPromptResult : android.webkit.JsResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JsPromptResult()
		{
			InitJNI();
		}
		protected JsPromptResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _confirm15970;
		public virtual void confirm(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.JsPromptResult._confirm15970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.JsPromptResult.staticClass, global::android.webkit.JsPromptResult._confirm15970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.JsPromptResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/JsPromptResult"));
			global::android.webkit.JsPromptResult._confirm15970 = @__env.GetMethodIDNoThrow(global::android.webkit.JsPromptResult.staticClass, "confirm", "(Ljava/lang/String;)V");
		}
	}
}
