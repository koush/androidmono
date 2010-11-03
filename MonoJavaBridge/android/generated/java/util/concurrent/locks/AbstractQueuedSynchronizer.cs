namespace java.util.concurrent.locks
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.locks.AbstractQueuedSynchronizer_))]
	public abstract partial class AbstractQueuedSynchronizer : java.util.concurrent.locks.AbstractOwnableSynchronizer, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractQueuedSynchronizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ConditionObject : java.lang.Object, Condition, java.io.Serializable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ConditionObject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			protected virtual bool hasWaiters()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "hasWaiters", "()Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._m0);
			}
			protected new int WaitQueueLength
			{
				get
				{
					return getWaitQueueLength();
				}
			}
			private static global::MonoJavaBridge.MethodId _m1;
			protected virtual int getWaitQueueLength()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "getWaitQueueLength", "()I", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._m1);
			}
			protected new global::java.util.Collection WaitingThreads
			{
				get
				{
					return getWaitingThreads();
				}
			}
			private static global::MonoJavaBridge.MethodId _m2;
			protected virtual global::java.util.Collection getWaitingThreads()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "getWaitingThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._m2) as java.util.Collection;
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual bool await(long arg0, java.util.concurrent.TimeUnit arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "await", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual void await()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "await", "()V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._m4);
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual void signal()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "signal", "()V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._m5);
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public virtual void signalAll()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "signalAll", "()V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._m6);
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public virtual void awaitUninterruptibly()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "awaitUninterruptibly", "()V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._m7);
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public virtual long awaitNanos(long arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "awaitNanos", "(J)J", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m9;
			public virtual bool awaitUntil(java.util.Date arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "awaitUntil", "(Ljava/util/Date;)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m10;
			public ConditionObject(java.util.concurrent.locks.AbstractQueuedSynchronizer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._m10.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._m10 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "<init>", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static ConditionObject()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected virtual int getState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getState", "()I", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual void setState(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "setState", "(I)V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void acquire(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquire", "(I)V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool release(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "release", "(I)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool hasQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "hasQueuedThreads", "()Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getQueueLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getQueueLength", "()I", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.util.Collection getQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getQueuedThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m7) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool hasWaiters(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "hasWaiters", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getWaitQueueLength(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getWaitQueueLength", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)I", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.util.Collection getWaitingThreads(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getWaitingThreads", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Ljava/util/Collection;", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void acquireInterruptibly(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquireInterruptibly", "(I)V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool tryAcquireNanos(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquireNanos", "(IJ)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected virtual bool isHeldExclusively()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "isHeldExclusively", "()Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool isQueued(java.lang.Thread arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "isQueued", "(Ljava/lang/Thread;)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected virtual bool tryAcquire(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquire", "(I)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected virtual bool compareAndSetState(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "compareAndSetState", "(II)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected virtual bool tryRelease(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryRelease", "(I)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		protected virtual int tryAcquireShared(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquireShared", "(I)I", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected virtual bool tryReleaseShared(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryReleaseShared", "(I)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void acquireShared(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquireShared", "(I)V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void acquireSharedInterruptibly(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquireSharedInterruptibly", "(I)V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool tryAcquireSharedNanos(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquireSharedNanos", "(IJ)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool releaseShared(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "releaseShared", "(I)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool hasContended()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "hasContended", "()Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.lang.Thread getFirstQueuedThread()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getFirstQueuedThread", "()Ljava/lang/Thread;", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m25) as java.lang.Thread;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::java.util.Collection getExclusiveQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getExclusiveQueuedThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m26) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::java.util.Collection getSharedQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getSharedQueuedThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m27) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual bool owns(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "owns", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		protected AbstractQueuedSynchronizer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m29.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m29 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._m29);
			Init(@__env, handle);
		}
		static AbstractQueuedSynchronizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/AbstractQueuedSynchronizer"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.locks.AbstractQueuedSynchronizer))]
	internal sealed partial class AbstractQueuedSynchronizer_ : java.util.concurrent.locks.AbstractQueuedSynchronizer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractQueuedSynchronizer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static AbstractQueuedSynchronizer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/AbstractQueuedSynchronizer"));
		}
	}
}
