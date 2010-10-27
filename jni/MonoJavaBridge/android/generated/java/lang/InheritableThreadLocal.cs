namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InheritableThreadLocal : java.lang.ThreadLocal
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InheritableThreadLocal()
		{
			InitJNI();
		}
		protected InheritableThreadLocal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _childValue20189;
		protected virtual global::java.lang.Object childValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.InheritableThreadLocal._childValue20189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.InheritableThreadLocal.staticClass, global::java.lang.InheritableThreadLocal._childValue20189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _InheritableThreadLocal20190;
		public InheritableThreadLocal() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InheritableThreadLocal.staticClass, global::java.lang.InheritableThreadLocal._InheritableThreadLocal20190);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.InheritableThreadLocal.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/InheritableThreadLocal"));
			global::java.lang.InheritableThreadLocal._childValue20189 = @__env.GetMethodIDNoThrow(global::java.lang.InheritableThreadLocal.staticClass, "childValue", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.lang.InheritableThreadLocal._InheritableThreadLocal20190 = @__env.GetMethodIDNoThrow(global::java.lang.InheritableThreadLocal.staticClass, "<init>", "()V");
		}
	}
}
