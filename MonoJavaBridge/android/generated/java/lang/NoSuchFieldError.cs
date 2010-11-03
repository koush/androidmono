namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchFieldError : java.lang.IncompatibleClassChangeError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoSuchFieldError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NoSuchFieldError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NoSuchFieldError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.NoSuchFieldError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchFieldError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchFieldError.staticClass, global::java.lang.NoSuchFieldError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public NoSuchFieldError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NoSuchFieldError._m1.native == global::System.IntPtr.Zero)
				global::java.lang.NoSuchFieldError._m1 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchFieldError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchFieldError.staticClass, global::java.lang.NoSuchFieldError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NoSuchFieldError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NoSuchFieldError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NoSuchFieldError"));
		}
	}
}
