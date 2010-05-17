namespace android.accounts 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class NetworkErrorException : android.accounts.AccountsException
	{ 
		internal new static global::java.lang.Class staticClass; 
		static NetworkErrorException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.accounts.NetworkErrorException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.accounts.NetworkErrorException(@__env); 
			} 
		} 
		protected NetworkErrorException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NetworkErrorException112; 
		public NetworkErrorException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.NetworkErrorException.staticClass, _NetworkErrorException112, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NetworkErrorException113; 
		public NetworkErrorException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.NetworkErrorException.staticClass, _NetworkErrorException113, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NetworkErrorException114; 
		public NetworkErrorException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.NetworkErrorException.staticClass, _NetworkErrorException114, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NetworkErrorException115; 
		public NetworkErrorException(java.lang.Throwable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.NetworkErrorException.staticClass, _NetworkErrorException115, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.accounts.NetworkErrorException.staticClass = @__class; 
			global::android.accounts.NetworkErrorException._NetworkErrorException112 = @__env.GetMethodID(global::android.accounts.NetworkErrorException.staticClass, "<init>", "()V"); 
			global::android.accounts.NetworkErrorException._NetworkErrorException113 = @__env.GetMethodID(global::android.accounts.NetworkErrorException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.accounts.NetworkErrorException._NetworkErrorException114 = @__env.GetMethodID(global::android.accounts.NetworkErrorException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V"); 
			global::android.accounts.NetworkErrorException._NetworkErrorException115 = @__env.GetMethodID(global::android.accounts.NetworkErrorException.staticClass, "<init>", "(Ljava/lang/Throwable;)V"); 
		} 
	} 
} 
