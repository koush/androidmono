namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.inputmethod.InputMethodSession_))]
	public partial interface InputMethodSession  : global::MonoJavaBridge.IJavaObject 
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
	internal sealed partial class InputMethodSession_ : java.lang.Object, InputMethodSession
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal InputMethodSession_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.view.inputmethod.InputMethodSession.dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodSession_.staticClass, "dispatchKeyEvent", "(ILandroid/view/KeyEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V", ref global::android.view.inputmethod.InputMethodSession_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.view.inputmethod.InputMethodSession.dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodSession_.staticClass, "dispatchTrackballEvent", "(ILandroid/view/MotionEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V", ref global::android.view.inputmethod.InputMethodSession_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void android.view.inputmethod.InputMethodSession.finishInput()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodSession_.staticClass, "finishInput", "()V", ref global::android.view.inputmethod.InputMethodSession_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void android.view.inputmethod.InputMethodSession.updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodSession_.staticClass, "updateSelection", "(IIIIII)V", ref global::android.view.inputmethod.InputMethodSession_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void android.view.inputmethod.InputMethodSession.updateCursor(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodSession_.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V", ref global::android.view.inputmethod.InputMethodSession_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void android.view.inputmethod.InputMethodSession.displayCompletions(android.view.inputmethod.CompletionInfo[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodSession_.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V", ref global::android.view.inputmethod.InputMethodSession_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void android.view.inputmethod.InputMethodSession.updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodSession_.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V", ref global::android.view.inputmethod.InputMethodSession_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void android.view.inputmethod.InputMethodSession.appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodSession_.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V", ref global::android.view.inputmethod.InputMethodSession_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void android.view.inputmethod.InputMethodSession.toggleSoftInput(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodSession_.staticClass, "toggleSoftInput", "(II)V", ref global::android.view.inputmethod.InputMethodSession_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static InputMethodSession_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethodSession_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethodSession"));
		}
	}
}
