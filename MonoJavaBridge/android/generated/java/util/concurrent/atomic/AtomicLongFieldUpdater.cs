namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.atomic.AtomicLongFieldUpdater_))]
	public abstract partial class AtomicLongFieldUpdater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicLongFieldUpdater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract long get(java.lang.Object arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void set(java.lang.Object arg0, long arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual long getAndAdd(java.lang.Object arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "getAndAdd", "(Ljava/lang/Object;J)J", ref global::java.util.concurrent.atomic.AtomicLongFieldUpdater._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void lazySet(java.lang.Object arg0, long arg1);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual long getAndSet(java.lang.Object arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "getAndSet", "(Ljava/lang/Object;J)J", ref global::java.util.concurrent.atomic.AtomicLongFieldUpdater._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract bool compareAndSet(java.lang.Object arg0, long arg1, long arg2);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract bool weakCompareAndSet(java.lang.Object arg0, long arg1, long arg2);
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual long getAndIncrement(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "getAndIncrement", "(Ljava/lang/Object;)J", ref global::java.util.concurrent.atomic.AtomicLongFieldUpdater._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual long getAndDecrement(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "getAndDecrement", "(Ljava/lang/Object;)J", ref global::java.util.concurrent.atomic.AtomicLongFieldUpdater._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual long incrementAndGet(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "incrementAndGet", "(Ljava/lang/Object;)J", ref global::java.util.concurrent.atomic.AtomicLongFieldUpdater._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual long decrementAndGet(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "decrementAndGet", "(Ljava/lang/Object;)J", ref global::java.util.concurrent.atomic.AtomicLongFieldUpdater._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual long addAndGet(java.lang.Object arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "addAndGet", "(Ljava/lang/Object;J)J", ref global::java.util.concurrent.atomic.AtomicLongFieldUpdater._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::java.util.concurrent.atomic.AtomicLongFieldUpdater newUpdater(java.lang.Class arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicLongFieldUpdater._m12.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicLongFieldUpdater._m12 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "newUpdater", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicLongFieldUpdater;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.atomic.AtomicLongFieldUpdater;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected AtomicLongFieldUpdater() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicLongFieldUpdater._m13.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicLongFieldUpdater._m13 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicLongFieldUpdater._m13);
			Init(@__env, handle);
		}
		static AtomicLongFieldUpdater()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicLongFieldUpdater"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.atomic.AtomicLongFieldUpdater))]
	internal sealed partial class AtomicLongFieldUpdater_ : java.util.concurrent.atomic.AtomicLongFieldUpdater
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AtomicLongFieldUpdater_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override long get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, "get", "(Ljava/lang/Object;)J", ref global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void set(java.lang.Object arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, "set", "(Ljava/lang/Object;J)V", ref global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void lazySet(java.lang.Object arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, "lazySet", "(Ljava/lang/Object;J)V", ref global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool compareAndSet(java.lang.Object arg0, long arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, "compareAndSet", "(Ljava/lang/Object;JJ)Z", ref global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool weakCompareAndSet(java.lang.Object arg0, long arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;JJ)Z", ref global::java.util.concurrent.atomic.AtomicLongFieldUpdater_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static AtomicLongFieldUpdater_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicLongFieldUpdater_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicLongFieldUpdater"));
		}
	}
}
