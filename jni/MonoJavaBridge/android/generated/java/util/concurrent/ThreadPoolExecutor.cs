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
			internal static global::MonoJavaBridge.MethodId _rejectedExecution27455;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._rejectedExecution27455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._rejectedExecution27455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _AbortPolicy27456;
			public AbortPolicy()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._AbortPolicy27456);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$AbortPolicy"));
				global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._rejectedExecution27455 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V");
				global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy._AbortPolicy27456 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.AbortPolicy.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _rejectedExecution27457;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._rejectedExecution27457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._rejectedExecution27457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _CallerRunsPolicy27458;
			public CallerRunsPolicy()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._CallerRunsPolicy27458);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$CallerRunsPolicy"));
				global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._rejectedExecution27457 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V");
				global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy._CallerRunsPolicy27458 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.CallerRunsPolicy.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _rejectedExecution27459;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._rejectedExecution27459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._rejectedExecution27459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _DiscardOldestPolicy27460;
			public DiscardOldestPolicy()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._DiscardOldestPolicy27460);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$DiscardOldestPolicy"));
				global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._rejectedExecution27459 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V");
				global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy._DiscardOldestPolicy27460 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.DiscardOldestPolicy.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _rejectedExecution27461;
			public virtual void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._rejectedExecution27461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._rejectedExecution27461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _DiscardPolicy27462;
			public DiscardPolicy()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass, global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._DiscardPolicy27462);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor$DiscardPolicy"));
				global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._rejectedExecution27461 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V");
				global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy._DiscardPolicy27462 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.DiscardPolicy.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _shutdown27463;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._shutdown27463);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._shutdown27463);
		}
		internal static global::MonoJavaBridge.MethodId _finalize27464;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._finalize27464);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._finalize27464);
		}
		internal static global::MonoJavaBridge.MethodId _remove27465;
		public virtual bool remove(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._remove27465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._remove27465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _awaitTermination27466;
		public override bool awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._awaitTermination27466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._awaitTermination27466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute27467;
		public override void execute(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._execute27467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._execute27467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _purge27468;
		public virtual void purge() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._purge27468);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._purge27468);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownNow27469;
		public override global::java.util.List shutdownNow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._shutdownNow27469)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._shutdownNow27469)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _isShutdown27470;
		public override bool isShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._isShutdown27470);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._isShutdown27470);
		}
		internal static global::MonoJavaBridge.MethodId _isTerminated27471;
		public override bool isTerminated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._isTerminated27471);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._isTerminated27471);
		}
		internal static global::MonoJavaBridge.MethodId _allowCoreThreadTimeOut27472;
		public virtual void allowCoreThreadTimeOut(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._allowCoreThreadTimeOut27472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._allowCoreThreadTimeOut27472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTerminating27473;
		public virtual bool isTerminating() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._isTerminating27473);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._isTerminating27473);
		}
		internal static global::MonoJavaBridge.MethodId _setThreadFactory27474;
		public virtual void setThreadFactory(java.util.concurrent.ThreadFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._setThreadFactory27474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._setThreadFactory27474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getThreadFactory27475;
		public virtual global::java.util.concurrent.ThreadFactory getThreadFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ThreadFactory>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getThreadFactory27475)) as java.util.concurrent.ThreadFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ThreadFactory>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getThreadFactory27475)) as java.util.concurrent.ThreadFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setRejectedExecutionHandler27476;
		public virtual void setRejectedExecutionHandler(java.util.concurrent.RejectedExecutionHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._setRejectedExecutionHandler27476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._setRejectedExecutionHandler27476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getRejectedExecutionHandler27477;
		public virtual global::java.util.concurrent.RejectedExecutionHandler getRejectedExecutionHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.RejectedExecutionHandler>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getRejectedExecutionHandler27477)) as java.util.concurrent.RejectedExecutionHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.RejectedExecutionHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getRejectedExecutionHandler27477)) as java.util.concurrent.RejectedExecutionHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setCorePoolSize27478;
		public virtual void setCorePoolSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._setCorePoolSize27478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._setCorePoolSize27478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCorePoolSize27479;
		public virtual int getCorePoolSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getCorePoolSize27479);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getCorePoolSize27479);
		}
		internal static global::MonoJavaBridge.MethodId _prestartCoreThread27480;
		public virtual bool prestartCoreThread() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._prestartCoreThread27480);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._prestartCoreThread27480);
		}
		internal static global::MonoJavaBridge.MethodId _prestartAllCoreThreads27481;
		public virtual int prestartAllCoreThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._prestartAllCoreThreads27481);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._prestartAllCoreThreads27481);
		}
		internal static global::MonoJavaBridge.MethodId _allowsCoreThreadTimeOut27482;
		public virtual bool allowsCoreThreadTimeOut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._allowsCoreThreadTimeOut27482);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._allowsCoreThreadTimeOut27482);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumPoolSize27483;
		public virtual void setMaximumPoolSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._setMaximumPoolSize27483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._setMaximumPoolSize27483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMaximumPoolSize27484;
		public virtual int getMaximumPoolSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getMaximumPoolSize27484);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getMaximumPoolSize27484);
		}
		internal static global::MonoJavaBridge.MethodId _setKeepAliveTime27485;
		public virtual void setKeepAliveTime(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._setKeepAliveTime27485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._setKeepAliveTime27485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getKeepAliveTime27486;
		public virtual long getKeepAliveTime(java.util.concurrent.TimeUnit arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getKeepAliveTime27486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getKeepAliveTime27486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.concurrent.BlockingQueue Queue
		{
			get
			{
				return getQueue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueue27487;
		public virtual global::java.util.concurrent.BlockingQueue getQueue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.BlockingQueue>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getQueue27487)) as java.util.concurrent.BlockingQueue;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.BlockingQueue>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getQueue27487)) as java.util.concurrent.BlockingQueue;
		}
		public new int PoolSize
		{
			get
			{
				return getPoolSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPoolSize27488;
		public virtual int getPoolSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getPoolSize27488);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getPoolSize27488);
		}
		public new int ActiveCount
		{
			get
			{
				return getActiveCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActiveCount27489;
		public virtual int getActiveCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getActiveCount27489);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getActiveCount27489);
		}
		public new int LargestPoolSize
		{
			get
			{
				return getLargestPoolSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLargestPoolSize27490;
		public virtual int getLargestPoolSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getLargestPoolSize27490);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getLargestPoolSize27490);
		}
		public new long TaskCount
		{
			get
			{
				return getTaskCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTaskCount27491;
		public virtual long getTaskCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getTaskCount27491);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getTaskCount27491);
		}
		public new long CompletedTaskCount
		{
			get
			{
				return getCompletedTaskCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompletedTaskCount27492;
		public virtual long getCompletedTaskCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._getCompletedTaskCount27492);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._getCompletedTaskCount27492);
		}
		internal static global::MonoJavaBridge.MethodId _beforeExecute27493;
		protected virtual void beforeExecute(java.lang.Thread arg0, java.lang.Runnable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._beforeExecute27493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._beforeExecute27493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _afterExecute27494;
		protected virtual void afterExecute(java.lang.Runnable arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._afterExecute27494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._afterExecute27494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _terminated27495;
		protected virtual void terminated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor._terminated27495);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._terminated27495);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadPoolExecutor27496;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4, java.util.concurrent.ThreadFactory arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadPoolExecutor27497;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4, java.util.concurrent.RejectedExecutionHandler arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadPoolExecutor27498;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4, java.util.concurrent.ThreadFactory arg5, java.util.concurrent.RejectedExecutionHandler arg6)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadPoolExecutor27499;
		public ThreadPoolExecutor(int arg0, int arg1, long arg2, java.util.concurrent.TimeUnit arg3, java.util.concurrent.BlockingQueue arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ThreadPoolExecutor.staticClass, global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ThreadPoolExecutor.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ThreadPoolExecutor"));
			global::java.util.concurrent.ThreadPoolExecutor._shutdown27463 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "shutdown", "()V");
			global::java.util.concurrent.ThreadPoolExecutor._finalize27464 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "finalize", "()V");
			global::java.util.concurrent.ThreadPoolExecutor._remove27465 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "remove", "(Ljava/lang/Runnable;)Z");
			global::java.util.concurrent.ThreadPoolExecutor._awaitTermination27466 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.ThreadPoolExecutor._execute27467 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "execute", "(Ljava/lang/Runnable;)V");
			global::java.util.concurrent.ThreadPoolExecutor._purge27468 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "purge", "()V");
			global::java.util.concurrent.ThreadPoolExecutor._shutdownNow27469 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "shutdownNow", "()Ljava/util/List;");
			global::java.util.concurrent.ThreadPoolExecutor._isShutdown27470 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "isShutdown", "()Z");
			global::java.util.concurrent.ThreadPoolExecutor._isTerminated27471 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "isTerminated", "()Z");
			global::java.util.concurrent.ThreadPoolExecutor._allowCoreThreadTimeOut27472 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "allowCoreThreadTimeOut", "(Z)V");
			global::java.util.concurrent.ThreadPoolExecutor._isTerminating27473 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "isTerminating", "()Z");
			global::java.util.concurrent.ThreadPoolExecutor._setThreadFactory27474 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setThreadFactory", "(Ljava/util/concurrent/ThreadFactory;)V");
			global::java.util.concurrent.ThreadPoolExecutor._getThreadFactory27475 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
			global::java.util.concurrent.ThreadPoolExecutor._setRejectedExecutionHandler27476 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setRejectedExecutionHandler", "(Ljava/util/concurrent/RejectedExecutionHandler;)V");
			global::java.util.concurrent.ThreadPoolExecutor._getRejectedExecutionHandler27477 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getRejectedExecutionHandler", "()Ljava/util/concurrent/RejectedExecutionHandler;");
			global::java.util.concurrent.ThreadPoolExecutor._setCorePoolSize27478 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setCorePoolSize", "(I)V");
			global::java.util.concurrent.ThreadPoolExecutor._getCorePoolSize27479 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getCorePoolSize", "()I");
			global::java.util.concurrent.ThreadPoolExecutor._prestartCoreThread27480 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "prestartCoreThread", "()Z");
			global::java.util.concurrent.ThreadPoolExecutor._prestartAllCoreThreads27481 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "prestartAllCoreThreads", "()I");
			global::java.util.concurrent.ThreadPoolExecutor._allowsCoreThreadTimeOut27482 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "allowsCoreThreadTimeOut", "()Z");
			global::java.util.concurrent.ThreadPoolExecutor._setMaximumPoolSize27483 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setMaximumPoolSize", "(I)V");
			global::java.util.concurrent.ThreadPoolExecutor._getMaximumPoolSize27484 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getMaximumPoolSize", "()I");
			global::java.util.concurrent.ThreadPoolExecutor._setKeepAliveTime27485 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "setKeepAliveTime", "(JLjava/util/concurrent/TimeUnit;)V");
			global::java.util.concurrent.ThreadPoolExecutor._getKeepAliveTime27486 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getKeepAliveTime", "(Ljava/util/concurrent/TimeUnit;)J");
			global::java.util.concurrent.ThreadPoolExecutor._getQueue27487 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getQueue", "()Ljava/util/concurrent/BlockingQueue;");
			global::java.util.concurrent.ThreadPoolExecutor._getPoolSize27488 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getPoolSize", "()I");
			global::java.util.concurrent.ThreadPoolExecutor._getActiveCount27489 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getActiveCount", "()I");
			global::java.util.concurrent.ThreadPoolExecutor._getLargestPoolSize27490 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getLargestPoolSize", "()I");
			global::java.util.concurrent.ThreadPoolExecutor._getTaskCount27491 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getTaskCount", "()J");
			global::java.util.concurrent.ThreadPoolExecutor._getCompletedTaskCount27492 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "getCompletedTaskCount", "()J");
			global::java.util.concurrent.ThreadPoolExecutor._beforeExecute27493 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "beforeExecute", "(Ljava/lang/Thread;Ljava/lang/Runnable;)V");
			global::java.util.concurrent.ThreadPoolExecutor._afterExecute27494 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "afterExecute", "(Ljava/lang/Runnable;Ljava/lang/Throwable;)V");
			global::java.util.concurrent.ThreadPoolExecutor._terminated27495 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "terminated", "()V");
			global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27496 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/ThreadFactory;)V");
			global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27497 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/RejectedExecutionHandler;)V");
			global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27498 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/ThreadFactory;Ljava/util/concurrent/RejectedExecutionHandler;)V");
			global::java.util.concurrent.ThreadPoolExecutor._ThreadPoolExecutor27499 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ThreadPoolExecutor.staticClass, "<init>", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;)V");
		}
	}
}
