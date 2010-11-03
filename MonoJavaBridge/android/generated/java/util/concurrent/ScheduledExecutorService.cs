namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.ScheduledExecutorService_))]
	public partial interface ScheduledExecutorService : ExecutorService
	{
		global::java.util.concurrent.ScheduledFuture schedule(java.lang.Runnable arg0, long arg1, java.util.concurrent.TimeUnit arg2);
		global::java.util.concurrent.ScheduledFuture schedule(java.util.concurrent.Callable arg0, long arg1, java.util.concurrent.TimeUnit arg2);
		global::java.util.concurrent.ScheduledFuture scheduleAtFixedRate(java.lang.Runnable arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3);
		global::java.util.concurrent.ScheduledFuture scheduleWithFixedDelay(java.lang.Runnable arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.ScheduledExecutorService))]
	internal sealed partial class ScheduledExecutorService_ : java.lang.Object, ScheduledExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ScheduledExecutorService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.util.concurrent.ScheduledFuture java.util.concurrent.ScheduledExecutorService.schedule(java.lang.Runnable arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.ScheduledFuture>(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", ref global::java.util.concurrent.ScheduledExecutorService_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.util.concurrent.ScheduledFuture;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.util.concurrent.ScheduledFuture java.util.concurrent.ScheduledExecutorService.schedule(java.util.concurrent.Callable arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.ScheduledFuture>(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "schedule", "(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", ref global::java.util.concurrent.ScheduledExecutorService_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.util.concurrent.ScheduledFuture;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.util.concurrent.ScheduledFuture java.util.concurrent.ScheduledExecutorService.scheduleAtFixedRate(java.lang.Runnable arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.ScheduledFuture>(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", ref global::java.util.concurrent.ScheduledExecutorService_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.util.concurrent.ScheduledFuture;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.util.concurrent.ScheduledFuture java.util.concurrent.ScheduledExecutorService.scheduleWithFixedDelay(java.lang.Runnable arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.ScheduledFuture>(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", ref global::java.util.concurrent.ScheduledExecutorService_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.util.concurrent.ScheduledFuture;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void java.util.concurrent.ExecutorService.shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "shutdown", "()V", ref global::java.util.concurrent.ScheduledExecutorService_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool java.util.concurrent.ExecutorService.awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.ScheduledExecutorService_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::java.util.concurrent.Future java.util.concurrent.ExecutorService.submit(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ScheduledExecutorService_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.util.concurrent.Future java.util.concurrent.ExecutorService.submit(java.util.concurrent.Callable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ScheduledExecutorService_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.util.concurrent.Future java.util.concurrent.ExecutorService.submit(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ScheduledExecutorService_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.lang.Object java.util.concurrent.ExecutorService.invokeAny(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", ref global::java.util.concurrent.ScheduledExecutorService_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.lang.Object java.util.concurrent.ExecutorService.invokeAny(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;", ref global::java.util.concurrent.ScheduledExecutorService_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::java.util.List java.util.concurrent.ExecutorService.invokeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "invokeAll", "(Ljava/util/Collection;)Ljava/util/List;", ref global::java.util.concurrent.ScheduledExecutorService_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::java.util.List java.util.concurrent.ExecutorService.invokeAll(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;", ref global::java.util.concurrent.ScheduledExecutorService_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		global::java.util.List java.util.concurrent.ExecutorService.shutdownNow()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "shutdownNow", "()Ljava/util/List;", ref global::java.util.concurrent.ScheduledExecutorService_._m13) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		bool java.util.concurrent.ExecutorService.isShutdown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "isShutdown", "()Z", ref global::java.util.concurrent.ScheduledExecutorService_._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		bool java.util.concurrent.ExecutorService.isTerminated()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "isTerminated", "()Z", ref global::java.util.concurrent.ScheduledExecutorService_._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void java.util.concurrent.Executor.execute(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ScheduledExecutorService_.staticClass, "execute", "(Ljava/lang/Runnable;)V", ref global::java.util.concurrent.ScheduledExecutorService_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ScheduledExecutorService_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ScheduledExecutorService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ScheduledExecutorService"));
		}
	}
}
