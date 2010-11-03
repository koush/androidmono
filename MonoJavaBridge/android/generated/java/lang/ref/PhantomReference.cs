namespace java.lang.@ref
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PhantomReference : java.lang.@ref.Reference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PhantomReference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object get()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.@ref.PhantomReference.staticClass, "get", "()Ljava/lang/Object;", ref global::java.lang.@ref.PhantomReference._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public PhantomReference(java.lang.Object arg0, java.lang.@ref.ReferenceQueue arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.@ref.PhantomReference._m1.native == global::System.IntPtr.Zero)
				global::java.lang.@ref.PhantomReference._m1 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.PhantomReference.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/ref/ReferenceQueue;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.@ref.PhantomReference.staticClass, global::java.lang.@ref.PhantomReference._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static PhantomReference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.@ref.PhantomReference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ref/PhantomReference"));
		}
	}
}
