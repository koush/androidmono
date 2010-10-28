namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ThreadLocal : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ThreadLocal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get20901;
		public virtual global::java.lang.Object get()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ThreadLocal._get20901)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ThreadLocal.staticClass, global::java.lang.ThreadLocal._get20901)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove20902;
		public virtual void remove()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadLocal._remove20902);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadLocal.staticClass, global::java.lang.ThreadLocal._remove20902);
		}
		internal static global::MonoJavaBridge.MethodId _set20903;
		public virtual void set(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadLocal._set20903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadLocal.staticClass, global::java.lang.ThreadLocal._set20903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initialValue20904;
		protected virtual global::java.lang.Object initialValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ThreadLocal._initialValue20904)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ThreadLocal.staticClass, global::java.lang.ThreadLocal._initialValue20904)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _ThreadLocal20905;
		public ThreadLocal() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ThreadLocal.staticClass, global::java.lang.ThreadLocal._ThreadLocal20905);
			Init(@__env, handle);
		}
		static ThreadLocal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ThreadLocal.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ThreadLocal"));
			global::java.lang.ThreadLocal._get20901 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadLocal.staticClass, "get", "()Ljava/lang/Object;");
			global::java.lang.ThreadLocal._remove20902 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadLocal.staticClass, "remove", "()V");
			global::java.lang.ThreadLocal._set20903 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadLocal.staticClass, "set", "(Ljava/lang/Object;)V");
			global::java.lang.ThreadLocal._initialValue20904 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadLocal.staticClass, "initialValue", "()Ljava/lang/Object;");
			global::java.lang.ThreadLocal._ThreadLocal20905 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadLocal.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
