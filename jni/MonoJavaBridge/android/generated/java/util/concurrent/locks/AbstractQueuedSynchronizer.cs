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
			internal static global::MonoJavaBridge.MethodId _hasWaiters21742;
			protected virtual bool hasWaiters() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._hasWaiters21742);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._hasWaiters21742);
			}
			protected new int WaitQueueLength
			{
				get
				{
					return getWaitQueueLength();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getWaitQueueLength21743;
			protected virtual int getWaitQueueLength() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._getWaitQueueLength21743);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._getWaitQueueLength21743);
			}
			protected new global::java.util.Collection WaitingThreads
			{
				get
				{
					return getWaitingThreads();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getWaitingThreads21744;
			protected virtual global::java.util.Collection getWaitingThreads() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._getWaitingThreads21744)) as java.util.Collection;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._getWaitingThreads21744)) as java.util.Collection;
			}
			internal static global::MonoJavaBridge.MethodId _await21745;
			public virtual bool await(long arg0, java.util.concurrent.TimeUnit arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._await21745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._await21745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _await21746;
			public virtual void await() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._await21746);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._await21746);
			}
			internal static global::MonoJavaBridge.MethodId _signal21747;
			public virtual void signal() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._signal21747);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._signal21747);
			}
			internal static global::MonoJavaBridge.MethodId _signalAll21748;
			public virtual void signalAll() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._signalAll21748);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._signalAll21748);
			}
			internal static global::MonoJavaBridge.MethodId _awaitUninterruptibly21749;
			public virtual void awaitUninterruptibly() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitUninterruptibly21749);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitUninterruptibly21749);
			}
			internal static global::MonoJavaBridge.MethodId _awaitNanos21750;
			public virtual long awaitNanos(long arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitNanos21750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitNanos21750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _awaitUntil21751;
			public virtual bool awaitUntil(java.util.Date arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitUntil21751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitUntil21751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _ConditionObject21752;
			public ConditionObject(java.util.concurrent.locks.AbstractQueuedSynchronizer arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._ConditionObject21752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject"));
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._hasWaiters21742 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "hasWaiters", "()Z");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._getWaitQueueLength21743 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "getWaitQueueLength", "()I");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._getWaitingThreads21744 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "getWaitingThreads", "()Ljava/util/Collection;");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._await21745 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "await", "(JLjava/util/concurrent/TimeUnit;)Z");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._await21746 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "await", "()V");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._signal21747 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "signal", "()V");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._signalAll21748 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "signalAll", "()V");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitUninterruptibly21749 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "awaitUninterruptibly", "()V");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitNanos21750 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "awaitNanos", "(J)J");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._awaitUntil21751 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "awaitUntil", "(Ljava/util/Date;)Z");
				global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject._ConditionObject21752 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject.staticClass, "<init>", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString21753;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._toString21753)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._toString21753)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getState21754;
		protected virtual int getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getState21754);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getState21754);
		}
		internal static global::MonoJavaBridge.MethodId _setState21755;
		protected virtual void setState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._setState21755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._setState21755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acquire21756;
		public virtual void acquire(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquire21756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquire21756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _release21757;
		public virtual bool release(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._release21757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._release21757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThreads21758;
		public virtual bool hasQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasQueuedThreads21758);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasQueuedThreads21758);
		}
		internal static global::MonoJavaBridge.MethodId _getQueueLength21759;
		public virtual int getQueueLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getQueueLength21759);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getQueueLength21759);
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedThreads21760;
		public virtual global::java.util.Collection getQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getQueuedThreads21760)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getQueuedThreads21760)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hasWaiters21761;
		public virtual bool hasWaiters(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasWaiters21761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasWaiters21761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitQueueLength21762;
		public virtual int getWaitQueueLength(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getWaitQueueLength21762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getWaitQueueLength21762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitingThreads21763;
		public virtual global::java.util.Collection getWaitingThreads(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getWaitingThreads21763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getWaitingThreads21763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _acquireInterruptibly21764;
		public virtual void acquireInterruptibly(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireInterruptibly21764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireInterruptibly21764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquireNanos21765;
		public virtual bool tryAcquireNanos(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireNanos21765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireNanos21765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isHeldExclusively21766;
		protected virtual bool isHeldExclusively() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._isHeldExclusively21766);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._isHeldExclusively21766);
		}
		internal static global::MonoJavaBridge.MethodId _isQueued21767;
		public virtual bool isQueued(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._isQueued21767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._isQueued21767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire21768;
		protected virtual bool tryAcquire(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquire21768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquire21768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSetState21769;
		protected virtual bool compareAndSetState(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._compareAndSetState21769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._compareAndSetState21769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tryRelease21770;
		protected virtual bool tryRelease(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryRelease21770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryRelease21770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquireShared21771;
		protected virtual int tryAcquireShared(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireShared21771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireShared21771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryReleaseShared21772;
		protected virtual bool tryReleaseShared(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryReleaseShared21772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryReleaseShared21772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acquireShared21773;
		public virtual void acquireShared(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireShared21773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireShared21773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acquireSharedInterruptibly21774;
		public virtual void acquireSharedInterruptibly(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireSharedInterruptibly21774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireSharedInterruptibly21774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquireSharedNanos21775;
		public virtual bool tryAcquireSharedNanos(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireSharedNanos21775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireSharedNanos21775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _releaseShared21776;
		public virtual bool releaseShared(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._releaseShared21776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._releaseShared21776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasContended21777;
		public virtual bool hasContended() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasContended21777);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasContended21777);
		}
		internal static global::MonoJavaBridge.MethodId _getFirstQueuedThread21778;
		public virtual global::java.lang.Thread getFirstQueuedThread() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getFirstQueuedThread21778)) as java.lang.Thread;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getFirstQueuedThread21778)) as java.lang.Thread;
		}
		internal static global::MonoJavaBridge.MethodId _getExclusiveQueuedThreads21779;
		public virtual global::java.util.Collection getExclusiveQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getExclusiveQueuedThreads21779)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getExclusiveQueuedThreads21779)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _getSharedQueuedThreads21780;
		public virtual global::java.util.Collection getSharedQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getSharedQueuedThreads21780)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getSharedQueuedThreads21780)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _owns21781;
		public virtual bool owns(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._owns21781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._owns21781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractQueuedSynchronizer21782;
		protected AbstractQueuedSynchronizer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, global::java.util.concurrent.locks.AbstractQueuedSynchronizer._AbstractQueuedSynchronizer21782);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/AbstractQueuedSynchronizer"));
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._toString21753 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getState21754 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getState", "()I");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._setState21755 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "setState", "(I)V");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquire21756 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquire", "(I)V");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._release21757 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "release", "(I)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasQueuedThreads21758 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "hasQueuedThreads", "()Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getQueueLength21759 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getQueueLength", "()I");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getQueuedThreads21760 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getQueuedThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasWaiters21761 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "hasWaiters", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getWaitQueueLength21762 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getWaitQueueLength", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)I");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getWaitingThreads21763 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getWaitingThreads", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Ljava/util/Collection;");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireInterruptibly21764 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquireInterruptibly", "(I)V");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireNanos21765 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquireNanos", "(IJ)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._isHeldExclusively21766 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "isHeldExclusively", "()Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._isQueued21767 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "isQueued", "(Ljava/lang/Thread;)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquire21768 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquire", "(I)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._compareAndSetState21769 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "compareAndSetState", "(II)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryRelease21770 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryRelease", "(I)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireShared21771 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquireShared", "(I)I");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryReleaseShared21772 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryReleaseShared", "(I)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireShared21773 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquireShared", "(I)V");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._acquireSharedInterruptibly21774 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "acquireSharedInterruptibly", "(I)V");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._tryAcquireSharedNanos21775 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "tryAcquireSharedNanos", "(IJ)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._releaseShared21776 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "releaseShared", "(I)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._hasContended21777 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "hasContended", "()Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getFirstQueuedThread21778 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getFirstQueuedThread", "()Ljava/lang/Thread;");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getExclusiveQueuedThreads21779 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getExclusiveQueuedThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._getSharedQueuedThreads21780 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "getSharedQueuedThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._owns21781 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "owns", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Z");
			global::java.util.concurrent.locks.AbstractQueuedSynchronizer._AbstractQueuedSynchronizer21782 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.AbstractQueuedSynchronizer.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.locks.AbstractQueuedSynchronizer))]
	public sealed partial class AbstractQueuedSynchronizer_ : java.util.concurrent.locks.AbstractQueuedSynchronizer
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
