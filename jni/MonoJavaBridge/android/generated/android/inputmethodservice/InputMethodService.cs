namespace android.inputmethodservice
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InputMethodService : android.inputmethodservice.AbstractInputMethodService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputMethodService()
		{
			InitJNI();
		}
		protected InputMethodService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class InputMethodImpl : android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static InputMethodImpl()
			{
				InitJNI();
			}
			protected InputMethodImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _attachToken4464;
			public override void attachToken(android.os.IBinder arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl._attachToken4464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._attachToken4464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _bindInput4465;
			public override void bindInput(android.view.inputmethod.InputBinding arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl._bindInput4465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._bindInput4465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _unbindInput4466;
			public override void unbindInput() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl._unbindInput4466);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._unbindInput4466);
			}
			internal static global::MonoJavaBridge.MethodId _startInput4467;
			public override void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl._startInput4467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._startInput4467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _restartInput4468;
			public override void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl._restartInput4468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._restartInput4468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _showSoftInput4469;
			public override void showSoftInput(int arg0, android.os.ResultReceiver arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl._showSoftInput4469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._showSoftInput4469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _hideSoftInput4470;
			public override void hideSoftInput(int arg0, android.os.ResultReceiver arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl._hideSoftInput4470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._hideSoftInput4470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _InputMethodImpl4471;
			public InputMethodImpl(android.inputmethodservice.InputMethodService arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._InputMethodImpl4471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/InputMethodService$InputMethodImpl"));
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._attachToken4464 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "attachToken", "(Landroid/os/IBinder;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._bindInput4465 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._unbindInput4466 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "unbindInput", "()V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._startInput4467 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._restartInput4468 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._showSoftInput4469 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._hideSoftInput4470 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._InputMethodImpl4471 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "<init>", "(Landroid/inputmethodservice/InputMethodService;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class InputMethodSessionImpl : android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static InputMethodSessionImpl()
			{
				InitJNI();
			}
			protected InputMethodSessionImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _finishInput4472;
			public override void finishInput() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._finishInput4472);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._finishInput4472);
			}
			internal static global::MonoJavaBridge.MethodId _updateSelection4473;
			public override void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateSelection4473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateSelection4473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			}
			internal static global::MonoJavaBridge.MethodId _updateCursor4474;
			public override void updateCursor(android.graphics.Rect arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateCursor4474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateCursor4474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _displayCompletions4475;
			public override void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._displayCompletions4475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._displayCompletions4475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _updateExtractedText4476;
			public override void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateExtractedText4476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateExtractedText4476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _appPrivateCommand4477;
			public override void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._appPrivateCommand4477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._appPrivateCommand4477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _toggleSoftInput4478;
			public override void toggleSoftInput(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._toggleSoftInput4478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._toggleSoftInput4478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _InputMethodSessionImpl4479;
			public InputMethodSessionImpl(android.inputmethodservice.InputMethodService arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._InputMethodSessionImpl4479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/InputMethodService$InputMethodSessionImpl"));
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._finishInput4472 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "finishInput", "()V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateSelection4473 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateSelection", "(IIIIII)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateCursor4474 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._displayCompletions4475 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateExtractedText4476 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._appPrivateCommand4477 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._toggleSoftInput4478 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "toggleSoftInput", "(II)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._InputMethodSessionImpl4479 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "<init>", "(Landroid/inputmethodservice/InputMethodService;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Insets : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Insets()
			{
				InitJNI();
			}
			internal Insets(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _Insets4480;
			public Insets()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.InputMethodService.Insets.staticClass, global::android.inputmethodservice.InputMethodService.Insets._Insets4480);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _contentTopInsets4481;
			public int contentTopInsets
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _visibleTopInsets4482;
			public int visibleTopInsets
			{
				get
				{
					return default(int);
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
			internal static global::MonoJavaBridge.FieldId _touchableInsets4483;
			public int touchableInsets
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.InputMethodService.Insets.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/InputMethodService$Insets"));
				global::android.inputmethodservice.InputMethodService.Insets._Insets4480 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.Insets.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _switchInputMethod4484;
		public virtual void switchInputMethod(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._switchInputMethod4484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._switchInputMethod4484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreate4485;
		public override void onCreate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onCreate4485);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreate4485);
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy4486;
		public override void onDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onDestroy4486);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onDestroy4486);
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged4487;
		public override void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onConfigurationChanged4487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onConfigurationChanged4487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dump4488;
		protected override void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._dump4488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._dump4488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTheme4489;
		public override void setTheme(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._setTheme4489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setTheme4489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWindow4490;
		public virtual global::android.app.Dialog getWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getWindow4490)) as android.app.Dialog;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getWindow4490)) as android.app.Dialog;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown4491;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onKeyDown4491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyDown4491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress4492;
		public override bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onKeyLongPress4492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyLongPress4492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp4493;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onKeyUp4493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyUp4493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple4494;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onKeyMultiple4494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyMultiple4494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent4495;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onTrackballEvent4495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onTrackballEvent4495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater4496;
		public virtual global::android.view.LayoutInflater getLayoutInflater() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getLayoutInflater4496)) as android.view.LayoutInflater;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getLayoutInflater4496)) as android.view.LayoutInflater;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodInterface4497;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onCreateInputMethodInterface4497)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateInputMethodInterface4497)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodSessionInterface4498;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onCreateInputMethodSessionInterface4498)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateInputMethodSessionInterface4498)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl;
		}
		internal static global::MonoJavaBridge.MethodId _onInitializeInterface4499;
		public virtual void onInitializeInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onInitializeInterface4499);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onInitializeInterface4499);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxWidth4500;
		public virtual int getMaxWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getMaxWidth4500);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getMaxWidth4500);
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentInputBinding4501;
		public virtual global::android.view.inputmethod.InputBinding getCurrentInputBinding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getCurrentInputBinding4501)) as android.view.inputmethod.InputBinding;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputBinding4501)) as android.view.inputmethod.InputBinding;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentInputConnection4502;
		public virtual global::android.view.inputmethod.InputConnection getCurrentInputConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getCurrentInputConnection4502)) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputConnection4502)) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentInputStarted4503;
		public virtual bool getCurrentInputStarted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getCurrentInputStarted4503);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputStarted4503);
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentInputEditorInfo4504;
		public virtual global::android.view.inputmethod.EditorInfo getCurrentInputEditorInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getCurrentInputEditorInfo4504)) as android.view.inputmethod.EditorInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputEditorInfo4504)) as android.view.inputmethod.EditorInfo;
		}
		internal static global::MonoJavaBridge.MethodId _updateFullscreenMode4505;
		public virtual void updateFullscreenMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._updateFullscreenMode4505);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._updateFullscreenMode4505);
		}
		internal static global::MonoJavaBridge.MethodId _onConfigureWindow4506;
		public virtual void onConfigureWindow(android.view.Window arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onConfigureWindow4506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onConfigureWindow4506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isFullscreenMode4507;
		public virtual bool isFullscreenMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._isFullscreenMode4507);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isFullscreenMode4507);
		}
		internal static global::MonoJavaBridge.MethodId _onEvaluateFullscreenMode4508;
		public virtual bool onEvaluateFullscreenMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onEvaluateFullscreenMode4508);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onEvaluateFullscreenMode4508);
		}
		internal static global::MonoJavaBridge.MethodId _setExtractViewShown4509;
		public virtual void setExtractViewShown(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._setExtractViewShown4509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setExtractViewShown4509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isExtractViewShown4510;
		public virtual bool isExtractViewShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._isExtractViewShown4510);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isExtractViewShown4510);
		}
		internal static global::MonoJavaBridge.MethodId _onComputeInsets4511;
		public virtual void onComputeInsets(android.inputmethodservice.InputMethodService.Insets arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onComputeInsets4511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onComputeInsets4511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateInputViewShown4512;
		public virtual void updateInputViewShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._updateInputViewShown4512);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._updateInputViewShown4512);
		}
		internal static global::MonoJavaBridge.MethodId _isShowInputRequested4513;
		public virtual bool isShowInputRequested() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._isShowInputRequested4513);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isShowInputRequested4513);
		}
		internal static global::MonoJavaBridge.MethodId _isInputViewShown4514;
		public virtual bool isInputViewShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._isInputViewShown4514);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isInputViewShown4514);
		}
		internal static global::MonoJavaBridge.MethodId _onEvaluateInputViewShown4515;
		public virtual bool onEvaluateInputViewShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onEvaluateInputViewShown4515);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onEvaluateInputViewShown4515);
		}
		internal static global::MonoJavaBridge.MethodId _setCandidatesViewShown4516;
		public virtual void setCandidatesViewShown(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._setCandidatesViewShown4516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setCandidatesViewShown4516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCandidatesHiddenVisibility4517;
		public virtual int getCandidatesHiddenVisibility() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getCandidatesHiddenVisibility4517);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCandidatesHiddenVisibility4517);
		}
		internal static global::MonoJavaBridge.MethodId _showStatusIcon4518;
		public virtual void showStatusIcon(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._showStatusIcon4518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._showStatusIcon4518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hideStatusIcon4519;
		public virtual void hideStatusIcon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._hideStatusIcon4519);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._hideStatusIcon4519);
		}
		internal static global::MonoJavaBridge.MethodId _setExtractView4520;
		public virtual void setExtractView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._setExtractView4520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setExtractView4520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCandidatesView4521;
		public virtual void setCandidatesView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._setCandidatesView4521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setCandidatesView4521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInputView4522;
		public virtual void setInputView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._setInputView4522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setInputView4522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateExtractTextView4523;
		public virtual global::android.view.View onCreateExtractTextView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onCreateExtractTextView4523)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateExtractTextView4523)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateCandidatesView4524;
		public virtual global::android.view.View onCreateCandidatesView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onCreateCandidatesView4524)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateCandidatesView4524)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputView4525;
		public virtual global::android.view.View onCreateInputView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onCreateInputView4525)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateInputView4525)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onStartInputView4526;
		public virtual void onStartInputView(android.view.inputmethod.EditorInfo arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onStartInputView4526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onStartInputView4526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInputView4527;
		public virtual void onFinishInputView(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onFinishInputView4527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onFinishInputView4527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStartCandidatesView4528;
		public virtual void onStartCandidatesView(android.view.inputmethod.EditorInfo arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onStartCandidatesView4528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onStartCandidatesView4528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishCandidatesView4529;
		public virtual void onFinishCandidatesView(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onFinishCandidatesView4529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onFinishCandidatesView4529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onShowInputRequested4530;
		public virtual bool onShowInputRequested(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onShowInputRequested4530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onShowInputRequested4530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showWindow4531;
		public virtual void showWindow(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._showWindow4531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._showWindow4531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hideWindow4532;
		public virtual void hideWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._hideWindow4532);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._hideWindow4532);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowShown4533;
		public virtual void onWindowShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onWindowShown4533);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onWindowShown4533);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowHidden4534;
		public virtual void onWindowHidden() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onWindowHidden4534);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onWindowHidden4534);
		}
		internal static global::MonoJavaBridge.MethodId _onBindInput4535;
		public virtual void onBindInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onBindInput4535);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onBindInput4535);
		}
		internal static global::MonoJavaBridge.MethodId _onUnbindInput4536;
		public virtual void onUnbindInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onUnbindInput4536);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUnbindInput4536);
		}
		internal static global::MonoJavaBridge.MethodId _onStartInput4537;
		public virtual void onStartInput(android.view.inputmethod.EditorInfo arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onStartInput4537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onStartInput4537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInput4538;
		public virtual void onFinishInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onFinishInput4538);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onFinishInput4538);
		}
		internal static global::MonoJavaBridge.MethodId _onDisplayCompletions4539;
		public virtual void onDisplayCompletions(android.view.inputmethod.CompletionInfo[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onDisplayCompletions4539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onDisplayCompletions4539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onUpdateExtractedText4540;
		public virtual void onUpdateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onUpdateExtractedText4540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateExtractedText4540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onUpdateSelection4541;
		public virtual void onUpdateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onUpdateSelection4541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateSelection4541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _onUpdateCursor4542;
		public virtual void onUpdateCursor(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onUpdateCursor4542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateCursor4542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestHideSelf4543;
		public virtual void requestHideSelf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._requestHideSelf4543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._requestHideSelf4543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAppPrivateCommand4544;
		public virtual void onAppPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onAppPrivateCommand4544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onAppPrivateCommand4544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendDownUpKeyEvents4545;
		public virtual void sendDownUpKeyEvents(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._sendDownUpKeyEvents4545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._sendDownUpKeyEvents4545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendDefaultEditorAction4546;
		public virtual bool sendDefaultEditorAction(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._sendDefaultEditorAction4546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._sendDefaultEditorAction4546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeyChar4547;
		public virtual void sendKeyChar(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._sendKeyChar4547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._sendKeyChar4547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onExtractedSelectionChanged4548;
		public virtual void onExtractedSelectionChanged(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onExtractedSelectionChanged4548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractedSelectionChanged4548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onExtractedTextClicked4549;
		public virtual void onExtractedTextClicked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onExtractedTextClicked4549);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractedTextClicked4549);
		}
		internal static global::MonoJavaBridge.MethodId _onExtractedCursorMovement4550;
		public virtual void onExtractedCursorMovement(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onExtractedCursorMovement4550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractedCursorMovement4550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onExtractTextContextMenuItem4551;
		public virtual bool onExtractTextContextMenuItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onExtractTextContextMenuItem4551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractTextContextMenuItem4551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextForImeAction4552;
		public virtual global::java.lang.CharSequence getTextForImeAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getTextForImeAction4552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getTextForImeAction4552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _onUpdateExtractingVisibility4553;
		public virtual void onUpdateExtractingVisibility(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onUpdateExtractingVisibility4553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateExtractingVisibility4553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onUpdateExtractingViews4554;
		public virtual void onUpdateExtractingViews(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onUpdateExtractingViews4554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateExtractingViews4554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onExtractingInputChanged4555;
		public virtual void onExtractingInputChanged(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onExtractingInputChanged4555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractingInputChanged4555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _InputMethodService4556;
		public InputMethodService()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._InputMethodService4556);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.InputMethodService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/InputMethodService"));
			global::android.inputmethodservice.InputMethodService._switchInputMethod4484 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "switchInputMethod", "(Ljava/lang/String;)V");
			global::android.inputmethodservice.InputMethodService._onCreate4485 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onCreate", "()V");
			global::android.inputmethodservice.InputMethodService._onDestroy4486 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onDestroy", "()V");
			global::android.inputmethodservice.InputMethodService._onConfigurationChanged4487 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.inputmethodservice.InputMethodService._dump4488 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V");
			global::android.inputmethodservice.InputMethodService._setTheme4489 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "setTheme", "(I)V");
			global::android.inputmethodservice.InputMethodService._getWindow4490 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getWindow", "()Landroid/app/Dialog;");
			global::android.inputmethodservice.InputMethodService._onKeyDown4491 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.InputMethodService._onKeyLongPress4492 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.InputMethodService._onKeyUp4493 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.InputMethodService._onKeyMultiple4494 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.InputMethodService._onTrackballEvent4495 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.inputmethodservice.InputMethodService._getLayoutInflater4496 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.inputmethodservice.InputMethodService._onCreateInputMethodInterface4497 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;");
			global::android.inputmethodservice.InputMethodService._onCreateInputMethodSessionInterface4498 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;");
			global::android.inputmethodservice.InputMethodService._onInitializeInterface4499 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onInitializeInterface", "()V");
			global::android.inputmethodservice.InputMethodService._getMaxWidth4500 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getMaxWidth", "()I");
			global::android.inputmethodservice.InputMethodService._getCurrentInputBinding4501 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputBinding", "()Landroid/view/inputmethod/InputBinding;");
			global::android.inputmethodservice.InputMethodService._getCurrentInputConnection4502 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputConnection", "()Landroid/view/inputmethod/InputConnection;");
			global::android.inputmethodservice.InputMethodService._getCurrentInputStarted4503 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputStarted", "()Z");
			global::android.inputmethodservice.InputMethodService._getCurrentInputEditorInfo4504 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputEditorInfo", "()Landroid/view/inputmethod/EditorInfo;");
			global::android.inputmethodservice.InputMethodService._updateFullscreenMode4505 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "updateFullscreenMode", "()V");
			global::android.inputmethodservice.InputMethodService._onConfigureWindow4506 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onConfigureWindow", "(Landroid/view/Window;ZZ)V");
			global::android.inputmethodservice.InputMethodService._isFullscreenMode4507 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "isFullscreenMode", "()Z");
			global::android.inputmethodservice.InputMethodService._onEvaluateFullscreenMode4508 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onEvaluateFullscreenMode", "()Z");
			global::android.inputmethodservice.InputMethodService._setExtractViewShown4509 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "setExtractViewShown", "(Z)V");
			global::android.inputmethodservice.InputMethodService._isExtractViewShown4510 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "isExtractViewShown", "()Z");
			global::android.inputmethodservice.InputMethodService._onComputeInsets4511 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onComputeInsets", "(Landroid/inputmethodservice/InputMethodService$Insets;)V");
			global::android.inputmethodservice.InputMethodService._updateInputViewShown4512 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "updateInputViewShown", "()V");
			global::android.inputmethodservice.InputMethodService._isShowInputRequested4513 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "isShowInputRequested", "()Z");
			global::android.inputmethodservice.InputMethodService._isInputViewShown4514 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "isInputViewShown", "()Z");
			global::android.inputmethodservice.InputMethodService._onEvaluateInputViewShown4515 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onEvaluateInputViewShown", "()Z");
			global::android.inputmethodservice.InputMethodService._setCandidatesViewShown4516 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "setCandidatesViewShown", "(Z)V");
			global::android.inputmethodservice.InputMethodService._getCandidatesHiddenVisibility4517 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getCandidatesHiddenVisibility", "()I");
			global::android.inputmethodservice.InputMethodService._showStatusIcon4518 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "showStatusIcon", "(I)V");
			global::android.inputmethodservice.InputMethodService._hideStatusIcon4519 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "hideStatusIcon", "()V");
			global::android.inputmethodservice.InputMethodService._setExtractView4520 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "setExtractView", "(Landroid/view/View;)V");
			global::android.inputmethodservice.InputMethodService._setCandidatesView4521 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "setCandidatesView", "(Landroid/view/View;)V");
			global::android.inputmethodservice.InputMethodService._setInputView4522 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "setInputView", "(Landroid/view/View;)V");
			global::android.inputmethodservice.InputMethodService._onCreateExtractTextView4523 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateExtractTextView", "()Landroid/view/View;");
			global::android.inputmethodservice.InputMethodService._onCreateCandidatesView4524 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateCandidatesView", "()Landroid/view/View;");
			global::android.inputmethodservice.InputMethodService._onCreateInputView4525 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputView", "()Landroid/view/View;");
			global::android.inputmethodservice.InputMethodService._onStartInputView4526 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onStartInputView", "(Landroid/view/inputmethod/EditorInfo;Z)V");
			global::android.inputmethodservice.InputMethodService._onFinishInputView4527 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onFinishInputView", "(Z)V");
			global::android.inputmethodservice.InputMethodService._onStartCandidatesView4528 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onStartCandidatesView", "(Landroid/view/inputmethod/EditorInfo;Z)V");
			global::android.inputmethodservice.InputMethodService._onFinishCandidatesView4529 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onFinishCandidatesView", "(Z)V");
			global::android.inputmethodservice.InputMethodService._onShowInputRequested4530 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onShowInputRequested", "(IZ)Z");
			global::android.inputmethodservice.InputMethodService._showWindow4531 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "showWindow", "(Z)V");
			global::android.inputmethodservice.InputMethodService._hideWindow4532 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "hideWindow", "()V");
			global::android.inputmethodservice.InputMethodService._onWindowShown4533 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onWindowShown", "()V");
			global::android.inputmethodservice.InputMethodService._onWindowHidden4534 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onWindowHidden", "()V");
			global::android.inputmethodservice.InputMethodService._onBindInput4535 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onBindInput", "()V");
			global::android.inputmethodservice.InputMethodService._onUnbindInput4536 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onUnbindInput", "()V");
			global::android.inputmethodservice.InputMethodService._onStartInput4537 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onStartInput", "(Landroid/view/inputmethod/EditorInfo;Z)V");
			global::android.inputmethodservice.InputMethodService._onFinishInput4538 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onFinishInput", "()V");
			global::android.inputmethodservice.InputMethodService._onDisplayCompletions4539 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onDisplayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.inputmethodservice.InputMethodService._onUpdateExtractedText4540 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V");
			global::android.inputmethodservice.InputMethodService._onUpdateSelection4541 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateSelection", "(IIIIII)V");
			global::android.inputmethodservice.InputMethodService._onUpdateCursor4542 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateCursor", "(Landroid/graphics/Rect;)V");
			global::android.inputmethodservice.InputMethodService._requestHideSelf4543 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "requestHideSelf", "(I)V");
			global::android.inputmethodservice.InputMethodService._onAppPrivateCommand4544 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onAppPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.inputmethodservice.InputMethodService._sendDownUpKeyEvents4545 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "sendDownUpKeyEvents", "(I)V");
			global::android.inputmethodservice.InputMethodService._sendDefaultEditorAction4546 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "sendDefaultEditorAction", "(Z)Z");
			global::android.inputmethodservice.InputMethodService._sendKeyChar4547 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "sendKeyChar", "(C)V");
			global::android.inputmethodservice.InputMethodService._onExtractedSelectionChanged4548 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedSelectionChanged", "(II)V");
			global::android.inputmethodservice.InputMethodService._onExtractedTextClicked4549 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedTextClicked", "()V");
			global::android.inputmethodservice.InputMethodService._onExtractedCursorMovement4550 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedCursorMovement", "(II)V");
			global::android.inputmethodservice.InputMethodService._onExtractTextContextMenuItem4551 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractTextContextMenuItem", "(I)Z");
			global::android.inputmethodservice.InputMethodService._getTextForImeAction4552 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getTextForImeAction", "(I)Ljava/lang/CharSequence;");
			global::android.inputmethodservice.InputMethodService._onUpdateExtractingVisibility4553 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractingVisibility", "(Landroid/view/inputmethod/EditorInfo;)V");
			global::android.inputmethodservice.InputMethodService._onUpdateExtractingViews4554 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractingViews", "(Landroid/view/inputmethod/EditorInfo;)V");
			global::android.inputmethodservice.InputMethodService._onExtractingInputChanged4555 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractingInputChanged", "(Landroid/view/inputmethod/EditorInfo;)V");
			global::android.inputmethodservice.InputMethodService._InputMethodService4556 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "<init>", "()V");
		}
	}
}
