namespace android.accounts 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface OnAccountsUpdateListener 
	{ 
		void onAccountsUpdated(android.accounts.Account[] arg0); 
	} 

	public partial class OnAccountsUpdateListener_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __OnAccountsUpdateListener.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __OnAccountsUpdateListener : java.lang.Object, OnAccountsUpdateListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static __OnAccountsUpdateListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.accounts.__OnAccountsUpdateListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.accounts.__OnAccountsUpdateListener(@__env); 
			} 
		} 
		internal __OnAccountsUpdateListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAccountsUpdated122; 
		 void android.accounts.OnAccountsUpdateListener.onAccountsUpdated(android.accounts.Account[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.__OnAccountsUpdateListener)) 
				@__env.CallVoidMethod(this, _onAccountsUpdated122, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.accounts.__OnAccountsUpdateListener.staticClass, _onAccountsUpdated122, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.accounts.__OnAccountsUpdateListener.staticClass = @__class; 
			global::android.accounts.__OnAccountsUpdateListener._onAccountsUpdated122 = @__env.GetMethodID(global::android.accounts.__OnAccountsUpdateListener.staticClass, "android.accounts.OnAccountsUpdateListener.onAccountsUpdated", "([Landroid/accounts/Account;)V"); 
		} 
	} 
} 
