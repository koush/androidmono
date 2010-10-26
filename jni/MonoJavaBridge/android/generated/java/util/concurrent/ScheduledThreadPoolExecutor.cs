namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScheduledThreadPoolExecutor : java.util.concurrent.ThreadPoolExecutor, ScheduledExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ScheduledThreadPoolExecutor()
		{
			InitJNI();
		}
		protected ScheduledThreadPoolExecutor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown27391;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._shutdown27391);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._shutdown27391);
		}
		internal static global::MonoJavaBridge.MethodId _remove27392;
		public override bool remove(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._remove27392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._remove27392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _execute27393;
		public override void execute(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._execute27393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._execute27393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _schedule27394;
		public virtual global::java.util.concurrent.ScheduledFuture schedule(java.lang.Runnable arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._schedule27394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.concurrent.ScheduledFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._schedule27394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.concurrent.ScheduledFuture;
		}
		internal static global::MonoJavaBridge.MethodId _schedule27395;
		public virtual global::java.util.concurrent.ScheduledFuture schedule(java.util.concurrent.Callable arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._schedule27395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.concurrent.ScheduledFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._schedule27395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.concurrent.ScheduledFuture;
		}
		internal static global::MonoJavaBridge.MethodId _scheduleAtFixedRate27396;
		public virtual global::java.util.concurrent.ScheduledFuture scheduleAtFixedRate(java.lang.Runnable arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._scheduleAtFixedRate27396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.concurrent.ScheduledFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._scheduleAtFixedRate27396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.concurrent.ScheduledFuture;
		}
		internal static global::MonoJavaBridge.MethodId _submit27397;
		public override global::java.util.concurrent.Future submit(java.util.concurrent.Callable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit27398;
		public override global::java.util.concurrent.Future submit(java.lang.Runnable arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit27399;
		public override global::java.util.concurrent.Future submit(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _shutdownNow27400;
		public override global::java.util.List shutdownNow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._shutdownNow27400)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._shutdownNow27400)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _scheduleWithFixedDelay27401;
		public virtual global::java.util.concurrent.ScheduledFuture scheduleWithFixedDelay(java.lang.Runnable arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._scheduleWithFixedDelay27401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.concurrent.ScheduledFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._scheduleWithFixedDelay27401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.concurrent.ScheduledFuture;
		}
		public new global::java.util.concurrent.BlockingQueue Queue
		{
			get
			{
				return getQueue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueue27402;
		public override global::java.util.concurrent.BlockingQueue getQueue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.BlockingQueue>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._getQueue27402)) as java.util.concurrent.BlockingQueue;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.BlockingQueue>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._getQueue27402)) as java.util.concurrent.BlockingQueue;
		}
		internal static global::MonoJavaBridge.MethodId _setContinueExistingPeriodicTasksAfterShutdownPolicy27403;
		public virtual void setContinueExistingPeriodicTasksAfterShutdownPolicy(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._setContinueExistingPeriodicTasksAfterShutdownPolicy27403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._setContinueExistingPeriodicTasksAfterShutdownPolicy27403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ContinueExistingPeriodicTasksAfterShutdownPolicy
		{
			get
			{
				return getContinueExistingPeriodicTasksAfterShutdownPolicy();
			}
			set
			{
				setContinueExistingPeriodicTasksAfterShutdownPolicy(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContinueExistingPeriodicTasksAfterShutdownPolicy27404;
		public virtual bool getContinueExistingPeriodicTasksAfterShutdownPolicy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._getContinueExistingPeriodicTasksAfterShutdownPolicy27404);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._getContinueExistingPeriodicTasksAfterShutdownPolicy27404);
		}
		internal static global::MonoJavaBridge.MethodId _setExecuteExistingDelayedTasksAfterShutdownPolicy27405;
		public virtual void setExecuteExistingDelayedTasksAfterShutdownPolicy(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._setExecuteExistingDelayedTasksAfterShutdownPolicy27405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._setExecuteExistingDelayedTasksAfterShutdownPolicy27405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ExecuteExistingDelayedTasksAfterShutdownPolicy
		{
			get
			{
				return getExecuteExistingDelayedTasksAfterShutdownPolicy();
			}
			set
			{
				setExecuteExistingDelayedTasksAfterShutdownPolicy(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExecuteExistingDelayedTasksAfterShutdownPolicy27406;
		public virtual bool getExecuteExistingDelayedTasksAfterShutdownPolicy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor._getExecuteExistingDelayedTasksAfterShutdownPolicy27406);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._getExecuteExistingDelayedTasksAfterShutdownPolicy27406);
		}
		internal static global::MonoJavaBridge.MethodId _ScheduledThreadPoolExecutor27407;
		public ScheduledThreadPoolExecutor(int arg0, java.util.concurrent.RejectedExecutionHandler arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScheduledThreadPoolExecutor27408;
		public ScheduledThreadPoolExecutor(int arg0, java.util.concurrent.ThreadFactory arg1, java.util.concurrent.RejectedExecutionHandler arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScheduledThreadPoolExecutor27409;
		public ScheduledThreadPoolExecutor(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScheduledThreadPoolExecutor27410;
		public ScheduledThreadPoolExecutor(int arg0, java.util.concurrent.ThreadFactory arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ScheduledThreadPoolExecutor"));
			global::java.util.concurrent.ScheduledThreadPoolExecutor._shutdown27391 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "shutdown", "()V");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._remove27392 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "remove", "(Ljava/lang/Runnable;)Z");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._execute27393 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "execute", "(Ljava/lang/Runnable;)V");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._schedule27394 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._schedule27395 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "schedule", "(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._scheduleAtFixedRate27396 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27397 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27398 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27399 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._shutdownNow27400 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "shutdownNow", "()Ljava/util/List;");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._scheduleWithFixedDelay27401 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._getQueue27402 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "getQueue", "()Ljava/util/concurrent/BlockingQueue;");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._setContinueExistingPeriodicTasksAfterShutdownPolicy27403 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "setContinueExistingPeriodicTasksAfterShutdownPolicy", "(Z)V");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._getContinueExistingPeriodicTasksAfterShutdownPolicy27404 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "getContinueExistingPeriodicTasksAfterShutdownPolicy", "()Z");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._setExecuteExistingDelayedTasksAfterShutdownPolicy27405 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "setExecuteExistingDelayedTasksAfterShutdownPolicy", "(Z)V");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._getExecuteExistingDelayedTasksAfterShutdownPolicy27406 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "getExecuteExistingDelayedTasksAfterShutdownPolicy", "()Z");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27407 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "<init>", "(ILjava/util/concurrent/RejectedExecutionHandler;)V");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27408 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "<init>", "(ILjava/util/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedExecutionHandler;)V");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27409 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27410 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "<init>", "(ILjava/util/concurrent/ThreadFactory;)V");
		}
	}
}
