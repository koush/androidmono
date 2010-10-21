namespace java.util.concurrent.locks
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LockSupport : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LockSupport()
		{
			InitJNI();
		}
		protected LockSupport(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _park27626;
		public static void park() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._park27626);
		}
		internal static global::MonoJavaBridge.MethodId _park27627;
		public static void park(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._park27627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unpark27628;
		public static void unpark(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._unpark27628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parkNanos27629;
		public static void parkNanos(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._parkNanos27629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parkNanos27630;
		public static void parkNanos(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._parkNanos27630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parkUntil27631;
		public static void parkUntil(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._parkUntil27631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parkUntil27632;
		public static void parkUntil(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._parkUntil27632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBlocker27633;
		public static global::java.lang.Object getBlocker(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._getBlocker27633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.LockSupport.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/LockSupport"));
			global::java.util.concurrent.locks.LockSupport._park27626 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "park", "()V");
			global::java.util.concurrent.locks.LockSupport._park27627 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "park", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.locks.LockSupport._unpark27628 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "unpark", "(Ljava/lang/Thread;)V");
			global::java.util.concurrent.locks.LockSupport._parkNanos27629 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkNanos", "(J)V");
			global::java.util.concurrent.locks.LockSupport._parkNanos27630 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkNanos", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.locks.LockSupport._parkUntil27631 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkUntil", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.locks.LockSupport._parkUntil27632 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkUntil", "(J)V");
			global::java.util.concurrent.locks.LockSupport._getBlocker27633 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "getBlocker", "(Ljava/lang/Thread;)Ljava/lang/Object;");
		}
	}
}
