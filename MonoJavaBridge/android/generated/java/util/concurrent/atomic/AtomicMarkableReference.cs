namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicMarkableReference : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicMarkableReference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object get(bool[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "get", "([Z)Ljava/lang/Object;", ref global::java.util.concurrent.atomic.AtomicMarkableReference._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void set(java.lang.Object arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "set", "(Ljava/lang/Object;Z)V", ref global::java.util.concurrent.atomic.AtomicMarkableReference._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool compareAndSet(java.lang.Object arg0, java.lang.Object arg1, bool arg2, bool arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z", ref global::java.util.concurrent.atomic.AtomicMarkableReference._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool weakCompareAndSet(java.lang.Object arg0, java.lang.Object arg1, bool arg2, bool arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;ZZ)Z", ref global::java.util.concurrent.atomic.AtomicMarkableReference._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "getReference", "()Ljava/lang/Object;", ref global::java.util.concurrent.atomic.AtomicMarkableReference._m4) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isMarked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "isMarked", "()Z", ref global::java.util.concurrent.atomic.AtomicMarkableReference._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool attemptMark(java.lang.Object arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "attemptMark", "(Ljava/lang/Object;Z)Z", ref global::java.util.concurrent.atomic.AtomicMarkableReference._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public AtomicMarkableReference(java.lang.Object arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicMarkableReference._m7.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicMarkableReference._m7 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass, "<init>", "(Ljava/lang/Object;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicMarkableReference.staticClass, global::java.util.concurrent.atomic.AtomicMarkableReference._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AtomicMarkableReference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicMarkableReference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicMarkableReference"));
		}
	}
}
