namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.inputmethod.InputMethod_SessionCallback_))]
	public interface InputMethod_SessionCallback  : global::MonoJavaBridge.IJavaObject 
	{
		void sessionCreated(android.view.inputmethod.InputMethodSession arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.inputmethod.InputMethod_SessionCallback))]
	public sealed partial class InputMethod_SessionCallback_ : java.lang.Object, InputMethod_SessionCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputMethod_SessionCallback_()
		{
			InitJNI();
		}
		internal InputMethod_SessionCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _sessionCreated10744;
		 void android.view.inputmethod.InputMethod_SessionCallback.sessionCreated(android.view.inputmethod.InputMethodSession arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_SessionCallback_._sessionCreated10744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_SessionCallback_.staticClass, global::android.view.inputmethod.InputMethod_SessionCallback_._sessionCreated10744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethod_SessionCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethod_SessionCallback"));
			global::android.view.inputmethod.InputMethod_SessionCallback_._sessionCreated10744 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_SessionCallback_.staticClass, "sessionCreated", "(Landroid/view/inputmethod/InputMethodSession;)V");
		}
	}
}
