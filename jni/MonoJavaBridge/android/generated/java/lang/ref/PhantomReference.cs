namespace java.lang.@ref
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PhantomReference : java.lang.@ref.Reference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PhantomReference()
		{
			InitJNI();
		}
		protected PhantomReference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get15343;
		public override global::java.lang.Object get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.@ref.PhantomReference._get15343)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.@ref.PhantomReference.staticClass, global::java.lang.@ref.PhantomReference._get15343)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _PhantomReference15344;
		public PhantomReference(java.lang.Object arg0, java.lang.@ref.ReferenceQueue arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.@ref.PhantomReference.staticClass, global::java.lang.@ref.PhantomReference._PhantomReference15344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.@ref.PhantomReference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/@ref/PhantomReference"));
			global::java.lang.@ref.PhantomReference._get15343 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.PhantomReference.staticClass, "get", "()Ljava/lang/Object;");
			global::java.lang.@ref.PhantomReference._PhantomReference15344 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.PhantomReference.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/@ref/ReferenceQueue;)V");
		}
	}
}
