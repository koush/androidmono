namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NonReadableChannelException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NonReadableChannelException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NonReadableChannelException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.NonReadableChannelException._m0.native == global::System.IntPtr.Zero)
				global::java.nio.channels.NonReadableChannelException._m0 = @__env.GetMethodIDNoThrow(global::java.nio.channels.NonReadableChannelException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.NonReadableChannelException.staticClass, global::java.nio.channels.NonReadableChannelException._m0);
			Init(@__env, handle);
		}
		static NonReadableChannelException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.NonReadableChannelException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/NonReadableChannelException"));
		}
	}
}
