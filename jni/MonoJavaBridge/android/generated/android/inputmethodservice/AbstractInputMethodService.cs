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
			internal static global::MonoJavaBridge.MethodId _attachToken6527;
			public abstract void attachToken(android.os.IBinder arg0);
			internal static global::MonoJavaBridge.MethodId _bindInput6528;
			public abstract void bindInput(android.view.inputmethod.InputBinding arg0);
			internal static global::MonoJavaBridge.MethodId _unbindInput6529;
			public abstract void unbindInput();
			internal static global::MonoJavaBridge.MethodId _startInput6530;
			public abstract void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
			internal static global::MonoJavaBridge.MethodId _restartInput6531;
			public abstract void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
			internal static global::MonoJavaBridge.MethodId _showSoftInput6532;
			public abstract void showSoftInput(int arg0, android.os.ResultReceiver arg1);
			internal static global::MonoJavaBridge.MethodId _hideSoftInput6533;
			public abstract void hideSoftInput(int arg0, android.os.ResultReceiver arg1);
			internal static global::MonoJavaBridge.MethodId _createSession6534;
			public virtual void createSession(android.view.inputmethod.InputMethod_SessionCallback arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession6534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession6534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public void createSession(global::android.view.inputmethod.InputMethod_SessionCallbackDelegate arg0)
			{
				createSession((global::android.view.inputmethod.InputMethod_SessionCallbackDelegateWrapper)arg0);
			}
			internal static global::MonoJavaBridge.MethodId _setSessionEnabled6535;
			public virtual void setSessionEnabled(android.view.inputmethod.InputMethodSession arg0, bool arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled6535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled6535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _revokeSession6536;
			public virtual void revokeSession(android.view.inputmethod.InputMethodSession arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession6536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession6536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _AbstractInputMethodImpl6537;
			public AbstractInputMethodImpl(android.inputmethodservice.AbstractInputMethodService arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._AbstractInputMethodImpl6537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl"));
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._attachToken6527 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "attachToken", "(Landroid/os/IBinder;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._bindInput6528 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._unbindInput6529 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "unbindInput", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._startInput6530 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._restartInput6531 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._showSoftInput6532 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._hideSoftInput6533 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession6534 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled6535 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession6536 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._AbstractInputMethodImpl6537 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl))]
		internal sealed partial class AbstractInputMethodImpl_ : android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AbstractInputMethodImpl_()
			{
				InitJNI();
			}
			internal AbstractInputMethodImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _attachToken6538;
			public override void attachToken(android.os.IBinder arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._attachToken6538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._attachToken6538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _bindInput6539;
			public override void bindInput(android.view.inputmethod.InputBinding arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._bindInput6539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._bindInput6539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _unbindInput6540;
			public override void unbindInput()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._unbindInput6540);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._unbindInput6540);
			}
			internal static global::MonoJavaBridge.MethodId _startInput6541;
			public override void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._startInput6541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._startInput6541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _restartInput6542;
			public override void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._restartInput6542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._restartInput6542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _showSoftInput6543;
			public override void showSoftInput(int arg0, android.os.ResultReceiver arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._showSoftInput6543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._showSoftInput6543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _hideSoftInput6544;
			public override void hideSoftInput(int arg0, android.os.ResultReceiver arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._hideSoftInput6544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._hideSoftInput6544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl"));
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._attachToken6538 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "attachToken", "(Landroid/os/IBinder;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._bindInput6539 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._unbindInput6540 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "unbindInput", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._startInput6541 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._restartInput6542 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._showSoftInput6543 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._hideSoftInput6544 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V");
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
			internal static global::MonoJavaBridge.MethodId _finishInput6545;
			public abstract void finishInput();
			internal static global::MonoJavaBridge.MethodId _updateSelection6546;
			public abstract void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);
			internal static global::MonoJavaBridge.MethodId _updateCursor6547;
			public abstract void updateCursor(android.graphics.Rect arg0);
			internal static global::MonoJavaBridge.MethodId _displayCompletions6548;
			public abstract void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0);
			internal static global::MonoJavaBridge.MethodId _updateExtractedText6549;
			public abstract void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1);
			internal static global::MonoJavaBridge.MethodId _appPrivateCommand6550;
			public abstract void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1);
			internal static global::MonoJavaBridge.MethodId _toggleSoftInput6551;
			public abstract void toggleSoftInput(int arg0, int arg1);
			internal static global::MonoJavaBridge.MethodId _isEnabled6552;
			public virtual bool isEnabled()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled6552);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled6552);
			}
			internal static global::MonoJavaBridge.MethodId _setEnabled6553;
			public virtual void setEnabled(bool arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled6553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled6553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent6554;
			public virtual void dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent6554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent6554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			public void dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, global::android.view.inputmethod.InputMethodSession_EventCallbackDelegate arg2)
			{
				dispatchKeyEvent(arg0, arg1, (global::android.view.inputmethod.InputMethodSession_EventCallbackDelegateWrapper)arg2);
			}
			internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent6555;
			public virtual void dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent6555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent6555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			public void dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, global::android.view.inputmethod.InputMethodSession_EventCallbackDelegate arg2)
			{
				dispatchTrackballEvent(arg0, arg1, (global::android.view.inputmethod.InputMethodSession_EventCallbackDelegateWrapper)arg2);
			}
			internal static global::MonoJavaBridge.MethodId _isRevoked6556;
			public virtual bool isRevoked()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked6556);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked6556);
			}
			internal static global::MonoJavaBridge.MethodId _revokeSelf6557;
			public virtual void revokeSelf()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf6557);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf6557);
			}
			internal static global::MonoJavaBridge.MethodId _AbstractInputMethodSessionImpl6558;
			public AbstractInputMethodSessionImpl(android.inputmethodservice.AbstractInputMethodService arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._AbstractInputMethodSessionImpl6558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl"));
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._finishInput6545 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "finishInput", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._updateSelection6546 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "updateSelection", "(IIIIII)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._updateCursor6547 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._displayCompletions6548 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._updateExtractedText6549 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._appPrivateCommand6550 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._toggleSoftInput6551 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "toggleSoftInput", "(II)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled6552 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "isEnabled", "()Z");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled6553 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "setEnabled", "(Z)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent6554 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "dispatchKeyEvent", "(ILandroid/view/KeyEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent6555 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "dispatchTrackballEvent", "(ILandroid/view/MotionEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked6556 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "isRevoked", "()Z");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf6557 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "revokeSelf", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._AbstractInputMethodSessionImpl6558 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl))]
		internal sealed partial class AbstractInputMethodSessionImpl_ : android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AbstractInputMethodSessionImpl_()
			{
				InitJNI();
			}
			internal AbstractInputMethodSessionImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _finishInput6559;
			public override void finishInput()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._finishInput6559);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._finishInput6559);
			}
			internal static global::MonoJavaBridge.MethodId _updateSelection6560;
			public override void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateSelection6560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateSelection6560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			}
			internal static global::MonoJavaBridge.MethodId _updateCursor6561;
			public override void updateCursor(android.graphics.Rect arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateCursor6561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateCursor6561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _displayCompletions6562;
			public override void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._displayCompletions6562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._displayCompletions6562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _updateExtractedText6563;
			public override void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateExtractedText6563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateExtractedText6563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _appPrivateCommand6564;
			public override void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._appPrivateCommand6564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._appPrivateCommand6564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _toggleSoftInput6565;
			public override void toggleSoftInput(int arg0, int arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._toggleSoftInput6565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._toggleSoftInput6565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl"));
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._finishInput6559 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "finishInput", "()V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateSelection6560 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "updateSelection", "(IIIIII)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateCursor6561 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._displayCompletions6562 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateExtractedText6563 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._appPrivateCommand6564 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V");
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._toggleSoftInput6565 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "toggleSoftInput", "(II)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown6566;
		public abstract bool onKeyDown(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress6567;
		public abstract bool onKeyLongPress(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _onKeyUp6568;
		public abstract bool onKeyUp(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple6569;
		public abstract bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2);
		internal static global::MonoJavaBridge.MethodId _onBind6570;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService._onBind6570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._onBind6570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _dump6571;
		protected override void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService._dump6571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._dump6571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent6572;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent6572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent6572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeyDispatcherState6573;
		public virtual global::android.view.KeyEvent.DispatcherState getKeyDispatcherState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState6573)) as android.view.KeyEvent.DispatcherState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState6573)) as android.view.KeyEvent.DispatcherState;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodInterface6574;
		public abstract global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface();
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodSessionInterface6575;
		public abstract global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface();
		internal static global::MonoJavaBridge.MethodId _AbstractInputMethodService6576;
		public AbstractInputMethodService() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._AbstractInputMethodService6576);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.AbstractInputMethodService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService"));
			global::android.inputmethodservice.AbstractInputMethodService._onKeyDown6566 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onKeyLongPress6567 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onKeyUp6568 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onKeyMultiple6569 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._onBind6570 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.inputmethodservice.AbstractInputMethodService._dump6571 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V");
			global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent6572 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState6573 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;");
			global::android.inputmethodservice.AbstractInputMethodService._onCreateInputMethodInterface6574 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;");
			global::android.inputmethodservice.AbstractInputMethodService._onCreateInputMethodSessionInterface6575 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;");
			global::android.inputmethodservice.AbstractInputMethodService._AbstractInputMethodService6576 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.inputmethodservice.AbstractInputMethodService))]
	internal sealed partial class AbstractInputMethodService_ : android.inputmethodservice.AbstractInputMethodService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractInputMethodService_()
		{
			InitJNI();
		}
		internal AbstractInputMethodService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown6577;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onKeyDown6577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onKeyDown6577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress6578;
		public override bool onKeyLongPress(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onKeyLongPress6578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onKeyLongPress6578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp6579;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onKeyUp6579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onKeyUp6579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple6580;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onKeyMultiple6580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onKeyMultiple6580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodInterface6581;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodInterface6581)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodInterface6581)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodSessionInterface6582;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodSessionInterface6582)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodSessionInterface6582)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.AbstractInputMethodService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService"));
			global::android.inputmethodservice.AbstractInputMethodService_._onKeyDown6577 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService_._onKeyLongPress6578 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService_._onKeyUp6579 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService_._onKeyMultiple6580 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodInterface6581 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;");
			global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodSessionInterface6582 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;");
		}
	}
}
