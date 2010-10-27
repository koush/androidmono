namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnectionPendingException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConnectionPendingException()
		{
			InitJNI();
		}
		protected ConnectionPendingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ConnectionPendingException22419;
		public ConnectionPendingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.ConnectionPendingException.staticClass, global::java.nio.channels.ConnectionPendingException._ConnectionPendingException22419);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ConnectionPendingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ConnectionPendingException"));
			global::java.nio.channels.ConnectionPendingException._ConnectionPendingException22419 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ConnectionPendingException.staticClass, "<init>", "()V");
		}
	}
}
