namespace javax.microedition.khronos.egl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.microedition.khronos.egl.EGLDisplay_))]
	public abstract partial class EGLDisplay : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EGLDisplay()
		{
			InitJNI();
		}
		protected EGLDisplay(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _EGLDisplay28837;
		public EGLDisplay()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.microedition.khronos.egl.EGLDisplay.staticClass, global::javax.microedition.khronos.egl.EGLDisplay._EGLDisplay28837);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLDisplay.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLDisplay"));
			global::javax.microedition.khronos.egl.EGLDisplay._EGLDisplay28837 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGLDisplay.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.egl.EGLDisplay))]
	public sealed partial class EGLDisplay_ : javax.microedition.khronos.egl.EGLDisplay
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EGLDisplay_()
		{
			InitJNI();
		}
		internal EGLDisplay_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLDisplay_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLDisplay"));
		}
	}
}
