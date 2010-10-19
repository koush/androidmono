namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicStampedReference : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicStampedReference()
		{
			InitJNI();
		}
		protected AtomicStampedReference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21731;
		public virtual global::java.lang.Object get(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicStampedReference._get21731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, global::java.util.concurrent.atomic.AtomicStampedReference._get21731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set21732;
		public virtual void set(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicStampedReference._set21732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, global::java.util.concurrent.atomic.AtomicStampedReference._set21732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet21733;
		public virtual bool compareAndSet(java.lang.Object arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicStampedReference._compareAndSet21733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, global::java.util.concurrent.atomic.AtomicStampedReference._compareAndSet21733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet21734;
		public virtual bool weakCompareAndSet(java.lang.Object arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicStampedReference._weakCompareAndSet21734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, global::java.util.concurrent.atomic.AtomicStampedReference._weakCompareAndSet21734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::java.lang.Object Reference
		{
			get
			{
				return getReference();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReference21735;
		public virtual global::java.lang.Object getReference() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicStampedReference._getReference21735)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, global::java.util.concurrent.atomic.AtomicStampedReference._getReference21735)) as java.lang.Object;
		}
		public new int Stamp
		{
			get
			{
				return getStamp();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStamp21736;
		public virtual int getStamp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicStampedReference._getStamp21736);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, global::java.util.concurrent.atomic.AtomicStampedReference._getStamp21736);
		}
		internal static global::MonoJavaBridge.MethodId _attemptStamp21737;
		public virtual bool attemptStamp(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicStampedReference._attemptStamp21737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, global::java.util.concurrent.atomic.AtomicStampedReference._attemptStamp21737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicStampedReference21738;
		public AtomicStampedReference(java.lang.Object arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicStampedReference.staticClass, global::java.util.concurrent.atomic.AtomicStampedReference._AtomicStampedReference21738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicStampedReference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicStampedReference"));
			global::java.util.concurrent.atomic.AtomicStampedReference._get21731 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "get", "([I)Ljava/lang/Object;");
			global::java.util.concurrent.atomic.AtomicStampedReference._set21732 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "set", "(Ljava/lang/Object;I)V");
			global::java.util.concurrent.atomic.AtomicStampedReference._compareAndSet21733 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;II)Z");
			global::java.util.concurrent.atomic.AtomicStampedReference._weakCompareAndSet21734 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;II)Z");
			global::java.util.concurrent.atomic.AtomicStampedReference._getReference21735 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "getReference", "()Ljava/lang/Object;");
			global::java.util.concurrent.atomic.AtomicStampedReference._getStamp21736 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "getStamp", "()I");
			global::java.util.concurrent.atomic.AtomicStampedReference._attemptStamp21737 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "attemptStamp", "(Ljava/lang/Object;I)Z");
			global::java.util.concurrent.atomic.AtomicStampedReference._AtomicStampedReference21738 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicStampedReference.staticClass, "<init>", "(Ljava/lang/Object;I)V");
		}
	}
}
