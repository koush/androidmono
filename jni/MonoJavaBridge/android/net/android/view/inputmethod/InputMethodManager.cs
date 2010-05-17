namespace android.view.inputmethod 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class InputMethodManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static InputMethodManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.inputmethod.InputMethodManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _isActive8500; 
		public bool isActive(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _isActive8500, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _isActive8500, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isActive8501; 
		public bool isActive() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _isActive8501); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _isActive8501); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restartInput8502; 
		public void restartInput(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _restartInput8502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _restartInput8502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showSoftInput8503; 
		public bool showSoftInput(android.view.View arg0, int arg1, android.os.ResultReceiver arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _showSoftInput8503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _showSoftInput8503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showSoftInput8504; 
		public bool showSoftInput(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _showSoftInput8504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _showSoftInput8504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateSelection8505; 
		public void updateSelection(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _updateSelection8505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _updateSelection8505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateCursor8506; 
		public void updateCursor(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _updateCursor8506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _updateCursor8506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _displayCompletions8507; 
		public void displayCompletions(android.view.View arg0, android.view.inputmethod.CompletionInfo[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _displayCompletions8507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _displayCompletions8507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateExtractedText8508; 
		public void updateExtractedText(android.view.View arg0, int arg1, android.view.inputmethod.ExtractedText arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _updateExtractedText8508, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _updateExtractedText8508, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toggleSoftInput8509; 
		public void toggleSoftInput(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _toggleSoftInput8509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _toggleSoftInput8509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFullscreenMode8510; 
		public bool isFullscreenMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _isFullscreenMode8510); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _isFullscreenMode8510); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showStatusIcon8511; 
		public void showStatusIcon(android.os.IBinder arg0, java.lang.String arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _showStatusIcon8511, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _showStatusIcon8511, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hideStatusIcon8512; 
		public void hideStatusIcon(android.os.IBinder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _hideStatusIcon8512, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _hideStatusIcon8512, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputMethodList8513; 
		public java.util.List getInputMethodList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getInputMethodList8513)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputMethodManager.staticClass, _getInputMethodList8513)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEnabledInputMethodList8514; 
		public java.util.List getEnabledInputMethodList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getEnabledInputMethodList8514)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputMethodManager.staticClass, _getEnabledInputMethodList8514)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAcceptingText8515; 
		public bool isAcceptingText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _isAcceptingText8515); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _isAcceptingText8515); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hideSoftInputFromWindow8516; 
		public bool hideSoftInputFromWindow(android.os.IBinder arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _hideSoftInputFromWindow8516, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _hideSoftInputFromWindow8516, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hideSoftInputFromWindow8517; 
		public bool hideSoftInputFromWindow(android.os.IBinder arg0, int arg1, android.os.ResultReceiver arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _hideSoftInputFromWindow8517, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _hideSoftInputFromWindow8517, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toggleSoftInputFromWindow8518; 
		public void toggleSoftInputFromWindow(android.os.IBinder arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _toggleSoftInputFromWindow8518, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _toggleSoftInputFromWindow8518, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isWatchingCursor8519; 
		public bool isWatchingCursor(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _isWatchingCursor8519, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _isWatchingCursor8519, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendAppPrivateCommand8520; 
		public void sendAppPrivateCommand(android.view.View arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _sendAppPrivateCommand8520, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _sendAppPrivateCommand8520, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInputMethod8521; 
		public void setInputMethod(android.os.IBinder arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _setInputMethod8521, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _setInputMethod8521, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hideSoftInputFromInputMethod8522; 
		public void hideSoftInputFromInputMethod(android.os.IBinder arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _hideSoftInputFromInputMethod8522, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _hideSoftInputFromInputMethod8522, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showSoftInputFromInputMethod8523; 
		public void showSoftInputFromInputMethod(android.os.IBinder arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _showSoftInputFromInputMethod8523, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _showSoftInputFromInputMethod8523, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showInputMethodPicker8524; 
		public void showInputMethodPicker() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _showInputMethodPicker8524); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _showInputMethodPicker8524); 
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
			global::android.view.inputmethod.InputMethodManager._isActive8500 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "isActive", "(Landroid/view/View;)Z"); 
			global::android.view.inputmethod.InputMethodManager._isActive8501 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "isActive", "()Z"); 
			global::android.view.inputmethod.InputMethodManager._restartInput8502 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "restartInput", "(Landroid/view/View;)V"); 
			global::android.view.inputmethod.InputMethodManager._showSoftInput8503 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInput", "(Landroid/view/View;ILandroid/os/ResultReceiver;)Z"); 
			global::android.view.inputmethod.InputMethodManager._showSoftInput8504 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInput", "(Landroid/view/View;I)Z"); 
			global::android.view.inputmethod.InputMethodManager._updateSelection8505 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "updateSelection", "(Landroid/view/View;IIII)V"); 
			global::android.view.inputmethod.InputMethodManager._updateCursor8506 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "updateCursor", "(Landroid/view/View;IIII)V"); 
			global::android.view.inputmethod.InputMethodManager._displayCompletions8507 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "displayCompletions", "(Landroid/view/View;[Landroid/view/inputmethod/CompletionInfo;)V"); 
			global::android.view.inputmethod.InputMethodManager._updateExtractedText8508 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "updateExtractedText", "(Landroid/view/View;ILandroid/view/inputmethod/ExtractedText;)V"); 
			global::android.view.inputmethod.InputMethodManager._toggleSoftInput8509 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "toggleSoftInput", "(II)V"); 
			global::android.view.inputmethod.InputMethodManager._isFullscreenMode8510 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "isFullscreenMode", "()Z"); 
			global::android.view.inputmethod.InputMethodManager._showStatusIcon8511 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "showStatusIcon", "(Landroid/os/IBinder;Ljava/lang/String;I)V"); 
			global::android.view.inputmethod.InputMethodManager._hideStatusIcon8512 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "hideStatusIcon", "(Landroid/os/IBinder;)V"); 
			global::android.view.inputmethod.InputMethodManager._getInputMethodList8513 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "getInputMethodList", "()Ljava/util/List;"); 
			global::android.view.inputmethod.InputMethodManager._getEnabledInputMethodList8514 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "getEnabledInputMethodList", "()Ljava/util/List;"); 
			global::android.view.inputmethod.InputMethodManager._isAcceptingText8515 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "isAcceptingText", "()Z"); 
			global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow8516 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromWindow", "(Landroid/os/IBinder;I)Z"); 
			global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow8517 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromWindow", "(Landroid/os/IBinder;ILandroid/os/ResultReceiver;)Z"); 
			global::android.view.inputmethod.InputMethodManager._toggleSoftInputFromWindow8518 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "toggleSoftInputFromWindow", "(Landroid/os/IBinder;II)V"); 
			global::android.view.inputmethod.InputMethodManager._isWatchingCursor8519 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "isWatchingCursor", "(Landroid/view/View;)Z"); 
			global::android.view.inputmethod.InputMethodManager._sendAppPrivateCommand8520 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "sendAppPrivateCommand", "(Landroid/view/View;Ljava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.view.inputmethod.InputMethodManager._setInputMethod8521 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "setInputMethod", "(Landroid/os/IBinder;Ljava/lang/String;)V"); 
			global::android.view.inputmethod.InputMethodManager._hideSoftInputFromInputMethod8522 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V"); 
			global::android.view.inputmethod.InputMethodManager._showSoftInputFromInputMethod8523 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V"); 
			global::android.view.inputmethod.InputMethodManager._showInputMethodPicker8524 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "showInputMethodPicker", "()V"); 
		} 
	} 
} 
