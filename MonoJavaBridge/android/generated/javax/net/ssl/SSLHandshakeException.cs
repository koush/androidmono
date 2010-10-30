namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLHandshakeException : javax.net.ssl.SSLException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLHandshakeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SSLHandshakeException29990;
		public SSLHandshakeException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLHandshakeException._SSLHandshakeException29990.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLHandshakeException._SSLHandshakeException29990 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLHandshakeException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLHandshakeException.staticClass, global::javax.net.ssl.SSLHandshakeException._SSLHandshakeException29990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SSLHandshakeException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLHandshakeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLHandshakeException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
