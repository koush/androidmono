namespace android.accounts 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class OperationCanceledException : android.accounts.AccountsException
	{ 
		internal new static global::java.lang.Class staticClass; 
		static OperationCanceledException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.accounts.OperationCanceledException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.accounts.OperationCanceledException(@__env); 
			} 
		} 
		protected OperationCanceledException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationCanceledException116; 
		public OperationCanceledException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.OperationCanceledException.staticClass, _OperationCanceledException116, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationCanceledException117; 
		public OperationCanceledException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.OperationCanceledException.staticClass, _OperationCanceledException117, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationCanceledException118; 
		public OperationCanceledException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.OperationCanceledException.staticClass, _OperationCanceledException118, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationCanceledException119; 
		public OperationCanceledException(java.lang.Throwable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.OperationCanceledException.staticClass, _OperationCanceledException119, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.accounts.OperationCanceledException.staticClass = @__class; 
			global::android.accounts.OperationCanceledException._OperationCanceledException116 = @__env.GetMethodID(global::android.accounts.OperationCanceledException.staticClass, "<init>", "()V"); 
			global::android.accounts.OperationCanceledException._OperationCanceledException117 = @__env.GetMethodID(global::android.accounts.OperationCanceledException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.accounts.OperationCanceledException._OperationCanceledException118 = @__env.GetMethodID(global::android.accounts.OperationCanceledException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V"); 
			global::android.accounts.OperationCanceledException._OperationCanceledException119 = @__env.GetMethodID(global::android.accounts.OperationCanceledException.staticClass, "<init>", "(Ljava/lang/Throwable;)V"); 
		} 
	} 
} 
