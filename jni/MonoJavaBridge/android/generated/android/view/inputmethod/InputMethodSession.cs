namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.inputmethod.InputMethodSession_))]
	public interface InputMethodSession  : global::MonoJavaBridge.IJavaObject 
	{
		void dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2);
		void dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2);
		void finishInput();
		void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);
		void updateCursor(android.graphics.Rect arg0);
		void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0);
		void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1);
		void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1);
		void toggleSoftInput(int arg0, int arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.inputmethod.InputMethodSession))]
	public sealed partial class InputMethodSession_ : java.lang.Object, InputMethodSession
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputMethodSession_()
		{
			InitJNI();
		}
		internal InputMethodSession_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent10252;
		 void android.view.inputmethod.InputMethodSession.dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_._dispatchKeyEvent10252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_.staticClass, global::android.view.inputmethod.InputMethodSession_._dispatchKeyEvent10252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent10253;
		 void android.view.inputmethod.InputMethodSession.dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_._dispatchTrackballEvent10253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_.staticClass, global::android.view.inputmethod.InputMethodSession_._dispatchTrackballEvent10253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _finishInput10254;
		 void android.view.inputmethod.InputMethodSession.finishInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_._finishInput10254);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_.staticClass, global::android.view.inputmethod.InputMethodSession_._finishInput10254);
		}
		internal static global::MonoJavaBridge.MethodId _updateSelection10255;
		 void android.view.inputmethod.InputMethodSession.updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_._updateSelection10255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_.staticClass, global::android.view.inputmethod.InputMethodSession_._updateSelection10255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _updateCursor10256;
		 void android.view.inputmethod.InputMethodSession.updateCursor(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_._updateCursor10256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_.staticClass, global::android.view.inputmethod.InputMethodSession_._updateCursor10256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _displayCompletions10257;
		 void android.view.inputmethod.InputMethodSession.displayCompletions(android.view.inputmethod.CompletionInfo[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_._displayCompletions10257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_.staticClass, global::android.view.inputmethod.InputMethodSession_._displayCompletions10257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateExtractedText10258;
		 void android.view.inputmethod.InputMethodSession.updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_._updateExtractedText10258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_.staticClass, global::android.view.inputmethod.InputMethodSession_._updateExtractedText10258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _appPrivateCommand10259;
		 void android.view.inputmethod.InputMethodSession.appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_._appPrivateCommand10259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_.staticClass, global::android.view.inputmethod.InputMethodSession_._appPrivateCommand10259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toggleSoftInput10260;
		 void android.view.inputmethod.InputMethodSession.toggleSoftInput(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_._toggleSoftInput10260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodSession_.staticClass, global::android.view.inputmethod.InputMethodSession_._toggleSoftInput10260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethodSession_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethodSession"));
			global::android.view.inputmethod.InputMethodSession_._dispatchKeyEvent10252 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodSession_.staticClass, "dispatchKeyEvent", "(ILandroid/view/KeyEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V");
			global::android.view.inputmethod.InputMethodSession_._dispatchTrackballEvent10253 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodSession_.staticClass, "dispatchTrackballEvent", "(ILandroid/view/MotionEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V");
			global::android.view.inputmethod.InputMethodSession_._finishInput10254 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodSession_.staticClass, "finishInput", "()V");
			global::android.view.inputmethod.InputMethodSession_._updateSelection10255 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodSession_.staticClass, "updateSelection", "(IIIIII)V");
			global::android.view.inputmethod.InputMethodSession_._updateCursor10256 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodSession_.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V");
			global::android.view.inputmethod.InputMethodSession_._displayCompletions10257 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodSession_.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.view.inputmethod.InputMethodSession_._updateExtractedText10258 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodSession_.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V");
			global::android.view.inputmethod.InputMethodSession_._appPrivateCommand10259 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodSession_.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.view.inputmethod.InputMethodSession_._toggleSoftInput10260 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodSession_.staticClass, "toggleSoftInput", "(II)V");
		}
	}
}
