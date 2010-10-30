namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Semaphore : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Semaphore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString27412;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._toString27412.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._toString27412 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._toString27412) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _acquire27413;
		public virtual void acquire(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._acquire27413.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._acquire27413 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquire", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquire27413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acquire27414;
		public virtual void acquire()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._acquire27414.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._acquire27414 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquire", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquire27414);
		}
		internal static global::MonoJavaBridge.MethodId _release27415;
		public virtual void release(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._release27415.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._release27415 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "release", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._release27415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _release27416;
		public virtual void release()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._release27416.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._release27416 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "release", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._release27416);
		}
		internal static global::MonoJavaBridge.MethodId _isFair27417;
		public virtual bool isFair()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._isFair27417.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._isFair27417 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "isFair", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._isFair27417);
		}
		internal static global::MonoJavaBridge.MethodId _hasQueuedThreads27418;
		public virtual bool hasQueuedThreads()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._hasQueuedThreads27418.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._hasQueuedThreads27418 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "hasQueuedThreads", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._hasQueuedThreads27418);
		}
		public new int QueueLength
		{
			get
			{
				return getQueueLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueueLength27419;
		public virtual int getQueueLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._getQueueLength27419.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._getQueueLength27419 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "getQueueLength", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._getQueueLength27419);
		}
		protected new global::java.util.Collection QueuedThreads
		{
			get
			{
				return getQueuedThreads();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQueuedThreads27420;
		protected virtual global::java.util.Collection getQueuedThreads()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._getQueuedThreads27420.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._getQueuedThreads27420 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "getQueuedThreads", "()Ljava/util/Collection;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._getQueuedThreads27420) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire27421;
		public virtual bool tryAcquire(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._tryAcquire27421.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._tryAcquire27421 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "(JLjava/util/concurrent/TimeUnit;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire27421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire27422;
		public virtual bool tryAcquire(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._tryAcquire27422.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._tryAcquire27422 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire27422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire27423;
		public virtual bool tryAcquire(int arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._tryAcquire27423.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._tryAcquire27423 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "(IJLjava/util/concurrent/TimeUnit;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire27423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _tryAcquire27424;
		public virtual bool tryAcquire()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._tryAcquire27424.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._tryAcquire27424 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._tryAcquire27424);
		}
		internal static global::MonoJavaBridge.MethodId _acquireUninterruptibly27425;
		public virtual void acquireUninterruptibly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._acquireUninterruptibly27425.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._acquireUninterruptibly27425 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquireUninterruptibly", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquireUninterruptibly27425);
		}
		internal static global::MonoJavaBridge.MethodId _acquireUninterruptibly27426;
		public virtual void acquireUninterruptibly(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._acquireUninterruptibly27426.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._acquireUninterruptibly27426 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "acquireUninterruptibly", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._acquireUninterruptibly27426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _availablePermits27427;
		public virtual int availablePermits()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._availablePermits27427.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._availablePermits27427 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "availablePermits", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._availablePermits27427);
		}
		internal static global::MonoJavaBridge.MethodId _drainPermits27428;
		public virtual int drainPermits()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._drainPermits27428.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._drainPermits27428 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "drainPermits", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._drainPermits27428);
		}
		internal static global::MonoJavaBridge.MethodId _reducePermits27429;
		protected virtual void reducePermits(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._reducePermits27429.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._reducePermits27429 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "reducePermits", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._reducePermits27429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Semaphore27430;
		public Semaphore(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._Semaphore27430.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._Semaphore27430 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._Semaphore27430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Semaphore27431;
		public Semaphore(int arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._Semaphore27431.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._Semaphore27431 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "<init>", "(IZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._Semaphore27431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Semaphore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Semaphore.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Semaphore"));
		}
		internal static void InitJNI()
		{
		}
	}
}
