namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.HttpsURLConnection_))]
	public abstract partial class HttpsURLConnection : java.net.HttpURLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpsURLConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setHostnameVerifier29842;
		public virtual void setHostnameVerifier(javax.net.ssl.HostnameVerifier arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._setHostnameVerifier29842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._setHostnameVerifier29842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHostnameVerifier29843;
		public virtual global::javax.net.ssl.HostnameVerifier getHostnameVerifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.HostnameVerifier>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._getHostnameVerifier29843)) as javax.net.ssl.HostnameVerifier;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.HostnameVerifier>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getHostnameVerifier29843)) as javax.net.ssl.HostnameVerifier;
		}
		internal static global::MonoJavaBridge.MethodId _getCipherSuite29844;
		public abstract global::java.lang.String getCipherSuite();
		internal static global::MonoJavaBridge.MethodId _getPeerPrincipal29845;
		public virtual global::java.security.Principal getPeerPrincipal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._getPeerPrincipal29845)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getPeerPrincipal29845)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPrincipal29846;
		public virtual global::java.security.Principal getLocalPrincipal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._getLocalPrincipal29846)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getLocalPrincipal29846)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalCertificates29847;
		public abstract global::java.security.cert.Certificate[] getLocalCertificates();
		internal static global::MonoJavaBridge.MethodId _getServerCertificates29848;
		public abstract global::java.security.cert.Certificate[] getServerCertificates();
		internal static global::MonoJavaBridge.MethodId _setDefaultHostnameVerifier29849;
		public static void setDefaultHostnameVerifier(javax.net.ssl.HostnameVerifier arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._setDefaultHostnameVerifier29849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultHostnameVerifier29850;
		public static global::javax.net.ssl.HostnameVerifier getDefaultHostnameVerifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.HostnameVerifier>(@__env.CallStaticObjectMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getDefaultHostnameVerifier29850)) as javax.net.ssl.HostnameVerifier;
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultSSLSocketFactory29851;
		public static void setDefaultSSLSocketFactory(javax.net.ssl.SSLSocketFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._setDefaultSSLSocketFactory29851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultSSLSocketFactory29852;
		public static global::javax.net.ssl.SSLSocketFactory getDefaultSSLSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getDefaultSSLSocketFactory29852)) as javax.net.ssl.SSLSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setSSLSocketFactory29853;
		public virtual void setSSLSocketFactory(javax.net.ssl.SSLSocketFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._setSSLSocketFactory29853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._setSSLSocketFactory29853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSSLSocketFactory29854;
		public virtual global::javax.net.ssl.SSLSocketFactory getSSLSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._getSSLSocketFactory29854)) as javax.net.ssl.SSLSocketFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getSSLSocketFactory29854)) as javax.net.ssl.SSLSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _HttpsURLConnection29855;
		protected HttpsURLConnection(java.net.URL arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._HttpsURLConnection29855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static HttpsURLConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.HttpsURLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/HttpsURLConnection"));
			global::javax.net.ssl.HttpsURLConnection._setHostnameVerifier29842 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V");
			global::javax.net.ssl.HttpsURLConnection._getHostnameVerifier29843 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;");
			global::javax.net.ssl.HttpsURLConnection._getCipherSuite29844 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getCipherSuite", "()Ljava/lang/String;");
			global::javax.net.ssl.HttpsURLConnection._getPeerPrincipal29845 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;");
			global::javax.net.ssl.HttpsURLConnection._getLocalPrincipal29846 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;");
			global::javax.net.ssl.HttpsURLConnection._getLocalCertificates29847 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getLocalCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HttpsURLConnection._getServerCertificates29848 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getServerCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HttpsURLConnection._setDefaultHostnameVerifier29849 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "setDefaultHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V");
			global::javax.net.ssl.HttpsURLConnection._getDefaultHostnameVerifier29850 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getDefaultHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;");
			global::javax.net.ssl.HttpsURLConnection._setDefaultSSLSocketFactory29851 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "setDefaultSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V");
			global::javax.net.ssl.HttpsURLConnection._getDefaultSSLSocketFactory29852 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getDefaultSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
			global::javax.net.ssl.HttpsURLConnection._setSSLSocketFactory29853 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "setSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V");
			global::javax.net.ssl.HttpsURLConnection._getSSLSocketFactory29854 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
			global::javax.net.ssl.HttpsURLConnection._HttpsURLConnection29855 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.HttpsURLConnection))]
	internal sealed partial class HttpsURLConnection_ : javax.net.ssl.HttpsURLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpsURLConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCipherSuite29856;
		public override global::java.lang.String getCipherSuite()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._getCipherSuite29856)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._getCipherSuite29856)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalCertificates29857;
		public override global::java.security.cert.Certificate[] getLocalCertificates()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._getLocalCertificates29857)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._getLocalCertificates29857)) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getServerCertificates29858;
		public override global::java.security.cert.Certificate[] getServerCertificates()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._getServerCertificates29858)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._getServerCertificates29858)) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _disconnect29859;
		public override void disconnect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._disconnect29859);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._disconnect29859);
		}
		internal static global::MonoJavaBridge.MethodId _usingProxy29860;
		public override bool usingProxy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._usingProxy29860);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._usingProxy29860);
		}
		internal static global::MonoJavaBridge.MethodId _connect29861;
		public override void connect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._connect29861);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._connect29861);
		}
		static HttpsURLConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.HttpsURLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/HttpsURLConnection"));
			global::javax.net.ssl.HttpsURLConnection_._getCipherSuite29856 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "getCipherSuite", "()Ljava/lang/String;");
			global::javax.net.ssl.HttpsURLConnection_._getLocalCertificates29857 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "getLocalCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HttpsURLConnection_._getServerCertificates29858 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "getServerCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HttpsURLConnection_._disconnect29859 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "disconnect", "()V");
			global::javax.net.ssl.HttpsURLConnection_._usingProxy29860 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "usingProxy", "()Z");
			global::javax.net.ssl.HttpsURLConnection_._connect29861 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "connect", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
