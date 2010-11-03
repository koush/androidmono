namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScheduledThreadPoolExecutor : java.util.concurrent.ThreadPoolExecutor, ScheduledExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ScheduledThreadPoolExecutor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "shutdown", "()V", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool remove(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "remove", "(Ljava/lang/Runnable;)Z", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool remove(global::java.lang.RunnableDelegate arg0)
		{
			return remove((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void execute(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "execute", "(Ljava/lang/Runnable;)V", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void execute(global::java.lang.RunnableDelegate arg0)
		{
			execute((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.util.concurrent.ScheduledFuture schedule(java.lang.Runnable arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.ScheduledFuture>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.util.concurrent.ScheduledFuture;
		}
		public java.util.concurrent.ScheduledFuture schedule(global::java.lang.RunnableDelegate arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return schedule((global::java.lang.RunnableDelegateWrapper)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.util.concurrent.ScheduledFuture schedule(java.util.concurrent.Callable arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.ScheduledFuture>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "schedule", "(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.util.concurrent.ScheduledFuture;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.util.concurrent.ScheduledFuture scheduleAtFixedRate(java.lang.Runnable arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.ScheduledFuture>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.util.concurrent.ScheduledFuture;
		}
		public java.util.concurrent.ScheduledFuture scheduleAtFixedRate(global::java.lang.RunnableDelegate arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			return scheduleAtFixedRate((global::java.lang.RunnableDelegateWrapper)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.util.concurrent.Future submit(java.util.concurrent.Callable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.util.concurrent.Future submit(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.concurrent.Future;
		}
		public java.util.concurrent.Future submit(global::java.lang.RunnableDelegate arg0, java.lang.Object arg1)
		{
			return submit((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.util.concurrent.Future submit(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.concurrent.Future;
		}
		public java.util.concurrent.Future submit(global::java.lang.RunnableDelegate arg0)
		{
			return submit((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.util.List shutdownNow()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "shutdownNow", "()Ljava/util/List;", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m9) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.util.concurrent.ScheduledFuture scheduleWithFixedDelay(java.lang.Runnable arg0, long arg1, long arg2, java.util.concurrent.TimeUnit arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.ScheduledFuture>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.util.concurrent.ScheduledFuture;
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
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::java.util.concurrent.BlockingQueue getQueue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.BlockingQueue>(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "getQueue", "()Ljava/util/concurrent/BlockingQueue;", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m11) as java.util.concurrent.BlockingQueue;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setContinueExistingPeriodicTasksAfterShutdownPolicy(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "setContinueExistingPeriodicTasksAfterShutdownPolicy", "(Z)V", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool getContinueExistingPeriodicTasksAfterShutdownPolicy()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "getContinueExistingPeriodicTasksAfterShutdownPolicy", "()Z", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setExecuteExistingDelayedTasksAfterShutdownPolicy(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "setExecuteExistingDelayedTasksAfterShutdownPolicy", "(Z)V", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool getExecuteExistingDelayedTasksAfterShutdownPolicy()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "getExecuteExistingDelayedTasksAfterShutdownPolicy", "()Z", ref global::java.util.concurrent.ScheduledThreadPoolExecutor._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public ScheduledThreadPoolExecutor(int arg0, java.util.concurrent.RejectedExecutionHandler arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._m16.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._m16 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "<init>", "(ILjava/util/concurrent/RejectedExecutionHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public ScheduledThreadPoolExecutor(int arg0, java.util.concurrent.ThreadFactory arg1, java.util.concurrent.RejectedExecutionHandler arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._m17.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._m17 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "<init>", "(ILjava/util/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedExecutionHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public ScheduledThreadPoolExecutor(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._m18.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._m18 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public ScheduledThreadPoolExecutor(int arg0, java.util.concurrent.ThreadFactory arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ScheduledThreadPoolExecutor._m19.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ScheduledThreadPoolExecutor._m19 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, "<init>", "(ILjava/util/concurrent/ThreadFactory;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ScheduledThreadPoolExecutor.staticClass, global::java.util.concurrent.ScheduledThreadPoolExecutor._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ScheduledThreadPoolExecutor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ScheduledThreadPoolExecutor.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ScheduledThreadPoolExecutor"));
		}
	}
}
