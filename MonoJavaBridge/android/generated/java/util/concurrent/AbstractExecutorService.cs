namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.AbstractExecutorService_))]
	public abstract partial class AbstractExecutorService : java.lang.Object, ExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractExecutorService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown27025;
		public abstract void shutdown();
		internal static global::MonoJavaBridge.MethodId _awaitTermination27026;
		public abstract bool awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1);
		internal static global::MonoJavaBridge.MethodId _shutdownNow27027;
		public abstract global::java.util.List shutdownNow();
		internal static global::MonoJavaBridge.MethodId _isShutdown27028;
		public abstract bool isShutdown();
		internal static global::MonoJavaBridge.MethodId _isTerminated27029;
		public abstract bool isTerminated();
		internal static global::MonoJavaBridge.MethodId _execute27030;
		public abstract void execute(java.lang.Runnable arg0);
		internal static global::MonoJavaBridge.MethodId _submit27031;
		public virtual global::java.util.concurrent.Future submit(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._submit27031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
		}
		public java.util.concurrent.Future submit(global::java.lang.RunnableDelegate arg0, java.lang.Object arg1)
		{
			return submit((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _submit27032;
		public virtual global::java.util.concurrent.Future submit(java.util.concurrent.Callable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._submit27032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit27033;
		public virtual global::java.util.concurrent.Future submit(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._submit27033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
		}
		public java.util.concurrent.Future submit(global::java.lang.RunnableDelegate arg0)
		{
			return submit((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _invokeAny27034;
		public virtual global::java.lang.Object invokeAny(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._invokeAny27034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAny27035;
		public virtual global::java.lang.Object invokeAny(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._invokeAny27035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAll27036;
		public virtual global::java.util.List invokeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._invokeAll27036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAll27037;
		public virtual global::java.util.List invokeAll(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._invokeAll27037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractExecutorService27038;
		public AbstractExecutorService() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._AbstractExecutorService27038);
			Init(@__env, handle);
		}
		static AbstractExecutorService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.AbstractExecutorService.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/AbstractExecutorService"));
			global::java.util.concurrent.AbstractExecutorService._shutdown27025 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "shutdown", "()V");
			global::java.util.concurrent.AbstractExecutorService._awaitTermination27026 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.AbstractExecutorService._shutdownNow27027 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "shutdownNow", "()Ljava/util/List;");
			global::java.util.concurrent.AbstractExecutorService._isShutdown27028 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "isShutdown", "()Z");
			global::java.util.concurrent.AbstractExecutorService._isTerminated27029 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "isTerminated", "()Z");
			global::java.util.concurrent.AbstractExecutorService._execute27030 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "execute", "(Ljava/lang/Runnable;)V");
			global::java.util.concurrent.AbstractExecutorService._submit27031 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.AbstractExecutorService._submit27032 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.AbstractExecutorService._submit27033 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.AbstractExecutorService._invokeAny27034 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;");
			global::java.util.concurrent.AbstractExecutorService._invokeAny27035 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.AbstractExecutorService._invokeAll27036 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAll", "(Ljava/util/Collection;)Ljava/util/List;");
			global::java.util.concurrent.AbstractExecutorService._invokeAll27037 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;");
			global::java.util.concurrent.AbstractExecutorService._AbstractExecutorService27038 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.AbstractExecutorService))]
	internal sealed partial class AbstractExecutorService_ : java.util.concurrent.AbstractExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractExecutorService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown27039;
		public override void shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_._shutdown27039);
		}
		internal static global::MonoJavaBridge.MethodId _awaitTermination27040;
		public override bool awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_._awaitTermination27040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shutdownNow27041;
		public override global::java.util.List shutdownNow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_._shutdownNow27041)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _isShutdown27042;
		public override bool isShutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_._isShutdown27042);
		}
		internal static global::MonoJavaBridge.MethodId _isTerminated27043;
		public override bool isTerminated()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_._isTerminated27043);
		}
		internal static global::MonoJavaBridge.MethodId _execute27044;
		public override void execute(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_._execute27044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void execute(global::java.lang.RunnableDelegate arg0)
		{
			execute((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		static AbstractExecutorService_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.AbstractExecutorService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/AbstractExecutorService"));
			global::java.util.concurrent.AbstractExecutorService_._shutdown27039 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService_.staticClass, "shutdown", "()V");
			global::java.util.concurrent.AbstractExecutorService_._awaitTermination27040 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService_.staticClass, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.AbstractExecutorService_._shutdownNow27041 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService_.staticClass, "shutdownNow", "()Ljava/util/List;");
			global::java.util.concurrent.AbstractExecutorService_._isShutdown27042 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService_.staticClass, "isShutdown", "()Z");
			global::java.util.concurrent.AbstractExecutorService_._isTerminated27043 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService_.staticClass, "isTerminated", "()Z");
			global::java.util.concurrent.AbstractExecutorService_._execute27044 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService_.staticClass, "execute", "(Ljava/lang/Runnable;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
