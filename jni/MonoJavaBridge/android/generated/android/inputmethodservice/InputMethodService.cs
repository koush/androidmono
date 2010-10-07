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
			internal static global::net.sf.jni4net.jni.MethodId _attachToken4242;
			public override void attachToken(android.os.IBinder arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl._attachToken4242, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._attachToken4242, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _bindInput4243;
			public override void bindInput(android.view.inputmethod.InputBinding arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl._bindInput4243, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._bindInput4243, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _unbindInput4244;
			public override void unbindInput() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl._unbindInput4244);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._unbindInput4244);
			}
			internal static global::net.sf.jni4net.jni.MethodId _startInput4245;
			public override void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl._startInput4245, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._startInput4245, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _restartInput4246;
			public override void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl._restartInput4246, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._restartInput4246, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _showSoftInput4247;
			public override void showSoftInput(int arg0, android.os.ResultReceiver arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl._showSoftInput4247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._showSoftInput4247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _hideSoftInput4248;
			public override void hideSoftInput(int arg0, android.os.ResultReceiver arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl._hideSoftInput4248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._hideSoftInput4248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _InputMethodImpl4249;
			public InputMethodImpl(android.inputmethodservice.InputMethodService arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodImpl._InputMethodImpl4249, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass = @__class;
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._attachToken4242 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "attachToken", "(Landroid/os/IBinder;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._bindInput4243 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._unbindInput4244 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "unbindInput", "()V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._startInput4245 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._restartInput4246 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._showSoftInput4247 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._hideSoftInput4248 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodImpl._InputMethodImpl4249 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodImpl.staticClass, "<init>", "(Landroid/inputmethodservice/InputMethodService;)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _finishInput4250;
			public override void finishInput() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._finishInput4250);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._finishInput4250);
			}
			internal static global::net.sf.jni4net.jni.MethodId _updateSelection4251;
			public override void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateSelection4251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateSelection4251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			}
			internal static global::net.sf.jni4net.jni.MethodId _updateCursor4252;
			public override void updateCursor(android.graphics.Rect arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateCursor4252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateCursor4252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _displayCompletions4253;
			public override void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._displayCompletions4253, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._displayCompletions4253, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _updateExtractedText4254;
			public override void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateExtractedText4254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateExtractedText4254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _appPrivateCommand4255;
			public override void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._appPrivateCommand4255, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._appPrivateCommand4255, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _toggleSoftInput4256;
			public override void toggleSoftInput(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._toggleSoftInput4256, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._toggleSoftInput4256, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _InputMethodSessionImpl4257;
			public InputMethodSessionImpl(android.inputmethodservice.InputMethodService arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._InputMethodSessionImpl4257, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass = @__class;
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._finishInput4250 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "finishInput", "()V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateSelection4251 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateSelection", "(IIIIII)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateCursor4252 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._displayCompletions4253 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._updateExtractedText4254 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._appPrivateCommand4255 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._toggleSoftInput4256 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "toggleSoftInput", "(II)V");
				global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl._InputMethodSessionImpl4257 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.InputMethodSessionImpl.staticClass, "<init>", "(Landroid/inputmethodservice/InputMethodService;)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _Insets4258;
			public Insets()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.inputmethodservice.InputMethodService.Insets.staticClass, global::android.inputmethodservice.InputMethodService.Insets._Insets4258, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _contentTopInsets4259;
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
			internal static global::net.sf.jni4net.jni.FieldId _visibleTopInsets4260;
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
			internal static global::net.sf.jni4net.jni.FieldId _touchableInsets4261;
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
				global::android.inputmethodservice.InputMethodService.Insets._Insets4258 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.Insets.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _switchInputMethod4262;
		public virtual void switchInputMethod(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._switchInputMethod4262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._switchInputMethod4262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreate4263;
		public override void onCreate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onCreate4263);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreate4263);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy4264;
		public override void onDestroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onDestroy4264);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onDestroy4264);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged4265;
		public override void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onConfigurationChanged4265, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onConfigurationChanged4265, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump4266;
		protected override void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._dump4266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._dump4266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTheme4267;
		public override void setTheme(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._setTheme4267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setTheme4267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWindow4268;
		public virtual global::android.app.Dialog getWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._getWindow4268));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getWindow4268));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown4269;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onKeyDown4269, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyDown4269, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyLongPress4270;
		public override bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onKeyLongPress4270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyLongPress4270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp4271;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onKeyUp4271, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyUp4271, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple4272;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onKeyMultiple4272, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onKeyMultiple4272, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent4273;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onTrackballEvent4273, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onTrackballEvent4273, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutInflater4274;
		public virtual global::android.view.LayoutInflater getLayoutInflater() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._getLayoutInflater4274));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getLayoutInflater4274));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputMethodInterface4275;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._onCreateInputMethodInterface4275));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateInputMethodInterface4275));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputMethodSessionInterface4276;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._onCreateInputMethodSessionInterface4276));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateInputMethodSessionInterface4276));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onInitializeInterface4277;
		public virtual void onInitializeInterface() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onInitializeInterface4277);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onInitializeInterface4277);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaxWidth4278;
		public virtual int getMaxWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.InputMethodService._getMaxWidth4278);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getMaxWidth4278);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentInputBinding4279;
		public virtual global::android.view.inputmethod.InputBinding getCurrentInputBinding() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.InputBinding>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._getCurrentInputBinding4279));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.InputBinding>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputBinding4279));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentInputConnection4280;
		public virtual global::android.view.inputmethod.InputConnection getCurrentInputConnection() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._getCurrentInputConnection4280));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputConnection4280));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentInputStarted4281;
		public virtual bool getCurrentInputStarted() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._getCurrentInputStarted4281);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputStarted4281);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentInputEditorInfo4282;
		public virtual global::android.view.inputmethod.EditorInfo getCurrentInputEditorInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.EditorInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._getCurrentInputEditorInfo4282));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.EditorInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCurrentInputEditorInfo4282));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateFullscreenMode4283;
		public virtual void updateFullscreenMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._updateFullscreenMode4283);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._updateFullscreenMode4283);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onConfigureWindow4284;
		public virtual void onConfigureWindow(android.view.Window arg0, bool arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onConfigureWindow4284, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onConfigureWindow4284, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFullscreenMode4285;
		public virtual bool isFullscreenMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._isFullscreenMode4285);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isFullscreenMode4285);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onEvaluateFullscreenMode4286;
		public virtual bool onEvaluateFullscreenMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onEvaluateFullscreenMode4286);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onEvaluateFullscreenMode4286);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setExtractViewShown4287;
		public virtual void setExtractViewShown(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._setExtractViewShown4287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setExtractViewShown4287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isExtractViewShown4288;
		public virtual bool isExtractViewShown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._isExtractViewShown4288);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isExtractViewShown4288);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onComputeInsets4289;
		public virtual void onComputeInsets(android.inputmethodservice.InputMethodService.Insets arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onComputeInsets4289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onComputeInsets4289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateInputViewShown4290;
		public virtual void updateInputViewShown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._updateInputViewShown4290);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._updateInputViewShown4290);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isShowInputRequested4291;
		public virtual bool isShowInputRequested() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._isShowInputRequested4291);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isShowInputRequested4291);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isInputViewShown4292;
		public virtual bool isInputViewShown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._isInputViewShown4292);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._isInputViewShown4292);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onEvaluateInputViewShown4293;
		public virtual bool onEvaluateInputViewShown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onEvaluateInputViewShown4293);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onEvaluateInputViewShown4293);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCandidatesViewShown4294;
		public virtual void setCandidatesViewShown(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._setCandidatesViewShown4294, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setCandidatesViewShown4294, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCandidatesHiddenVisibility4295;
		public virtual int getCandidatesHiddenVisibility() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.InputMethodService._getCandidatesHiddenVisibility4295);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getCandidatesHiddenVisibility4295);
		}
		internal static global::net.sf.jni4net.jni.MethodId _showStatusIcon4296;
		public virtual void showStatusIcon(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._showStatusIcon4296, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._showStatusIcon4296, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hideStatusIcon4297;
		public virtual void hideStatusIcon() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._hideStatusIcon4297);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._hideStatusIcon4297);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setExtractView4298;
		public virtual void setExtractView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._setExtractView4298, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setExtractView4298, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCandidatesView4299;
		public virtual void setCandidatesView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._setCandidatesView4299, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setCandidatesView4299, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInputView4300;
		public virtual void setInputView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._setInputView4300, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._setInputView4300, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateExtractTextView4301;
		public virtual global::android.view.View onCreateExtractTextView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._onCreateExtractTextView4301));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateExtractTextView4301));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateCandidatesView4302;
		public virtual global::android.view.View onCreateCandidatesView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._onCreateCandidatesView4302));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateCandidatesView4302));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputView4303;
		public virtual global::android.view.View onCreateInputView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._onCreateInputView4303));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onCreateInputView4303));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStartInputView4304;
		public virtual void onStartInputView(android.view.inputmethod.EditorInfo arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onStartInputView4304, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onStartInputView4304, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInputView4305;
		public virtual void onFinishInputView(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onFinishInputView4305, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onFinishInputView4305, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStartCandidatesView4306;
		public virtual void onStartCandidatesView(android.view.inputmethod.EditorInfo arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onStartCandidatesView4306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onStartCandidatesView4306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinishCandidatesView4307;
		public virtual void onFinishCandidatesView(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onFinishCandidatesView4307, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onFinishCandidatesView4307, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onShowInputRequested4308;
		public virtual bool onShowInputRequested(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onShowInputRequested4308, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onShowInputRequested4308, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showWindow4309;
		public virtual void showWindow(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._showWindow4309, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._showWindow4309, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hideWindow4310;
		public virtual void hideWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._hideWindow4310);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._hideWindow4310);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowShown4311;
		public virtual void onWindowShown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onWindowShown4311);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onWindowShown4311);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowHidden4312;
		public virtual void onWindowHidden() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onWindowHidden4312);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onWindowHidden4312);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBindInput4313;
		public virtual void onBindInput() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onBindInput4313);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onBindInput4313);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUnbindInput4314;
		public virtual void onUnbindInput() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onUnbindInput4314);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUnbindInput4314);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStartInput4315;
		public virtual void onStartInput(android.view.inputmethod.EditorInfo arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onStartInput4315, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onStartInput4315, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInput4316;
		public virtual void onFinishInput() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onFinishInput4316);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onFinishInput4316);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDisplayCompletions4317;
		public virtual void onDisplayCompletions(android.view.inputmethod.CompletionInfo[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onDisplayCompletions4317, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onDisplayCompletions4317, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateExtractedText4318;
		public virtual void onUpdateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onUpdateExtractedText4318, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateExtractedText4318, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateSelection4319;
		public virtual void onUpdateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onUpdateSelection4319, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateSelection4319, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateCursor4320;
		public virtual void onUpdateCursor(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onUpdateCursor4320, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateCursor4320, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestHideSelf4321;
		public virtual void requestHideSelf(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._requestHideSelf4321, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._requestHideSelf4321, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAppPrivateCommand4322;
		public virtual void onAppPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onAppPrivateCommand4322, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onAppPrivateCommand4322, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendDownUpKeyEvents4323;
		public virtual void sendDownUpKeyEvents(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._sendDownUpKeyEvents4323, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._sendDownUpKeyEvents4323, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendDefaultEditorAction4324;
		public virtual bool sendDefaultEditorAction(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._sendDefaultEditorAction4324, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._sendDefaultEditorAction4324, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendKeyChar4325;
		public virtual void sendKeyChar(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._sendKeyChar4325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._sendKeyChar4325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onExtractedSelectionChanged4326;
		public virtual void onExtractedSelectionChanged(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onExtractedSelectionChanged4326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractedSelectionChanged4326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onExtractedTextClicked4327;
		public virtual void onExtractedTextClicked() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onExtractedTextClicked4327);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractedTextClicked4327);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onExtractedCursorMovement4328;
		public virtual void onExtractedCursorMovement(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onExtractedCursorMovement4328, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractedCursorMovement4328, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onExtractTextContextMenuItem4329;
		public virtual bool onExtractTextContextMenuItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.InputMethodService._onExtractTextContextMenuItem4329, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractTextContextMenuItem4329, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextForImeAction4330;
		public virtual global::java.lang.CharSequence getTextForImeAction(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService._getTextForImeAction4330, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._getTextForImeAction4330, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateExtractingVisibility4331;
		public virtual void onUpdateExtractingVisibility(android.view.inputmethod.EditorInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onUpdateExtractingVisibility4331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateExtractingVisibility4331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateExtractingViews4332;
		public virtual void onUpdateExtractingViews(android.view.inputmethod.EditorInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onUpdateExtractingViews4332, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onUpdateExtractingViews4332, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onExtractingInputChanged4333;
		public virtual void onExtractingInputChanged(android.view.inputmethod.EditorInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.InputMethodService._onExtractingInputChanged4333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._onExtractingInputChanged4333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _InputMethodService4334;
		public InputMethodService()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.inputmethodservice.InputMethodService.staticClass, global::android.inputmethodservice.InputMethodService._InputMethodService4334, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.inputmethodservice.InputMethodService.staticClass = @__class;
			global::android.inputmethodservice.InputMethodService._switchInputMethod4262 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "switchInputMethod", "(Ljava/lang/String;)V");
			global::android.inputmethodservice.InputMethodService._onCreate4263 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreate", "()V");
			global::android.inputmethodservice.InputMethodService._onDestroy4264 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onDestroy", "()V");
			global::android.inputmethodservice.InputMethodService._onConfigurationChanged4265 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.inputmethodservice.InputMethodService._dump4266 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V");
			global::android.inputmethodservice.InputMethodService._setTheme4267 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setTheme", "(I)V");
			global::android.inputmethodservice.InputMethodService._getWindow4268 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getWindow", "()Landroid/app/Dialog;");
			global::android.inputmethodservice.InputMethodService._onKeyDown4269 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.InputMethodService._onKeyLongPress4270 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.InputMethodService._onKeyUp4271 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.InputMethodService._onKeyMultiple4272 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.inputmethodservice.InputMethodService._onTrackballEvent4273 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.inputmethodservice.InputMethodService._getLayoutInflater4274 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.inputmethodservice.InputMethodService._onCreateInputMethodInterface4275 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;");
			global::android.inputmethodservice.InputMethodService._onCreateInputMethodSessionInterface4276 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;");
			global::android.inputmethodservice.InputMethodService._onInitializeInterface4277 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onInitializeInterface", "()V");
			global::android.inputmethodservice.InputMethodService._getMaxWidth4278 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getMaxWidth", "()I");
			global::android.inputmethodservice.InputMethodService._getCurrentInputBinding4279 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputBinding", "()Landroid/view/inputmethod/InputBinding;");
			global::android.inputmethodservice.InputMethodService._getCurrentInputConnection4280 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputConnection", "()Landroid/view/inputmethod/InputConnection;");
			global::android.inputmethodservice.InputMethodService._getCurrentInputStarted4281 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputStarted", "()Z");
			global::android.inputmethodservice.InputMethodService._getCurrentInputEditorInfo4282 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getCurrentInputEditorInfo", "()Landroid/view/inputmethod/EditorInfo;");
			global::android.inputmethodservice.InputMethodService._updateFullscreenMode4283 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "updateFullscreenMode", "()V");
			global::android.inputmethodservice.InputMethodService._onConfigureWindow4284 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onConfigureWindow", "(Landroid/view/Window;ZZ)V");
			global::android.inputmethodservice.InputMethodService._isFullscreenMode4285 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "isFullscreenMode", "()Z");
			global::android.inputmethodservice.InputMethodService._onEvaluateFullscreenMode4286 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onEvaluateFullscreenMode", "()Z");
			global::android.inputmethodservice.InputMethodService._setExtractViewShown4287 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setExtractViewShown", "(Z)V");
			global::android.inputmethodservice.InputMethodService._isExtractViewShown4288 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "isExtractViewShown", "()Z");
			global::android.inputmethodservice.InputMethodService._onComputeInsets4289 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onComputeInsets", "(Landroid/inputmethodservice/InputMethodService$Insets;)V");
			global::android.inputmethodservice.InputMethodService._updateInputViewShown4290 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "updateInputViewShown", "()V");
			global::android.inputmethodservice.InputMethodService._isShowInputRequested4291 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "isShowInputRequested", "()Z");
			global::android.inputmethodservice.InputMethodService._isInputViewShown4292 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "isInputViewShown", "()Z");
			global::android.inputmethodservice.InputMethodService._onEvaluateInputViewShown4293 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onEvaluateInputViewShown", "()Z");
			global::android.inputmethodservice.InputMethodService._setCandidatesViewShown4294 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setCandidatesViewShown", "(Z)V");
			global::android.inputmethodservice.InputMethodService._getCandidatesHiddenVisibility4295 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getCandidatesHiddenVisibility", "()I");
			global::android.inputmethodservice.InputMethodService._showStatusIcon4296 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "showStatusIcon", "(I)V");
			global::android.inputmethodservice.InputMethodService._hideStatusIcon4297 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "hideStatusIcon", "()V");
			global::android.inputmethodservice.InputMethodService._setExtractView4298 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setExtractView", "(Landroid/view/View;)V");
			global::android.inputmethodservice.InputMethodService._setCandidatesView4299 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setCandidatesView", "(Landroid/view/View;)V");
			global::android.inputmethodservice.InputMethodService._setInputView4300 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "setInputView", "(Landroid/view/View;)V");
			global::android.inputmethodservice.InputMethodService._onCreateExtractTextView4301 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateExtractTextView", "()Landroid/view/View;");
			global::android.inputmethodservice.InputMethodService._onCreateCandidatesView4302 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateCandidatesView", "()Landroid/view/View;");
			global::android.inputmethodservice.InputMethodService._onCreateInputView4303 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onCreateInputView", "()Landroid/view/View;");
			global::android.inputmethodservice.InputMethodService._onStartInputView4304 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onStartInputView", "(Landroid/view/inputmethod/EditorInfo;Z)V");
			global::android.inputmethodservice.InputMethodService._onFinishInputView4305 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onFinishInputView", "(Z)V");
			global::android.inputmethodservice.InputMethodService._onStartCandidatesView4306 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onStartCandidatesView", "(Landroid/view/inputmethod/EditorInfo;Z)V");
			global::android.inputmethodservice.InputMethodService._onFinishCandidatesView4307 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onFinishCandidatesView", "(Z)V");
			global::android.inputmethodservice.InputMethodService._onShowInputRequested4308 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onShowInputRequested", "(IZ)Z");
			global::android.inputmethodservice.InputMethodService._showWindow4309 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "showWindow", "(Z)V");
			global::android.inputmethodservice.InputMethodService._hideWindow4310 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "hideWindow", "()V");
			global::android.inputmethodservice.InputMethodService._onWindowShown4311 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onWindowShown", "()V");
			global::android.inputmethodservice.InputMethodService._onWindowHidden4312 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onWindowHidden", "()V");
			global::android.inputmethodservice.InputMethodService._onBindInput4313 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onBindInput", "()V");
			global::android.inputmethodservice.InputMethodService._onUnbindInput4314 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUnbindInput", "()V");
			global::android.inputmethodservice.InputMethodService._onStartInput4315 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onStartInput", "(Landroid/view/inputmethod/EditorInfo;Z)V");
			global::android.inputmethodservice.InputMethodService._onFinishInput4316 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onFinishInput", "()V");
			global::android.inputmethodservice.InputMethodService._onDisplayCompletions4317 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onDisplayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.inputmethodservice.InputMethodService._onUpdateExtractedText4318 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V");
			global::android.inputmethodservice.InputMethodService._onUpdateSelection4319 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateSelection", "(IIIIII)V");
			global::android.inputmethodservice.InputMethodService._onUpdateCursor4320 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateCursor", "(Landroid/graphics/Rect;)V");
			global::android.inputmethodservice.InputMethodService._requestHideSelf4321 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "requestHideSelf", "(I)V");
			global::android.inputmethodservice.InputMethodService._onAppPrivateCommand4322 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onAppPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.inputmethodservice.InputMethodService._sendDownUpKeyEvents4323 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "sendDownUpKeyEvents", "(I)V");
			global::android.inputmethodservice.InputMethodService._sendDefaultEditorAction4324 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "sendDefaultEditorAction", "(Z)Z");
			global::android.inputmethodservice.InputMethodService._sendKeyChar4325 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "sendKeyChar", "(C)V");
			global::android.inputmethodservice.InputMethodService._onExtractedSelectionChanged4326 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedSelectionChanged", "(II)V");
			global::android.inputmethodservice.InputMethodService._onExtractedTextClicked4327 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedTextClicked", "()V");
			global::android.inputmethodservice.InputMethodService._onExtractedCursorMovement4328 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractedCursorMovement", "(II)V");
			global::android.inputmethodservice.InputMethodService._onExtractTextContextMenuItem4329 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractTextContextMenuItem", "(I)Z");
			global::android.inputmethodservice.InputMethodService._getTextForImeAction4330 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "getTextForImeAction", "(I)Ljava/lang/CharSequence;");
			global::android.inputmethodservice.InputMethodService._onUpdateExtractingVisibility4331 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractingVisibility", "(Landroid/view/inputmethod/EditorInfo;)V");
			global::android.inputmethodservice.InputMethodService._onUpdateExtractingViews4332 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onUpdateExtractingViews", "(Landroid/view/inputmethod/EditorInfo;)V");
			global::android.inputmethodservice.InputMethodService._onExtractingInputChanged4333 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "onExtractingInputChanged", "(Landroid/view/inputmethod/EditorInfo;)V");
			global::android.inputmethodservice.InputMethodService._InputMethodService4334 = @__env.GetMethodID(global::android.inputmethodservice.InputMethodService.staticClass, "<init>", "()V");
		}
	}
}
