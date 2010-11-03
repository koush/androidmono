namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FormatterClosedException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FormatterClosedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public FormatterClosedException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.FormatterClosedException._m0.native == global::System.IntPtr.Zero)
				global::java.util.FormatterClosedException._m0 = @__env.GetMethodIDNoThrow(global::java.util.FormatterClosedException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.FormatterClosedException.staticClass, global::java.util.FormatterClosedException._m0);
			Init(@__env, handle);
		}
		static FormatterClosedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.FormatterClosedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/FormatterClosedException"));
		}
	}
}
