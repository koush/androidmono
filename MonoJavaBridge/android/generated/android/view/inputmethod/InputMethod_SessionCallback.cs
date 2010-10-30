namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.inputmethod.InputMethod_SessionCallback_))]
	public partial interface InputMethod_SessionCallback  : global::MonoJavaBridge.IJavaObject 
	{
		void sessionCreated(android.view.inputmethod.InputMethodSession arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.inputmethod.InputMethod_SessionCallback))]
	internal sealed partial class InputMethod_SessionCallback_ : java.lang.Object, InputMethod_SessionCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal InputMethod_SessionCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _sessionCreated15912;
		void android.view.inputmethod.InputMethod_SessionCallback.sessionCreated(android.view.inputmethod.InputMethodSession arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethod_SessionCallback_.staticClass, "sessionCreated", "(Landroid/view/inputmethod/InputMethodSession;)V", ref global::android.view.inputmethod.InputMethod_SessionCallback_._sessionCreated15912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static InputMethod_SessionCallback_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethod_SessionCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethod$SessionCallback"));
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate void InputMethod_SessionCallbackDelegate(android.view.inputmethod.InputMethodSession arg0);

	internal partial class InputMethod_SessionCallbackDelegateWrapper : java.lang.Object, InputMethod_SessionCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InputMethod_SessionCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InputMethod_SessionCallbackDelegateWrapper15913;
		public InputMethod_SessionCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.InputMethod_SessionCallbackDelegateWrapper._InputMethod_SessionCallbackDelegateWrapper15913.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.InputMethod_SessionCallbackDelegateWrapper._InputMethod_SessionCallbackDelegateWrapper15913 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethod_SessionCallbackDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputMethod_SessionCallbackDelegateWrapper.staticClass, global::android.view.inputmethod.InputMethod_SessionCallbackDelegateWrapper._InputMethod_SessionCallbackDelegateWrapper15913);
			Init(@__env, handle);
		}
		static InputMethod_SessionCallbackDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethod_SessionCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethod_SessionCallbackDelegateWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class InputMethod_SessionCallbackDelegateWrapper
	{
		private InputMethod_SessionCallbackDelegate myDelegate;
		public void sessionCreated(android.view.inputmethod.InputMethodSession arg0)
		{
			myDelegate(arg0);
		}
		public static implicit operator InputMethod_SessionCallbackDelegateWrapper(InputMethod_SessionCallbackDelegate d)
		{
			global::android.view.inputmethod.InputMethod_SessionCallbackDelegateWrapper ret = new global::android.view.inputmethod.InputMethod_SessionCallbackDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
