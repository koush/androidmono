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
		static OnAccountsUpdateListener_()
		{
			InitJNI();
		}
		internal OnAccountsUpdateListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onAccountsUpdated1384;
		void android.accounts.OnAccountsUpdateListener.onAccountsUpdated(android.accounts.Account[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.OnAccountsUpdateListener_._onAccountsUpdated1384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.OnAccountsUpdateListener_.staticClass, global::android.accounts.OnAccountsUpdateListener_._onAccountsUpdated1384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.OnAccountsUpdateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/OnAccountsUpdateListener"));
			global::android.accounts.OnAccountsUpdateListener_._onAccountsUpdated1384 = @__env.GetMethodIDNoThrow(global::android.accounts.OnAccountsUpdateListener_.staticClass, "onAccountsUpdated", "([Landroid/accounts/Account;)V");
		}
	}

	public delegate void OnAccountsUpdateListenerDelegate(android.accounts.Account[] arg0);

	internal partial class OnAccountsUpdateListenerDelegateWrapper : java.lang.Object, OnAccountsUpdateListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OnAccountsUpdateListenerDelegateWrapper()
		{
			InitJNI();
		}
		protected OnAccountsUpdateListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _OnAccountsUpdateListenerDelegateWrapper1385;
		public OnAccountsUpdateListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.OnAccountsUpdateListenerDelegateWrapper.staticClass, global::android.accounts.OnAccountsUpdateListenerDelegateWrapper._OnAccountsUpdateListenerDelegateWrapper1385);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.OnAccountsUpdateListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/OnAccountsUpdateListenerDelegateWrapper"));
			global::android.accounts.OnAccountsUpdateListenerDelegateWrapper._OnAccountsUpdateListenerDelegateWrapper1385 = @__env.GetMethodIDNoThrow(global::android.accounts.OnAccountsUpdateListenerDelegateWrapper.staticClass, "<init>", "()V");
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
