namespace javax.microedition.khronos.egl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.microedition.khronos.egl.EGL_))]
	public partial interface EGL  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.egl.EGL))]
	internal sealed partial class EGL_ : java.lang.Object, EGL
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EGL_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static EGL_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGL_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGL"));
		}
		internal static void InitJNI()
		{
		}
	}
}
