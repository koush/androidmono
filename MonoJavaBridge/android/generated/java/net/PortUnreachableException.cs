namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PortUnreachableException : java.net.SocketException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PortUnreachableException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _PortUnreachableException21655;
		public PortUnreachableException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.PortUnreachableException._PortUnreachableException21655.native == global::System.IntPtr.Zero)
				global::java.net.PortUnreachableException._PortUnreachableException21655 = @__env.GetMethodIDNoThrow(global::java.net.PortUnreachableException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.PortUnreachableException.staticClass, global::java.net.PortUnreachableException._PortUnreachableException21655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PortUnreachableException21656;
		public PortUnreachableException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.PortUnreachableException._PortUnreachableException21656.native == global::System.IntPtr.Zero)
				global::java.net.PortUnreachableException._PortUnreachableException21656 = @__env.GetMethodIDNoThrow(global::java.net.PortUnreachableException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.PortUnreachableException.staticClass, global::java.net.PortUnreachableException._PortUnreachableException21656);
			Init(@__env, handle);
		}
		static PortUnreachableException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.PortUnreachableException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/PortUnreachableException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
