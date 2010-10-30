namespace android.accounts
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.accounts.OnAccountsUpdateListener_))]
	public partial interface OnAccountsUpdateListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onAccountsUpdated(android.accounts.Account[] arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.accounts.OnAccountsUpdateListener))]
	internal sealed partial class OnAccountsUpdateListener_ : java.lang.Object, OnAccountsUpdateListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal OnAccountsUpdateListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.accounts.OnAccountsUpdateListener.onAccountsUpdated(android.accounts.Account[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.OnAccountsUpdateListener_.staticClass, "onAccountsUpdated", "([Landroid/accounts/Account;)V", ref global::android.accounts.OnAccountsUpdateListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static OnAccountsUpdateListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.OnAccountsUpdateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/OnAccountsUpdateListener"));
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate void OnAccountsUpdateListenerDelegate(android.accounts.Account[] arg0);

	internal partial class OnAccountsUpdateListenerDelegateWrapper : java.lang.Object, OnAccountsUpdateListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OnAccountsUpdateListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public OnAccountsUpdateListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.OnAccountsUpdateListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
				global::android.accounts.OnAccountsUpdateListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.accounts.OnAccountsUpdateListenerDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.OnAccountsUpdateListenerDelegateWrapper.staticClass, global::android.accounts.OnAccountsUpdateListenerDelegateWrapper._m0);
			Init(@__env, handle);
		}
		static OnAccountsUpdateListenerDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.OnAccountsUpdateListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/OnAccountsUpdateListenerDelegateWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class OnAccountsUpdateListenerDelegateWrapper
	{
		private OnAccountsUpdateListenerDelegate myDelegate;
		public void onAccountsUpdated(android.accounts.Account[] arg0)
		{
			myDelegate(arg0);
		}
		public static implicit operator OnAccountsUpdateListenerDelegateWrapper(OnAccountsUpdateListenerDelegate d)
		{
			global::android.accounts.OnAccountsUpdateListenerDelegateWrapper ret = new global::android.accounts.OnAccountsUpdateListenerDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
