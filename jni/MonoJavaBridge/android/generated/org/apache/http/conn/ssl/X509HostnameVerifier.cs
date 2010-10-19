namespace org.apache.http.conn.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.ssl.X509HostnameVerifier_))]
	public interface X509HostnameVerifier : javax.net.ssl.HostnameVerifier
	{
		bool verify(java.lang.String arg0, javax.net.ssl.SSLSession arg1);
		void verify(java.lang.String arg0, javax.net.ssl.SSLSocket arg1);
		void verify(java.lang.String arg0, java.security.cert.X509Certificate arg1);
		void verify(java.lang.String arg0, java.lang.String[] arg1, java.lang.String[] arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.ssl.X509HostnameVerifier))]
	public sealed partial class X509HostnameVerifier_ : java.lang.Object, X509HostnameVerifier
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509HostnameVerifier_()
		{
			InitJNI();
		}
		internal X509HostnameVerifier_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _verify25639;
		 bool org.apache.http.conn.ssl.X509HostnameVerifier.verify(java.lang.String arg0, javax.net.ssl.SSLSession arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify25639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass, global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify25639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _verify25640;
		 void org.apache.http.conn.ssl.X509HostnameVerifier.verify(java.lang.String arg0, javax.net.ssl.SSLSocket arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify25640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass, global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify25640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _verify25641;
		 void org.apache.http.conn.ssl.X509HostnameVerifier.verify(java.lang.String arg0, java.security.cert.X509Certificate arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify25641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass, global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify25641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _verify25642;
		 void org.apache.http.conn.ssl.X509HostnameVerifier.verify(java.lang.String arg0, java.lang.String[] arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify25642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass, global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify25642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _verify25643;
		 bool javax.net.ssl.HostnameVerifier.verify(java.lang.String arg0, javax.net.ssl.SSLSession arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify25643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass, global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify25643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ssl/X509HostnameVerifier"));
			global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify25639 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z");
			global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify25640 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSocket;)V");
			global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify25641 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass, "verify", "(Ljava/lang/String;Ljava/security/cert/X509Certificate;)V");
			global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify25642 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass, "verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V");
			global::org.apache.http.conn.ssl.X509HostnameVerifier_._verify25643 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.X509HostnameVerifier_.staticClass, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z");
		}
	}
}
