namespace org.apache.http.conn.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.ssl.X509HostnameVerifier_))]
	public partial interface X509HostnameVerifier : javax.net.ssl.HostnameVerifier
	{
		bool verify(java.lang.String arg0, javax.net.ssl.SSLSession arg1);
		void verify(java.lang.String arg0, javax.net.ssl.SSLSocket arg1);
		void verify(java.lang.String arg0, java.security.cert.X509Certificate arg1);
		void verify(java.lang.String arg0, java.lang.String[] arg1, java.lang.String[] arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.ssl.X509HostnameVerifier))]
	internal sealed partial class X509HostnameVerifier_ : java.lang.Object, X509HostnameVerifier
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal X509HostnameVerifier_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _verify32359;
		bool org.apache.http.conn.ssl.X509HostnameVerifier.verify(java.lang.String arg0, javax.net.ssl.SSLSession arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify32359.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify32359 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify32359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _verify32360;
		void org.apache.http.conn.ssl.X509HostnameVerifier.verify(java.lang.String arg0, javax.net.ssl.SSLSocket arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify32360.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify32360 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSocket;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify32360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _verify32361;
		void org.apache.http.conn.ssl.X509HostnameVerifier.verify(java.lang.String arg0, java.security.cert.X509Certificate arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify32361.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify32361 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass, "verify", "(Ljava/lang/String;Ljava/security/cert/X509Certificate;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify32361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _verify32362;
		void org.apache.http.conn.ssl.X509HostnameVerifier.verify(java.lang.String arg0, java.lang.String[] arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify32362.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify32362 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass, "verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify32362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _verify32363;
		bool javax.net.ssl.HostnameVerifier.verify(java.lang.String arg0, javax.net.ssl.SSLSession arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify32363.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify32363 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify32363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static X509HostnameVerifier_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ssl/X509HostnameVerifier"));
		}
		internal static void InitJNI()
		{
		}
	}
}
