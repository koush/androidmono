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
		internal static global::MonoJavaBridge.MethodId _execute27261;
		void java.util.concurrent.Executor.execute(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Executor_._execute27261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Executor_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Executor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Executor"));
			global::java.util.concurrent.Executor_._execute27261 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Executor_.staticClass, "execute", "(Ljava/lang/Runnable;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
