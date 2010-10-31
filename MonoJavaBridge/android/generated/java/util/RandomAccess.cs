namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.RandomAccess_))]
	public partial interface RandomAccess  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.RandomAccess))]
	internal sealed partial class RandomAccess_ : java.lang.Object, RandomAccess
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RandomAccess_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static RandomAccess_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.RandomAccess_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/RandomAccess"));
		}
	}
}
