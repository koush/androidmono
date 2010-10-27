namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileLockInterruptionException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FileLockInterruptionException()
		{
			InitJNI();
		}
		protected FileLockInterruptionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _FileLockInterruptionException22500;
		public FileLockInterruptionException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.FileLockInterruptionException.staticClass, global::java.nio.channels.FileLockInterruptionException._FileLockInterruptionException22500);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.FileLockInterruptionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileLockInterruptionException"));
			global::java.nio.channels.FileLockInterruptionException._FileLockInterruptionException22500 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLockInterruptionException.staticClass, "<init>", "()V");
		}
	}
}
