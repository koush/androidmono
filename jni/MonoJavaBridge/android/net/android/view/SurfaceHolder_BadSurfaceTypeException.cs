namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SurfaceHolder_BadSurfaceTypeException : java.lang.RuntimeException
	{ 
		internal static global::java.lang.Class staticClass; 
		static SurfaceHolder_BadSurfaceTypeException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.SurfaceHolder_BadSurfaceTypeException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.SurfaceHolder_BadSurfaceTypeException(@__env); 
			} 
		} 
		protected SurfaceHolder_BadSurfaceTypeException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SurfaceHolder_BadSurfaceTypeException8052; 
		public SurfaceHolder_BadSurfaceTypeException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.SurfaceHolder_BadSurfaceTypeException.staticClass, global::android.view.SurfaceHolder_BadSurfaceTypeException._SurfaceHolder_BadSurfaceTypeException8052, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SurfaceHolder_BadSurfaceTypeException8053; 
		public SurfaceHolder_BadSurfaceTypeException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.SurfaceHolder_BadSurfaceTypeException.staticClass, global::android.view.SurfaceHolder_BadSurfaceTypeException._SurfaceHolder_BadSurfaceTypeException8053, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.SurfaceHolder_BadSurfaceTypeException.staticClass = @__class; 
			global::android.view.SurfaceHolder_BadSurfaceTypeException._SurfaceHolder_BadSurfaceTypeException8052 = @__env.GetMethodID(global::android.view.SurfaceHolder_BadSurfaceTypeException.staticClass, "<init>", "()V"); 
			global::android.view.SurfaceHolder_BadSurfaceTypeException._SurfaceHolder_BadSurfaceTypeException8053 = @__env.GetMethodID(global::android.view.SurfaceHolder_BadSurfaceTypeException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
