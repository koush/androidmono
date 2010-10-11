namespace android.inputmethodservice
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.inputmethodservice.AbstractInputMethodService_))]
	public abstract partial class AbstractInputMethodService : android.app.Service, android.view.KeyEvent.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractInputMethodService()
		{
			InitJNI();
		}
		protected AbstractInputMethodService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_))]
		public abstract partial class AbstractInputMethodImpl : java.lang.Object, android.view.inputmethod.InputMethod
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AbstractInputMethodImpl()
			{
				InitJNI();
			}
			protected AbstractInputMethodImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _attachToken4394;
			public abstract void attachToken(android.os.IBinder arg0);
			internal static global::MonoJavaBridge.MethodId _bindInput4395;
			public abstract void bindInput(android.view.inputmethod.InputBinding arg0);
			internal static global::MonoJavaBridge.MethodId _unbindInput4396;
			public abstract void unbindInput();
			internal static global::MonoJavaBridge.MethodId _startInput4397;
			public abstract void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
			internal static global::MonoJavaBridge.MethodId _restartInput4398;
			public abstract void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
			internal static global::MonoJavaBridge.MethodId _showSoftInput4399;
			public abstract void showSoftInput(int arg0, android.os.ResultReceiver arg1);
			internal static global::MonoJavaBridge.MethodId _hideSoftInput4400;
			public abstract void hideSoftInput(int arg0, android.os.ResultReceiver arg1);
			internal static global::MonoJavaBridge.MethodId _createSession4401;
			public virtual void createSession(android.view.inputmethod.InputMethod_SessionCallback arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession4401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession4401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _setSessionEnabled4402;
			public virtual void setSessionEnabled(android.view.inputmethod.InputMethodSession arg0, bool arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled4402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled4402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _revokeSession4403;
			public virtual void revokeSession(android.view.inputmethod.InputMethodSession arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession4403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession4403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _AbstractInputMethodImpl4404;
			public AbstractInputMethodImpl(android.inputmethodservice.AbstractInputMethodService arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._AbstractInputMethodImpl4404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl"));
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._attachToken4394 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "attachToken", "(Landroid/os/IBinder;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._bindInput4395 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._unbindInput4396 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "unbindInput", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._startInput4397 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._restartInput4398 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._showSoftInput4399 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._hideSoftInput4400 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession4401 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled4402 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession4403 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._AbstractInputMethodImpl4404 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl))]
		public sealed partial class AbstractInputMethodImpl_ : android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AbstractInputMethodImpl_()
			{
				InitJNI();
			}
			internal AbstractInputMethodImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _attachToken4405;
			public override void attachToken(android.os.IBinder arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._attachToken4405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._attachToken4405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _bindInput4406;
			public override void bindInput(android.view.inputmethod.InputBinding arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._bindInput4406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._bindInput4406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _unbindInput4407;
			public override void unbindInput() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._unbindInput4407);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._unbindInput4407);
			}
			internal static global::MonoJavaBridge.MethodId _startInput4408;
			public override void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._startInput4408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._startInput4408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _restartInput4409;
			public override void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._restartInput4409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._restartInput4409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _showSoftInput4410;
			public override void showSoftInput(int arg0, android.os.ResultReceiver arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._showSoftInput4410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._showSoftInput4410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _hideSoftInput4411;
			public override void hideSoftInput(int arg0, android.os.ResultReceiver arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._hideSoftInput4411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._hideSoftInput4411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl"));
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._attachToken4405 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "attachToken", "(Landroid/os/IBinder;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._bindInput4406 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._unbindInput4407 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "unbindInput", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._startInput4408 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._restartInput4409 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._showSoftInput4410 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._hideSoftInput4411 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_))]
		public abstract partial class AbstractInputMethodSessionImpl : java.lang.Object, android.view.inputmethod.InputMethodSession
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AbstractInputMethodSessionImpl()
			{
				InitJNI();
			}
			protected AbstractInputMethodSessionImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _finishInput4412;
			public abstract void finishInput();
			internal static global::MonoJavaBridge.MethodId _updateSelection4413;
			public abstract void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);
			internal static global::MonoJavaBridge.MethodId _updateCursor4414;
			public abstract void updateCursor(android.graphics.Rect arg0);
			internal static global::MonoJavaBridge.MethodId _displayCompletions4415;
			public abstract void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0);
			internal static global::MonoJavaBridge.MethodId _updateExtractedText4416;
			public abstract void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1);
			internal static global::MonoJavaBridge.MethodId _appPrivateCommand4417;
			public abstract void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1);
			internal static global::MonoJavaBridge.MethodId _toggleSoftInput4418;
			public abstract void toggleSoftInput(int arg0, int arg1);
			internal static global::MonoJavaBridge.MethodId _isEnabled4419;
			public virtual bool isEnabled() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled4419);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled4419);
			}
			internal static global::MonoJavaBridge.MethodId _setEnabled4420;
			public virtual void setEnabled(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled4420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled4420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent4421;
			public virtual void dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent4421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent4421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent4422;
			public virtual void dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent4422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent4422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _isRevoked4423;
			public virtual bool isRevoked() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked4423);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked4423);
			}
			internal static global::MonoJavaBridge.MethodId _revokeSelf4424;
			public virtual void revokeSelf() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf4424);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf4424);
			}
			internal static global::MonoJavaBridge.MethodId _AbstractInputMethodSessionImpl4425;
			public AbstractInputMethodSessionImpl(android.inputmethodservice.AbstractInputMethodService arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._AbstractInputMethodSessionImpl4425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl"));
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._finishInput4412 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "finishInput", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._updateSelection4413 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "updateSelection", "(IIIIII)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._updateCursor4414 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._displayCompletions4415 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._updateExtractedText4416 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._appPrivateCommand4417 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._toggleSoftInput4418 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "toggleSoftInput", "(II)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled4419 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "isEnabled", "()Z");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled4420 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "setEnabled", "(Z)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent4421 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "dispatchKeyEvent", "(ILandroid/view/KeyEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent4422 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "dispatchTrackballEvent", "(ILandroid/view/MotionEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked4423 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "isRevoked", "()Z");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf4424 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "revokeSelf", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._AbstractInputMethodSessionImpl4425 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl))]
		public sealed partial class AbstractInputMethodSessionImpl_ : android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AbstractInputMethodSessionImpl_()
			{
				InitJNI();
			}
			internal AbstractInputMethodSessionImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _finishInput4426;
			public override void finishInput() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._finishInput4426);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._finishInput4426);
			}
			internal static global::MonoJavaBridge.MethodId _updateSelection4427;
			public override void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateSelection4427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateSelection4427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			}
			internal static global::MonoJavaBridge.MethodId _updateCursor4428;
			public override void updateCursor(android.graphics.Rect arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateCursor4428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateCursor4428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _displayCompletions4429;
			public override void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._displayCompletions4429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._displayCompletions4429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _updateExtractedText4430;
			public override void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateExtractedText4430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateExtractedText4430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _appPrivateCommand4431;
			public override void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._appPrivateCommand4431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._appPrivateCommand4431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _toggleSoftInput4432;
			public override void toggleSoftInput(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._toggleSoftInput4432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._toggleSoftInput4432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl"));
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._finishInput4426 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "finishInput", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateSelection4427 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "updateSelection", "(IIIIII)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateCursor4428 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._displayCompletions4429 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateExtractedText4430 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._appPrivateCommand4431 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._toggleSoftInput4432 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "toggleSoftInput", "(II)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown4433;
		public abstract bool onKeyDown(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress4434;
		public abstract bool onKeyLongPress(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _onKeyUp4435;
		public abstract bool onKeyUp(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple4436;
		public abstract bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2);
		internal static global::MonoJavaBridge.MethodId _onBind4437;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService._onBind4437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._onBind4437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _dump4438;
		protected override void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService._dump4438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._dump4438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent4439;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent4439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent4439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeyDispatcherState4440;
		public virtual global::android.view.KeyEvent.DispatcherState getKeyDispatcherState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState4440)) as android.view.KeyEvent.DispatcherState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState4440)) as android.view.KeyEvent.DispatcherState;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodInterface4441;
		public abstract global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface();
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodSessionInterface4442;
		public abstract global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface();
		internal static global::MonoJavaBridge.MethodId _AbstractInputMethodService4443;
		public AbstractInputMethodService()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._AbstractInputMethodService4443);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.AbstractInputMethodService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService"));
			global::android.inputmethodservice.AbstractInputMethodService._onKeyDown4433 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onKeyLongPress4434 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onKeyUp4435 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onKeyMultiple4436 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onBind4437 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.inputmethodservice.AbstractInputMethodService._dump4438 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V");
			global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent4439 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState4440 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;");
			global::android.inputmethodservice.AbstractInputMethodService._onCreateInputMethodInterface4441 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;");
			global::android.inputmethodservice.AbstractInputMethodService._onCreateInputMethodSessionInterface4442 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;");
			global::android.inputmethodservice.AbstractInputMethodService._AbstractInputMethodService4443 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.inputmethodservice.AbstractInputMethodService))]
	public sealed partial class AbstractInputMethodService_ : android.inputmethodservice.AbstractInputMethodService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractInputMethodService_()
		{
			InitJNI();
		}
		internal AbstractInputMethodService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown4444;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onKeyDown4444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onKeyDown4444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress4445;
		public override bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onKeyLongPress4445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onKeyLongPress4445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp4446;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onKeyUp4446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onKeyUp4446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple4447;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onKeyMultiple4447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onKeyMultiple4447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodInterface4448;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodInterface4448)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodInterface4448)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodSessionInterface4449;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodSessionInterface4449)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodSessionInterface4449)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.AbstractInputMethodService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService"));
			global::android.inputmethodservice.AbstractInputMethodService_._onKeyDown4444 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService_._onKeyLongPress4445 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService_._onKeyUp4446 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService_._onKeyMultiple4447 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodInterface4448 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;");
			global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodSessionInterface4449 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;");
		}
	}
}
