namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicReferenceArray : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicReferenceArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "get", "(I)Ljava/lang/Object;", ref global::java.util.concurrent.atomic.AtomicReferenceArray._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.atomic.AtomicReferenceArray._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "length", "()I", ref global::java.util.concurrent.atomic.AtomicReferenceArray._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void set(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "set", "(ILjava/lang/Object;)V", ref global::java.util.concurrent.atomic.AtomicReferenceArray._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void lazySet(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "lazySet", "(ILjava/lang/Object;)V", ref global::java.util.concurrent.atomic.AtomicReferenceArray._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.Object getAndSet(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "getAndSet", "(ILjava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.atomic.AtomicReferenceArray._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool compareAndSet(int arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "compareAndSet", "(ILjava/lang/Object;Ljava/lang/Object;)Z", ref global::java.util.concurrent.atomic.AtomicReferenceArray._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool weakCompareAndSet(int arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "weakCompareAndSet", "(ILjava/lang/Object;Ljava/lang/Object;)Z", ref global::java.util.concurrent.atomic.AtomicReferenceArray._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public AtomicReferenceArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReferenceArray._m8.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReferenceArray._m8 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicReferenceArray.staticClass, global::java.util.concurrent.atomic.AtomicReferenceArray._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public AtomicReferenceArray(java.lang.Object[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReferenceArray._m9.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReferenceArray._m9 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "<init>", "([Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicReferenceArray.staticClass, global::java.util.concurrent.atomic.AtomicReferenceArray._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AtomicReferenceArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicReferenceArray"));
		}
	}
}
