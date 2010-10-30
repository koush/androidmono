namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnresolvedAddressException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnresolvedAddressException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnresolvedAddressException22655;
		public UnresolvedAddressException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.UnresolvedAddressException._UnresolvedAddressException22655.native == global::System.IntPtr.Zero)
				global::java.nio.channels.UnresolvedAddressException._UnresolvedAddressException22655 = @__env.GetMethodIDNoThrow(global::java.nio.channels.UnresolvedAddressException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.UnresolvedAddressException.staticClass, global::java.nio.channels.UnresolvedAddressException._UnresolvedAddressException22655);
			Init(@__env, handle);
		}
		static UnresolvedAddressException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.UnresolvedAddressException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/UnresolvedAddressException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
