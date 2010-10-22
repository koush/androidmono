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
			internal static global::MonoJavaBridge.MethodId _attachToken6572;
			public override void attachToken(android.os.IBinder arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl._attachToken6572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._attachToken6572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _bindInput6573;
			public override void bindInput(android.view.inputmethod.InputBinding arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl._bindInput6573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._bindInput6573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _unbindInput6574;
			public override void unbindInput() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl._unbindInput6574);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._unbindInput6574);
			}
			internal static global::MonoJavaBridge.MethodId _startInput6575;
			public override void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl._startInput6575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._startInput6575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _restartInput6576;
			public override void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl._restartInput6576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._restartInput6576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _showSoftInput6577;
			public override void showSoftInput(int arg0, android.os.ResultReceiver arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl._showSoftInput6577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._showSoftInput6577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _hideSoftInput6578;
			public override void hideSoftInput(int arg0, android.os.ResultReceiver arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl._hideSoftInput6578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._hideSoftInput6578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _InputMethodImpl6579;
			public InputMethodImpl(android.inputmethodservice.InputMethodService arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._InputMethodImpl6579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/InputMethodService$InputMethodImpl"));
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._attachToken6572 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "attachToken", "(Landroid/os/IBinder;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._bindInput6573 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._unbindInput6574 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "unbindInput", "()V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._startInput6575 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._restartInput6576 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._showSoftInput6577 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._hideSoftInput6578 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._InputMethodImpl6579 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "<init>", "(Landroid/inputmethodservice/InputMethodService;)V");
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
			internal static global::MonoJavaBridge.MethodId _finishInput6580;
			public override void finishInput() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._finishInput6580);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._finishInput6580);
			}
			internal static global::MonoJavaBridge.MethodId _updateSelection6581;
			public override void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateSelection6581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateSelection6581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			}
			internal static global::MonoJavaBridge.MethodId _updateCursor6582;
			public override void updateCursor(android.graphics.Rect arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateCursor6582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateCursor6582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _displayCompletions6583;
			public override void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._displayCompletions6583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._displayCompletions6583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _updateExtractedText6584;
			public override void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateExtractedText6584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateExtractedText6584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _appPrivateCommand6585;
			public override void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._appPrivateCommand6585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._appPrivateCommand6585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _toggleSoftInput6586;
			public override void toggleSoftInput(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._toggleSoftInput6586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._toggleSoftInput6586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _InputMethodSessionImpl6587;
			public InputMethodSessionImpl(android.inputmethodservice.InputMethodService arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._InputMethodSessionImpl6587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/InputMethodService$InputMethodSessionImpl"));
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._finishInput6580 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "finishInput", "()V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateSelection6581 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateSelection", "(IIIIII)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateCursor6582 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._displayCompletions6583 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateExtractedText6584 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._appPrivateCommand6585 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._toggleSoftInput6586 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "toggleSoftInput", "(II)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._InputMethodSessionImpl6587 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "<init>", "(Landroid/inputmethodservice/InputMethodService;)V");
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
			internal static global::MonoJavaBridge.MethodId _Insets6588;
			public Insets()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.InputMethodService.Insets.staticClass, global::android.inputmethodservice.InputMethodService.Insets._Insets6588);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _contentTopInsets6589;
			public int contentTopInsets
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _contentTopInsets6589);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _visibleTopInsets6590;
			public int visibleTopInsets
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _visibleTopInsets6590);
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
			internal static global::MonoJavaBridge.FieldId _touchableInsets6594;
			public int touchableInsets
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _touchableInsets6594);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.InputMethodService.Insets.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/InputMethodService$Insets"));
				global::android.inputmethodservice.InputMethodService.Insets._Insets6588 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.Insets.staticClass, "<init>", "()V");
				global::android.inputmethodservice.InputMethodService.Insets._contentTopInsets6589 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.InputMethodService.Insets.staticClass, "contentTopInsets", "I");
				global::android.inputmethodservice.InputMethodService.Insets._visibleTopInsets6590 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.InputMethodService.Insets.staticClass, "visibleTopInsets", "I");
				global::android.inputmethodservice.InputMethodService.Insets._touchableInsets6594 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.InputMethodService.Insets.staticClass, "touchableInsets", "I");
			}
		}
		internal static global::MonoJavaBridge.MethodId _switchInputMethod6595;
		public virtual void switchInputMethod(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._switchInputMethod6595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._switchInputMethod6595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreate6596;
		public override void onCreate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onCreate6596);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreate6596);
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy6597;
		public override void onDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onDestroy6597);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onDestroy6597);
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged6598;
		public override void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onConfigurationChanged6598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onConfigurationChanged6598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dump6599;
		protected override void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._dump6599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._dump6599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTheme6600;
		public override void setTheme(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._setTheme6600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setTheme6600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.app.Dialog Window
		{
			get
			{
				return getWindow();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindow6601;
		public virtual global::android.app.Dialog getWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getWindow6601)) as android.app.Dialog;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getWindow6601)) as android.app.Dialog;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown6602;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onKeyDown6602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyDown6602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress6603;
		public override bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onKeyLongPress6603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyLongPress6603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp6604;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onKeyUp6604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyUp6604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple6605;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onKeyMultiple6605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyMultiple6605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent6606;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onTrackballEvent6606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onTrackballEvent6606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.LayoutInflater LayoutInflater
		{
			get
			{
				return getLayoutInflater();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater6607;
		public virtual global::android.view.LayoutInflater getLayoutInflater() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getLayoutInflater6607)) as android.view.LayoutInflater;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getLayoutInflater6607)) as android.view.LayoutInflater;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodInterface6608;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onCreateInputMethodInterface6608)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateInputMethodInterface6608)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodSessionInterface6609;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onCreateInputMethodSessionInterface6609)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateInputMethodSessionInterface6609)) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl;
		}
		internal static global::MonoJavaBridge.MethodId _onInitializeInterface6610;
		public virtual void onInitializeInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onInitializeInterface6610);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onInitializeInterface6610);
		}
		public new int MaxWidth
		{
			get
			{
				return getMaxWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxWidth6611;
		public virtual int getMaxWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getMaxWidth6611);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getMaxWidth6611);
		}
		public new global::android.view.inputmethod.InputBinding CurrentInputBinding
		{
			get
			{
				return getCurrentInputBinding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentInputBinding6612;
		public virtual global::android.view.inputmethod.InputBinding getCurrentInputBinding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.inputmethod.InputBinding>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getCurrentInputBinding6612)) as android.view.inputmethod.InputBinding;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.inputmethod.InputBinding>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputBinding6612)) as android.view.inputmethod.InputBinding;
		}
		public new global::android.view.inputmethod.InputConnection CurrentInputConnection
		{
			get
			{
				return getCurrentInputConnection();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentInputConnection6613;
		public virtual global::android.view.inputmethod.InputConnection getCurrentInputConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getCurrentInputConnection6613)) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputConnection6613)) as android.view.inputmethod.InputConnection;
		}
		public new bool CurrentInputStarted
		{
			get
			{
				return getCurrentInputStarted();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentInputStarted6614;
		public virtual bool getCurrentInputStarted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getCurrentInputStarted6614);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputStarted6614);
		}
		public new global::android.view.inputmethod.EditorInfo CurrentInputEditorInfo
		{
			get
			{
				return getCurrentInputEditorInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentInputEditorInfo6615;
		public virtual global::android.view.inputmethod.EditorInfo getCurrentInputEditorInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getCurrentInputEditorInfo6615)) as android.view.inputmethod.EditorInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputEditorInfo6615)) as android.view.inputmethod.EditorInfo;
		}
		internal static global::MonoJavaBridge.MethodId _updateFullscreenMode6616;
		public virtual void updateFullscreenMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._updateFullscreenMode6616);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._updateFullscreenMode6616);
		}
		internal static global::MonoJavaBridge.MethodId _onConfigureWindow6617;
		public virtual void onConfigureWindow(android.view.Window arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onConfigureWindow6617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onConfigureWindow6617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isFullscreenMode6618;
		public virtual bool isFullscreenMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._isFullscreenMode6618);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isFullscreenMode6618);
		}
		internal static global::MonoJavaBridge.MethodId _onEvaluateFullscreenMode6619;
		public virtual bool onEvaluateFullscreenMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onEvaluateFullscreenMode6619);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onEvaluateFullscreenMode6619);
		}
		internal static global::MonoJavaBridge.MethodId _setExtractViewShown6620;
		public virtual void setExtractViewShown(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._setExtractViewShown6620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setExtractViewShown6620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isExtractViewShown6621;
		public virtual bool isExtractViewShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._isExtractViewShown6621);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isExtractViewShown6621);
		}
		internal static global::MonoJavaBridge.MethodId _onComputeInsets6622;
		public virtual void onComputeInsets(android.inputmethodservice.InputMethodService.Insets arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onComputeInsets6622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onComputeInsets6622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateInputViewShown6623;
		public virtual void updateInputViewShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._updateInputViewShown6623);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._updateInputViewShown6623);
		}
		internal static global::MonoJavaBridge.MethodId _isShowInputRequested6624;
		public virtual bool isShowInputRequested() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._isShowInputRequested6624);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isShowInputRequested6624);
		}
		internal static global::MonoJavaBridge.MethodId _isInputViewShown6625;
		public virtual bool isInputViewShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._isInputViewShown6625);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isInputViewShown6625);
		}
		internal static global::MonoJavaBridge.MethodId _onEvaluateInputViewShown6626;
		public virtual bool onEvaluateInputViewShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onEvaluateInputViewShown6626);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onEvaluateInputViewShown6626);
		}
		internal static global::MonoJavaBridge.MethodId _setCandidatesViewShown6627;
		public virtual void setCandidatesViewShown(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._setCandidatesViewShown6627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setCandidatesViewShown6627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CandidatesHiddenVisibility
		{
			get
			{
				return getCandidatesHiddenVisibility();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCandidatesHiddenVisibility6628;
		public virtual int getCandidatesHiddenVisibility() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getCandidatesHiddenVisibility6628);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCandidatesHiddenVisibility6628);
		}
		internal static global::MonoJavaBridge.MethodId _showStatusIcon6629;
		public virtual void showStatusIcon(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._showStatusIcon6629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._showStatusIcon6629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hideStatusIcon6630;
		public virtual void hideStatusIcon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._hideStatusIcon6630);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._hideStatusIcon6630);
		}
		internal static global::MonoJavaBridge.MethodId _setExtractView6631;
		public virtual void setExtractView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._setExtractView6631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setExtractView6631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCandidatesView6632;
		public virtual void setCandidatesView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._setCandidatesView6632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setCandidatesView6632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInputView6633;
		public virtual void setInputView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._setInputView6633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setInputView6633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateExtractTextView6634;
		public virtual global::android.view.View onCreateExtractTextView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onCreateExtractTextView6634)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateExtractTextView6634)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateCandidatesView6635;
		public virtual global::android.view.View onCreateCandidatesView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onCreateCandidatesView6635)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateCandidatesView6635)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputView6636;
		public virtual global::android.view.View onCreateInputView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onCreateInputView6636)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateInputView6636)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onStartInputView6637;
		public virtual void onStartInputView(android.view.inputmethod.EditorInfo arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onStartInputView6637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onStartInputView6637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInputView6638;
		public virtual void onFinishInputView(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onFinishInputView6638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onFinishInputView6638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStartCandidatesView6639;
		public virtual void onStartCandidatesView(android.view.inputmethod.EditorInfo arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onStartCandidatesView6639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onStartCandidatesView6639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishCandidatesView6640;
		public virtual void onFinishCandidatesView(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onFinishCandidatesView6640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onFinishCandidatesView6640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onShowInputRequested6641;
		public virtual bool onShowInputRequested(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onShowInputRequested6641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onShowInputRequested6641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showWindow6642;
		public virtual void showWindow(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._showWindow6642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._showWindow6642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hideWindow6643;
		public virtual void hideWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._hideWindow6643);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._hideWindow6643);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowShown6644;
		public virtual void onWindowShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onWindowShown6644);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onWindowShown6644);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowHidden6645;
		public virtual void onWindowHidden() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onWindowHidden6645);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onWindowHidden6645);
		}
		internal static global::MonoJavaBridge.MethodId _onBindInput6646;
		public virtual void onBindInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onBindInput6646);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onBindInput6646);
		}
		internal static global::MonoJavaBridge.MethodId _onUnbindInput6647;
		public virtual void onUnbindInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onUnbindInput6647);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUnbindInput6647);
		}
		internal static global::MonoJavaBridge.MethodId _onStartInput6648;
		public virtual void onStartInput(android.view.inputmethod.EditorInfo arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onStartInput6648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onStartInput6648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInput6649;
		public virtual void onFinishInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onFinishInput6649);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onFinishInput6649);
		}
		internal static global::MonoJavaBridge.MethodId _onDisplayCompletions6650;
		public virtual void onDisplayCompletions(android.view.inputmethod.CompletionInfo[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onDisplayCompletions6650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onDisplayCompletions6650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onUpdateExtractedText6651;
		public virtual void onUpdateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onUpdateExtractedText6651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateExtractedText6651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onUpdateSelection6652;
		public virtual void onUpdateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onUpdateSelection6652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateSelection6652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _onUpdateCursor6653;
		public virtual void onUpdateCursor(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onUpdateCursor6653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateCursor6653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestHideSelf6654;
		public virtual void requestHideSelf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._requestHideSelf6654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._requestHideSelf6654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAppPrivateCommand6655;
		public virtual void onAppPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onAppPrivateCommand6655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onAppPrivateCommand6655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendDownUpKeyEvents6656;
		public virtual void sendDownUpKeyEvents(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._sendDownUpKeyEvents6656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._sendDownUpKeyEvents6656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendDefaultEditorAction6657;
		public virtual bool sendDefaultEditorAction(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._sendDefaultEditorAction6657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._sendDefaultEditorAction6657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeyChar6658;
		public virtual void sendKeyChar(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._sendKeyChar6658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._sendKeyChar6658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onExtractedSelectionChanged6659;
		public virtual void onExtractedSelectionChanged(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onExtractedSelectionChanged6659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractedSelectionChanged6659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onExtractedTextClicked6660;
		public virtual void onExtractedTextClicked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onExtractedTextClicked6660);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractedTextClicked6660);
		}
		internal static global::MonoJavaBridge.MethodId _onExtractedCursorMovement6661;
		public virtual void onExtractedCursorMovement(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onExtractedCursorMovement6661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractedCursorMovement6661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onExtractTextContextMenuItem6662;
		public virtual bool onExtractTextContextMenuItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onExtractTextContextMenuItem6662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractTextContextMenuItem6662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextForImeAction6663;
		public virtual global::java.lang.CharSequence getTextForImeAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._getTextForImeAction6663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getTextForImeAction6663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _onUpdateExtractingVisibility6664;
		public virtual void onUpdateExtractingVisibility(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onUpdateExtractingVisibility6664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateExtractingVisibility6664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onUpdateExtractingViews6665;
		public virtual void onUpdateExtractingViews(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onUpdateExtractingViews6665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateExtractingViews6665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onExtractingInputChanged6666;
		public virtual void onExtractingInputChanged(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService._onExtractingInputChanged6666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractingInputChanged6666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _InputMethodService6667;
		public InputMethodService()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._InputMethodService6667);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.InputMethodService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/InputMethodService"));
			global::android.inputmethodservice.InputMethodService._switchInputMethod6595 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "switchInputMethod", "(Ljava/lang/String;)V");
			global::android.inputmethodservice.InputMethodService._onCreate6596 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onCreate", "()V");
			global::android.inputmethodservice.InputMethodService._onDestroy6597 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onDestroy", "()V");
			global::android.inputmethodservice.InputMethodService._onConfigurationChanged6598 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.inputmethodservice.InputMethodService._dump6599 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V");
			global::android.inputmethodservice.InputMethodService._setTheme6600 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "setTheme", "(I)V");
			global::android.inputmethodservice.InputMethodService._getWindow6601 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getWindow", "()Landroid/app/Dialog;");
			global::android.inputmethodservice.InputMethodService._onKeyDown6602 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.InputMethodService._onKeyLongPress6603 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.InputMethodService._onKeyUp6604 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.InputMethodService._onKeyMultiple6605 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.InputMethodService._onTrackballEvent6606 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.inputmethodservice.InputMethodService._getLayoutInflater6607 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.inputmethodservice.InputMethodService._onCreateInputMethodInterface6608 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;");
			global::android.inputmethodservice.InputMethodService._onCreateInputMethodSessionInterface6609 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;");
			global::android.inputmethodservice.InputMethodService._onInitializeInterface6610 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onInitializeInterface", "()V");
			global::android.inputmethodservice.InputMethodService._getMaxWidth6611 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getMaxWidth", "()I");
			global::android.inputmethodservice.InputMethodService._getCurrentInputBinding6612 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputBinding", "()Landroid/view/inputmethod/InputBinding;");
			global::android.inputmethodservice.InputMethodService._getCurrentInputConnection6613 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputConnection", "()Landroid/view/inputmethod/InputConnection;");
			global::android.inputmethodservice.InputMethodService._getCurrentInputStarted6614 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputStarted", "()Z");
			global::android.inputmethodservice.InputMethodService._getCurrentInputEditorInfo6615 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputEditorInfo", "()Landroid/view/inputmethod/EditorInfo;");
			global::android.inputmethodservice.InputMethodService._updateFullscreenMode6616 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "updateFullscreenMode", "()V");
			global::android.inputmethodservice.InputMethodService._onConfigureWindow6617 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onConfigureWindow", "(Landroid/view/Window;ZZ)V");
			global::android.inputmethodservice.InputMethodService._isFullscreenMode6618 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "isFullscreenMode", "()Z");
			global::android.inputmethodservice.InputMethodService._onEvaluateFullscreenMode6619 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onEvaluateFullscreenMode", "()Z");
			global::android.inputmethodservice.InputMethodService._setExtractViewShown6620 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "setExtractViewShown", "(Z)V");
			global::android.inputmethodservice.InputMethodService._isExtractViewShown6621 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "isExtractViewShown", "()Z");
			global::android.inputmethodservice.InputMethodService._onComputeInsets6622 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onComputeInsets", "(Landroid/inputmethodservice/InputMethodService$Insets;)V");
			global::android.inputmethodservice.InputMethodService._updateInputViewShown6623 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "updateInputViewShown", "()V");
			global::android.inputmethodservice.InputMethodService._isShowInputRequested6624 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "isShowInputRequested", "()Z");
			global::android.inputmethodservice.InputMethodService._isInputViewShown6625 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "isInputViewShown", "()Z");
			global::android.inputmethodservice.InputMethodService._onEvaluateInputViewShown6626 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onEvaluateInputViewShown", "()Z");
			global::android.inputmethodservice.InputMethodService._setCandidatesViewShown6627 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "setCandidatesViewShown", "(Z)V");
			global::android.inputmethodservice.InputMethodService._getCandidatesHiddenVisibility6628 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getCandidatesHiddenVisibility", "()I");
			global::android.inputmethodservice.InputMethodService._showStatusIcon6629 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "showStatusIcon", "(I)V");
			global::android.inputmethodservice.InputMethodService._hideStatusIcon6630 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "hideStatusIcon", "()V");
			global::android.inputmethodservice.InputMethodService._setExtractView6631 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "setExtractView", "(Landroid/view/View;)V");
			global::android.inputmethodservice.InputMethodService._setCandidatesView6632 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "setCandidatesView", "(Landroid/view/View;)V");
			global::android.inputmethodservice.InputMethodService._setInputView6633 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "setInputView", "(Landroid/view/View;)V");
			global::android.inputmethodservice.InputMethodService._onCreateExtractTextView6634 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateExtractTextView", "()Landroid/view/View;");
			global::android.inputmethodservice.InputMethodService._onCreateCandidatesView6635 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateCandidatesView", "()Landroid/view/View;");
			global::android.inputmethodservice.InputMethodService._onCreateInputView6636 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputView", "()Landroid/view/View;");
			global::android.inputmethodservice.InputMethodService._onStartInputView6637 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onStartInputView", "(Landroid/view/inputmethod/EditorInfo;Z)V");
			global::android.inputmethodservice.InputMethodService._onFinishInputView6638 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onFinishInputView", "(Z)V");
			global::android.inputmethodservice.InputMethodService._onStartCandidatesView6639 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onStartCandidatesView", "(Landroid/view/inputmethod/EditorInfo;Z)V");
			global::android.inputmethodservice.InputMethodService._onFinishCandidatesView6640 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onFinishCandidatesView", "(Z)V");
			global::android.inputmethodservice.InputMethodService._onShowInputRequested6641 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onShowInputRequested", "(IZ)Z");
			global::android.inputmethodservice.InputMethodService._showWindow6642 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "showWindow", "(Z)V");
			global::android.inputmethodservice.InputMethodService._hideWindow6643 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "hideWindow", "()V");
			global::android.inputmethodservice.InputMethodService._onWindowShown6644 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onWindowShown", "()V");
			global::android.inputmethodservice.InputMethodService._onWindowHidden6645 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onWindowHidden", "()V");
			global::android.inputmethodservice.InputMethodService._onBindInput6646 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onBindInput", "()V");
			global::android.inputmethodservice.InputMethodService._onUnbindInput6647 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onUnbindInput", "()V");
			global::android.inputmethodservice.InputMethodService._onStartInput6648 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onStartInput", "(Landroid/view/inputmethod/EditorInfo;Z)V");
			global::android.inputmethodservice.InputMethodService._onFinishInput6649 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onFinishInput", "()V");
			global::android.inputmethodservice.InputMethodService._onDisplayCompletions6650 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onDisplayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.inputmethodservice.InputMethodService._onUpdateExtractedText6651 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V");
			global::android.inputmethodservice.InputMethodService._onUpdateSelection6652 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateSelection", "(IIIIII)V");
			global::android.inputmethodservice.InputMethodService._onUpdateCursor6653 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateCursor", "(Landroid/graphics/Rect;)V");
			global::android.inputmethodservice.InputMethodService._requestHideSelf6654 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "requestHideSelf", "(I)V");
			global::android.inputmethodservice.InputMethodService._onAppPrivateCommand6655 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onAppPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.inputmethodservice.InputMethodService._sendDownUpKeyEvents6656 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "sendDownUpKeyEvents", "(I)V");
			global::android.inputmethodservice.InputMethodService._sendDefaultEditorAction6657 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "sendDefaultEditorAction", "(Z)Z");
			global::android.inputmethodservice.InputMethodService._sendKeyChar6658 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "sendKeyChar", "(C)V");
			global::android.inputmethodservice.InputMethodService._onExtractedSelectionChanged6659 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedSelectionChanged", "(II)V");
			global::android.inputmethodservice.InputMethodService._onExtractedTextClicked6660 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedTextClicked", "()V");
			global::android.inputmethodservice.InputMethodService._onExtractedCursorMovement6661 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedCursorMovement", "(II)V");
			global::android.inputmethodservice.InputMethodService._onExtractTextContextMenuItem6662 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractTextContextMenuItem", "(I)Z");
			global::android.inputmethodservice.InputMethodService._getTextForImeAction6663 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "getTextForImeAction", "(I)Ljava/lang/CharSequence;");
			global::android.inputmethodservice.InputMethodService._onUpdateExtractingVisibility6664 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractingVisibility", "(Landroid/view/inputmethod/EditorInfo;)V");
			global::android.inputmethodservice.InputMethodService._onUpdateExtractingViews6665 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractingViews", "(Landroid/view/inputmethod/EditorInfo;)V");
			global::android.inputmethodservice.InputMethodService._onExtractingInputChanged6666 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractingInputChanged", "(Landroid/view/inputmethod/EditorInfo;)V");
			global::android.inputmethodservice.InputMethodService._InputMethodService6667 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.InputMethodService.staticClass, "<init>", "()V");
		}
	}
}
