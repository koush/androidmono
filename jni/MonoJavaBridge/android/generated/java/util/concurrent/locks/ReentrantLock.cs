namespace java.util.concurrent.locks
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ReentrantLock : java.lang.Object, Lock, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ReentrantLock()
		{
			InitJNI();
		}
		protected ReentrantLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _lock27754;
		public virtual void @lock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._lock27754);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._lock27754);
		}
		internal static global::MonoJavaBridge.MethodId _toString27755;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._toString27755)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._toString27755)) as java.lang.String;
		}
		protected new global::java.lang.Thread Owner
		{
			get
			{
				return getOwner();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOwner27756;
		protected virtual global::java.lang.Thread getOwner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._getOwner27756)) as java.lang.Thread;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._getOwner27756)) as java.lang.Thread;
		}
		internal static global::MonoJavaBridge.MethodId _unlock27757;
		public virtual void unlock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._unlock27757);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._unlock27757);
		}
		internal static global::MonoJavaBridge.MethodId _lockInterruptibly27758;
		public virtual void lockInterruptibly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._lockInterruptibly27758);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._lockInterruptibly27758);
		}
		internal static global::MonoJavaBridge.MethodId _tryLock27759;
		public virtual bool tryLock(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._tryLock27759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._tryLock27759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tryLock27760;
		public virtual bool tryLock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._tryLock27760);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._tryLock27760);
		}
		internal static global::MonoJavaBridge.MethodId _newCondition27761;
		public virtual global::java.util.concurrent.locks.Condition newCondition()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._newCondition27761)) as java.util.concurrent.locks.Condition;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._newCondition27761)) as java.util.concurrent.locks.Condition;
		}
		public new int HoldCount
		{
			get
			{
				return getHoldCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHoldCount27762;
		public virtual int getHoldCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._getHoldCount27762);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._getHoldCount27762);
		}
		internal static global::MonoJavaBridge.MethodId _isHeldByCurrentThread27763;
		public virtual bool isHeldByCurrentThread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._isHeldByCurrentThread27763);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._isHeldByCurrentThread27763);
		}
		internal static global::MonoJavaBridge.MethodId _isLocked27764;
		public virtual bool isLocked()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._isLocked27764);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._isLocked27764);
		}
		internal static global::MonoJavaBridge.MethodId _isFair27765;
		public virtual bool isFair()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._isFair27765);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._isFair27765);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThreads27766;
		public virtual bool hasQueuedThreads()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._hasQueuedThreads27766);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._hasQueuedThreads27766);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThread27767;
		public virtual bool hasQueuedThread(java.lang.Thread arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._hasQueuedThread27767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._hasQueuedThread27767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int QueueLength
		{
			get
			{
				return getQueueLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueueLength27768;
		public virtual int getQueueLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._getQueueLength27768);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._getQueueLength27768);
		}
		protected new global::java.util.Collection QueuedThreads
		{
			get
			{
				return getQueuedThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedThreads27769;
		protected virtual global::java.util.Collection getQueuedThreads()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._getQueuedThreads27769)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._getQueuedThreads27769)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hasWaiters27770;
		public virtual bool hasWaiters(java.util.concurrent.locks.Condition arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._hasWaiters27770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._hasWaiters27770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitQueueLength27771;
		public virtual int getWaitQueueLength(java.util.concurrent.locks.Condition arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._getWaitQueueLength27771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._getWaitQueueLength27771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitingThreads27772;
		protected virtual global::java.util.Collection getWaitingThreads(java.util.concurrent.locks.Condition arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._getWaitingThreads27772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._getWaitingThreads27772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _ReentrantLock27773;
		public ReentrantLock() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._ReentrantLock27773);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ReentrantLock27774;
		public ReentrantLock(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._ReentrantLock27774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.ReentrantLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantLock"));
			global::java.util.concurrent.locks.ReentrantLock._lock27754 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "@lock", "()V");
			global::java.util.concurrent.locks.ReentrantLock._toString27755 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.locks.ReentrantLock._getOwner27756 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "getOwner", "()Ljava/lang/Thread;");
			global::java.util.concurrent.locks.ReentrantLock._unlock27757 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "unlock", "()V");
			global::java.util.concurrent.locks.ReentrantLock._lockInterruptibly27758 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "lockInterruptibly", "()V");
			global::java.util.concurrent.locks.ReentrantLock._tryLock27759 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.locks.ReentrantLock._tryLock27760 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "tryLock", "()Z");
			global::java.util.concurrent.locks.ReentrantLock._newCondition27761 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;");
			global::java.util.concurrent.locks.ReentrantLock._getHoldCount27762 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "getHoldCount", "()I");
			global::java.util.concurrent.locks.ReentrantLock._isHeldByCurrentThread27763 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "isHeldByCurrentThread", "()Z");
			global::java.util.concurrent.locks.ReentrantLock._isLocked27764 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "isLocked", "()Z");
			global::java.util.concurrent.locks.ReentrantLock._isFair27765 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "isFair", "()Z");
			global::java.util.concurrent.locks.ReentrantLock._hasQueuedThreads27766 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "hasQueuedThreads", "()Z");
			global::java.util.concurrent.locks.ReentrantLock._hasQueuedThread27767 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "hasQueuedThread", "(Ljava/lang/Thread;)Z");
			global::java.util.concurrent.locks.ReentrantLock._getQueueLength27768 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "getQueueLength", "()I");
			global::java.util.concurrent.locks.ReentrantLock._getQueuedThreads27769 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "getQueuedThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantLock._hasWaiters27770 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "hasWaiters", "(Ljava/util/concurrent/locks/Condition;)Z");
			global::java.util.concurrent.locks.ReentrantLock._getWaitQueueLength27771 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "getWaitQueueLength", "(Ljava/util/concurrent/locks/Condition;)I");
			global::java.util.concurrent.locks.ReentrantLock._getWaitingThreads27772 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "getWaitingThreads", "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantLock._ReentrantLock27773 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "<init>", "()V");
			global::java.util.concurrent.locks.ReentrantLock._ReentrantLock27774 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "<init>", "(Z)V");
		}
	}
}
