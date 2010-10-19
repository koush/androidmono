namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlreadyConnectedException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AlreadyConnectedException()
		{
			InitJNI();
		}
		protected AlreadyConnectedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AlreadyConnectedException16685;
		public AlreadyConnectedException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.AlreadyConnectedException.staticClass, global::java.nio.channels.AlreadyConnectedException._AlreadyConnectedException16685);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.AlreadyConnectedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/AlreadyConnectedException"));
			global::java.nio.channels.AlreadyConnectedException._AlreadyConnectedException16685 = @__env.GetMethodIDNoThrow(global::java.nio.channels.AlreadyConnectedException.staticClass, "<init>", "()V");
		}
	}
}
