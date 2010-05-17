namespace java.io 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class IOException : java.lang.Exception
	{ 
		internal static global::java.lang.Class staticClass; 
		static IOException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.io.IOException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.io.IOException(@__env); 
			} 
		} 
		protected IOException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _IOException10584; 
		public IOException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.IOException.staticClass, _IOException10584, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _IOException10585; 
		public IOException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.IOException.staticClass, _IOException10585, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _IOException10586; 
		public IOException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.IOException.staticClass, _IOException10586, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _IOException10587; 
		public IOException(java.lang.Throwable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.IOException.staticClass, _IOException10587, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.io.IOException.staticClass = @__class; 
			global::java.io.IOException._IOException10584 = @__env.GetMethodID(global::java.io.IOException.staticClass, "<init>", "()V"); 
			global::java.io.IOException._IOException10585 = @__env.GetMethodID(global::java.io.IOException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::java.io.IOException._IOException10586 = @__env.GetMethodID(global::java.io.IOException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V"); 
			global::java.io.IOException._IOException10587 = @__env.GetMethodID(global::java.io.IOException.staticClass, "<init>", "(Ljava/lang/Throwable;)V"); 
		} 
	} 
} 
