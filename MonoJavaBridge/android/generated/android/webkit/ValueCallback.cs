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
		internal static global::MonoJavaBridge.MethodId _onReceiveValue16121;
		void android.webkit.ValueCallback.onReceiveValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.ValueCallback_._onReceiveValue16121.native == global::System.IntPtr.Zero)
				global::android.webkit.ValueCallback_._onReceiveValue16121 = @__env.GetMethodIDNoThrow(global::android.webkit.ValueCallback_.staticClass, "onReceiveValue", "(Ljava/lang/Object;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.ValueCallback_._onReceiveValue16121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ValueCallback_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.ValueCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/ValueCallback"));
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate void ValueCallbackDelegate(java.lang.Object arg0);

	internal partial class ValueCallbackDelegateWrapper : java.lang.Object, ValueCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ValueCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ValueCallbackDelegateWrapper16122;
		public ValueCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.ValueCallbackDelegateWrapper._ValueCallbackDelegateWrapper16122.native == global::System.IntPtr.Zero)
				global::android.webkit.ValueCallbackDelegateWrapper._ValueCallbackDelegateWrapper16122 = @__env.GetMethodIDNoThrow(global::android.webkit.ValueCallbackDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.ValueCallbackDelegateWrapper.staticClass, global::android.webkit.ValueCallbackDelegateWrapper._ValueCallbackDelegateWrapper16122);
			Init(@__env, handle);
		}
		static ValueCallbackDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.ValueCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/ValueCallbackDelegateWrapper"));
		}
		internal static void InitJNI()
		{
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
