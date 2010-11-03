namespace java.nio
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferOverflowException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BufferOverflowException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public BufferOverflowException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.BufferOverflowException._m0.native == global::System.IntPtr.Zero)
				global::java.nio.BufferOverflowException._m0 = @__env.GetMethodIDNoThrow(global::java.nio.BufferOverflowException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.BufferOverflowException.staticClass, global::java.nio.BufferOverflowException._m0);
			Init(@__env, handle);
		}
		static BufferOverflowException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.BufferOverflowException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/BufferOverflowException"));
		}
	}
}
