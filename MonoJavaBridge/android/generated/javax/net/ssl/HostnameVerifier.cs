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
		internal static global::MonoJavaBridge.MethodId _verify29841;
		bool javax.net.ssl.HostnameVerifier.verify(java.lang.String arg0, javax.net.ssl.SSLSession arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.HostnameVerifier_._verify29841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static HostnameVerifier_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.HostnameVerifier_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/HostnameVerifier"));
			global::javax.net.ssl.HostnameVerifier_._verify29841 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HostnameVerifier_.staticClass, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
