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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getCipherSuite29831)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getCipherSuite29831)) as java.lang.String;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getPeerPrincipal29832)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getPeerPrincipal29832)) as java.security.Principal;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getLocalPrincipal29833)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getLocalPrincipal29833)) as java.security.Principal;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getSocket29834)) as javax.net.ssl.SSLSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getSocket29834)) as javax.net.ssl.SSLSocket;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getSession29835)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getSession29835)) as javax.net.ssl.SSLSession;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getLocalCertificates29836)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getLocalCertificates29836)) as java.security.cert.Certificate[];
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getPeerCertificates29837)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getPeerCertificates29837)) as java.security.cert.Certificate[];
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.security.cert.X509Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getPeerCertificateChain29838)) as javax.security.cert.X509Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.security.cert.X509Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getPeerCertificateChain29838)) as javax.security.cert.X509Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _HandshakeCompletedEvent29839;
		public HandshakeCompletedEvent(javax.net.ssl.SSLSocket arg0, javax.net.ssl.SSLSession arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._HandshakeCompletedEvent29839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static HandshakeCompletedEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.HandshakeCompletedEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/HandshakeCompletedEvent"));
			global::javax.net.ssl.HandshakeCompletedEvent._getCipherSuite29831 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getCipherSuite", "()Ljava/lang/String;");
			global::javax.net.ssl.HandshakeCompletedEvent._getPeerPrincipal29832 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;");
			global::javax.net.ssl.HandshakeCompletedEvent._getLocalPrincipal29833 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;");
			global::javax.net.ssl.HandshakeCompletedEvent._getSocket29834 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getSocket", "()Ljavax/net/ssl/SSLSocket;");
			global::javax.net.ssl.HandshakeCompletedEvent._getSession29835 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.HandshakeCompletedEvent._getLocalCertificates29836 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getLocalCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HandshakeCompletedEvent._getPeerCertificates29837 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getPeerCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HandshakeCompletedEvent._getPeerCertificateChain29838 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getPeerCertificateChain", "()[Ljavax/security/cert/X509Certificate;");
			global::javax.net.ssl.HandshakeCompletedEvent._HandshakeCompletedEvent29839 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "<init>", "(Ljavax/net/ssl/SSLSocket;Ljavax/net/ssl/SSLSession;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
