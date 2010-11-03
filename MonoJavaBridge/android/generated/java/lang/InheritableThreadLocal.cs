namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InheritableThreadLocal : java.lang.ThreadLocal
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InheritableThreadLocal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual global::java.lang.Object childValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.InheritableThreadLocal.staticClass, "childValue", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.lang.InheritableThreadLocal._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public InheritableThreadLocal() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.InheritableThreadLocal._m1.native == global::System.IntPtr.Zero)
				global::java.lang.InheritableThreadLocal._m1 = @__env.GetMethodIDNoThrow(global::java.lang.InheritableThreadLocal.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InheritableThreadLocal.staticClass, global::java.lang.InheritableThreadLocal._m1);
			Init(@__env, handle);
		}
		static InheritableThreadLocal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.InheritableThreadLocal.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/InheritableThreadLocal"));
		}
	}
}
