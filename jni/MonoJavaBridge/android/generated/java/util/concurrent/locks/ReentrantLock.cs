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
		internal static global::MonoJavaBridge.MethodId _lock21806;
		public virtual void @lock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._lock21806);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._lock21806);
		}
		internal static global::MonoJavaBridge.MethodId _toString21807;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._toString21807)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._toString21807)) as java.lang.String;
		}
		protected new global::java.lang.Thread Owner
		{
			get
			{
				return getOwner();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOwner21808;
		protected virtual global::java.lang.Thread getOwner() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._getOwner21808)) as java.lang.Thread;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._getOwner21808)) as java.lang.Thread;
		}
		internal static global::MonoJavaBridge.MethodId _unlock21809;
		public virtual void unlock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._unlock21809);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._unlock21809);
		}
		internal static global::MonoJavaBridge.MethodId _lockInterruptibly21810;
		public virtual void lockInterruptibly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._lockInterruptibly21810);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._lockInterruptibly21810);
		}
		internal static global::MonoJavaBridge.MethodId _tryLock21811;
		public virtual bool tryLock(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._tryLock21811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._tryLock21811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tryLock21812;
		public virtual bool tryLock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._tryLock21812);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._tryLock21812);
		}
		internal static global::MonoJavaBridge.MethodId _newCondition21813;
		public virtual global::java.util.concurrent.locks.Condition newCondition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._newCondition21813)) as java.util.concurrent.locks.Condition;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._newCondition21813)) as java.util.concurrent.locks.Condition;
		}
		public new int HoldCount
		{
			get
			{
				return getHoldCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHoldCount21814;
		public virtual int getHoldCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._getHoldCount21814);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._getHoldCount21814);
		}
		internal static global::MonoJavaBridge.MethodId _isHeldByCurrentThread21815;
		public virtual bool isHeldByCurrentThread() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._isHeldByCurrentThread21815);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._isHeldByCurrentThread21815);
		}
		internal static global::MonoJavaBridge.MethodId _isLocked21816;
		public virtual bool isLocked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._isLocked21816);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._isLocked21816);
		}
		internal static global::MonoJavaBridge.MethodId _isFair21817;
		public virtual bool isFair() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._isFair21817);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._isFair21817);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThreads21818;
		public virtual bool hasQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._hasQueuedThreads21818);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._hasQueuedThreads21818);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThread21819;
		public virtual bool hasQueuedThread(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._hasQueuedThread21819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._hasQueuedThread21819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int QueueLength
		{
			get
			{
				return getQueueLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueueLength21820;
		public virtual int getQueueLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._getQueueLength21820);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._getQueueLength21820);
		}
		protected new global::java.util.Collection QueuedThreads
		{
			get
			{
				return getQueuedThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedThreads21821;
		protected virtual global::java.util.Collection getQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._getQueuedThreads21821)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._getQueuedThreads21821)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hasWaiters21822;
		public virtual bool hasWaiters(java.util.concurrent.locks.Condition arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._hasWaiters21822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._hasWaiters21822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitQueueLength21823;
		public virtual int getWaitQueueLength(java.util.concurrent.locks.Condition arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._getWaitQueueLength21823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._getWaitQueueLength21823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitingThreads21824;
		protected virtual global::java.util.Collection getWaitingThreads(java.util.concurrent.locks.Condition arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock._getWaitingThreads21824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._getWaitingThreads21824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _ReentrantLock21825;
		public ReentrantLock()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._ReentrantLock21825);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ReentrantLock21826;
		public ReentrantLock(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantLock.staticClass, global::java.util.concurrent.locks.ReentrantLock._ReentrantLock21826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.ReentrantLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantLock"));
			global::java.util.concurrent.locks.ReentrantLock._lock21806 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "@lock", "()V");
			global::java.util.concurrent.locks.ReentrantLock._toString21807 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.locks.ReentrantLock._getOwner21808 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "getOwner", "()Ljava/lang/Thread;");
			global::java.util.concurrent.locks.ReentrantLock._unlock21809 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "unlock", "()V");
			global::java.util.concurrent.locks.ReentrantLock._lockInterruptibly21810 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "lockInterruptibly", "()V");
			global::java.util.concurrent.locks.ReentrantLock._tryLock21811 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.locks.ReentrantLock._tryLock21812 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "tryLock", "()Z");
			global::java.util.concurrent.locks.ReentrantLock._newCondition21813 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;");
			global::java.util.concurrent.locks.ReentrantLock._getHoldCount21814 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "getHoldCount", "()I");
			global::java.util.concurrent.locks.ReentrantLock._isHeldByCurrentThread21815 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "isHeldByCurrentThread", "()Z");
			global::java.util.concurrent.locks.ReentrantLock._isLocked21816 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "isLocked", "()Z");
			global::java.util.concurrent.locks.ReentrantLock._isFair21817 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "isFair", "()Z");
			global::java.util.concurrent.locks.ReentrantLock._hasQueuedThreads21818 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "hasQueuedThreads", "()Z");
			global::java.util.concurrent.locks.ReentrantLock._hasQueuedThread21819 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "hasQueuedThread", "(Ljava/lang/Thread;)Z");
			global::java.util.concurrent.locks.ReentrantLock._getQueueLength21820 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "getQueueLength", "()I");
			global::java.util.concurrent.locks.ReentrantLock._getQueuedThreads21821 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "getQueuedThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantLock._hasWaiters21822 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "hasWaiters", "(Ljava/util/concurrent/locks/Condition;)Z");
			global::java.util.concurrent.locks.ReentrantLock._getWaitQueueLength21823 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "getWaitQueueLength", "(Ljava/util/concurrent/locks/Condition;)I");
			global::java.util.concurrent.locks.ReentrantLock._getWaitingThreads21824 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "getWaitingThreads", "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantLock._ReentrantLock21825 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "<init>", "()V");
			global::java.util.concurrent.locks.ReentrantLock._ReentrantLock21826 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantLock.staticClass, "<init>", "(Z)V");
		}
	}
}
