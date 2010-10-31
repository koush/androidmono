namespace java.lang.@ref
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.@ref.Reference_))]
	public abstract partial class Reference : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Reference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object get()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.@ref.Reference.staticClass, "get", "()Ljava/lang/Object;", ref global::java.lang.@ref.Reference._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.@ref.Reference.staticClass, "clear", "()V", ref global::java.lang.@ref.Reference._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool isEnqueued()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.@ref.Reference.staticClass, "isEnqueued", "()Z", ref global::java.lang.@ref.Reference._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool enqueue()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.@ref.Reference.staticClass, "enqueue", "()Z", ref global::java.lang.@ref.Reference._m3);
		}
		static Reference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.@ref.Reference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ref/Reference"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.@ref.Reference))]
	internal sealed partial class Reference_ : java.lang.@ref.Reference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Reference_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static Reference_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.@ref.Reference_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ref/Reference"));
		}
	}
}
