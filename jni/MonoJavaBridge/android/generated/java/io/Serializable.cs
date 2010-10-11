namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.Serializable_))]
	public interface Serializable  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.Serializable))]
	public sealed partial class Serializable_ : java.lang.Object, Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Serializable_()
		{
			InitJNI();
		}
		internal Serializable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Serializable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Serializable"));
		}
	}
}
