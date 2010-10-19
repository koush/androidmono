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
			internal static global::MonoJavaBridge.MethodId _lock21827;
			public virtual void @lock() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lock21827);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lock21827);
			}
			internal static global::MonoJavaBridge.MethodId _toString21828;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._toString21828)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._toString21828)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _unlock21829;
			public virtual void unlock() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._unlock21829);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._unlock21829);
			}
			internal static global::MonoJavaBridge.MethodId _lockInterruptibly21830;
			public virtual void lockInterruptibly() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lockInterruptibly21830);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lockInterruptibly21830);
			}
			internal static global::MonoJavaBridge.MethodId _tryLock21831;
			public virtual bool tryLock() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock21831);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock21831);
			}
			internal static global::MonoJavaBridge.MethodId _tryLock21832;
			public virtual bool tryLock(long arg0, java.util.concurrent.TimeUnit arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock21832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock21832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _newCondition21833;
			public virtual global::java.util.concurrent.locks.Condition newCondition() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._newCondition21833)) as java.util.concurrent.locks.Condition;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._newCondition21833)) as java.util.concurrent.locks.Condition;
			}
			internal static global::MonoJavaBridge.MethodId _ReadLock21834;
			protected ReadLock(java.util.concurrent.locks.ReentrantReadWriteLock arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._ReadLock21834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantReadWriteLock$ReadLock"));
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lock21827 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "@lock", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._toString21828 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "toString", "()Ljava/lang/String;");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._unlock21829 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "unlock", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._lockInterruptibly21830 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "lockInterruptibly", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock21831 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "tryLock", "()Z");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._tryLock21832 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._newCondition21833 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock._ReadLock21834 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.ReadLock.staticClass, "<init>", "(Ljava/util/concurrent/locks/ReentrantReadWriteLock;)V");
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
			internal static global::MonoJavaBridge.MethodId _lock21835;
			public virtual void @lock() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lock21835);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lock21835);
			}
			internal static global::MonoJavaBridge.MethodId _toString21836;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._toString21836)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._toString21836)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _unlock21837;
			public virtual void unlock() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._unlock21837);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._unlock21837);
			}
			internal static global::MonoJavaBridge.MethodId _lockInterruptibly21838;
			public virtual void lockInterruptibly() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lockInterruptibly21838);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lockInterruptibly21838);
			}
			internal static global::MonoJavaBridge.MethodId _tryLock21839;
			public virtual bool tryLock(long arg0, java.util.concurrent.TimeUnit arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock21839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock21839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _tryLock21840;
			public virtual bool tryLock() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock21840);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock21840);
			}
			internal static global::MonoJavaBridge.MethodId _newCondition21841;
			public virtual global::java.util.concurrent.locks.Condition newCondition() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._newCondition21841)) as java.util.concurrent.locks.Condition;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._newCondition21841)) as java.util.concurrent.locks.Condition;
			}
			public new int HoldCount
			{
				get
				{
					return getHoldCount();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHoldCount21842;
			public virtual int getHoldCount() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._getHoldCount21842);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._getHoldCount21842);
			}
			internal static global::MonoJavaBridge.MethodId _isHeldByCurrentThread21843;
			public virtual bool isHeldByCurrentThread() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._isHeldByCurrentThread21843);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._isHeldByCurrentThread21843);
			}
			internal static global::MonoJavaBridge.MethodId _WriteLock21844;
			protected WriteLock(java.util.concurrent.locks.ReentrantReadWriteLock arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._WriteLock21844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantReadWriteLock$WriteLock"));
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lock21835 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "@lock", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._toString21836 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "toString", "()Ljava/lang/String;");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._unlock21837 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "unlock", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._lockInterruptibly21838 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "lockInterruptibly", "()V");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock21839 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._tryLock21840 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "tryLock", "()Z");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._newCondition21841 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._getHoldCount21842 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "getHoldCount", "()I");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._isHeldByCurrentThread21843 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "isHeldByCurrentThread", "()Z");
				global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock._WriteLock21844 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.WriteLock.staticClass, "<init>", "(Ljava/util/concurrent/locks/ReentrantReadWriteLock;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString21845;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._toString21845)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._toString21845)) as java.lang.String;
		}
		protected new global::java.lang.Thread Owner
		{
			get
			{
				return getOwner();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOwner21846;
		protected virtual global::java.lang.Thread getOwner() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getOwner21846)) as java.lang.Thread;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getOwner21846)) as java.lang.Thread;
		}
		internal static global::MonoJavaBridge.MethodId _isFair21847;
		public virtual bool isFair() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._isFair21847);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._isFair21847);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThreads21848;
		public virtual bool hasQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThreads21848);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThreads21848);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThread21849;
		public virtual bool hasQueuedThread(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThread21849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThread21849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int QueueLength
		{
			get
			{
				return getQueueLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueueLength21850;
		public virtual int getQueueLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueueLength21850);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueueLength21850);
		}
		protected new global::java.util.Collection QueuedThreads
		{
			get
			{
				return getQueuedThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedThreads21851;
		protected virtual global::java.util.Collection getQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedThreads21851)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedThreads21851)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hasWaiters21852;
		public virtual bool hasWaiters(java.util.concurrent.locks.Condition arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasWaiters21852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._hasWaiters21852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitQueueLength21853;
		public virtual int getWaitQueueLength(java.util.concurrent.locks.Condition arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitQueueLength21853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitQueueLength21853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWaitingThreads21854;
		protected virtual global::java.util.Collection getWaitingThreads(java.util.concurrent.locks.Condition arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitingThreads21854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitingThreads21854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _readLock21855;
		public virtual global::java.util.concurrent.locks.Lock readLock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._readLock21855)) as java.util.concurrent.locks.Lock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._readLock21855)) as java.util.concurrent.locks.Lock;
		}
		internal static global::MonoJavaBridge.MethodId _writeLock21856;
		public virtual global::java.util.concurrent.locks.Lock writeLock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._writeLock21856)) as java.util.concurrent.locks.Lock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._writeLock21856)) as java.util.concurrent.locks.Lock;
		}
		public new int ReadLockCount
		{
			get
			{
				return getReadLockCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReadLockCount21857;
		public virtual int getReadLockCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadLockCount21857);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadLockCount21857);
		}
		internal static global::MonoJavaBridge.MethodId _isWriteLocked21858;
		public virtual bool isWriteLocked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLocked21858);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLocked21858);
		}
		internal static global::MonoJavaBridge.MethodId _isWriteLockedByCurrentThread21859;
		public virtual bool isWriteLockedByCurrentThread() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLockedByCurrentThread21859);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLockedByCurrentThread21859);
		}
		public new int WriteHoldCount
		{
			get
			{
				return getWriteHoldCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWriteHoldCount21860;
		public virtual int getWriteHoldCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWriteHoldCount21860);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getWriteHoldCount21860);
		}
		public new int ReadHoldCount
		{
			get
			{
				return getReadHoldCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReadHoldCount21861;
		public virtual int getReadHoldCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadHoldCount21861);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadHoldCount21861);
		}
		protected new global::java.util.Collection QueuedWriterThreads
		{
			get
			{
				return getQueuedWriterThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedWriterThreads21862;
		protected virtual global::java.util.Collection getQueuedWriterThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedWriterThreads21862)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedWriterThreads21862)) as java.util.Collection;
		}
		protected new global::java.util.Collection QueuedReaderThreads
		{
			get
			{
				return getQueuedReaderThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedReaderThreads21863;
		protected virtual global::java.util.Collection getQueuedReaderThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedReaderThreads21863)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedReaderThreads21863)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _ReentrantReadWriteLock21864;
		public ReentrantReadWriteLock(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock21864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ReentrantReadWriteLock21865;
		public ReentrantReadWriteLock()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock21865);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReentrantReadWriteLock"));
			global::java.util.concurrent.locks.ReentrantReadWriteLock._toString21845 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getOwner21846 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getOwner", "()Ljava/lang/Thread;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._isFair21847 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "isFair", "()Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThreads21848 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "hasQueuedThreads", "()Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._hasQueuedThread21849 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "hasQueuedThread", "(Ljava/lang/Thread;)Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueueLength21850 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueueLength", "()I");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedThreads21851 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueuedThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._hasWaiters21852 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "hasWaiters", "(Ljava/util/concurrent/locks/Condition;)Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitQueueLength21853 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getWaitQueueLength", "(Ljava/util/concurrent/locks/Condition;)I");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getWaitingThreads21854 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getWaitingThreads", "(Ljava/util/concurrent/locks/Condition;)Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._readLock21855 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "readLock", "()Ljava/util/concurrent/locks/Lock;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._writeLock21856 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "writeLock", "()Ljava/util/concurrent/locks/Lock;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadLockCount21857 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getReadLockCount", "()I");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLocked21858 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "isWriteLocked", "()Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._isWriteLockedByCurrentThread21859 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "isWriteLockedByCurrentThread", "()Z");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getWriteHoldCount21860 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getWriteHoldCount", "()I");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getReadHoldCount21861 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getReadHoldCount", "()I");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedWriterThreads21862 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueuedWriterThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._getQueuedReaderThreads21863 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "getQueuedReaderThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock21864 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "<init>", "(Z)V");
			global::java.util.concurrent.locks.ReentrantReadWriteLock._ReentrantReadWriteLock21865 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReentrantReadWriteLock.staticClass, "<init>", "()V");
		}
	}
}
