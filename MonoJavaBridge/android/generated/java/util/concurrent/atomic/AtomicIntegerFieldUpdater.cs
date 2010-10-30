namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_))]
	public abstract partial class AtomicIntegerFieldUpdater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicIntegerFieldUpdater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27567;
		public abstract int get(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _set27568;
		public abstract void set(java.lang.Object arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getAndAdd27569;
		public virtual int getAndAdd(java.lang.Object arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "getAndAdd", "(Ljava/lang/Object;I)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndAdd27569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27570;
		public abstract void lazySet(java.lang.Object arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getAndSet27571;
		public virtual int getAndSet(java.lang.Object arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "getAndSet", "(Ljava/lang/Object;I)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndSet27571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27572;
		public abstract bool compareAndSet(java.lang.Object arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27573;
		public abstract bool weakCompareAndSet(java.lang.Object arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _getAndIncrement27574;
		public virtual int getAndIncrement(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "getAndIncrement", "(Ljava/lang/Object;)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndIncrement27574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement27575;
		public virtual int getAndDecrement(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "getAndDecrement", "(Ljava/lang/Object;)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._getAndDecrement27575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet27576;
		public virtual int incrementAndGet(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "incrementAndGet", "(Ljava/lang/Object;)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._incrementAndGet27576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet27577;
		public virtual int decrementAndGet(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "decrementAndGet", "(Ljava/lang/Object;)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._decrementAndGet27577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet27578;
		public virtual int addAndGet(java.lang.Object arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "addAndGet", "(Ljava/lang/Object;I)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._addAndGet27578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newUpdater27579;
		public static global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater newUpdater(java.lang.Class arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._newUpdater27579.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._newUpdater27579 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "newUpdater", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicIntegerFieldUpdater;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._newUpdater27579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.atomic.AtomicIntegerFieldUpdater;
		}
		internal static global::MonoJavaBridge.MethodId _AtomicIntegerFieldUpdater27580;
		protected AtomicIntegerFieldUpdater() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._AtomicIntegerFieldUpdater27580.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._AtomicIntegerFieldUpdater27580 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater._AtomicIntegerFieldUpdater27580);
			Init(@__env, handle);
		}
		static AtomicIntegerFieldUpdater()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicIntegerFieldUpdater"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater))]
	internal sealed partial class AtomicIntegerFieldUpdater_ : java.util.concurrent.atomic.AtomicIntegerFieldUpdater
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AtomicIntegerFieldUpdater_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27581;
		public override int get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, "get", "(Ljava/lang/Object;)I", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._get27581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set27582;
		public override void set(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, "set", "(Ljava/lang/Object;I)V", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._set27582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27583;
		public override void lazySet(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, "lazySet", "(Ljava/lang/Object;I)V", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._lazySet27583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27584;
		public override bool compareAndSet(java.lang.Object arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, "compareAndSet", "(Ljava/lang/Object;II)Z", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._compareAndSet27584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27585;
		public override bool weakCompareAndSet(java.lang.Object arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;II)Z", ref global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_._weakCompareAndSet27585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static AtomicIntegerFieldUpdater_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicIntegerFieldUpdater_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicIntegerFieldUpdater"));
		}
		internal static void InitJNI()
		{
		}
	}
}
