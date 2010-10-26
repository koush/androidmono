namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NotYetBoundException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NotYetBoundException()
		{
			InitJNI();
		}
		protected NotYetBoundException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NotYetBoundException22516;
		public NotYetBoundException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.NotYetBoundException.staticClass, global::java.nio.channels.NotYetBoundException._NotYetBoundException22516);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.NotYetBoundException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/NotYetBoundException"));
			global::java.nio.channels.NotYetBoundException._NotYetBoundException22516 = @__env.GetMethodIDNoThrow(global::java.nio.channels.NotYetBoundException.staticClass, "<init>", "()V");
		}
	}
}
