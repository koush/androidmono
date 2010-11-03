namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Executors : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Executors(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.util.concurrent.ExecutorService newFixedThreadPool(int arg0, java.util.concurrent.ThreadFactory arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m0.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m0 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newFixedThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.ExecutorService;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.util.concurrent.ExecutorService newFixedThreadPool(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m1.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m1 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newFixedThreadPool", "(I)Ljava/util/concurrent/ExecutorService;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.util.concurrent.ExecutorService newSingleThreadExecutor(java.util.concurrent.ThreadFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m2.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m2 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.util.concurrent.ExecutorService newSingleThreadExecutor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m3.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m3 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadExecutor", "()Ljava/util/concurrent/ExecutorService;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m3)) as java.util.concurrent.ExecutorService;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.util.concurrent.ExecutorService newCachedThreadPool(java.util.concurrent.ThreadFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m4.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m4 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newCachedThreadPool", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.util.concurrent.ExecutorService newCachedThreadPool()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m5.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m5 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newCachedThreadPool", "()Ljava/util/concurrent/ExecutorService;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m5)) as java.util.concurrent.ExecutorService;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.util.concurrent.ScheduledExecutorService newSingleThreadScheduledExecutor(java.util.concurrent.ThreadFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m6.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m6 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadScheduledExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ScheduledExecutorService;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.util.concurrent.ScheduledExecutorService newSingleThreadScheduledExecutor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m7.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m7 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newSingleThreadScheduledExecutor", "()Ljava/util/concurrent/ScheduledExecutorService;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m7)) as java.util.concurrent.ScheduledExecutorService;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.util.concurrent.ScheduledExecutorService newScheduledThreadPool(int arg0, java.util.concurrent.ThreadFactory arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m8.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m8 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newScheduledThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.ScheduledExecutorService;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.util.concurrent.ScheduledExecutorService newScheduledThreadPool(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m9.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m9 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "newScheduledThreadPool", "(I)Ljava/util/concurrent/ScheduledExecutorService;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ScheduledExecutorService;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.util.concurrent.ExecutorService unconfigurableExecutorService(java.util.concurrent.ExecutorService arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m10.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m10 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "unconfigurableExecutorService", "(Ljava/util/concurrent/ExecutorService;)Ljava/util/concurrent/ExecutorService;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ExecutorService;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.util.concurrent.ScheduledExecutorService unconfigurableScheduledExecutorService(java.util.concurrent.ScheduledExecutorService arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m11.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m11 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "unconfigurableScheduledExecutorService", "(Ljava/util/concurrent/ScheduledExecutorService;)Ljava/util/concurrent/ScheduledExecutorService;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ScheduledExecutorService>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.ScheduledExecutorService;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::java.util.concurrent.ThreadFactory defaultThreadFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m12.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m12 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "defaultThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ThreadFactory>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m12)) as java.util.concurrent.ThreadFactory;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::java.util.concurrent.ThreadFactory privilegedThreadFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m13.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m13 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "privilegedThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.ThreadFactory>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m13)) as java.util.concurrent.ThreadFactory;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::java.util.concurrent.Callable callable(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m14.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m14 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Callable;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		public static java.util.concurrent.Callable callable(global::java.lang.RunnableDelegate arg0)
		{
			return callable((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::java.util.concurrent.Callable callable(java.security.PrivilegedAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m15.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m15 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/security/PrivilegedAction;)Ljava/util/concurrent/Callable;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::java.util.concurrent.Callable callable(java.security.PrivilegedExceptionAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m16.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m16 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/security/PrivilegedExceptionAction;)Ljava/util/concurrent/Callable;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static global::java.util.concurrent.Callable callable(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m17.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m17 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "callable", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Callable;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Callable;
		}
		public static java.util.concurrent.Callable callable(global::java.lang.RunnableDelegate arg0, java.lang.Object arg1)
		{
			return callable((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static global::java.util.concurrent.Callable privilegedCallable(java.util.concurrent.Callable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m18.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m18 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "privilegedCallable", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static global::java.util.concurrent.Callable privilegedCallableUsingCurrentClassLoader(java.util.concurrent.Callable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Executors._m19.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Executors._m19 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.Executors.staticClass, "privilegedCallableUsingCurrentClassLoader", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Callable>(@__env.CallStaticObjectMethod(java.util.concurrent.Executors.staticClass, global::java.util.concurrent.Executors._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Callable;
		}
		static Executors()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Executors.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Executors"));
		}
	}
}
