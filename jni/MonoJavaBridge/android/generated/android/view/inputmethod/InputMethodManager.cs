namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class InputMethodManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputMethodManager()
		{
			InitJNI();
		}
		internal InputMethodManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isActive10772;
		public bool isActive(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._isActive10772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._isActive10772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isActive10773;
		public bool isActive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._isActive10773);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._isActive10773);
		}
		internal static global::MonoJavaBridge.MethodId _restartInput10774;
		public void restartInput(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._restartInput10774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._restartInput10774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showSoftInput10775;
		public bool showSoftInput(android.view.View arg0, int arg1, android.os.ResultReceiver arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._showSoftInput10775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._showSoftInput10775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _showSoftInput10776;
		public bool showSoftInput(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._showSoftInput10776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._showSoftInput10776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateSelection10777;
		public void updateSelection(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._updateSelection10777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._updateSelection10777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _updateCursor10778;
		public void updateCursor(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._updateCursor10778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._updateCursor10778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _displayCompletions10779;
		public void displayCompletions(android.view.View arg0, android.view.inputmethod.CompletionInfo[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._displayCompletions10779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._displayCompletions10779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateExtractedText10780;
		public void updateExtractedText(android.view.View arg0, int arg1, android.view.inputmethod.ExtractedText arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._updateExtractedText10780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._updateExtractedText10780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _toggleSoftInput10781;
		public void toggleSoftInput(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._toggleSoftInput10781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._toggleSoftInput10781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isFullscreenMode10782;
		public bool isFullscreenMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._isFullscreenMode10782);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._isFullscreenMode10782);
		}
		internal static global::MonoJavaBridge.MethodId _showStatusIcon10783;
		public void showStatusIcon(android.os.IBinder arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._showStatusIcon10783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._showStatusIcon10783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _hideStatusIcon10784;
		public void hideStatusIcon(android.os.IBinder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._hideStatusIcon10784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._hideStatusIcon10784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List InputMethodList
		{
			get
			{
				return getInputMethodList();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputMethodList10785;
		public global::java.util.List getInputMethodList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._getInputMethodList10785)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._getInputMethodList10785)) as java.util.List;
		}
		public new global::java.util.List EnabledInputMethodList
		{
			get
			{
				return getEnabledInputMethodList();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledInputMethodList10786;
		public global::java.util.List getEnabledInputMethodList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._getEnabledInputMethodList10786)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._getEnabledInputMethodList10786)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _isAcceptingText10787;
		public bool isAcceptingText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._isAcceptingText10787);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._isAcceptingText10787);
		}
		internal static global::MonoJavaBridge.MethodId _hideSoftInputFromWindow10788;
		public bool hideSoftInputFromWindow(android.os.IBinder arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow10788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow10788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hideSoftInputFromWindow10789;
		public bool hideSoftInputFromWindow(android.os.IBinder arg0, int arg1, android.os.ResultReceiver arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow10789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow10789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _toggleSoftInputFromWindow10790;
		public void toggleSoftInputFromWindow(android.os.IBinder arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._toggleSoftInputFromWindow10790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._toggleSoftInputFromWindow10790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isWatchingCursor10791;
		public bool isWatchingCursor(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._isWatchingCursor10791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._isWatchingCursor10791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendAppPrivateCommand10792;
		public void sendAppPrivateCommand(android.view.View arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._sendAppPrivateCommand10792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._sendAppPrivateCommand10792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setInputMethod10793;
		public void setInputMethod(android.os.IBinder arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._setInputMethod10793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._setInputMethod10793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hideSoftInputFromInputMethod10794;
		public void hideSoftInputFromInputMethod(android.os.IBinder arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromInputMethod10794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromInputMethod10794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showSoftInputFromInputMethod10795;
		public void showSoftInputFromInputMethod(android.os.IBinder arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._showSoftInputFromInputMethod10795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._showSoftInputFromInputMethod10795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showInputMethodPicker10796;
		public void showInputMethodPicker() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._showInputMethodPicker10796);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._showInputMethodPicker10796);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethodManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethodManager"));
			global::android.view.inputmethod.InputMethodManager._isActive10772 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "isActive", "(Landroid/view/View;)Z");
			global::android.view.inputmethod.InputMethodManager._isActive10773 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "isActive", "()Z");
			global::android.view.inputmethod.InputMethodManager._restartInput10774 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "restartInput", "(Landroid/view/View;)V");
			global::android.view.inputmethod.InputMethodManager._showSoftInput10775 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInput", "(Landroid/view/View;ILandroid/os/ResultReceiver;)Z");
			global::android.view.inputmethod.InputMethodManager._showSoftInput10776 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInput", "(Landroid/view/View;I)Z");
			global::android.view.inputmethod.InputMethodManager._updateSelection10777 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "updateSelection", "(Landroid/view/View;IIII)V");
			global::android.view.inputmethod.InputMethodManager._updateCursor10778 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "updateCursor", "(Landroid/view/View;IIII)V");
			global::android.view.inputmethod.InputMethodManager._displayCompletions10779 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "displayCompletions", "(Landroid/view/View;[Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.view.inputmethod.InputMethodManager._updateExtractedText10780 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "updateExtractedText", "(Landroid/view/View;ILandroid/view/inputmethod/ExtractedText;)V");
			global::android.view.inputmethod.InputMethodManager._toggleSoftInput10781 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "toggleSoftInput", "(II)V");
			global::android.view.inputmethod.InputMethodManager._isFullscreenMode10782 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "isFullscreenMode", "()Z");
			global::android.view.inputmethod.InputMethodManager._showStatusIcon10783 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "showStatusIcon", "(Landroid/os/IBinder;Ljava/lang/String;I)V");
			global::android.view.inputmethod.InputMethodManager._hideStatusIcon10784 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "hideStatusIcon", "(Landroid/os/IBinder;)V");
			global::android.view.inputmethod.InputMethodManager._getInputMethodList10785 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "getInputMethodList", "()Ljava/util/List;");
			global::android.view.inputmethod.InputMethodManager._getEnabledInputMethodList10786 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "getEnabledInputMethodList", "()Ljava/util/List;");
			global::android.view.inputmethod.InputMethodManager._isAcceptingText10787 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "isAcceptingText", "()Z");
			global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow10788 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromWindow", "(Landroid/os/IBinder;I)Z");
			global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow10789 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromWindow", "(Landroid/os/IBinder;ILandroid/os/ResultReceiver;)Z");
			global::android.view.inputmethod.InputMethodManager._toggleSoftInputFromWindow10790 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "toggleSoftInputFromWindow", "(Landroid/os/IBinder;II)V");
			global::android.view.inputmethod.InputMethodManager._isWatchingCursor10791 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "isWatchingCursor", "(Landroid/view/View;)Z");
			global::android.view.inputmethod.InputMethodManager._sendAppPrivateCommand10792 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "sendAppPrivateCommand", "(Landroid/view/View;Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.view.inputmethod.InputMethodManager._setInputMethod10793 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "setInputMethod", "(Landroid/os/IBinder;Ljava/lang/String;)V");
			global::android.view.inputmethod.InputMethodManager._hideSoftInputFromInputMethod10794 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V");
			global::android.view.inputmethod.InputMethodManager._showSoftInputFromInputMethod10795 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V");
			global::android.view.inputmethod.InputMethodManager._showInputMethodPicker10796 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "showInputMethodPicker", "()V");
		}
	}
}
