namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.RandomAccess_))]
	public interface RandomAccess  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.RandomAccess))]
	public sealed partial class RandomAccess_ : java.lang.Object, RandomAccess
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RandomAccess_()
		{
			InitJNI();
		}
		internal RandomAccess_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.RandomAccess_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/RandomAccess"));
		}
	}
}
