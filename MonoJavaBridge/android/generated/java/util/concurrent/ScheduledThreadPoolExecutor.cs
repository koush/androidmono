namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScheduledThreadPoolExecutor : java.util.concurrent.ThreadPoolExecutor, ScheduledExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ScheduledThreadPoolExecutor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown27392;
		public override void shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._shutdown27392.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._shutdown27392 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "shutdown", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._shutdown27392);
		}
		internal static global::MonoJavaBridge.MethodId _remove27393;
		public override bool remove(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._remove27393.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._remove27393 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "remove", "(Ljava/lang/Runnable;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._remove27393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool remove(global::java.lang.RunnableDelegate arg0)
		{
			return remove((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _execute27394;
		public override void execute(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._execute27394.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._execute27394 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "execute", "(Ljava/lang/Runnable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._execute27394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void execute(global::java.lang.RunnableDelegate arg0)
		{
			execute((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _schedule27395;
		public virtual global::java.util.concurrent.ScheduledFuture schedule(java.lang.Runnable arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._schedule27395.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._schedule27395 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.ScheduledFuture>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._schedule27395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.util.concurrent.ScheduledFuture;
		}
		public java.util.concurrent.ScheduledFuture schedule(global::java.lang.RunnableDelegate arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return schedule((global::java.lang.RunnableDelegateWrapper)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _schedule27396;
		public virtual global::java.util.concurrent.ScheduledFuture schedule(java.util.concurrent.Callable arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._schedule27396.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._schedule27396 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "schedule", "(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.ScheduledFuture>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._schedule27396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.util.concurrent.ScheduledFuture;
		}
		internal static global::MonoJavaBridge.MethodId _scheduleAtFixedRate27397;
		public virtual global::java.util.concurrent.ScheduledFuture scheduleAtFixedRate(java.lang.Runnable arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._scheduleAtFixedRate27397.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._scheduleAtFixedRate27397 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.ScheduledFuture>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._scheduleAtFixedRate27397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.util.concurrent.ScheduledFuture;
		}
		public java.util.concurrent.ScheduledFuture scheduleAtFixedRate(global::java.lang.RunnableDelegate arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			return scheduleAtFixedRate((global::java.lang.RunnableDelegateWrapper)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _submit27398;
		public override global::java.util.concurrent.Future submit(java.util.concurrent.Callable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27398.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27398 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit27399;
		public override global::java.util.concurrent.Future submit(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27399.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27399 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.concurrent.Future;
		}
		public java.util.concurrent.Future submit(global::java.lang.RunnableDelegate arg0, java.lang.Object arg1)
		{
			return submit((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _submit27400;
		public override global::java.util.concurrent.Future submit(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27400.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27400 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._submit27400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.concurrent.Future;
		}
		public java.util.concurrent.Future submit(global::java.lang.RunnableDelegate arg0)
		{
			return submit((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownNow27401;
		public override global::java.util.List shutdownNow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._shutdownNow27401.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._shutdownNow27401 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "shutdownNow", "()Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._shutdownNow27401) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _scheduleWithFixedDelay27402;
		public virtual global::java.util.concurrent.ScheduledFuture scheduleWithFixedDelay(java.lang.Runnable arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._scheduleWithFixedDelay27402.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._scheduleWithFixedDelay27402 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.ScheduledFuture>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._scheduleWithFixedDelay27402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.util.concurrent.ScheduledFuture;
		}
		public java.util.concurrent.ScheduledFuture scheduleWithFixedDelay(global::java.lang.RunnableDelegate arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			return scheduleWithFixedDelay((global::java.lang.RunnableDelegateWrapper)arg0, arg1, arg2, arg3);
		}
		public new global::java.util.concurrent.BlockingQueue Queue
		{
			get
			{
				return getQueue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueue27403;
		public override global::java.util.concurrent.BlockingQueue getQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._getQueue27403.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._getQueue27403 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "getQueue", "()Ljava/util/concurrent/BlockingQueue;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.BlockingQueue>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._getQueue27403) as java.util.concurrent.BlockingQueue;
		}
		internal static global::MonoJavaBridge.MethodId _setContinueExistingPeriodicTasksAfterShutdownPolicy27404;
		public virtual void setContinueExistingPeriodicTasksAfterShutdownPolicy(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._setContinueExistingPeriodicTasksAfterShutdownPolicy27404.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._setContinueExistingPeriodicTasksAfterShutdownPolicy27404 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "setContinueExistingPeriodicTasksAfterShutdownPolicy", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._setContinueExistingPeriodicTasksAfterShutdownPolicy27404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getContinueExistingPeriodicTasksAfterShutdownPolicy27405;
		public virtual bool getContinueExistingPeriodicTasksAfterShutdownPolicy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._getContinueExistingPeriodicTasksAfterShutdownPolicy27405.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._getContinueExistingPeriodicTasksAfterShutdownPolicy27405 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "getContinueExistingPeriodicTasksAfterShutdownPolicy", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._getContinueExistingPeriodicTasksAfterShutdownPolicy27405);
		}
		internal static global::MonoJavaBridge.MethodId _setExecuteExistingDelayedTasksAfterShutdownPolicy27406;
		public virtual void setExecuteExistingDelayedTasksAfterShutdownPolicy(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._setExecuteExistingDelayedTasksAfterShutdownPolicy27406.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._setExecuteExistingDelayedTasksAfterShutdownPolicy27406 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "setExecuteExistingDelayedTasksAfterShutdownPolicy", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._setExecuteExistingDelayedTasksAfterShutdownPolicy27406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getExecuteExistingDelayedTasksAfterShutdownPolicy27407;
		public virtual bool getExecuteExistingDelayedTasksAfterShutdownPolicy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._getExecuteExistingDelayedTasksAfterShutdownPolicy27407.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._getExecuteExistingDelayedTasksAfterShutdownPolicy27407 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "getExecuteExistingDelayedTasksAfterShutdownPolicy", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._getExecuteExistingDelayedTasksAfterShutdownPolicy27407);
		}
		internal static global::MonoJavaBridge.MethodId _ScheduledThreadPoolExecutor27408;
		public ScheduledThreadPoolExecutor(int arg0, java.util.concurrent.RejectedExecutionHandler arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27408.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27408 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "<init>", "(ILjava/util/concurrent/RejectedExecutionHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScheduledThreadPoolExecutor27409;
		public ScheduledThreadPoolExecutor(int arg0, java.util.concurrent.ThreadFactory arg1, java.util.concurrent.RejectedExecutionHandler arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27409.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27409 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "<init>", "(ILjava/util/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedExecutionHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScheduledThreadPoolExecutor27410;
		public ScheduledThreadPoolExecutor(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27410.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27410 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScheduledThreadPoolExecutor27411;
		public ScheduledThreadPoolExecutor(int arg0, java.util.concurrent.ThreadFactory arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27411.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27411 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "<init>", "(ILjava/util/concurrent/ThreadFactory;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._ScheduledThreadPoolExecutor27411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ScheduledThreadPoolExecutor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ScheduledThreadPoolExecutor"));
		}
		internal static void InitJNI()
		{
		}
	}
}
