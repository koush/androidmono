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
		static AccountManagerCallback_()
		{
			InitJNI();
		}
		internal AccountManagerCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run1351;
		 void android.accounts.AccountManagerCallback.run(android.accounts.AccountManagerFuture arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountManagerCallback_._run1351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountManagerCallback_.staticClass, global::android.accounts.AccountManagerCallback_._run1351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AccountManagerCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountManagerCallback"));
			global::android.accounts.AccountManagerCallback_._run1351 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManagerCallback_.staticClass, "run", "(Landroid/accounts/AccountManagerFuture;)V");
		}
	}

	public delegate void AccountManagerCallbackDelegate(android.accounts.AccountManagerFuture arg0);

	internal partial class AccountManagerCallbackDelegateWrapper : java.lang.Object, AccountManagerCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccountManagerCallbackDelegateWrapper()
		{
			InitJNI();
		}
		protected AccountManagerCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AccountManagerCallbackDelegateWrapper1352;
		public AccountManagerCallbackDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountManagerCallbackDelegateWrapper.staticClass, global::android.accounts.AccountManagerCallbackDelegateWrapper._AccountManagerCallbackDelegateWrapper1352);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AccountManagerCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountManagerCallbackDelegateWrapper"));
			global::android.accounts.AccountManagerCallbackDelegateWrapper._AccountManagerCallbackDelegateWrapper1352 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManagerCallbackDelegateWrapper.staticClass, "<init>", "()V");
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
