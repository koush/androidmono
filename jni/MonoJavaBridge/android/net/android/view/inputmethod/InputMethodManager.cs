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
		internal static global::net.sf.jni4net.jni.MethodId _isActive9172; 
		public bool isActive(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _isActive9172, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _isActive9172, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isActive9173; 
		public bool isActive() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _isActive9173); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _isActive9173); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restartInput9174; 
		public void restartInput(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _restartInput9174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _restartInput9174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showSoftInput9175; 
		public bool showSoftInput(android.view.View arg0, int arg1, android.os.ResultReceiver arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _showSoftInput9175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _showSoftInput9175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showSoftInput9176; 
		public bool showSoftInput(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _showSoftInput9176, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _showSoftInput9176, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateSelection9177; 
		public void updateSelection(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _updateSelection9177, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _updateSelection9177, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateCursor9178; 
		public void updateCursor(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _updateCursor9178, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _updateCursor9178, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _displayCompletions9179; 
		public void displayCompletions(android.view.View arg0, android.view.inputmethod.CompletionInfo[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _displayCompletions9179, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _displayCompletions9179, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateExtractedText9180; 
		public void updateExtractedText(android.view.View arg0, int arg1, android.view.inputmethod.ExtractedText arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _updateExtractedText9180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _updateExtractedText9180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toggleSoftInput9181; 
		public void toggleSoftInput(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _toggleSoftInput9181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _toggleSoftInput9181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFullscreenMode9182; 
		public bool isFullscreenMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _isFullscreenMode9182); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _isFullscreenMode9182); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showStatusIcon9183; 
		public void showStatusIcon(android.os.IBinder arg0, java.lang.String arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _showStatusIcon9183, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _showStatusIcon9183, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hideStatusIcon9184; 
		public void hideStatusIcon(android.os.IBinder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _hideStatusIcon9184, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _hideStatusIcon9184, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputMethodList9185; 
		public java.util.List getInputMethodList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getInputMethodList9185)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputMethodManager.staticClass, _getInputMethodList9185)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEnabledInputMethodList9186; 
		public java.util.List getEnabledInputMethodList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getEnabledInputMethodList9186)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputMethodManager.staticClass, _getEnabledInputMethodList9186)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAcceptingText9187; 
		public bool isAcceptingText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _isAcceptingText9187); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _isAcceptingText9187); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hideSoftInputFromWindow9188; 
		public bool hideSoftInputFromWindow(android.os.IBinder arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _hideSoftInputFromWindow9188, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _hideSoftInputFromWindow9188, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hideSoftInputFromWindow9189; 
		public bool hideSoftInputFromWindow(android.os.IBinder arg0, int arg1, android.os.ResultReceiver arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _hideSoftInputFromWindow9189, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _hideSoftInputFromWindow9189, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toggleSoftInputFromWindow9190; 
		public void toggleSoftInputFromWindow(android.os.IBinder arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _toggleSoftInputFromWindow9190, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _toggleSoftInputFromWindow9190, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isWatchingCursor9191; 
		public bool isWatchingCursor(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				return @__env.CallBooleanMethod(this, _isWatchingCursor9191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _isWatchingCursor9191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendAppPrivateCommand9192; 
		public void sendAppPrivateCommand(android.view.View arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _sendAppPrivateCommand9192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _sendAppPrivateCommand9192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInputMethod9193; 
		public void setInputMethod(android.os.IBinder arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _setInputMethod9193, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _setInputMethod9193, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hideSoftInputFromInputMethod9194; 
		public void hideSoftInputFromInputMethod(android.os.IBinder arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _hideSoftInputFromInputMethod9194, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _hideSoftInputFromInputMethod9194, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showSoftInputFromInputMethod9195; 
		public void showSoftInputFromInputMethod(android.os.IBinder arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _showSoftInputFromInputMethod9195, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _showSoftInputFromInputMethod9195, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showInputMethodPicker9196; 
		public void showInputMethodPicker() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputMethodManager)) 
				@__env.CallVoidMethod(this, _showInputMethodPicker9196); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputMethodManager.staticClass, _showInputMethodPicker9196); 
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
			global::android.view.inputmethod.InputMethodManager._isActive9172 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "isActive", "(Landroid/view/View;)Z"); 
			global::android.view.inputmethod.InputMethodManager._isActive9173 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "isActive", "()Z"); 
			global::android.view.inputmethod.InputMethodManager._restartInput9174 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "restartInput", "(Landroid/view/View;)V"); 
			global::android.view.inputmethod.InputMethodManager._showSoftInput9175 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInput", "(Landroid/view/View;ILandroid/os/ResultReceiver;)Z"); 
			global::android.view.inputmethod.InputMethodManager._showSoftInput9176 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInput", "(Landroid/view/View;I)Z"); 
			global::android.view.inputmethod.InputMethodManager._updateSelection9177 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "updateSelection", "(Landroid/view/View;IIII)V"); 
			global::android.view.inputmethod.InputMethodManager._updateCursor9178 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "updateCursor", "(Landroid/view/View;IIII)V"); 
			global::android.view.inputmethod.InputMethodManager._displayCompletions9179 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "displayCompletions", "(Landroid/view/View;[Landroid/view/inputmethod/CompletionInfo;)V"); 
			global::android.view.inputmethod.InputMethodManager._updateExtractedText9180 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "updateExtractedText", "(Landroid/view/View;ILandroid/view/inputmethod/ExtractedText;)V"); 
			global::android.view.inputmethod.InputMethodManager._toggleSoftInput9181 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "toggleSoftInput", "(II)V"); 
			global::android.view.inputmethod.InputMethodManager._isFullscreenMode9182 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "isFullscreenMode", "()Z"); 
			global::android.view.inputmethod.InputMethodManager._showStatusIcon9183 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "showStatusIcon", "(Landroid/os/IBinder;Ljava/lang/String;I)V"); 
			global::android.view.inputmethod.InputMethodManager._hideStatusIcon9184 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "hideStatusIcon", "(Landroid/os/IBinder;)V"); 
			global::android.view.inputmethod.InputMethodManager._getInputMethodList9185 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "getInputMethodList", "()Ljava/util/List;"); 
			global::android.view.inputmethod.InputMethodManager._getEnabledInputMethodList9186 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "getEnabledInputMethodList", "()Ljava/util/List;"); 
			global::android.view.inputmethod.InputMethodManager._isAcceptingText9187 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "isAcceptingText", "()Z"); 
			global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow9188 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromWindow", "(Landroid/os/IBinder;I)Z"); 
			global::android.view.inputmethod.InputMethodManager._hideSoftInputFromWindow9189 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromWindow", "(Landroid/os/IBinder;ILandroid/os/ResultReceiver;)Z"); 
			global::android.view.inputmethod.InputMethodManager._toggleSoftInputFromWindow9190 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "toggleSoftInputFromWindow", "(Landroid/os/IBinder;II)V"); 
			global::android.view.inputmethod.InputMethodManager._isWatchingCursor9191 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "isWatchingCursor", "(Landroid/view/View;)Z"); 
			global::android.view.inputmethod.InputMethodManager._sendAppPrivateCommand9192 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "sendAppPrivateCommand", "(Landroid/view/View;Ljava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.view.inputmethod.InputMethodManager._setInputMethod9193 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "setInputMethod", "(Landroid/os/IBinder;Ljava/lang/String;)V"); 
			global::android.view.inputmethod.InputMethodManager._hideSoftInputFromInputMethod9194 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "hideSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V"); 
			global::android.view.inputmethod.InputMethodManager._showSoftInputFromInputMethod9195 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "showSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V"); 
			global::android.view.inputmethod.InputMethodManager._showInputMethodPicker9196 = @__env.GetMethodID(global::android.view.inputmethod.InputMethodManager.staticClass, "showInputMethodPicker", "()V"); 
		} 
	} 
} 
