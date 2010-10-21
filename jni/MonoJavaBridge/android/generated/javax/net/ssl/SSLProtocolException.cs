namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLProtocolException : javax.net.ssl.SSLException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLProtocolException()
		{
			InitJNI();
		}
		protected SSLProtocolException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SSLProtocolException29876;
		public SSLProtocolException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLProtocolException.staticClass, global::javax.net.ssl.SSLProtocolException._SSLProtocolException29876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLProtocolException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLProtocolException"));
			global::javax.net.ssl.SSLProtocolException._SSLProtocolException29876 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLProtocolException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
