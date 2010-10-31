namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.net.ssl.HostnameVerifier_))]
	public partial interface HostnameVerifier  : global::MonoJavaBridge.IJavaObject 
	{
		bool verify(java.lang.String arg0, javax.net.ssl.SSLSession arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.HostnameVerifier))]
	internal sealed partial class HostnameVerifier_ : java.lang.Object, HostnameVerifier
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HostnameVerifier_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool javax.net.ssl.HostnameVerifier.verify(java.lang.String arg0, javax.net.ssl.SSLSession arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.HostnameVerifier_.staticClass, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z", ref global::javax.net.ssl.HostnameVerifier_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static HostnameVerifier_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.HostnameVerifier_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/HostnameVerifier"));
		}
	}
}
