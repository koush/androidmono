namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SocketException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public SocketException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.SocketException._m0.native == global::System.IntPtr.Zero)
				global::java.net.SocketException._m0 = @__env.GetMethodIDNoThrow(global::java.net.SocketException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketException.staticClass, global::java.net.SocketException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public SocketException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.SocketException._m1.native == global::System.IntPtr.Zero)
				global::java.net.SocketException._m1 = @__env.GetMethodIDNoThrow(global::java.net.SocketException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketException.staticClass, global::java.net.SocketException._m1);
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
