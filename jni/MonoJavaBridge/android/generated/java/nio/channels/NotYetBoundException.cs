namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NotYetBoundException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NotYetBoundException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NotYetBoundException22517;
		public NotYetBoundException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.NotYetBoundException.staticClass, global::java.nio.channels.NotYetBoundException._NotYetBoundException22517);
			Init(@__env, handle);
		}
		static NotYetBoundException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.NotYetBoundException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/NotYetBoundException"));
			global::java.nio.channels.NotYetBoundException._NotYetBoundException22517 = @__env.GetMethodIDNoThrow(global::java.nio.channels.NotYetBoundException.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
