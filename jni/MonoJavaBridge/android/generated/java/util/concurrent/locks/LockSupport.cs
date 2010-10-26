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
		internal static global::MonoJavaBridge.MethodId _park27744;
		public static void park() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._park27744);
		}
		internal static global::MonoJavaBridge.MethodId _park27745;
		public static void park(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._park27745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unpark27746;
		public static void unpark(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._unpark27746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parkNanos27747;
		public static void parkNanos(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._parkNanos27747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parkNanos27748;
		public static void parkNanos(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._parkNanos27748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parkUntil27749;
		public static void parkUntil(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._parkUntil27749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parkUntil27750;
		public static void parkUntil(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._parkUntil27750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBlocker27751;
		public static global::java.lang.Object getBlocker(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._getBlocker27751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.LockSupport.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/LockSupport"));
			global::java.util.concurrent.locks.LockSupport._park27744 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "park", "()V");
			global::java.util.concurrent.locks.LockSupport._park27745 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "park", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.locks.LockSupport._unpark27746 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "unpark", "(Ljava/lang/Thread;)V");
			global::java.util.concurrent.locks.LockSupport._parkNanos27747 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkNanos", "(J)V");
			global::java.util.concurrent.locks.LockSupport._parkNanos27748 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkNanos", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.locks.LockSupport._parkUntil27749 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkUntil", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.locks.LockSupport._parkUntil27750 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkUntil", "(J)V");
			global::java.util.concurrent.locks.LockSupport._getBlocker27751 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "getBlocker", "(Ljava/lang/Thread;)Ljava/lang/Object;");
		}
	}
}
