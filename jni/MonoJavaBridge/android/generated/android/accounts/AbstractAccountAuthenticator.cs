namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.accounts.AbstractAccountAuthenticator_))]
	public abstract partial class AbstractAccountAuthenticator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractAccountAuthenticator()
		{
			InitJNI();
		}
		protected AbstractAccountAuthenticator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getIBinder36;
		public virtual global::android.os.IBinder getIBinder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator._getIBinder36)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator.staticClass, global::android.accounts.AbstractAccountAuthenticator._getIBinder36)) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _editProperties37;
		public abstract global::android.os.Bundle editProperties(android.accounts.AccountAuthenticatorResponse arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _addAccount38;
		public abstract global::android.os.Bundle addAccount(android.accounts.AccountAuthenticatorResponse arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String[] arg3, android.os.Bundle arg4);
		internal static global::MonoJavaBridge.MethodId _confirmCredentials39;
		public abstract global::android.os.Bundle confirmCredentials(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, android.os.Bundle arg2);
		internal static global::MonoJavaBridge.MethodId _getAuthToken40;
		public abstract global::android.os.Bundle getAuthToken(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String arg2, android.os.Bundle arg3);
		internal static global::MonoJavaBridge.MethodId _getAuthTokenLabel41;
		public abstract global::java.lang.String getAuthTokenLabel(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _updateCredentials42;
		public abstract global::android.os.Bundle updateCredentials(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String arg2, android.os.Bundle arg3);
		internal static global::MonoJavaBridge.MethodId _hasFeatures43;
		public abstract global::android.os.Bundle hasFeatures(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String[] arg2);
		internal static global::MonoJavaBridge.MethodId _getAccountRemovalAllowed44;
		public virtual global::android.os.Bundle getAccountRemovalAllowed(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator._getAccountRemovalAllowed44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator.staticClass, global::android.accounts.AbstractAccountAuthenticator._getAccountRemovalAllowed44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractAccountAuthenticator45;
		public AbstractAccountAuthenticator(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AbstractAccountAuthenticator.staticClass, global::android.accounts.AbstractAccountAuthenticator._AbstractAccountAuthenticator45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AbstractAccountAuthenticator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AbstractAccountAuthenticator"));
			global::android.accounts.AbstractAccountAuthenticator._getIBinder36 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator.staticClass, "getIBinder", "()Landroid/os/IBinder;");
			global::android.accounts.AbstractAccountAuthenticator._editProperties37 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator.staticClass, "editProperties", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;)Landroid/os/Bundle;");
			global::android.accounts.AbstractAccountAuthenticator._addAccount38 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator.staticClass, "addAccount", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.accounts.AbstractAccountAuthenticator._confirmCredentials39 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator.staticClass, "confirmCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.accounts.AbstractAccountAuthenticator._getAuthToken40 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator.staticClass, "getAuthToken", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.accounts.AbstractAccountAuthenticator._getAuthTokenLabel41 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator.staticClass, "getAuthTokenLabel", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.accounts.AbstractAccountAuthenticator._updateCredentials42 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator.staticClass, "updateCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.accounts.AbstractAccountAuthenticator._hasFeatures43 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator.staticClass, "hasFeatures", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;[Ljava/lang/String;)Landroid/os/Bundle;");
			global::android.accounts.AbstractAccountAuthenticator._getAccountRemovalAllowed44 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator.staticClass, "getAccountRemovalAllowed", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;)Landroid/os/Bundle;");
			global::android.accounts.AbstractAccountAuthenticator._AbstractAccountAuthenticator45 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.accounts.AbstractAccountAuthenticator))]
	public sealed partial class AbstractAccountAuthenticator_ : android.accounts.AbstractAccountAuthenticator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractAccountAuthenticator_()
		{
			InitJNI();
		}
		internal AbstractAccountAuthenticator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _editProperties46;
		public override global::android.os.Bundle editProperties(android.accounts.AccountAuthenticatorResponse arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_._editProperties46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_.staticClass, global::android.accounts.AbstractAccountAuthenticator_._editProperties46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _addAccount47;
		public override global::android.os.Bundle addAccount(android.accounts.AccountAuthenticatorResponse arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String[] arg3, android.os.Bundle arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_._addAccount47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_.staticClass, global::android.accounts.AbstractAccountAuthenticator_._addAccount47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _confirmCredentials48;
		public override global::android.os.Bundle confirmCredentials(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_._confirmCredentials48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_.staticClass, global::android.accounts.AbstractAccountAuthenticator_._confirmCredentials48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthToken49;
		public override global::android.os.Bundle getAuthToken(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String arg2, android.os.Bundle arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_._getAuthToken49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_.staticClass, global::android.accounts.AbstractAccountAuthenticator_._getAuthToken49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthTokenLabel50;
		public override global::java.lang.String getAuthTokenLabel(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_._getAuthTokenLabel50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_.staticClass, global::android.accounts.AbstractAccountAuthenticator_._getAuthTokenLabel50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _updateCredentials51;
		public override global::android.os.Bundle updateCredentials(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String arg2, android.os.Bundle arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_._updateCredentials51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_.staticClass, global::android.accounts.AbstractAccountAuthenticator_._updateCredentials51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _hasFeatures52;
		public override global::android.os.Bundle hasFeatures(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_._hasFeatures52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AbstractAccountAuthenticator_.staticClass, global::android.accounts.AbstractAccountAuthenticator_._hasFeatures52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.os.Bundle;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AbstractAccountAuthenticator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AbstractAccountAuthenticator"));
			global::android.accounts.AbstractAccountAuthenticator_._editProperties46 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator_.staticClass, "editProperties", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;)Landroid/os/Bundle;");
			global::android.accounts.AbstractAccountAuthenticator_._addAccount47 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator_.staticClass, "addAccount", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.accounts.AbstractAccountAuthenticator_._confirmCredentials48 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator_.staticClass, "confirmCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.accounts.AbstractAccountAuthenticator_._getAuthToken49 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator_.staticClass, "getAuthToken", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.accounts.AbstractAccountAuthenticator_._getAuthTokenLabel50 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator_.staticClass, "getAuthTokenLabel", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.accounts.AbstractAccountAuthenticator_._updateCredentials51 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator_.staticClass, "updateCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.accounts.AbstractAccountAuthenticator_._hasFeatures52 = @__env.GetMethodIDNoThrow(global::android.accounts.AbstractAccountAuthenticator_.staticClass, "hasFeatures", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;[Ljava/lang/String;)Landroid/os/Bundle;");
		}
	}
}
