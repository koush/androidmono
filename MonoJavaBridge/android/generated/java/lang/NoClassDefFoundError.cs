namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoClassDefFoundError : java.lang.LinkageError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoClassDefFoundError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NoClassDefFoundError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NoClassDefFoundError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.NoClassDefFoundError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.NoClassDefFoundError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoClassDefFoundError.staticClass, global::java.lang.NoClassDefFoundError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public NoClassDefFoundError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NoClassDefFoundError._m1.native == global::System.IntPtr.Zero)
				global::java.lang.NoClassDefFoundError._m1 = @__env.GetMethodIDNoThrow(global::java.lang.NoClassDefFoundError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoClassDefFoundError.staticClass, global::java.lang.NoClassDefFoundError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NoClassDefFoundError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NoClassDefFoundError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NoClassDefFoundError"));
		}
	}
}
