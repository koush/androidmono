namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class OperationApplicationException : java.lang.Exception
	{ 
		internal static global::java.lang.Class staticClass; 
		static OperationApplicationException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.OperationApplicationException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getNumSuccessfulYieldPoints1475; 
		public virtual int getNumSuccessfulYieldPoints() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.content.OperationApplicationException._getNumSuccessfulYieldPoints1475); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._getNumSuccessfulYieldPoints1475); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationApplicationException1476; 
		public OperationApplicationException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException1476, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationApplicationException1477; 
		public OperationApplicationException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException1477, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationApplicationException1478; 
		public OperationApplicationException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException1478, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationApplicationException1479; 
		public OperationApplicationException(java.lang.Throwable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException1479, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationApplicationException1480; 
		public OperationApplicationException(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException1480, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OperationApplicationException1481; 
		public OperationApplicationException(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException1481, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.OperationApplicationException.staticClass = @__class; 
			global::android.content.OperationApplicationException._getNumSuccessfulYieldPoints1475 = @__env.GetMethodID(global::android.content.OperationApplicationException.staticClass, "getNumSuccessfulYieldPoints", "()I"); 
			global::android.content.OperationApplicationException._OperationApplicationException1476 = @__env.GetMethodID(global::android.content.OperationApplicationException.staticClass, "<init>", "()V"); 
			global::android.content.OperationApplicationException._OperationApplicationException1477 = @__env.GetMethodID(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.content.OperationApplicationException._OperationApplicationException1478 = @__env.GetMethodID(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V"); 
			global::android.content.OperationApplicationException._OperationApplicationException1479 = @__env.GetMethodID(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V"); 
			global::android.content.OperationApplicationException._OperationApplicationException1480 = @__env.GetMethodID(global::android.content.OperationApplicationException.staticClass, "<init>", "(I)V"); 
			global::android.content.OperationApplicationException._OperationApplicationException1481 = @__env.GetMethodID(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/String;I)V"); 
		} 
	} 
} 
