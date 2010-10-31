namespace android.os
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.IBinder_DeathRecipient_))]
	public partial interface IBinder_DeathRecipient  : global::MonoJavaBridge.IJavaObject 
	{
		void binderDied();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.IBinder_DeathRecipient))]
	internal sealed partial class IBinder_DeathRecipient_ : java.lang.Object, IBinder_DeathRecipient
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal IBinder_DeathRecipient_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.os.IBinder_DeathRecipient.binderDied()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.IBinder_DeathRecipient_.staticClass, "binderDied", "()V", ref global::android.os.IBinder_DeathRecipient_._m0);
		}
		static IBinder_DeathRecipient_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.IBinder_DeathRecipient_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/IBinder$DeathRecipient"));
		}
	}

	public delegate void IBinder_DeathRecipientDelegate();

	internal partial class IBinder_DeathRecipientDelegateWrapper : java.lang.Object, IBinder_DeathRecipient
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IBinder_DeathRecipientDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public IBinder_DeathRecipientDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.IBinder_DeathRecipientDelegateWrapper._m0.native == global::System.IntPtr.Zero)
				global::android.os.IBinder_DeathRecipientDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.os.IBinder_DeathRecipientDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.IBinder_DeathRecipientDelegateWrapper.staticClass, global::android.os.IBinder_DeathRecipientDelegateWrapper._m0);
			Init(@__env, handle);
		}
		static IBinder_DeathRecipientDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.IBinder_DeathRecipientDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/IBinder_DeathRecipientDelegateWrapper"));
		}
	}
	internal partial class IBinder_DeathRecipientDelegateWrapper
	{
		private IBinder_DeathRecipientDelegate myDelegate;
		public void binderDied()
		{
			myDelegate();
		}
		public static implicit operator IBinder_DeathRecipientDelegateWrapper(IBinder_DeathRecipientDelegate d)
		{
			global::android.os.IBinder_DeathRecipientDelegateWrapper ret = new global::android.os.IBinder_DeathRecipientDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
