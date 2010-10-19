namespace java.lang.@ref
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SoftReference : java.lang.@ref.Reference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SoftReference()
		{
			InitJNI();
		}
		protected SoftReference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get15353;
		public override global::java.lang.Object get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.@ref.SoftReference._get15353)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.@ref.SoftReference.staticClass, global::java.lang.@ref.SoftReference._get15353)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _SoftReference15354;
		public SoftReference(java.lang.Object arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.@ref.SoftReference.staticClass, global::java.lang.@ref.SoftReference._SoftReference15354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SoftReference15355;
		public SoftReference(java.lang.Object arg0, java.lang.@ref.ReferenceQueue arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.@ref.SoftReference.staticClass, global::java.lang.@ref.SoftReference._SoftReference15355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.@ref.SoftReference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/@ref/SoftReference"));
			global::java.lang.@ref.SoftReference._get15353 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.SoftReference.staticClass, "get", "()Ljava/lang/Object;");
			global::java.lang.@ref.SoftReference._SoftReference15354 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.SoftReference.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::java.lang.@ref.SoftReference._SoftReference15355 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.SoftReference.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/@ref/ReferenceQueue;)V");
		}
	}
}
