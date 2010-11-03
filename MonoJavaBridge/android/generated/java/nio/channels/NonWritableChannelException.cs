namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NonWritableChannelException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NonWritableChannelException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NonWritableChannelException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.NonWritableChannelException._m0.native == global::System.IntPtr.Zero)
				global::java.nio.channels.NonWritableChannelException._m0 = @__env.GetMethodIDNoThrow(global::java.nio.channels.NonWritableChannelException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.NonWritableChannelException.staticClass, global::java.nio.channels.NonWritableChannelException._m0);
			Init(@__env, handle);
		}
		static NonWritableChannelException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.NonWritableChannelException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/NonWritableChannelException"));
		}
	}
}
