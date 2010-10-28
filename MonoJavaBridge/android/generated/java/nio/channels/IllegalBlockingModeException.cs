namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalBlockingModeException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalBlockingModeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IllegalBlockingModeException22508;
		public IllegalBlockingModeException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.IllegalBlockingModeException.staticClass, global::java.nio.channels.IllegalBlockingModeException._IllegalBlockingModeException22508);
			Init(@__env, handle);
		}
		static IllegalBlockingModeException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.IllegalBlockingModeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/IllegalBlockingModeException"));
			global::java.nio.channels.IllegalBlockingModeException._IllegalBlockingModeException22508 = @__env.GetMethodIDNoThrow(global::java.nio.channels.IllegalBlockingModeException.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
