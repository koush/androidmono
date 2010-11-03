namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_))]
	public abstract partial class AtomicReferenceFieldUpdater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicReferenceFieldUpdater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.Object get(java.lang.Object arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void set(java.lang.Object arg0, java.lang.Object arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract void lazySet(java.lang.Object arg0, java.lang.Object arg1);
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.Object getAndSet(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, "getAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract bool compareAndSet(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract bool weakCompareAndSet(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2);
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater newUpdater(java.lang.Class arg0, java.lang.Class arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._m6.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._m6 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, "newUpdater", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Ljava/util/concurrent/atomic/AtomicReferenceFieldUpdater;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.concurrent.atomic.AtomicReferenceFieldUpdater;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected AtomicReferenceFieldUpdater() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._m7.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._m7 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater._m7);
			Init(@__env, handle);
		}
		static AtomicReferenceFieldUpdater()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicReferenceFieldUpdater"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater))]
	internal sealed partial class AtomicReferenceFieldUpdater_ : java.util.concurrent.atomic.AtomicReferenceFieldUpdater
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AtomicReferenceFieldUpdater_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void set(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V", ref global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void lazySet(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, "lazySet", "(Ljava/lang/Object;Ljava/lang/Object;)V", ref global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool compareAndSet(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", ref global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool weakCompareAndSet(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", ref global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static AtomicReferenceFieldUpdater_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicReferenceFieldUpdater_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicReferenceFieldUpdater"));
		}
	}
}
