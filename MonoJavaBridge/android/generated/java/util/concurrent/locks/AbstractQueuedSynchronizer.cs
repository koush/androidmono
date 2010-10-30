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
			internal static global::MonoJavaBridge.MethodId _hasWaiters27691;
			protected virtual bool hasWaiters()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "hasWaiters", "()Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._hasWaiters27691);
			}
			protected new int WaitQueueLength
			{
				get
				{
					return getWaitQueueLength();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getWaitQueueLength27692;
			protected virtual int getWaitQueueLength()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "getWaitQueueLength", "()I", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._getWaitQueueLength27692);
			}
			protected new global::java.util.Collection WaitingThreads
			{
				get
				{
					return getWaitingThreads();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getWaitingThreads27693;
			protected virtual global::java.util.Collection getWaitingThreads()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "getWaitingThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._getWaitingThreads27693) as java.util.Collection;
			}
			internal static global::MonoJavaBridge.MethodId _await27694;
			public virtual bool await(long arg0, java.util.concurrent.TimeUnit arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "await", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._await27694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _await27695;
			public virtual void await()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "await", "()V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._await27695);
			}
			internal static global::MonoJavaBridge.MethodId _signal27696;
			public virtual void signal()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "signal", "()V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._signal27696);
			}
			internal static global::MonoJavaBridge.MethodId _signalAll27697;
			public virtual void signalAll()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "signalAll", "()V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._signalAll27697);
			}
			internal static global::MonoJavaBridge.MethodId _awaitUninterruptibly27698;
			public virtual void awaitUninterruptibly()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "awaitUninterruptibly", "()V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitUninterruptibly27698);
			}
			internal static global::MonoJavaBridge.MethodId _awaitNanos27699;
			public virtual long awaitNanos(long arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "awaitNanos", "(J)J", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitNanos27699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _awaitUntil27700;
			public virtual bool awaitUntil(java.util.Date arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "awaitUntil", "(Ljava/util/Date;)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitUntil27700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _ConditionObject27701;
			public ConditionObject(java.util.concurrent.locks.AbstractQueuedSynchronizer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._ConditionObject27701.native == global::System.IntPtr.Zero)
					global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._ConditionObject27701 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "<init>", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._ConditionObject27701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static ConditionObject()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString27702;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._toString27702) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getState27703;
		protected virtual int getState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getState", "()I", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getState27703);
		}
		internal static global::MonoJavaBridge.MethodId _setState27704;
		protected virtual void setState(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "setState", "(I)V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._setState27704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acquire27705;
		public virtual void acquire(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquire", "(I)V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquire27705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _release27706;
		public virtual bool release(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "release", "(I)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._release27706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThreads27707;
		public virtual bool hasQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "hasQueuedThreads", "()Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasQueuedThreads27707);
		}
		internal static global::MonoJavaBridge.MethodId _getQueueLength27708;
		public virtual int getQueueLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getQueueLength", "()I", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getQueueLength27708);
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedThreads27709;
		public virtual global::java.util.Collection getQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getQueuedThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getQueuedThreads27709) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hasWaiters27710;
		public virtual bool hasWaiters(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "hasWaiters", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasWaiters27710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitQueueLength27711;
		public virtual int getWaitQueueLength(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getWaitQueueLength", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)I", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getWaitQueueLength27711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitingThreads27712;
		public virtual global::java.util.Collection getWaitingThreads(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getWaitingThreads", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Ljava/util/Collection;", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getWaitingThreads27712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _acquireInterruptibly27713;
		public virtual void acquireInterruptibly(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquireInterruptibly", "(I)V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireInterruptibly27713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquireNanos27714;
		public virtual bool tryAcquireNanos(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquireNanos", "(IJ)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireNanos27714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isHeldExclusively27715;
		protected virtual bool isHeldExclusively()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "isHeldExclusively", "()Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._isHeldExclusively27715);
		}
		internal static global::MonoJavaBridge.MethodId _isQueued27716;
		public virtual bool isQueued(java.lang.Thread arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "isQueued", "(Ljava/lang/Thread;)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._isQueued27716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire27717;
		protected virtual bool tryAcquire(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquire", "(I)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquire27717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSetState27718;
		protected virtual bool compareAndSetState(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "compareAndSetState", "(II)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._compareAndSetState27718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tryRelease27719;
		protected virtual bool tryRelease(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryRelease", "(I)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryRelease27719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquireShared27720;
		protected virtual int tryAcquireShared(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquireShared", "(I)I", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireShared27720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryReleaseShared27721;
		protected virtual bool tryReleaseShared(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryReleaseShared", "(I)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryReleaseShared27721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acquireShared27722;
		public virtual void acquireShared(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquireShared", "(I)V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireShared27722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acquireSharedInterruptibly27723;
		public virtual void acquireSharedInterruptibly(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquireSharedInterruptibly", "(I)V", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireSharedInterruptibly27723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquireSharedNanos27724;
		public virtual bool tryAcquireSharedNanos(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquireSharedNanos", "(IJ)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireSharedNanos27724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _releaseShared27725;
		public virtual bool releaseShared(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "releaseShared", "(I)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._releaseShared27725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasContended27726;
		public virtual bool hasContended()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "hasContended", "()Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasContended27726);
		}
		internal static global::MonoJavaBridge.MethodId _getFirstQueuedThread27727;
		public virtual global::java.lang.Thread getFirstQueuedThread()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getFirstQueuedThread", "()Ljava/lang/Thread;", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getFirstQueuedThread27727) as java.lang.Thread;
		}
		internal static global::MonoJavaBridge.MethodId _getExclusiveQueuedThreads27728;
		public virtual global::java.util.Collection getExclusiveQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getExclusiveQueuedThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getExclusiveQueuedThreads27728) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _getSharedQueuedThreads27729;
		public virtual global::java.util.Collection getSharedQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getSharedQueuedThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getSharedQueuedThreads27729) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _owns27730;
		public virtual bool owns(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "owns", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Z", ref global::java.util.concurrent.locks.AbstractQueuedSynchronizer._owns27730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractQueuedSynchronizer27731;
		protected AbstractQueuedSynchronizer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.locks.AbstractQueuedSynchronizer._AbstractQueuedSynchronizer27731.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer._AbstractQueuedSynchronizer27731 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._AbstractQueuedSynchronizer27731);
			Init(@__env, handle);
		}
		static AbstractQueuedSynchronizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/AbstractQueuedSynchronizer"));
		}
		internal static void InitJNI()
		{
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
		internal static void InitJNI()
		{
		}
	}
}
