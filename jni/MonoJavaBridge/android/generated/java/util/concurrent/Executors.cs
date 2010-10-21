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
		internal static global::MonoJavaBridge.MethodId _newFixedThreadPool27163;
		public static global::java.util.concurrent.ExecutorService newFixedThreadPool(int arg0, java.util.concurrent.ThreadFactory arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newFixedThreadPool27163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newFixedThreadPool27164;
		public static global::java.util.concurrent.ExecutorService newFixedThreadPool(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newFixedThreadPool27164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newSingleThreadExecutor27165;
		public static global::java.util.concurrent.ExecutorService newSingleThreadExecutor(java.util.concurrent.ThreadFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newSingleThreadExecutor27165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newSingleThreadExecutor27166;
		public static global::java.util.concurrent.ExecutorService newSingleThreadExecutor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newSingleThreadExecutor27166)) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newCachedThreadPool27167;
		public static global::java.util.concurrent.ExecutorService newCachedThreadPool(java.util.concurrent.ThreadFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newCachedThreadPool27167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newCachedThreadPool27168;
		public static global::java.util.concurrent.ExecutorService newCachedThreadPool() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newCachedThreadPool27168)) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newSingleThreadScheduledExecutor27169;
		public static global::java.util.concurrent.ScheduledExecutorService newSingleThreadScheduledExecutor(java.util.concurrent.ThreadFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newSingleThreadScheduledExecutor27169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ScheduledExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newSingleThreadScheduledExecutor27170;
		public static global::java.util.concurrent.ScheduledExecutorService newSingleThreadScheduledExecutor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newSingleThreadScheduledExecutor27170)) as java.util.concurrent.ScheduledExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newScheduledThreadPool27171;
		public static global::java.util.concurrent.ScheduledExecutorService newScheduledThreadPool(int arg0, java.util.concurrent.ThreadFactory arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newScheduledThreadPool27171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.ScheduledExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _newScheduledThreadPool27172;
		public static global::java.util.concurrent.ScheduledExecutorService newScheduledThreadPool(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._newScheduledThreadPool27172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ScheduledExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _unconfigurableExecutorService27173;
		public static global::java.util.concurrent.ExecutorService unconfigurableExecutorService(java.util.concurrent.ExecutorService arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._unconfigurableExecutorService27173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _unconfigurableScheduledExecutorService27174;
		public static global::java.util.concurrent.ScheduledExecutorService unconfigurableScheduledExecutorService(java.util.concurrent.ScheduledExecutorService arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._unconfigurableScheduledExecutorService27174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ScheduledExecutorService;
		}
		internal static global::MonoJavaBridge.MethodId _defaultThreadFactory27175;
		public static global::java.util.concurrent.ThreadFactory defaultThreadFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ThreadFactory>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._defaultThreadFactory27175)) as java.util.concurrent.ThreadFactory;
		}
		internal static global::MonoJavaBridge.MethodId _privilegedThreadFactory27176;
		public static global::java.util.concurrent.ThreadFactory privilegedThreadFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ThreadFactory>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._privilegedThreadFactory27176)) as java.util.concurrent.ThreadFactory;
		}
		internal static global::MonoJavaBridge.MethodId _callable27177;
		public static global::java.util.concurrent.Callable callable(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._callable27177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		internal static global::MonoJavaBridge.MethodId _callable27178;
		public static global::java.util.concurrent.Callable callable(java.security.PrivilegedAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._callable27178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		internal static global::MonoJavaBridge.MethodId _callable27179;
		public static global::java.util.concurrent.Callable callable(java.security.PrivilegedExceptionAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._callable27179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		internal static global::MonoJavaBridge.MethodId _callable27180;
		public static global::java.util.concurrent.Callable callable(java.lang.Runnable arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._callable27180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Callable;
		}
		internal static global::MonoJavaBridge.MethodId _privilegedCallable27181;
		public static global::java.util.concurrent.Callable privilegedCallable(java.util.concurrent.Callable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._privilegedCallable27181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		internal static global::MonoJavaBridge.MethodId _privilegedCallableUsingCurrentClassLoader27182;
		public static global::java.util.concurrent.Callable privilegedCallableUsingCurrentClassLoader(java.util.concurrent.Callable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._privilegedCallableUsingCurrentClassLoader27182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Executors.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Executors"));
			global::java.util.concurrent.Executors._newFixedThreadPool27163 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newFixedThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newFixedThreadPool27164 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newFixedThreadPool", "(I)Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newSingleThreadExecutor27165 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newSingleThreadExecutor27166 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadExecutor", "()Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newCachedThreadPool27167 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newCachedThreadPool", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newCachedThreadPool27168 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newCachedThreadPool", "()Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._newSingleThreadScheduledExecutor27169 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadScheduledExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;");
			global::java.util.concurrent.Executors._newSingleThreadScheduledExecutor27170 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadScheduledExecutor", "()Ljava/util/concurrent/ScheduledExecutorService;");
			global::java.util.concurrent.Executors._newScheduledThreadPool27171 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newScheduledThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;");
			global::java.util.concurrent.Executors._newScheduledThreadPool27172 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newScheduledThreadPool", "(I)Ljava/util/concurrent/ScheduledExecutorService;");
			global::java.util.concurrent.Executors._unconfigurableExecutorService27173 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "unconfigurableExecutorService", "(Ljava/util/concurrent/ExecutorService;)Ljava/util/concurrent/ExecutorService;");
			global::java.util.concurrent.Executors._unconfigurableScheduledExecutorService27174 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "unconfigurableScheduledExecutorService", "(Ljava/util/concurrent/ScheduledExecutorService;)Ljava/util/concurrent/ScheduledExecutorService;");
			global::java.util.concurrent.Executors._defaultThreadFactory27175 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "defaultThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
			global::java.util.concurrent.Executors._privilegedThreadFactory27176 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "privilegedThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
			global::java.util.concurrent.Executors._callable27177 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Callable;");
			global::java.util.concurrent.Executors._callable27178 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/security/PrivilegedAction;)Ljava/util/concurrent/Callable;");
			global::java.util.concurrent.Executors._callable27179 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/security/PrivilegedExceptionAction;)Ljava/util/concurrent/Callable;");
			global::java.util.concurrent.Executors._callable27180 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Callable;");
			global::java.util.concurrent.Executors._privilegedCallable27181 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "privilegedCallable", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;");
			global::java.util.concurrent.Executors._privilegedCallableUsingCurrentClassLoader27182 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "privilegedCallableUsingCurrentClassLoader", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;");
		}
	}
}
