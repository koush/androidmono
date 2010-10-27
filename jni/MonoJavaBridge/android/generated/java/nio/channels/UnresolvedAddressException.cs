namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnresolvedAddressException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnresolvedAddressException()
		{
			InitJNI();
		}
		protected UnresolvedAddressException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnresolvedAddressException22654;
		public UnresolvedAddressException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.UnresolvedAddressException.staticClass, global::java.nio.channels.UnresolvedAddressException._UnresolvedAddressException22654);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.UnresolvedAddressException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/UnresolvedAddressException"));
			global::java.nio.channels.UnresolvedAddressException._UnresolvedAddressException22654 = @__env.GetMethodIDNoThrow(global::java.nio.channels.UnresolvedAddressException.staticClass, "<init>", "()V");
		}
	}
}
