namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.accounts.AbstractAccountAuthenticator_))]
	public abstract partial class AbstractAccountAuthenticator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractAccountAuthenticator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getIBinder1261;
		public virtual global::android.os.IBinder getIBinder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AbstractAccountAuthenticator._getIBinder1261.native == global::System.IntPtr.Zero)
				global::android.accounts.AbstractAccountAuthenticator._getIBinder1261 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator.staticClass, "getIBinder", "()Landroid/os/IBinder;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.accounts.AbstractAccountAuthenticator.staticClass, global::android.accounts.AbstractAccountAuthenticator._getIBinder1261) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _editProperties1262;
		public abstract global::android.os.Bundle editProperties(android.accounts.AccountAuthenticatorResponse arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _addAccount1263;
		public abstract global::android.os.Bundle addAccount(android.accounts.AccountAuthenticatorResponse arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String[] arg3, android.os.Bundle arg4);
		internal static global::MonoJavaBridge.MethodId _confirmCredentials1264;
		public abstract global::android.os.Bundle confirmCredentials(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, android.os.Bundle arg2);
		internal static global::MonoJavaBridge.MethodId _getAuthToken1265;
		public abstract global::android.os.Bundle getAuthToken(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String arg2, android.os.Bundle arg3);
		internal static global::MonoJavaBridge.MethodId _getAuthTokenLabel1266;
		public abstract global::java.lang.String getAuthTokenLabel(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _updateCredentials1267;
		public abstract global::android.os.Bundle updateCredentials(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String arg2, android.os.Bundle arg3);
		internal static global::MonoJavaBridge.MethodId _hasFeatures1268;
		public abstract global::android.os.Bundle hasFeatures(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String[] arg2);
		internal static global::MonoJavaBridge.MethodId _getAccountRemovalAllowed1269;
		public virtual global::android.os.Bundle getAccountRemovalAllowed(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AbstractAccountAuthenticator._getAccountRemovalAllowed1269.native == global::System.IntPtr.Zero)
				global::android.accounts.AbstractAccountAuthenticator._getAccountRemovalAllowed1269 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator.staticClass, "getAccountRemovalAllowed", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;)Landroid/os/Bundle;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.accounts.AbstractAccountAuthenticator.staticClass, global::android.accounts.AbstractAccountAuthenticator._getAccountRemovalAllowed1269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractAccountAuthenticator1270;
		public AbstractAccountAuthenticator(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AbstractAccountAuthenticator._AbstractAccountAuthenticator1270.native == global::System.IntPtr.Zero)
				global::android.accounts.AbstractAccountAuthenticator._AbstractAccountAuthenticator1270 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AbstractAccountAuthenticator.staticClass, global::android.accounts.AbstractAccountAuthenticator._AbstractAccountAuthenticator1270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AbstractAccountAuthenticator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AbstractAccountAuthenticator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AbstractAccountAuthenticator"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.accounts.AbstractAccountAuthenticator))]
	internal sealed partial class AbstractAccountAuthenticator_ : android.accounts.AbstractAccountAuthenticator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractAccountAuthenticator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _editProperties1271;
		public override global::android.os.Bundle editProperties(android.accounts.AccountAuthenticatorResponse arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AbstractAccountAuthenticator_._editProperties1271.native == global::System.IntPtr.Zero)
				global::android.accounts.AbstractAccountAuthenticator_._editProperties1271 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator_.staticClass, "editProperties", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;)Landroid/os/Bundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_._editProperties1271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _addAccount1272;
		public override global::android.os.Bundle addAccount(android.accounts.AccountAuthenticatorResponse arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String[] arg3, android.os.Bundle arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AbstractAccountAuthenticator_._addAccount1272.native == global::System.IntPtr.Zero)
				global::android.accounts.AbstractAccountAuthenticator_._addAccount1272 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator_.staticClass, "addAccount", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_._addAccount1272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _confirmCredentials1273;
		public override global::android.os.Bundle confirmCredentials(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AbstractAccountAuthenticator_._confirmCredentials1273.native == global::System.IntPtr.Zero)
				global::android.accounts.AbstractAccountAuthenticator_._confirmCredentials1273 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator_.staticClass, "confirmCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Landroid/os/Bundle;)Landroid/os/Bundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_._confirmCredentials1273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthToken1274;
		public override global::android.os.Bundle getAuthToken(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String arg2, android.os.Bundle arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AbstractAccountAuthenticator_._getAuthToken1274.native == global::System.IntPtr.Zero)
				global::android.accounts.AbstractAccountAuthenticator_._getAuthToken1274 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator_.staticClass, "getAuthToken", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_._getAuthToken1274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthTokenLabel1275;
		public override global::java.lang.String getAuthTokenLabel(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AbstractAccountAuthenticator_._getAuthTokenLabel1275.native == global::System.IntPtr.Zero)
				global::android.accounts.AbstractAccountAuthenticator_._getAuthTokenLabel1275 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator_.staticClass, "getAuthTokenLabel", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_._getAuthTokenLabel1275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _updateCredentials1276;
		public override global::android.os.Bundle updateCredentials(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String arg2, android.os.Bundle arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AbstractAccountAuthenticator_._updateCredentials1276.native == global::System.IntPtr.Zero)
				global::android.accounts.AbstractAccountAuthenticator_._updateCredentials1276 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator_.staticClass, "updateCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_._updateCredentials1276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _hasFeatures1277;
		public override global::android.os.Bundle hasFeatures(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AbstractAccountAuthenticator_._hasFeatures1277.native == global::System.IntPtr.Zero)
				global::android.accounts.AbstractAccountAuthenticator_._hasFeatures1277 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator_.staticClass, "hasFeatures", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;[Ljava/lang/String;)Landroid/os/Bundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_._hasFeatures1277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.os.Bundle;
		}
		static AbstractAccountAuthenticator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AbstractAccountAuthenticator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AbstractAccountAuthenticator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
