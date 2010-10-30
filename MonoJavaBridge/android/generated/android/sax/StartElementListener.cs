namespace android.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.sax.StartElementListener_))]
	public partial interface StartElementListener  : global::MonoJavaBridge.IJavaObject 
	{
		void start(org.xml.sax.Attributes arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.sax.StartElementListener))]
	internal sealed partial class StartElementListener_ : java.lang.Object, StartElementListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal StartElementListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.sax.StartElementListener.start(org.xml.sax.Attributes arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.StartElementListener_.staticClass, "start", "(Lorg/xml/sax/Attributes;)V", ref global::android.sax.StartElementListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static StartElementListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.StartElementListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/StartElementListener"));
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate void StartElementListenerDelegate(org.xml.sax.Attributes arg0);

	internal partial class StartElementListenerDelegateWrapper : java.lang.Object, StartElementListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StartElementListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public StartElementListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.sax.StartElementListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
				global::android.sax.StartElementListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.sax.StartElementListenerDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.sax.StartElementListenerDelegateWrapper.staticClass, global::android.sax.StartElementListenerDelegateWrapper._m0);
			Init(@__env, handle);
		}
		static StartElementListenerDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.StartElementListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/StartElementListenerDelegateWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class StartElementListenerDelegateWrapper
	{
		private StartElementListenerDelegate myDelegate;
		public void start(org.xml.sax.Attributes arg0)
		{
			myDelegate(arg0);
		}
		public static implicit operator StartElementListenerDelegateWrapper(StartElementListenerDelegate d)
		{
			global::android.sax.StartElementListenerDelegateWrapper ret = new global::android.sax.StartElementListenerDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
