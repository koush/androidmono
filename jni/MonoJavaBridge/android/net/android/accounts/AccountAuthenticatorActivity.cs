namespace android.accounts 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AccountAuthenticatorActivity : android.app.Activity
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AccountAuthenticatorActivity() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.accounts.AccountAuthenticatorActivity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.accounts.AccountAuthenticatorActivity(@__env); 
			} 
		} 
		protected AccountAuthenticatorActivity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate54; 
		protected override void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.AccountAuthenticatorActivity)) 
				@__env.CallVoidMethod(this, _onCreate54, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.accounts.AccountAuthenticatorActivity.staticClass, _onCreate54, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAccountAuthenticatorResult55; 
		public virtual void setAccountAuthenticatorResult(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.AccountAuthenticatorActivity)) 
				@__env.CallVoidMethod(this, _setAccountAuthenticatorResult55, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.accounts.AccountAuthenticatorActivity.staticClass, _setAccountAuthenticatorResult55, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finish56; 
		public override void finish() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.AccountAuthenticatorActivity)) 
				@__env.CallVoidMethod(this, _finish56); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.accounts.AccountAuthenticatorActivity.staticClass, _finish56); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AccountAuthenticatorActivity57; 
		public AccountAuthenticatorActivity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.AccountAuthenticatorActivity.staticClass, _AccountAuthenticatorActivity57, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.accounts.AccountAuthenticatorActivity.staticClass = @__class; 
			global::android.accounts.AccountAuthenticatorActivity._onCreate54 = @__env.GetMethodID(global::android.accounts.AccountAuthenticatorActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.accounts.AccountAuthenticatorActivity._setAccountAuthenticatorResult55 = @__env.GetMethodID(global::android.accounts.AccountAuthenticatorActivity.staticClass, "setAccountAuthenticatorResult", "(Landroid/os/Bundle;)V"); 
			global::android.accounts.AccountAuthenticatorActivity._finish56 = @__env.GetMethodID(global::android.accounts.AccountAuthenticatorActivity.staticClass, "finish", "()V"); 
			global::android.accounts.AccountAuthenticatorActivity._AccountAuthenticatorActivity57 = @__env.GetMethodID(global::android.accounts.AccountAuthenticatorActivity.staticClass, "<init>", "()V"); 
		} 
	} 
} 
