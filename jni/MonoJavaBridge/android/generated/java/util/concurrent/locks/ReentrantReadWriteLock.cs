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
			internal static global::MonoJavaBridge.MethodId _lock27775;
			public virtual void @lock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lock27775);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lock27775);
			}
			internal static global::MonoJavaBridge.MethodId _toString27776;
			public override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._toString27776)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._toString27776)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _unlock27777;
			public virtual void unlock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._unlock27777);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._unlock27777);
			}
			internal static global::MonoJavaBridge.MethodId _lockInterruptibly27778;
			public virtual void lockInterruptibly()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lockInterruptibly27778);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lockInterruptibly27778);
			}
			internal static global::MonoJavaBridge.MethodId _tryLock27779;
			public virtual bool tryLock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock27779);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock27779);
			}
			internal static global::MonoJavaBridge.MethodId _tryLock27780;
			public virtual bool tryLock(long arg0, java.util.concurrent.TimeUnit arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock27780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock27780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _newCondition27781;
			public virtual global::java.util.concurrent.locks.Condition newCondition()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._newCondition27781)) as java.util.concurrent.locks.Condition;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._newCondition27781)) as java.util.concurrent.locks.Condition;
			}
			internal static global::MonoJavaBridge.MethodId _ReadLock27782;
			protected ReadLock(java.util.concurrent.locks.ReentrantReadWriteLock arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._ReadLock27782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantReadWriteLock$ReadLock"));
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lock27775 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "@lock", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._toString27776 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "toString", "()Ljava/lang/String;");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._unlock27777 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "unlock", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lockInterruptibly27778 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "lockInterruptibly", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock27779 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "tryLock", "()Z");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock27780 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._newCondition27781 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._ReadLock27782 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "<init>", "(Ljava/util/concurrent/locks/ReentrantReadWriteLock;)V");
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
			internal static global::MonoJavaBridge.MethodId _lock27783;
			public virtual void @lock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lock27783);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lock27783);
			}
			internal static global::MonoJavaBridge.MethodId _toString27784;
			public override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._toString27784)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._toString27784)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _unlock27785;
			public virtual void unlock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._unlock27785);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._unlock27785);
			}
			internal static global::MonoJavaBridge.MethodId _lockInterruptibly27786;
			public virtual void lockInterruptibly()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lockInterruptibly27786);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lockInterruptibly27786);
			}
			internal static global::MonoJavaBridge.MethodId _tryLock27787;
			public virtual bool tryLock(long arg0, java.util.concurrent.TimeUnit arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock27787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock27787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _tryLock27788;
			public virtual bool tryLock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock27788);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock27788);
			}
			internal static global::MonoJavaBridge.MethodId _newCondition27789;
			public virtual global::java.util.concurrent.locks.Condition newCondition()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._newCondition27789)) as java.util.concurrent.locks.Condition;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._newCondition27789)) as java.util.concurrent.locks.Condition;
			}
			public new int HoldCount
			{
				get
				{
					return getHoldCount();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHoldCount27790;
			public virtual int getHoldCount()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._getHoldCount27790);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._getHoldCount27790);
			}
			internal static global::MonoJavaBridge.MethodId _isHeldByCurrentThread27791;
			public virtual bool isHeldByCurrentThread()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._isHeldByCurrentThread27791);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._isHeldByCurrentThread27791);
			}
			internal static global::MonoJavaBridge.MethodId _WriteLock27792;
			protected WriteLock(java.util.concurrent.locks.ReentrantReadWriteLock arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._WriteLock27792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantReadWriteLock$WriteLock"));
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lock27783 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "@lock", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._toString27784 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "toString", "()Ljava/lang/String;");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._unlock27785 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "unlock", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lockInterruptibly27786 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "lockInterruptibly", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock27787 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock27788 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "tryLock", "()Z");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._newCondition27789 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._getHoldCount27790 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "getHoldCount", "()I");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._isHeldByCurrentThread27791 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "isHeldByCurrentThread", "()Z");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._WriteLock27792 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "<init>", "(Ljava/util/concurrent/locks/ReentrantReadWriteLock;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString27793;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._toString27793)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._toString27793)) as java.lang.String;
		}
		protected new global::java.lang.Thread Owner
		{
			get
			{
				return getOwner();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOwner27794;
		protected virtual global::java.lang.Thread getOwner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getOwner27794)) as java.lang.Thread;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getOwner27794)) as java.lang.Thread;
		}
		internal static global::MonoJavaBridge.MethodId _isFair27795;
		public virtual bool isFair()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._isFair27795);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._isFair27795);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThreads27796;
		public virtual bool hasQueuedThreads()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThreads27796);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThreads27796);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThread27797;
		public virtual bool hasQueuedThread(java.lang.Thread arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThread27797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThread27797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int QueueLength
		{
			get
			{
				return getQueueLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueueLength27798;
		public virtual int getQueueLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueueLength27798);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueueLength27798);
		}
		protected new global::java.util.Collection QueuedThreads
		{
			get
			{
				return getQueuedThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedThreads27799;
		protected virtual global::java.util.Collection getQueuedThreads()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedThreads27799)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedThreads27799)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hasWaiters27800;
		public virtual bool hasWaiters(java.util.concurrent.locks.Condition arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasWaiters27800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasWaiters27800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitQueueLength27801;
		public virtual int getWaitQueueLength(java.util.concurrent.locks.Condition arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitQueueLength27801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitQueueLength27801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitingThreads27802;
		protected virtual global::java.util.Collection getWaitingThreads(java.util.concurrent.locks.Condition arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitingThreads27802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitingThreads27802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _readLock27803;
		public virtual global::java.util.concurrent.locks.Lock readLock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._readLock27803)) as java.util.concurrent.locks.Lock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._readLock27803)) as java.util.concurrent.locks.Lock;
		}
		internal static global::MonoJavaBridge.MethodId _writeLock27804;
		public virtual global::java.util.concurrent.locks.Lock writeLock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._writeLock27804)) as java.util.concurrent.locks.Lock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._writeLock27804)) as java.util.concurrent.locks.Lock;
		}
		public new int ReadLockCount
		{
			get
			{
				return getReadLockCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReadLockCount27805;
		public virtual int getReadLockCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadLockCount27805);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadLockCount27805);
		}
		internal static global::MonoJavaBridge.MethodId _isWriteLocked27806;
		public virtual bool isWriteLocked()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLocked27806);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLocked27806);
		}
		internal static global::MonoJavaBridge.MethodId _isWriteLockedByCurrentThread27807;
		public virtual bool isWriteLockedByCurrentThread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLockedByCurrentThread27807);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLockedByCurrentThread27807);
		}
		public new int WriteHoldCount
		{
			get
			{
				return getWriteHoldCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWriteHoldCount27808;
		public virtual int getWriteHoldCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWriteHoldCount27808);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWriteHoldCount27808);
		}
		public new int ReadHoldCount
		{
			get
			{
				return getReadHoldCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReadHoldCount27809;
		public virtual int getReadHoldCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadHoldCount27809);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadHoldCount27809);
		}
		protected new global::java.util.Collection QueuedWriterThreads
		{
			get
			{
				return getQueuedWriterThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedWriterThreads27810;
		protected virtual global::java.util.Collection getQueuedWriterThreads()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedWriterThreads27810)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedWriterThreads27810)) as java.util.Collection;
		}
		protected new global::java.util.Collection QueuedReaderThreads
		{
			get
			{
				return getQueuedReaderThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedReaderThreads27811;
		protected virtual global::java.util.Collection getQueuedReaderThreads()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedReaderThreads27811)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedReaderThreads27811)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _ReentrantReadWriteLock27812;
		public ReentrantReadWriteLock(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock27812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ReentrantReadWriteLock27813;
		public ReentrantReadWriteLock() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock27813);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantReadWriteLock"));
			global::java.util.concurrent.locks.ReentrantReadWriteLock._toString27793 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getOwner27794 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getOwner", "()Ljava/lang/Thread;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._isFair27795 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "isFair", "()Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThreads27796 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "hasQueuedThreads", "()Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThread27797 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "hasQueuedThread", "(Ljava/lang/Thread;)Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueueLength27798 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueueLength", "()I");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedThreads27799 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueuedThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._hasWaiters27800 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "hasWaiters", "(Ljava/util/concurrent/locks/Condition;)Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitQueueLength27801 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getWaitQueueLength", "(Ljava/util/concurrent/locks/Condition;)I");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitingThreads27802 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getWaitingThreads", "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._readLock27803 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "readLock", "()Ljava/util/concurrent/locks/Lock;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._writeLock27804 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "writeLock", "()Ljava/util/concurrent/locks/Lock;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadLockCount27805 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getReadLockCount", "()I");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLocked27806 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "isWriteLocked", "()Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLockedByCurrentThread27807 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "isWriteLockedByCurrentThread", "()Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getWriteHoldCount27808 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getWriteHoldCount", "()I");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadHoldCount27809 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getReadHoldCount", "()I");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedWriterThreads27810 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueuedWriterThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedReaderThreads27811 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueuedReaderThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock27812 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "<init>", "(Z)V");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock27813 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "<init>", "()V");
		}
	}
}
