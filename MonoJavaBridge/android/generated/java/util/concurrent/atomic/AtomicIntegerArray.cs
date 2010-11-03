namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicIntegerArray : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicIntegerArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "get", "(I)I", ref global::java.util.concurrent.atomic.AtomicIntegerArray._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.atomic.AtomicIntegerArray._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "length", "()I", ref global::java.util.concurrent.atomic.AtomicIntegerArray._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void set(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "set", "(II)V", ref global::java.util.concurrent.atomic.AtomicIntegerArray._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getAndAdd(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndAdd", "(II)I", ref global::java.util.concurrent.atomic.AtomicIntegerArray._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void lazySet(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "lazySet", "(II)V", ref global::java.util.concurrent.atomic.AtomicIntegerArray._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getAndSet(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndSet", "(II)I", ref global::java.util.concurrent.atomic.AtomicIntegerArray._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool compareAndSet(int arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "compareAndSet", "(III)Z", ref global::java.util.concurrent.atomic.AtomicIntegerArray._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool weakCompareAndSet(int arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "weakCompareAndSet", "(III)Z", ref global::java.util.concurrent.atomic.AtomicIntegerArray._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getAndIncrement(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndIncrement", "(I)I", ref global::java.util.concurrent.atomic.AtomicIntegerArray._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getAndDecrement(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "getAndDecrement", "(I)I", ref global::java.util.concurrent.atomic.AtomicIntegerArray._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int incrementAndGet(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "incrementAndGet", "(I)I", ref global::java.util.concurrent.atomic.AtomicIntegerArray._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int decrementAndGet(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "decrementAndGet", "(I)I", ref global::java.util.concurrent.atomic.AtomicIntegerArray._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int addAndGet(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "addAndGet", "(II)I", ref global::java.util.concurrent.atomic.AtomicIntegerArray._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public AtomicIntegerArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicIntegerArray._m14.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicIntegerArray._m14 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public AtomicIntegerArray(int[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicIntegerArray._m15.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicIntegerArray._m15 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass, "<init>", "([I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicIntegerArray.staticClass, global::java.util.concurrent.atomic.AtomicIntegerArray._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AtomicIntegerArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicIntegerArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicIntegerArray"));
		}
	}
}
