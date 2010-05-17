namespace android.accounts 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractAccountAuthenticator : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AbstractAccountAuthenticator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.accounts.AbstractAccountAuthenticator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractAccountAuthenticator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIBinder34; 
		public virtual android.os.IBinder getIBinder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.AbstractAccountAuthenticator)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, _getIBinder34)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.accounts.AbstractAccountAuthenticator.staticClass, _getIBinder34)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _editProperties35; 
		public abstract android.os.Bundle editProperties(android.accounts.AccountAuthenticatorResponse arg0, java.lang.String arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _addAccount36; 
		public abstract android.os.Bundle addAccount(android.accounts.AccountAuthenticatorResponse arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String[] arg3, android.os.Bundle arg4); 
		internal static global::net.sf.jni4net.jni.MethodId _confirmCredentials37; 
		public abstract android.os.Bundle confirmCredentials(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, android.os.Bundle arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _getAuthToken38; 
		public abstract android.os.Bundle getAuthToken(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String arg2, android.os.Bundle arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _getAuthTokenLabel39; 
		public abstract java.lang.String getAuthTokenLabel(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _updateCredentials40; 
		public abstract android.os.Bundle updateCredentials(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String arg2, android.os.Bundle arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _hasFeatures41; 
		public abstract android.os.Bundle hasFeatures(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1, java.lang.String[] arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _getAccountRemovalAllowed42; 
		public virtual android.os.Bundle getAccountRemovalAllowed(android.accounts.AccountAuthenticatorResponse arg0, android.accounts.Account arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.AbstractAccountAuthenticator)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _getAccountRemovalAllowed42, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.accounts.AbstractAccountAuthenticator.staticClass, _getAccountRemovalAllowed42, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractAccountAuthenticator43; 
		public AbstractAccountAuthenticator(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.AbstractAccountAuthenticator.staticClass, _AbstractAccountAuthenticator43, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.accounts.AbstractAccountAuthenticator.staticClass = @__class; 
			global::android.accounts.AbstractAccountAuthenticator._getIBinder34 = @__env.GetMethodID(global::android.accounts.AbstractAccountAuthenticator.staticClass, "getIBinder", "()Landroid/os/IBinder;"); 
			global::android.accounts.AbstractAccountAuthenticator._editProperties35 = @__env.GetMethodID(global::android.accounts.AbstractAccountAuthenticator.staticClass, "editProperties", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;)Landroid/os/Bundle;"); 
			global::android.accounts.AbstractAccountAuthenticator._addAccount36 = @__env.GetMethodID(global::android.accounts.AbstractAccountAuthenticator.staticClass, "addAccount", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;"); 
			global::android.accounts.AbstractAccountAuthenticator._confirmCredentials37 = @__env.GetMethodID(global::android.accounts.AbstractAccountAuthenticator.staticClass, "confirmCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Landroid/os/Bundle;)Landroid/os/Bundle;"); 
			global::android.accounts.AbstractAccountAuthenticator._getAuthToken38 = @__env.GetMethodID(global::android.accounts.AbstractAccountAuthenticator.staticClass, "getAuthToken", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;"); 
			global::android.accounts.AbstractAccountAuthenticator._getAuthTokenLabel39 = @__env.GetMethodID(global::android.accounts.AbstractAccountAuthenticator.staticClass, "getAuthTokenLabel", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.accounts.AbstractAccountAuthenticator._updateCredentials40 = @__env.GetMethodID(global::android.accounts.AbstractAccountAuthenticator.staticClass, "updateCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;"); 
			global::android.accounts.AbstractAccountAuthenticator._hasFeatures41 = @__env.GetMethodID(global::android.accounts.AbstractAccountAuthenticator.staticClass, "hasFeatures", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;[Ljava/lang/String;)Landroid/os/Bundle;"); 
			global::android.accounts.AbstractAccountAuthenticator._getAccountRemovalAllowed42 = @__env.GetMethodID(global::android.accounts.AbstractAccountAuthenticator.staticClass, "getAccountRemovalAllowed", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;)Landroid/os/Bundle;"); 
			global::android.accounts.AbstractAccountAuthenticator._AbstractAccountAuthenticator43 = @__env.GetMethodID(global::android.accounts.AbstractAccountAuthenticator.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
