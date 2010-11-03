namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsatisfiedLinkError : java.lang.LinkageError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnsatisfiedLinkError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public UnsatisfiedLinkError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.UnsatisfiedLinkError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.UnsatisfiedLinkError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.UnsatisfiedLinkError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsatisfiedLinkError.staticClass, global::java.lang.UnsatisfiedLinkError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public UnsatisfiedLinkError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.UnsatisfiedLinkError._m1.native == global::System.IntPtr.Zero)
				global::java.lang.UnsatisfiedLinkError._m1 = @__env.GetMethodIDNoThrow(global::java.lang.UnsatisfiedLinkError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnsatisfiedLinkError.staticClass, global::java.lang.UnsatisfiedLinkError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnsatisfiedLinkError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.UnsatisfiedLinkError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/UnsatisfiedLinkError"));
		}
	}
}
