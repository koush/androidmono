namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLPeerUnverifiedException : javax.net.ssl.SSLException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLPeerUnverifiedException()
		{
			InitJNI();
		}
		protected SSLPeerUnverifiedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SSLPeerUnverifiedException23442;
		public SSLPeerUnverifiedException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLPeerUnverifiedException.staticClass, global::javax.net.ssl.SSLPeerUnverifiedException._SSLPeerUnverifiedException23442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLPeerUnverifiedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLPeerUnverifiedException"));
			global::javax.net.ssl.SSLPeerUnverifiedException._SSLPeerUnverifiedException23442 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLPeerUnverifiedException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
