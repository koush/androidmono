namespace android.accounts
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.accounts.OnAccountsUpdateListener_))]
	public interface OnAccountsUpdateListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onAccountsUpdated(android.accounts.Account[] arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.accounts.OnAccountsUpdateListener))]
	public sealed partial class OnAccountsUpdateListener_ : java.lang.Object, OnAccountsUpdateListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OnAccountsUpdateListener_()
		{
			InitJNI();
		}
		internal OnAccountsUpdateListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onAccountsUpdated132;
		 void android.accounts.OnAccountsUpdateListener.onAccountsUpdated(android.accounts.Account[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.OnAccountsUpdateListener_._onAccountsUpdated132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.OnAccountsUpdateListener_.staticClass, global::android.accounts.OnAccountsUpdateListener_._onAccountsUpdated132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.OnAccountsUpdateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/OnAccountsUpdateListener"));
			global::android.accounts.OnAccountsUpdateListener_._onAccountsUpdated132 = @__env.GetMethodIDNoThrow(global::android.accounts.OnAccountsUpdateListener_.staticClass, "onAccountsUpdated", "([Landroid/accounts/Account;)V");
		}
	}
}
