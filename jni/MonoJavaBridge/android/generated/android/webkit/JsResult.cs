namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class JsResult : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static JsResult()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.JsResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.webkit.JsResult(@__env);
			}
		}
		protected JsResult(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancel9978;
		public virtual void cancel() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.JsResult._cancel9978);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.JsResult.staticClass, global::android.webkit.JsResult._cancel9978);
		}
		internal static global::net.sf.jni4net.jni.MethodId _confirm9979;
		public virtual void confirm() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.JsResult._confirm9979);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.JsResult.staticClass, global::android.webkit.JsResult._confirm9979);
		}
		internal static global::net.sf.jni4net.jni.MethodId _wakeUp9980;
		protected virtual void wakeUp() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.JsResult._wakeUp9980);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.JsResult.staticClass, global::android.webkit.JsResult._wakeUp9980);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.JsResult.staticClass = @__class;
			global::android.webkit.JsResult._cancel9978 = @__env.GetMethodID(global::android.webkit.JsResult.staticClass, "cancel", "()V");
			global::android.webkit.JsResult._confirm9979 = @__env.GetMethodID(global::android.webkit.JsResult.staticClass, "confirm", "()V");
			global::android.webkit.JsResult._wakeUp9980 = @__env.GetMethodID(global::android.webkit.JsResult.staticClass, "wakeUp", "()V");
		}
	}
}
