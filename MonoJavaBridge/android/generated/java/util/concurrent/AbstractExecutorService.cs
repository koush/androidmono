namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.AbstractExecutorService_))]
	public abstract partial class AbstractExecutorService : java.lang.Object, ExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractExecutorService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void shutdown();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract bool awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.util.List shutdownNow();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract bool isShutdown();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract bool isTerminated();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract void execute(java.lang.Runnable arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.util.concurrent.Future submit(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.AbstractExecutorService.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.AbstractExecutorService._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.concurrent.Future;
		}
		public java.util.concurrent.Future submit(global::java.lang.RunnableDelegate arg0, java.lang.Object arg1)
		{
			return submit((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.util.concurrent.Future submit(java.util.concurrent.Callable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.AbstractExecutorService.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.AbstractExecutorService._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.util.concurrent.Future submit(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.AbstractExecutorService.staticClass, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.AbstractExecutorService._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.concurrent.Future;
		}
		public java.util.concurrent.Future submit(global::java.lang.RunnableDelegate arg0)
		{
			return submit((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.Object invokeAny(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;", ref global::java.util.concurrent.AbstractExecutorService._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.Object invokeAny(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", ref global::java.util.concurrent.AbstractExecutorService._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.util.List invokeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAll", "(Ljava/util/Collection;)Ljava/util/List;", ref global::java.util.concurrent.AbstractExecutorService._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.util.List invokeAll(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;", ref global::java.util.concurrent.AbstractExecutorService._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public AbstractExecutorService() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.AbstractExecutorService._m13.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.AbstractExecutorService._m13 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._m13);
			Init(@__env, handle);
		}
		static AbstractExecutorService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.AbstractExecutorService.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/AbstractExecutorService"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.AbstractExecutorService))]
	internal sealed partial class AbstractExecutorService_ : java.util.concurrent.AbstractExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractExecutorService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.AbstractExecutorService_.staticClass, "shutdown", "()V", ref global::java.util.concurrent.AbstractExecutorService_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.AbstractExecutorService_.staticClass, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.AbstractExecutorService_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.util.List shutdownNow()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.AbstractExecutorService_.staticClass, "shutdownNow", "()Ljava/util/List;", ref global::java.util.concurrent.AbstractExecutorService_._m2) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isShutdown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.AbstractExecutorService_.staticClass, "isShutdown", "()Z", ref global::java.util.concurrent.AbstractExecutorService_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isTerminated()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.AbstractExecutorService_.staticClass, "isTerminated", "()Z", ref global::java.util.concurrent.AbstractExecutorService_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void execute(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.AbstractExecutorService_.staticClass, "execute", "(Ljava/lang/Runnable;)V", ref global::java.util.concurrent.AbstractExecutorService_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void execute(global::java.lang.RunnableDelegate arg0)
		{
			execute((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		static AbstractExecutorService_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.AbstractExecutorService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/AbstractExecutorService"));
		}
	}
}
