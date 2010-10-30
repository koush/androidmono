namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HandshakeCompletedEvent : java.util.EventObject
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HandshakeCompletedEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String CipherSuite
		{
			get
			{
				return getCipherSuite();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCipherSuite29831;
		public virtual global::java.lang.String getCipherSuite()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getCipherSuite", "()Ljava/lang/String;", ref global::javax.net.ssl.HandshakeCompletedEvent._getCipherSuite29831) as java.lang.String;
		}
		public new global::java.security.Principal PeerPrincipal
		{
			get
			{
				return getPeerPrincipal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPeerPrincipal29832;
		public virtual global::java.security.Principal getPeerPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;", ref global::javax.net.ssl.HandshakeCompletedEvent._getPeerPrincipal29832) as java.security.Principal;
		}
		public new global::java.security.Principal LocalPrincipal
		{
			get
			{
				return getLocalPrincipal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPrincipal29833;
		public virtual global::java.security.Principal getLocalPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;", ref global::javax.net.ssl.HandshakeCompletedEvent._getLocalPrincipal29833) as java.security.Principal;
		}
		public new global::javax.net.ssl.SSLSocket Socket
		{
			get
			{
				return getSocket();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocket29834;
		public virtual global::javax.net.ssl.SSLSocket getSocket()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getSocket", "()Ljavax/net/ssl/SSLSocket;", ref global::javax.net.ssl.HandshakeCompletedEvent._getSocket29834) as javax.net.ssl.SSLSocket;
		}
		public new global::javax.net.ssl.SSLSession Session
		{
			get
			{
				return getSession();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSession29835;
		public virtual global::javax.net.ssl.SSLSession getSession()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSession>(this, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;", ref global::javax.net.ssl.HandshakeCompletedEvent._getSession29835) as javax.net.ssl.SSLSession;
		}
		public new global::java.security.cert.Certificate[] LocalCertificates
		{
			get
			{
				return getLocalCertificates();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalCertificates29836;
		public virtual global::java.security.cert.Certificate[] getLocalCertificates()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getLocalCertificates", "()[Ljava/security/cert/Certificate;", ref global::javax.net.ssl.HandshakeCompletedEvent._getLocalCertificates29836) as java.security.cert.Certificate[];
		}
		public new global::java.security.cert.Certificate[] PeerCertificates
		{
			get
			{
				return getPeerCertificates();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPeerCertificates29837;
		public virtual global::java.security.cert.Certificate[] getPeerCertificates()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getPeerCertificates", "()[Ljava/security/cert/Certificate;", ref global::javax.net.ssl.HandshakeCompletedEvent._getPeerCertificates29837) as java.security.cert.Certificate[];
		}
		public new global::javax.security.cert.X509Certificate[] PeerCertificateChain
		{
			get
			{
				return getPeerCertificateChain();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPeerCertificateChain29838;
		public virtual global::javax.security.cert.X509Certificate[] getPeerCertificateChain()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<javax.security.cert.X509Certificate>(this, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getPeerCertificateChain", "()[Ljavax/security/cert/X509Certificate;", ref global::javax.net.ssl.HandshakeCompletedEvent._getPeerCertificateChain29838) as javax.security.cert.X509Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _HandshakeCompletedEvent29839;
		public HandshakeCompletedEvent(javax.net.ssl.SSLSocket arg0, javax.net.ssl.SSLSession arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.HandshakeCompletedEvent._HandshakeCompletedEvent29839.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.HandshakeCompletedEvent._HandshakeCompletedEvent29839 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "<init>", "(Ljavax/net/ssl/SSLSocket;Ljavax/net/ssl/SSLSession;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._HandshakeCompletedEvent29839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static HandshakeCompletedEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.HandshakeCompletedEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/HandshakeCompletedEvent"));
		}
		internal static void InitJNI()
		{
		}
	}
}
