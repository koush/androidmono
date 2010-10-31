namespace java.util.concurrent.locks
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.locks.Lock_))]
	public partial interface Lock  : global::MonoJavaBridge.IJavaObject 
	{
		void @lock();
		void unlock();
		void lockInterruptibly();
		bool tryLock();
		bool tryLock(long arg0, java.util.concurrent.TimeUnit arg1);
		global::java.util.concurrent.locks.Condition newCondition();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.locks.Lock))]
	internal sealed partial class Lock_ : java.lang.Object, Lock
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Lock_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void java.util.concurrent.locks.Lock.@lock()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.Lock_.staticClass, "@lock", "()V", ref global::java.util.concurrent.locks.Lock_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void java.util.concurrent.locks.Lock.unlock()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.Lock_.staticClass, "unlock", "()V", ref global::java.util.concurrent.locks.Lock_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void java.util.concurrent.locks.Lock.lockInterruptibly()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.Lock_.staticClass, "lockInterruptibly", "()V", ref global::java.util.concurrent.locks.Lock_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool java.util.concurrent.locks.Lock.tryLock()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.Lock_.staticClass, "tryLock", "()Z", ref global::java.util.concurrent.locks.Lock_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool java.util.concurrent.locks.Lock.tryLock(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.Lock_.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.locks.Lock_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.util.concurrent.locks.Condition java.util.concurrent.locks.Lock.newCondition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.locks.Condition>(this, global::java.util.concurrent.locks.Lock_.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;", ref global::java.util.concurrent.locks.Lock_._m5) as java.util.concurrent.locks.Condition;
		}
		static Lock_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.Lock_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/Lock"));
		}
	}
}
