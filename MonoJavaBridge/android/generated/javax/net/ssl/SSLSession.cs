namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.net.ssl.SSLSession_))]
	public partial interface SSLSession  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object getValue(java.lang.String arg0);
		byte[] getId();
		global::java.lang.String getProtocol();
		void putValue(java.lang.String arg0, java.lang.Object arg1);
		bool isValid();
		void invalidate();
		global::java.lang.String getCipherSuite();
		global::java.security.Principal getPeerPrincipal();
		global::java.security.Principal getLocalPrincipal();
		global::java.security.cert.Certificate[] getLocalCertificates();
		global::java.security.cert.Certificate[] getPeerCertificates();
		global::javax.security.cert.X509Certificate[] getPeerCertificateChain();
		global::javax.net.ssl.SSLSessionContext getSessionContext();
		long getCreationTime();
		long getLastAccessedTime();
		void removeValue(java.lang.String arg0);
		global::java.lang.String[] getValueNames();
		global::java.lang.String getPeerHost();
		int getPeerPort();
		int getPacketBufferSize();
		int getApplicationBufferSize();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLSession))]
	internal sealed partial class SSLSession_ : java.lang.Object, SSLSession
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SSLSession_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object javax.net.ssl.SSLSession.getValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.net.ssl.SSLSession_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		byte[] javax.net.ssl.SSLSession.getId()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.net.ssl.SSLSession_.staticClass, "getId", "()[B", ref global::javax.net.ssl.SSLSession_._m1) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String javax.net.ssl.SSLSession.getProtocol()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLSession_.staticClass, "getProtocol", "()Ljava/lang/String;", ref global::javax.net.ssl.SSLSession_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void javax.net.ssl.SSLSession.putValue(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "putValue", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.net.ssl.SSLSession_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool javax.net.ssl.SSLSession.isValid()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "isValid", "()Z", ref global::javax.net.ssl.SSLSession_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void javax.net.ssl.SSLSession.invalidate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "invalidate", "()V", ref global::javax.net.ssl.SSLSession_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::java.lang.String javax.net.ssl.SSLSession.getCipherSuite()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLSession_.staticClass, "getCipherSuite", "()Ljava/lang/String;", ref global::javax.net.ssl.SSLSession_._m6) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.security.Principal javax.net.ssl.SSLSession.getPeerPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::javax.net.ssl.SSLSession_.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;", ref global::javax.net.ssl.SSLSession_._m7) as java.security.Principal;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.security.Principal javax.net.ssl.SSLSession.getLocalPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::javax.net.ssl.SSLSession_.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;", ref global::javax.net.ssl.SSLSession_._m8) as java.security.Principal;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.security.cert.Certificate[] javax.net.ssl.SSLSession.getLocalCertificates()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::javax.net.ssl.SSLSession_.staticClass, "getLocalCertificates", "()[Ljava/security/cert/Certificate;", ref global::javax.net.ssl.SSLSession_._m9) as java.security.cert.Certificate[];
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.security.cert.Certificate[] javax.net.ssl.SSLSession.getPeerCertificates()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::javax.net.ssl.SSLSession_.staticClass, "getPeerCertificates", "()[Ljava/security/cert/Certificate;", ref global::javax.net.ssl.SSLSession_._m10) as java.security.cert.Certificate[];
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::javax.security.cert.X509Certificate[] javax.net.ssl.SSLSession.getPeerCertificateChain()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<javax.security.cert.X509Certificate>(this, global::javax.net.ssl.SSLSession_.staticClass, "getPeerCertificateChain", "()[Ljavax/security/cert/X509Certificate;", ref global::javax.net.ssl.SSLSession_._m11) as javax.security.cert.X509Certificate[];
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::javax.net.ssl.SSLSessionContext javax.net.ssl.SSLSession.getSessionContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSessionContext>(this, global::javax.net.ssl.SSLSession_.staticClass, "getSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", ref global::javax.net.ssl.SSLSession_._m12) as javax.net.ssl.SSLSessionContext;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		long javax.net.ssl.SSLSession.getCreationTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "getCreationTime", "()J", ref global::javax.net.ssl.SSLSession_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		long javax.net.ssl.SSLSession.getLastAccessedTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "getLastAccessedTime", "()J", ref global::javax.net.ssl.SSLSession_._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void javax.net.ssl.SSLSession.removeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "removeValue", "(Ljava/lang/String;)V", ref global::javax.net.ssl.SSLSession_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		global::java.lang.String[] javax.net.ssl.SSLSession.getValueNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLSession_.staticClass, "getValueNames", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLSession_._m16) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m17;
		global::java.lang.String javax.net.ssl.SSLSession.getPeerHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLSession_.staticClass, "getPeerHost", "()Ljava/lang/String;", ref global::javax.net.ssl.SSLSession_._m17) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		int javax.net.ssl.SSLSession.getPeerPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "getPeerPort", "()I", ref global::javax.net.ssl.SSLSession_._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		int javax.net.ssl.SSLSession.getPacketBufferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "getPacketBufferSize", "()I", ref global::javax.net.ssl.SSLSession_._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		int javax.net.ssl.SSLSession.getApplicationBufferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "getApplicationBufferSize", "()I", ref global::javax.net.ssl.SSLSession_._m20);
		}
		static SSLSession_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSession_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSession"));
		}
		internal static void InitJNI()
		{
		}
	}
}
