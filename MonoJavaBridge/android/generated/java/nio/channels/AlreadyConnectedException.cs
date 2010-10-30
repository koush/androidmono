namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlreadyConnectedException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlreadyConnectedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AlreadyConnectedException22398;
		public AlreadyConnectedException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.AlreadyConnectedException._AlreadyConnectedException22398.native == global::System.IntPtr.Zero)
				global::java.nio.channels.AlreadyConnectedException._AlreadyConnectedException22398 = @__env.GetMethodIDNoThrow(global::java.nio.channels.AlreadyConnectedException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.AlreadyConnectedException.staticClass, global::java.nio.channels.AlreadyConnectedException._AlreadyConnectedException22398);
			Init(@__env, handle);
		}
		static AlreadyConnectedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.AlreadyConnectedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/AlreadyConnectedException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
