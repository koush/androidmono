namespace android.accounts
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.accounts.AccountManagerCallback_))]
	public partial interface AccountManagerCallback  : global::MonoJavaBridge.IJavaObject 
	{
		void run(android.accounts.AccountManagerFuture arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.accounts.AccountManagerCallback))]
	internal sealed partial class AccountManagerCallback_ : java.lang.Object, AccountManagerCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AccountManagerCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.accounts.AccountManagerCallback.run(android.accounts.AccountManagerFuture arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountManagerCallback_.staticClass, "run", "(Landroid/accounts/AccountManagerFuture;)V", ref global::android.accounts.AccountManagerCallback_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AccountManagerCallback_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AccountManagerCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountManagerCallback"));
		}
	}

	public delegate void AccountManagerCallbackDelegate(android.accounts.AccountManagerFuture arg0);

	internal partial class AccountManagerCallbackDelegateWrapper : java.lang.Object, AccountManagerCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AccountManagerCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public AccountManagerCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AccountManagerCallbackDelegateWrapper._m0.native == global::System.IntPtr.Zero)
				global::android.accounts.AccountManagerCallbackDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManagerCallbackDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountManagerCallbackDelegateWrapper.staticClass, global::android.accounts.AccountManagerCallbackDelegateWrapper._m0);
			Init(@__env, handle);
		}
		static AccountManagerCallbackDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AccountManagerCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountManagerCallbackDelegateWrapper"));
		}
	}
	internal partial class AccountManagerCallbackDelegateWrapper
	{
		private AccountManagerCallbackDelegate myDelegate;
		public void run(android.accounts.AccountManagerFuture arg0)
		{
			myDelegate(arg0);
		}
		public static implicit operator AccountManagerCallbackDelegateWrapper(AccountManagerCallbackDelegate d)
		{
			global::android.accounts.AccountManagerCallbackDelegateWrapper ret = new global::android.accounts.AccountManagerCallbackDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
