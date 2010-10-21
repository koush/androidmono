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
			internal static global::MonoJavaBridge.MethodId _attachToken6502;
			public abstract void attachToken(android.os.IBinder arg0);
			internal static global::MonoJavaBridge.MethodId _bindInput6503;
			public abstract void bindInput(android.view.inputmethod.InputBinding arg0);
			internal static global::MonoJavaBridge.MethodId _unbindInput6504;
			public abstract void unbindInput();
			internal static global::MonoJavaBridge.MethodId _startInput6505;
			public abstract void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
			internal static global::MonoJavaBridge.MethodId _restartInput6506;
			public abstract void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
			internal static global::MonoJavaBridge.MethodId _showSoftInput6507;
			public abstract void showSoftInput(int arg0, android.os.ResultReceiver arg1);
			internal static global::MonoJavaBridge.MethodId _hideSoftInput6508;
			public abstract void hideSoftInput(int arg0, android.os.ResultReceiver arg1);
			internal static global::MonoJavaBridge.MethodId _createSession6509;
			public virtual void createSession(android.view.inputmethod.InputMethod_SessionCallback arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession6509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession6509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _setSessionEnabled6510;
			public virtual void setSessionEnabled(android.view.inputmethod.InputMethodSession arg0, bool arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled6510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled6510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _revokeSession6511;
			public virtual void revokeSession(android.view.inputmethod.InputMethodSession arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession6511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession6511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _AbstractInputMethodImpl6512;
			public AbstractInputMethodImpl(android.inputmethodservice.AbstractInputMethodService arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._AbstractInputMethodImpl6512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl"));
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._attachToken6502 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "attachToken", "(Landroid/os/IBinder;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._bindInput6503 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._unbindInput6504 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "unbindInput", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._startInput6505 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._restartInput6506 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._showSoftInput6507 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._hideSoftInput6508 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession6509 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled6510 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession6511 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._AbstractInputMethodImpl6512 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V");
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
			internal static global::MonoJavaBridge.MethodId _attachToken6513;
			public override void attachToken(android.os.IBinder arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._attachToken6513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._attachToken6513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _bindInput6514;
			public override void bindInput(android.view.inputmethod.InputBinding arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._bindInput6514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._bindInput6514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _unbindInput6515;
			public override void unbindInput() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._unbindInput6515);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._unbindInput6515);
			}
			internal static global::MonoJavaBridge.MethodId _startInput6516;
			public override void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._startInput6516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._startInput6516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _restartInput6517;
			public override void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._restartInput6517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._restartInput6517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _showSoftInput6518;
			public override void showSoftInput(int arg0, android.os.ResultReceiver arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._showSoftInput6518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._showSoftInput6518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _hideSoftInput6519;
			public override void hideSoftInput(int arg0, android.os.ResultReceiver arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._hideSoftInput6519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._hideSoftInput6519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl"));
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._attachToken6513 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "attachToken", "(Landroid/os/IBinder;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._bindInput6514 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._unbindInput6515 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "unbindInput", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._startInput6516 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._restartInput6517 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._showSoftInput6518 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._hideSoftInput6519 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V");
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
			internal static global::MonoJavaBridge.MethodId _finishInput6520;
			public abstract void finishInput();
			internal static global::MonoJavaBridge.MethodId _updateSelection6521;
			public abstract void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);
			internal static global::MonoJavaBridge.MethodId _updateCursor6522;
			public abstract void updateCursor(android.graphics.Rect arg0);
			internal static global::MonoJavaBridge.MethodId _displayCompletions6523;
			public abstract void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0);
			internal static global::MonoJavaBridge.MethodId _updateExtractedText6524;
			public abstract void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1);
			internal static global::MonoJavaBridge.MethodId _appPrivateCommand6525;
			public abstract void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1);
			internal static global::MonoJavaBridge.MethodId _toggleSoftInput6526;
			public abstract void toggleSoftInput(int arg0, int arg1);
			internal static global::MonoJavaBridge.MethodId _isEnabled6527;
			public virtual bool isEnabled() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled6527);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled6527);
			}
			internal static global::MonoJavaBridge.MethodId _setEnabled6528;
			public virtual void setEnabled(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled6528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled6528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent6529;
			public virtual void dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent6529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent6529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent6530;
			public virtual void dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent6530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent6530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _isRevoked6531;
			public virtual bool isRevoked() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked6531);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked6531);
			}
			internal static global::MonoJavaBridge.MethodId _revokeSelf6532;
			public virtual void revokeSelf() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf6532);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf6532);
			}
			internal static global::MonoJavaBridge.MethodId _AbstractInputMethodSessionImpl6533;
			public AbstractInputMethodSessionImpl(android.inputmethodservice.AbstractInputMethodService arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._AbstractInputMethodSessionImpl6533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl"));
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._finishInput6520 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "finishInput", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._updateSelection6521 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "updateSelection", "(IIIIII)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._updateCursor6522 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._displayCompletions6523 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._updateExtractedText6524 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._appPrivateCommand6525 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._toggleSoftInput6526 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "toggleSoftInput", "(II)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled6527 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "isEnabled", "()Z");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled6528 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "setEnabled", "(Z)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent6529 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "dispatchKeyEvent", "(ILandroid/view/KeyEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent6530 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "dispatchTrackballEvent", "(ILandroid/view/MotionEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked6531 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "isRevoked", "()Z");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf6532 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "revokeSelf", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._AbstractInputMethodSessionImpl6533 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V");
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
			internal static global::MonoJavaBridge.MethodId _finishInput6534;
			public override void finishInput() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._finishInput6534);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._finishInput6534);
			}
			internal static global::MonoJavaBridge.MethodId _updateSelection6535;
			public override void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateSelection6535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateSelection6535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			}
			internal static global::MonoJavaBridge.MethodId _updateCursor6536;
			public override void updateCursor(android.graphics.Rect arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateCursor6536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateCursor6536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _displayCompletions6537;
			public override void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._displayCompletions6537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._displayCompletions6537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _updateExtractedText6538;
			public override void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateExtractedText6538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateExtractedText6538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _appPrivateCommand6539;
			public override void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._appPrivateCommand6539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._appPrivateCommand6539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _toggleSoftInput6540;
			public override void toggleSoftInput(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._toggleSoftInput6540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._toggleSoftInput6540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl"));
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._finishInput6534 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "finishInput", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateSelection6535 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "updateSelection", "(IIIIII)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateCursor6536 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._displayCompletions6537 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateExtractedText6538 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._appPrivateCommand6539 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._toggleSoftInput6540 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "toggleSoftInput", "(II)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown6541;
		public abstract bool onKeyDown(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress6542;
		public abstract bool onKeyLongPress(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _onKeyUp6543;
		public abstract bool onKeyUp(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple6544;
		public abstract bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2);
		internal static global::MonoJavaBridge.MethodId _onBind6545;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService._onBind6545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._onBind6545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _dump6546;
		protected override void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService._dump6546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._dump6546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent6547;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent6547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent6547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeyDispatcherState6548;
		public virtual global::android.view.KeyEvent.DispatcherState getKeyDispatcherState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState6548)) as android.view.KeyEvent.DispatcherState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState6548)) as android.view.KeyEvent.DispatcherState;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodInterface6549;
		public abstract global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface();
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodSessionInterface6550;
		public abstract global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface();
		internal static global::MonoJavaBridge.MethodId _AbstractInputMethodService6551;
		public AbstractInputMethodService()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._AbstractInputMethodService6551);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.AbstractInputMethodService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService"));
			global::android.inputmethodservice.AbstractInputMethodService._onKeyDown6541 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onKeyLongPress6542 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onKeyUp6543 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onKeyMultiple6544 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onBind6545 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.inputmethodservice.AbstractInputMethodService._dump6546 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V");
			global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent6547 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState6548 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;");
			global::android.inputmethodservice.AbstractInputMethodService._onCreateInputMethodInterface6549 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;");
			global::android.inputmethodservice.AbstractInputMethodService._onCreateInputMethodSessionInterface6550 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;");
			global::android.inputmethodservice.AbstractInputMethodService._AbstractInputMethodService6551 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _onKeyDown6552;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onKeyDown6552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onKeyDown6552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress6553;
		public override bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onKeyLongPress6553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onKeyLongPress6553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp6554;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onKeyUp6554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onKeyUp6554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple6555;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onKeyMultiple6555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onKeyMultiple6555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodInterface6556;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodInterface6556)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodInterface6556)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodSessionInterface6557;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodSessionInterface6557)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodSessionInterface6557)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.AbstractInputMethodService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService"));
			global::android.inputmethodservice.AbstractInputMethodService_._onKeyDown6552 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService_._onKeyLongPress6553 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService_._onKeyUp6554 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService_._onKeyMultiple6555 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodInterface6556 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;");
			global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodSessionInterface6557 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;");
		}
	}
}
