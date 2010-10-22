namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.inputmethod.InputMethodSession_EventCallback_))]
	public partial interface InputMethodSession_EventCallback  : global::MonoJavaBridge.IJavaObject 
	{
		void finishedEvent(int arg0, bool arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.inputmethod.InputMethodSession_EventCallback))]
	public sealed partial class InputMethodSession_EventCallback_ : java.lang.Object, InputMethodSession_EventCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputMethodSession_EventCallback_()
		{
			InitJNI();
		}
		internal InputMethodSession_EventCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finishedEvent15896;
		 void android.view.inputmethod.InputMethodSession_EventCallback.finishedEvent(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_EventCallback_._finishedEvent15896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_EventCallback_.staticClass, global::android.view.inputmethod.InputMethodSession_EventCallback_._finishedEvent15896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethodSession_EventCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethodSession_EventCallback"));
			global::android.view.inputmethod.InputMethodSession_EventCallback_._finishedEvent15896 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodSession_EventCallback_.staticClass, "finishedEvent", "(IZ)V");
		}
	}
}
