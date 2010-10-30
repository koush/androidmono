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
		internal static global::MonoJavaBridge.MethodId _binderDied9895;
		void android.os.IBinder_DeathRecipient.binderDied()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.os.IBinder_DeathRecipient_._binderDied9895);
		}
		static IBinder_DeathRecipient_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.IBinder_DeathRecipient_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/IBinder$DeathRecipient"));
			global::android.os.IBinder_DeathRecipient_._binderDied9895 = @__env.GetMethodIDNoThrow(global::android.os.IBinder_DeathRecipient_.staticClass, "binderDied", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate void IBinder_DeathRecipientDelegate();

	internal partial class IBinder_DeathRecipientDelegateWrapper : java.lang.Object, IBinder_DeathRecipient
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IBinder_DeathRecipientDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IBinder_DeathRecipientDelegateWrapper9896;
		public IBinder_DeathRecipientDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.IBinder_DeathRecipientDelegateWrapper.staticClass, global::android.os.IBinder_DeathRecipientDelegateWrapper._IBinder_DeathRecipientDelegateWrapper9896);
			Init(@__env, handle);
		}
		static IBinder_DeathRecipientDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.IBinder_DeathRecipientDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/IBinder_DeathRecipientDelegateWrapper"));
			global::android.os.IBinder_DeathRecipientDelegateWrapper._IBinder_DeathRecipientDelegateWrapper9896 = @__env.GetMethodIDNoThrow(global::android.os.IBinder_DeathRecipientDelegateWrapper.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
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
