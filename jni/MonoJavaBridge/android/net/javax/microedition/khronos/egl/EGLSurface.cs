namespace javax.microedition.khronos.egl 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class EGLSurface : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static EGLSurface() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(javax.microedition.khronos.egl.EGLSurface), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected EGLSurface(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _EGLSurface12153; 
		public EGLSurface()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(javax.microedition.khronos.egl.EGLSurface.staticClass, _EGLSurface12153, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::javax.microedition.khronos.egl.EGLSurface.staticClass = @__class; 
			global::javax.microedition.khronos.egl.EGLSurface._EGLSurface12153 = @__env.GetMethodID(global::javax.microedition.khronos.egl.EGLSurface.staticClass, "<init>", "()V"); 
		} 
	} 
} 
