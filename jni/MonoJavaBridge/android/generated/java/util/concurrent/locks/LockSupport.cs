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
		internal static global::MonoJavaBridge.MethodId _park21796;
		public static void park() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._park21796);
		}
		internal static global::MonoJavaBridge.MethodId _park21797;
		public static void park(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._park21797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unpark21798;
		public static void unpark(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._unpark21798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parkNanos21799;
		public static void parkNanos(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._parkNanos21799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parkNanos21800;
		public static void parkNanos(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._parkNanos21800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parkUntil21801;
		public static void parkUntil(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._parkUntil21801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parkUntil21802;
		public static void parkUntil(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._parkUntil21802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBlocker21803;
		public static global::java.lang.Object getBlocker(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.locks.LockSupport.staticClass, global::java.util.concurrent.locks.LockSupport._getBlocker21803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.LockSupport.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/LockSupport"));
			global::java.util.concurrent.locks.LockSupport._park21796 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "park", "()V");
			global::java.util.concurrent.locks.LockSupport._park21797 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "park", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.locks.LockSupport._unpark21798 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "unpark", "(Ljava/lang/Thread;)V");
			global::java.util.concurrent.locks.LockSupport._parkNanos21799 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkNanos", "(J)V");
			global::java.util.concurrent.locks.LockSupport._parkNanos21800 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkNanos", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.locks.LockSupport._parkUntil21801 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkUntil", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.locks.LockSupport._parkUntil21802 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "parkUntil", "(J)V");
			global::java.util.concurrent.locks.LockSupport._getBlocker21803 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.locks.LockSupport.staticClass, "getBlocker", "(Ljava/lang/Thread;)Ljava/lang/Object;");
		}
	}
}
