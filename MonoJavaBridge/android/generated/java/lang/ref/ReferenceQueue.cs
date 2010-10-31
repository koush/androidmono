namespace java.lang.@ref
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ReferenceQueue : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ReferenceQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.@ref.Reference remove(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.@ref.ReferenceQueue.staticClass, "remove", "(J)Ljava/lang/ref/Reference;", ref global::java.lang.@ref.ReferenceQueue._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.@ref.Reference;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.@ref.Reference remove()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.@ref.ReferenceQueue.staticClass, "remove", "()Ljava/lang/ref/Reference;", ref global::java.lang.@ref.ReferenceQueue._m1) as java.lang.@ref.Reference;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.@ref.Reference poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.@ref.ReferenceQueue.staticClass, "poll", "()Ljava/lang/ref/Reference;", ref global::java.lang.@ref.ReferenceQueue._m2) as java.lang.@ref.Reference;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public ReferenceQueue() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.@ref.ReferenceQueue._m3.native == global::System.IntPtr.Zero)
				global::java.lang.@ref.ReferenceQueue._m3 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.ReferenceQueue.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.@ref.ReferenceQueue.staticClass, global::java.lang.@ref.ReferenceQueue._m3);
			Init(@__env, handle);
		}
		static ReferenceQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.@ref.ReferenceQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ref/ReferenceQueue"));
		}
	}
}
