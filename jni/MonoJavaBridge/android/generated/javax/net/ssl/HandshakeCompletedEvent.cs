namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HandshakeCompletedEvent : java.util.EventObject
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HandshakeCompletedEvent()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getCipherSuite23281;
		public virtual global::java.lang.String getCipherSuite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getCipherSuite23281)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getCipherSuite23281)) as java.lang.String;
		}
		public new global::java.security.Principal PeerPrincipal
		{
			get
			{
				return getPeerPrincipal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPeerPrincipal23282;
		public virtual global::java.security.Principal getPeerPrincipal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getPeerPrincipal23282)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getPeerPrincipal23282)) as java.security.Principal;
		}
		public new global::java.security.Principal LocalPrincipal
		{
			get
			{
				return getLocalPrincipal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPrincipal23283;
		public virtual global::java.security.Principal getLocalPrincipal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getLocalPrincipal23283)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getLocalPrincipal23283)) as java.security.Principal;
		}
		public new global::javax.net.ssl.SSLSocket Socket
		{
			get
			{
				return getSocket();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocket23284;
		public virtual global::javax.net.ssl.SSLSocket getSocket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getSocket23284)) as javax.net.ssl.SSLSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getSocket23284)) as javax.net.ssl.SSLSocket;
		}
		public new global::javax.net.ssl.SSLSession Session
		{
			get
			{
				return getSession();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSession23285;
		public virtual global::javax.net.ssl.SSLSession getSession() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getSession23285)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getSession23285)) as javax.net.ssl.SSLSession;
		}
		public new global::java.security.cert.Certificate[] LocalCertificates
		{
			get
			{
				return getLocalCertificates();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalCertificates23286;
		public virtual global::java.security.cert.Certificate[] getLocalCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getLocalCertificates23286)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getLocalCertificates23286)) as java.security.cert.Certificate[];
		}
		public new global::java.security.cert.Certificate[] PeerCertificates
		{
			get
			{
				return getPeerCertificates();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPeerCertificates23287;
		public virtual global::java.security.cert.Certificate[] getPeerCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getPeerCertificates23287)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getPeerCertificates23287)) as java.security.cert.Certificate[];
		}
		public new global::javax.security.cert.X509Certificate[] PeerCertificateChain
		{
			get
			{
				return getPeerCertificateChain();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPeerCertificateChain23288;
		public virtual global::javax.security.cert.X509Certificate[] getPeerCertificateChain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.security.cert.X509Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent._getPeerCertificateChain23288)) as javax.security.cert.X509Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.security.cert.X509Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._getPeerCertificateChain23288)) as javax.security.cert.X509Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _HandshakeCompletedEvent23289;
		public HandshakeCompletedEvent(javax.net.ssl.SSLSocket arg0, javax.net.ssl.SSLSession arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.HandshakeCompletedEvent.staticClass, global::javax.net.ssl.HandshakeCompletedEvent._HandshakeCompletedEvent23289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.HandshakeCompletedEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/HandshakeCompletedEvent"));
			global::javax.net.ssl.HandshakeCompletedEvent._getCipherSuite23281 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getCipherSuite", "()Ljava/lang/String;");
			global::javax.net.ssl.HandshakeCompletedEvent._getPeerPrincipal23282 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;");
			global::javax.net.ssl.HandshakeCompletedEvent._getLocalPrincipal23283 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;");
			global::javax.net.ssl.HandshakeCompletedEvent._getSocket23284 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getSocket", "()Ljavax/net/ssl/SSLSocket;");
			global::javax.net.ssl.HandshakeCompletedEvent._getSession23285 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.HandshakeCompletedEvent._getLocalCertificates23286 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getLocalCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HandshakeCompletedEvent._getPeerCertificates23287 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getPeerCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HandshakeCompletedEvent._getPeerCertificateChain23288 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "getPeerCertificateChain", "()[Ljavax/security/cert/X509Certificate;");
			global::javax.net.ssl.HandshakeCompletedEvent._HandshakeCompletedEvent23289 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HandshakeCompletedEvent.staticClass, "<init>", "(Ljavax/net/ssl/SSLSocket;Ljavax/net/ssl/SSLSession;)V");
		}
	}
}
