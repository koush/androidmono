namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoConnectionPendingException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoConnectionPendingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoConnectionPendingException22514;
		public NoConnectionPendingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.NoConnectionPendingException._NoConnectionPendingException22514.native == global::System.IntPtr.Zero)
				global::java.nio.channels.NoConnectionPendingException._NoConnectionPendingException22514 = @__env.GetMethodIDNoThrow(global::java.nio.channels.NoConnectionPendingException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.NoConnectionPendingException.staticClass, global::java.nio.channels.NoConnectionPendingException._NoConnectionPendingException22514);
			Init(@__env, handle);
		}
		static NoConnectionPendingException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.NoConnectionPendingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/NoConnectionPendingException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
