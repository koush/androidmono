namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketTimeoutException : java.io.InterruptedIOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SocketTimeoutException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public SocketTimeoutException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.SocketTimeoutException._m0.native == global::System.IntPtr.Zero)
				global::java.net.SocketTimeoutException._m0 = @__env.GetMethodIDNoThrow(global::java.net.SocketTimeoutException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketTimeoutException.staticClass, global::java.net.SocketTimeoutException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public SocketTimeoutException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.SocketTimeoutException._m1.native == global::System.IntPtr.Zero)
				global::java.net.SocketTimeoutException._m1 = @__env.GetMethodIDNoThrow(global::java.net.SocketTimeoutException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketTimeoutException.staticClass, global::java.net.SocketTimeoutException._m1);
			Init(@__env, handle);
		}
		static SocketTimeoutException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketTimeoutException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketTimeoutException"));
		}
	}
}
