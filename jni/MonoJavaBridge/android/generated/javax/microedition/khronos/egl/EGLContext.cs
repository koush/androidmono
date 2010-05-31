namespace javax.microedition.khronos.egl
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class EGLContext : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static EGLContext()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::javax.microedition.khronos.egl.EGLContext), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected EGLContext(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGL13126;
		public abstract global::javax.microedition.khronos.opengles.GL getGL();
		internal static global::net.sf.jni4net.jni.MethodId _getEGL13127;
		public static global::javax.microedition.khronos.egl.EGL getEGL() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<javax.microedition.khronos.egl.EGL>(@__env, @__env.CallStaticObjectMethodPtr(javax.microedition.khronos.egl.EGLContext.staticClass, global::javax.microedition.khronos.egl.EGLContext._getEGL13127));
		}
		internal static global::net.sf.jni4net.jni.MethodId _EGLContext13128;
		public EGLContext()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(javax.microedition.khronos.egl.EGLContext.staticClass, global::javax.microedition.khronos.egl.EGLContext._EGLContext13128, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::javax.microedition.khronos.egl.EGLContext.staticClass = @__class;
			global::javax.microedition.khronos.egl.EGLContext._getGL13126 = @__env.GetMethodID(global::javax.microedition.khronos.egl.EGLContext.staticClass, "getGL", "()Ljavax/microedition/khronos/opengles/GL;");
			global::javax.microedition.khronos.egl.EGLContext._getEGL13127 = @__env.GetStaticMethodID(global::javax.microedition.khronos.egl.EGLContext.staticClass, "getEGL", "()Ljavax/microedition/khronos/egl/EGL;");
			global::javax.microedition.khronos.egl.EGLContext._EGLContext13128 = @__env.GetMethodID(global::javax.microedition.khronos.egl.EGLContext.staticClass, "<init>", "()V");
		}
	}
}
