namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicIntegerArray : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicIntegerArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27551;
		public virtual int get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._get27551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString27552;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._toString27552)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length27553;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._length27553);
		}
		internal static global::MonoJavaBridge.MethodId _set27554;
		public virtual void set(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._set27554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndAdd27555;
		public virtual int getAndAdd(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndAdd27555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27556;
		public virtual void lazySet(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._lazySet27556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet27557;
		public virtual int getAndSet(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndSet27557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27558;
		public virtual bool compareAndSet(int arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._compareAndSet27558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27559;
		public virtual bool weakCompareAndSet(int arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._weakCompareAndSet27559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAndIncrement27560;
		public virtual int getAndIncrement(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndIncrement27560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement27561;
		public virtual int getAndDecrement(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._getAndDecrement27561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet27562;
		public virtual int incrementAndGet(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._incrementAndGet27562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet27563;
		public virtual int decrementAndGet(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._decrementAndGet27563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet27564;
		public virtual int addAndGet(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._addAndGet27564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicIntegerArray27565;
		public AtomicIntegerArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._AtomicIntegerArray27565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicIntegerArray27566;
		public AtomicIntegerArray(int[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._AtomicIntegerArray27566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AtomicIntegerArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicIntegerArray"));
			global::java.util.concurrent.atomic.AtomicIntegerArray._get27551 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "get", "(I)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._toString27552 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicIntegerArray._length27553 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "length", "()I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._set27554 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "set", "(II)V");
			global::java.util.concurrent.atomic.AtomicIntegerArray._getAndAdd27555 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndAdd", "(II)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._lazySet27556 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "lazySet", "(II)V");
			global::java.util.concurrent.atomic.AtomicIntegerArray._getAndSet27557 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndSet", "(II)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._compareAndSet27558 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "compareAndSet", "(III)Z");
			global::java.util.concurrent.atomic.AtomicIntegerArray._weakCompareAndSet27559 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "weakCompareAndSet", "(III)Z");
			global::java.util.concurrent.atomic.AtomicIntegerArray._getAndIncrement27560 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndIncrement", "(I)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._getAndDecrement27561 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndDecrement", "(I)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._incrementAndGet27562 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "incrementAndGet", "(I)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._decrementAndGet27563 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "decrementAndGet", "(I)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._addAndGet27564 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "addAndGet", "(II)I");
			global::java.util.concurrent.atomic.AtomicIntegerArray._AtomicIntegerArray27565 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.atomic.AtomicIntegerArray._AtomicIntegerArray27566 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "<init>", "([I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
