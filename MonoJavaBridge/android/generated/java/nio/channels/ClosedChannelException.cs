namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClosedChannelException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClosedChannelException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ClosedChannelException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.ClosedChannelException._m0.native == global::System.IntPtr.Zero)
				global::java.nio.channels.ClosedChannelException._m0 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ClosedChannelException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.ClosedChannelException.staticClass, global::java.nio.channels.ClosedChannelException._m0);
			Init(@__env, handle);
		}
		static ClosedChannelException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ClosedChannelException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ClosedChannelException"));
		}
	}
}
