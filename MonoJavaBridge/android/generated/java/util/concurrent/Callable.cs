namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.Callable_))]
	public partial interface Callable  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object call();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.Callable))]
	internal sealed partial class Callable_ : java.lang.Object, Callable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Callable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object java.util.concurrent.Callable.call()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.Callable_.staticClass, "call", "()Ljava/lang/Object;", ref global::java.util.concurrent.Callable_._m0) as java.lang.Object;
		}
		static Callable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Callable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Callable"));
		}
	}
}
