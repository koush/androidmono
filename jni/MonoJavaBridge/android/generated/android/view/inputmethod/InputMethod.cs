namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.inputmethod.InputMethod_))]
	public interface InputMethod  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class InputMethod_ : java.lang.Object, InputMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputMethod_()
		{
			InitJNI();
		}
		internal InputMethod_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createSession10199;
		 void android.view.inputmethod.InputMethod.createSession(android.view.inputmethod.InputMethod_SessionCallback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._createSession10199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_.staticClass, global::android.view.inputmethod.InputMethod_._createSession10199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSessionEnabled10200;
		 void android.view.inputmethod.InputMethod.setSessionEnabled(android.view.inputmethod.InputMethodSession arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._setSessionEnabled10200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_.staticClass, global::android.view.inputmethod.InputMethod_._setSessionEnabled10200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _revokeSession10201;
		 void android.view.inputmethod.InputMethod.revokeSession(android.view.inputmethod.InputMethodSession arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._revokeSession10201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_.staticClass, global::android.view.inputmethod.InputMethod_._revokeSession10201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _attachToken10202;
		 void android.view.inputmethod.InputMethod.attachToken(android.os.IBinder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._attachToken10202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_.staticClass, global::android.view.inputmethod.InputMethod_._attachToken10202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindInput10203;
		 void android.view.inputmethod.InputMethod.bindInput(android.view.inputmethod.InputBinding arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._bindInput10203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_.staticClass, global::android.view.inputmethod.InputMethod_._bindInput10203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unbindInput10204;
		 void android.view.inputmethod.InputMethod.unbindInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._unbindInput10204);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_.staticClass, global::android.view.inputmethod.InputMethod_._unbindInput10204);
		}
		internal static global::MonoJavaBridge.MethodId _startInput10205;
		 void android.view.inputmethod.InputMethod.startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._startInput10205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_.staticClass, global::android.view.inputmethod.InputMethod_._startInput10205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _restartInput10206;
		 void android.view.inputmethod.InputMethod.restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._restartInput10206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_.staticClass, global::android.view.inputmethod.InputMethod_._restartInput10206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showSoftInput10207;
		 void android.view.inputmethod.InputMethod.showSoftInput(int arg0, android.os.ResultReceiver arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._showSoftInput10207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_.staticClass, global::android.view.inputmethod.InputMethod_._showSoftInput10207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hideSoftInput10208;
		 void android.view.inputmethod.InputMethod.hideSoftInput(int arg0, android.os.ResultReceiver arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_._hideSoftInput10208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethod_.staticClass, global::android.view.inputmethod.InputMethod_._hideSoftInput10208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethod_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethod"));
			global::android.view.inputmethod.InputMethod_._createSession10199 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V");
			global::android.view.inputmethod.InputMethod_._setSessionEnabled10200 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V");
			global::android.view.inputmethod.InputMethod_._revokeSession10201 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V");
			global::android.view.inputmethod.InputMethod_._attachToken10202 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "attachToken", "(Landroid/os/IBinder;)V");
			global::android.view.inputmethod.InputMethod_._bindInput10203 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V");
			global::android.view.inputmethod.InputMethod_._unbindInput10204 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "unbindInput", "()V");
			global::android.view.inputmethod.InputMethod_._startInput10205 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
			global::android.view.inputmethod.InputMethod_._restartInput10206 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
			global::android.view.inputmethod.InputMethod_._showSoftInput10207 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V");
			global::android.view.inputmethod.InputMethod_._hideSoftInput10208 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V");
		}
	}
}
