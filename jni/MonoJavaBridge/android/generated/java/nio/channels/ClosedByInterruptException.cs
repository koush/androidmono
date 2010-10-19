namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClosedByInterruptException : java.nio.channels.AsynchronousCloseException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClosedByInterruptException()
		{
			InitJNI();
		}
		protected ClosedByInterruptException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ClosedByInterruptException16704;
		public ClosedByInterruptException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.ClosedByInterruptException.staticClass, global::java.nio.channels.ClosedByInterruptException._ClosedByInterruptException16704);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ClosedByInterruptException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ClosedByInterruptException"));
			global::java.nio.channels.ClosedByInterruptException._ClosedByInterruptException16704 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ClosedByInterruptException.staticClass, "<init>", "()V");
		}
	}
}
