namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class JsPromptResult : android.webkit.JsResult
	{
		internal new static global::java.lang.Class staticClass;
		static JsPromptResult()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.JsPromptResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.webkit.JsPromptResult(@__env);
			}
		}
		protected JsPromptResult(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _confirm9977;
		public virtual void confirm(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.JsPromptResult._confirm9977, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.JsPromptResult.staticClass, global::android.webkit.JsPromptResult._confirm9977, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.JsPromptResult.staticClass = @__class;
			global::android.webkit.JsPromptResult._confirm9977 = @__env.GetMethodID(global::android.webkit.JsPromptResult.staticClass, "confirm", "(Ljava/lang/String;)V");
		}
	}
}
