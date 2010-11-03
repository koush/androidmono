namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ThreadPoolExecutor : java.util.concurrent.AbstractExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ThreadPoolExecutor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class AbortPolicy : java.lang.Object, RejectedExecutionHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AbortPolicy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", ref global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public void rejectedExecution(global::java.lang.RunnableDelegate arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				rejectedExecution((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public AbortPolicy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._m1.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._m1 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._m1);
				Init(@__env, handle);
			}
			static AbortPolicy()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$AbortPolicy"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class CallerRunsPolicy : java.lang.Object, RejectedExecutionHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CallerRunsPolicy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", ref global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public void rejectedExecution(global::java.lang.RunnableDelegate arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				rejectedExecution((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public CallerRunsPolicy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._m1.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._m1 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._m1);
				Init(@__env, handle);
			}
			static CallerRunsPolicy()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$CallerRunsPolicy"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class DiscardOldestPolicy : java.lang.Object, RejectedExecutionHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected DiscardOldestPolicy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", ref global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public void rejectedExecution(global::java.lang.RunnableDelegate arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				rejectedExecution((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public DiscardOldestPolicy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._m1.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._m1 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._m1);
				Init(@__env, handle);
			}
			static DiscardOldestPolicy()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$DiscardOldestPolicy"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class DiscardPolicy : java.lang.Object, RejectedExecutionHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected DiscardPolicy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V", ref global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public void rejectedExecution(global::java.lang.RunnableDelegate arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				rejectedExecution((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public DiscardPolicy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._m1.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._m1 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._m1);
				Init(@__env, handle);
			}
			static DiscardPolicy()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$DiscardPolicy"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "shutdown", "()V", ref global::java.util.concurrent.ThreadPoolExecutor._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "finalize", "()V", ref global::java.util.concurrent.ThreadPoolExecutor._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool remove(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "remove", "(Ljava/lang/Runnable;)Z", ref global::java.util.concurrent.ThreadPoolExecutor._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool remove(global::java.lang.RunnableDelegate arg0)
		{
			return remove((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.ThreadPoolExecutor._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void execute(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "execute", "(Ljava/lang/Runnable;)V", ref global::java.util.concurrent.ThreadPoolExecutor._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void execute(global::java.lang.RunnableDelegate arg0)
		{
			execute((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void purge()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "purge", "()V", ref global::java.util.concurrent.ThreadPoolExecutor._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.util.List shutdownNow()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "shutdownNow", "()Ljava/util/List;", ref global::java.util.concurrent.ThreadPoolExecutor._m6) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool isShutdown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "isShutdown", "()Z", ref global::java.util.concurrent.ThreadPoolExecutor._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool isTerminated()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "isTerminated", "()Z", ref global::java.util.concurrent.ThreadPoolExecutor._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void allowCoreThreadTimeOut(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "allowCoreThreadTimeOut", "(Z)V", ref global::java.util.concurrent.ThreadPoolExecutor._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isTerminating()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "isTerminating", "()Z", ref global::java.util.concurrent.ThreadPoolExecutor._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setThreadFactory(java.util.concurrent.ThreadFactory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setThreadFactory", "(Ljava/util/concurrent/ThreadFactory;)V", ref global::java.util.concurrent.ThreadPoolExecutor._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.concurrent.ThreadFactory ThreadFactory
		{
			get
			{
				return getThreadFactory();
			}
			set
			{
				setThreadFactory(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.util.concurrent.ThreadFactory getThreadFactory()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.ThreadFactory>(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getThreadFactory", "()Ljava/util/concurrent/ThreadFactory;", ref global::java.util.concurrent.ThreadPoolExecutor._m12) as java.util.concurrent.ThreadFactory;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setRejectedExecutionHandler(java.util.concurrent.RejectedExecutionHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setRejectedExecutionHandler", "(Ljava/util/concurrent/RejectedExecutionHandler;)V", ref global::java.util.concurrent.ThreadPoolExecutor._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.concurrent.RejectedExecutionHandler RejectedExecutionHandler
		{
			get
			{
				return getRejectedExecutionHandler();
			}
			set
			{
				setRejectedExecutionHandler(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.util.concurrent.RejectedExecutionHandler getRejectedExecutionHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.RejectedExecutionHandler>(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getRejectedExecutionHandler", "()Ljava/util/concurrent/RejectedExecutionHandler;", ref global::java.util.concurrent.ThreadPoolExecutor._m14) as java.util.concurrent.RejectedExecutionHandler;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setCorePoolSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setCorePoolSize", "(I)V", ref global::java.util.concurrent.ThreadPoolExecutor._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CorePoolSize
		{
			get
			{
				return getCorePoolSize();
			}
			set
			{
				setCorePoolSize(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int getCorePoolSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getCorePoolSize", "()I", ref global::java.util.concurrent.ThreadPoolExecutor._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool prestartCoreThread()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "prestartCoreThread", "()Z", ref global::java.util.concurrent.ThreadPoolExecutor._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual int prestartAllCoreThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "prestartAllCoreThreads", "()I", ref global::java.util.concurrent.ThreadPoolExecutor._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool allowsCoreThreadTimeOut()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "allowsCoreThreadTimeOut", "()Z", ref global::java.util.concurrent.ThreadPoolExecutor._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setMaximumPoolSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setMaximumPoolSize", "(I)V", ref global::java.util.concurrent.ThreadPoolExecutor._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaximumPoolSize
		{
			get
			{
				return getMaximumPoolSize();
			}
			set
			{
				setMaximumPoolSize(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual int getMaximumPoolSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getMaximumPoolSize", "()I", ref global::java.util.concurrent.ThreadPoolExecutor._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setKeepAliveTime(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setKeepAliveTime", "(JLjava/util/concurrent/TimeUnit;)V", ref global::java.util.concurrent.ThreadPoolExecutor._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual long getKeepAliveTime(java.util.concurrent.TimeUnit arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getKeepAliveTime", "(Ljava/util/concurrent/TimeUnit;)J", ref global::java.util.concurrent.ThreadPoolExecutor._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.concurrent.BlockingQueue Queue
		{
			get
			{
				return getQueue();
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual global::java.util.concurrent.BlockingQueue getQueue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.BlockingQueue>(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getQueue", "()Ljava/util/concurrent/BlockingQueue;", ref global::java.util.concurrent.ThreadPoolExecutor._m24) as java.util.concurrent.BlockingQueue;
		}
		public new int PoolSize
		{
			get
			{
				return getPoolSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual int getPoolSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getPoolSize", "()I", ref global::java.util.concurrent.ThreadPoolExecutor._m25);
		}
		public new int ActiveCount
		{
			get
			{
				return getActiveCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual int getActiveCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getActiveCount", "()I", ref global::java.util.concurrent.ThreadPoolExecutor._m26);
		}
		public new int LargestPoolSize
		{
			get
			{
				return getLargestPoolSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual int getLargestPoolSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getLargestPoolSize", "()I", ref global::java.util.concurrent.ThreadPoolExecutor._m27);
		}
		public new long TaskCount
		{
			get
			{
				return getTaskCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual long getTaskCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getTaskCount", "()J", ref global::java.util.concurrent.ThreadPoolExecutor._m28);
		}
		public new long CompletedTaskCount
		{
			get
			{
				return getCompletedTaskCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual long getCompletedTaskCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getCompletedTaskCount", "()J", ref global::java.util.concurrent.ThreadPoolExecutor._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		protected virtual void beforeExecute(java.lang.Thread arg0, java.lang.Runnable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "beforeExecute", "(Ljava/lang/Thread;Ljava/lang/Runnable;)V", ref global::java.util.concurrent.ThreadPoolExecutor._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void beforeExecute(java.lang.Thread arg0, global::java.lang.RunnableDelegate arg1)
		{
			beforeExecute(arg0, (global::java.lang.RunnableDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		protected virtual void afterExecute(java.lang.Runnable arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "afterExecute", "(Ljava/lang/Runnable;Ljava/lang/Throwable;)V", ref global::java.util.concurrent.ThreadPoolExecutor._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void afterExecute(global::java.lang.RunnableDelegate arg0, java.lang.Throwable arg1)
		{
			afterExecute((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		protected virtual void terminated()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, "terminated", "()V", ref global::java.util.concurrent.ThreadPoolExecutor._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4, java.util.concurrent.ThreadFactory arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._m33.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._m33 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/ThreadFactory;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4, java.util.concurrent.RejectedExecutionHandler arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._m34.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._m34 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/RejectedExecutionHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4, java.util.concurrent.ThreadFactory arg5, java.util.concurrent.RejectedExecutionHandler arg6) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._m35.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._m35 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedExecutionHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._m36.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._m36 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		static ThreadPoolExecutor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ThreadPoolExecutor.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor"));
		}
	}
}
