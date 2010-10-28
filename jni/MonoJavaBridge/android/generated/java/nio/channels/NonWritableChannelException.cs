namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NonWritableChannelException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NonWritableChannelException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NonWritableChannelException22516;
		public NonWritableChannelException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.NonWritableChannelException.staticClass, global::java.nio.channels.NonWritableChannelException._NonWritableChannelException22516);
			Init(@__env, handle);
		}
		static NonWritableChannelException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.NonWritableChannelException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/NonWritableChannelException"));
			global::java.nio.channels.NonWritableChannelException._NonWritableChannelException22516 = @__env.GetMethodIDNoThrow(global::java.nio.channels.NonWritableChannelException.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
