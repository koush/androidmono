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
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void @lock()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "@lock", "()V", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._m1) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void unlock()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "unlock", "()V", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual void lockInterruptibly()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "lockInterruptibly", "()V", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._m3);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual bool tryLock()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "tryLock", "()Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._m4);
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual bool tryLock(long arg0, java.util.concurrent.TimeUnit arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public virtual global::java.util.concurrent.locks.Condition newCondition()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.locks.Condition>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._m6) as java.util.concurrent.locks.Condition;
			}
			private static global::MonoJavaBridge.MethodId _m7;
			protected ReadLock(java.util.concurrent.locks.ReentrantReadWriteLock arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._m7.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._m7 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "<init>", "(Ljava/util/concurrent/locks/ReentrantReadWriteLock;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static ReadLock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantReadWriteLock$ReadLock"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class WriteLock : java.lang.Object, Lock, java.io.Serializable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected WriteLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void @lock()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "@lock", "()V", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._m1) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void unlock()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "unlock", "()V", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual void lockInterruptibly()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "lockInterruptibly", "()V", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._m3);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual bool tryLock(long arg0, java.util.concurrent.TimeUnit arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual bool tryLock()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "tryLock", "()Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._m5);
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public virtual global::java.util.concurrent.locks.Condition newCondition()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.locks.Condition>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._m6) as java.util.concurrent.locks.Condition;
			}
			public new int HoldCount
			{
				get
				{
					return getHoldCount();
				}
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public virtual int getHoldCount()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "getHoldCount", "()I", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._m7);
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public virtual bool isHeldByCurrentThread()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "isHeldByCurrentThread", "()Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._m8);
			}
			private static global::MonoJavaBridge.MethodId _m9;
			protected WriteLock(java.util.concurrent.locks.ReentrantReadWriteLock arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._m9.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._m9 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "<init>", "(Ljava/util/concurrent/locks/ReentrantReadWriteLock;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static WriteLock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantReadWriteLock$WriteLock"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m0) as java.lang.String;
		}
		protected new global::java.lang.Thread Owner
		{
			get
			{
				return getOwner();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected virtual global::java.lang.Thread getOwner()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getOwner", "()Ljava/lang/Thread;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m1) as java.lang.Thread;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool isFair()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "isFair", "()Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool hasQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "hasQueuedThreads", "()Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool hasQueuedThread(java.lang.Thread arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "hasQueuedThread", "(Ljava/lang/Thread;)Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int QueueLength
		{
			get
			{
				return getQueueLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getQueueLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueueLength", "()I", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m5);
		}
		protected new global::java.util.Collection QueuedThreads
		{
			get
			{
				return getQueuedThreads();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected virtual global::java.util.Collection getQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueuedThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m6) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool hasWaiters(java.util.concurrent.locks.Condition arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "hasWaiters", "(Ljava/util/concurrent/locks/Condition;)Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getWaitQueueLength(java.util.concurrent.locks.Condition arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getWaitQueueLength", "(Ljava/util/concurrent/locks/Condition;)I", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual global::java.util.Collection getWaitingThreads(java.util.concurrent.locks.Condition arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getWaitingThreads", "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.util.concurrent.locks.Lock readLock()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.locks.Lock>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "readLock", "()Ljava/util/concurrent/locks/Lock;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m10) as java.util.concurrent.locks.Lock;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.util.concurrent.locks.Lock writeLock()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.locks.Lock>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "writeLock", "()Ljava/util/concurrent/locks/Lock;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m11) as java.util.concurrent.locks.Lock;
		}
		public new int ReadLockCount
		{
			get
			{
				return getReadLockCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int getReadLockCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getReadLockCount", "()I", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool isWriteLocked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "isWriteLocked", "()Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool isWriteLockedByCurrentThread()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "isWriteLockedByCurrentThread", "()Z", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m14);
		}
		public new int WriteHoldCount
		{
			get
			{
				return getWriteHoldCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int getWriteHoldCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getWriteHoldCount", "()I", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m15);
		}
		public new int ReadHoldCount
		{
			get
			{
				return getReadHoldCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int getReadHoldCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getReadHoldCount", "()I", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m16);
		}
		protected new global::java.util.Collection QueuedWriterThreads
		{
			get
			{
				return getQueuedWriterThreads();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected virtual global::java.util.Collection getQueuedWriterThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueuedWriterThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m17) as java.util.Collection;
		}
		protected new global::java.util.Collection QueuedReaderThreads
		{
			get
			{
				return getQueuedReaderThreads();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		protected virtual global::java.util.Collection getQueuedReaderThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueuedReaderThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.ReentrantReadWriteLock._m18) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public ReentrantReadWriteLock(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.ReentrantReadWriteLock._m19.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.ReentrantReadWriteLock._m19 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public ReentrantReadWriteLock() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.ReentrantReadWriteLock._m20.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.ReentrantReadWriteLock._m20 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._m20);
			Init(@__env, handle);
		}
		static ReentrantReadWriteLock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantReadWriteLock"));
		}
	}
}
