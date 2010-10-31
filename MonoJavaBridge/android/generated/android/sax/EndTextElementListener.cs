namespace android.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.sax.EndTextElementListener_))]
	public partial interface EndTextElementListener  : global::MonoJavaBridge.IJavaObject 
	{
		void end(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.sax.EndTextElementListener))]
	internal sealed partial class EndTextElementListener_ : java.lang.Object, EndTextElementListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EndTextElementListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.sax.EndTextElementListener.end(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.EndTextElementListener_.staticClass, "end", "(Ljava/lang/String;)V", ref global::android.sax.EndTextElementListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static EndTextElementListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.EndTextElementListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/EndTextElementListener"));
		}
	}

	public delegate void EndTextElementListenerDelegate(java.lang.String arg0);

	internal partial class EndTextElementListenerDelegateWrapper : java.lang.Object, EndTextElementListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EndTextElementListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public EndTextElementListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.sax.EndTextElementListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
				global::android.sax.EndTextElementListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.sax.EndTextElementListenerDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.sax.EndTextElementListenerDelegateWrapper.staticClass, global::android.sax.EndTextElementListenerDelegateWrapper._m0);
			Init(@__env, handle);
		}
		static EndTextElementListenerDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.EndTextElementListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/EndTextElementListenerDelegateWrapper"));
		}
	}
	internal partial class EndTextElementListenerDelegateWrapper
	{
		private EndTextElementListenerDelegate myDelegate;
		public void end(java.lang.String arg0)
		{
			myDelegate(arg0);
		}
		public static implicit operator EndTextElementListenerDelegateWrapper(EndTextElementListenerDelegate d)
		{
			global::android.sax.EndTextElementListenerDelegateWrapper ret = new global::android.sax.EndTextElementListenerDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
