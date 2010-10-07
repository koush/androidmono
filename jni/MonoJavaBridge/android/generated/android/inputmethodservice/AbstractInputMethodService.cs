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
			internal static global::net.sf.jni4net.jni.MethodId _attachToken4192;
			public abstract void attachToken(android.os.IBinder arg0);
			internal static global::net.sf.jni4net.jni.MethodId _bindInput4193;
			public abstract void bindInput(android.view.inputmethod.InputBinding arg0);
			internal static global::net.sf.jni4net.jni.MethodId _unbindInput4194;
			public abstract void unbindInput();
			internal static global::net.sf.jni4net.jni.MethodId _startInput4195;
			public abstract void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
			internal static global::net.sf.jni4net.jni.MethodId _restartInput4196;
			public abstract void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
			internal static global::net.sf.jni4net.jni.MethodId _showSoftInput4197;
			public abstract void showSoftInput(int arg0, android.os.ResultReceiver arg1);
			internal static global::net.sf.jni4net.jni.MethodId _hideSoftInput4198;
			public abstract void hideSoftInput(int arg0, android.os.ResultReceiver arg1);
			internal static global::net.sf.jni4net.jni.MethodId _createSession4199;
			public virtual void createSession(android.view.inputmethod.InputMethod_SessionCallback arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession4199, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession4199, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setSessionEnabled4200;
			public virtual void setSessionEnabled(android.view.inputmethod.InputMethodSession arg0, bool arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled4200, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled4200, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _revokeSession4201;
			public virtual void revokeSession(android.view.inputmethod.InputMethodSession arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession4201, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession4201, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _AbstractInputMethodImpl4202;
			public AbstractInputMethodImpl(android.inputmethodservice.AbstractInputMethodService arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._AbstractInputMethodImpl4202, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass = @__class;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._attachToken4192 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "attachToken", "(Landroid/os/IBinder;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._bindInput4193 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._unbindInput4194 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "unbindInput", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._startInput4195 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._restartInput4196 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._showSoftInput4197 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._hideSoftInput4198 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession4199 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled4200 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession4201 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._AbstractInputMethodImpl4202 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _finishInput4203;
			public abstract void finishInput();
			internal static global::net.sf.jni4net.jni.MethodId _updateSelection4204;
			public abstract void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);
			internal static global::net.sf.jni4net.jni.MethodId _updateCursor4205;
			public abstract void updateCursor(android.graphics.Rect arg0);
			internal static global::net.sf.jni4net.jni.MethodId _displayCompletions4206;
			public abstract void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0);
			internal static global::net.sf.jni4net.jni.MethodId _updateExtractedText4207;
			public abstract void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1);
			internal static global::net.sf.jni4net.jni.MethodId _appPrivateCommand4208;
			public abstract void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1);
			internal static global::net.sf.jni4net.jni.MethodId _toggleSoftInput4209;
			public abstract void toggleSoftInput(int arg0, int arg1);
			internal static global::net.sf.jni4net.jni.MethodId _isEnabled4210;
			public virtual bool isEnabled() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled4210);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled4210);
			}
			internal static global::net.sf.jni4net.jni.MethodId _setEnabled4211;
			public virtual void setEnabled(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled4211, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled4211, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent4212;
			public virtual void dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent4212, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent4212, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent4213;
			public virtual void dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent4213, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent4213, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _isRevoked4214;
			public virtual bool isRevoked() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked4214);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked4214);
			}
			internal static global::net.sf.jni4net.jni.MethodId _revokeSelf4215;
			public virtual void revokeSelf() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf4215);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf4215);
			}
			internal static global::net.sf.jni4net.jni.MethodId _AbstractInputMethodSessionImpl4216;
			public AbstractInputMethodSessionImpl(android.inputmethodservice.AbstractInputMethodService arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._AbstractInputMethodSessionImpl4216, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass = @__class;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._finishInput4203 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "finishInput", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._updateSelection4204 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "updateSelection", "(IIIIII)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._updateCursor4205 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._displayCompletions4206 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._updateExtractedText4207 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._appPrivateCommand4208 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._toggleSoftInput4209 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "toggleSoftInput", "(II)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled4210 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "isEnabled", "()Z");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled4211 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "setEnabled", "(Z)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent4212 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "dispatchKeyEvent", "(ILandroid/view/KeyEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent4213 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "dispatchTrackballEvent", "(ILandroid/view/MotionEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked4214 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "isRevoked", "()Z");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf4215 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "revokeSelf", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._AbstractInputMethodSessionImpl4216 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown4217;
		public abstract bool onKeyDown(int arg0, android.view.KeyEvent arg1);
		internal static global::net.sf.jni4net.jni.MethodId _onKeyLongPress4218;
		public abstract bool onKeyLongPress(int arg0, android.view.KeyEvent arg1);
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp4219;
		public abstract bool onKeyUp(int arg0, android.view.KeyEvent arg1);
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple4220;
		public abstract bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2);
		internal static global::net.sf.jni4net.jni.MethodId _onBind4221;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.AbstractInputMethodService._onBind4221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._onBind4221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump4222;
		protected override void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService._dump4222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._dump4222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent4223;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent4223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent4223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKeyDispatcherState4224;
		public virtual global::android.view.KeyEvent.DispatcherState getKeyDispatcherState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent.DispatcherState>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState4224));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyEvent.DispatcherState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState4224));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputMethodInterface4225;
		public abstract global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface();
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputMethodSessionInterface4226;
		public abstract global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface();
		internal static global::net.sf.jni4net.jni.MethodId _AbstractInputMethodService4227;
		public AbstractInputMethodService()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._AbstractInputMethodService4227, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.inputmethodservice.AbstractInputMethodService.staticClass = @__class;
			global::android.inputmethodservice.AbstractInputMethodService._onKeyDown4217 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onKeyLongPress4218 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onKeyUp4219 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onKeyMultiple4220 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onBind4221 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.inputmethodservice.AbstractInputMethodService._dump4222 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V");
			global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent4223 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState4224 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;");
			global::android.inputmethodservice.AbstractInputMethodService._onCreateInputMethodInterface4225 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;");
			global::android.inputmethodservice.AbstractInputMethodService._onCreateInputMethodSessionInterface4226 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;");
			global::android.inputmethodservice.AbstractInputMethodService._AbstractInputMethodService4227 = @__env.GetMethodID(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "<init>", "()V");
		}
	}
}
