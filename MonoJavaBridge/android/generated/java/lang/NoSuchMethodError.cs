namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchMethodError : java.lang.IncompatibleClassChangeError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoSuchMethodError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NoSuchMethodError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NoSuchMethodError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.NoSuchMethodError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchMethodError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchMethodError.staticClass, global::java.lang.NoSuchMethodError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public NoSuchMethodError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NoSuchMethodError._m1.native == global::System.IntPtr.Zero)
				global::java.lang.NoSuchMethodError._m1 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchMethodError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchMethodError.staticClass, global::java.lang.NoSuchMethodError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NoSuchMethodError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NoSuchMethodError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NoSuchMethodError"));
		}
	}
}
