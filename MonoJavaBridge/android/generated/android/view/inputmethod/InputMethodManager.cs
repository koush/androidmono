namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class InputMethodManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal InputMethodManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public bool isActive(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "isActive", "(Landroid/view/View;)Z", ref global::android.view.inputmethod.InputMethodManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public bool isActive()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "isActive", "()Z", ref global::android.view.inputmethod.InputMethodManager._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void restartInput(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "restartInput", "(Landroid/view/View;)V", ref global::android.view.inputmethod.InputMethodManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public bool showSoftInput(android.view.View arg0, int arg1, android.os.ResultReceiver arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInput", "(Landroid/view/View;ILandroid/os/ResultReceiver;)Z", ref global::android.view.inputmethod.InputMethodManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public bool showSoftInput(android.view.View arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInput", "(Landroid/view/View;I)Z", ref global::android.view.inputmethod.InputMethodManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void updateSelection(android.view.View arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "updateSelection", "(Landroid/view/View;IIII)V", ref global::android.view.inputmethod.InputMethodManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public void updateCursor(android.view.View arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "updateCursor", "(Landroid/view/View;IIII)V", ref global::android.view.inputmethod.InputMethodManager._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public void displayCompletions(android.view.View arg0, android.view.inputmethod.CompletionInfo[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "displayCompletions", "(Landroid/view/View;[Landroid/view/inputmethod/CompletionInfo;)V", ref global::android.view.inputmethod.InputMethodManager._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public void updateExtractedText(android.view.View arg0, int arg1, android.view.inputmethod.ExtractedText arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "updateExtractedText", "(Landroid/view/View;ILandroid/view/inputmethod/ExtractedText;)V", ref global::android.view.inputmethod.InputMethodManager._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public void toggleSoftInput(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "toggleSoftInput", "(II)V", ref global::android.view.inputmethod.InputMethodManager._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public bool isFullscreenMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "isFullscreenMode", "()Z", ref global::android.view.inputmethod.InputMethodManager._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public void showStatusIcon(android.os.IBinder arg0, java.lang.String arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "showStatusIcon", "(Landroid/os/IBinder;Ljava/lang/String;I)V", ref global::android.view.inputmethod.InputMethodManager._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public void hideStatusIcon(android.os.IBinder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "hideStatusIcon", "(Landroid/os/IBinder;)V", ref global::android.view.inputmethod.InputMethodManager._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List InputMethodList
		{
			get
			{
				return getInputMethodList();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::java.util.List getInputMethodList()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.view.inputmethod.InputMethodManager.staticClass, "getInputMethodList", "()Ljava/util/List;", ref global::android.view.inputmethod.InputMethodManager._m13) as java.util.List;
		}
		public new global::java.util.List EnabledInputMethodList
		{
			get
			{
				return getEnabledInputMethodList();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public global::java.util.List getEnabledInputMethodList()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.view.inputmethod.InputMethodManager.staticClass, "getEnabledInputMethodList", "()Ljava/util/List;", ref global::android.view.inputmethod.InputMethodManager._m14) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public bool isAcceptingText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "isAcceptingText", "()Z", ref global::android.view.inputmethod.InputMethodManager._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public bool hideSoftInputFromWindow(android.os.IBinder arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromWindow", "(Landroid/os/IBinder;I)Z", ref global::android.view.inputmethod.InputMethodManager._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public bool hideSoftInputFromWindow(android.os.IBinder arg0, int arg1, android.os.ResultReceiver arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromWindow", "(Landroid/os/IBinder;ILandroid/os/ResultReceiver;)Z", ref global::android.view.inputmethod.InputMethodManager._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public void toggleSoftInputFromWindow(android.os.IBinder arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "toggleSoftInputFromWindow", "(Landroid/os/IBinder;II)V", ref global::android.view.inputmethod.InputMethodManager._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public bool isWatchingCursor(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "isWatchingCursor", "(Landroid/view/View;)Z", ref global::android.view.inputmethod.InputMethodManager._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public void sendAppPrivateCommand(android.view.View arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "sendAppPrivateCommand", "(Landroid/view/View;Ljava/lang/String;Landroid/os/Bundle;)V", ref global::android.view.inputmethod.InputMethodManager._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public void setInputMethod(android.os.IBinder arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "setInputMethod", "(Landroid/os/IBinder;Ljava/lang/String;)V", ref global::android.view.inputmethod.InputMethodManager._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public void hideSoftInputFromInputMethod(android.os.IBinder arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V", ref global::android.view.inputmethod.InputMethodManager._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public void showSoftInputFromInputMethod(android.os.IBinder arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V", ref global::android.view.inputmethod.InputMethodManager._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public void showInputMethodPicker()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, "showInputMethodPicker", "()V", ref global::android.view.inputmethod.InputMethodManager._m24);
		}
		public static int SHOW_IMPLICIT
		{
			get
			{
				return 1;
			}
		}
		public static int SHOW_FORCED
		{
			get
			{
				return 2;
			}
		}
		public static int RESULT_UNCHANGED_SHOWN
		{
			get
			{
				return 0;
			}
		}
		public static int RESULT_UNCHANGED_HIDDEN
		{
			get
			{
				return 1;
			}
		}
		public static int RESULT_SHOWN
		{
			get
			{
				return 2;
			}
		}
		public static int RESULT_HIDDEN
		{
			get
			{
				return 3;
			}
		}
		public static int HIDE_IMPLICIT_ONLY
		{
			get
			{
				return 1;
			}
		}
		public static int HIDE_NOT_ALWAYS
		{
			get
			{
				return 2;
			}
		}
		static InputMethodManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethodManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethodManager"));
		}
	}
}
