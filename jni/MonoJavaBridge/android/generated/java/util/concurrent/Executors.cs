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
		internal static global::MonoJavaBridge.MethodId _newFixedThreadPool21333;
		public static global::java.util.concurrent.ExecutorService newFixedThreadPool(int arg0, java.util.concurrent.ThreadFactory arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newFixedThreadPool21333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newFixedThreadPool21334;
		public static global::java.util.concurrent.ExecutorService newFixedThreadPool(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newFixedThreadPool21334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newSingleThreadExecutor21335;
		public static global::java.util.concurrent.ExecutorService newSingleThreadExecutor(java.util.concurrent.ThreadFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newSingleThreadExecutor21335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newSingleThreadExecutor21336;
		public static global::java.util.concurrent.ExecutorService newSingleThreadExecutor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newSingleThreadExecutor21336)) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newCachedThreadPool21337;
		public static global::java.util.concurrent.ExecutorService newCachedThreadPool(java.util.concurrent.ThreadFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newCachedThreadPool21337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newCachedThreadPool21338;
		public static global::java.util.concurrent.ExecutorService newCachedThreadPool() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newCachedThreadPool21338)) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newSingleThreadScheduledExecutor21339;
		public static global::java.util.concurrent.ScheduledExecutorService newSingleThreadScheduledExecutor(java.util.concurrent.ThreadFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newSingleThreadScheduledExecutor21339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ScheduledExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newSingleThreadScheduledExecutor21340;
		public static global::java.util.concurrent.ScheduledExecutorService newSingleThreadScheduledExecutor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newSingleThreadScheduledExecutor21340)) as java.util.concurrent.ScheduledExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newScheduledThreadPool21341;
		public static global::java.util.concurrent.ScheduledExecutorService newScheduledThreadPool(int arg0, java.util.concurrent.ThreadFactory arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newScheduledThreadPool21341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.ScheduledExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newScheduledThreadPool21342;
		public static global::java.util.concurrent.ScheduledExecutorService newScheduledThreadPool(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newScheduledThreadPool21342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ScheduledExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _unconfigurableExecutorService21343;
		public static global::java.util.concurrent.ExecutorService unconfigurableExecutorService(java.util.concurrent.ExecutorService arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._unconfigurableExecutorService21343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _unconfigurableScheduledExecutorService21344;
		public static global::java.util.concurrent.ScheduledExecutorService unconfigurableScheduledExecutorService(java.util.concurrent.ScheduledExecutorService arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._unconfigurableScheduledExecutorService21344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ScheduledExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _defaultThreadFactory21345;
		public static global::java.util.concurrent.ThreadFactory defaultThreadFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ThreadFactory>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._defaultThreadFactory21345)) as java.util.concurrent.ThreadFactory;
		}
		internal static global::MonoJavaBridge.MethodId _privilegedThreadFactory21346;
		public static global::java.util.concurrent.ThreadFactory privilegedThreadFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ThreadFactory>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._privilegedThreadFactory21346)) as java.util.concurrent.ThreadFactory;
		}
		internal static global::MonoJavaBridge.MethodId _callable21347;
		public static global::java.util.concurrent.Callable callable(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._callable21347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		internal static global::MonoJavaBridge.MethodId _callable21348;
		public static global::java.util.concurrent.Callable callable(java.security.PrivilegedAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._callable21348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		internal static global::MonoJavaBridge.MethodId _callable21349;
		public static global::java.util.concurrent.Callable callable(java.security.PrivilegedExceptionAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._callable21349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		internal static global::MonoJavaBridge.MethodId _callable21350;
		public static global::java.util.concurrent.Callable callable(java.lang.Runnable arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._callable21350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Callable;
		}
		internal static global::MonoJavaBridge.MethodId _privilegedCallable21351;
		public static global::java.util.concurrent.Callable privilegedCallable(java.util.concurrent.Callable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._privilegedCallable21351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		internal static global::MonoJavaBridge.MethodId _privilegedCallableUsingCurrentClassLoader21352;
		public static global::java.util.concurrent.Callable privilegedCallableUsingCurrentClassLoader(java.util.concurrent.Callable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._privilegedCallableUsingCurrentClassLoader21352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Executors.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Executors"));
			global::java.util.concurrent.Executors._newFixedThreadPool21333 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newFixedThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newFixedThreadPool21334 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newFixedThreadPool", "(I)Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newSingleThreadExecutor21335 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newSingleThreadExecutor21336 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadExecutor", "()Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newCachedThreadPool21337 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newCachedThreadPool", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newCachedThreadPool21338 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newCachedThreadPool", "()Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newSingleThreadScheduledExecutor21339 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadScheduledExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;");
			global::java.util.concurrent.Executors._newSingleThreadScheduledExecutor21340 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadScheduledExecutor", "()Ljava/util/concurrent/ScheduledExecutorService;");
			global::java.util.concurrent.Executors._newScheduledThreadPool21341 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newScheduledThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;");
			global::java.util.concurrent.Executors._newScheduledThreadPool21342 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newScheduledThreadPool", "(I)Ljava/util/concurrent/ScheduledExecutorService;");
			global::java.util.concurrent.Executors._unconfigurableExecutorService21343 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "unconfigurableExecutorService", "(Ljava/util/concurrent/ExecutorService;)Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._unconfigurableScheduledExecutorService21344 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "unconfigurableScheduledExecutorService", "(Ljava/util/concurrent/ScheduledExecutorService;)Ljava/util/concurrent/ScheduledExecutorService;");
			global::java.util.concurrent.Executors._defaultThreadFactory21345 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "defaultThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
			global::java.util.concurrent.Executors._privilegedThreadFactory21346 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "privilegedThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
			global::java.util.concurrent.Executors._callable21347 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Callable;");
			global::java.util.concurrent.Executors._callable21348 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/security/PrivilegedAction;)Ljava/util/concurrent/Callable;");
			global::java.util.concurrent.Executors._callable21349 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/security/PrivilegedExceptionAction;)Ljava/util/concurrent/Callable;");
			global::java.util.concurrent.Executors._callable21350 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Callable;");
			global::java.util.concurrent.Executors._privilegedCallable21351 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "privilegedCallable", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;");
			global::java.util.concurrent.Executors._privilegedCallableUsingCurrentClassLoader21352 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "privilegedCallableUsingCurrentClassLoader", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;");
		}
	}
}
