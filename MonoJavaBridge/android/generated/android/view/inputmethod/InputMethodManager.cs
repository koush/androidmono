namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class InputMethodManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal InputMethodManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isActive15945;
		public bool isActive(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._isActive15945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._isActive15945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isActive15946;
		public bool isActive()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._isActive15946);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._isActive15946);
		}
		internal static global::MonoJavaBridge.MethodId _restartInput15947;
		public void restartInput(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._restartInput15947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._restartInput15947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showSoftInput15948;
		public bool showSoftInput(android.view.View arg0, int arg1, android.os.ResultReceiver arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._showSoftInput15948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._showSoftInput15948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _showSoftInput15949;
		public bool showSoftInput(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._showSoftInput15949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._showSoftInput15949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateSelection15950;
		public void updateSelection(android.view.View arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._updateSelection15950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._updateSelection15950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _updateCursor15951;
		public void updateCursor(android.view.View arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._updateCursor15951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._updateCursor15951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _displayCompletions15952;
		public void displayCompletions(android.view.View arg0, android.view.inputmethod.CompletionInfo[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._displayCompletions15952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._displayCompletions15952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateExtractedText15953;
		public void updateExtractedText(android.view.View arg0, int arg1, android.view.inputmethod.ExtractedText arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._updateExtractedText15953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._updateExtractedText15953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _toggleSoftInput15954;
		public void toggleSoftInput(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._toggleSoftInput15954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._toggleSoftInput15954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isFullscreenMode15955;
		public bool isFullscreenMode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._isFullscreenMode15955);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._isFullscreenMode15955);
		}
		internal static global::MonoJavaBridge.MethodId _showStatusIcon15956;
		public void showStatusIcon(android.os.IBinder arg0, java.lang.String arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._showStatusIcon15956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._showStatusIcon15956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _hideStatusIcon15957;
		public void hideStatusIcon(android.os.IBinder arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._hideStatusIcon15957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._hideStatusIcon15957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List InputMethodList
		{
			get
			{
				return getInputMethodList();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputMethodList15958;
		public global::java.util.List getInputMethodList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._getInputMethodList15958)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._getInputMethodList15958)) as java.util.List;
		}
		public new global::java.util.List EnabledInputMethodList
		{
			get
			{
				return getEnabledInputMethodList();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledInputMethodList15959;
		public global::java.util.List getEnabledInputMethodList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._getEnabledInputMethodList15959)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._getEnabledInputMethodList15959)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _isAcceptingText15960;
		public bool isAcceptingText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._isAcceptingText15960);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._isAcceptingText15960);
		}
		internal static global::MonoJavaBridge.MethodId _hideSoftInputFromWindow15961;
		public bool hideSoftInputFromWindow(android.os.IBinder arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow15961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow15961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hideSoftInputFromWindow15962;
		public bool hideSoftInputFromWindow(android.os.IBinder arg0, int arg1, android.os.ResultReceiver arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow15962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow15962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _toggleSoftInputFromWindow15963;
		public void toggleSoftInputFromWindow(android.os.IBinder arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._toggleSoftInputFromWindow15963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._toggleSoftInputFromWindow15963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isWatchingCursor15964;
		public bool isWatchingCursor(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._isWatchingCursor15964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._isWatchingCursor15964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendAppPrivateCommand15965;
		public void sendAppPrivateCommand(android.view.View arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._sendAppPrivateCommand15965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._sendAppPrivateCommand15965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setInputMethod15966;
		public void setInputMethod(android.os.IBinder arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._setInputMethod15966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._setInputMethod15966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hideSoftInputFromInputMethod15967;
		public void hideSoftInputFromInputMethod(android.os.IBinder arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromInputMethod15967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromInputMethod15967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showSoftInputFromInputMethod15968;
		public void showSoftInputFromInputMethod(android.os.IBinder arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._showSoftInputFromInputMethod15968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._showSoftInputFromInputMethod15968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showInputMethodPicker15969;
		public void showInputMethodPicker()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager._showInputMethodPicker15969);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._showInputMethodPicker15969);
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
			global::android.view.inputmethod.InputMethodManager._isActive15945 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "isActive", "(Landroid/view/View;)Z");
			global::android.view.inputmethod.InputMethodManager._isActive15946 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "isActive", "()Z");
			global::android.view.inputmethod.InputMethodManager._restartInput15947 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "restartInput", "(Landroid/view/View;)V");
			global::android.view.inputmethod.InputMethodManager._showSoftInput15948 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInput", "(Landroid/view/View;ILandroid/os/ResultReceiver;)Z");
			global::android.view.inputmethod.InputMethodManager._showSoftInput15949 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInput", "(Landroid/view/View;I)Z");
			global::android.view.inputmethod.InputMethodManager._updateSelection15950 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "updateSelection", "(Landroid/view/View;IIII)V");
			global::android.view.inputmethod.InputMethodManager._updateCursor15951 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "updateCursor", "(Landroid/view/View;IIII)V");
			global::android.view.inputmethod.InputMethodManager._displayCompletions15952 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "displayCompletions", "(Landroid/view/View;[Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.view.inputmethod.InputMethodManager._updateExtractedText15953 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "updateExtractedText", "(Landroid/view/View;ILandroid/view/inputmethod/ExtractedText;)V");
			global::android.view.inputmethod.InputMethodManager._toggleSoftInput15954 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "toggleSoftInput", "(II)V");
			global::android.view.inputmethod.InputMethodManager._isFullscreenMode15955 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "isFullscreenMode", "()Z");
			global::android.view.inputmethod.InputMethodManager._showStatusIcon15956 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "showStatusIcon", "(Landroid/os/IBinder;Ljava/lang/String;I)V");
			global::android.view.inputmethod.InputMethodManager._hideStatusIcon15957 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "hideStatusIcon", "(Landroid/os/IBinder;)V");
			global::android.view.inputmethod.InputMethodManager._getInputMethodList15958 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "getInputMethodList", "()Ljava/util/List;");
			global::android.view.inputmethod.InputMethodManager._getEnabledInputMethodList15959 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "getEnabledInputMethodList", "()Ljava/util/List;");
			global::android.view.inputmethod.InputMethodManager._isAcceptingText15960 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "isAcceptingText", "()Z");
			global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow15961 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromWindow", "(Landroid/os/IBinder;I)Z");
			global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow15962 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromWindow", "(Landroid/os/IBinder;ILandroid/os/ResultReceiver;)Z");
			global::android.view.inputmethod.InputMethodManager._toggleSoftInputFromWindow15963 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "toggleSoftInputFromWindow", "(Landroid/os/IBinder;II)V");
			global::android.view.inputmethod.InputMethodManager._isWatchingCursor15964 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "isWatchingCursor", "(Landroid/view/View;)Z");
			global::android.view.inputmethod.InputMethodManager._sendAppPrivateCommand15965 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "sendAppPrivateCommand", "(Landroid/view/View;Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.view.inputmethod.InputMethodManager._setInputMethod15966 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "setInputMethod", "(Landroid/os/IBinder;Ljava/lang/String;)V");
			global::android.view.inputmethod.InputMethodManager._hideSoftInputFromInputMethod15967 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V");
			global::android.view.inputmethod.InputMethodManager._showSoftInputFromInputMethod15968 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V");
			global::android.view.inputmethod.InputMethodManager._showInputMethodPicker15969 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodManager.staticClass, "showInputMethodPicker", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
