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
		internal static global::MonoJavaBridge.MethodId _cancel1353;
		bool android.accounts.AccountManagerFuture.cancel(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.accounts.AccountManagerFuture_.staticClass, "cancel", "(Z)Z", ref global::android.accounts.AccountManagerFuture_._cancel1353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCancelled1354;
		bool android.accounts.AccountManagerFuture.isCancelled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.accounts.AccountManagerFuture_.staticClass, "isCancelled", "()Z", ref global::android.accounts.AccountManagerFuture_._isCancelled1354);
		}
		internal static global::MonoJavaBridge.MethodId _isDone1355;
		bool android.accounts.AccountManagerFuture.isDone()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.accounts.AccountManagerFuture_.staticClass, "isDone", "()Z", ref global::android.accounts.AccountManagerFuture_._isDone1355);
		}
		internal static global::MonoJavaBridge.MethodId _getResult1356;
		global::java.lang.Object android.accounts.AccountManagerFuture.getResult()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.accounts.AccountManagerFuture_.staticClass, "getResult", "()Ljava/lang/Object;", ref global::android.accounts.AccountManagerFuture_._getResult1356) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getResult1357;
		global::java.lang.Object android.accounts.AccountManagerFuture.getResult(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.accounts.AccountManagerFuture_.staticClass, "getResult", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", ref global::android.accounts.AccountManagerFuture_._getResult1357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
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
