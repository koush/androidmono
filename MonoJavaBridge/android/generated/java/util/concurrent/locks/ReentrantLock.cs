namespace java.util.concurrent.locks
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ReentrantLock : java.lang.Object, Lock, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ReentrantLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _lock27755;
		public virtual void @lock()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "@lock", "()V", ref global::java.util.concurrent.locks.ReentrantLock._lock27755);
		}
		internal static global::MonoJavaBridge.MethodId _toString27756;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.locks.ReentrantLock._toString27756) as java.lang.String;
		}
		protected new global::java.lang.Thread Owner
		{
			get
			{
				return getOwner();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOwner27757;
		protected virtual global::java.lang.Thread getOwner()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "getOwner", "()Ljava/lang/Thread;", ref global::java.util.concurrent.locks.ReentrantLock._getOwner27757) as java.lang.Thread;
		}
		internal static global::MonoJavaBridge.MethodId _unlock27758;
		public virtual void unlock()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "unlock", "()V", ref global::java.util.concurrent.locks.ReentrantLock._unlock27758);
		}
		internal static global::MonoJavaBridge.MethodId _lockInterruptibly27759;
		public virtual void lockInterruptibly()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "lockInterruptibly", "()V", ref global::java.util.concurrent.locks.ReentrantLock._lockInterruptibly27759);
		}
		internal static global::MonoJavaBridge.MethodId _tryLock27760;
		public virtual bool tryLock(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.locks.ReentrantLock._tryLock27760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tryLock27761;
		public virtual bool tryLock()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "tryLock", "()Z", ref global::java.util.concurrent.locks.ReentrantLock._tryLock27761);
		}
		internal static global::MonoJavaBridge.MethodId _newCondition27762;
		public virtual global::java.util.concurrent.locks.Condition newCondition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.locks.Condition>(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;", ref global::java.util.concurrent.locks.ReentrantLock._newCondition27762) as java.util.concurrent.locks.Condition;
		}
		public new int HoldCount
		{
			get
			{
				return getHoldCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHoldCount27763;
		public virtual int getHoldCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "getHoldCount", "()I", ref global::java.util.concurrent.locks.ReentrantLock._getHoldCount27763);
		}
		internal static global::MonoJavaBridge.MethodId _isHeldByCurrentThread27764;
		public virtual bool isHeldByCurrentThread()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "isHeldByCurrentThread", "()Z", ref global::java.util.concurrent.locks.ReentrantLock._isHeldByCurrentThread27764);
		}
		internal static global::MonoJavaBridge.MethodId _isLocked27765;
		public virtual bool isLocked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "isLocked", "()Z", ref global::java.util.concurrent.locks.ReentrantLock._isLocked27765);
		}
		internal static global::MonoJavaBridge.MethodId _isFair27766;
		public virtual bool isFair()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "isFair", "()Z", ref global::java.util.concurrent.locks.ReentrantLock._isFair27766);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThreads27767;
		public virtual bool hasQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "hasQueuedThreads", "()Z", ref global::java.util.concurrent.locks.ReentrantLock._hasQueuedThreads27767);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThread27768;
		public virtual bool hasQueuedThread(java.lang.Thread arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "hasQueuedThread", "(Ljava/lang/Thread;)Z", ref global::java.util.concurrent.locks.ReentrantLock._hasQueuedThread27768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int QueueLength
		{
			get
			{
				return getQueueLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueueLength27769;
		public virtual int getQueueLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "getQueueLength", "()I", ref global::java.util.concurrent.locks.ReentrantLock._getQueueLength27769);
		}
		protected new global::java.util.Collection QueuedThreads
		{
			get
			{
				return getQueuedThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedThreads27770;
		protected virtual global::java.util.Collection getQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "getQueuedThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.ReentrantLock._getQueuedThreads27770) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hasWaiters27771;
		public virtual bool hasWaiters(java.util.concurrent.locks.Condition arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "hasWaiters", "(Ljava/util/concurrent/locks/Condition;)Z", ref global::java.util.concurrent.locks.ReentrantLock._hasWaiters27771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitQueueLength27772;
		public virtual int getWaitQueueLength(java.util.concurrent.locks.Condition arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "getWaitQueueLength", "(Ljava/util/concurrent/locks/Condition;)I", ref global::java.util.concurrent.locks.ReentrantLock._getWaitQueueLength27772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitingThreads27773;
		protected virtual global::java.util.Collection getWaitingThreads(java.util.concurrent.locks.Condition arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "getWaitingThreads", "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection;", ref global::java.util.concurrent.locks.ReentrantLock._getWaitingThreads27773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _ReentrantLock27774;
		public ReentrantLock() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.ReentrantLock._ReentrantLock27774.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.ReentrantLock._ReentrantLock27774 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._ReentrantLock27774);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ReentrantLock27775;
		public ReentrantLock(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.ReentrantLock._ReentrantLock27775.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.ReentrantLock._ReentrantLock27775 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._ReentrantLock27775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ReentrantLock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.ReentrantLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantLock"));
		}
		internal static void InitJNI()
		{
		}
	}
}
