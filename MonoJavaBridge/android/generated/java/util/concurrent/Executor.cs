namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.Executor_))]
	public partial interface Executor  : global::MonoJavaBridge.IJavaObject 
	{
		void execute(java.lang.Runnable arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.Executor))]
	internal sealed partial class Executor_ : java.lang.Object, Executor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Executor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void java.util.concurrent.Executor.execute(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.Executor_.staticClass, "execute", "(Ljava/lang/Runnable;)V", ref global::java.util.concurrent.Executor_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Executor_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Executor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Executor"));
		}
	}
}
