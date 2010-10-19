namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalBlockingModeException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IllegalBlockingModeException()
		{
			InitJNI();
		}
		protected IllegalBlockingModeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IllegalBlockingModeException16795;
		public IllegalBlockingModeException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.IllegalBlockingModeException.staticClass, global::java.nio.channels.IllegalBlockingModeException._IllegalBlockingModeException16795);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.IllegalBlockingModeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/IllegalBlockingModeException"));
			global::java.nio.channels.IllegalBlockingModeException._IllegalBlockingModeException16795 = @__env.GetMethodIDNoThrow(global::java.nio.channels.IllegalBlockingModeException.staticClass, "<init>", "()V");
		}
	}
}
