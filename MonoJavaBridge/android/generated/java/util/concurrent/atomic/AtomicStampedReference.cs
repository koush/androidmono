namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicStampedReference : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicStampedReference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27680;
		public virtual global::java.lang.Object get(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "get", "([I)Ljava/lang/Object;", ref global::java.util.concurrent.atomic.AtomicStampedReference._get27680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set27681;
		public virtual void set(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "set", "(Ljava/lang/Object;I)V", ref global::java.util.concurrent.atomic.AtomicStampedReference._set27681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27682;
		public virtual bool compareAndSet(java.lang.Object arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;II)Z", ref global::java.util.concurrent.atomic.AtomicStampedReference._compareAndSet27682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27683;
		public virtual bool weakCompareAndSet(java.lang.Object arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;II)Z", ref global::java.util.concurrent.atomic.AtomicStampedReference._weakCompareAndSet27683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::java.lang.Object Reference
		{
			get
			{
				return getReference();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReference27684;
		public virtual global::java.lang.Object getReference()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "getReference", "()Ljava/lang/Object;", ref global::java.util.concurrent.atomic.AtomicStampedReference._getReference27684) as java.lang.Object;
		}
		public new int Stamp
		{
			get
			{
				return getStamp();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStamp27685;
		public virtual int getStamp()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "getStamp", "()I", ref global::java.util.concurrent.atomic.AtomicStampedReference._getStamp27685);
		}
		internal static global::MonoJavaBridge.MethodId _attemptStamp27686;
		public virtual bool attemptStamp(java.lang.Object arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "attemptStamp", "(Ljava/lang/Object;I)Z", ref global::java.util.concurrent.atomic.AtomicStampedReference._attemptStamp27686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicStampedReference27687;
		public AtomicStampedReference(java.lang.Object arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicStampedReference._AtomicStampedReference27687.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicStampedReference._AtomicStampedReference27687 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "<init>", "(Ljava/lang/Object;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicStampedReference.staticClass, global::java.util.concurrent.atomic.AtomicStampedReference._AtomicStampedReference27687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AtomicStampedReference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicStampedReference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicStampedReference"));
		}
		internal static void InitJNI()
		{
		}
	}
}
