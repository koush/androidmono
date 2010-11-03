namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExecutorCompletionService : java.lang.Object, CompletionService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExecutorCompletionService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.util.concurrent.Future poll(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ExecutorCompletionService.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ExecutorCompletionService._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.util.concurrent.Future poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ExecutorCompletionService.staticClass, "poll", "()Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ExecutorCompletionService._m1) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.util.concurrent.Future submit(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ExecutorCompletionService.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ExecutorCompletionService._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.concurrent.Future;
		}
		public java.util.concurrent.Future submit(global::java.lang.RunnableDelegate arg0, java.lang.Object arg1)
		{
			return submit((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.util.concurrent.Future submit(java.util.concurrent.Callable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ExecutorCompletionService.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ExecutorCompletionService._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.util.concurrent.Future take()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ExecutorCompletionService.staticClass, "take", "()Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ExecutorCompletionService._m4) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ExecutorCompletionService(java.util.concurrent.Executor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ExecutorCompletionService._m5.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ExecutorCompletionService._m5 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "<init>", "(Ljava/util/concurrent/Executor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ExecutorCompletionService(java.util.concurrent.Executor arg0, java.util.concurrent.BlockingQueue arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ExecutorCompletionService._m6.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ExecutorCompletionService._m6 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/BlockingQueue;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ExecutorCompletionService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ExecutorCompletionService.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ExecutorCompletionService"));
		}
	}
}
