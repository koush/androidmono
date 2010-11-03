namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicLongArray : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicLongArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual long get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "get", "(I)J", ref global::java.util.concurrent.atomic.AtomicLongArray._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.atomic.AtomicLongArray._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "length", "()I", ref global::java.util.concurrent.atomic.AtomicLongArray._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void set(int arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "set", "(IJ)V", ref global::java.util.concurrent.atomic.AtomicLongArray._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual long getAndAdd(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndAdd", "(IJ)J", ref global::java.util.concurrent.atomic.AtomicLongArray._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void lazySet(int arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "lazySet", "(IJ)V", ref global::java.util.concurrent.atomic.AtomicLongArray._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual long getAndSet(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndSet", "(IJ)J", ref global::java.util.concurrent.atomic.AtomicLongArray._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool compareAndSet(int arg0, long arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "compareAndSet", "(IJJ)Z", ref global::java.util.concurrent.atomic.AtomicLongArray._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool weakCompareAndSet(int arg0, long arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "weakCompareAndSet", "(IJJ)Z", ref global::java.util.concurrent.atomic.AtomicLongArray._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual long getAndIncrement(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndIncrement", "(I)J", ref global::java.util.concurrent.atomic.AtomicLongArray._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual long getAndDecrement(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndDecrement", "(I)J", ref global::java.util.concurrent.atomic.AtomicLongArray._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual long incrementAndGet(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "incrementAndGet", "(I)J", ref global::java.util.concurrent.atomic.AtomicLongArray._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual long decrementAndGet(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "decrementAndGet", "(I)J", ref global::java.util.concurrent.atomic.AtomicLongArray._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual long addAndGet(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "addAndGet", "(IJ)J", ref global::java.util.concurrent.atomic.AtomicLongArray._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public AtomicLongArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicLongArray._m14.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicLongArray._m14 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public AtomicLongArray(long[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicLongArray._m15.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicLongArray._m15 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "<init>", "([J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AtomicLongArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicLongArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicLongArray"));
		}
	}
}
