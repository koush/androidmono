namespace java.util.concurrent.locks
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.locks.ReadWriteLock_))]
	public partial interface ReadWriteLock  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.util.concurrent.locks.Lock readLock();
		global::java.util.concurrent.locks.Lock writeLock();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.locks.ReadWriteLock))]
	internal sealed partial class ReadWriteLock_ : java.lang.Object, ReadWriteLock
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ReadWriteLock_()
		{
			InitJNI();
		}
		internal ReadWriteLock_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readLock27752;
		 global::java.util.concurrent.locks.Lock java.util.concurrent.locks.ReadWriteLock.readLock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReadWriteLock_._readLock27752)) as java.util.concurrent.locks.Lock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReadWriteLock_.staticClass, global::java.util.concurrent.locks.ReadWriteLock_._readLock27752)) as java.util.concurrent.locks.Lock;
		}
		internal static global::MonoJavaBridge.MethodId _writeLock27753;
		 global::java.util.concurrent.locks.Lock java.util.concurrent.locks.ReadWriteLock.writeLock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReadWriteLock_._writeLock27753)) as java.util.concurrent.locks.Lock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReadWriteLock_.staticClass, global::java.util.concurrent.locks.ReadWriteLock_._writeLock27753)) as java.util.concurrent.locks.Lock;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.ReadWriteLock_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReadWriteLock"));
			global::java.util.concurrent.locks.ReadWriteLock_._readLock27752 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReadWriteLock_.staticClass, "readLock", "()Ljava/util/concurrent/locks/Lock;");
			global::java.util.concurrent.locks.ReadWriteLock_._writeLock27753 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReadWriteLock_.staticClass, "writeLock", "()Ljava/util/concurrent/locks/Lock;");
		}
	}
}
