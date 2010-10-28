namespace java.nio
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferOverflowException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BufferOverflowException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _BufferOverflowException22015;
		public BufferOverflowException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.BufferOverflowException.staticClass, global::java.nio.BufferOverflowException._BufferOverflowException22015);
			Init(@__env, handle);
		}
		static BufferOverflowException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.BufferOverflowException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/BufferOverflowException"));
			global::java.nio.BufferOverflowException._BufferOverflowException22015 = @__env.GetMethodIDNoThrow(global::java.nio.BufferOverflowException.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
