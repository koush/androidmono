namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicInteger : java.lang.Number, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicInteger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int get()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "get", "()I", ref global::java.util.concurrent.atomic.AtomicInteger._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.atomic.AtomicInteger._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void set(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "set", "(I)V", ref global::java.util.concurrent.atomic.AtomicInteger._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "intValue", "()I", ref global::java.util.concurrent.atomic.AtomicInteger._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "longValue", "()J", ref global::java.util.concurrent.atomic.AtomicInteger._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "floatValue", "()F", ref global::java.util.concurrent.atomic.AtomicInteger._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "doubleValue", "()D", ref global::java.util.concurrent.atomic.AtomicInteger._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getAndAdd(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndAdd", "(I)I", ref global::java.util.concurrent.atomic.AtomicInteger._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void lazySet(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "lazySet", "(I)V", ref global::java.util.concurrent.atomic.AtomicInteger._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getAndSet(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndSet", "(I)I", ref global::java.util.concurrent.atomic.AtomicInteger._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool compareAndSet(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "compareAndSet", "(II)Z", ref global::java.util.concurrent.atomic.AtomicInteger._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool weakCompareAndSet(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "weakCompareAndSet", "(II)Z", ref global::java.util.concurrent.atomic.AtomicInteger._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int AndIncrement
		{
			get
			{
				return getAndIncrement();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int getAndIncrement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndIncrement", "()I", ref global::java.util.concurrent.atomic.AtomicInteger._m12);
		}
		public new int AndDecrement
		{
			get
			{
				return getAndDecrement();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int getAndDecrement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndDecrement", "()I", ref global::java.util.concurrent.atomic.AtomicInteger._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int incrementAndGet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "incrementAndGet", "()I", ref global::java.util.concurrent.atomic.AtomicInteger._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int decrementAndGet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "decrementAndGet", "()I", ref global::java.util.concurrent.atomic.AtomicInteger._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int addAndGet(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "addAndGet", "(I)I", ref global::java.util.concurrent.atomic.AtomicInteger._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public AtomicInteger(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicInteger._m17.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicInteger._m17 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public AtomicInteger() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicInteger._m18.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicInteger._m18 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._m18);
			Init(@__env, handle);
		}
		static AtomicInteger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicInteger.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicInteger"));
		}
	}
}
