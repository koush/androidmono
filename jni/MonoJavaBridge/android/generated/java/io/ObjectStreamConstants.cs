namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.ObjectStreamConstants_))]
	public partial interface ObjectStreamConstants  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.ObjectStreamConstants))]
	internal sealed partial class ObjectStreamConstants_ : java.lang.Object, ObjectStreamConstants
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ObjectStreamConstants_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static ObjectStreamConstants_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectStreamConstants_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectStreamConstants"));
		}
		internal static void InitJNI()
		{
		}
	}
}
