namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SocketException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SocketException21774;
		public SocketException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.SocketException._SocketException21774.native == global::System.IntPtr.Zero)
				global::java.net.SocketException._SocketException21774 = @__env.GetMethodIDNoThrow(global::java.net.SocketException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketException.staticClass, global::java.net.SocketException._SocketException21774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SocketException21775;
		public SocketException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.SocketException._SocketException21775.native == global::System.IntPtr.Zero)
				global::java.net.SocketException._SocketException21775 = @__env.GetMethodIDNoThrow(global::java.net.SocketException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketException.staticClass, global::java.net.SocketException._SocketException21775);
			Init(@__env, handle);
		}
		static SocketException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
