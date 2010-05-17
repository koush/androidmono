namespace android.accounts 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AuthenticatorException : android.accounts.AccountsException
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AuthenticatorException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.accounts.AuthenticatorException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.accounts.AuthenticatorException(@__env); 
			} 
		} 
		protected AuthenticatorException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AuthenticatorException108; 
		public AuthenticatorException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.AuthenticatorException.staticClass, _AuthenticatorException108, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AuthenticatorException109; 
		public AuthenticatorException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.AuthenticatorException.staticClass, _AuthenticatorException109, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AuthenticatorException110; 
		public AuthenticatorException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.AuthenticatorException.staticClass, _AuthenticatorException110, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AuthenticatorException111; 
		public AuthenticatorException(java.lang.Throwable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.AuthenticatorException.staticClass, _AuthenticatorException111, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.accounts.AuthenticatorException.staticClass = @__class; 
			global::android.accounts.AuthenticatorException._AuthenticatorException108 = @__env.GetMethodID(global::android.accounts.AuthenticatorException.staticClass, "<init>", "()V"); 
			global::android.accounts.AuthenticatorException._AuthenticatorException109 = @__env.GetMethodID(global::android.accounts.AuthenticatorException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.accounts.AuthenticatorException._AuthenticatorException110 = @__env.GetMethodID(global::android.accounts.AuthenticatorException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V"); 
			global::android.accounts.AuthenticatorException._AuthenticatorException111 = @__env.GetMethodID(global::android.accounts.AuthenticatorException.staticClass, "<init>", "(Ljava/lang/Throwable;)V"); 
		} 
	} 
} 
