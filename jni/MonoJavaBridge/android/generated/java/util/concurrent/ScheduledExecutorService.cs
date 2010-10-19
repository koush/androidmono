namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.ScheduledExecutorService_))]
	public interface ScheduledExecutorService : ExecutorService
	{
		global::java.util.concurrent.ScheduledFuture schedule(java.lang.Runnable arg0, long arg1, java.util.concurrent.TimeUnit arg2);
		global::java.util.concurrent.ScheduledFuture schedule(java.util.concurrent.Callable arg0, long arg1, java.util.concurrent.TimeUnit arg2);
		global::java.util.concurrent.ScheduledFuture scheduleAtFixedRate(java.lang.Runnable arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3);
		global::java.util.concurrent.ScheduledFuture scheduleWithFixedDelay(java.lang.Runnable arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.ScheduledExecutorService))]
	public sealed partial class ScheduledExecutorService_ : java.lang.Object, ScheduledExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ScheduledExecutorService_()
		{
			InitJNI();
		}
		internal ScheduledExecutorService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _schedule21419;
		 global::java.util.concurrent.ScheduledFuture java.util.concurrent.ScheduledExecutorService.schedule(java.lang.Runnable arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._schedule21419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.concurrent.ScheduledFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._schedule21419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.concurrent.ScheduledFuture;
		}
		internal static global::MonoJavaBridge.MethodId _schedule21420;
		 global::java.util.concurrent.ScheduledFuture java.util.concurrent.ScheduledExecutorService.schedule(java.util.concurrent.Callable arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._schedule21420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.concurrent.ScheduledFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._schedule21420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.concurrent.ScheduledFuture;
		}
		internal static global::MonoJavaBridge.MethodId _scheduleAtFixedRate21421;
		 global::java.util.concurrent.ScheduledFuture java.util.concurrent.ScheduledExecutorService.scheduleAtFixedRate(java.lang.Runnable arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._scheduleAtFixedRate21421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.concurrent.ScheduledFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._scheduleAtFixedRate21421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.concurrent.ScheduledFuture;
		}
		internal static global::MonoJavaBridge.MethodId _scheduleWithFixedDelay21422;
		 global::java.util.concurrent.ScheduledFuture java.util.concurrent.ScheduledExecutorService.scheduleWithFixedDelay(java.lang.Runnable arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._scheduleWithFixedDelay21422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.concurrent.ScheduledFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._scheduleWithFixedDelay21422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.concurrent.ScheduledFuture;
		}
		internal static global::MonoJavaBridge.MethodId _shutdown21423;
		 void java.util.concurrent.ExecutorService.shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._shutdown21423);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._shutdown21423);
		}
		internal static global::MonoJavaBridge.MethodId _awaitTermination21424;
		 bool java.util.concurrent.ExecutorService.awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._awaitTermination21424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._awaitTermination21424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _submit21425;
		 global::java.util.concurrent.Future java.util.concurrent.ExecutorService.submit(java.lang.Runnable arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._submit21425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._submit21425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit21426;
		 global::java.util.concurrent.Future java.util.concurrent.ExecutorService.submit(java.util.concurrent.Callable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._submit21426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._submit21426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit21427;
		 global::java.util.concurrent.Future java.util.concurrent.ExecutorService.submit(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._submit21427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._submit21427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAny21428;
		 global::java.lang.Object java.util.concurrent.ExecutorService.invokeAny(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._invokeAny21428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._invokeAny21428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAny21429;
		 global::java.lang.Object java.util.concurrent.ExecutorService.invokeAny(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._invokeAny21429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._invokeAny21429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAll21430;
		 global::java.util.List java.util.concurrent.ExecutorService.invokeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._invokeAll21430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._invokeAll21430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAll21431;
		 global::java.util.List java.util.concurrent.ExecutorService.invokeAll(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._invokeAll21431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._invokeAll21431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _shutdownNow21432;
		 global::java.util.List java.util.concurrent.ExecutorService.shutdownNow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._shutdownNow21432)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._shutdownNow21432)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _isShutdown21433;
		 bool java.util.concurrent.ExecutorService.isShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._isShutdown21433);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._isShutdown21433);
		}
		internal static global::MonoJavaBridge.MethodId _isTerminated21434;
		 bool java.util.concurrent.ExecutorService.isTerminated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._isTerminated21434);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._isTerminated21434);
		}
		internal static global::MonoJavaBridge.MethodId _execute21435;
		 void java.util.concurrent.Executor.execute(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_._execute21435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ScheduledExecutorService_.staticClass, global::java.util.concurrent.ScheduledExecutorService_._execute21435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ScheduledExecutorService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ScheduledExecutorService"));
			global::java.util.concurrent.ScheduledExecutorService_._schedule21419 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			global::java.util.concurrent.ScheduledExecutorService_._schedule21420 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "schedule", "(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			global::java.util.concurrent.ScheduledExecutorService_._scheduleAtFixedRate21421 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			global::java.util.concurrent.ScheduledExecutorService_._scheduleWithFixedDelay21422 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			global::java.util.concurrent.ScheduledExecutorService_._shutdown21423 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "shutdown", "()V");
			global::java.util.concurrent.ScheduledExecutorService_._awaitTermination21424 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.ScheduledExecutorService_._submit21425 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ScheduledExecutorService_._submit21426 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ScheduledExecutorService_._submit21427 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ScheduledExecutorService_._invokeAny21428 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.ScheduledExecutorService_._invokeAny21429 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;");
			global::java.util.concurrent.ScheduledExecutorService_._invokeAll21430 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "invokeAll", "(Ljava/util/Collection;)Ljava/util/List;");
			global::java.util.concurrent.ScheduledExecutorService_._invokeAll21431 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;");
			global::java.util.concurrent.ScheduledExecutorService_._shutdownNow21432 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "shutdownNow", "()Ljava/util/List;");
			global::java.util.concurrent.ScheduledExecutorService_._isShutdown21433 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "isShutdown", "()Z");
			global::java.util.concurrent.ScheduledExecutorService_._isTerminated21434 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "isTerminated", "()Z");
			global::java.util.concurrent.ScheduledExecutorService_._execute21435 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledExecutorService_.staticClass, "execute", "(Ljava/lang/Runnable;)V");
		}
	}
}
