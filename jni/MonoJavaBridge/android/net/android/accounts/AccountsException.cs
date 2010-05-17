namespace android.accounts 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AccountsException : java.lang.Exception
	{ 
		internal static global::java.lang.Class staticClass; 
		static AccountsException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.accounts.AccountsException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.accounts.AccountsException(@__env); 
			} 
		} 
		protected AccountsException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AccountsException90; 
		public AccountsException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.AccountsException.staticClass, _AccountsException90, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AccountsException91; 
		public AccountsException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.AccountsException.staticClass, _AccountsException91, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AccountsException92; 
		public AccountsException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.AccountsException.staticClass, _AccountsException92, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AccountsException93; 
		public AccountsException(java.lang.Throwable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.AccountsException.staticClass, _AccountsException93, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.accounts.AccountsException.staticClass = @__class; 
			global::android.accounts.AccountsException._AccountsException90 = @__env.GetMethodID(global::android.accounts.AccountsException.staticClass, "<init>", "()V"); 
			global::android.accounts.AccountsException._AccountsException91 = @__env.GetMethodID(global::android.accounts.AccountsException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.accounts.AccountsException._AccountsException92 = @__env.GetMethodID(global::android.accounts.AccountsException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V"); 
			global::android.accounts.AccountsException._AccountsException93 = @__env.GetMethodID(global::android.accounts.AccountsException.staticClass, "<init>", "(Ljava/lang/Throwable;)V"); 
		} 
	} 
} 
