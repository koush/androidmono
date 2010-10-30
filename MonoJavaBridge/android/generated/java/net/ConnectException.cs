namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnectException : java.net.SocketException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConnectException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ConnectException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ConnectException._m0.native == global::System.IntPtr.Zero)
				global::java.net.ConnectException._m0 = @__env.GetMethodIDNoThrow(global::java.net.ConnectException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ConnectException.staticClass, global::java.net.ConnectException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ConnectException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ConnectException._m1.native == global::System.IntPtr.Zero)
				global::java.net.ConnectException._m1 = @__env.GetMethodIDNoThrow(global::java.net.ConnectException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ConnectException.staticClass, global::java.net.ConnectException._m1);
			Init(@__env, handle);
		}
		static ConnectException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ConnectException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ConnectException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
