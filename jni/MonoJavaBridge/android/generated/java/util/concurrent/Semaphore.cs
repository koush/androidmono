namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Semaphore : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Semaphore()
		{
			InitJNI();
		}
		protected Semaphore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString21463;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._toString21463)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._toString21463)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _acquire21464;
		public virtual void acquire(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._acquire21464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquire21464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acquire21465;
		public virtual void acquire() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._acquire21465);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquire21465);
		}
		internal static global::MonoJavaBridge.MethodId _release21466;
		public virtual void release(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._release21466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._release21466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _release21467;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._release21467);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._release21467);
		}
		internal static global::MonoJavaBridge.MethodId _isFair21468;
		public virtual bool isFair() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._isFair21468);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._isFair21468);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThreads21469;
		public virtual bool hasQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._hasQueuedThreads21469);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._hasQueuedThreads21469);
		}
		public new int QueueLength
		{
			get
			{
				return getQueueLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueueLength21470;
		public virtual int getQueueLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._getQueueLength21470);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._getQueueLength21470);
		}
		protected new global::java.util.Collection QueuedThreads
		{
			get
			{
				return getQueuedThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedThreads21471;
		protected virtual global::java.util.Collection getQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._getQueuedThreads21471)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._getQueuedThreads21471)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire21472;
		public virtual bool tryAcquire(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._tryAcquire21472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire21472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire21473;
		public virtual bool tryAcquire(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._tryAcquire21473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire21473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire21474;
		public virtual bool tryAcquire(int arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._tryAcquire21474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire21474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire21475;
		public virtual bool tryAcquire() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._tryAcquire21475);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire21475);
		}
		internal static global::MonoJavaBridge.MethodId _acquireUninterruptibly21476;
		public virtual void acquireUninterruptibly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._acquireUninterruptibly21476);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquireUninterruptibly21476);
		}
		internal static global::MonoJavaBridge.MethodId _acquireUninterruptibly21477;
		public virtual void acquireUninterruptibly(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._acquireUninterruptibly21477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquireUninterruptibly21477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _availablePermits21478;
		public virtual int availablePermits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._availablePermits21478);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._availablePermits21478);
		}
		internal static global::MonoJavaBridge.MethodId _drainPermits21479;
		public virtual int drainPermits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._drainPermits21479);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._drainPermits21479);
		}
		internal static global::MonoJavaBridge.MethodId _reducePermits21480;
		protected virtual void reducePermits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._reducePermits21480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._reducePermits21480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Semaphore21481;
		public Semaphore(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._Semaphore21481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Semaphore21482;
		public Semaphore(int arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._Semaphore21482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Semaphore.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Semaphore"));
			global::java.util.concurrent.Semaphore._toString21463 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.Semaphore._acquire21464 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquire", "(I)V");
			global::java.util.concurrent.Semaphore._acquire21465 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquire", "()V");
			global::java.util.concurrent.Semaphore._release21466 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "release", "(I)V");
			global::java.util.concurrent.Semaphore._release21467 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "release", "()V");
			global::java.util.concurrent.Semaphore._isFair21468 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "isFair", "()Z");
			global::java.util.concurrent.Semaphore._hasQueuedThreads21469 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "hasQueuedThreads", "()Z");
			global::java.util.concurrent.Semaphore._getQueueLength21470 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "getQueueLength", "()I");
			global::java.util.concurrent.Semaphore._getQueuedThreads21471 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "getQueuedThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.Semaphore._tryAcquire21472 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.Semaphore._tryAcquire21473 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "(I)Z");
			global::java.util.concurrent.Semaphore._tryAcquire21474 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "(IJLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.Semaphore._tryAcquire21475 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "()Z");
			global::java.util.concurrent.Semaphore._acquireUninterruptibly21476 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquireUninterruptibly", "()V");
			global::java.util.concurrent.Semaphore._acquireUninterruptibly21477 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquireUninterruptibly", "(I)V");
			global::java.util.concurrent.Semaphore._availablePermits21478 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "availablePermits", "()I");
			global::java.util.concurrent.Semaphore._drainPermits21479 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "drainPermits", "()I");
			global::java.util.concurrent.Semaphore._reducePermits21480 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "reducePermits", "(I)V");
			global::java.util.concurrent.Semaphore._Semaphore21481 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.Semaphore._Semaphore21482 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "<init>", "(IZ)V");
		}
	}
}
