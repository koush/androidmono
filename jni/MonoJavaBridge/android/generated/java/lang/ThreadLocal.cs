namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ThreadLocal : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ThreadLocal()
		{
			InitJNI();
		}
		protected ThreadLocal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get15260;
		public virtual global::java.lang.Object get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ThreadLocal._get15260)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ThreadLocal.staticClass, global::java.lang.ThreadLocal._get15260)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove15261;
		public virtual void remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadLocal._remove15261);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadLocal.staticClass, global::java.lang.ThreadLocal._remove15261);
		}
		internal static global::MonoJavaBridge.MethodId _set15262;
		public virtual void set(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadLocal._set15262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadLocal.staticClass, global::java.lang.ThreadLocal._set15262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initialValue15263;
		protected virtual global::java.lang.Object initialValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ThreadLocal._initialValue15263)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ThreadLocal.staticClass, global::java.lang.ThreadLocal._initialValue15263)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _ThreadLocal15264;
		public ThreadLocal()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ThreadLocal.staticClass, global::java.lang.ThreadLocal._ThreadLocal15264);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ThreadLocal.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ThreadLocal"));
			global::java.lang.ThreadLocal._get15260 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadLocal.staticClass, "get", "()Ljava/lang/Object;");
			global::java.lang.ThreadLocal._remove15261 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadLocal.staticClass, "remove", "()V");
			global::java.lang.ThreadLocal._set15262 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadLocal.staticClass, "set", "(Ljava/lang/Object;)V");
			global::java.lang.ThreadLocal._initialValue15263 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadLocal.staticClass, "initialValue", "()Ljava/lang/Object;");
			global::java.lang.ThreadLocal._ThreadLocal15264 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadLocal.staticClass, "<init>", "()V");
		}
	}
}
