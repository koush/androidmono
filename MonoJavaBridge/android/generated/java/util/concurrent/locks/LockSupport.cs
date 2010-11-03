namespace java.util.concurrent.locks
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LockSupport : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LockSupport(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void park()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.LockSupport._m0.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.LockSupport._m0 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "park", "()V");
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void park(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.LockSupport._m1.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.LockSupport._m1 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "park", "(Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void unpark(java.lang.Thread arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.LockSupport._m2.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.LockSupport._m2 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "unpark", "(Ljava/lang/Thread;)V");
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void parkNanos(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.LockSupport._m3.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.LockSupport._m3 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkNanos", "(J)V");
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void parkNanos(java.lang.Object arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.LockSupport._m4.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.LockSupport._m4 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkNanos", "(Ljava/lang/Object;J)V");
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void parkUntil(java.lang.Object arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.LockSupport._m5.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.LockSupport._m5 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkUntil", "(Ljava/lang/Object;J)V");
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void parkUntil(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.LockSupport._m6.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.LockSupport._m6 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkUntil", "(J)V");
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.lang.Object getBlocker(java.lang.Thread arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.LockSupport._m7.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.LockSupport._m7 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "getBlocker", "(Ljava/lang/Thread;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		static LockSupport()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.LockSupport.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/LockSupport"));
		}
	}
}
