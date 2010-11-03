namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.ExecutorService_))]
	public partial interface ExecutorService : Executor
	{
		void shutdown();
		bool awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1);
		global::java.util.concurrent.Future submit(java.lang.Runnable arg0, java.lang.Object arg1);
		global::java.util.concurrent.Future submit(java.util.concurrent.Callable arg0);
		global::java.util.concurrent.Future submit(java.lang.Runnable arg0);
		global::java.lang.Object invokeAny(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2);
		global::java.lang.Object invokeAny(java.util.Collection arg0);
		global::java.util.List invokeAll(java.util.Collection arg0);
		global::java.util.List invokeAll(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2);
		global::java.util.List shutdownNow();
		bool isShutdown();
		bool isTerminated();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.ExecutorService))]
	internal sealed partial class ExecutorService_ : java.lang.Object, ExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ExecutorService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void java.util.concurrent.ExecutorService.shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ExecutorService_.staticClass, "shutdown", "()V", ref global::java.util.concurrent.ExecutorService_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool java.util.concurrent.ExecutorService.awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ExecutorService_.staticClass, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.ExecutorService_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.util.concurrent.Future java.util.concurrent.ExecutorService.submit(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ExecutorService_.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ExecutorService_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.util.concurrent.Future java.util.concurrent.ExecutorService.submit(java.util.concurrent.Callable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ExecutorService_.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ExecutorService_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.util.concurrent.Future java.util.concurrent.ExecutorService.submit(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ExecutorService_.staticClass, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ExecutorService_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.lang.Object java.util.concurrent.ExecutorService.invokeAny(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ExecutorService_.staticClass, "invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", ref global::java.util.concurrent.ExecutorService_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::java.lang.Object java.util.concurrent.ExecutorService.invokeAny(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ExecutorService_.staticClass, "invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;", ref global::java.util.concurrent.ExecutorService_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.util.List java.util.concurrent.ExecutorService.invokeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.ExecutorService_.staticClass, "invokeAll", "(Ljava/util/Collection;)Ljava/util/List;", ref global::java.util.concurrent.ExecutorService_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.util.List java.util.concurrent.ExecutorService.invokeAll(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.ExecutorService_.staticClass, "invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;", ref global::java.util.concurrent.ExecutorService_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.util.List java.util.concurrent.ExecutorService.shutdownNow()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.ExecutorService_.staticClass, "shutdownNow", "()Ljava/util/List;", ref global::java.util.concurrent.ExecutorService_._m9) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		bool java.util.concurrent.ExecutorService.isShutdown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ExecutorService_.staticClass, "isShutdown", "()Z", ref global::java.util.concurrent.ExecutorService_._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		bool java.util.concurrent.ExecutorService.isTerminated()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ExecutorService_.staticClass, "isTerminated", "()Z", ref global::java.util.concurrent.ExecutorService_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void java.util.concurrent.Executor.execute(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ExecutorService_.staticClass, "execute", "(Ljava/lang/Runnable;)V", ref global::java.util.concurrent.ExecutorService_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ExecutorService_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ExecutorService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ExecutorService"));
		}
	}
}
