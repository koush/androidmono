namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JsResult : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JsResult()
		{
			InitJNI();
		}
		protected JsResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _cancel10325;
		public virtual void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.JsResult._cancel10325);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.JsResult.staticClass, global::android.webkit.JsResult._cancel10325);
		}
		internal static global::MonoJavaBridge.MethodId _confirm10326;
		public virtual void confirm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.JsResult._confirm10326);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.JsResult.staticClass, global::android.webkit.JsResult._confirm10326);
		}
		internal static global::MonoJavaBridge.MethodId _wakeUp10327;
		protected virtual void wakeUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.JsResult._wakeUp10327);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.JsResult.staticClass, global::android.webkit.JsResult._wakeUp10327);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.JsResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/JsResult"));
			global::android.webkit.JsResult._cancel10325 = @__env.GetMethodIDNoThrow(global::android.webkit.JsResult.staticClass, "cancel", "()V");
			global::android.webkit.JsResult._confirm10326 = @__env.GetMethodIDNoThrow(global::android.webkit.JsResult.staticClass, "confirm", "()V");
			global::android.webkit.JsResult._wakeUp10327 = @__env.GetMethodIDNoThrow(global::android.webkit.JsResult.staticClass, "wakeUp", "()V");
		}
	}
}
