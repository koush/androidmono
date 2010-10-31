namespace javax.microedition.khronos.opengles
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.microedition.khronos.opengles.GL_))]
	public partial interface GL  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.opengles.GL))]
	internal sealed partial class GL_ : java.lang.Object, GL
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GL_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static GL_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.opengles.GL_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/opengles/GL"));
		}
	}
}
