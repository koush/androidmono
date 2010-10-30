namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClosedByInterruptException : java.nio.channels.AsynchronousCloseException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClosedByInterruptException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ClosedByInterruptException22417;
		public ClosedByInterruptException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.ClosedByInterruptException._ClosedByInterruptException22417.native == global::System.IntPtr.Zero)
				global::java.nio.channels.ClosedByInterruptException._ClosedByInterruptException22417 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ClosedByInterruptException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.ClosedByInterruptException.staticClass, global::java.nio.channels.ClosedByInterruptException._ClosedByInterruptException22417);
			Init(@__env, handle);
		}
		static ClosedByInterruptException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ClosedByInterruptException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ClosedByInterruptException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
