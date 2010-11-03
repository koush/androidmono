namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Semaphore : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Semaphore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.Semaphore.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.Semaphore._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void acquire(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.Semaphore.staticClass, "acquire", "(I)V", ref global::java.util.concurrent.Semaphore._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void acquire()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.Semaphore.staticClass, "acquire", "()V", ref global::java.util.concurrent.Semaphore._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void release(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.Semaphore.staticClass, "release", "(I)V", ref global::java.util.concurrent.Semaphore._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void release()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.Semaphore.staticClass, "release", "()V", ref global::java.util.concurrent.Semaphore._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isFair()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.Semaphore.staticClass, "isFair", "()Z", ref global::java.util.concurrent.Semaphore._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool hasQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.Semaphore.staticClass, "hasQueuedThreads", "()Z", ref global::java.util.concurrent.Semaphore._m6);
		}
		public new int QueueLength
		{
			get
			{
				return getQueueLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getQueueLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.Semaphore.staticClass, "getQueueLength", "()I", ref global::java.util.concurrent.Semaphore._m7);
		}
		protected new global::java.util.Collection QueuedThreads
		{
			get
			{
				return getQueuedThreads();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual global::java.util.Collection getQueuedThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.Semaphore.staticClass, "getQueuedThreads", "()Ljava/util/Collection;", ref global::java.util.concurrent.Semaphore._m8) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool tryAcquire(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.Semaphore._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool tryAcquire(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "(I)Z", ref global::java.util.concurrent.Semaphore._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool tryAcquire(int arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "(IJLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.Semaphore._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool tryAcquire()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.Semaphore.staticClass, "tryAcquire", "()Z", ref global::java.util.concurrent.Semaphore._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void acquireUninterruptibly()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.Semaphore.staticClass, "acquireUninterruptibly", "()V", ref global::java.util.concurrent.Semaphore._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void acquireUninterruptibly(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.Semaphore.staticClass, "acquireUninterruptibly", "(I)V", ref global::java.util.concurrent.Semaphore._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int availablePermits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.Semaphore.staticClass, "availablePermits", "()I", ref global::java.util.concurrent.Semaphore._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int drainPermits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.Semaphore.staticClass, "drainPermits", "()I", ref global::java.util.concurrent.Semaphore._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected virtual void reducePermits(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.Semaphore.staticClass, "reducePermits", "(I)V", ref global::java.util.concurrent.Semaphore._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public Semaphore(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._m18.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._m18 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public Semaphore(int arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Semaphore._m19.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Semaphore._m19 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Semaphore.staticClass, "<init>", "(IZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.Semaphore.staticClass, global::java.util.concurrent.Semaphore._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Semaphore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Semaphore.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Semaphore"));
		}
	}
}
