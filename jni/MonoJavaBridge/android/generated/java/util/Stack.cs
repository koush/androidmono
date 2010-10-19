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
		internal static global::MonoJavaBridge.MethodId _push20872;
		public virtual global::java.lang.Object push(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Stack._push20872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Stack.staticClass, global::java.util.Stack._push20872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _pop20873;
		public virtual global::java.lang.Object pop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Stack._pop20873)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Stack.staticClass, global::java.util.Stack._pop20873)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek20874;
		public virtual global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Stack._peek20874)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Stack.staticClass, global::java.util.Stack._peek20874)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _empty20875;
		public virtual bool empty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Stack._empty20875);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Stack.staticClass, global::java.util.Stack._empty20875);
		}
		internal static global::MonoJavaBridge.MethodId _search20876;
		public virtual int search(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Stack._search20876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Stack.staticClass, global::java.util.Stack._search20876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Stack20877;
		public Stack()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Stack.staticClass, global::java.util.Stack._Stack20877);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Stack.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Stack"));
			global::java.util.Stack._push20872 = @__env.GetMethodIDNoThrow(global::java.util.Stack.staticClass, "push", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Stack._pop20873 = @__env.GetMethodIDNoThrow(global::java.util.Stack.staticClass, "pop", "()Ljava/lang/Object;");
			global::java.util.Stack._peek20874 = @__env.GetMethodIDNoThrow(global::java.util.Stack.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.Stack._empty20875 = @__env.GetMethodIDNoThrow(global::java.util.Stack.staticClass, "empty", "()Z");
			global::java.util.Stack._search20876 = @__env.GetMethodIDNoThrow(global::java.util.Stack.staticClass, "search", "(Ljava/lang/Object;)I");
			global::java.util.Stack._Stack20877 = @__env.GetMethodIDNoThrow(global::java.util.Stack.staticClass, "<init>", "()V");
		}
	}
}
