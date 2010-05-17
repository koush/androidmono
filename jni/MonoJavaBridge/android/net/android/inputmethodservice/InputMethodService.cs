namespace android.inputmethodservice 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class InputMethodService : android.inputmethodservice.AbstractInputMethodService
	{ 
		internal new static global::java.lang.Class staticClass; 
		static InputMethodService() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.inputmethodservice.InputMethodService), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.inputmethodservice.InputMethodService(@__env); 
			} 
		} 
		protected InputMethodService(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class InputMethodImpl : android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl
		{ 
			internal new static global::java.lang.Class staticClass; 
			static InputMethodImpl() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.inputmethodservice.InputMethodService.InputMethodImpl), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.inputmethodservice.InputMethodService.InputMethodImpl(@__env); 
				} 
			} 
			protected InputMethodImpl(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _attachToken3795; 
			public override void attachToken(android.os.IBinder arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.InputMethodService.InputMethodImpl)) 
					@__env.CallVoidMethod(this, _attachToken3795, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, _attachToken3795, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _bindInput3796; 
			public override void bindInput(android.view.inputmethod.InputBinding arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.InputMethodService.InputMethodImpl)) 
					@__env.CallVoidMethod(this, _bindInput3796, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, _bindInput3796, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _unbindInput3797; 
			public override void unbindInput() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.InputMethodService.InputMethodImpl)) 
					@__env.CallVoidMethod(this, _unbindInput3797); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, _unbindInput3797); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _startInput3798; 
			public override void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.InputMethodService.InputMethodImpl)) 
					@__env.CallVoidMethod(this, _startInput3798, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, _startInput3798, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _restartInput3799; 
			public override void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.InputMethodService.InputMethodImpl)) 
					@__env.CallVoidMethod(this, _restartInput3799, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, _restartInput3799, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _showSoftInput3800; 
			public override void showSoftInput(int arg0, android.os.ResultReceiver arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.InputMethodService.InputMethodImpl)) 
					@__env.CallVoidMethod(this, _showSoftInput3800, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, _showSoftInput3800, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _hideSoftInput3801; 
			public override void hideSoftInput(int arg0, android.os.ResultReceiver arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.InputMethodService.InputMethodImpl)) 
					@__env.CallVoidMethod(this, _hideSoftInput3801, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, _hideSoftInput3801, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _InputMethodImpl3802; 
			public InputMethodImpl(android.inputmethodservice.InputMethodService arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, _InputMethodImpl3802, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass = @__class; 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._attachToken3795 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "attachToken", "(Landroid/os/IBinder;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._bindInput3796 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._unbindInput3797 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "unbindInput", "()V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._startInput3798 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._restartInput3799 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._showSoftInput3800 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._hideSoftInput3801 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._InputMethodImpl3802 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "<init>", "(Landroid/inputmethodservice/InputMethodService;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class InputMethodSessionImpl : android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl
		{ 
			internal new static global::java.lang.Class staticClass; 
			static InputMethodSessionImpl() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.inputmethodservice.InputMethodService.InputMethodSessionImpl), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl(@__env); 
				} 
			} 
			protected InputMethodSessionImpl(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _finishInput3803; 
			public override void finishInput() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.InputMethodService.InputMethodSessionImpl)) 
					@__env.CallVoidMethod(this, _finishInput3803); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, _finishInput3803); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _updateSelection3804; 
			public override void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.InputMethodService.InputMethodSessionImpl)) 
					@__env.CallVoidMethod(this, _updateSelection3804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, _updateSelection3804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _updateCursor3805; 
			public override void updateCursor(android.graphics.Rect arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.InputMethodService.InputMethodSessionImpl)) 
					@__env.CallVoidMethod(this, _updateCursor3805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, _updateCursor3805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _displayCompletions3806; 
			public override void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.InputMethodService.InputMethodSessionImpl)) 
					@__env.CallVoidMethod(this, _displayCompletions3806, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, _displayCompletions3806, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _updateExtractedText3807; 
			public override void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.InputMethodService.InputMethodSessionImpl)) 
					@__env.CallVoidMethod(this, _updateExtractedText3807, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, _updateExtractedText3807, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _appPrivateCommand3808; 
			public override void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.InputMethodService.InputMethodSessionImpl)) 
					@__env.CallVoidMethod(this, _appPrivateCommand3808, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, _appPrivateCommand3808, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _toggleSoftInput3809; 
			public override void toggleSoftInput(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.InputMethodService.InputMethodSessionImpl)) 
					@__env.CallVoidMethod(this, _toggleSoftInput3809, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, _toggleSoftInput3809, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _InputMethodSessionImpl3810; 
			public InputMethodSessionImpl(android.inputmethodservice.InputMethodService arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, _InputMethodSessionImpl3810, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass = @__class; 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._finishInput3803 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "finishInput", "()V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateSelection3804 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateSelection", "(IIIIII)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateCursor3805 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._displayCompletions3806 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateExtractedText3807 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._appPrivateCommand3808 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._toggleSoftInput3809 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "toggleSoftInput", "(II)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._InputMethodSessionImpl3810 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "<init>", "(Landroid/inputmethodservice/InputMethodService;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Insets : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Insets() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.inputmethodservice.InputMethodService.Insets), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.inputmethodservice.InputMethodService.Insets(@__env); 
				} 
			} 
			internal Insets(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Insets3811; 
			public Insets()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.inputmethodservice.InputMethodService.Insets.staticClass, _Insets3811, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _contentTopInsets3812; 
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
			internal static global::net.sf.jni4net.jni.FieldId _visibleTopInsets3813; 
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
			internal static global::net.sf.jni4net.jni.FieldId _touchableInsets3814; 
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.inputmethodservice.InputMethodService.Insets.staticClass = @__class; 
				global::android.inputmethodservice.InputMethodService.Insets._Insets3811 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.Insets.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _switchInputMethod3815; 
		public virtual void switchInputMethod(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _switchInputMethod3815, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _switchInputMethod3815, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate3816; 
		public override void onCreate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onCreate3816); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onCreate3816); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy3817; 
		public override void onDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onDestroy3817); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onDestroy3817); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged3818; 
		public override void onConfigurationChanged(android.content.res.Configuration arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onConfigurationChanged3818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onConfigurationChanged3818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump3819; 
		protected override void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _dump3819, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _dump3819, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTheme3820; 
		public override void setTheme(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _setTheme3820, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _setTheme3820, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindow3821; 
		public virtual android.app.Dialog getWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallObjectMethodPtr(this, _getWindow3821)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.InputMethodService.staticClass, _getWindow3821)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown3822; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallBooleanMethod(this, _onKeyDown3822, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onKeyDown3822, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyLongPress3823; 
		public override bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallBooleanMethod(this, _onKeyLongPress3823, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onKeyLongPress3823, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp3824; 
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallBooleanMethod(this, _onKeyUp3824, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onKeyUp3824, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple3825; 
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallBooleanMethod(this, _onKeyMultiple3825, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onKeyMultiple3825, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent3826; 
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallBooleanMethod(this, _onTrackballEvent3826, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onTrackballEvent3826, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutInflater3827; 
		public virtual android.view.LayoutInflater getLayoutInflater() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallObjectMethodPtr(this, _getLayoutInflater3827)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.InputMethodService.staticClass, _getLayoutInflater3827)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputMethodInterface3828; 
		public override android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl>(@__env, @__env.CallObjectMethodPtr(this, _onCreateInputMethodInterface3828)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.InputMethodService.staticClass, _onCreateInputMethodInterface3828)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputMethodSessionInterface3829; 
		public override android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl>(@__env, @__env.CallObjectMethodPtr(this, _onCreateInputMethodSessionInterface3829)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.InputMethodService.staticClass, _onCreateInputMethodSessionInterface3829)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onInitializeInterface3830; 
		public virtual void onInitializeInterface() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onInitializeInterface3830); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onInitializeInterface3830); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxWidth3831; 
		public virtual int getMaxWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallIntMethod(this, _getMaxWidth3831); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.inputmethodservice.InputMethodService.staticClass, _getMaxWidth3831); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentInputBinding3832; 
		public virtual android.view.inputmethod.InputBinding getCurrentInputBinding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.InputBinding>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentInputBinding3832)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.InputBinding>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.InputMethodService.staticClass, _getCurrentInputBinding3832)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentInputConnection3833; 
		public virtual android.view.inputmethod.InputConnection getCurrentInputConnection() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentInputConnection3833)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.InputMethodService.staticClass, _getCurrentInputConnection3833)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentInputStarted3834; 
		public virtual bool getCurrentInputStarted() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallBooleanMethod(this, _getCurrentInputStarted3834); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.InputMethodService.staticClass, _getCurrentInputStarted3834); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentInputEditorInfo3835; 
		public virtual android.view.inputmethod.EditorInfo getCurrentInputEditorInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.EditorInfo>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentInputEditorInfo3835)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.EditorInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.InputMethodService.staticClass, _getCurrentInputEditorInfo3835)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateFullscreenMode3836; 
		public virtual void updateFullscreenMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _updateFullscreenMode3836); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _updateFullscreenMode3836); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onConfigureWindow3837; 
		public virtual void onConfigureWindow(android.view.Window arg0, bool arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onConfigureWindow3837, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onConfigureWindow3837, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFullscreenMode3838; 
		public virtual bool isFullscreenMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallBooleanMethod(this, _isFullscreenMode3838); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.InputMethodService.staticClass, _isFullscreenMode3838); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onEvaluateFullscreenMode3839; 
		public virtual bool onEvaluateFullscreenMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallBooleanMethod(this, _onEvaluateFullscreenMode3839); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onEvaluateFullscreenMode3839); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setExtractViewShown3840; 
		public virtual void setExtractViewShown(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _setExtractViewShown3840, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _setExtractViewShown3840, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isExtractViewShown3841; 
		public virtual bool isExtractViewShown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallBooleanMethod(this, _isExtractViewShown3841); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.InputMethodService.staticClass, _isExtractViewShown3841); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onComputeInsets3842; 
		public virtual void onComputeInsets(android.inputmethodservice.InputMethodService.Insets arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onComputeInsets3842, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onComputeInsets3842, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateInputViewShown3843; 
		public virtual void updateInputViewShown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _updateInputViewShown3843); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _updateInputViewShown3843); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShowInputRequested3844; 
		public virtual bool isShowInputRequested() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallBooleanMethod(this, _isShowInputRequested3844); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.InputMethodService.staticClass, _isShowInputRequested3844); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInputViewShown3845; 
		public virtual bool isInputViewShown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallBooleanMethod(this, _isInputViewShown3845); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.InputMethodService.staticClass, _isInputViewShown3845); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onEvaluateInputViewShown3846; 
		public virtual bool onEvaluateInputViewShown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallBooleanMethod(this, _onEvaluateInputViewShown3846); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onEvaluateInputViewShown3846); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCandidatesViewShown3847; 
		public virtual void setCandidatesViewShown(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _setCandidatesViewShown3847, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _setCandidatesViewShown3847, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCandidatesHiddenVisibility3848; 
		public virtual int getCandidatesHiddenVisibility() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallIntMethod(this, _getCandidatesHiddenVisibility3848); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.inputmethodservice.InputMethodService.staticClass, _getCandidatesHiddenVisibility3848); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showStatusIcon3849; 
		public virtual void showStatusIcon(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _showStatusIcon3849, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _showStatusIcon3849, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hideStatusIcon3850; 
		public virtual void hideStatusIcon() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _hideStatusIcon3850); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _hideStatusIcon3850); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setExtractView3851; 
		public virtual void setExtractView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _setExtractView3851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _setExtractView3851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCandidatesView3852; 
		public virtual void setCandidatesView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _setCandidatesView3852, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _setCandidatesView3852, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInputView3853; 
		public virtual void setInputView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _setInputView3853, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _setInputView3853, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateExtractTextView3854; 
		public virtual android.view.View onCreateExtractTextView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _onCreateExtractTextView3854)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.InputMethodService.staticClass, _onCreateExtractTextView3854)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateCandidatesView3855; 
		public virtual android.view.View onCreateCandidatesView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _onCreateCandidatesView3855)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.InputMethodService.staticClass, _onCreateCandidatesView3855)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputView3856; 
		public virtual android.view.View onCreateInputView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _onCreateInputView3856)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.InputMethodService.staticClass, _onCreateInputView3856)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStartInputView3857; 
		public virtual void onStartInputView(android.view.inputmethod.EditorInfo arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onStartInputView3857, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onStartInputView3857, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInputView3858; 
		public virtual void onFinishInputView(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onFinishInputView3858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onFinishInputView3858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStartCandidatesView3859; 
		public virtual void onStartCandidatesView(android.view.inputmethod.EditorInfo arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onStartCandidatesView3859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onStartCandidatesView3859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishCandidatesView3860; 
		public virtual void onFinishCandidatesView(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onFinishCandidatesView3860, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onFinishCandidatesView3860, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onShowInputRequested3861; 
		public virtual bool onShowInputRequested(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallBooleanMethod(this, _onShowInputRequested3861, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onShowInputRequested3861, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showWindow3862; 
		public virtual void showWindow(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _showWindow3862, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _showWindow3862, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hideWindow3863; 
		public virtual void hideWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _hideWindow3863); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _hideWindow3863); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowShown3864; 
		public virtual void onWindowShown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onWindowShown3864); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onWindowShown3864); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowHidden3865; 
		public virtual void onWindowHidden() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onWindowHidden3865); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onWindowHidden3865); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBindInput3866; 
		public virtual void onBindInput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onBindInput3866); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onBindInput3866); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUnbindInput3867; 
		public virtual void onUnbindInput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onUnbindInput3867); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onUnbindInput3867); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStartInput3868; 
		public virtual void onStartInput(android.view.inputmethod.EditorInfo arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onStartInput3868, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onStartInput3868, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInput3869; 
		public virtual void onFinishInput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onFinishInput3869); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onFinishInput3869); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDisplayCompletions3870; 
		public virtual void onDisplayCompletions(android.view.inputmethod.CompletionInfo[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onDisplayCompletions3870, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onDisplayCompletions3870, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateExtractedText3871; 
		public virtual void onUpdateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onUpdateExtractedText3871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onUpdateExtractedText3871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateSelection3872; 
		public virtual void onUpdateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onUpdateSelection3872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onUpdateSelection3872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateCursor3873; 
		public virtual void onUpdateCursor(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onUpdateCursor3873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onUpdateCursor3873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestHideSelf3874; 
		public virtual void requestHideSelf(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _requestHideSelf3874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _requestHideSelf3874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAppPrivateCommand3875; 
		public virtual void onAppPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onAppPrivateCommand3875, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onAppPrivateCommand3875, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendDownUpKeyEvents3876; 
		public virtual void sendDownUpKeyEvents(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _sendDownUpKeyEvents3876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _sendDownUpKeyEvents3876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendDefaultEditorAction3877; 
		public virtual bool sendDefaultEditorAction(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallBooleanMethod(this, _sendDefaultEditorAction3877, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.InputMethodService.staticClass, _sendDefaultEditorAction3877, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendKeyChar3878; 
		public virtual void sendKeyChar(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _sendKeyChar3878, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _sendKeyChar3878, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onExtractedSelectionChanged3879; 
		public virtual void onExtractedSelectionChanged(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onExtractedSelectionChanged3879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onExtractedSelectionChanged3879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onExtractedTextClicked3880; 
		public virtual void onExtractedTextClicked() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onExtractedTextClicked3880); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onExtractedTextClicked3880); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onExtractedCursorMovement3881; 
		public virtual void onExtractedCursorMovement(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onExtractedCursorMovement3881, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onExtractedCursorMovement3881, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onExtractTextContextMenuItem3882; 
		public virtual bool onExtractTextContextMenuItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return @__env.CallBooleanMethod(this, _onExtractTextContextMenuItem3882, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onExtractTextContextMenuItem3882, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextForImeAction3883; 
		public virtual java.lang.CharSequence getTextForImeAction(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getTextForImeAction3883, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.InputMethodService.staticClass, _getTextForImeAction3883, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateExtractingVisibility3884; 
		public virtual void onUpdateExtractingVisibility(android.view.inputmethod.EditorInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onUpdateExtractingVisibility3884, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onUpdateExtractingVisibility3884, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateExtractingViews3885; 
		public virtual void onUpdateExtractingViews(android.view.inputmethod.EditorInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onUpdateExtractingViews3885, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onUpdateExtractingViews3885, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onExtractingInputChanged3886; 
		public virtual void onExtractingInputChanged(android.view.inputmethod.EditorInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.InputMethodService)) 
				@__env.CallVoidMethod(this, _onExtractingInputChanged3886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.InputMethodService.staticClass, _onExtractingInputChanged3886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputMethodService3887; 
		public InputMethodService()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.InputMethodService.staticClass, _InputMethodService3887, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.inputmethodservice.InputMethodService.staticClass = @__class; 
			global::android.inputmethodservice.InputMethodService._switchInputMethod3815 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "switchInputMethod", "(Ljava/lang/String;)V"); 
			global::android.inputmethodservice.InputMethodService._onCreate3816 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreate", "()V"); 
			global::android.inputmethodservice.InputMethodService._onDestroy3817 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onDestroy", "()V"); 
			global::android.inputmethodservice.InputMethodService._onConfigurationChanged3818 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"); 
			global::android.inputmethodservice.InputMethodService._dump3819 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V"); 
			global::android.inputmethodservice.InputMethodService._setTheme3820 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setTheme", "(I)V"); 
			global::android.inputmethodservice.InputMethodService._getWindow3821 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getWindow", "()Landroid/app/Dialog;"); 
			global::android.inputmethodservice.InputMethodService._onKeyDown3822 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.inputmethodservice.InputMethodService._onKeyLongPress3823 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.inputmethodservice.InputMethodService._onKeyUp3824 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.inputmethodservice.InputMethodService._onKeyMultiple3825 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z"); 
			global::android.inputmethodservice.InputMethodService._onTrackballEvent3826 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.inputmethodservice.InputMethodService._getLayoutInflater3827 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;"); 
			global::android.inputmethodservice.InputMethodService._onCreateInputMethodInterface3828 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;"); 
			global::android.inputmethodservice.InputMethodService._onCreateInputMethodSessionInterface3829 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;"); 
			global::android.inputmethodservice.InputMethodService._onInitializeInterface3830 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onInitializeInterface", "()V"); 
			global::android.inputmethodservice.InputMethodService._getMaxWidth3831 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getMaxWidth", "()I"); 
			global::android.inputmethodservice.InputMethodService._getCurrentInputBinding3832 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputBinding", "()Landroid/view/inputmethod/InputBinding;"); 
			global::android.inputmethodservice.InputMethodService._getCurrentInputConnection3833 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputConnection", "()Landroid/view/inputmethod/InputConnection;"); 
			global::android.inputmethodservice.InputMethodService._getCurrentInputStarted3834 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputStarted", "()Z"); 
			global::android.inputmethodservice.InputMethodService._getCurrentInputEditorInfo3835 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputEditorInfo", "()Landroid/view/inputmethod/EditorInfo;"); 
			global::android.inputmethodservice.InputMethodService._updateFullscreenMode3836 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "updateFullscreenMode", "()V"); 
			global::android.inputmethodservice.InputMethodService._onConfigureWindow3837 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onConfigureWindow", "(Landroid/view/Window;ZZ)V"); 
			global::android.inputmethodservice.InputMethodService._isFullscreenMode3838 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "isFullscreenMode", "()Z"); 
			global::android.inputmethodservice.InputMethodService._onEvaluateFullscreenMode3839 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onEvaluateFullscreenMode", "()Z"); 
			global::android.inputmethodservice.InputMethodService._setExtractViewShown3840 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setExtractViewShown", "(Z)V"); 
			global::android.inputmethodservice.InputMethodService._isExtractViewShown3841 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "isExtractViewShown", "()Z"); 
			global::android.inputmethodservice.InputMethodService._onComputeInsets3842 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onComputeInsets", "(Landroid/inputmethodservice/InputMethodService$Insets;)V"); 
			global::android.inputmethodservice.InputMethodService._updateInputViewShown3843 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "updateInputViewShown", "()V"); 
			global::android.inputmethodservice.InputMethodService._isShowInputRequested3844 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "isShowInputRequested", "()Z"); 
			global::android.inputmethodservice.InputMethodService._isInputViewShown3845 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "isInputViewShown", "()Z"); 
			global::android.inputmethodservice.InputMethodService._onEvaluateInputViewShown3846 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onEvaluateInputViewShown", "()Z"); 
			global::android.inputmethodservice.InputMethodService._setCandidatesViewShown3847 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setCandidatesViewShown", "(Z)V"); 
			global::android.inputmethodservice.InputMethodService._getCandidatesHiddenVisibility3848 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getCandidatesHiddenVisibility", "()I"); 
			global::android.inputmethodservice.InputMethodService._showStatusIcon3849 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "showStatusIcon", "(I)V"); 
			global::android.inputmethodservice.InputMethodService._hideStatusIcon3850 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "hideStatusIcon", "()V"); 
			global::android.inputmethodservice.InputMethodService._setExtractView3851 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setExtractView", "(Landroid/view/View;)V"); 
			global::android.inputmethodservice.InputMethodService._setCandidatesView3852 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setCandidatesView", "(Landroid/view/View;)V"); 
			global::android.inputmethodservice.InputMethodService._setInputView3853 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setInputView", "(Landroid/view/View;)V"); 
			global::android.inputmethodservice.InputMethodService._onCreateExtractTextView3854 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateExtractTextView", "()Landroid/view/View;"); 
			global::android.inputmethodservice.InputMethodService._onCreateCandidatesView3855 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateCandidatesView", "()Landroid/view/View;"); 
			global::android.inputmethodservice.InputMethodService._onCreateInputView3856 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputView", "()Landroid/view/View;"); 
			global::android.inputmethodservice.InputMethodService._onStartInputView3857 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onStartInputView", "(Landroid/view/inputmethod/EditorInfo;Z)V"); 
			global::android.inputmethodservice.InputMethodService._onFinishInputView3858 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onFinishInputView", "(Z)V"); 
			global::android.inputmethodservice.InputMethodService._onStartCandidatesView3859 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onStartCandidatesView", "(Landroid/view/inputmethod/EditorInfo;Z)V"); 
			global::android.inputmethodservice.InputMethodService._onFinishCandidatesView3860 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onFinishCandidatesView", "(Z)V"); 
			global::android.inputmethodservice.InputMethodService._onShowInputRequested3861 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onShowInputRequested", "(IZ)Z"); 
			global::android.inputmethodservice.InputMethodService._showWindow3862 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "showWindow", "(Z)V"); 
			global::android.inputmethodservice.InputMethodService._hideWindow3863 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "hideWindow", "()V"); 
			global::android.inputmethodservice.InputMethodService._onWindowShown3864 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onWindowShown", "()V"); 
			global::android.inputmethodservice.InputMethodService._onWindowHidden3865 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onWindowHidden", "()V"); 
			global::android.inputmethodservice.InputMethodService._onBindInput3866 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onBindInput", "()V"); 
			global::android.inputmethodservice.InputMethodService._onUnbindInput3867 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUnbindInput", "()V"); 
			global::android.inputmethodservice.InputMethodService._onStartInput3868 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onStartInput", "(Landroid/view/inputmethod/EditorInfo;Z)V"); 
			global::android.inputmethodservice.InputMethodService._onFinishInput3869 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onFinishInput", "()V"); 
			global::android.inputmethodservice.InputMethodService._onDisplayCompletions3870 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onDisplayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V"); 
			global::android.inputmethodservice.InputMethodService._onUpdateExtractedText3871 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V"); 
			global::android.inputmethodservice.InputMethodService._onUpdateSelection3872 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateSelection", "(IIIIII)V"); 
			global::android.inputmethodservice.InputMethodService._onUpdateCursor3873 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateCursor", "(Landroid/graphics/Rect;)V"); 
			global::android.inputmethodservice.InputMethodService._requestHideSelf3874 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "requestHideSelf", "(I)V"); 
			global::android.inputmethodservice.InputMethodService._onAppPrivateCommand3875 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onAppPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.inputmethodservice.InputMethodService._sendDownUpKeyEvents3876 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "sendDownUpKeyEvents", "(I)V"); 
			global::android.inputmethodservice.InputMethodService._sendDefaultEditorAction3877 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "sendDefaultEditorAction", "(Z)Z"); 
			global::android.inputmethodservice.InputMethodService._sendKeyChar3878 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "sendKeyChar", "(C)V"); 
			global::android.inputmethodservice.InputMethodService._onExtractedSelectionChanged3879 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedSelectionChanged", "(II)V"); 
			global::android.inputmethodservice.InputMethodService._onExtractedTextClicked3880 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedTextClicked", "()V"); 
			global::android.inputmethodservice.InputMethodService._onExtractedCursorMovement3881 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedCursorMovement", "(II)V"); 
			global::android.inputmethodservice.InputMethodService._onExtractTextContextMenuItem3882 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractTextContextMenuItem", "(I)Z"); 
			global::android.inputmethodservice.InputMethodService._getTextForImeAction3883 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getTextForImeAction", "(I)Ljava/lang/CharSequence;"); 
			global::android.inputmethodservice.InputMethodService._onUpdateExtractingVisibility3884 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractingVisibility", "(Landroid/view/inputmethod/EditorInfo;)V"); 
			global::android.inputmethodservice.InputMethodService._onUpdateExtractingViews3885 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractingViews", "(Landroid/view/inputmethod/EditorInfo;)V"); 
			global::android.inputmethodservice.InputMethodService._onExtractingInputChanged3886 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractingInputChanged", "(Landroid/view/inputmethod/EditorInfo;)V"); 
			global::android.inputmethodservice.InputMethodService._InputMethodService3887 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "<init>", "()V"); 
		} 
	} 
} 
