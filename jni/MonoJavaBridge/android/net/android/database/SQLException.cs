namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SQLException : java.lang.RuntimeException
	{ 
		internal static global::java.lang.Class staticClass; 
		static SQLException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.SQLException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.SQLException(@__env); 
			} 
		} 
		protected SQLException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SQLException2430; 
		public SQLException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.SQLException.staticClass, global::android.database.SQLException._SQLException2430, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SQLException2431; 
		public SQLException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.SQLException.staticClass, global::android.database.SQLException._SQLException2431, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.SQLException.staticClass = @__class; 
			global::android.database.SQLException._SQLException2430 = @__env.GetMethodID(global::android.database.SQLException.staticClass, "<init>", "()V"); 
			global::android.database.SQLException._SQLException2431 = @__env.GetMethodID(global::android.database.SQLException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
