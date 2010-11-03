namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Stack : java.util.Vector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Stack(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object push(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Stack.staticClass, "push", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Stack._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object pop()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Stack.staticClass, "pop", "()Ljava/lang/Object;", ref global::java.util.Stack._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.Object peek()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Stack.staticClass, "peek", "()Ljava/lang/Object;", ref global::java.util.Stack._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool empty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Stack.staticClass, "empty", "()Z", ref global::java.util.Stack._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int search(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Stack.staticClass, "search", "(Ljava/lang/Object;)I", ref global::java.util.Stack._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public Stack() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Stack._m5.native == global::System.IntPtr.Zero)
				global::java.util.Stack._m5 = @__env.GetMethodIDNoThrow(global::java.util.Stack.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Stack.staticClass, global::java.util.Stack._m5);
			Init(@__env, handle);
		}
		static Stack()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Stack.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Stack"));
		}
	}
}
