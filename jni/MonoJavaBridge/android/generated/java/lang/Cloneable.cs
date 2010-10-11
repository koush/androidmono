namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Cloneable_))]
	public interface Cloneable  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Cloneable))]
	public sealed partial class Cloneable_ : java.lang.Object, Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Cloneable_()
		{
			InitJNI();
		}
		internal Cloneable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Cloneable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Cloneable"));
		}
	}
}
