namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class OperationApplicationException : java.lang.Exception
	{ 
		internal static global::java.lang.Class staticClass; 
		static OperationApplicationException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.OperationApplicationException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.OperationApplicationException(@__env); 
			} 
		} 
		protected OperationApplicationException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumSuccessfulYieldPoints1452; 
		public virtual int getNumSuccessfulYieldPoints() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.OperationApplicationException)) 
				return @__env.CallIntMethod(this, _getNumSuccessfulYieldPoints1452); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.OperationApplicationException.staticClass, _getNumSuccessfulYieldPoints1452); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationApplicationException1453; 
		public OperationApplicationException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.OperationApplicationException.staticClass, _OperationApplicationException1453, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationApplicationException1454; 
		public OperationApplicationException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.OperationApplicationException.staticClass, _OperationApplicationException1454, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationApplicationException1455; 
		public OperationApplicationException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.OperationApplicationException.staticClass, _OperationApplicationException1455, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationApplicationException1456; 
		public OperationApplicationException(java.lang.Throwable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.OperationApplicationException.staticClass, _OperationApplicationException1456, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationApplicationException1457; 
		public OperationApplicationException(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.OperationApplicationException.staticClass, _OperationApplicationException1457, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationApplicationException1458; 
		public OperationApplicationException(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.OperationApplicationException.staticClass, _OperationApplicationException1458, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.OperationApplicationException.staticClass = @__class; 
			global::android.content.OperationApplicationException._getNumSuccessfulYieldPoints1452 = @__env.GetMethodID(global::android.content.OperationApplicationException.staticClass, "getNumSuccessfulYieldPoints", "()I"); 
			global::android.content.OperationApplicationException._OperationApplicationException1453 = @__env.GetMethodID(global::android.content.OperationApplicationException.staticClass, "<init>", "()V"); 
			global::android.content.OperationApplicationException._OperationApplicationException1454 = @__env.GetMethodID(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.content.OperationApplicationException._OperationApplicationException1455 = @__env.GetMethodID(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V"); 
			global::android.content.OperationApplicationException._OperationApplicationException1456 = @__env.GetMethodID(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V"); 
			global::android.content.OperationApplicationException._OperationApplicationException1457 = @__env.GetMethodID(global::android.content.OperationApplicationException.staticClass, "<init>", "(I)V"); 
			global::android.content.OperationApplicationException._OperationApplicationException1458 = @__env.GetMethodID(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/String;I)V"); 
		} 
	} 
} 
