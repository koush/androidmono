namespace android.inputmethodservice 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractInputMethodService : android.app.Service, android.view.KeyEvent.Callback
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AbstractInputMethodService() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.inputmethodservice.AbstractInputMethodService), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractInputMethodService(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public abstract class AbstractInputMethodImpl : java.lang.Object, android.view.inputmethod.InputMethod
		{ 
			internal static global::java.lang.Class staticClass; 
			static AbstractInputMethodImpl() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			protected AbstractInputMethodImpl(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _attachToken3960; 
			public abstract void attachToken(android.os.IBinder arg0); 
			internal static global::net.sf.jni4net.jni.MethodId _bindInput3961; 
			public abstract void bindInput(android.view.inputmethod.InputBinding arg0); 
			internal static global::net.sf.jni4net.jni.MethodId _unbindInput3962; 
			public abstract void unbindInput(); 
			internal static global::net.sf.jni4net.jni.MethodId _startInput3963; 
			public abstract void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1); 
			internal static global::net.sf.jni4net.jni.MethodId _restartInput3964; 
			public abstract void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1); 
			internal static global::net.sf.jni4net.jni.MethodId _showSoftInput3965; 
			public abstract void showSoftInput(int arg0, android.os.ResultReceiver arg1); 
			internal static global::net.sf.jni4net.jni.MethodId _hideSoftInput3966; 
			public abstract void hideSoftInput(int arg0, android.os.ResultReceiver arg1); 
			internal static global::net.sf.jni4net.jni.MethodId _createSession3967; 
			public virtual void createSession(android.view.inputmethod.InputMethod_SessionCallback arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl)) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession3967, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession3967, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setSessionEnabled3968; 
			public virtual void setSessionEnabled(android.view.inputmethod.InputMethodSession arg0, bool arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl)) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled3968, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled3968, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _revokeSession3969; 
			public virtual void revokeSession(android.view.inputmethod.InputMethodSession arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl)) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession3969, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession3969, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _AbstractInputMethodImpl3970; 
			public AbstractInputMethodImpl(android.inputmethodservice.AbstractInputMethodService arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._AbstractInputMethodImpl3970, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass = @__class; 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._attachToken3960 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "attachToken", "(Landroid/os/IBinder;)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._bindInput3961 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._unbindInput3962 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "unbindInput", "()V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._startInput3963 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._restartInput3964 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._showSoftInput3965 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._hideSoftInput3966 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession3967 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled3968 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession3969 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._AbstractInputMethodImpl3970 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public abstract class AbstractInputMethodSessionImpl : java.lang.Object, android.view.inputmethod.InputMethodSession
		{ 
			internal static global::java.lang.Class staticClass; 
			static AbstractInputMethodSessionImpl() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			protected AbstractInputMethodSessionImpl(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _finishInput3971; 
			public abstract void finishInput(); 
			internal static global::net.sf.jni4net.jni.MethodId _updateSelection3972; 
			public abstract void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5); 
			internal static global::net.sf.jni4net.jni.MethodId _updateCursor3973; 
			public abstract void updateCursor(android.graphics.Rect arg0); 
			internal static global::net.sf.jni4net.jni.MethodId _displayCompletions3974; 
			public abstract void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0); 
			internal static global::net.sf.jni4net.jni.MethodId _updateExtractedText3975; 
			public abstract void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1); 
			internal static global::net.sf.jni4net.jni.MethodId _appPrivateCommand3976; 
			public abstract void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1); 
			internal static global::net.sf.jni4net.jni.MethodId _toggleSoftInput3977; 
			public abstract void toggleSoftInput(int arg0, int arg1); 
			internal static global::net.sf.jni4net.jni.MethodId _isEnabled3978; 
			public virtual bool isEnabled() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl)) 
					return @__env.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled3978); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled3978); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setEnabled3979; 
			public virtual void setEnabled(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl)) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled3979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled3979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent3980; 
			public virtual void dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl)) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent3980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent3980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent3981; 
			public virtual void dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl)) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent3981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent3981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isRevoked3982; 
			public virtual bool isRevoked() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl)) 
					return @__env.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked3982); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked3982); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _revokeSelf3983; 
			public virtual void revokeSelf() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl)) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf3983); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf3983); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _AbstractInputMethodSessionImpl3984; 
			public AbstractInputMethodSessionImpl(android.inputmethodservice.AbstractInputMethodService arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._AbstractInputMethodSessionImpl3984, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass = @__class; 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._finishInput3971 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "finishInput", "()V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._updateSelection3972 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "updateSelection", "(IIIIII)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._updateCursor3973 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._displayCompletions3974 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._updateExtractedText3975 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._appPrivateCommand3976 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._toggleSoftInput3977 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "toggleSoftInput", "(II)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled3978 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "isEnabled", "()Z"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled3979 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "setEnabled", "(Z)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent3980 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "dispatchKeyEvent", "(ILandroid/view/KeyEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent3981 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "dispatchTrackballEvent", "(ILandroid/view/MotionEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked3982 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "isRevoked", "()Z"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf3983 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "revokeSelf", "()V"); 
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._AbstractInputMethodSessionImpl3984 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown3985; 
		public abstract bool onKeyDown(int arg0, android.view.KeyEvent arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyLongPress3986; 
		public abstract bool onKeyLongPress(int arg0, android.view.KeyEvent arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp3987; 
		public abstract bool onKeyUp(int arg0, android.view.KeyEvent arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple3988; 
		public abstract bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _onBind3989; 
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.AbstractInputMethodService)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.AbstractInputMethodService._onBind3989, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._onBind3989, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump3990; 
		protected override void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.AbstractInputMethodService)) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService._dump3990, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._dump3990, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent3991; 
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.AbstractInputMethodService)) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent3991, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent3991, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyDispatcherState3992; 
		public virtual global::android.view.KeyEvent.DispatcherState getKeyDispatcherState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.AbstractInputMethodService)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent.DispatcherState>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState3992)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent.DispatcherState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState3992)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputMethodInterface3993; 
		public abstract global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface(); 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputMethodSessionInterface3994; 
		public abstract global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface(); 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractInputMethodService3995; 
		public AbstractInputMethodService()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._AbstractInputMethodService3995, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.inputmethodservice.AbstractInputMethodService.staticClass = @__class; 
			global::android.inputmethodservice.AbstractInputMethodService._onKeyDown3985 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.inputmethodservice.AbstractInputMethodService._onKeyLongPress3986 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.inputmethodservice.AbstractInputMethodService._onKeyUp3987 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.inputmethodservice.AbstractInputMethodService._onKeyMultiple3988 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z"); 
			global::android.inputmethodservice.AbstractInputMethodService._onBind3989 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"); 
			global::android.inputmethodservice.AbstractInputMethodService._dump3990 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V"); 
			global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent3991 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState3992 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;"); 
			global::android.inputmethodservice.AbstractInputMethodService._onCreateInputMethodInterface3993 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;"); 
			global::android.inputmethodservice.AbstractInputMethodService._onCreateInputMethodSessionInterface3994 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;"); 
			global::android.inputmethodservice.AbstractInputMethodService._AbstractInputMethodService3995 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "<init>", "()V"); 
		} 
	} 
} 
