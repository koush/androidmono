namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OutOfMemoryError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OutOfMemoryError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public OutOfMemoryError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.OutOfMemoryError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.OutOfMemoryError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.OutOfMemoryError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.OutOfMemoryError.staticClass, global::java.lang.OutOfMemoryError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public OutOfMemoryError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.OutOfMemoryError._m1.native == global::System.IntPtr.Zero)
				global::java.lang.OutOfMemoryError._m1 = @__env.GetMethodIDNoThrow(global::java.lang.OutOfMemoryError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.OutOfMemoryError.staticClass, global::java.lang.OutOfMemoryError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static OutOfMemoryError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.OutOfMemoryError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/OutOfMemoryError"));
		}
	}
}
