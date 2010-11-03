namespace java.nio
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferUnderflowException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BufferUnderflowException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public BufferUnderflowException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.BufferUnderflowException._m0.native == global::System.IntPtr.Zero)
				global::java.nio.BufferUnderflowException._m0 = @__env.GetMethodIDNoThrow(global::java.nio.BufferUnderflowException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.BufferUnderflowException.staticClass, global::java.nio.BufferUnderflowException._m0);
			Init(@__env, handle);
		}
		static BufferUnderflowException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.BufferUnderflowException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/BufferUnderflowException"));
		}
	}
}
