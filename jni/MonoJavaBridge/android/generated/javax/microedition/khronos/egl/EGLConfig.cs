namespace javax.microedition.khronos.egl
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class EGLConfig : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static EGLConfig()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::javax.microedition.khronos.egl.EGLConfig), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected EGLConfig(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _EGLConfig13956;
		public EGLConfig()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(javax.microedition.khronos.egl.EGLConfig.staticClass, global::javax.microedition.khronos.egl.EGLConfig._EGLConfig13956, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::javax.microedition.khronos.egl.EGLConfig.staticClass = @__class;
			global::javax.microedition.khronos.egl.EGLConfig._EGLConfig13956 = @__env.GetMethodID(global::javax.microedition.khronos.egl.EGLConfig.staticClass, "<init>", "()V");
		}
	}
}
