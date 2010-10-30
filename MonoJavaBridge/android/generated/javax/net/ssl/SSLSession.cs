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
		internal static global::MonoJavaBridge.MethodId _getValue30037;
		global::java.lang.Object javax.net.ssl.SSLSession.getValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.net.ssl.SSLSession_._getValue30037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getId30038;
		byte[] javax.net.ssl.SSLSession.getId()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.net.ssl.SSLSession_.staticClass, "getId", "()[B", ref global::javax.net.ssl.SSLSession_._getId30038) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getProtocol30039;
		global::java.lang.String javax.net.ssl.SSLSession.getProtocol()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLSession_.staticClass, "getProtocol", "()Ljava/lang/String;", ref global::javax.net.ssl.SSLSession_._getProtocol30039) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _putValue30040;
		void javax.net.ssl.SSLSession.putValue(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "putValue", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.net.ssl.SSLSession_._putValue30040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isValid30041;
		bool javax.net.ssl.SSLSession.isValid()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "isValid", "()Z", ref global::javax.net.ssl.SSLSession_._isValid30041);
		}
		internal static global::MonoJavaBridge.MethodId _invalidate30042;
		void javax.net.ssl.SSLSession.invalidate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "invalidate", "()V", ref global::javax.net.ssl.SSLSession_._invalidate30042);
		}
		internal static global::MonoJavaBridge.MethodId _getCipherSuite30043;
		global::java.lang.String javax.net.ssl.SSLSession.getCipherSuite()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLSession_.staticClass, "getCipherSuite", "()Ljava/lang/String;", ref global::javax.net.ssl.SSLSession_._getCipherSuite30043) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPeerPrincipal30044;
		global::java.security.Principal javax.net.ssl.SSLSession.getPeerPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::javax.net.ssl.SSLSession_.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;", ref global::javax.net.ssl.SSLSession_._getPeerPrincipal30044) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPrincipal30045;
		global::java.security.Principal javax.net.ssl.SSLSession.getLocalPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::javax.net.ssl.SSLSession_.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;", ref global::javax.net.ssl.SSLSession_._getLocalPrincipal30045) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalCertificates30046;
		global::java.security.cert.Certificate[] javax.net.ssl.SSLSession.getLocalCertificates()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::javax.net.ssl.SSLSession_.staticClass, "getLocalCertificates", "()[Ljava/security/cert/Certificate;", ref global::javax.net.ssl.SSLSession_._getLocalCertificates30046) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getPeerCertificates30047;
		global::java.security.cert.Certificate[] javax.net.ssl.SSLSession.getPeerCertificates()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::javax.net.ssl.SSLSession_.staticClass, "getPeerCertificates", "()[Ljava/security/cert/Certificate;", ref global::javax.net.ssl.SSLSession_._getPeerCertificates30047) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getPeerCertificateChain30048;
		global::javax.security.cert.X509Certificate[] javax.net.ssl.SSLSession.getPeerCertificateChain()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<javax.security.cert.X509Certificate>(this, global::javax.net.ssl.SSLSession_.staticClass, "getPeerCertificateChain", "()[Ljavax/security/cert/X509Certificate;", ref global::javax.net.ssl.SSLSession_._getPeerCertificateChain30048) as javax.security.cert.X509Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getSessionContext30049;
		global::javax.net.ssl.SSLSessionContext javax.net.ssl.SSLSession.getSessionContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSessionContext>(this, global::javax.net.ssl.SSLSession_.staticClass, "getSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", ref global::javax.net.ssl.SSLSession_._getSessionContext30049) as javax.net.ssl.SSLSessionContext;
		}
		internal static global::MonoJavaBridge.MethodId _getCreationTime30050;
		long javax.net.ssl.SSLSession.getCreationTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "getCreationTime", "()J", ref global::javax.net.ssl.SSLSession_._getCreationTime30050);
		}
		internal static global::MonoJavaBridge.MethodId _getLastAccessedTime30051;
		long javax.net.ssl.SSLSession.getLastAccessedTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "getLastAccessedTime", "()J", ref global::javax.net.ssl.SSLSession_._getLastAccessedTime30051);
		}
		internal static global::MonoJavaBridge.MethodId _removeValue30052;
		void javax.net.ssl.SSLSession.removeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "removeValue", "(Ljava/lang/String;)V", ref global::javax.net.ssl.SSLSession_._removeValue30052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getValueNames30053;
		global::java.lang.String[] javax.net.ssl.SSLSession.getValueNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLSession_.staticClass, "getValueNames", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLSession_._getValueNames30053) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getPeerHost30054;
		global::java.lang.String javax.net.ssl.SSLSession.getPeerHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLSession_.staticClass, "getPeerHost", "()Ljava/lang/String;", ref global::javax.net.ssl.SSLSession_._getPeerHost30054) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPeerPort30055;
		int javax.net.ssl.SSLSession.getPeerPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "getPeerPort", "()I", ref global::javax.net.ssl.SSLSession_._getPeerPort30055);
		}
		internal static global::MonoJavaBridge.MethodId _getPacketBufferSize30056;
		int javax.net.ssl.SSLSession.getPacketBufferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "getPacketBufferSize", "()I", ref global::javax.net.ssl.SSLSession_._getPacketBufferSize30056);
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationBufferSize30057;
		int javax.net.ssl.SSLSession.getApplicationBufferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.net.ssl.SSLSession_.staticClass, "getApplicationBufferSize", "()I", ref global::javax.net.ssl.SSLSession_._getApplicationBufferSize30057);
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
