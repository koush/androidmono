namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ThreadLocal : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ThreadLocal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object get()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ThreadLocal.staticClass, "get", "()Ljava/lang/Object;", ref global::java.lang.ThreadLocal._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadLocal.staticClass, "remove", "()V", ref global::java.lang.ThreadLocal._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void set(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadLocal.staticClass, "set", "(Ljava/lang/Object;)V", ref global::java.lang.ThreadLocal._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual global::java.lang.Object initialValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ThreadLocal.staticClass, "initialValue", "()Ljava/lang/Object;", ref global::java.lang.ThreadLocal._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ThreadLocal() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadLocal._m4.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadLocal._m4 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadLocal.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ThreadLocal.staticClass, global::java.lang.ThreadLocal._m4);
			Init(@__env, handle);
		}
		static ThreadLocal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ThreadLocal.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ThreadLocal"));
		}
	}
}
