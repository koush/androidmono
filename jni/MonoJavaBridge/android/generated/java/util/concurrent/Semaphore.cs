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
		internal static global::MonoJavaBridge.MethodId _toString27293;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._toString27293)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._toString27293)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _acquire27294;
		public virtual void acquire(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._acquire27294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquire27294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acquire27295;
		public virtual void acquire() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._acquire27295);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquire27295);
		}
		internal static global::MonoJavaBridge.MethodId _release27296;
		public virtual void release(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._release27296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._release27296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _release27297;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._release27297);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._release27297);
		}
		internal static global::MonoJavaBridge.MethodId _isFair27298;
		public virtual bool isFair() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._isFair27298);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._isFair27298);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThreads27299;
		public virtual bool hasQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._hasQueuedThreads27299);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._hasQueuedThreads27299);
		}
		public new int QueueLength
		{
			get
			{
				return getQueueLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueueLength27300;
		public virtual int getQueueLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._getQueueLength27300);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._getQueueLength27300);
		}
		protected new global::java.util.Collection QueuedThreads
		{
			get
			{
				return getQueuedThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedThreads27301;
		protected virtual global::java.util.Collection getQueuedThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._getQueuedThreads27301)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._getQueuedThreads27301)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire27302;
		public virtual bool tryAcquire(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._tryAcquire27302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire27302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire27303;
		public virtual bool tryAcquire(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._tryAcquire27303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire27303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire27304;
		public virtual bool tryAcquire(int arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._tryAcquire27304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire27304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire27305;
		public virtual bool tryAcquire() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._tryAcquire27305);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire27305);
		}
		internal static global::MonoJavaBridge.MethodId _acquireUninterruptibly27306;
		public virtual void acquireUninterruptibly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._acquireUninterruptibly27306);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquireUninterruptibly27306);
		}
		internal static global::MonoJavaBridge.MethodId _acquireUninterruptibly27307;
		public virtual void acquireUninterruptibly(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._acquireUninterruptibly27307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquireUninterruptibly27307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _availablePermits27308;
		public virtual int availablePermits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._availablePermits27308);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._availablePermits27308);
		}
		internal static global::MonoJavaBridge.MethodId _drainPermits27309;
		public virtual int drainPermits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._drainPermits27309);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._drainPermits27309);
		}
		internal static global::MonoJavaBridge.MethodId _reducePermits27310;
		protected virtual void reducePermits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore._reducePermits27310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._reducePermits27310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Semaphore27311;
		public Semaphore(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._Semaphore27311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Semaphore27312;
		public Semaphore(int arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._Semaphore27312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Semaphore.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Semaphore"));
			global::java.util.concurrent.Semaphore._toString27293 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.Semaphore._acquire27294 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquire", "(I)V");
			global::java.util.concurrent.Semaphore._acquire27295 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquire", "()V");
			global::java.util.concurrent.Semaphore._release27296 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "release", "(I)V");
			global::java.util.concurrent.Semaphore._release27297 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "release", "()V");
			global::java.util.concurrent.Semaphore._isFair27298 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "isFair", "()Z");
			global::java.util.concurrent.Semaphore._hasQueuedThreads27299 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "hasQueuedThreads", "()Z");
			global::java.util.concurrent.Semaphore._getQueueLength27300 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "getQueueLength", "()I");
			global::java.util.concurrent.Semaphore._getQueuedThreads27301 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "getQueuedThreads", "()Ljava/util/Collection;");
			global::java.util.concurrent.Semaphore._tryAcquire27302 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.Semaphore._tryAcquire27303 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "(I)Z");
			global::java.util.concurrent.Semaphore._tryAcquire27304 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "(IJLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.Semaphore._tryAcquire27305 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "()Z");
			global::java.util.concurrent.Semaphore._acquireUninterruptibly27306 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquireUninterruptibly", "()V");
			global::java.util.concurrent.Semaphore._acquireUninterruptibly27307 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquireUninterruptibly", "(I)V");
			global::java.util.concurrent.Semaphore._availablePermits27308 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "availablePermits", "()I");
			global::java.util.concurrent.Semaphore._drainPermits27309 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "drainPermits", "()I");
			global::java.util.concurrent.Semaphore._reducePermits27310 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "reducePermits", "(I)V");
			global::java.util.concurrent.Semaphore._Semaphore27311 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.Semaphore._Semaphore27312 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "<init>", "(IZ)V");
		}
	}
}
