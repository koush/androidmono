namespace java.util.concurrent.locks
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ReentrantLock : java.lang.Object, Lock, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ReentrantLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void @lock()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "@lock", "()V", ref global::java.util.concurrent.locks.ReentrantLock._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.locks.ReentrantLock._m1) as java.lang.String;
		}
		protected new global::java.lang.Thread Owner
		{
			get
			{
				return getOwner();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual global::java.lang.Thread getOwner()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "getOwner", "()Ljava/lang/Thread;", ref global::java.util.concurrent.locks.ReentrantLock._m2) as java.lang.Thread;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void unlock()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "unlock", "()V", ref global::java.util.concurrent.locks.ReentrantLock._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void lockInterruptibly()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "lockInterruptibly", "()V", ref global::java.util.concurrent.locks.ReentrantLock._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool tryLock(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.locks.ReentrantLock._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool tryLock()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "tryLock", "()Z", ref global::java.util.concurrent.locks.ReentrantLock._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.util.concurrent.locks.Condition newCondition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.locks.Condition>(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;", ref global::java.util.concurrent.locks.ReentrantLock._m7) as java.util.concurrent.locks.Condition;
		}
		public new int HoldCount
		{
			get
			{
				return getHoldCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getHoldCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "getHoldCount", "()I", ref global::java.util.concurrent.locks.ReentrantLock._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isHeldByCurrentThread()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "isHeldByCurrentThread", "()Z", ref global::java.util.concurrent.locks.ReentrantLock._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isLocked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "isLocked", "()Z", ref global::java.util.concurrent.locks.ReentrantLock._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool isFair()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "isFair", "()Z", ref global::java.util.concurrent.locks.ReentrantLock._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool hasQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "hasQueuedThreads", "()Z", ref global::java.util.concurrent.locks.ReentrantLock._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool hasQueuedThread(java.lang.Thread arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "hasQueuedThread", "(Ljava/lang/Thread;)Z", ref global::java.util.concurrent.locks.ReentrantLock._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int QueueLength
		{
			get
			{
				return getQueueLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int getQueueLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "getQueueLength", "()I", ref global::java.util.concurrent.locks.ReentrantLock._m14);
		}
		protected new global::java.util.Collection QueuedThreads
		{
			get
			{
				return getQueuedThreads();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected virtual global::java.util.Collection getQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "getQueuedThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.ReentrantLock._m15) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool hasWaiters(java.util.concurrent.locks.Condition arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "hasWaiters", "(Ljava/util/concurrent/locks/Condition;)Z", ref global::java.util.concurrent.locks.ReentrantLock._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual int getWaitQueueLength(java.util.concurrent.locks.Condition arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "getWaitQueueLength", "(Ljava/util/concurrent/locks/Condition;)I", ref global::java.util.concurrent.locks.ReentrantLock._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		protected virtual global::java.util.Collection getWaitingThreads(java.util.concurrent.locks.Condition arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.ReentrantLock.staticClass, "getWaitingThreads", "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection;", ref global::java.util.concurrent.locks.ReentrantLock._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public ReentrantLock() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.ReentrantLock._m19.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.ReentrantLock._m19 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._m19);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public ReentrantLock(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.ReentrantLock._m20.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.ReentrantLock._m20 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ReentrantLock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.ReentrantLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantLock"));
		}
	}
}
