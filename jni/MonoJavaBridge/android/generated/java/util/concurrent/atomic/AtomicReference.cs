namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicReference : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicReference()
		{
			InitJNI();
		}
		protected AtomicReference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21699;
		public virtual global::java.lang.Object get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference._get21699)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._get21699)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _toString21700;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference._toString21700)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._toString21700)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set21701;
		public virtual void set(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference._set21701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._set21701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet21702;
		public virtual void lazySet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference._lazySet21702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._lazySet21702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet21703;
		public virtual global::java.lang.Object getAndSet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference._getAndSet21703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._getAndSet21703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet21704;
		public virtual bool compareAndSet(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference._compareAndSet21704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._compareAndSet21704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet21705;
		public virtual bool weakCompareAndSet(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference._weakCompareAndSet21705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._weakCompareAndSet21705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicReference21706;
		public AtomicReference(java.lang.Object arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._AtomicReference21706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicReference21707;
		public AtomicReference()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._AtomicReference21707);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicReference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicReference"));
			global::java.util.concurrent.atomic.AtomicReference._get21699 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "get", "()Ljava/lang/Object;");
			global::java.util.concurrent.atomic.AtomicReference._toString21700 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicReference._set21701 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "set", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.atomic.AtomicReference._lazySet21702 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "lazySet", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.atomic.AtomicReference._getAndSet21703 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "getAndSet", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.atomic.AtomicReference._compareAndSet21704 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.concurrent.atomic.AtomicReference._weakCompareAndSet21705 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.concurrent.atomic.AtomicReference._AtomicReference21706 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.atomic.AtomicReference._AtomicReference21707 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "<init>", "()V");
		}
	}
}
