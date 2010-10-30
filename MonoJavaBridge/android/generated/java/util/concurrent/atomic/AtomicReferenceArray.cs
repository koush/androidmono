namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicReferenceArray : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicReferenceArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27657;
		public virtual global::java.lang.Object get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "get", "(I)Ljava/lang/Object;", ref global::java.util.concurrent.atomic.AtomicReferenceArray._get27657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _toString27658;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.atomic.AtomicReferenceArray._toString27658) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length27659;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "length", "()I", ref global::java.util.concurrent.atomic.AtomicReferenceArray._length27659);
		}
		internal static global::MonoJavaBridge.MethodId _set27660;
		public virtual void set(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "set", "(ILjava/lang/Object;)V", ref global::java.util.concurrent.atomic.AtomicReferenceArray._set27660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27661;
		public virtual void lazySet(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "lazySet", "(ILjava/lang/Object;)V", ref global::java.util.concurrent.atomic.AtomicReferenceArray._lazySet27661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet27662;
		public virtual global::java.lang.Object getAndSet(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "getAndSet", "(ILjava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.atomic.AtomicReferenceArray._getAndSet27662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27663;
		public virtual bool compareAndSet(int arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "compareAndSet", "(ILjava/lang/Object;Ljava/lang/Object;)Z", ref global::java.util.concurrent.atomic.AtomicReferenceArray._compareAndSet27663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27664;
		public virtual bool weakCompareAndSet(int arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "weakCompareAndSet", "(ILjava/lang/Object;Ljava/lang/Object;)Z", ref global::java.util.concurrent.atomic.AtomicReferenceArray._weakCompareAndSet27664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicReferenceArray27665;
		public AtomicReferenceArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReferenceArray._AtomicReferenceArray27665.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReferenceArray._AtomicReferenceArray27665 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicReferenceArray.staticClass, global::java.util.concurrent.atomic.AtomicReferenceArray._AtomicReferenceArray27665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicReferenceArray27666;
		public AtomicReferenceArray(java.lang.Object[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicReferenceArray._AtomicReferenceArray27666.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicReferenceArray._AtomicReferenceArray27666 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "<init>", "([Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicReferenceArray.staticClass, global::java.util.concurrent.atomic.AtomicReferenceArray._AtomicReferenceArray27666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AtomicReferenceArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicReferenceArray"));
		}
		internal static void InitJNI()
		{
		}
	}
}
