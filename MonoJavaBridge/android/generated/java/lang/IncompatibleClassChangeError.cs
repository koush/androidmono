namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IncompatibleClassChangeError : java.lang.LinkageError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IncompatibleClassChangeError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public IncompatibleClassChangeError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IncompatibleClassChangeError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.IncompatibleClassChangeError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.IncompatibleClassChangeError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IncompatibleClassChangeError.staticClass, global::java.lang.IncompatibleClassChangeError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public IncompatibleClassChangeError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IncompatibleClassChangeError._m1.native == global::System.IntPtr.Zero)
				global::java.lang.IncompatibleClassChangeError._m1 = @__env.GetMethodIDNoThrow(global::java.lang.IncompatibleClassChangeError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IncompatibleClassChangeError.staticClass, global::java.lang.IncompatibleClassChangeError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IncompatibleClassChangeError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IncompatibleClassChangeError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IncompatibleClassChangeError"));
		}
	}
}
