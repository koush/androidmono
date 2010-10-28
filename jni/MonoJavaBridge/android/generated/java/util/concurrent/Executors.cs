namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Executors : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Executors()
		{
			InitJNI();
		}
		protected Executors(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newFixedThreadPool27282;
		public static global::java.util.concurrent.ExecutorService newFixedThreadPool(int arg0, java.util.concurrent.ThreadFactory arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newFixedThreadPool27282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newFixedThreadPool27283;
		public static global::java.util.concurrent.ExecutorService newFixedThreadPool(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newFixedThreadPool27283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newSingleThreadExecutor27284;
		public static global::java.util.concurrent.ExecutorService newSingleThreadExecutor(java.util.concurrent.ThreadFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newSingleThreadExecutor27284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newSingleThreadExecutor27285;
		public static global::java.util.concurrent.ExecutorService newSingleThreadExecutor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newSingleThreadExecutor27285)) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newCachedThreadPool27286;
		public static global::java.util.concurrent.ExecutorService newCachedThreadPool(java.util.concurrent.ThreadFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newCachedThreadPool27286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newCachedThreadPool27287;
		public static global::java.util.concurrent.ExecutorService newCachedThreadPool()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newCachedThreadPool27287)) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newSingleThreadScheduledExecutor27288;
		public static global::java.util.concurrent.ScheduledExecutorService newSingleThreadScheduledExecutor(java.util.concurrent.ThreadFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newSingleThreadScheduledExecutor27288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ScheduledExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newSingleThreadScheduledExecutor27289;
		public static global::java.util.concurrent.ScheduledExecutorService newSingleThreadScheduledExecutor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newSingleThreadScheduledExecutor27289)) as java.util.concurrent.ScheduledExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newScheduledThreadPool27290;
		public static global::java.util.concurrent.ScheduledExecutorService newScheduledThreadPool(int arg0, java.util.concurrent.ThreadFactory arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newScheduledThreadPool27290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.ScheduledExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newScheduledThreadPool27291;
		public static global::java.util.concurrent.ScheduledExecutorService newScheduledThreadPool(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newScheduledThreadPool27291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ScheduledExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _unconfigurableExecutorService27292;
		public static global::java.util.concurrent.ExecutorService unconfigurableExecutorService(java.util.concurrent.ExecutorService arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._unconfigurableExecutorService27292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _unconfigurableScheduledExecutorService27293;
		public static global::java.util.concurrent.ScheduledExecutorService unconfigurableScheduledExecutorService(java.util.concurrent.ScheduledExecutorService arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._unconfigurableScheduledExecutorService27293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ScheduledExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _defaultThreadFactory27294;
		public static global::java.util.concurrent.ThreadFactory defaultThreadFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ThreadFactory>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._defaultThreadFactory27294)) as java.util.concurrent.ThreadFactory;
		}
		internal static global::MonoJavaBridge.MethodId _privilegedThreadFactory27295;
		public static global::java.util.concurrent.ThreadFactory privilegedThreadFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ThreadFactory>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._privilegedThreadFactory27295)) as java.util.concurrent.ThreadFactory;
		}
		internal static global::MonoJavaBridge.MethodId _callable27296;
		public static global::java.util.concurrent.Callable callable(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._callable27296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		public static java.util.concurrent.Callable callable(global::java.lang.RunnableDelegate arg0)
		{
			return callable((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _callable27297;
		public static global::java.util.concurrent.Callable callable(java.security.PrivilegedAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._callable27297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		internal static global::MonoJavaBridge.MethodId _callable27298;
		public static global::java.util.concurrent.Callable callable(java.security.PrivilegedExceptionAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._callable27298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		internal static global::MonoJavaBridge.MethodId _callable27299;
		public static global::java.util.concurrent.Callable callable(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._callable27299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Callable;
		}
		public static java.util.concurrent.Callable callable(global::java.lang.RunnableDelegate arg0, java.lang.Object arg1)
		{
			return callable((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _privilegedCallable27300;
		public static global::java.util.concurrent.Callable privilegedCallable(java.util.concurrent.Callable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._privilegedCallable27300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		internal static global::MonoJavaBridge.MethodId _privilegedCallableUsingCurrentClassLoader27301;
		public static global::java.util.concurrent.Callable privilegedCallableUsingCurrentClassLoader(java.util.concurrent.Callable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._privilegedCallableUsingCurrentClassLoader27301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Executors.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Executors"));
			global::java.util.concurrent.Executors._newFixedThreadPool27282 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newFixedThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newFixedThreadPool27283 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newFixedThreadPool", "(I)Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newSingleThreadExecutor27284 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newSingleThreadExecutor27285 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadExecutor", "()Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newCachedThreadPool27286 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newCachedThreadPool", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newCachedThreadPool27287 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newCachedThreadPool", "()Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newSingleThreadScheduledExecutor27288 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadScheduledExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;");
			global::java.util.concurrent.Executors._newSingleThreadScheduledExecutor27289 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadScheduledExecutor", "()Ljava/util/concurrent/ScheduledExecutorService;");
			global::java.util.concurrent.Executors._newScheduledThreadPool27290 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newScheduledThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;");
			global::java.util.concurrent.Executors._newScheduledThreadPool27291 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newScheduledThreadPool", "(I)Ljava/util/concurrent/ScheduledExecutorService;");
			global::java.util.concurrent.Executors._unconfigurableExecutorService27292 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "unconfigurableExecutorService", "(Ljava/util/concurrent/ExecutorService;)Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._unconfigurableScheduledExecutorService27293 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "unconfigurableScheduledExecutorService", "(Ljava/util/concurrent/ScheduledExecutorService;)Ljava/util/concurrent/ScheduledExecutorService;");
			global::java.util.concurrent.Executors._defaultThreadFactory27294 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "defaultThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
			global::java.util.concurrent.Executors._privilegedThreadFactory27295 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "privilegedThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
			global::java.util.concurrent.Executors._callable27296 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Callable;");
			global::java.util.concurrent.Executors._callable27297 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/security/PrivilegedAction;)Ljava/util/concurrent/Callable;");
			global::java.util.concurrent.Executors._callable27298 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/security/PrivilegedExceptionAction;)Ljava/util/concurrent/Callable;");
			global::java.util.concurrent.Executors._callable27299 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Callable;");
			global::java.util.concurrent.Executors._privilegedCallable27300 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "privilegedCallable", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;");
			global::java.util.concurrent.Executors._privilegedCallableUsingCurrentClassLoader27301 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "privilegedCallableUsingCurrentClassLoader", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;");
		}
	}
}
