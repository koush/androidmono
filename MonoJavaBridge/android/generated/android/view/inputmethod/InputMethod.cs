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
		internal static global::MonoJavaBridge.MethodId _createSession15914;
		void android.view.inputmethod.InputMethod.createSession(android.view.inputmethod.InputMethod_SessionCallback arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._createSession15914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSessionEnabled15915;
		void android.view.inputmethod.InputMethod.setSessionEnabled(android.view.inputmethod.InputMethodSession arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._setSessionEnabled15915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _revokeSession15916;
		void android.view.inputmethod.InputMethod.revokeSession(android.view.inputmethod.InputMethodSession arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._revokeSession15916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _attachToken15917;
		void android.view.inputmethod.InputMethod.attachToken(android.os.IBinder arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._attachToken15917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindInput15918;
		void android.view.inputmethod.InputMethod.bindInput(android.view.inputmethod.InputBinding arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._bindInput15918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unbindInput15919;
		void android.view.inputmethod.InputMethod.unbindInput()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._unbindInput15919);
		}
		internal static global::MonoJavaBridge.MethodId _startInput15920;
		void android.view.inputmethod.InputMethod.startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._startInput15920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _restartInput15921;
		void android.view.inputmethod.InputMethod.restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._restartInput15921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showSoftInput15922;
		void android.view.inputmethod.InputMethod.showSoftInput(int arg0, android.os.ResultReceiver arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._showSoftInput15922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hideSoftInput15923;
		void android.view.inputmethod.InputMethod.hideSoftInput(int arg0, android.os.ResultReceiver arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._hideSoftInput15923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static InputMethod_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethod_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethod"));
			global::android.view.inputmethod.InputMethod_._createSession15914 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V");
			global::android.view.inputmethod.InputMethod_._setSessionEnabled15915 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V");
			global::android.view.inputmethod.InputMethod_._revokeSession15916 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V");
			global::android.view.inputmethod.InputMethod_._attachToken15917 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "attachToken", "(Landroid/os/IBinder;)V");
			global::android.view.inputmethod.InputMethod_._bindInput15918 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V");
			global::android.view.inputmethod.InputMethod_._unbindInput15919 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "unbindInput", "()V");
			global::android.view.inputmethod.InputMethod_._startInput15920 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
			global::android.view.inputmethod.InputMethod_._restartInput15921 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
			global::android.view.inputmethod.InputMethod_._showSoftInput15922 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V");
			global::android.view.inputmethod.InputMethod_._hideSoftInput15923 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
