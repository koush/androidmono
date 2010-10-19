namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ThreadPoolExecutor : java.util.concurrent.AbstractExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ThreadPoolExecutor()
		{
			InitJNI();
		}
		protected ThreadPoolExecutor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class AbortPolicy : java.lang.Object, RejectedExecutionHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AbortPolicy()
			{
				InitJNI();
			}
			protected AbortPolicy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _rejectedExecution21507;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._rejectedExecution21507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._rejectedExecution21507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _AbortPolicy21508;
			public AbortPolicy()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._AbortPolicy21508);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$AbortPolicy"));
				global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._rejectedExecution21507 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V");
				global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._AbortPolicy21508 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class CallerRunsPolicy : java.lang.Object, RejectedExecutionHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static CallerRunsPolicy()
			{
				InitJNI();
			}
			protected CallerRunsPolicy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _rejectedExecution21509;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._rejectedExecution21509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._rejectedExecution21509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _CallerRunsPolicy21510;
			public CallerRunsPolicy()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._CallerRunsPolicy21510);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$CallerRunsPolicy"));
				global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._rejectedExecution21509 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V");
				global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._CallerRunsPolicy21510 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class DiscardOldestPolicy : java.lang.Object, RejectedExecutionHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static DiscardOldestPolicy()
			{
				InitJNI();
			}
			protected DiscardOldestPolicy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _rejectedExecution21511;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._rejectedExecution21511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._rejectedExecution21511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _DiscardOldestPolicy21512;
			public DiscardOldestPolicy()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._DiscardOldestPolicy21512);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$DiscardOldestPolicy"));
				global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._rejectedExecution21511 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V");
				global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._DiscardOldestPolicy21512 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class DiscardPolicy : java.lang.Object, RejectedExecutionHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static DiscardPolicy()
			{
				InitJNI();
			}
			protected DiscardPolicy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _rejectedExecution21513;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._rejectedExecution21513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._rejectedExecution21513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _DiscardPolicy21514;
			public DiscardPolicy()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._DiscardPolicy21514);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$DiscardPolicy"));
				global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._rejectedExecution21513 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V");
				global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._DiscardPolicy21514 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _shutdown21515;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._shutdown21515);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._shutdown21515);
		}
		internal static global::MonoJavaBridge.MethodId _finalize21516;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._finalize21516);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._finalize21516);
		}
		internal static global::MonoJavaBridge.MethodId _remove21517;
		public virtual bool remove(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._remove21517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._remove21517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _awaitTermination21518;
		public override bool awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._awaitTermination21518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._awaitTermination21518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute21519;
		public override void execute(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._execute21519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._execute21519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _purge21520;
		public virtual void purge() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._purge21520);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._purge21520);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownNow21521;
		public override global::java.util.List shutdownNow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._shutdownNow21521)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._shutdownNow21521)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _isShutdown21522;
		public override bool isShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._isShutdown21522);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._isShutdown21522);
		}
		internal static global::MonoJavaBridge.MethodId _isTerminated21523;
		public override bool isTerminated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._isTerminated21523);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._isTerminated21523);
		}
		internal static global::MonoJavaBridge.MethodId _allowCoreThreadTimeOut21524;
		public virtual void allowCoreThreadTimeOut(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._allowCoreThreadTimeOut21524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._allowCoreThreadTimeOut21524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTerminating21525;
		public virtual bool isTerminating() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._isTerminating21525);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._isTerminating21525);
		}
		internal static global::MonoJavaBridge.MethodId _setThreadFactory21526;
		public virtual void setThreadFactory(java.util.concurrent.ThreadFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._setThreadFactory21526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._setThreadFactory21526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getThreadFactory21527;
		public virtual global::java.util.concurrent.ThreadFactory getThreadFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ThreadFactory>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getThreadFactory21527)) as java.util.concurrent.ThreadFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ThreadFactory>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getThreadFactory21527)) as java.util.concurrent.ThreadFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setRejectedExecutionHandler21528;
		public virtual void setRejectedExecutionHandler(java.util.concurrent.RejectedExecutionHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._setRejectedExecutionHandler21528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._setRejectedExecutionHandler21528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getRejectedExecutionHandler21529;
		public virtual global::java.util.concurrent.RejectedExecutionHandler getRejectedExecutionHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.RejectedExecutionHandler>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getRejectedExecutionHandler21529)) as java.util.concurrent.RejectedExecutionHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.RejectedExecutionHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getRejectedExecutionHandler21529)) as java.util.concurrent.RejectedExecutionHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setCorePoolSize21530;
		public virtual void setCorePoolSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._setCorePoolSize21530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._setCorePoolSize21530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCorePoolSize21531;
		public virtual int getCorePoolSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getCorePoolSize21531);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getCorePoolSize21531);
		}
		internal static global::MonoJavaBridge.MethodId _prestartCoreThread21532;
		public virtual bool prestartCoreThread() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._prestartCoreThread21532);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._prestartCoreThread21532);
		}
		internal static global::MonoJavaBridge.MethodId _prestartAllCoreThreads21533;
		public virtual int prestartAllCoreThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._prestartAllCoreThreads21533);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._prestartAllCoreThreads21533);
		}
		internal static global::MonoJavaBridge.MethodId _allowsCoreThreadTimeOut21534;
		public virtual bool allowsCoreThreadTimeOut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._allowsCoreThreadTimeOut21534);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._allowsCoreThreadTimeOut21534);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumPoolSize21535;
		public virtual void setMaximumPoolSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._setMaximumPoolSize21535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._setMaximumPoolSize21535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMaximumPoolSize21536;
		public virtual int getMaximumPoolSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getMaximumPoolSize21536);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getMaximumPoolSize21536);
		}
		internal static global::MonoJavaBridge.MethodId _setKeepAliveTime21537;
		public virtual void setKeepAliveTime(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._setKeepAliveTime21537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._setKeepAliveTime21537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getKeepAliveTime21538;
		public virtual long getKeepAliveTime(java.util.concurrent.TimeUnit arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getKeepAliveTime21538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getKeepAliveTime21538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.concurrent.BlockingQueue Queue
		{
			get
			{
				return getQueue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueue21539;
		public virtual global::java.util.concurrent.BlockingQueue getQueue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.BlockingQueue>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getQueue21539)) as java.util.concurrent.BlockingQueue;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.BlockingQueue>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getQueue21539)) as java.util.concurrent.BlockingQueue;
		}
		public new int PoolSize
		{
			get
			{
				return getPoolSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPoolSize21540;
		public virtual int getPoolSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getPoolSize21540);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getPoolSize21540);
		}
		public new int ActiveCount
		{
			get
			{
				return getActiveCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActiveCount21541;
		public virtual int getActiveCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getActiveCount21541);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getActiveCount21541);
		}
		public new int LargestPoolSize
		{
			get
			{
				return getLargestPoolSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLargestPoolSize21542;
		public virtual int getLargestPoolSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getLargestPoolSize21542);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getLargestPoolSize21542);
		}
		public new long TaskCount
		{
			get
			{
				return getTaskCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTaskCount21543;
		public virtual long getTaskCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getTaskCount21543);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getTaskCount21543);
		}
		public new long CompletedTaskCount
		{
			get
			{
				return getCompletedTaskCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompletedTaskCount21544;
		public virtual long getCompletedTaskCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getCompletedTaskCount21544);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getCompletedTaskCount21544);
		}
		internal static global::MonoJavaBridge.MethodId _beforeExecute21545;
		protected virtual void beforeExecute(java.lang.Thread arg0, java.lang.Runnable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._beforeExecute21545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._beforeExecute21545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _afterExecute21546;
		protected virtual void afterExecute(java.lang.Runnable arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._afterExecute21546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._afterExecute21546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _terminated21547;
		protected virtual void terminated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._terminated21547);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._terminated21547);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadPoolExecutor21548;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4, java.util.concurrent.ThreadFactory arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor21548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadPoolExecutor21549;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4, java.util.concurrent.RejectedExecutionHandler arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor21549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadPoolExecutor21550;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4, java.util.concurrent.ThreadFactory arg5, java.util.concurrent.RejectedExecutionHandler arg6)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor21550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadPoolExecutor21551;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor21551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ThreadPoolExecutor.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor"));
			global::java.util.concurrent.ThreadPoolExecutor._shutdown21515 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "shutdown", "()V");
			global::java.util.concurrent.ThreadPoolExecutor._finalize21516 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "finalize", "()V");
			global::java.util.concurrent.ThreadPoolExecutor._remove21517 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "remove", "(Ljava/lang/Runnable;)Z");
			global::java.util.concurrent.ThreadPoolExecutor._awaitTermination21518 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.ThreadPoolExecutor._execute21519 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "execute", "(Ljava/lang/Runnable;)V");
			global::java.util.concurrent.ThreadPoolExecutor._purge21520 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "purge", "()V");
			global::java.util.concurrent.ThreadPoolExecutor._shutdownNow21521 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "shutdownNow", "()Ljava/util/List;");
			global::java.util.concurrent.ThreadPoolExecutor._isShutdown21522 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "isShutdown", "()Z");
			global::java.util.concurrent.ThreadPoolExecutor._isTerminated21523 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "isTerminated", "()Z");
			global::java.util.concurrent.ThreadPoolExecutor._allowCoreThreadTimeOut21524 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "allowCoreThreadTimeOut", "(Z)V");
			global::java.util.concurrent.ThreadPoolExecutor._isTerminating21525 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "isTerminating", "()Z");
			global::java.util.concurrent.ThreadPoolExecutor._setThreadFactory21526 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setThreadFactory", "(Ljava/util/concurrent/ThreadFactory;)V");
			global::java.util.concurrent.ThreadPoolExecutor._getThreadFactory21527 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
			global::java.util.concurrent.ThreadPoolExecutor._setRejectedExecutionHandler21528 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setRejectedExecutionHandler", "(Ljava/util/concurrent/RejectedExecutionHandler;)V");
			global::java.util.concurrent.ThreadPoolExecutor._getRejectedExecutionHandler21529 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getRejectedExecutionHandler", "()Ljava/util/concurrent/RejectedExecutionHandler;");
			global::java.util.concurrent.ThreadPoolExecutor._setCorePoolSize21530 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setCorePoolSize", "(I)V");
			global::java.util.concurrent.ThreadPoolExecutor._getCorePoolSize21531 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getCorePoolSize", "()I");
			global::java.util.concurrent.ThreadPoolExecutor._prestartCoreThread21532 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "prestartCoreThread", "()Z");
			global::java.util.concurrent.ThreadPoolExecutor._prestartAllCoreThreads21533 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "prestartAllCoreThreads", "()I");
			global::java.util.concurrent.ThreadPoolExecutor._allowsCoreThreadTimeOut21534 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "allowsCoreThreadTimeOut", "()Z");
			global::java.util.concurrent.ThreadPoolExecutor._setMaximumPoolSize21535 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setMaximumPoolSize", "(I)V");
			global::java.util.concurrent.ThreadPoolExecutor._getMaximumPoolSize21536 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getMaximumPoolSize", "()I");
			global::java.util.concurrent.ThreadPoolExecutor._setKeepAliveTime21537 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setKeepAliveTime", "(JLjava/util/concurrent/TimeUnit;)V");
			global::java.util.concurrent.ThreadPoolExecutor._getKeepAliveTime21538 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getKeepAliveTime", "(Ljava/util/concurrent/TimeUnit;)J");
			global::java.util.concurrent.ThreadPoolExecutor._getQueue21539 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getQueue", "()Ljava/util/concurrent/BlockingQueue;");
			global::java.util.concurrent.ThreadPoolExecutor._getPoolSize21540 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getPoolSize", "()I");
			global::java.util.concurrent.ThreadPoolExecutor._getActiveCount21541 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getActiveCount", "()I");
			global::java.util.concurrent.ThreadPoolExecutor._getLargestPoolSize21542 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getLargestPoolSize", "()I");
			global::java.util.concurrent.ThreadPoolExecutor._getTaskCount21543 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getTaskCount", "()J");
			global::java.util.concurrent.ThreadPoolExecutor._getCompletedTaskCount21544 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getCompletedTaskCount", "()J");
			global::java.util.concurrent.ThreadPoolExecutor._beforeExecute21545 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "beforeExecute", "(Ljava/lang/Thread;Ljava/lang/Runnable;)V");
			global::java.util.concurrent.ThreadPoolExecutor._afterExecute21546 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "afterExecute", "(Ljava/lang/Runnable;Ljava/lang/Throwable;)V");
			global::java.util.concurrent.ThreadPoolExecutor._terminated21547 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "terminated", "()V");
			global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor21548 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/ThreadFactory;)V");
			global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor21549 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/RejectedExecutionHandler;)V");
			global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor21550 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedExecutionHandler;)V");
			global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor21551 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;)V");
		}
	}
}
