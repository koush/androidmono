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
		internal static global::MonoJavaBridge.MethodId _toString27411;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._toString27411)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._toString27411)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _acquire27412;
		public virtual void acquire(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._acquire27412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquire27412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acquire27413;
		public virtual void acquire() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._acquire27413);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquire27413);
		}
		internal static global::MonoJavaBridge.MethodId _release27414;
		public virtual void release(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._release27414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._release27414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _release27415;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._release27415);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._release27415);
		}
		internal static global::MonoJavaBridge.MethodId _isFair27416;
		public virtual bool isFair() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._isFair27416);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._isFair27416);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThreads27417;
		public virtual bool hasQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._hasQueuedThreads27417);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._hasQueuedThreads27417);
		}
		public new int QueueLength
		{
			get
			{
				return getQueueLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueueLength27418;
		public virtual int getQueueLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._getQueueLength27418);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._getQueueLength27418);
		}
		protected new global::java.util.Collection QueuedThreads
		{
			get
			{
				return getQueuedThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedThreads27419;
		protected virtual global::java.util.Collection getQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._getQueuedThreads27419)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._getQueuedThreads27419)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire27420;
		public virtual bool tryAcquire(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._tryAcquire27420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire27420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire27421;
		public virtual bool tryAcquire(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._tryAcquire27421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire27421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire27422;
		public virtual bool tryAcquire(int arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._tryAcquire27422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire27422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire27423;
		public virtual bool tryAcquire() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._tryAcquire27423);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire27423);
		}
		internal static global::MonoJavaBridge.MethodId _acquireUninterruptibly27424;
		public virtual void acquireUninterruptibly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._acquireUninterruptibly27424);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquireUninterruptibly27424);
		}
		internal static global::MonoJavaBridge.MethodId _acquireUninterruptibly27425;
		public virtual void acquireUninterruptibly(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._acquireUninterruptibly27425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquireUninterruptibly27425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _availablePermits27426;
		public virtual int availablePermits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._availablePermits27426);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._availablePermits27426);
		}
		internal static global::MonoJavaBridge.MethodId _drainPermits27427;
		public virtual int drainPermits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._drainPermits27427);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._drainPermits27427);
		}
		internal static global::MonoJavaBridge.MethodId _reducePermits27428;
		protected virtual void reducePermits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._reducePermits27428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._reducePermits27428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Semaphore27429;
		public Semaphore(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._Semaphore27429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Semaphore27430;
		public Semaphore(int arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._Semaphore27430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Semaphore.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Semaphore"));
			global::java.util.concurrent.Semaphore._toString27411 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.Semaphore._acquire27412 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquire", "(I)V");
			global::java.util.concurrent.Semaphore._acquire27413 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquire", "()V");
			global::java.util.concurrent.Semaphore._release27414 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "release", "(I)V");
			global::java.util.concurrent.Semaphore._release27415 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "release", "()V");
			global::java.util.concurrent.Semaphore._isFair27416 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "isFair", "()Z");
			global::java.util.concurrent.Semaphore._hasQueuedThreads27417 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "hasQueuedThreads", "()Z");
			global::java.util.concurrent.Semaphore._getQueueLength27418 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "getQueueLength", "()I");
			global::java.util.concurrent.Semaphore._getQueuedThreads27419 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "getQueuedThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.Semaphore._tryAcquire27420 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.Semaphore._tryAcquire27421 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "(I)Z");
			global::java.util.concurrent.Semaphore._tryAcquire27422 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "(IJLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.Semaphore._tryAcquire27423 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "()Z");
			global::java.util.concurrent.Semaphore._acquireUninterruptibly27424 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquireUninterruptibly", "()V");
			global::java.util.concurrent.Semaphore._acquireUninterruptibly27425 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquireUninterruptibly", "(I)V");
			global::java.util.concurrent.Semaphore._availablePermits27426 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "availablePermits", "()I");
			global::java.util.concurrent.Semaphore._drainPermits27427 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "drainPermits", "()I");
			global::java.util.concurrent.Semaphore._reducePermits27428 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "reducePermits", "(I)V");
			global::java.util.concurrent.Semaphore._Semaphore27429 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.Semaphore._Semaphore27430 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "<init>", "(IZ)V");
		}
	}
}
