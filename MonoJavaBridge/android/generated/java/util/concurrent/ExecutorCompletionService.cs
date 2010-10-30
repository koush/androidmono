namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExecutorCompletionService : java.lang.Object, CompletionService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExecutorCompletionService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _poll27262;
		public virtual global::java.util.concurrent.Future poll(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ExecutorCompletionService.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ExecutorCompletionService._poll27262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _poll27263;
		public virtual global::java.util.concurrent.Future poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ExecutorCompletionService.staticClass, "poll", "()Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ExecutorCompletionService._poll27263) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit27264;
		public virtual global::java.util.concurrent.Future submit(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ExecutorCompletionService.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ExecutorCompletionService._submit27264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.concurrent.Future;
		}
		public java.util.concurrent.Future submit(global::java.lang.RunnableDelegate arg0, java.lang.Object arg1)
		{
			return submit((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _submit27265;
		public virtual global::java.util.concurrent.Future submit(java.util.concurrent.Callable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ExecutorCompletionService.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ExecutorCompletionService._submit27265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _take27266;
		public virtual global::java.util.concurrent.Future take()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ExecutorCompletionService.staticClass, "take", "()Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ExecutorCompletionService._take27266) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _ExecutorCompletionService27267;
		public ExecutorCompletionService(java.util.concurrent.Executor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ExecutorCompletionService._ExecutorCompletionService27267.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ExecutorCompletionService._ExecutorCompletionService27267 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "<init>", "(Ljava/util/concurrent/Executor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._ExecutorCompletionService27267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExecutorCompletionService27268;
		public ExecutorCompletionService(java.util.concurrent.Executor arg0, java.util.concurrent.BlockingQueue arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ExecutorCompletionService._ExecutorCompletionService27268.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ExecutorCompletionService._ExecutorCompletionService27268 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/BlockingQueue;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._ExecutorCompletionService27268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ExecutorCompletionService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ExecutorCompletionService.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ExecutorCompletionService"));
		}
		internal static void InitJNI()
		{
		}
	}
}
