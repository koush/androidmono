namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StackOverflowError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StackOverflowError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public StackOverflowError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.StackOverflowError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.StackOverflowError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.StackOverflowError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StackOverflowError.staticClass, global::java.lang.StackOverflowError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public StackOverflowError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.StackOverflowError._m1.native == global::System.IntPtr.Zero)
				global::java.lang.StackOverflowError._m1 = @__env.GetMethodIDNoThrow(global::java.lang.StackOverflowError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StackOverflowError.staticClass, global::java.lang.StackOverflowError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StackOverflowError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StackOverflowError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StackOverflowError"));
		}
	}
}
