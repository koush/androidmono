namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccountAuthenticatorActivity : android.app.Activity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AccountAuthenticatorActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1288;
		protected override void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorActivity.staticClass, global::android.accounts.AccountAuthenticatorActivity._onCreate1288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.os.Bundle AccountAuthenticatorResult
		{
			set
			{
				setAccountAuthenticatorResult(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAccountAuthenticatorResult1289;
		public virtual void setAccountAuthenticatorResult(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorActivity.staticClass, global::android.accounts.AccountAuthenticatorActivity._setAccountAuthenticatorResult1289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finish1290;
		public override void finish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorActivity.staticClass, global::android.accounts.AccountAuthenticatorActivity._finish1290);
		}
		internal static global::MonoJavaBridge.MethodId _AccountAuthenticatorActivity1291;
		public AccountAuthenticatorActivity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountAuthenticatorActivity.staticClass, global::android.accounts.AccountAuthenticatorActivity._AccountAuthenticatorActivity1291);
			Init(@__env, handle);
		}
		static AccountAuthenticatorActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AccountAuthenticatorActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountAuthenticatorActivity"));
			global::android.accounts.AccountAuthenticatorActivity._onCreate1288 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.accounts.AccountAuthenticatorActivity._setAccountAuthenticatorResult1289 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorActivity.staticClass, "setAccountAuthenticatorResult", "(Landroid/os/Bundle;)V");
			global::android.accounts.AccountAuthenticatorActivity._finish1290 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorActivity.staticClass, "finish", "()V");
			global::android.accounts.AccountAuthenticatorActivity._AccountAuthenticatorActivity1291 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorActivity.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
