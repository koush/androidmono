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
			internal static global::MonoJavaBridge.MethodId _rejectedExecution27456;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._rejectedExecution27456.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._rejectedExecution27456 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._rejectedExecution27456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public void rejectedExecution(global::java.lang.RunnableDelegate arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				rejectedExecution((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _AbortPolicy27457;
			public AbortPolicy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._AbortPolicy27457.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._AbortPolicy27457 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._AbortPolicy27457);
				Init(@__env, handle);
			}
			static AbortPolicy()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$AbortPolicy"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class CallerRunsPolicy : java.lang.Object, RejectedExecutionHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CallerRunsPolicy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _rejectedExecution27458;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._rejectedExecution27458.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._rejectedExecution27458 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._rejectedExecution27458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public void rejectedExecution(global::java.lang.RunnableDelegate arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				rejectedExecution((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _CallerRunsPolicy27459;
			public CallerRunsPolicy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._CallerRunsPolicy27459.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._CallerRunsPolicy27459 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._CallerRunsPolicy27459);
				Init(@__env, handle);
			}
			static CallerRunsPolicy()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$CallerRunsPolicy"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class DiscardOldestPolicy : java.lang.Object, RejectedExecutionHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected DiscardOldestPolicy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _rejectedExecution27460;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._rejectedExecution27460.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._rejectedExecution27460 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._rejectedExecution27460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public void rejectedExecution(global::java.lang.RunnableDelegate arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				rejectedExecution((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _DiscardOldestPolicy27461;
			public DiscardOldestPolicy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._DiscardOldestPolicy27461.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._DiscardOldestPolicy27461 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._DiscardOldestPolicy27461);
				Init(@__env, handle);
			}
			static DiscardOldestPolicy()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$DiscardOldestPolicy"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class DiscardPolicy : java.lang.Object, RejectedExecutionHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected DiscardPolicy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _rejectedExecution27462;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._rejectedExecution27462.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._rejectedExecution27462 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._rejectedExecution27462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public void rejectedExecution(global::java.lang.RunnableDelegate arg0, java.util.concurrent.ThreadPoolExecutor arg1)
			{
				rejectedExecution((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _DiscardPolicy27463;
			public DiscardPolicy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._DiscardPolicy27463.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._DiscardPolicy27463 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._DiscardPolicy27463);
				Init(@__env, handle);
			}
			static DiscardPolicy()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$DiscardPolicy"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _shutdown27464;
		public override void shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._shutdown27464.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._shutdown27464 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "shutdown", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._shutdown27464);
		}
		internal static global::MonoJavaBridge.MethodId _finalize27465;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._finalize27465.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._finalize27465 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "finalize", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._finalize27465);
		}
		internal static global::MonoJavaBridge.MethodId _remove27466;
		public virtual bool remove(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._remove27466.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._remove27466 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "remove", "(Ljava/lang/Runnable;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._remove27466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool remove(global::java.lang.RunnableDelegate arg0)
		{
			return remove((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _awaitTermination27467;
		public override bool awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._awaitTermination27467.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._awaitTermination27467 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._awaitTermination27467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute27468;
		public override void execute(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._execute27468.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._execute27468 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "execute", "(Ljava/lang/Runnable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._execute27468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void execute(global::java.lang.RunnableDelegate arg0)
		{
			execute((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _purge27469;
		public virtual void purge()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._purge27469.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._purge27469 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "purge", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._purge27469);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownNow27470;
		public override global::java.util.List shutdownNow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._shutdownNow27470.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._shutdownNow27470 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "shutdownNow", "()Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._shutdownNow27470) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _isShutdown27471;
		public override bool isShutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._isShutdown27471.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._isShutdown27471 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "isShutdown", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._isShutdown27471);
		}
		internal static global::MonoJavaBridge.MethodId _isTerminated27472;
		public override bool isTerminated()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._isTerminated27472.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._isTerminated27472 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "isTerminated", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._isTerminated27472);
		}
		internal static global::MonoJavaBridge.MethodId _allowCoreThreadTimeOut27473;
		public virtual void allowCoreThreadTimeOut(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._allowCoreThreadTimeOut27473.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._allowCoreThreadTimeOut27473 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "allowCoreThreadTimeOut", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._allowCoreThreadTimeOut27473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTerminating27474;
		public virtual bool isTerminating()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._isTerminating27474.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._isTerminating27474 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "isTerminating", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._isTerminating27474);
		}
		internal static global::MonoJavaBridge.MethodId _setThreadFactory27475;
		public virtual void setThreadFactory(java.util.concurrent.ThreadFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._setThreadFactory27475.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._setThreadFactory27475 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setThreadFactory", "(Ljava/util/concurrent/ThreadFactory;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._setThreadFactory27475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getThreadFactory27476;
		public virtual global::java.util.concurrent.ThreadFactory getThreadFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._getThreadFactory27476.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._getThreadFactory27476 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.ThreadFactory>(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getThreadFactory27476) as java.util.concurrent.ThreadFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setRejectedExecutionHandler27477;
		public virtual void setRejectedExecutionHandler(java.util.concurrent.RejectedExecutionHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._setRejectedExecutionHandler27477.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._setRejectedExecutionHandler27477 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setRejectedExecutionHandler", "(Ljava/util/concurrent/RejectedExecutionHandler;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._setRejectedExecutionHandler27477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getRejectedExecutionHandler27478;
		public virtual global::java.util.concurrent.RejectedExecutionHandler getRejectedExecutionHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._getRejectedExecutionHandler27478.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._getRejectedExecutionHandler27478 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getRejectedExecutionHandler", "()Ljava/util/concurrent/RejectedExecutionHandler;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.RejectedExecutionHandler>(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getRejectedExecutionHandler27478) as java.util.concurrent.RejectedExecutionHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setCorePoolSize27479;
		public virtual void setCorePoolSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._setCorePoolSize27479.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._setCorePoolSize27479 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setCorePoolSize", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._setCorePoolSize27479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCorePoolSize27480;
		public virtual int getCorePoolSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._getCorePoolSize27480.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._getCorePoolSize27480 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getCorePoolSize", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getCorePoolSize27480);
		}
		internal static global::MonoJavaBridge.MethodId _prestartCoreThread27481;
		public virtual bool prestartCoreThread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._prestartCoreThread27481.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._prestartCoreThread27481 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "prestartCoreThread", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._prestartCoreThread27481);
		}
		internal static global::MonoJavaBridge.MethodId _prestartAllCoreThreads27482;
		public virtual int prestartAllCoreThreads()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._prestartAllCoreThreads27482.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._prestartAllCoreThreads27482 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "prestartAllCoreThreads", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._prestartAllCoreThreads27482);
		}
		internal static global::MonoJavaBridge.MethodId _allowsCoreThreadTimeOut27483;
		public virtual bool allowsCoreThreadTimeOut()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._allowsCoreThreadTimeOut27483.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._allowsCoreThreadTimeOut27483 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "allowsCoreThreadTimeOut", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._allowsCoreThreadTimeOut27483);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumPoolSize27484;
		public virtual void setMaximumPoolSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._setMaximumPoolSize27484.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._setMaximumPoolSize27484 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setMaximumPoolSize", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._setMaximumPoolSize27484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMaximumPoolSize27485;
		public virtual int getMaximumPoolSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._getMaximumPoolSize27485.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._getMaximumPoolSize27485 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getMaximumPoolSize", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getMaximumPoolSize27485);
		}
		internal static global::MonoJavaBridge.MethodId _setKeepAliveTime27486;
		public virtual void setKeepAliveTime(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._setKeepAliveTime27486.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._setKeepAliveTime27486 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setKeepAliveTime", "(JLjava/util/concurrent/TimeUnit;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._setKeepAliveTime27486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getKeepAliveTime27487;
		public virtual long getKeepAliveTime(java.util.concurrent.TimeUnit arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._getKeepAliveTime27487.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._getKeepAliveTime27487 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getKeepAliveTime", "(Ljava/util/concurrent/TimeUnit;)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getKeepAliveTime27487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.concurrent.BlockingQueue Queue
		{
			get
			{
				return getQueue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueue27488;
		public virtual global::java.util.concurrent.BlockingQueue getQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._getQueue27488.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._getQueue27488 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getQueue", "()Ljava/util/concurrent/BlockingQueue;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.BlockingQueue>(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getQueue27488) as java.util.concurrent.BlockingQueue;
		}
		public new int PoolSize
		{
			get
			{
				return getPoolSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPoolSize27489;
		public virtual int getPoolSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._getPoolSize27489.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._getPoolSize27489 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getPoolSize", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getPoolSize27489);
		}
		public new int ActiveCount
		{
			get
			{
				return getActiveCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActiveCount27490;
		public virtual int getActiveCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._getActiveCount27490.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._getActiveCount27490 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getActiveCount", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getActiveCount27490);
		}
		public new int LargestPoolSize
		{
			get
			{
				return getLargestPoolSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLargestPoolSize27491;
		public virtual int getLargestPoolSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._getLargestPoolSize27491.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._getLargestPoolSize27491 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getLargestPoolSize", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getLargestPoolSize27491);
		}
		public new long TaskCount
		{
			get
			{
				return getTaskCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTaskCount27492;
		public virtual long getTaskCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._getTaskCount27492.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._getTaskCount27492 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getTaskCount", "()J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getTaskCount27492);
		}
		public new long CompletedTaskCount
		{
			get
			{
				return getCompletedTaskCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompletedTaskCount27493;
		public virtual long getCompletedTaskCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._getCompletedTaskCount27493.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._getCompletedTaskCount27493 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getCompletedTaskCount", "()J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getCompletedTaskCount27493);
		}
		internal static global::MonoJavaBridge.MethodId _beforeExecute27494;
		protected virtual void beforeExecute(java.lang.Thread arg0, java.lang.Runnable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._beforeExecute27494.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._beforeExecute27494 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "beforeExecute", "(Ljava/lang/Thread;Ljava/lang/Runnable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._beforeExecute27494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void beforeExecute(java.lang.Thread arg0, global::java.lang.RunnableDelegate arg1)
		{
			beforeExecute(arg0, (global::java.lang.RunnableDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _afterExecute27495;
		protected virtual void afterExecute(java.lang.Runnable arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._afterExecute27495.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._afterExecute27495 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "afterExecute", "(Ljava/lang/Runnable;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._afterExecute27495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void afterExecute(global::java.lang.RunnableDelegate arg0, java.lang.Throwable arg1)
		{
			afterExecute((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _terminated27496;
		protected virtual void terminated()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._terminated27496.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._terminated27496 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "terminated", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._terminated27496);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadPoolExecutor27497;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4, java.util.concurrent.ThreadFactory arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27497.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27497 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/ThreadFactory;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadPoolExecutor27498;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4, java.util.concurrent.RejectedExecutionHandler arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27498.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27498 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/RejectedExecutionHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadPoolExecutor27499;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4, java.util.concurrent.ThreadFactory arg5, java.util.concurrent.RejectedExecutionHandler arg6) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27499.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27499 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedExecutionHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadPoolExecutor27500;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27500.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27500 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		static ThreadPoolExecutor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ThreadPoolExecutor.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor"));
		}
		internal static void InitJNI()
		{
		}
	}
}
