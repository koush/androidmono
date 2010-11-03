namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicLong : java.lang.Number, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicLong(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual long get()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "get", "()J", ref global::java.util.concurrent.atomic.AtomicLong._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.atomic.AtomicLong._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void set(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "set", "(J)V", ref global::java.util.concurrent.atomic.AtomicLong._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "intValue", "()I", ref global::java.util.concurrent.atomic.AtomicLong._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "longValue", "()J", ref global::java.util.concurrent.atomic.AtomicLong._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "floatValue", "()F", ref global::java.util.concurrent.atomic.AtomicLong._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "doubleValue", "()D", ref global::java.util.concurrent.atomic.AtomicLong._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual long getAndAdd(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndAdd", "(J)J", ref global::java.util.concurrent.atomic.AtomicLong._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void lazySet(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "lazySet", "(J)V", ref global::java.util.concurrent.atomic.AtomicLong._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual long getAndSet(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndSet", "(J)J", ref global::java.util.concurrent.atomic.AtomicLong._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool compareAndSet(long arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "compareAndSet", "(JJ)Z", ref global::java.util.concurrent.atomic.AtomicLong._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool weakCompareAndSet(long arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "weakCompareAndSet", "(JJ)Z", ref global::java.util.concurrent.atomic.AtomicLong._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new long AndIncrement
		{
			get
			{
				return getAndIncrement();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual long getAndIncrement()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndIncrement", "()J", ref global::java.util.concurrent.atomic.AtomicLong._m12);
		}
		public new long AndDecrement
		{
			get
			{
				return getAndDecrement();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual long getAndDecrement()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "getAndDecrement", "()J", ref global::java.util.concurrent.atomic.AtomicLong._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual long incrementAndGet()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "incrementAndGet", "()J", ref global::java.util.concurrent.atomic.AtomicLong._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual long decrementAndGet()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "decrementAndGet", "()J", ref global::java.util.concurrent.atomic.AtomicLong._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual long addAndGet(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLong.staticClass, "addAndGet", "(J)J", ref global::java.util.concurrent.atomic.AtomicLong._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public AtomicLong(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicLong._m17.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicLong._m17 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "<init>", "(J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public AtomicLong() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicLong._m18.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicLong._m18 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLong.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLong.staticClass, global::java.util.concurrent.atomic.AtomicLong._m18);
			Init(@__env, handle);
		}
		static AtomicLong()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicLong.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicLong"));
		}
	}
}
