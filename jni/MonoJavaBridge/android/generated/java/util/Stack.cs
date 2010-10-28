namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Stack : java.util.Vector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Stack()
		{
			InitJNI();
		}
		protected Stack(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _push26819;
		public virtual global::java.lang.Object push(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Stack._push26819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Stack.staticClass, global::java.util.Stack._push26819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pop26820;
		public virtual global::java.lang.Object pop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Stack._pop26820)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Stack.staticClass, global::java.util.Stack._pop26820)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek26821;
		public virtual global::java.lang.Object peek()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Stack._peek26821)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Stack.staticClass, global::java.util.Stack._peek26821)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _empty26822;
		public virtual bool empty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Stack._empty26822);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Stack.staticClass, global::java.util.Stack._empty26822);
		}
		internal static global::MonoJavaBridge.MethodId _search26823;
		public virtual int search(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Stack._search26823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Stack.staticClass, global::java.util.Stack._search26823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Stack26824;
		public Stack() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Stack.staticClass, global::java.util.Stack._Stack26824);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Stack.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Stack"));
			global::java.util.Stack._push26819 = @__env.GetMethodIDNoThrow(global::java.util.Stack.staticClass, "push", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Stack._pop26820 = @__env.GetMethodIDNoThrow(global::java.util.Stack.staticClass, "pop", "()Ljava/lang/Object;");
			global::java.util.Stack._peek26821 = @__env.GetMethodIDNoThrow(global::java.util.Stack.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.Stack._empty26822 = @__env.GetMethodIDNoThrow(global::java.util.Stack.staticClass, "empty", "()Z");
			global::java.util.Stack._search26823 = @__env.GetMethodIDNoThrow(global::java.util.Stack.staticClass, "search", "(Ljava/lang/Object;)I");
			global::java.util.Stack._Stack26824 = @__env.GetMethodIDNoThrow(global::java.util.Stack.staticClass, "<init>", "()V");
		}
	}
}
