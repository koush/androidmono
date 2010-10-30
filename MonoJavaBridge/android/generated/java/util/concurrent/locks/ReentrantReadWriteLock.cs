namespace java.util.concurrent.locks
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ReentrantReadWriteLock : java.lang.Object, ReadWriteLock, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ReentrantReadWriteLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ReadLock : java.lang.Object, Lock, java.io.Serializable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ReadLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _lock27776;
			public virtual void @lock()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "@lock", "()V", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lock27776);
			}
			internal static global::MonoJavaBridge.MethodId _toString27777;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._toString27777) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _unlock27778;
			public virtual void unlock()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "unlock", "()V", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._unlock27778);
			}
			internal static global::MonoJavaBridge.MethodId _lockInterruptibly27779;
			public virtual void lockInterruptibly()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "lockInterruptibly", "()V", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lockInterruptibly27779);
			}
			internal static global::MonoJavaBridge.MethodId _tryLock27780;
			public virtual bool tryLock()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "tryLock", "()Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock27780);
			}
			internal static global::MonoJavaBridge.MethodId _tryLock27781;
			public virtual bool tryLock(long arg0, java.util.concurrent.TimeUnit arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock27781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _newCondition27782;
			public virtual global::java.util.concurrent.locks.Condition newCondition()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.locks.Condition>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._newCondition27782) as java.util.concurrent.locks.Condition;
			}
			internal static global::MonoJavaBridge.MethodId _ReadLock27783;
			protected ReadLock(java.util.concurrent.locks.ReentrantReadWriteLock arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._ReadLock27783.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._ReadLock27783 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "<init>", "(Ljava/util/concurrent/locks/ReentrantReadWriteLock;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._ReadLock27783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static ReadLock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantReadWriteLock$ReadLock"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class WriteLock : java.lang.Object, Lock, java.io.Serializable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected WriteLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _lock27784;
			public virtual void @lock()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "@lock", "()V", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lock27784);
			}
			internal static global::MonoJavaBridge.MethodId _toString27785;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._toString27785) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _unlock27786;
			public virtual void unlock()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "unlock", "()V", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._unlock27786);
			}
			internal static global::MonoJavaBridge.MethodId _lockInterruptibly27787;
			public virtual void lockInterruptibly()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "lockInterruptibly", "()V", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lockInterruptibly27787);
			}
			internal static global::MonoJavaBridge.MethodId _tryLock27788;
			public virtual bool tryLock(long arg0, java.util.concurrent.TimeUnit arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock27788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _tryLock27789;
			public virtual bool tryLock()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "tryLock", "()Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock27789);
			}
			internal static global::MonoJavaBridge.MethodId _newCondition27790;
			public virtual global::java.util.concurrent.locks.Condition newCondition()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.locks.Condition>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._newCondition27790) as java.util.concurrent.locks.Condition;
			}
			public new int HoldCount
			{
				get
				{
					return getHoldCount();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHoldCount27791;
			public virtual int getHoldCount()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "getHoldCount", "()I", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._getHoldCount27791);
			}
			internal static global::MonoJavaBridge.MethodId _isHeldByCurrentThread27792;
			public virtual bool isHeldByCurrentThread()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "isHeldByCurrentThread", "()Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._isHeldByCurrentThread27792);
			}
			internal static global::MonoJavaBridge.MethodId _WriteLock27793;
			protected WriteLock(java.util.concurrent.locks.ReentrantReadWriteLock arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._WriteLock27793.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._WriteLock27793 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "<init>", "(Ljava/util/concurrent/locks/ReentrantReadWriteLock;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._WriteLock27793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static WriteLock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantReadWriteLock$WriteLock"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString27794;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._toString27794) as java.lang.String;
		}
		protected new global::java.lang.Thread Owner
		{
			get
			{
				return getOwner();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOwner27795;
		protected virtual global::java.lang.Thread getOwner()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getOwner", "()Ljava/lang/Thread;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._getOwner27795) as java.lang.Thread;
		}
		internal static global::MonoJavaBridge.MethodId _isFair27796;
		public virtual bool isFair()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "isFair", "()Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._isFair27796);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThreads27797;
		public virtual bool hasQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "hasQueuedThreads", "()Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThreads27797);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThread27798;
		public virtual bool hasQueuedThread(java.lang.Thread arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "hasQueuedThread", "(Ljava/lang/Thread;)Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThread27798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int QueueLength
		{
			get
			{
				return getQueueLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueueLength27799;
		public virtual int getQueueLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueueLength", "()I", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueueLength27799);
		}
		protected new global::java.util.Collection QueuedThreads
		{
			get
			{
				return getQueuedThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedThreads27800;
		protected virtual global::java.util.Collection getQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueuedThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedThreads27800) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hasWaiters27801;
		public virtual bool hasWaiters(java.util.concurrent.locks.Condition arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "hasWaiters", "(Ljava/util/concurrent/locks/Condition;)Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._hasWaiters27801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitQueueLength27802;
		public virtual int getWaitQueueLength(java.util.concurrent.locks.Condition arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getWaitQueueLength", "(Ljava/util/concurrent/locks/Condition;)I", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitQueueLength27802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitingThreads27803;
		protected virtual global::java.util.Collection getWaitingThreads(java.util.concurrent.locks.Condition arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getWaitingThreads", "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitingThreads27803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _readLock27804;
		public virtual global::java.util.concurrent.locks.Lock readLock()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.locks.Lock>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "readLock", "()Ljava/util/concurrent/locks/Lock;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._readLock27804) as java.util.concurrent.locks.Lock;
		}
		internal static global::MonoJavaBridge.MethodId _writeLock27805;
		public virtual global::java.util.concurrent.locks.Lock writeLock()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.locks.Lock>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "writeLock", "()Ljava/util/concurrent/locks/Lock;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._writeLock27805) as java.util.concurrent.locks.Lock;
		}
		public new int ReadLockCount
		{
			get
			{
				return getReadLockCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReadLockCount27806;
		public virtual int getReadLockCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getReadLockCount", "()I", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadLockCount27806);
		}
		internal static global::MonoJavaBridge.MethodId _isWriteLocked27807;
		public virtual bool isWriteLocked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "isWriteLocked", "()Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLocked27807);
		}
		internal static global::MonoJavaBridge.MethodId _isWriteLockedByCurrentThread27808;
		public virtual bool isWriteLockedByCurrentThread()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "isWriteLockedByCurrentThread", "()Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLockedByCurrentThread27808);
		}
		public new int WriteHoldCount
		{
			get
			{
				return getWriteHoldCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWriteHoldCount27809;
		public virtual int getWriteHoldCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getWriteHoldCount", "()I", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._getWriteHoldCount27809);
		}
		public new int ReadHoldCount
		{
			get
			{
				return getReadHoldCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReadHoldCount27810;
		public virtual int getReadHoldCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getReadHoldCount", "()I", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadHoldCount27810);
		}
		protected new global::java.util.Collection QueuedWriterThreads
		{
			get
			{
				return getQueuedWriterThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedWriterThreads27811;
		protected virtual global::java.util.Collection getQueuedWriterThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueuedWriterThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedWriterThreads27811) as java.util.Collection;
		}
		protected new global::java.util.Collection QueuedReaderThreads
		{
			get
			{
				return getQueuedReaderThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedReaderThreads27812;
		protected virtual global::java.util.Collection getQueuedReaderThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueuedReaderThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedReaderThreads27812) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _ReentrantReadWriteLock27813;
		public ReentrantReadWriteLock(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock27813.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock27813 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock27813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ReentrantReadWriteLock27814;
		public ReentrantReadWriteLock() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock27814.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock27814 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock27814);
			Init(@__env, handle);
		}
		static ReentrantReadWriteLock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantReadWriteLock"));
		}
		internal static void InitJNI()
		{
		}
	}
}
