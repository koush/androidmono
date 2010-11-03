namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalAccessError : java.lang.IncompatibleClassChangeError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalAccessError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public IllegalAccessError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalAccessError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalAccessError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalAccessError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalAccessError.staticClass, global::java.lang.IllegalAccessError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public IllegalAccessError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalAccessError._m1.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalAccessError._m1 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalAccessError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalAccessError.staticClass, global::java.lang.IllegalAccessError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IllegalAccessError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IllegalAccessError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IllegalAccessError"));
		}
	}
}
