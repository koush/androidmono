namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicInteger : java.lang.Number, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicInteger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27532;
		public virtual int get()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "get", "()I", ref global::java.util.concurrent.atomic.AtomicInteger._get27532);
		}
		internal static global::MonoJavaBridge.MethodId _toString27533;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.atomic.AtomicInteger._toString27533) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set27534;
		public virtual void set(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "set", "(I)V", ref global::java.util.concurrent.atomic.AtomicInteger._set27534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intValue27535;
		public override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "intValue", "()I", ref global::java.util.concurrent.atomic.AtomicInteger._intValue27535);
		}
		internal static global::MonoJavaBridge.MethodId _longValue27536;
		public override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "longValue", "()J", ref global::java.util.concurrent.atomic.AtomicInteger._longValue27536);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue27537;
		public override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "floatValue", "()F", ref global::java.util.concurrent.atomic.AtomicInteger._floatValue27537);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue27538;
		public override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "doubleValue", "()D", ref global::java.util.concurrent.atomic.AtomicInteger._doubleValue27538);
		}
		internal static global::MonoJavaBridge.MethodId _getAndAdd27539;
		public virtual int getAndAdd(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndAdd", "(I)I", ref global::java.util.concurrent.atomic.AtomicInteger._getAndAdd27539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27540;
		public virtual void lazySet(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "lazySet", "(I)V", ref global::java.util.concurrent.atomic.AtomicInteger._lazySet27540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet27541;
		public virtual int getAndSet(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndSet", "(I)I", ref global::java.util.concurrent.atomic.AtomicInteger._getAndSet27541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27542;
		public virtual bool compareAndSet(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "compareAndSet", "(II)Z", ref global::java.util.concurrent.atomic.AtomicInteger._compareAndSet27542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27543;
		public virtual bool weakCompareAndSet(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "weakCompareAndSet", "(II)Z", ref global::java.util.concurrent.atomic.AtomicInteger._weakCompareAndSet27543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int AndIncrement
		{
			get
			{
				return getAndIncrement();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAndIncrement27544;
		public virtual int getAndIncrement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndIncrement", "()I", ref global::java.util.concurrent.atomic.AtomicInteger._getAndIncrement27544);
		}
		public new int AndDecrement
		{
			get
			{
				return getAndDecrement();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement27545;
		public virtual int getAndDecrement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "getAndDecrement", "()I", ref global::java.util.concurrent.atomic.AtomicInteger._getAndDecrement27545);
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet27546;
		public virtual int incrementAndGet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "incrementAndGet", "()I", ref global::java.util.concurrent.atomic.AtomicInteger._incrementAndGet27546);
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet27547;
		public virtual int decrementAndGet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "decrementAndGet", "()I", ref global::java.util.concurrent.atomic.AtomicInteger._decrementAndGet27547);
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet27548;
		public virtual int addAndGet(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicInteger.staticClass, "addAndGet", "(I)I", ref global::java.util.concurrent.atomic.AtomicInteger._addAndGet27548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicInteger27549;
		public AtomicInteger(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicInteger._AtomicInteger27549.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicInteger._AtomicInteger27549 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._AtomicInteger27549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicInteger27550;
		public AtomicInteger() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicInteger._AtomicInteger27550.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicInteger._AtomicInteger27550 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicInteger.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicInteger.staticClass, global::java.util.concurrent.atomic.AtomicInteger._AtomicInteger27550);
			Init(@__env, handle);
		}
		static AtomicInteger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicInteger.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicInteger"));
		}
		internal static void InitJNI()
		{
		}
	}
}
