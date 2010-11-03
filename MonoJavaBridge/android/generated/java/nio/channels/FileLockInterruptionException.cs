namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileLockInterruptionException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileLockInterruptionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public FileLockInterruptionException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.FileLockInterruptionException._m0.native == global::System.IntPtr.Zero)
				global::java.nio.channels.FileLockInterruptionException._m0 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLockInterruptionException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.FileLockInterruptionException.staticClass, global::java.nio.channels.FileLockInterruptionException._m0);
			Init(@__env, handle);
		}
		static FileLockInterruptionException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.FileLockInterruptionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileLockInterruptionException"));
		}
	}
}
