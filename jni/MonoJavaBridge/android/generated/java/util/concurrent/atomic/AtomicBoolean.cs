namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicBoolean : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicBoolean()
		{
			InitJNI();
		}
		protected AtomicBoolean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27523;
		public virtual bool get()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean._get27523);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._get27523);
		}
		internal static global::MonoJavaBridge.MethodId _toString27524;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean._toString27524)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._toString27524)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set27525;
		public virtual void set(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean._set27525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._set27525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27526;
		public virtual void lazySet(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean._lazySet27526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._lazySet27526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet27527;
		public virtual bool getAndSet(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean._getAndSet27527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._getAndSet27527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27528;
		public virtual bool compareAndSet(bool arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean._compareAndSet27528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._compareAndSet27528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27529;
		public virtual bool weakCompareAndSet(bool arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean._weakCompareAndSet27529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._weakCompareAndSet27529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicBoolean27530;
		public AtomicBoolean(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._AtomicBoolean27530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicBoolean27531;
		public AtomicBoolean() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._AtomicBoolean27531);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicBoolean.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicBoolean"));
			global::java.util.concurrent.atomic.AtomicBoolean._get27523 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "get", "()Z");
			global::java.util.concurrent.atomic.AtomicBoolean._toString27524 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicBoolean._set27525 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "set", "(Z)V");
			global::java.util.concurrent.atomic.AtomicBoolean._lazySet27526 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "lazySet", "(Z)V");
			global::java.util.concurrent.atomic.AtomicBoolean._getAndSet27527 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "getAndSet", "(Z)Z");
			global::java.util.concurrent.atomic.AtomicBoolean._compareAndSet27528 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "compareAndSet", "(ZZ)Z");
			global::java.util.concurrent.atomic.AtomicBoolean._weakCompareAndSet27529 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "weakCompareAndSet", "(ZZ)Z");
			global::java.util.concurrent.atomic.AtomicBoolean._AtomicBoolean27530 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "<init>", "(Z)V");
			global::java.util.concurrent.atomic.AtomicBoolean._AtomicBoolean27531 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "<init>", "()V");
		}
	}
}
