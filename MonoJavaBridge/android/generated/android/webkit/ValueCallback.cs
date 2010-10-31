namespace android.webkit
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.ValueCallback_))]
	public partial interface ValueCallback  : global::MonoJavaBridge.IJavaObject 
	{
		void onReceiveValue(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.ValueCallback))]
	internal sealed partial class ValueCallback_ : java.lang.Object, ValueCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ValueCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.webkit.ValueCallback.onReceiveValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.ValueCallback_.staticClass, "onReceiveValue", "(Ljava/lang/Object;)V", ref global::android.webkit.ValueCallback_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ValueCallback_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.ValueCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/ValueCallback"));
		}
	}

	public delegate void ValueCallbackDelegate(java.lang.Object arg0);

	internal partial class ValueCallbackDelegateWrapper : java.lang.Object, ValueCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ValueCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ValueCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.ValueCallbackDelegateWrapper._m0.native == global::System.IntPtr.Zero)
				global::android.webkit.ValueCallbackDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.webkit.ValueCallbackDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.ValueCallbackDelegateWrapper.staticClass, global::android.webkit.ValueCallbackDelegateWrapper._m0);
			Init(@__env, handle);
		}
		static ValueCallbackDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.ValueCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/ValueCallbackDelegateWrapper"));
		}
	}
	internal partial class ValueCallbackDelegateWrapper
	{
		private ValueCallbackDelegate myDelegate;
		public void onReceiveValue(java.lang.Object arg0)
		{
			myDelegate(arg0);
		}
		public static implicit operator ValueCallbackDelegateWrapper(ValueCallbackDelegate d)
		{
			global::android.webkit.ValueCallbackDelegateWrapper ret = new global::android.webkit.ValueCallbackDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
