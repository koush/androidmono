namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClosedChannelException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClosedChannelException()
		{
			InitJNI();
		}
		protected ClosedChannelException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ClosedChannelException22418;
		public ClosedChannelException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.ClosedChannelException.staticClass, global::java.nio.channels.ClosedChannelException._ClosedChannelException22418);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ClosedChannelException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ClosedChannelException"));
			global::java.nio.channels.ClosedChannelException._ClosedChannelException22418 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ClosedChannelException.staticClass, "<init>", "()V");
		}
	}
}
