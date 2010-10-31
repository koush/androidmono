namespace android.inputmethodservice
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.inputmethodservice.AbstractInputMethodService_))]
	public abstract partial class AbstractInputMethodService : android.app.Service, android.view.KeyEvent.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractInputMethodService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_))]
		public abstract partial class AbstractInputMethodImpl : java.lang.Object, android.view.inputmethod.InputMethod
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AbstractInputMethodImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public abstract void attachToken(android.os.IBinder arg0);
			private static global::MonoJavaBridge.MethodId _m1;
			public abstract void bindInput(android.view.inputmethod.InputBinding arg0);
			private static global::MonoJavaBridge.MethodId _m2;
			public abstract void unbindInput();
			private static global::MonoJavaBridge.MethodId _m3;
			public abstract void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
			private static global::MonoJavaBridge.MethodId _m4;
			public abstract void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
			private static global::MonoJavaBridge.MethodId _m5;
			public abstract void showSoftInput(int arg0, android.os.ResultReceiver arg1);
			private static global::MonoJavaBridge.MethodId _m6;
			public abstract void hideSoftInput(int arg0, android.os.ResultReceiver arg1);
			private static global::MonoJavaBridge.MethodId _m7;
			public virtual void createSession(android.view.inputmethod.InputMethod_SessionCallback arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public void createSession(global::android.view.inputmethod.InputMethod_SessionCallbackDelegate arg0)
			{
				createSession((global::android.view.inputmethod.InputMethod_SessionCallbackDelegateWrapper)arg0);
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public virtual void setSessionEnabled(android.view.inputmethod.InputMethodSession arg0, bool arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m9;
			public virtual void revokeSession(android.view.inputmethod.InputMethodSession arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m10;
			public AbstractInputMethodImpl(android.inputmethodservice.AbstractInputMethodService arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._m10.native == global::System.IntPtr.Zero)
					global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._m10 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static AbstractInputMethodImpl()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl"));
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl))]
		internal sealed partial class AbstractInputMethodImpl_ : android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal AbstractInputMethodImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override void attachToken(android.os.IBinder arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "attachToken", "(Landroid/os/IBinder;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override void bindInput(android.view.inputmethod.InputBinding arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public override void unbindInput()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "unbindInput", "()V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public override void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public override void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public override void showSoftInput(int arg0, android.os.ResultReceiver arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public override void hideSoftInput(int arg0, android.os.ResultReceiver arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static AbstractInputMethodImpl_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl"));
			}
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_))]
		public abstract partial class AbstractInputMethodSessionImpl : java.lang.Object, android.view.inputmethod.InputMethodSession
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AbstractInputMethodSessionImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public abstract void finishInput();
			private static global::MonoJavaBridge.MethodId _m1;
			public abstract void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);
			private static global::MonoJavaBridge.MethodId _m2;
			public abstract void updateCursor(android.graphics.Rect arg0);
			private static global::MonoJavaBridge.MethodId _m3;
			public abstract void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0);
			private static global::MonoJavaBridge.MethodId _m4;
			public abstract void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1);
			private static global::MonoJavaBridge.MethodId _m5;
			public abstract void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1);
			private static global::MonoJavaBridge.MethodId _m6;
			public abstract void toggleSoftInput(int arg0, int arg1);
			private static global::MonoJavaBridge.MethodId _m7;
			public virtual bool isEnabled()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "isEnabled", "()Z", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._m7);
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public virtual void setEnabled(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "setEnabled", "(Z)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m9;
			public virtual void dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "dispatchKeyEvent", "(ILandroid/view/KeyEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			public void dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, global::android.view.inputmethod.InputMethodSession_EventCallbackDelegate arg2)
			{
				dispatchKeyEvent(arg0, arg1, (global::android.view.inputmethod.InputMethodSession_EventCallbackDelegateWrapper)arg2);
			}
			private static global::MonoJavaBridge.MethodId _m10;
			public virtual void dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "dispatchTrackballEvent", "(ILandroid/view/MotionEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			public void dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, global::android.view.inputmethod.InputMethodSession_EventCallbackDelegate arg2)
			{
				dispatchTrackballEvent(arg0, arg1, (global::android.view.inputmethod.InputMethodSession_EventCallbackDelegateWrapper)arg2);
			}
			private static global::MonoJavaBridge.MethodId _m11;
			public virtual bool isRevoked()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "isRevoked", "()Z", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._m11);
			}
			private static global::MonoJavaBridge.MethodId _m12;
			public virtual void revokeSelf()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "revokeSelf", "()V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._m12);
			}
			private static global::MonoJavaBridge.MethodId _m13;
			public AbstractInputMethodSessionImpl(android.inputmethodservice.AbstractInputMethodService arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._m13.native == global::System.IntPtr.Zero)
					global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._m13 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static AbstractInputMethodSessionImpl()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl"));
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl))]
		internal sealed partial class AbstractInputMethodSessionImpl_ : android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal AbstractInputMethodSessionImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override void finishInput()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "finishInput", "()V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "updateSelection", "(IIIIII)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public override void updateCursor(android.graphics.Rect arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public override void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public override void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public override void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public override void toggleSoftInput(int arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "toggleSoftInput", "(II)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static AbstractInputMethodSessionImpl_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract bool onKeyDown(int arg0, android.view.KeyEvent arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract bool onKeyLongPress(int arg0, android.view.KeyEvent arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract bool onKeyUp(int arg0, android.view.KeyEvent arg1);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2);
		private static global::MonoJavaBridge.MethodId _m4;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", ref global::android.inputmethodservice.AbstractInputMethodService._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.IBinder;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", ref global::android.inputmethodservice.AbstractInputMethodService._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.inputmethodservice.AbstractInputMethodService._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.view.KeyEvent.DispatcherState getKeyDispatcherState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, "getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;", ref global::android.inputmethodservice.AbstractInputMethodService._m7) as android.view.KeyEvent.DispatcherState;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface();
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface();
		private static global::MonoJavaBridge.MethodId _m10;
		public AbstractInputMethodService() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.AbstractInputMethodService._m10.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.AbstractInputMethodService._m10 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._m10);
			Init(@__env, handle);
		}
		static AbstractInputMethodService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.AbstractInputMethodService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.inputmethodservice.AbstractInputMethodService))]
	internal sealed partial class AbstractInputMethodService_ : android.inputmethodservice.AbstractInputMethodService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractInputMethodService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.inputmethodservice.AbstractInputMethodService_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool onKeyLongPress(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", ref global::android.inputmethodservice.AbstractInputMethodService_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.inputmethodservice.AbstractInputMethodService_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", ref global::android.inputmethodservice.AbstractInputMethodService_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;", ref global::android.inputmethodservice.AbstractInputMethodService_._m4) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;", ref global::android.inputmethodservice.AbstractInputMethodService_._m5) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl;
		}
		static AbstractInputMethodService_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.AbstractInputMethodService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService"));
		}
	}
}
