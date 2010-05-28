namespace javax.microedition.khronos.egl 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class EGLDisplay : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static EGLDisplay() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::javax.microedition.khronos.egl.EGLDisplay), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected EGLDisplay(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _EGLDisplay13129; 
		public EGLDisplay()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(javax.microedition.khronos.egl.EGLDisplay.staticClass, global::javax.microedition.khronos.egl.EGLDisplay._EGLDisplay13129, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::javax.microedition.khronos.egl.EGLDisplay.staticClass = @__class; 
			global::javax.microedition.khronos.egl.EGLDisplay._EGLDisplay13129 = @__env.GetMethodID(global::javax.microedition.khronos.egl.EGLDisplay.staticClass, "<init>", "()V"); 
		} 
	} 
} 
