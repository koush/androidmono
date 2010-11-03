namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_))]
	public abstract partial class AtomicIntegerFieldUpdater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicIntegerFieldUpdater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract int get(java.lang.Object arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void set(java.lang.Object arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getAndAdd(java.lang.Object arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "getAndAdd", "(Ljava/lang/Object;I)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void lazySet(java.lang.Object arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getAndSet(java.lang.Object arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "getAndSet", "(Ljava/lang/Object;I)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract bool compareAndSet(java.lang.Object arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract bool weakCompareAndSet(java.lang.Object arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getAndIncrement(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "getAndIncrement", "(Ljava/lang/Object;)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getAndDecrement(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "getAndDecrement", "(Ljava/lang/Object;)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int incrementAndGet(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "incrementAndGet", "(Ljava/lang/Object;)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int decrementAndGet(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "decrementAndGet", "(Ljava/lang/Object;)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int addAndGet(java.lang.Object arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "addAndGet", "(Ljava/lang/Object;I)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater newUpdater(java.lang.Class arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._m12.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._m12 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "newUpdater", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicIntegerFieldUpdater;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.atomic.AtomicIntegerFieldUpdater;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected AtomicIntegerFieldUpdater() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._m13.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._m13 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._m13);
			Init(@__env, handle);
		}
		static AtomicIntegerFieldUpdater()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicIntegerFieldUpdater"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater))]
	internal sealed partial class AtomicIntegerFieldUpdater_ : java.util.concurrent.atomic.AtomicIntegerFieldUpdater
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AtomicIntegerFieldUpdater_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, "get", "(Ljava/lang/Object;)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void set(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, "set", "(Ljava/lang/Object;I)V", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void lazySet(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, "lazySet", "(Ljava/lang/Object;I)V", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool compareAndSet(java.lang.Object arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, "compareAndSet", "(Ljava/lang/Object;II)Z", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool weakCompareAndSet(java.lang.Object arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;II)Z", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static AtomicIntegerFieldUpdater_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicIntegerFieldUpdater"));
		}
	}
}
