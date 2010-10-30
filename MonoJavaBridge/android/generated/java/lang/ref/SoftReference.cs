namespace java.lang.@ref
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SoftReference : java.lang.@ref.Reference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SoftReference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get20994;
		public override global::java.lang.Object get()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.@ref.SoftReference._get20994.native == global::System.IntPtr.Zero)
				global::java.lang.@ref.SoftReference._get20994 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.SoftReference.staticClass, "get", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.@ref.SoftReference.staticClass, global::java.lang.@ref.SoftReference._get20994) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _SoftReference20995;
		public SoftReference(java.lang.Object arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.@ref.SoftReference._SoftReference20995.native == global::System.IntPtr.Zero)
				global::java.lang.@ref.SoftReference._SoftReference20995 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.SoftReference.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.@ref.SoftReference.staticClass, global::java.lang.@ref.SoftReference._SoftReference20995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SoftReference20996;
		public SoftReference(java.lang.Object arg0, java.lang.@ref.ReferenceQueue arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.@ref.SoftReference._SoftReference20996.native == global::System.IntPtr.Zero)
				global::java.lang.@ref.SoftReference._SoftReference20996 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.SoftReference.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/ref/ReferenceQueue;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.@ref.SoftReference.staticClass, global::java.lang.@ref.SoftReference._SoftReference20996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static SoftReference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.@ref.SoftReference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ref/SoftReference"));
		}
		internal static void InitJNI()
		{
		}
	}
}
