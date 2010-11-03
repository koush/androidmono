namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalAccessException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalAccessException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public IllegalAccessException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalAccessException._m0.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalAccessException._m0 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalAccessException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalAccessException.staticClass, global::java.lang.IllegalAccessException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public IllegalAccessException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IllegalAccessException._m1.native == global::System.IntPtr.Zero)
				global::java.lang.IllegalAccessException._m1 = @__env.GetMethodIDNoThrow(global::java.lang.IllegalAccessException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IllegalAccessException.staticClass, global::java.lang.IllegalAccessException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IllegalAccessException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IllegalAccessException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IllegalAccessException"));
		}
	}
}
