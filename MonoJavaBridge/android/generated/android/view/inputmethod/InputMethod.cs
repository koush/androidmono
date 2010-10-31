namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.inputmethod.InputMethod_))]
	public partial interface InputMethod  : global::MonoJavaBridge.IJavaObject 
	{
		void createSession(android.view.inputmethod.InputMethod_SessionCallback arg0);
		void setSessionEnabled(android.view.inputmethod.InputMethodSession arg0, bool arg1);
		void revokeSession(android.view.inputmethod.InputMethodSession arg0);
		void attachToken(android.os.IBinder arg0);
		void bindInput(android.view.inputmethod.InputBinding arg0);
		void unbindInput();
		void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
		void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
		void showSoftInput(int arg0, android.os.ResultReceiver arg1);
		void hideSoftInput(int arg0, android.os.ResultReceiver arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.inputmethod.InputMethod))]
	internal sealed partial class InputMethod_ : java.lang.Object, InputMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal InputMethod_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.view.inputmethod.InputMethod.createSession(android.view.inputmethod.InputMethod_SessionCallback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethod_.staticClass, "createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V", ref global::android.view.inputmethod.InputMethod_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.view.inputmethod.InputMethod.setSessionEnabled(android.view.inputmethod.InputMethodSession arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethod_.staticClass, "setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V", ref global::android.view.inputmethod.InputMethod_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void android.view.inputmethod.InputMethod.revokeSession(android.view.inputmethod.InputMethodSession arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethod_.staticClass, "revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V", ref global::android.view.inputmethod.InputMethod_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void android.view.inputmethod.InputMethod.attachToken(android.os.IBinder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethod_.staticClass, "attachToken", "(Landroid/os/IBinder;)V", ref global::android.view.inputmethod.InputMethod_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void android.view.inputmethod.InputMethod.bindInput(android.view.inputmethod.InputBinding arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethod_.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V", ref global::android.view.inputmethod.InputMethod_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void android.view.inputmethod.InputMethod.unbindInput()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethod_.staticClass, "unbindInput", "()V", ref global::android.view.inputmethod.InputMethod_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void android.view.inputmethod.InputMethod.startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethod_.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V", ref global::android.view.inputmethod.InputMethod_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void android.view.inputmethod.InputMethod.restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethod_.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V", ref global::android.view.inputmethod.InputMethod_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void android.view.inputmethod.InputMethod.showSoftInput(int arg0, android.os.ResultReceiver arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethod_.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V", ref global::android.view.inputmethod.InputMethod_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void android.view.inputmethod.InputMethod.hideSoftInput(int arg0, android.os.ResultReceiver arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethod_.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V", ref global::android.view.inputmethod.InputMethod_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static InputMethod_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethod_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethod"));
		}
	}
}
