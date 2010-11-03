namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InternalError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InternalError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public InternalError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.InternalError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.InternalError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.InternalError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InternalError.staticClass, global::java.lang.InternalError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public InternalError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.InternalError._m1.native == global::System.IntPtr.Zero)
				global::java.lang.InternalError._m1 = @__env.GetMethodIDNoThrow(global::java.lang.InternalError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.InternalError.staticClass, global::java.lang.InternalError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InternalError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.InternalError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/InternalError"));
		}
	}
}
