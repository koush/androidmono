namespace java.util.concurrent.locks
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ReentrantReadWriteLock : java.lang.Object, ReadWriteLock, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ReentrantReadWriteLock()
		{
			InitJNI();
		}
		protected ReentrantReadWriteLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ReadLock : java.lang.Object, Lock, java.io.Serializable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ReadLock()
			{
				InitJNI();
			}
			protected ReadLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _lock27657;
			public virtual void @lock() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lock27657);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lock27657);
			}
			internal static global::MonoJavaBridge.MethodId _toString27658;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._toString27658)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._toString27658)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _unlock27659;
			public virtual void unlock() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._unlock27659);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._unlock27659);
			}
			internal static global::MonoJavaBridge.MethodId _lockInterruptibly27660;
			public virtual void lockInterruptibly() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lockInterruptibly27660);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lockInterruptibly27660);
			}
			internal static global::MonoJavaBridge.MethodId _tryLock27661;
			public virtual bool tryLock() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock27661);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock27661);
			}
			internal static global::MonoJavaBridge.MethodId _tryLock27662;
			public virtual bool tryLock(long arg0, java.util.concurrent.TimeUnit arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock27662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock27662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _newCondition27663;
			public virtual global::java.util.concurrent.locks.Condition newCondition() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._newCondition27663)) as java.util.concurrent.locks.Condition;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._newCondition27663)) as java.util.concurrent.locks.Condition;
			}
			internal static global::MonoJavaBridge.MethodId _ReadLock27664;
			protected ReadLock(java.util.concurrent.locks.ReentrantReadWriteLock arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._ReadLock27664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantReadWriteLock$ReadLock"));
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lock27657 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "@lock", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._toString27658 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "toString", "()Ljava/lang/String;");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._unlock27659 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "unlock", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lockInterruptibly27660 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "lockInterruptibly", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock27661 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "tryLock", "()Z");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock27662 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._newCondition27663 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._ReadLock27664 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "<init>", "(Ljava/util/concurrent/locks/ReentrantReadWriteLock;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class WriteLock : java.lang.Object, Lock, java.io.Serializable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static WriteLock()
			{
				InitJNI();
			}
			protected WriteLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _lock27665;
			public virtual void @lock() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lock27665);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lock27665);
			}
			internal static global::MonoJavaBridge.MethodId _toString27666;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._toString27666)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._toString27666)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _unlock27667;
			public virtual void unlock() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._unlock27667);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._unlock27667);
			}
			internal static global::MonoJavaBridge.MethodId _lockInterruptibly27668;
			public virtual void lockInterruptibly() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lockInterruptibly27668);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lockInterruptibly27668);
			}
			internal static global::MonoJavaBridge.MethodId _tryLock27669;
			public virtual bool tryLock(long arg0, java.util.concurrent.TimeUnit arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock27669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock27669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _tryLock27670;
			public virtual bool tryLock() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock27670);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock27670);
			}
			internal static global::MonoJavaBridge.MethodId _newCondition27671;
			public virtual global::java.util.concurrent.locks.Condition newCondition() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._newCondition27671)) as java.util.concurrent.locks.Condition;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._newCondition27671)) as java.util.concurrent.locks.Condition;
			}
			public new int HoldCount
			{
				get
				{
					return getHoldCount();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHoldCount27672;
			public virtual int getHoldCount() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._getHoldCount27672);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._getHoldCount27672);
			}
			internal static global::MonoJavaBridge.MethodId _isHeldByCurrentThread27673;
			public virtual bool isHeldByCurrentThread() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._isHeldByCurrentThread27673);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._isHeldByCurrentThread27673);
			}
			internal static global::MonoJavaBridge.MethodId _WriteLock27674;
			protected WriteLock(java.util.concurrent.locks.ReentrantReadWriteLock arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._WriteLock27674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantReadWriteLock$WriteLock"));
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lock27665 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "@lock", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._toString27666 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "toString", "()Ljava/lang/String;");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._unlock27667 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "unlock", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lockInterruptibly27668 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "lockInterruptibly", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock27669 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock27670 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "tryLock", "()Z");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._newCondition27671 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._getHoldCount27672 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "getHoldCount", "()I");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._isHeldByCurrentThread27673 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "isHeldByCurrentThread", "()Z");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._WriteLock27674 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "<init>", "(Ljava/util/concurrent/locks/ReentrantReadWriteLock;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString27675;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._toString27675)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._toString27675)) as java.lang.String;
		}
		protected new global::java.lang.Thread Owner
		{
			get
			{
				return getOwner();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOwner27676;
		protected virtual global::java.lang.Thread getOwner() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getOwner27676)) as java.lang.Thread;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getOwner27676)) as java.lang.Thread;
		}
		internal static global::MonoJavaBridge.MethodId _isFair27677;
		public virtual bool isFair() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._isFair27677);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._isFair27677);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThreads27678;
		public virtual bool hasQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThreads27678);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThreads27678);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThread27679;
		public virtual bool hasQueuedThread(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThread27679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThread27679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int QueueLength
		{
			get
			{
				return getQueueLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueueLength27680;
		public virtual int getQueueLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueueLength27680);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueueLength27680);
		}
		protected new global::java.util.Collection QueuedThreads
		{
			get
			{
				return getQueuedThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedThreads27681;
		protected virtual global::java.util.Collection getQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedThreads27681)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedThreads27681)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hasWaiters27682;
		public virtual bool hasWaiters(java.util.concurrent.locks.Condition arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasWaiters27682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasWaiters27682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitQueueLength27683;
		public virtual int getWaitQueueLength(java.util.concurrent.locks.Condition arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitQueueLength27683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitQueueLength27683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitingThreads27684;
		protected virtual global::java.util.Collection getWaitingThreads(java.util.concurrent.locks.Condition arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitingThreads27684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitingThreads27684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _readLock27685;
		public virtual global::java.util.concurrent.locks.Lock readLock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._readLock27685)) as java.util.concurrent.locks.Lock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._readLock27685)) as java.util.concurrent.locks.Lock;
		}
		internal static global::MonoJavaBridge.MethodId _writeLock27686;
		public virtual global::java.util.concurrent.locks.Lock writeLock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._writeLock27686)) as java.util.concurrent.locks.Lock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._writeLock27686)) as java.util.concurrent.locks.Lock;
		}
		public new int ReadLockCount
		{
			get
			{
				return getReadLockCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReadLockCount27687;
		public virtual int getReadLockCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadLockCount27687);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadLockCount27687);
		}
		internal static global::MonoJavaBridge.MethodId _isWriteLocked27688;
		public virtual bool isWriteLocked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLocked27688);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLocked27688);
		}
		internal static global::MonoJavaBridge.MethodId _isWriteLockedByCurrentThread27689;
		public virtual bool isWriteLockedByCurrentThread() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLockedByCurrentThread27689);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLockedByCurrentThread27689);
		}
		public new int WriteHoldCount
		{
			get
			{
				return getWriteHoldCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWriteHoldCount27690;
		public virtual int getWriteHoldCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWriteHoldCount27690);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWriteHoldCount27690);
		}
		public new int ReadHoldCount
		{
			get
			{
				return getReadHoldCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReadHoldCount27691;
		public virtual int getReadHoldCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadHoldCount27691);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadHoldCount27691);
		}
		protected new global::java.util.Collection QueuedWriterThreads
		{
			get
			{
				return getQueuedWriterThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedWriterThreads27692;
		protected virtual global::java.util.Collection getQueuedWriterThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedWriterThreads27692)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedWriterThreads27692)) as java.util.Collection;
		}
		protected new global::java.util.Collection QueuedReaderThreads
		{
			get
			{
				return getQueuedReaderThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedReaderThreads27693;
		protected virtual global::java.util.Collection getQueuedReaderThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedReaderThreads27693)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedReaderThreads27693)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _ReentrantReadWriteLock27694;
		public ReentrantReadWriteLock(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock27694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ReentrantReadWriteLock27695;
		public ReentrantReadWriteLock()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock27695);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantReadWriteLock"));
			global::java.util.concurrent.locks.ReentrantReadWriteLock._toString27675 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getOwner27676 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getOwner", "()Ljava/lang/Thread;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._isFair27677 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "isFair", "()Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThreads27678 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "hasQueuedThreads", "()Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThread27679 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "hasQueuedThread", "(Ljava/lang/Thread;)Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueueLength27680 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueueLength", "()I");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedThreads27681 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueuedThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._hasWaiters27682 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "hasWaiters", "(Ljava/util/concurrent/locks/Condition;)Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitQueueLength27683 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getWaitQueueLength", "(Ljava/util/concurrent/locks/Condition;)I");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitingThreads27684 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getWaitingThreads", "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._readLock27685 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "readLock", "()Ljava/util/concurrent/locks/Lock;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._writeLock27686 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "writeLock", "()Ljava/util/concurrent/locks/Lock;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadLockCount27687 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getReadLockCount", "()I");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLocked27688 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "isWriteLocked", "()Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLockedByCurrentThread27689 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "isWriteLockedByCurrentThread", "()Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getWriteHoldCount27690 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getWriteHoldCount", "()I");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadHoldCount27691 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getReadHoldCount", "()I");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedWriterThreads27692 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueuedWriterThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedReaderThreads27693 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueuedReaderThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock27694 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "<init>", "(Z)V");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock27695 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "<init>", "()V");
		}
	}
}
