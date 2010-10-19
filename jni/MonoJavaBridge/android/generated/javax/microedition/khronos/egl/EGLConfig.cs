namespace javax.microedition.khronos.egl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.microedition.khronos.egl.EGLConfig_))]
	public abstract partial class EGLConfig : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EGLConfig()
		{
			InitJNI();
		}
		protected EGLConfig(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _EGLConfig22862;
		public EGLConfig()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.microedition.khronos.egl.EGLConfig.staticClass, global::javax.microedition.khronos.egl.EGLConfig._EGLConfig22862);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLConfig.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLConfig"));
			global::javax.microedition.khronos.egl.EGLConfig._EGLConfig22862 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGLConfig.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.egl.EGLConfig))]
	public sealed partial class EGLConfig_ : javax.microedition.khronos.egl.EGLConfig
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EGLConfig_()
		{
			InitJNI();
		}
		internal EGLConfig_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLConfig_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLConfig"));
		}
	}
}
