namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicBoolean : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicBoolean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool get()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "get", "()Z", ref global::java.util.concurrent.atomic.AtomicBoolean._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.atomic.AtomicBoolean._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void set(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "set", "(Z)V", ref global::java.util.concurrent.atomic.AtomicBoolean._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void lazySet(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "lazySet", "(Z)V", ref global::java.util.concurrent.atomic.AtomicBoolean._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool getAndSet(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "getAndSet", "(Z)Z", ref global::java.util.concurrent.atomic.AtomicBoolean._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool compareAndSet(bool arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "compareAndSet", "(ZZ)Z", ref global::java.util.concurrent.atomic.AtomicBoolean._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool weakCompareAndSet(bool arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "weakCompareAndSet", "(ZZ)Z", ref global::java.util.concurrent.atomic.AtomicBoolean._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public AtomicBoolean(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicBoolean._m7.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicBoolean._m7 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public AtomicBoolean() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicBoolean._m8.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicBoolean._m8 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._m8);
			Init(@__env, handle);
		}
		static AtomicBoolean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicBoolean.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicBoolean"));
		}
	}
}
