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
		internal static global::MonoJavaBridge.MethodId _get27404;
		public virtual bool get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean._get27404);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._get27404);
		}
		internal static global::MonoJavaBridge.MethodId _toString27405;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean._toString27405)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._toString27405)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set27406;
		public virtual void set(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean._set27406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._set27406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27407;
		public virtual void lazySet(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean._lazySet27407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._lazySet27407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet27408;
		public virtual bool getAndSet(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean._getAndSet27408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._getAndSet27408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27409;
		public virtual bool compareAndSet(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean._compareAndSet27409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._compareAndSet27409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27410;
		public virtual bool weakCompareAndSet(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean._weakCompareAndSet27410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._weakCompareAndSet27410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicBoolean27411;
		public AtomicBoolean(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._AtomicBoolean27411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicBoolean27412;
		public AtomicBoolean()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicBoolean.staticClass, global::java.util.concurrent.atomic.AtomicBoolean._AtomicBoolean27412);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicBoolean.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicBoolean"));
			global::java.util.concurrent.atomic.AtomicBoolean._get27404 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "get", "()Z");
			global::java.util.concurrent.atomic.AtomicBoolean._toString27405 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicBoolean._set27406 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "set", "(Z)V");
			global::java.util.concurrent.atomic.AtomicBoolean._lazySet27407 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "lazySet", "(Z)V");
			global::java.util.concurrent.atomic.AtomicBoolean._getAndSet27408 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "getAndSet", "(Z)Z");
			global::java.util.concurrent.atomic.AtomicBoolean._compareAndSet27409 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "compareAndSet", "(ZZ)Z");
			global::java.util.concurrent.atomic.AtomicBoolean._weakCompareAndSet27410 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "weakCompareAndSet", "(ZZ)Z");
			global::java.util.concurrent.atomic.AtomicBoolean._AtomicBoolean27411 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "<init>", "(Z)V");
			global::java.util.concurrent.atomic.AtomicBoolean._AtomicBoolean27412 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicBoolean.staticClass, "<init>", "()V");
		}
	}
}
