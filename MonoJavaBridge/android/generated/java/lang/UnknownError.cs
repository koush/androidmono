namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnknownError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnknownError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public UnknownError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.UnknownError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.UnknownError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.UnknownError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnknownError.staticClass, global::java.lang.UnknownError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public UnknownError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.UnknownError._m1.native == global::System.IntPtr.Zero)
				global::java.lang.UnknownError._m1 = @__env.GetMethodIDNoThrow(global::java.lang.UnknownError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.UnknownError.staticClass, global::java.lang.UnknownError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnknownError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.UnknownError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/UnknownError"));
		}
	}
}
