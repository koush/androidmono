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
		static Lock_()
		{
			InitJNI();
		}
		internal Lock_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _lock27739;
		void java.util.concurrent.locks.Lock.@lock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.Lock_._lock27739);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.Lock_.staticClass, global::java.util.concurrent.locks.Lock_._lock27739);
		}
		internal static global::MonoJavaBridge.MethodId _unlock27740;
		void java.util.concurrent.locks.Lock.unlock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.Lock_._unlock27740);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.Lock_.staticClass, global::java.util.concurrent.locks.Lock_._unlock27740);
		}
		internal static global::MonoJavaBridge.MethodId _lockInterruptibly27741;
		void java.util.concurrent.locks.Lock.lockInterruptibly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.Lock_._lockInterruptibly27741);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.Lock_.staticClass, global::java.util.concurrent.locks.Lock_._lockInterruptibly27741);
		}
		internal static global::MonoJavaBridge.MethodId _tryLock27742;
		bool java.util.concurrent.locks.Lock.tryLock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.Lock_._tryLock27742);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.Lock_.staticClass, global::java.util.concurrent.locks.Lock_._tryLock27742);
		}
		internal static global::MonoJavaBridge.MethodId _tryLock27743;
		bool java.util.concurrent.locks.Lock.tryLock(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.Lock_._tryLock27743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.Lock_.staticClass, global::java.util.concurrent.locks.Lock_._tryLock27743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newCondition27744;
		global::java.util.concurrent.locks.Condition java.util.concurrent.locks.Lock.newCondition()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.Lock_._newCondition27744)) as java.util.concurrent.locks.Condition;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.Lock_.staticClass, global::java.util.concurrent.locks.Lock_._newCondition27744)) as java.util.concurrent.locks.Condition;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.Lock_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/Lock"));
			global::java.util.concurrent.locks.Lock_._lock27739 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.Lock_.staticClass, "@lock", "()V");
			global::java.util.concurrent.locks.Lock_._unlock27740 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.Lock_.staticClass, "unlock", "()V");
			global::java.util.concurrent.locks.Lock_._lockInterruptibly27741 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.Lock_.staticClass, "lockInterruptibly", "()V");
			global::java.util.concurrent.locks.Lock_._tryLock27742 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.Lock_.staticClass, "tryLock", "()Z");
			global::java.util.concurrent.locks.Lock_._tryLock27743 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.Lock_.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.locks.Lock_._newCondition27744 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.Lock_.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;");
		}
	}
}
