namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ParcelFormatException : java.lang.RuntimeException
	{ 
		internal static global::java.lang.Class staticClass; 
		static ParcelFormatException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.ParcelFormatException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.ParcelFormatException(@__env); 
			} 
		} 
		protected ParcelFormatException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ParcelFormatException5534; 
		public ParcelFormatException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.ParcelFormatException.staticClass, _ParcelFormatException5534, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ParcelFormatException5535; 
		public ParcelFormatException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.ParcelFormatException.staticClass, _ParcelFormatException5535, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.ParcelFormatException.staticClass = @__class; 
			global::android.os.ParcelFormatException._ParcelFormatException5534 = @__env.GetMethodID(global::android.os.ParcelFormatException.staticClass, "<init>", "()V"); 
			global::android.os.ParcelFormatException._ParcelFormatException5535 = @__env.GetMethodID(global::android.os.ParcelFormatException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
