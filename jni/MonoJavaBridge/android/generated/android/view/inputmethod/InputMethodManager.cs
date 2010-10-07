namespace android.view.inputmethod
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class InputMethodManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static InputMethodManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.inputmethod.InputMethodManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.inputmethod.InputMethodManager(@__env);
			}
		}
		internal InputMethodManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _isActive9879;
		public bool isActive(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager._isActive9879, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._isActive9879, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isActive9880;
		public bool isActive() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager._isActive9880);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._isActive9880);
		}
		internal static global::net.sf.jni4net.jni.MethodId _restartInput9881;
		public void restartInput(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager._restartInput9881, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._restartInput9881, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showSoftInput9882;
		public bool showSoftInput(android.view.View arg0, int arg1, android.os.ResultReceiver arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager._showSoftInput9882, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._showSoftInput9882, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showSoftInput9883;
		public bool showSoftInput(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager._showSoftInput9883, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._showSoftInput9883, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateSelection9884;
		public void updateSelection(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager._updateSelection9884, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._updateSelection9884, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateCursor9885;
		public void updateCursor(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager._updateCursor9885, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._updateCursor9885, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _displayCompletions9886;
		public void displayCompletions(android.view.View arg0, android.view.inputmethod.CompletionInfo[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager._displayCompletions9886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._displayCompletions9886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateExtractedText9887;
		public void updateExtractedText(android.view.View arg0, int arg1, android.view.inputmethod.ExtractedText arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager._updateExtractedText9887, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._updateExtractedText9887, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toggleSoftInput9888;
		public void toggleSoftInput(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager._toggleSoftInput9888, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._toggleSoftInput9888, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFullscreenMode9889;
		public bool isFullscreenMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager._isFullscreenMode9889);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._isFullscreenMode9889);
		}
		internal static global::net.sf.jni4net.jni.MethodId _showStatusIcon9890;
		public void showStatusIcon(android.os.IBinder arg0, java.lang.String arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager._showStatusIcon9890, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._showStatusIcon9890, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hideStatusIcon9891;
		public void hideStatusIcon(android.os.IBinder arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager._hideStatusIcon9891, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._hideStatusIcon9891, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputMethodList9892;
		public global::java.util.List getInputMethodList() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputMethodManager._getInputMethodList9892));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._getInputMethodList9892));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEnabledInputMethodList9893;
		public global::java.util.List getEnabledInputMethodList() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputMethodManager._getEnabledInputMethodList9893));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._getEnabledInputMethodList9893));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAcceptingText9894;
		public bool isAcceptingText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager._isAcceptingText9894);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._isAcceptingText9894);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hideSoftInputFromWindow9895;
		public bool hideSoftInputFromWindow(android.os.IBinder arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow9895, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow9895, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hideSoftInputFromWindow9896;
		public bool hideSoftInputFromWindow(android.os.IBinder arg0, int arg1, android.os.ResultReceiver arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow9896, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow9896, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toggleSoftInputFromWindow9897;
		public void toggleSoftInputFromWindow(android.os.IBinder arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager._toggleSoftInputFromWindow9897, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._toggleSoftInputFromWindow9897, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isWatchingCursor9898;
		public bool isWatchingCursor(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodManager._isWatchingCursor9898, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._isWatchingCursor9898, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendAppPrivateCommand9899;
		public void sendAppPrivateCommand(android.view.View arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager._sendAppPrivateCommand9899, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._sendAppPrivateCommand9899, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInputMethod9900;
		public void setInputMethod(android.os.IBinder arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager._setInputMethod9900, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._setInputMethod9900, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hideSoftInputFromInputMethod9901;
		public void hideSoftInputFromInputMethod(android.os.IBinder arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromInputMethod9901, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._hideSoftInputFromInputMethod9901, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showSoftInputFromInputMethod9902;
		public void showSoftInputFromInputMethod(android.os.IBinder arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager._showSoftInputFromInputMethod9902, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._showSoftInputFromInputMethod9902, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showInputMethodPicker9903;
		public void showInputMethodPicker() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputMethodManager._showInputMethodPicker9903);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputMethodManager.staticClass, global::android.view.inputmethod.InputMethodManager._showInputMethodPicker9903);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.inputmethod.InputMethodManager.staticClass = @__class;
			global::android.view.inputmethod.InputMethodManager._isActive9879 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "isActive", "(Landroid/view/View;)Z");
			global::android.view.inputmethod.InputMethodManager._isActive9880 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "isActive", "()Z");
			global::android.view.inputmethod.InputMethodManager._restartInput9881 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "restartInput", "(Landroid/view/View;)V");
			global::android.view.inputmethod.InputMethodManager._showSoftInput9882 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInput", "(Landroid/view/View;ILandroid/os/ResultReceiver;)Z");
			global::android.view.inputmethod.InputMethodManager._showSoftInput9883 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInput", "(Landroid/view/View;I)Z");
			global::android.view.inputmethod.InputMethodManager._updateSelection9884 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "updateSelection", "(Landroid/view/View;IIII)V");
			global::android.view.inputmethod.InputMethodManager._updateCursor9885 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "updateCursor", "(Landroid/view/View;IIII)V");
			global::android.view.inputmethod.InputMethodManager._displayCompletions9886 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "displayCompletions", "(Landroid/view/View;[Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.view.inputmethod.InputMethodManager._updateExtractedText9887 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "updateExtractedText", "(Landroid/view/View;ILandroid/view/inputmethod/ExtractedText;)V");
			global::android.view.inputmethod.InputMethodManager._toggleSoftInput9888 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "toggleSoftInput", "(II)V");
			global::android.view.inputmethod.InputMethodManager._isFullscreenMode9889 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "isFullscreenMode", "()Z");
			global::android.view.inputmethod.InputMethodManager._showStatusIcon9890 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "showStatusIcon", "(Landroid/os/IBinder;Ljava/lang/String;I)V");
			global::android.view.inputmethod.InputMethodManager._hideStatusIcon9891 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "hideStatusIcon", "(Landroid/os/IBinder;)V");
			global::android.view.inputmethod.InputMethodManager._getInputMethodList9892 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "getInputMethodList", "()Ljava/util/List;");
			global::android.view.inputmethod.InputMethodManager._getEnabledInputMethodList9893 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "getEnabledInputMethodList", "()Ljava/util/List;");
			global::android.view.inputmethod.InputMethodManager._isAcceptingText9894 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "isAcceptingText", "()Z");
			global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow9895 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromWindow", "(Landroid/os/IBinder;I)Z");
			global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow9896 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromWindow", "(Landroid/os/IBinder;ILandroid/os/ResultReceiver;)Z");
			global::android.view.inputmethod.InputMethodManager._toggleSoftInputFromWindow9897 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "toggleSoftInputFromWindow", "(Landroid/os/IBinder;II)V");
			global::android.view.inputmethod.InputMethodManager._isWatchingCursor9898 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "isWatchingCursor", "(Landroid/view/View;)Z");
			global::android.view.inputmethod.InputMethodManager._sendAppPrivateCommand9899 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "sendAppPrivateCommand", "(Landroid/view/View;Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.view.inputmethod.InputMethodManager._setInputMethod9900 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "setInputMethod", "(Landroid/os/IBinder;Ljava/lang/String;)V");
			global::android.view.inputmethod.InputMethodManager._hideSoftInputFromInputMethod9901 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V");
			global::android.view.inputmethod.InputMethodManager._showSoftInputFromInputMethod9902 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V");
			global::android.view.inputmethod.InputMethodManager._showInputMethodPicker9903 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "showInputMethodPicker", "()V");
		}
	}
}
