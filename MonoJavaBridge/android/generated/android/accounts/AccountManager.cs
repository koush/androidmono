namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccountManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AccountManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.accounts.AccountManager get(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AccountManager._m0.native == global::System.IntPtr.Zero)
				global::android.accounts.AccountManager._m0 = @__env.GetStaticMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "get", "(Landroid/content/Context;)Landroid/accounts/AccountManager;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.accounts.AccountManager;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setPassword(android.accounts.Account arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountManager.staticClass, "setPassword", "(Landroid/accounts/Account;Ljava/lang/String;)V", ref global::android.accounts.AccountManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.accounts.AccountManagerFuture editProperties(java.lang.String arg0, android.app.Activity arg1, android.accounts.AccountManagerCallback arg2, android.os.Handler arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.accounts.AccountManagerFuture>(this, global::android.accounts.AccountManager.staticClass, "editProperties", "(Ljava/lang/String;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", ref global::android.accounts.AccountManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.accounts.AccountManagerFuture;
		}
		public android.accounts.AccountManagerFuture editProperties(java.lang.String arg0, android.app.Activity arg1, global::android.accounts.AccountManagerCallbackDelegate arg2, android.os.Handler arg3)
		{
			return editProperties(arg0, arg1, (global::android.accounts.AccountManagerCallbackDelegateWrapper)arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.accounts.AccountManagerFuture addAccount(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, android.os.Bundle arg3, android.app.Activity arg4, android.accounts.AccountManagerCallback arg5, android.os.Handler arg6)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.accounts.AccountManagerFuture>(this, global::android.accounts.AccountManager.staticClass, "addAccount", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", ref global::android.accounts.AccountManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6)) as android.accounts.AccountManagerFuture;
		}
		public android.accounts.AccountManagerFuture addAccount(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, android.os.Bundle arg3, android.app.Activity arg4, global::android.accounts.AccountManagerCallbackDelegate arg5, android.os.Handler arg6)
		{
			return addAccount(arg0, arg1, arg2, arg3, arg4, (global::android.accounts.AccountManagerCallbackDelegateWrapper)arg5, arg6);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.accounts.AccountManagerFuture confirmCredentials(android.accounts.Account arg0, android.os.Bundle arg1, android.app.Activity arg2, android.accounts.AccountManagerCallback arg3, android.os.Handler arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.accounts.AccountManagerFuture>(this, global::android.accounts.AccountManager.staticClass, "confirmCredentials", "(Landroid/accounts/Account;Landroid/os/Bundle;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", ref global::android.accounts.AccountManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.accounts.AccountManagerFuture;
		}
		public android.accounts.AccountManagerFuture confirmCredentials(android.accounts.Account arg0, android.os.Bundle arg1, android.app.Activity arg2, global::android.accounts.AccountManagerCallbackDelegate arg3, android.os.Handler arg4)
		{
			return confirmCredentials(arg0, arg1, arg2, (global::android.accounts.AccountManagerCallbackDelegateWrapper)arg3, arg4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::android.accounts.AccountManagerFuture getAuthToken(android.accounts.Account arg0, java.lang.String arg1, bool arg2, android.accounts.AccountManagerCallback arg3, android.os.Handler arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.accounts.AccountManagerFuture>(this, global::android.accounts.AccountManager.staticClass, "getAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;ZLandroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", ref global::android.accounts.AccountManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.accounts.AccountManagerFuture;
		}
		public android.accounts.AccountManagerFuture getAuthToken(android.accounts.Account arg0, java.lang.String arg1, bool arg2, global::android.accounts.AccountManagerCallbackDelegate arg3, android.os.Handler arg4)
		{
			return getAuthToken(arg0, arg1, arg2, (global::android.accounts.AccountManagerCallbackDelegateWrapper)arg3, arg4);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.accounts.AccountManagerFuture getAuthToken(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, android.app.Activity arg3, android.accounts.AccountManagerCallback arg4, android.os.Handler arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.accounts.AccountManagerFuture>(this, global::android.accounts.AccountManager.staticClass, "getAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", ref global::android.accounts.AccountManager._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5)) as android.accounts.AccountManagerFuture;
		}
		public android.accounts.AccountManagerFuture getAuthToken(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, android.app.Activity arg3, global::android.accounts.AccountManagerCallbackDelegate arg4, android.os.Handler arg5)
		{
			return getAuthToken(arg0, arg1, arg2, arg3, (global::android.accounts.AccountManagerCallbackDelegateWrapper)arg4, arg5);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.accounts.AccountManagerFuture updateCredentials(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, android.app.Activity arg3, android.accounts.AccountManagerCallback arg4, android.os.Handler arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.accounts.AccountManagerFuture>(this, global::android.accounts.AccountManager.staticClass, "updateCredentials", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", ref global::android.accounts.AccountManager._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5)) as android.accounts.AccountManagerFuture;
		}
		public android.accounts.AccountManagerFuture updateCredentials(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, android.app.Activity arg3, global::android.accounts.AccountManagerCallbackDelegate arg4, android.os.Handler arg5)
		{
			return updateCredentials(arg0, arg1, arg2, arg3, (global::android.accounts.AccountManagerCallbackDelegateWrapper)arg4, arg5);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.accounts.AccountManagerFuture hasFeatures(android.accounts.Account arg0, java.lang.String[] arg1, android.accounts.AccountManagerCallback arg2, android.os.Handler arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.accounts.AccountManagerFuture>(this, global::android.accounts.AccountManager.staticClass, "hasFeatures", "(Landroid/accounts/Account;[Ljava/lang/String;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", ref global::android.accounts.AccountManager._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.accounts.AccountManagerFuture;
		}
		public android.accounts.AccountManagerFuture hasFeatures(android.accounts.Account arg0, java.lang.String[] arg1, global::android.accounts.AccountManagerCallbackDelegate arg2, android.os.Handler arg3)
		{
			return hasFeatures(arg0, arg1, (global::android.accounts.AccountManagerCallbackDelegateWrapper)arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.String getPassword(android.accounts.Account arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.accounts.AccountManager.staticClass, "getPassword", "(Landroid/accounts/Account;)Ljava/lang/String;", ref global::android.accounts.AccountManager._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.String getUserData(android.accounts.Account arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.accounts.AccountManager.staticClass, "getUserData", "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/lang/String;", ref global::android.accounts.AccountManager._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		public new global::android.accounts.AuthenticatorDescription[] AuthenticatorTypes
		{
			get
			{
				return getAuthenticatorTypes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::android.accounts.AuthenticatorDescription[] getAuthenticatorTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.accounts.AuthenticatorDescription>(this, global::android.accounts.AccountManager.staticClass, "getAuthenticatorTypes", "()[Landroid/accounts/AuthenticatorDescription;", ref global::android.accounts.AccountManager._m11) as android.accounts.AuthenticatorDescription[];
		}
		public new global::android.accounts.Account[] Accounts
		{
			get
			{
				return getAccounts();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::android.accounts.Account[] getAccounts()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.accounts.Account>(this, global::android.accounts.AccountManager.staticClass, "getAccounts", "()[Landroid/accounts/Account;", ref global::android.accounts.AccountManager._m12) as android.accounts.Account[];
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::android.accounts.Account[] getAccountsByType(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.accounts.Account>(this, global::android.accounts.AccountManager.staticClass, "getAccountsByType", "(Ljava/lang/String;)[Landroid/accounts/Account;", ref global::android.accounts.AccountManager._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.accounts.Account[];
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::android.accounts.AccountManagerFuture getAccountsByTypeAndFeatures(java.lang.String arg0, java.lang.String[] arg1, android.accounts.AccountManagerCallback arg2, android.os.Handler arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.accounts.AccountManagerFuture>(this, global::android.accounts.AccountManager.staticClass, "getAccountsByTypeAndFeatures", "(Ljava/lang/String;[Ljava/lang/String;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", ref global::android.accounts.AccountManager._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.accounts.AccountManagerFuture;
		}
		public android.accounts.AccountManagerFuture getAccountsByTypeAndFeatures(java.lang.String arg0, java.lang.String[] arg1, global::android.accounts.AccountManagerCallbackDelegate arg2, android.os.Handler arg3)
		{
			return getAccountsByTypeAndFeatures(arg0, arg1, (global::android.accounts.AccountManagerCallbackDelegateWrapper)arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool addAccountExplicitly(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.accounts.AccountManager.staticClass, "addAccountExplicitly", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Z", ref global::android.accounts.AccountManager._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::android.accounts.AccountManagerFuture removeAccount(android.accounts.Account arg0, android.accounts.AccountManagerCallback arg1, android.os.Handler arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.accounts.AccountManagerFuture>(this, global::android.accounts.AccountManager.staticClass, "removeAccount", "(Landroid/accounts/Account;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", ref global::android.accounts.AccountManager._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.accounts.AccountManagerFuture;
		}
		public android.accounts.AccountManagerFuture removeAccount(android.accounts.Account arg0, global::android.accounts.AccountManagerCallbackDelegate arg1, android.os.Handler arg2)
		{
			return removeAccount(arg0, (global::android.accounts.AccountManagerCallbackDelegateWrapper)arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void invalidateAuthToken(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountManager.staticClass, "invalidateAuthToken", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.accounts.AccountManager._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.lang.String peekAuthToken(android.accounts.Account arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.accounts.AccountManager.staticClass, "peekAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/lang/String;", ref global::android.accounts.AccountManager._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void clearPassword(android.accounts.Account arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountManager.staticClass, "clearPassword", "(Landroid/accounts/Account;)V", ref global::android.accounts.AccountManager._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setUserData(android.accounts.Account arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountManager.staticClass, "setUserData", "(Landroid/accounts/Account;Ljava/lang/String;Ljava/lang/String;)V", ref global::android.accounts.AccountManager._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setAuthToken(android.accounts.Account arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountManager.staticClass, "setAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;Ljava/lang/String;)V", ref global::android.accounts.AccountManager._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::java.lang.String blockingGetAuthToken(android.accounts.Account arg0, java.lang.String arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.accounts.AccountManager.staticClass, "blockingGetAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;Z)Ljava/lang/String;", ref global::android.accounts.AccountManager._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::android.accounts.AccountManagerFuture getAuthTokenByFeatures(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, android.app.Activity arg3, android.os.Bundle arg4, android.os.Bundle arg5, android.accounts.AccountManagerCallback arg6, android.os.Handler arg7)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.accounts.AccountManagerFuture>(this, global::android.accounts.AccountManager.staticClass, "getAuthTokenByFeatures", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/app/Activity;Landroid/os/Bundle;Landroid/os/Bundle;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", ref global::android.accounts.AccountManager._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7)) as android.accounts.AccountManagerFuture;
		}
		public android.accounts.AccountManagerFuture getAuthTokenByFeatures(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, android.app.Activity arg3, android.os.Bundle arg4, android.os.Bundle arg5, global::android.accounts.AccountManagerCallbackDelegate arg6, android.os.Handler arg7)
		{
			return getAuthTokenByFeatures(arg0, arg1, arg2, arg3, arg4, arg5, (global::android.accounts.AccountManagerCallbackDelegateWrapper)arg6, arg7);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void addOnAccountsUpdatedListener(android.accounts.OnAccountsUpdateListener arg0, android.os.Handler arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountManager.staticClass, "addOnAccountsUpdatedListener", "(Landroid/accounts/OnAccountsUpdateListener;Landroid/os/Handler;Z)V", ref global::android.accounts.AccountManager._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void addOnAccountsUpdatedListener(global::android.accounts.OnAccountsUpdateListenerDelegate arg0, android.os.Handler arg1, bool arg2)
		{
			addOnAccountsUpdatedListener((global::android.accounts.OnAccountsUpdateListenerDelegateWrapper)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void removeOnAccountsUpdatedListener(android.accounts.OnAccountsUpdateListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountManager.staticClass, "removeOnAccountsUpdatedListener", "(Landroid/accounts/OnAccountsUpdateListener;)V", ref global::android.accounts.AccountManager._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeOnAccountsUpdatedListener(global::android.accounts.OnAccountsUpdateListenerDelegate arg0)
		{
			removeOnAccountsUpdatedListener((global::android.accounts.OnAccountsUpdateListenerDelegateWrapper)arg0);
		}
		public static int ERROR_CODE_REMOTE_EXCEPTION
		{
			get
			{
				return 1;
			}
		}
		public static int ERROR_CODE_NETWORK_ERROR
		{
			get
			{
				return 3;
			}
		}
		public static int ERROR_CODE_CANCELED
		{
			get
			{
				return 4;
			}
		}
		public static int ERROR_CODE_INVALID_RESPONSE
		{
			get
			{
				return 5;
			}
		}
		public static int ERROR_CODE_UNSUPPORTED_OPERATION
		{
			get
			{
				return 6;
			}
		}
		public static int ERROR_CODE_BAD_ARGUMENTS
		{
			get
			{
				return 7;
			}
		}
		public static int ERROR_CODE_BAD_REQUEST
		{
			get
			{
				return 8;
			}
		}
		public static global::java.lang.String KEY_ACCOUNT_NAME
		{
			get
			{
				return "authAccount";
			}
		}
		public static global::java.lang.String KEY_ACCOUNT_TYPE
		{
			get
			{
				return "accountType";
			}
		}
		public static global::java.lang.String KEY_AUTHTOKEN
		{
			get
			{
				return "authtoken";
			}
		}
		public static global::java.lang.String KEY_INTENT
		{
			get
			{
				return "intent";
			}
		}
		public static global::java.lang.String KEY_PASSWORD
		{
			get
			{
				return "password";
			}
		}
		public static global::java.lang.String KEY_ACCOUNTS
		{
			get
			{
				return "accounts";
			}
		}
		public static global::java.lang.String KEY_ACCOUNT_AUTHENTICATOR_RESPONSE
		{
			get
			{
				return "accountAuthenticatorResponse";
			}
		}
		public static global::java.lang.String KEY_ACCOUNT_MANAGER_RESPONSE
		{
			get
			{
				return "accountManagerResponse";
			}
		}
		public static global::java.lang.String KEY_AUTHENTICATOR_TYPES
		{
			get
			{
				return "authenticator_types";
			}
		}
		public static global::java.lang.String KEY_AUTH_FAILED_MESSAGE
		{
			get
			{
				return "authFailedMessage";
			}
		}
		public static global::java.lang.String KEY_AUTH_TOKEN_LABEL
		{
			get
			{
				return "authTokenLabelKey";
			}
		}
		public static global::java.lang.String KEY_BOOLEAN_RESULT
		{
			get
			{
				return "booleanResult";
			}
		}
		public static global::java.lang.String KEY_ERROR_CODE
		{
			get
			{
				return "errorCode";
			}
		}
		public static global::java.lang.String KEY_ERROR_MESSAGE
		{
			get
			{
				return "errorMessage";
			}
		}
		public static global::java.lang.String KEY_USERDATA
		{
			get
			{
				return "userdata";
			}
		}
		public static global::java.lang.String ACTION_AUTHENTICATOR_INTENT
		{
			get
			{
				return "android.accounts.AccountAuthenticator";
			}
		}
		public static global::java.lang.String AUTHENTICATOR_META_DATA_NAME
		{
			get
			{
				return "android.accounts.AccountAuthenticator";
			}
		}
		public static global::java.lang.String AUTHENTICATOR_ATTRIBUTES_NAME
		{
			get
			{
				return "account-authenticator";
			}
		}
		public static global::java.lang.String LOGIN_ACCOUNTS_CHANGED_ACTION
		{
			get
			{
				return "android.accounts.LOGIN_ACCOUNTS_CHANGED";
			}
		}
		static AccountManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AccountManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
