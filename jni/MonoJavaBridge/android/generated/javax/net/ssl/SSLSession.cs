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
		static SSLSession_()
		{
			InitJNI();
		}
		internal SSLSession_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getValue30037;
		global::java.lang.Object javax.net.ssl.SSLSession.getValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getValue30037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getValue30037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getId30038;
		byte[] javax.net.ssl.SSLSession.getId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getId30038)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getId30038)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getProtocol30039;
		global::java.lang.String javax.net.ssl.SSLSession.getProtocol()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getProtocol30039)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getProtocol30039)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _putValue30040;
		void javax.net.ssl.SSLSession.putValue(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._putValue30040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._putValue30040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isValid30041;
		bool javax.net.ssl.SSLSession.isValid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._isValid30041);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._isValid30041);
		}
		internal static global::MonoJavaBridge.MethodId _invalidate30042;
		void javax.net.ssl.SSLSession.invalidate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._invalidate30042);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._invalidate30042);
		}
		internal static global::MonoJavaBridge.MethodId _getCipherSuite30043;
		global::java.lang.String javax.net.ssl.SSLSession.getCipherSuite()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getCipherSuite30043)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getCipherSuite30043)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPeerPrincipal30044;
		global::java.security.Principal javax.net.ssl.SSLSession.getPeerPrincipal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getPeerPrincipal30044)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getPeerPrincipal30044)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPrincipal30045;
		global::java.security.Principal javax.net.ssl.SSLSession.getLocalPrincipal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getLocalPrincipal30045)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getLocalPrincipal30045)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalCertificates30046;
		global::java.security.cert.Certificate[] javax.net.ssl.SSLSession.getLocalCertificates()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getLocalCertificates30046)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getLocalCertificates30046)) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getPeerCertificates30047;
		global::java.security.cert.Certificate[] javax.net.ssl.SSLSession.getPeerCertificates()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getPeerCertificates30047)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getPeerCertificates30047)) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getPeerCertificateChain30048;
		global::javax.security.cert.X509Certificate[] javax.net.ssl.SSLSession.getPeerCertificateChain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.security.cert.X509Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getPeerCertificateChain30048)) as javax.security.cert.X509Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.security.cert.X509Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getPeerCertificateChain30048)) as javax.security.cert.X509Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getSessionContext30049;
		global::javax.net.ssl.SSLSessionContext javax.net.ssl.SSLSession.getSessionContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSessionContext>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getSessionContext30049)) as javax.net.ssl.SSLSessionContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSessionContext>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getSessionContext30049)) as javax.net.ssl.SSLSessionContext;
		}
		internal static global::MonoJavaBridge.MethodId _getCreationTime30050;
		long javax.net.ssl.SSLSession.getCreationTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getCreationTime30050);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getCreationTime30050);
		}
		internal static global::MonoJavaBridge.MethodId _getLastAccessedTime30051;
		long javax.net.ssl.SSLSession.getLastAccessedTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getLastAccessedTime30051);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getLastAccessedTime30051);
		}
		internal static global::MonoJavaBridge.MethodId _removeValue30052;
		void javax.net.ssl.SSLSession.removeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._removeValue30052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._removeValue30052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getValueNames30053;
		global::java.lang.String[] javax.net.ssl.SSLSession.getValueNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getValueNames30053)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getValueNames30053)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getPeerHost30054;
		global::java.lang.String javax.net.ssl.SSLSession.getPeerHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getPeerHost30054)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getPeerHost30054)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPeerPort30055;
		int javax.net.ssl.SSLSession.getPeerPort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getPeerPort30055);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getPeerPort30055);
		}
		internal static global::MonoJavaBridge.MethodId _getPacketBufferSize30056;
		int javax.net.ssl.SSLSession.getPacketBufferSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getPacketBufferSize30056);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getPacketBufferSize30056);
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationBufferSize30057;
		int javax.net.ssl.SSLSession.getApplicationBufferSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_._getApplicationBufferSize30057);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLSession_.staticClass, global::javax.net.ssl.SSLSession_._getApplicationBufferSize30057);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSession_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSession"));
			global::javax.net.ssl.SSLSession_._getValue30037 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.net.ssl.SSLSession_._getId30038 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getId", "()[B");
			global::javax.net.ssl.SSLSession_._getProtocol30039 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getProtocol", "()Ljava/lang/String;");
			global::javax.net.ssl.SSLSession_._putValue30040 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "putValue", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.net.ssl.SSLSession_._isValid30041 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "isValid", "()Z");
			global::javax.net.ssl.SSLSession_._invalidate30042 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "invalidate", "()V");
			global::javax.net.ssl.SSLSession_._getCipherSuite30043 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getCipherSuite", "()Ljava/lang/String;");
			global::javax.net.ssl.SSLSession_._getPeerPrincipal30044 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;");
			global::javax.net.ssl.SSLSession_._getLocalPrincipal30045 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;");
			global::javax.net.ssl.SSLSession_._getLocalCertificates30046 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getLocalCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.SSLSession_._getPeerCertificates30047 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getPeerCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.SSLSession_._getPeerCertificateChain30048 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getPeerCertificateChain", "()[Ljavax/security/cert/X509Certificate;");
			global::javax.net.ssl.SSLSession_._getSessionContext30049 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getSessionContext", "()Ljavax/net/ssl/SSLSessionContext;");
			global::javax.net.ssl.SSLSession_._getCreationTime30050 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getCreationTime", "()J");
			global::javax.net.ssl.SSLSession_._getLastAccessedTime30051 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getLastAccessedTime", "()J");
			global::javax.net.ssl.SSLSession_._removeValue30052 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "removeValue", "(Ljava/lang/String;)V");
			global::javax.net.ssl.SSLSession_._getValueNames30053 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getValueNames", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSession_._getPeerHost30054 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getPeerHost", "()Ljava/lang/String;");
			global::javax.net.ssl.SSLSession_._getPeerPort30055 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getPeerPort", "()I");
			global::javax.net.ssl.SSLSession_._getPacketBufferSize30056 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getPacketBufferSize", "()I");
			global::javax.net.ssl.SSLSession_._getApplicationBufferSize30057 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSession_.staticClass, "getApplicationBufferSize", "()I");
		}
	}
}
