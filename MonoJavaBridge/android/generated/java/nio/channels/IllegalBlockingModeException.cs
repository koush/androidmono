namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalBlockingModeException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalBlockingModeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public IllegalBlockingModeException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.IllegalBlockingModeException._m0.native == global::System.IntPtr.Zero)
				global::java.nio.channels.IllegalBlockingModeException._m0 = @__env.GetMethodIDNoThrow(global::java.nio.channels.IllegalBlockingModeException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.IllegalBlockingModeException.staticClass, global::java.nio.channels.IllegalBlockingModeException._m0);
			Init(@__env, handle);
		}
		static IllegalBlockingModeException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.IllegalBlockingModeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/IllegalBlockingModeException"));
		}
	}
}
