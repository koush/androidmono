namespace android.inputmethodservice 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class InputMethodService : android.inputmethodservice.AbstractInputMethodService
	{ 
		internal new static global::java.lang.Class staticClass; 
		static InputMethodService() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.inputmethodservice.InputMethodService), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.inputmethodservice.InputMethodService.InputMethodImpl), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _attachToken4010; 
			public override void attachToken(android.os.IBinder arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl._attachToken4010, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._attachToken4010, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _bindInput4011; 
			public override void bindInput(android.view.inputmethod.InputBinding arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl._bindInput4011, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._bindInput4011, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _unbindInput4012; 
			public override void unbindInput() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl._unbindInput4012); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._unbindInput4012); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _startInput4013; 
			public override void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl._startInput4013, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._startInput4013, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _restartInput4014; 
			public override void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl._restartInput4014, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._restartInput4014, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _showSoftInput4015; 
			public override void showSoftInput(int arg0, android.os.ResultReceiver arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl._showSoftInput4015, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._showSoftInput4015, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _hideSoftInput4016; 
			public override void hideSoftInput(int arg0, android.os.ResultReceiver arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl._hideSoftInput4016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._hideSoftInput4016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _InputMethodImpl4017; 
			public InputMethodImpl(android.inputmethodservice.InputMethodService arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._InputMethodImpl4017, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass = @__class; 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._attachToken4010 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "attachToken", "(Landroid/os/IBinder;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._bindInput4011 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._unbindInput4012 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "unbindInput", "()V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._startInput4013 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._restartInput4014 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._showSoftInput4015 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._hideSoftInput4016 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._InputMethodImpl4017 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "<init>", "(Landroid/inputmethodservice/InputMethodService;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class InputMethodSessionImpl : android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl
		{ 
			internal new static global::java.lang.Class staticClass; 
			static InputMethodSessionImpl() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _finishInput4018; 
			public override void finishInput() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._finishInput4018); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._finishInput4018); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _updateSelection4019; 
			public override void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateSelection4019, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateSelection4019, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _updateCursor4020; 
			public override void updateCursor(android.graphics.Rect arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateCursor4020, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateCursor4020, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _displayCompletions4021; 
			public override void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._displayCompletions4021, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._displayCompletions4021, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _updateExtractedText4022; 
			public override void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateExtractedText4022, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateExtractedText4022, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _appPrivateCommand4023; 
			public override void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._appPrivateCommand4023, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._appPrivateCommand4023, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _toggleSoftInput4024; 
			public override void toggleSoftInput(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._toggleSoftInput4024, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._toggleSoftInput4024, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _InputMethodSessionImpl4025; 
			public InputMethodSessionImpl(android.inputmethodservice.InputMethodService arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._InputMethodSessionImpl4025, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass = @__class; 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._finishInput4018 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "finishInput", "()V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateSelection4019 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateSelection", "(IIIIII)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateCursor4020 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._displayCompletions4021 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateExtractedText4022 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._appPrivateCommand4023 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._toggleSoftInput4024 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "toggleSoftInput", "(II)V"); 
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._InputMethodSessionImpl4025 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "<init>", "(Landroid/inputmethodservice/InputMethodService;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Insets : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Insets() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.inputmethodservice.InputMethodService.Insets), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _Insets4026; 
			public Insets()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.inputmethodservice.InputMethodService.Insets.staticClass, global::android.inputmethodservice.InputMethodService.Insets._Insets4026, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _contentTopInsets4027; 
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
			internal static global::net.sf.jni4net.jni.FieldId _visibleTopInsets4028; 
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
			internal static global::net.sf.jni4net.jni.FieldId _touchableInsets4029; 
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
				global::android.inputmethodservice.InputMethodService.Insets._Insets4026 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.Insets.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _switchInputMethod4030; 
		public virtual void switchInputMethod(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._switchInputMethod4030, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._switchInputMethod4030, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate4031; 
		public override void onCreate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onCreate4031); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreate4031); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy4032; 
		public override void onDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onDestroy4032); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onDestroy4032); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged4033; 
		public override void onConfigurationChanged(android.content.res.Configuration arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onConfigurationChanged4033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onConfigurationChanged4033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump4034; 
		protected override void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._dump4034, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._dump4034, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTheme4035; 
		public override void setTheme(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._setTheme4035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setTheme4035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindow4036; 
		public virtual global::android.app.Dialog getWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._getWindow4036)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getWindow4036)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown4037; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onKeyDown4037, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyDown4037, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyLongPress4038; 
		public override bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onKeyLongPress4038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyLongPress4038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp4039; 
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onKeyUp4039, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyUp4039, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple4040; 
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onKeyMultiple4040, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyMultiple4040, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent4041; 
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onTrackballEvent4041, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onTrackballEvent4041, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutInflater4042; 
		public virtual global::android.view.LayoutInflater getLayoutInflater() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._getLayoutInflater4042)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getLayoutInflater4042)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputMethodInterface4043; 
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._onCreateInputMethodInterface4043)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateInputMethodInterface4043)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputMethodSessionInterface4044; 
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._onCreateInputMethodSessionInterface4044)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateInputMethodSessionInterface4044)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onInitializeInterface4045; 
		public virtual void onInitializeInterface() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onInitializeInterface4045); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onInitializeInterface4045); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxWidth4046; 
		public virtual int getMaxWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.inputmethodservice.InputMethodService._getMaxWidth4046); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getMaxWidth4046); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentInputBinding4047; 
		public virtual global::android.view.inputmethod.InputBinding getCurrentInputBinding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.InputBinding>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._getCurrentInputBinding4047)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.InputBinding>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputBinding4047)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentInputConnection4048; 
		public virtual global::android.view.inputmethod.InputConnection getCurrentInputConnection() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._getCurrentInputConnection4048)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputConnection4048)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentInputStarted4049; 
		public virtual bool getCurrentInputStarted() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._getCurrentInputStarted4049); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputStarted4049); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentInputEditorInfo4050; 
		public virtual global::android.view.inputmethod.EditorInfo getCurrentInputEditorInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.EditorInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._getCurrentInputEditorInfo4050)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.EditorInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputEditorInfo4050)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateFullscreenMode4051; 
		public virtual void updateFullscreenMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._updateFullscreenMode4051); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._updateFullscreenMode4051); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onConfigureWindow4052; 
		public virtual void onConfigureWindow(android.view.Window arg0, bool arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onConfigureWindow4052, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onConfigureWindow4052, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFullscreenMode4053; 
		public virtual bool isFullscreenMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._isFullscreenMode4053); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isFullscreenMode4053); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onEvaluateFullscreenMode4054; 
		public virtual bool onEvaluateFullscreenMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onEvaluateFullscreenMode4054); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onEvaluateFullscreenMode4054); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setExtractViewShown4055; 
		public virtual void setExtractViewShown(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._setExtractViewShown4055, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setExtractViewShown4055, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isExtractViewShown4056; 
		public virtual bool isExtractViewShown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._isExtractViewShown4056); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isExtractViewShown4056); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onComputeInsets4057; 
		public virtual void onComputeInsets(android.inputmethodservice.InputMethodService.Insets arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onComputeInsets4057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onComputeInsets4057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateInputViewShown4058; 
		public virtual void updateInputViewShown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._updateInputViewShown4058); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._updateInputViewShown4058); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShowInputRequested4059; 
		public virtual bool isShowInputRequested() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._isShowInputRequested4059); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isShowInputRequested4059); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInputViewShown4060; 
		public virtual bool isInputViewShown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._isInputViewShown4060); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isInputViewShown4060); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onEvaluateInputViewShown4061; 
		public virtual bool onEvaluateInputViewShown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onEvaluateInputViewShown4061); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onEvaluateInputViewShown4061); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCandidatesViewShown4062; 
		public virtual void setCandidatesViewShown(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._setCandidatesViewShown4062, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setCandidatesViewShown4062, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCandidatesHiddenVisibility4063; 
		public virtual int getCandidatesHiddenVisibility() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.inputmethodservice.InputMethodService._getCandidatesHiddenVisibility4063); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCandidatesHiddenVisibility4063); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showStatusIcon4064; 
		public virtual void showStatusIcon(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._showStatusIcon4064, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._showStatusIcon4064, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hideStatusIcon4065; 
		public virtual void hideStatusIcon() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._hideStatusIcon4065); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._hideStatusIcon4065); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setExtractView4066; 
		public virtual void setExtractView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._setExtractView4066, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setExtractView4066, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCandidatesView4067; 
		public virtual void setCandidatesView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._setCandidatesView4067, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setCandidatesView4067, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInputView4068; 
		public virtual void setInputView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._setInputView4068, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setInputView4068, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateExtractTextView4069; 
		public virtual global::android.view.View onCreateExtractTextView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._onCreateExtractTextView4069)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateExtractTextView4069)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateCandidatesView4070; 
		public virtual global::android.view.View onCreateCandidatesView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._onCreateCandidatesView4070)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateCandidatesView4070)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputView4071; 
		public virtual global::android.view.View onCreateInputView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._onCreateInputView4071)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateInputView4071)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStartInputView4072; 
		public virtual void onStartInputView(android.view.inputmethod.EditorInfo arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onStartInputView4072, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onStartInputView4072, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInputView4073; 
		public virtual void onFinishInputView(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onFinishInputView4073, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onFinishInputView4073, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStartCandidatesView4074; 
		public virtual void onStartCandidatesView(android.view.inputmethod.EditorInfo arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onStartCandidatesView4074, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onStartCandidatesView4074, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishCandidatesView4075; 
		public virtual void onFinishCandidatesView(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onFinishCandidatesView4075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onFinishCandidatesView4075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onShowInputRequested4076; 
		public virtual bool onShowInputRequested(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onShowInputRequested4076, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onShowInputRequested4076, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showWindow4077; 
		public virtual void showWindow(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._showWindow4077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._showWindow4077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hideWindow4078; 
		public virtual void hideWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._hideWindow4078); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._hideWindow4078); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowShown4079; 
		public virtual void onWindowShown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onWindowShown4079); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onWindowShown4079); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowHidden4080; 
		public virtual void onWindowHidden() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onWindowHidden4080); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onWindowHidden4080); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBindInput4081; 
		public virtual void onBindInput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onBindInput4081); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onBindInput4081); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUnbindInput4082; 
		public virtual void onUnbindInput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onUnbindInput4082); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUnbindInput4082); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStartInput4083; 
		public virtual void onStartInput(android.view.inputmethod.EditorInfo arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onStartInput4083, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onStartInput4083, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInput4084; 
		public virtual void onFinishInput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onFinishInput4084); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onFinishInput4084); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDisplayCompletions4085; 
		public virtual void onDisplayCompletions(android.view.inputmethod.CompletionInfo[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onDisplayCompletions4085, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onDisplayCompletions4085, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateExtractedText4086; 
		public virtual void onUpdateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onUpdateExtractedText4086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateExtractedText4086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateSelection4087; 
		public virtual void onUpdateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onUpdateSelection4087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateSelection4087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateCursor4088; 
		public virtual void onUpdateCursor(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onUpdateCursor4088, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateCursor4088, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestHideSelf4089; 
		public virtual void requestHideSelf(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._requestHideSelf4089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._requestHideSelf4089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAppPrivateCommand4090; 
		public virtual void onAppPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onAppPrivateCommand4090, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onAppPrivateCommand4090, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendDownUpKeyEvents4091; 
		public virtual void sendDownUpKeyEvents(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._sendDownUpKeyEvents4091, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._sendDownUpKeyEvents4091, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendDefaultEditorAction4092; 
		public virtual bool sendDefaultEditorAction(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._sendDefaultEditorAction4092, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._sendDefaultEditorAction4092, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendKeyChar4093; 
		public virtual void sendKeyChar(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._sendKeyChar4093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._sendKeyChar4093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onExtractedSelectionChanged4094; 
		public virtual void onExtractedSelectionChanged(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onExtractedSelectionChanged4094, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractedSelectionChanged4094, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onExtractedTextClicked4095; 
		public virtual void onExtractedTextClicked() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onExtractedTextClicked4095); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractedTextClicked4095); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onExtractedCursorMovement4096; 
		public virtual void onExtractedCursorMovement(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onExtractedCursorMovement4096, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractedCursorMovement4096, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onExtractTextContextMenuItem4097; 
		public virtual bool onExtractTextContextMenuItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onExtractTextContextMenuItem4097, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractTextContextMenuItem4097, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextForImeAction4098; 
		public virtual global::java.lang.CharSequence getTextForImeAction(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._getTextForImeAction4098, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getTextForImeAction4098, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateExtractingVisibility4099; 
		public virtual void onUpdateExtractingVisibility(android.view.inputmethod.EditorInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onUpdateExtractingVisibility4099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateExtractingVisibility4099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateExtractingViews4100; 
		public virtual void onUpdateExtractingViews(android.view.inputmethod.EditorInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onUpdateExtractingViews4100, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateExtractingViews4100, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onExtractingInputChanged4101; 
		public virtual void onExtractingInputChanged(android.view.inputmethod.EditorInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onExtractingInputChanged4101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractingInputChanged4101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputMethodService4102; 
		public InputMethodService()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._InputMethodService4102, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.inputmethodservice.InputMethodService.staticClass = @__class; 
			global::android.inputmethodservice.InputMethodService._switchInputMethod4030 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "switchInputMethod", "(Ljava/lang/String;)V"); 
			global::android.inputmethodservice.InputMethodService._onCreate4031 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreate", "()V"); 
			global::android.inputmethodservice.InputMethodService._onDestroy4032 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onDestroy", "()V"); 
			global::android.inputmethodservice.InputMethodService._onConfigurationChanged4033 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"); 
			global::android.inputmethodservice.InputMethodService._dump4034 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V"); 
			global::android.inputmethodservice.InputMethodService._setTheme4035 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setTheme", "(I)V"); 
			global::android.inputmethodservice.InputMethodService._getWindow4036 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getWindow", "()Landroid/app/Dialog;"); 
			global::android.inputmethodservice.InputMethodService._onKeyDown4037 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.inputmethodservice.InputMethodService._onKeyLongPress4038 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.inputmethodservice.InputMethodService._onKeyUp4039 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.inputmethodservice.InputMethodService._onKeyMultiple4040 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z"); 
			global::android.inputmethodservice.InputMethodService._onTrackballEvent4041 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.inputmethodservice.InputMethodService._getLayoutInflater4042 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;"); 
			global::android.inputmethodservice.InputMethodService._onCreateInputMethodInterface4043 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;"); 
			global::android.inputmethodservice.InputMethodService._onCreateInputMethodSessionInterface4044 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;"); 
			global::android.inputmethodservice.InputMethodService._onInitializeInterface4045 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onInitializeInterface", "()V"); 
			global::android.inputmethodservice.InputMethodService._getMaxWidth4046 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getMaxWidth", "()I"); 
			global::android.inputmethodservice.InputMethodService._getCurrentInputBinding4047 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputBinding", "()Landroid/view/inputmethod/InputBinding;"); 
			global::android.inputmethodservice.InputMethodService._getCurrentInputConnection4048 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputConnection", "()Landroid/view/inputmethod/InputConnection;"); 
			global::android.inputmethodservice.InputMethodService._getCurrentInputStarted4049 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputStarted", "()Z"); 
			global::android.inputmethodservice.InputMethodService._getCurrentInputEditorInfo4050 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputEditorInfo", "()Landroid/view/inputmethod/EditorInfo;"); 
			global::android.inputmethodservice.InputMethodService._updateFullscreenMode4051 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "updateFullscreenMode", "()V"); 
			global::android.inputmethodservice.InputMethodService._onConfigureWindow4052 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onConfigureWindow", "(Landroid/view/Window;ZZ)V"); 
			global::android.inputmethodservice.InputMethodService._isFullscreenMode4053 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "isFullscreenMode", "()Z"); 
			global::android.inputmethodservice.InputMethodService._onEvaluateFullscreenMode4054 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onEvaluateFullscreenMode", "()Z"); 
			global::android.inputmethodservice.InputMethodService._setExtractViewShown4055 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setExtractViewShown", "(Z)V"); 
			global::android.inputmethodservice.InputMethodService._isExtractViewShown4056 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "isExtractViewShown", "()Z"); 
			global::android.inputmethodservice.InputMethodService._onComputeInsets4057 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onComputeInsets", "(Landroid/inputmethodservice/InputMethodService$Insets;)V"); 
			global::android.inputmethodservice.InputMethodService._updateInputViewShown4058 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "updateInputViewShown", "()V"); 
			global::android.inputmethodservice.InputMethodService._isShowInputRequested4059 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "isShowInputRequested", "()Z"); 
			global::android.inputmethodservice.InputMethodService._isInputViewShown4060 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "isInputViewShown", "()Z"); 
			global::android.inputmethodservice.InputMethodService._onEvaluateInputViewShown4061 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onEvaluateInputViewShown", "()Z"); 
			global::android.inputmethodservice.InputMethodService._setCandidatesViewShown4062 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setCandidatesViewShown", "(Z)V"); 
			global::android.inputmethodservice.InputMethodService._getCandidatesHiddenVisibility4063 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getCandidatesHiddenVisibility", "()I"); 
			global::android.inputmethodservice.InputMethodService._showStatusIcon4064 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "showStatusIcon", "(I)V"); 
			global::android.inputmethodservice.InputMethodService._hideStatusIcon4065 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "hideStatusIcon", "()V"); 
			global::android.inputmethodservice.InputMethodService._setExtractView4066 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setExtractView", "(Landroid/view/View;)V"); 
			global::android.inputmethodservice.InputMethodService._setCandidatesView4067 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setCandidatesView", "(Landroid/view/View;)V"); 
			global::android.inputmethodservice.InputMethodService._setInputView4068 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setInputView", "(Landroid/view/View;)V"); 
			global::android.inputmethodservice.InputMethodService._onCreateExtractTextView4069 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateExtractTextView", "()Landroid/view/View;"); 
			global::android.inputmethodservice.InputMethodService._onCreateCandidatesView4070 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateCandidatesView", "()Landroid/view/View;"); 
			global::android.inputmethodservice.InputMethodService._onCreateInputView4071 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputView", "()Landroid/view/View;"); 
			global::android.inputmethodservice.InputMethodService._onStartInputView4072 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onStartInputView", "(Landroid/view/inputmethod/EditorInfo;Z)V"); 
			global::android.inputmethodservice.InputMethodService._onFinishInputView4073 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onFinishInputView", "(Z)V"); 
			global::android.inputmethodservice.InputMethodService._onStartCandidatesView4074 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onStartCandidatesView", "(Landroid/view/inputmethod/EditorInfo;Z)V"); 
			global::android.inputmethodservice.InputMethodService._onFinishCandidatesView4075 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onFinishCandidatesView", "(Z)V"); 
			global::android.inputmethodservice.InputMethodService._onShowInputRequested4076 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onShowInputRequested", "(IZ)Z"); 
			global::android.inputmethodservice.InputMethodService._showWindow4077 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "showWindow", "(Z)V"); 
			global::android.inputmethodservice.InputMethodService._hideWindow4078 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "hideWindow", "()V"); 
			global::android.inputmethodservice.InputMethodService._onWindowShown4079 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onWindowShown", "()V"); 
			global::android.inputmethodservice.InputMethodService._onWindowHidden4080 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onWindowHidden", "()V"); 
			global::android.inputmethodservice.InputMethodService._onBindInput4081 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onBindInput", "()V"); 
			global::android.inputmethodservice.InputMethodService._onUnbindInput4082 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUnbindInput", "()V"); 
			global::android.inputmethodservice.InputMethodService._onStartInput4083 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onStartInput", "(Landroid/view/inputmethod/EditorInfo;Z)V"); 
			global::android.inputmethodservice.InputMethodService._onFinishInput4084 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onFinishInput", "()V"); 
			global::android.inputmethodservice.InputMethodService._onDisplayCompletions4085 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onDisplayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V"); 
			global::android.inputmethodservice.InputMethodService._onUpdateExtractedText4086 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V"); 
			global::android.inputmethodservice.InputMethodService._onUpdateSelection4087 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateSelection", "(IIIIII)V"); 
			global::android.inputmethodservice.InputMethodService._onUpdateCursor4088 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateCursor", "(Landroid/graphics/Rect;)V"); 
			global::android.inputmethodservice.InputMethodService._requestHideSelf4089 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "requestHideSelf", "(I)V"); 
			global::android.inputmethodservice.InputMethodService._onAppPrivateCommand4090 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onAppPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.inputmethodservice.InputMethodService._sendDownUpKeyEvents4091 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "sendDownUpKeyEvents", "(I)V"); 
			global::android.inputmethodservice.InputMethodService._sendDefaultEditorAction4092 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "sendDefaultEditorAction", "(Z)Z"); 
			global::android.inputmethodservice.InputMethodService._sendKeyChar4093 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "sendKeyChar", "(C)V"); 
			global::android.inputmethodservice.InputMethodService._onExtractedSelectionChanged4094 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedSelectionChanged", "(II)V"); 
			global::android.inputmethodservice.InputMethodService._onExtractedTextClicked4095 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedTextClicked", "()V"); 
			global::android.inputmethodservice.InputMethodService._onExtractedCursorMovement4096 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedCursorMovement", "(II)V"); 
			global::android.inputmethodservice.InputMethodService._onExtractTextContextMenuItem4097 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractTextContextMenuItem", "(I)Z"); 
			global::android.inputmethodservice.InputMethodService._getTextForImeAction4098 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getTextForImeAction", "(I)Ljava/lang/CharSequence;"); 
			global::android.inputmethodservice.InputMethodService._onUpdateExtractingVisibility4099 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractingVisibility", "(Landroid/view/inputmethod/EditorInfo;)V"); 
			global::android.inputmethodservice.InputMethodService._onUpdateExtractingViews4100 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractingViews", "(Landroid/view/inputmethod/EditorInfo;)V"); 
			global::android.inputmethodservice.InputMethodService._onExtractingInputChanged4101 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractingInputChanged", "(Landroid/view/inputmethod/EditorInfo;)V"); 
			global::android.inputmethodservice.InputMethodService._InputMethodService4102 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "<init>", "()V"); 
		} 
	} 
} 
