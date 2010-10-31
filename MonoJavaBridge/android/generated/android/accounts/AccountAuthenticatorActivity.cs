namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccountAuthenticatorActivity : android.app.Activity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AccountAuthenticatorActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V", ref global::android.accounts.AccountAuthenticatorActivity._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.os.Bundle AccountAuthenticatorResult
		{
			set
			{
				setAccountAuthenticatorResult(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setAccountAuthenticatorResult(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorActivity.staticClass, "setAccountAuthenticatorResult", "(Landroid/os/Bundle;)V", ref global::android.accounts.AccountAuthenticatorActivity._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void finish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorActivity.staticClass, "finish", "()V", ref global::android.accounts.AccountAuthenticatorActivity._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public AccountAuthenticatorActivity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AccountAuthenticatorActivity._m3.native == global::System.IntPtr.Zero)
				global::android.accounts.AccountAuthenticatorActivity._m3 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorActivity.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountAuthenticatorActivity.staticClass, global::android.accounts.AccountAuthenticatorActivity._m3);
			Init(@__env, handle);
		}
		static AccountAuthenticatorActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AccountAuthenticatorActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountAuthenticatorActivity"));
		}
	}
}
