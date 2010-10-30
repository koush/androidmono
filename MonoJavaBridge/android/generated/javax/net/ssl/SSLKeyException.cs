namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLKeyException : javax.net.ssl.SSLException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLKeyException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SSLKeyException29991;
		public SSLKeyException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLKeyException._SSLKeyException29991.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLKeyException._SSLKeyException29991 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLKeyException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLKeyException.staticClass, global::javax.net.ssl.SSLKeyException._SSLKeyException29991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SSLKeyException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLKeyException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLKeyException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
