namespace android.accounts
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.accounts.AccountManagerFuture_))]
	public partial interface AccountManagerFuture  : global::MonoJavaBridge.IJavaObject 
	{
		bool cancel(bool arg0);
		bool isCancelled();
		bool isDone();
		global::java.lang.Object getResult();
		global::java.lang.Object getResult(long arg0, java.util.concurrent.TimeUnit arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.accounts.AccountManagerFuture))]
	internal sealed partial class AccountManagerFuture_ : java.lang.Object, AccountManagerFuture
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AccountManagerFuture_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool android.accounts.AccountManagerFuture.cancel(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.accounts.AccountManagerFuture_.staticClass, "cancel", "(Z)Z", ref global::android.accounts.AccountManagerFuture_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool android.accounts.AccountManagerFuture.isCancelled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.accounts.AccountManagerFuture_.staticClass, "isCancelled", "()Z", ref global::android.accounts.AccountManagerFuture_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool android.accounts.AccountManagerFuture.isDone()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.accounts.AccountManagerFuture_.staticClass, "isDone", "()Z", ref global::android.accounts.AccountManagerFuture_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.Object android.accounts.AccountManagerFuture.getResult()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.accounts.AccountManagerFuture_.staticClass, "getResult", "()Ljava/lang/Object;", ref global::android.accounts.AccountManagerFuture_._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.Object android.accounts.AccountManagerFuture.getResult(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.accounts.AccountManagerFuture_.staticClass, "getResult", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", ref global::android.accounts.AccountManagerFuture_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		static AccountManagerFuture_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AccountManagerFuture_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountManagerFuture"));
		}
		internal static void InitJNI()
		{
		}
	}
}
