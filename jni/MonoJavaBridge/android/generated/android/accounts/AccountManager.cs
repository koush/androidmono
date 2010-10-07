namespace android.accounts
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AccountManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static AccountManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.accounts.AccountManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.accounts.AccountManager(@__env);
			}
		}
		protected AccountManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get65;
		public static global::android.accounts.AccountManager get(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.accounts.AccountManager>(@__env, @__env.CallStaticObjectMethodPtr(android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._get65, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPassword66;
		public virtual void setPassword(android.accounts.Account arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.accounts.AccountManager._setPassword66, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._setPassword66, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _editProperties67;
		public virtual global::android.accounts.AccountManagerFuture editProperties(java.lang.String arg0, android.app.Activity arg1, android.accounts.AccountManagerCallback arg2, android.os.Handler arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._editProperties67, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._editProperties67, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addAccount68;
		public virtual global::android.accounts.AccountManagerFuture addAccount(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, android.os.Bundle arg3, android.app.Activity arg4, android.accounts.AccountManagerCallback arg5, android.os.Handler arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._addAccount68, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._addAccount68, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _confirmCredentials69;
		public virtual global::android.accounts.AccountManagerFuture confirmCredentials(android.accounts.Account arg0, android.os.Bundle arg1, android.app.Activity arg2, android.accounts.AccountManagerCallback arg3, android.os.Handler arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._confirmCredentials69, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._confirmCredentials69, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAuthToken70;
		public virtual global::android.accounts.AccountManagerFuture getAuthToken(android.accounts.Account arg0, java.lang.String arg1, bool arg2, android.accounts.AccountManagerCallback arg3, android.os.Handler arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._getAuthToken70, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getAuthToken70, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAuthToken71;
		public virtual global::android.accounts.AccountManagerFuture getAuthToken(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, android.app.Activity arg3, android.accounts.AccountManagerCallback arg4, android.os.Handler arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._getAuthToken71, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getAuthToken71, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateCredentials72;
		public virtual global::android.accounts.AccountManagerFuture updateCredentials(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, android.app.Activity arg3, android.accounts.AccountManagerCallback arg4, android.os.Handler arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._updateCredentials72, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._updateCredentials72, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasFeatures73;
		public virtual global::android.accounts.AccountManagerFuture hasFeatures(android.accounts.Account arg0, java.lang.String[] arg1, android.accounts.AccountManagerCallback arg2, android.os.Handler arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._hasFeatures73, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._hasFeatures73, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPassword74;
		public virtual global::java.lang.String getPassword(android.accounts.Account arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._getPassword74, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getPassword74, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUserData75;
		public virtual global::java.lang.String getUserData(android.accounts.Account arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._getUserData75, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getUserData75, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAuthenticatorTypes76;
		public virtual global::android.accounts.AuthenticatorDescription[] getAuthenticatorTypes() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._getAuthenticatorTypes76));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getAuthenticatorTypes76));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAccounts77;
		public virtual global::android.accounts.Account[] getAccounts() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._getAccounts77));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getAccounts77));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAccountsByType78;
		public virtual global::android.accounts.Account[] getAccountsByType(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._getAccountsByType78, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getAccountsByType78, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAccountsByTypeAndFeatures79;
		public virtual global::android.accounts.AccountManagerFuture getAccountsByTypeAndFeatures(java.lang.String arg0, java.lang.String[] arg1, android.accounts.AccountManagerCallback arg2, android.os.Handler arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._getAccountsByTypeAndFeatures79, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getAccountsByTypeAndFeatures79, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addAccountExplicitly80;
		public virtual bool addAccountExplicitly(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.accounts.AccountManager._addAccountExplicitly80, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._addAccountExplicitly80, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAccount81;
		public virtual global::android.accounts.AccountManagerFuture removeAccount(android.accounts.Account arg0, android.accounts.AccountManagerCallback arg1, android.os.Handler arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._removeAccount81, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._removeAccount81, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateAuthToken82;
		public virtual void invalidateAuthToken(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.accounts.AccountManager._invalidateAuthToken82, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._invalidateAuthToken82, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _peekAuthToken83;
		public virtual global::java.lang.String peekAuthToken(android.accounts.Account arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._peekAuthToken83, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._peekAuthToken83, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearPassword84;
		public virtual void clearPassword(android.accounts.Account arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.accounts.AccountManager._clearPassword84, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._clearPassword84, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUserData85;
		public virtual void setUserData(android.accounts.Account arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.accounts.AccountManager._setUserData85, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._setUserData85, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAuthToken86;
		public virtual void setAuthToken(android.accounts.Account arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.accounts.AccountManager._setAuthToken86, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._setAuthToken86, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _blockingGetAuthToken87;
		public virtual global::java.lang.String blockingGetAuthToken(android.accounts.Account arg0, java.lang.String arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._blockingGetAuthToken87, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._blockingGetAuthToken87, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAuthTokenByFeatures88;
		public virtual global::android.accounts.AccountManagerFuture getAuthTokenByFeatures(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, android.app.Activity arg3, android.os.Bundle arg4, android.os.Bundle arg5, android.accounts.AccountManagerCallback arg6, android.os.Handler arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AccountManager._getAuthTokenByFeatures88, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.accounts.AccountManagerFuture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getAuthTokenByFeatures88, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addOnAccountsUpdatedListener89;
		public virtual void addOnAccountsUpdatedListener(android.accounts.OnAccountsUpdateListener arg0, android.os.Handler arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.accounts.AccountManager._addOnAccountsUpdatedListener89, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._addOnAccountsUpdatedListener89, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeOnAccountsUpdatedListener90;
		public virtual void removeOnAccountsUpdatedListener(android.accounts.OnAccountsUpdateListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.accounts.AccountManager._removeOnAccountsUpdatedListener90, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._removeOnAccountsUpdatedListener90, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.accounts.AccountManager.staticClass = @__class;
			global::android.accounts.AccountManager._get65 = @__env.GetStaticMethodID(global::android.accounts.AccountManager.staticClass, "get", "(Landroid/content/Context;)Landroid/accounts/AccountManager;");
			global::android.accounts.AccountManager._setPassword66 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "setPassword", "(Landroid/accounts/Account;Ljava/lang/String;)V");
			global::android.accounts.AccountManager._editProperties67 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "editProperties", "(Ljava/lang/String;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._addAccount68 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "addAccount", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._confirmCredentials69 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "confirmCredentials", "(Landroid/accounts/Account;Landroid/os/Bundle;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._getAuthToken70 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "getAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;ZLandroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._getAuthToken71 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "getAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._updateCredentials72 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "updateCredentials", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._hasFeatures73 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "hasFeatures", "(Landroid/accounts/Account;[Ljava/lang/String;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._getPassword74 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "getPassword", "(Landroid/accounts/Account;)Ljava/lang/String;");
			global::android.accounts.AccountManager._getUserData75 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "getUserData", "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/lang/String;");
			global::android.accounts.AccountManager._getAuthenticatorTypes76 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "getAuthenticatorTypes", "()[Landroid/accounts/AuthenticatorDescription;");
			global::android.accounts.AccountManager._getAccounts77 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "getAccounts", "()[Landroid/accounts/Account;");
			global::android.accounts.AccountManager._getAccountsByType78 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "getAccountsByType", "(Ljava/lang/String;)[Landroid/accounts/Account;");
			global::android.accounts.AccountManager._getAccountsByTypeAndFeatures79 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "getAccountsByTypeAndFeatures", "(Ljava/lang/String;[Ljava/lang/String;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._addAccountExplicitly80 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "addAccountExplicitly", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.accounts.AccountManager._removeAccount81 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "removeAccount", "(Landroid/accounts/Account;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._invalidateAuthToken82 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "invalidateAuthToken", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.accounts.AccountManager._peekAuthToken83 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "peekAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/lang/String;");
			global::android.accounts.AccountManager._clearPassword84 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "clearPassword", "(Landroid/accounts/Account;)V");
			global::android.accounts.AccountManager._setUserData85 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "setUserData", "(Landroid/accounts/Account;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.accounts.AccountManager._setAuthToken86 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "setAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.accounts.AccountManager._blockingGetAuthToken87 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "blockingGetAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;Z)Ljava/lang/String;");
			global::android.accounts.AccountManager._getAuthTokenByFeatures88 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "getAuthTokenByFeatures", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/app/Activity;Landroid/os/Bundle;Landroid/os/Bundle;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._addOnAccountsUpdatedListener89 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "addOnAccountsUpdatedListener", "(Landroid/accounts/OnAccountsUpdateListener;Landroid/os/Handler;Z)V");
			global::android.accounts.AccountManager._removeOnAccountsUpdatedListener90 = @__env.GetMethodID(global::android.accounts.AccountManager.staticClass, "removeOnAccountsUpdatedListener", "(Landroid/accounts/OnAccountsUpdateListener;)V");
		}
	}
}
