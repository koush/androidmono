namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccountsException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccountsException()
		{
			InitJNI();
		}
		protected AccountsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AccountsException1358;
		public AccountsException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountsException.staticClass, global::android.accounts.AccountsException._AccountsException1358);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AccountsException1359;
		public AccountsException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountsException.staticClass, global::android.accounts.AccountsException._AccountsException1359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AccountsException1360;
		public AccountsException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountsException.staticClass, global::android.accounts.AccountsException._AccountsException1360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AccountsException1361;
		public AccountsException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountsException.staticClass, global::android.accounts.AccountsException._AccountsException1361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AccountsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountsException"));
			global::android.accounts.AccountsException._AccountsException1358 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountsException.staticClass, "<init>", "()V");
			global::android.accounts.AccountsException._AccountsException1359 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountsException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.accounts.AccountsException._AccountsException1360 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountsException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::android.accounts.AccountsException._AccountsException1361 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountsException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
