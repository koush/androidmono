namespace java.util.concurrent.locks
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.locks.AbstractQueuedSynchronizer_))]
	public abstract partial class AbstractQueuedSynchronizer : java.util.concurrent.locks.AbstractOwnableSynchronizer, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractQueuedSynchronizer()
		{
			InitJNI();
		}
		protected AbstractQueuedSynchronizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ConditionObject : java.lang.Object, Condition, java.io.Serializable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ConditionObject()
			{
				InitJNI();
			}
			protected ConditionObject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _hasWaiters27690;
			protected virtual bool hasWaiters()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._hasWaiters27690);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._hasWaiters27690);
			}
			protected new int WaitQueueLength
			{
				get
				{
					return getWaitQueueLength();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getWaitQueueLength27691;
			protected virtual int getWaitQueueLength()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._getWaitQueueLength27691);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._getWaitQueueLength27691);
			}
			protected new global::java.util.Collection WaitingThreads
			{
				get
				{
					return getWaitingThreads();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getWaitingThreads27692;
			protected virtual global::java.util.Collection getWaitingThreads()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._getWaitingThreads27692)) as java.util.Collection;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._getWaitingThreads27692)) as java.util.Collection;
			}
			internal static global::MonoJavaBridge.MethodId _await27693;
			public virtual bool await(long arg0, java.util.concurrent.TimeUnit arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._await27693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._await27693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _await27694;
			public virtual void await()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._await27694);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._await27694);
			}
			internal static global::MonoJavaBridge.MethodId _signal27695;
			public virtual void signal()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._signal27695);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._signal27695);
			}
			internal static global::MonoJavaBridge.MethodId _signalAll27696;
			public virtual void signalAll()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._signalAll27696);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._signalAll27696);
			}
			internal static global::MonoJavaBridge.MethodId _awaitUninterruptibly27697;
			public virtual void awaitUninterruptibly()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitUninterruptibly27697);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitUninterruptibly27697);
			}
			internal static global::MonoJavaBridge.MethodId _awaitNanos27698;
			public virtual long awaitNanos(long arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitNanos27698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitNanos27698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _awaitUntil27699;
			public virtual bool awaitUntil(java.util.Date arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitUntil27699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitUntil27699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _ConditionObject27700;
			public ConditionObject(java.util.concurrent.locks.AbstractQueuedSynchronizer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._ConditionObject27700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject"));
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._hasWaiters27690 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "hasWaiters", "()Z");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._getWaitQueueLength27691 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "getWaitQueueLength", "()I");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._getWaitingThreads27692 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "getWaitingThreads", "()Ljava/util/Collection;");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._await27693 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "await", "(JLjava/util/concurrent/TimeUnit;)Z");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._await27694 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "await", "()V");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._signal27695 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "signal", "()V");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._signalAll27696 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "signalAll", "()V");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitUninterruptibly27697 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "awaitUninterruptibly", "()V");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitNanos27698 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "awaitNanos", "(J)J");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitUntil27699 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "awaitUntil", "(Ljava/util/Date;)Z");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._ConditionObject27700 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "<init>", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString27701;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._toString27701)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._toString27701)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getState27702;
		protected virtual int getState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getState27702);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getState27702);
		}
		internal static global::MonoJavaBridge.MethodId _setState27703;
		protected virtual void setState(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._setState27703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._setState27703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acquire27704;
		public virtual void acquire(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquire27704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquire27704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _release27705;
		public virtual bool release(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._release27705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._release27705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThreads27706;
		public virtual bool hasQueuedThreads()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasQueuedThreads27706);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasQueuedThreads27706);
		}
		internal static global::MonoJavaBridge.MethodId _getQueueLength27707;
		public virtual int getQueueLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getQueueLength27707);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getQueueLength27707);
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedThreads27708;
		public virtual global::java.util.Collection getQueuedThreads()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getQueuedThreads27708)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getQueuedThreads27708)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hasWaiters27709;
		public virtual bool hasWaiters(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasWaiters27709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasWaiters27709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitQueueLength27710;
		public virtual int getWaitQueueLength(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getWaitQueueLength27710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getWaitQueueLength27710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitingThreads27711;
		public virtual global::java.util.Collection getWaitingThreads(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getWaitingThreads27711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getWaitingThreads27711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _acquireInterruptibly27712;
		public virtual void acquireInterruptibly(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireInterruptibly27712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireInterruptibly27712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquireNanos27713;
		public virtual bool tryAcquireNanos(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireNanos27713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireNanos27713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isHeldExclusively27714;
		protected virtual bool isHeldExclusively()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._isHeldExclusively27714);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._isHeldExclusively27714);
		}
		internal static global::MonoJavaBridge.MethodId _isQueued27715;
		public virtual bool isQueued(java.lang.Thread arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._isQueued27715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._isQueued27715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire27716;
		protected virtual bool tryAcquire(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquire27716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquire27716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSetState27717;
		protected virtual bool compareAndSetState(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._compareAndSetState27717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._compareAndSetState27717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tryRelease27718;
		protected virtual bool tryRelease(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryRelease27718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryRelease27718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquireShared27719;
		protected virtual int tryAcquireShared(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireShared27719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireShared27719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryReleaseShared27720;
		protected virtual bool tryReleaseShared(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryReleaseShared27720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryReleaseShared27720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acquireShared27721;
		public virtual void acquireShared(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireShared27721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireShared27721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acquireSharedInterruptibly27722;
		public virtual void acquireSharedInterruptibly(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireSharedInterruptibly27722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireSharedInterruptibly27722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquireSharedNanos27723;
		public virtual bool tryAcquireSharedNanos(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireSharedNanos27723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireSharedNanos27723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _releaseShared27724;
		public virtual bool releaseShared(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._releaseShared27724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._releaseShared27724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasContended27725;
		public virtual bool hasContended()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasContended27725);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasContended27725);
		}
		internal static global::MonoJavaBridge.MethodId _getFirstQueuedThread27726;
		public virtual global::java.lang.Thread getFirstQueuedThread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getFirstQueuedThread27726)) as java.lang.Thread;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getFirstQueuedThread27726)) as java.lang.Thread;
		}
		internal static global::MonoJavaBridge.MethodId _getExclusiveQueuedThreads27727;
		public virtual global::java.util.Collection getExclusiveQueuedThreads()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getExclusiveQueuedThreads27727)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getExclusiveQueuedThreads27727)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _getSharedQueuedThreads27728;
		public virtual global::java.util.Collection getSharedQueuedThreads()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getSharedQueuedThreads27728)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getSharedQueuedThreads27728)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _owns27729;
		public virtual bool owns(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._owns27729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._owns27729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractQueuedSynchronizer27730;
		protected AbstractQueuedSynchronizer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._AbstractQueuedSynchronizer27730);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/AbstractQueuedSynchronizer"));
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._toString27701 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getState27702 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getState", "()I");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._setState27703 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "setState", "(I)V");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquire27704 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquire", "(I)V");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._release27705 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "release", "(I)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasQueuedThreads27706 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "hasQueuedThreads", "()Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getQueueLength27707 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getQueueLength", "()I");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getQueuedThreads27708 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getQueuedThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasWaiters27709 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "hasWaiters", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getWaitQueueLength27710 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getWaitQueueLength", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)I");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getWaitingThreads27711 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getWaitingThreads", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Ljava/util/Collection;");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireInterruptibly27712 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquireInterruptibly", "(I)V");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireNanos27713 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquireNanos", "(IJ)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._isHeldExclusively27714 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "isHeldExclusively", "()Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._isQueued27715 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "isQueued", "(Ljava/lang/Thread;)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquire27716 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquire", "(I)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._compareAndSetState27717 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "compareAndSetState", "(II)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryRelease27718 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryRelease", "(I)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireShared27719 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquireShared", "(I)I");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryReleaseShared27720 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryReleaseShared", "(I)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireShared27721 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquireShared", "(I)V");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireSharedInterruptibly27722 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquireSharedInterruptibly", "(I)V");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireSharedNanos27723 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquireSharedNanos", "(IJ)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._releaseShared27724 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "releaseShared", "(I)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasContended27725 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "hasContended", "()Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getFirstQueuedThread27726 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getFirstQueuedThread", "()Ljava/lang/Thread;");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getExclusiveQueuedThreads27727 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getExclusiveQueuedThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getSharedQueuedThreads27728 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getSharedQueuedThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._owns27729 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "owns", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._AbstractQueuedSynchronizer27730 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.locks.AbstractQueuedSynchronizer))]
	internal sealed partial class AbstractQueuedSynchronizer_ : java.util.concurrent.locks.AbstractQueuedSynchronizer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractQueuedSynchronizer_()
		{
			InitJNI();
		}
		internal AbstractQueuedSynchronizer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/AbstractQueuedSynchronizer"));
		}
	}
}
