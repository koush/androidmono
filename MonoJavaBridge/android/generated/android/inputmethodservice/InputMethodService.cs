namespace android.inputmethodservice
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InputMethodService : android.inputmethodservice.AbstractInputMethodService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InputMethodService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class InputMethodImpl : android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected InputMethodImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override void attachToken(android.os.IBinder arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "attachToken", "(Landroid/os/IBinder;)V", ref global::android.inputmethodservice.InputMethodService.InputMethodImpl._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override void bindInput(android.view.inputmethod.InputBinding arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V", ref global::android.inputmethodservice.InputMethodService.InputMethodImpl._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public override void unbindInput()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "unbindInput", "()V", ref global::android.inputmethodservice.InputMethodService.InputMethodImpl._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public override void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V", ref global::android.inputmethodservice.InputMethodService.InputMethodImpl._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public override void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V", ref global::android.inputmethodservice.InputMethodService.InputMethodImpl._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public override void showSoftInput(int arg0, android.os.ResultReceiver arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V", ref global::android.inputmethodservice.InputMethodService.InputMethodImpl._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public override void hideSoftInput(int arg0, android.os.ResultReceiver arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V", ref global::android.inputmethodservice.InputMethodService.InputMethodImpl._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public InputMethodImpl(android.inputmethodservice.InputMethodService arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.inputmethodservice.InputMethodService.InputMethodImpl._m7.native == global::System.IntPtr.Zero)
					global::android.inputmethodservice.InputMethodService.InputMethodImpl._m7 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "<init>", "(Landroid/inputmethodservice/InputMethodService;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static InputMethodImpl()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/InputMethodService$InputMethodImpl"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class InputMethodSessionImpl : android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected InputMethodSessionImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override void finishInput()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "finishInput", "()V", ref global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateSelection", "(IIIIII)V", ref global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public override void updateCursor(android.graphics.Rect arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V", ref global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public override void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V", ref global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public override void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V", ref global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public override void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V", ref global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public override void toggleSoftInput(int arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "toggleSoftInput", "(II)V", ref global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public InputMethodSessionImpl(android.inputmethodservice.InputMethodService arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._m7.native == global::System.IntPtr.Zero)
					global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._m7 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "<init>", "(Landroid/inputmethodservice/InputMethodService;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static InputMethodSessionImpl()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/InputMethodService$InputMethodSessionImpl"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Insets : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Insets(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public Insets() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.inputmethodservice.InputMethodService.Insets._m0.native == global::System.IntPtr.Zero)
					global::android.inputmethodservice.InputMethodService.Insets._m0 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.Insets.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.InputMethodService.Insets.staticClass, global::android.inputmethodservice.InputMethodService.Insets._m0);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _contentTopInsets2557;
			public int contentTopInsets
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _contentTopInsets2557);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _visibleTopInsets2558;
			public int visibleTopInsets
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _visibleTopInsets2558);
				}
				set
				{
				}
			}
			public static int TOUCHABLE_INSETS_FRAME
			{
				get
				{
					return 0;
				}
			}
			public static int TOUCHABLE_INSETS_CONTENT
			{
				get
				{
					return 1;
				}
			}
			public static int TOUCHABLE_INSETS_VISIBLE
			{
				get
				{
					return 2;
				}
			}
			internal static global::MonoJavaBridge.FieldId _touchableInsets2562;
			public int touchableInsets
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _touchableInsets2562);
				}
				set
				{
				}
			}
			static Insets()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.InputMethodService.Insets.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/InputMethodService$Insets"));
				global::android.inputmethodservice.InputMethodService.Insets._contentTopInsets2557 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.InputMethodService.Insets.staticClass, "contentTopInsets", "I");
				global::android.inputmethodservice.InputMethodService.Insets._visibleTopInsets2558 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.InputMethodService.Insets.staticClass, "visibleTopInsets", "I");
				global::android.inputmethodservice.InputMethodService.Insets._touchableInsets2562 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.InputMethodService.Insets.staticClass, "touchableInsets", "I");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void switchInputMethod(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "switchInputMethod", "(Ljava/lang/String;)V", ref global::android.inputmethodservice.InputMethodService._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void onCreate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onCreate", "()V", ref global::android.inputmethodservice.InputMethodService._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onDestroy", "()V", ref global::android.inputmethodservice.InputMethodService._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V", ref global::android.inputmethodservice.InputMethodService._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", ref global::android.inputmethodservice.InputMethodService._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int Theme
		{
			set
			{
				setTheme(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void setTheme(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "setTheme", "(I)V", ref global::android.inputmethodservice.InputMethodService._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.app.Dialog Window
		{
			get
			{
				return getWindow();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.app.Dialog getWindow()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "getWindow", "()Landroid/app/Dialog;", ref global::android.inputmethodservice.InputMethodService._m6) as android.app.Dialog;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.inputmethodservice.InputMethodService._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool onKeyLongPress(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", ref global::android.inputmethodservice.InputMethodService._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.inputmethodservice.InputMethodService._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", ref global::android.inputmethodservice.InputMethodService._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.inputmethodservice.InputMethodService._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.LayoutInflater LayoutInflater
		{
			get
			{
				return getLayoutInflater();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::android.view.LayoutInflater getLayoutInflater()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;", ref global::android.inputmethodservice.InputMethodService._m12) as android.view.LayoutInflater;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;", ref global::android.inputmethodservice.InputMethodService._m13) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;", ref global::android.inputmethodservice.InputMethodService._m14) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void onInitializeInterface()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onInitializeInterface", "()V", ref global::android.inputmethodservice.InputMethodService._m15);
		}
		public new int MaxWidth
		{
			get
			{
				return getMaxWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int getMaxWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "getMaxWidth", "()I", ref global::android.inputmethodservice.InputMethodService._m16);
		}
		public new global::android.view.inputmethod.InputBinding CurrentInputBinding
		{
			get
			{
				return getCurrentInputBinding();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::android.view.inputmethod.InputBinding getCurrentInputBinding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.view.inputmethod.InputBinding>(this, global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputBinding", "()Landroid/view/inputmethod/InputBinding;", ref global::android.inputmethodservice.InputMethodService._m17) as android.view.inputmethod.InputBinding;
		}
		public new global::android.view.inputmethod.InputConnection CurrentInputConnection
		{
			get
			{
				return getCurrentInputConnection();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::android.view.inputmethod.InputConnection getCurrentInputConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.inputmethod.InputConnection>(this, global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputConnection", "()Landroid/view/inputmethod/InputConnection;", ref global::android.inputmethodservice.InputMethodService._m18) as android.view.inputmethod.InputConnection;
		}
		public new bool CurrentInputStarted
		{
			get
			{
				return getCurrentInputStarted();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool getCurrentInputStarted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputStarted", "()Z", ref global::android.inputmethodservice.InputMethodService._m19);
		}
		public new global::android.view.inputmethod.EditorInfo CurrentInputEditorInfo
		{
			get
			{
				return getCurrentInputEditorInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::android.view.inputmethod.EditorInfo getCurrentInputEditorInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputEditorInfo", "()Landroid/view/inputmethod/EditorInfo;", ref global::android.inputmethodservice.InputMethodService._m20) as android.view.inputmethod.EditorInfo;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void updateFullscreenMode()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "updateFullscreenMode", "()V", ref global::android.inputmethodservice.InputMethodService._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void onConfigureWindow(android.view.Window arg0, bool arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onConfigureWindow", "(Landroid/view/Window;ZZ)V", ref global::android.inputmethodservice.InputMethodService._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool isFullscreenMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "isFullscreenMode", "()Z", ref global::android.inputmethodservice.InputMethodService._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool onEvaluateFullscreenMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onEvaluateFullscreenMode", "()Z", ref global::android.inputmethodservice.InputMethodService._m24);
		}
		public new bool ExtractViewShown
		{
			set
			{
				setExtractViewShown(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setExtractViewShown(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "setExtractViewShown", "(Z)V", ref global::android.inputmethodservice.InputMethodService._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool isExtractViewShown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "isExtractViewShown", "()Z", ref global::android.inputmethodservice.InputMethodService._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void onComputeInsets(android.inputmethodservice.InputMethodService.Insets arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onComputeInsets", "(Landroid/inputmethodservice/InputMethodService$Insets;)V", ref global::android.inputmethodservice.InputMethodService._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void updateInputViewShown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "updateInputViewShown", "()V", ref global::android.inputmethodservice.InputMethodService._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool isShowInputRequested()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "isShowInputRequested", "()Z", ref global::android.inputmethodservice.InputMethodService._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual bool isInputViewShown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "isInputViewShown", "()Z", ref global::android.inputmethodservice.InputMethodService._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual bool onEvaluateInputViewShown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onEvaluateInputViewShown", "()Z", ref global::android.inputmethodservice.InputMethodService._m31);
		}
		public new bool CandidatesViewShown
		{
			set
			{
				setCandidatesViewShown(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setCandidatesViewShown(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "setCandidatesViewShown", "(Z)V", ref global::android.inputmethodservice.InputMethodService._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CandidatesHiddenVisibility
		{
			get
			{
				return getCandidatesHiddenVisibility();
			}
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual int getCandidatesHiddenVisibility()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "getCandidatesHiddenVisibility", "()I", ref global::android.inputmethodservice.InputMethodService._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void showStatusIcon(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "showStatusIcon", "(I)V", ref global::android.inputmethodservice.InputMethodService._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void hideStatusIcon()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "hideStatusIcon", "()V", ref global::android.inputmethodservice.InputMethodService._m35);
		}
		public new global::android.view.View ExtractView
		{
			set
			{
				setExtractView(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void setExtractView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "setExtractView", "(Landroid/view/View;)V", ref global::android.inputmethodservice.InputMethodService._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View CandidatesView
		{
			set
			{
				setCandidatesView(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void setCandidatesView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "setCandidatesView", "(Landroid/view/View;)V", ref global::android.inputmethodservice.InputMethodService._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View InputView
		{
			set
			{
				setInputView(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual void setInputView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "setInputView", "(Landroid/view/View;)V", ref global::android.inputmethodservice.InputMethodService._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual global::android.view.View onCreateExtractTextView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onCreateExtractTextView", "()Landroid/view/View;", ref global::android.inputmethodservice.InputMethodService._m39) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::android.view.View onCreateCandidatesView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onCreateCandidatesView", "()Landroid/view/View;", ref global::android.inputmethodservice.InputMethodService._m40) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual global::android.view.View onCreateInputView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputView", "()Landroid/view/View;", ref global::android.inputmethodservice.InputMethodService._m41) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual void onStartInputView(android.view.inputmethod.EditorInfo arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onStartInputView", "(Landroid/view/inputmethod/EditorInfo;Z)V", ref global::android.inputmethodservice.InputMethodService._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual void onFinishInputView(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onFinishInputView", "(Z)V", ref global::android.inputmethodservice.InputMethodService._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual void onStartCandidatesView(android.view.inputmethod.EditorInfo arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onStartCandidatesView", "(Landroid/view/inputmethod/EditorInfo;Z)V", ref global::android.inputmethodservice.InputMethodService._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual void onFinishCandidatesView(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onFinishCandidatesView", "(Z)V", ref global::android.inputmethodservice.InputMethodService._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual bool onShowInputRequested(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onShowInputRequested", "(IZ)Z", ref global::android.inputmethodservice.InputMethodService._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual void showWindow(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "showWindow", "(Z)V", ref global::android.inputmethodservice.InputMethodService._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual void hideWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "hideWindow", "()V", ref global::android.inputmethodservice.InputMethodService._m48);
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual void onWindowShown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onWindowShown", "()V", ref global::android.inputmethodservice.InputMethodService._m49);
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual void onWindowHidden()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onWindowHidden", "()V", ref global::android.inputmethodservice.InputMethodService._m50);
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual void onBindInput()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onBindInput", "()V", ref global::android.inputmethodservice.InputMethodService._m51);
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public virtual void onUnbindInput()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onUnbindInput", "()V", ref global::android.inputmethodservice.InputMethodService._m52);
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public virtual void onStartInput(android.view.inputmethod.EditorInfo arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onStartInput", "(Landroid/view/inputmethod/EditorInfo;Z)V", ref global::android.inputmethodservice.InputMethodService._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public virtual void onFinishInput()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onFinishInput", "()V", ref global::android.inputmethodservice.InputMethodService._m54);
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public virtual void onDisplayCompletions(android.view.inputmethod.CompletionInfo[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onDisplayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V", ref global::android.inputmethodservice.InputMethodService._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public virtual void onUpdateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V", ref global::android.inputmethodservice.InputMethodService._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public virtual void onUpdateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateSelection", "(IIIIII)V", ref global::android.inputmethodservice.InputMethodService._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public virtual void onUpdateCursor(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateCursor", "(Landroid/graphics/Rect;)V", ref global::android.inputmethodservice.InputMethodService._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public virtual void requestHideSelf(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "requestHideSelf", "(I)V", ref global::android.inputmethodservice.InputMethodService._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public virtual void onAppPrivateCommand(java.lang.String arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onAppPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V", ref global::android.inputmethodservice.InputMethodService._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public virtual void sendDownUpKeyEvents(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "sendDownUpKeyEvents", "(I)V", ref global::android.inputmethodservice.InputMethodService._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public virtual bool sendDefaultEditorAction(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "sendDefaultEditorAction", "(Z)Z", ref global::android.inputmethodservice.InputMethodService._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public virtual void sendKeyChar(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "sendKeyChar", "(C)V", ref global::android.inputmethodservice.InputMethodService._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public virtual void onExtractedSelectionChanged(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedSelectionChanged", "(II)V", ref global::android.inputmethodservice.InputMethodService._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public virtual void onExtractedTextClicked()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedTextClicked", "()V", ref global::android.inputmethodservice.InputMethodService._m65);
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public virtual void onExtractedCursorMovement(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedCursorMovement", "(II)V", ref global::android.inputmethodservice.InputMethodService._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public virtual bool onExtractTextContextMenuItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onExtractTextContextMenuItem", "(I)Z", ref global::android.inputmethodservice.InputMethodService._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public virtual global::java.lang.CharSequence getTextForImeAction(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.inputmethodservice.InputMethodService.staticClass, "getTextForImeAction", "(I)Ljava/lang/CharSequence;", ref global::android.inputmethodservice.InputMethodService._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public virtual void onUpdateExtractingVisibility(android.view.inputmethod.EditorInfo arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractingVisibility", "(Landroid/view/inputmethod/EditorInfo;)V", ref global::android.inputmethodservice.InputMethodService._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public virtual void onUpdateExtractingViews(android.view.inputmethod.EditorInfo arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractingViews", "(Landroid/view/inputmethod/EditorInfo;)V", ref global::android.inputmethodservice.InputMethodService._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public virtual void onExtractingInputChanged(android.view.inputmethod.EditorInfo arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, "onExtractingInputChanged", "(Landroid/view/inputmethod/EditorInfo;)V", ref global::android.inputmethodservice.InputMethodService._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public InputMethodService() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.InputMethodService._m72.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.InputMethodService._m72 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._m72);
			Init(@__env, handle);
		}
		static InputMethodService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.InputMethodService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/InputMethodService"));
		}
		internal static void InitJNI()
		{
		}
	}
}
