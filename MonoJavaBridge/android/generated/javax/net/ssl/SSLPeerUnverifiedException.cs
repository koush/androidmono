namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLPeerUnverifiedException : javax.net.ssl.SSLException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLPeerUnverifiedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public SSLPeerUnverifiedException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLPeerUnverifiedException._m0.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLPeerUnverifiedException._m0 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLPeerUnverifiedException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLPeerUnverifiedException.staticClass, global::javax.net.ssl.SSLPeerUnverifiedException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SSLPeerUnverifiedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLPeerUnverifiedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLPeerUnverifiedException"));
		}
	}
}
