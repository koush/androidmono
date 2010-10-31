namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.accounts.AbstractAccountAuthenticator_))]
	public abstract partial class AbstractAccountAuthenticator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractAccountAuthenticator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.os.IBinder getIBinder()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.accounts.AbstractAccountAuthenticator.staticClass, "getIBinder", "()Landroid/os/IBinder;", ref global::android.accounts.AbstractAccountAuthenticator._m0) as android.os.IBinder;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::android.os.Bundle editProperties(android.accounts.AccountAuthenticatorResponse arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::android.os.Bundle addAccount(android.accounts.AccountAuthenticatorResponse arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String[] arg3, android.os.Bundle arg4);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::android.os.Bundle confirmCredentials(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, android.os.Bundle arg2);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::android.os.Bundle getAuthToken(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String arg2, android.os.Bundle arg3);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.lang.String getAuthTokenLabel(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::android.os.Bundle updateCredentials(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String arg2, android.os.Bundle arg3);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::android.os.Bundle hasFeatures(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String[] arg2);
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.os.Bundle getAccountRemovalAllowed(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.accounts.AbstractAccountAuthenticator.staticClass, "getAccountRemovalAllowed", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;)Landroid/os/Bundle;", ref global::android.accounts.AbstractAccountAuthenticator._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public AbstractAccountAuthenticator(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AbstractAccountAuthenticator._m9.native == global::System.IntPtr.Zero)
				global::android.accounts.AbstractAccountAuthenticator._m9 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AbstractAccountAuthenticator.staticClass, global::android.accounts.AbstractAccountAuthenticator._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AbstractAccountAuthenticator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AbstractAccountAuthenticator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AbstractAccountAuthenticator"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.accounts.AbstractAccountAuthenticator))]
	internal sealed partial class AbstractAccountAuthenticator_ : android.accounts.AbstractAccountAuthenticator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractAccountAuthenticator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::android.os.Bundle editProperties(android.accounts.AccountAuthenticatorResponse arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.accounts.AbstractAccountAuthenticator_.staticClass, "editProperties", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;)Landroid/os/Bundle;", ref global::android.accounts.AbstractAccountAuthenticator_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::android.os.Bundle addAccount(android.accounts.AccountAuthenticatorResponse arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String[] arg3, android.os.Bundle arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.accounts.AbstractAccountAuthenticator_.staticClass, "addAccount", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", ref global::android.accounts.AbstractAccountAuthenticator_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::android.os.Bundle confirmCredentials(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, android.os.Bundle arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.accounts.AbstractAccountAuthenticator_.staticClass, "confirmCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Landroid/os/Bundle;)Landroid/os/Bundle;", ref global::android.accounts.AbstractAccountAuthenticator_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::android.os.Bundle getAuthToken(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String arg2, android.os.Bundle arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.accounts.AbstractAccountAuthenticator_.staticClass, "getAuthToken", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", ref global::android.accounts.AbstractAccountAuthenticator_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.String getAuthTokenLabel(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.accounts.AbstractAccountAuthenticator_.staticClass, "getAuthTokenLabel", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.accounts.AbstractAccountAuthenticator_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::android.os.Bundle updateCredentials(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String arg2, android.os.Bundle arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.accounts.AbstractAccountAuthenticator_.staticClass, "updateCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", ref global::android.accounts.AbstractAccountAuthenticator_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::android.os.Bundle hasFeatures(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.accounts.AbstractAccountAuthenticator_.staticClass, "hasFeatures", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;[Ljava/lang/String;)Landroid/os/Bundle;", ref global::android.accounts.AbstractAccountAuthenticator_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.os.Bundle;
		}
		static AbstractAccountAuthenticator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AbstractAccountAuthenticator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AbstractAccountAuthenticator"));
		}
	}
}
