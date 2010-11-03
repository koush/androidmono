namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicReference : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicReference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object get()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicReference.staticClass, "get", "()Ljava/lang/Object;", ref global::java.util.concurrent.atomic.AtomicReference._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.atomic.AtomicReference.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.atomic.AtomicReference._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void set(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicReference.staticClass, "set", "(Ljava/lang/Object;)V", ref global::java.util.concurrent.atomic.AtomicReference._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void lazySet(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicReference.staticClass, "lazySet", "(Ljava/lang/Object;)V", ref global::java.util.concurrent.atomic.AtomicReference._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.Object getAndSet(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicReference.staticClass, "getAndSet", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.atomic.AtomicReference._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool compareAndSet(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicReference.staticClass, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Z", ref global::java.util.concurrent.atomic.AtomicReference._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool weakCompareAndSet(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicReference.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Z", ref global::java.util.concurrent.atomic.AtomicReference._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public AtomicReference(java.lang.Object arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReference._m7.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReference._m7 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public AtomicReference() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReference._m8.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReference._m8 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._m8);
			Init(@__env, handle);
		}
		static AtomicReference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicReference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicReference"));
		}
	}
}
