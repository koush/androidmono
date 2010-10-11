namespace android.accounts
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.accounts.AccountManagerCallback_))]
	public interface AccountManagerCallback  : global::MonoJavaBridge.IJavaObject 
	{
		void run(android.accounts.AccountManagerFuture arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.accounts.AccountManagerCallback))]
	public sealed partial class AccountManagerCallback_ : java.lang.Object, AccountManagerCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccountManagerCallback_()
		{
			InitJNI();
		}
		internal AccountManagerCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run100;
		 void android.accounts.AccountManagerCallback.run(android.accounts.AccountManagerFuture arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountManagerCallback_._run100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountManagerCallback_.staticClass, global::android.accounts.AccountManagerCallback_._run100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AccountManagerCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountManagerCallback"));
			global::android.accounts.AccountManagerCallback_._run100 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManagerCallback_.staticClass, "run", "(Landroid/accounts/AccountManagerFuture;)V");
		}
	}
}
