namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnectionPendingException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConnectionPendingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ConnectionPendingException22420;
		public ConnectionPendingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.ConnectionPendingException._ConnectionPendingException22420.native == global::System.IntPtr.Zero)
				global::java.nio.channels.ConnectionPendingException._ConnectionPendingException22420 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ConnectionPendingException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.ConnectionPendingException.staticClass, global::java.nio.channels.ConnectionPendingException._ConnectionPendingException22420);
			Init(@__env, handle);
		}
		static ConnectionPendingException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ConnectionPendingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ConnectionPendingException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
