namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.Serializable_))]
	public partial interface Serializable  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.Serializable))]
	internal sealed partial class Serializable_ : java.lang.Object, Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Serializable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static Serializable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Serializable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Serializable"));
		}
	}
}
