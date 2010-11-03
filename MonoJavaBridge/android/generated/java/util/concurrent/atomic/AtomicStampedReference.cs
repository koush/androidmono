namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicStampedReference : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicStampedReference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object get(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "get", "([I)Ljava/lang/Object;", ref global::java.util.concurrent.atomic.AtomicStampedReference._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void set(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "set", "(Ljava/lang/Object;I)V", ref global::java.util.concurrent.atomic.AtomicStampedReference._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool compareAndSet(java.lang.Object arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;II)Z", ref global::java.util.concurrent.atomic.AtomicStampedReference._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool weakCompareAndSet(java.lang.Object arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;II)Z", ref global::java.util.concurrent.atomic.AtomicStampedReference._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::java.lang.Object Reference
		{
			get
			{
				return getReference();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.Object getReference()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "getReference", "()Ljava/lang/Object;", ref global::java.util.concurrent.atomic.AtomicStampedReference._m4) as java.lang.Object;
		}
		public new int Stamp
		{
			get
			{
				return getStamp();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getStamp()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "getStamp", "()I", ref global::java.util.concurrent.atomic.AtomicStampedReference._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool attemptStamp(java.lang.Object arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "attemptStamp", "(Ljava/lang/Object;I)Z", ref global::java.util.concurrent.atomic.AtomicStampedReference._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public AtomicStampedReference(java.lang.Object arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicStampedReference._m7.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicStampedReference._m7 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "<init>", "(Ljava/lang/Object;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicStampedReference.staticClass, global::java.util.concurrent.atomic.AtomicStampedReference._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AtomicStampedReference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicStampedReference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicStampedReference"));
		}
	}
}
