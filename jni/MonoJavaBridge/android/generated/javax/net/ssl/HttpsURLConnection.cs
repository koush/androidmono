namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.HttpsURLConnection_))]
	public abstract partial class HttpsURLConnection : java.net.HttpURLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpsURLConnection()
		{
			InitJNI();
		}
		protected HttpsURLConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setHostnameVerifier29841;
		public virtual void setHostnameVerifier(javax.net.ssl.HostnameVerifier arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._setHostnameVerifier29841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._setHostnameVerifier29841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHostnameVerifier29842;
		public virtual global::javax.net.ssl.HostnameVerifier getHostnameVerifier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.HostnameVerifier>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._getHostnameVerifier29842)) as javax.net.ssl.HostnameVerifier;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.HostnameVerifier>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getHostnameVerifier29842)) as javax.net.ssl.HostnameVerifier;
		}
		internal static global::MonoJavaBridge.MethodId _getCipherSuite29843;
		public abstract global::java.lang.String getCipherSuite();
		internal static global::MonoJavaBridge.MethodId _getPeerPrincipal29844;
		public virtual global::java.security.Principal getPeerPrincipal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._getPeerPrincipal29844)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getPeerPrincipal29844)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPrincipal29845;
		public virtual global::java.security.Principal getLocalPrincipal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._getLocalPrincipal29845)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getLocalPrincipal29845)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalCertificates29846;
		public abstract global::java.security.cert.Certificate[] getLocalCertificates();
		internal static global::MonoJavaBridge.MethodId _getServerCertificates29847;
		public abstract global::java.security.cert.Certificate[] getServerCertificates();
		internal static global::MonoJavaBridge.MethodId _setDefaultHostnameVerifier29848;
		public static void setDefaultHostnameVerifier(javax.net.ssl.HostnameVerifier arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._setDefaultHostnameVerifier29848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultHostnameVerifier29849;
		public static global::javax.net.ssl.HostnameVerifier getDefaultHostnameVerifier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.HostnameVerifier>(@__env.CallStaticObjectMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getDefaultHostnameVerifier29849)) as javax.net.ssl.HostnameVerifier;
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultSSLSocketFactory29850;
		public static void setDefaultSSLSocketFactory(javax.net.ssl.SSLSocketFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._setDefaultSSLSocketFactory29850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultSSLSocketFactory29851;
		public static global::javax.net.ssl.SSLSocketFactory getDefaultSSLSocketFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getDefaultSSLSocketFactory29851)) as javax.net.ssl.SSLSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setSSLSocketFactory29852;
		public virtual void setSSLSocketFactory(javax.net.ssl.SSLSocketFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._setSSLSocketFactory29852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._setSSLSocketFactory29852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSSLSocketFactory29853;
		public virtual global::javax.net.ssl.SSLSocketFactory getSSLSocketFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._getSSLSocketFactory29853)) as javax.net.ssl.SSLSocketFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getSSLSocketFactory29853)) as javax.net.ssl.SSLSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _HttpsURLConnection29854;
		protected HttpsURLConnection(java.net.URL arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._HttpsURLConnection29854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.HttpsURLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/HttpsURLConnection"));
			global::javax.net.ssl.HttpsURLConnection._setHostnameVerifier29841 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V");
			global::javax.net.ssl.HttpsURLConnection._getHostnameVerifier29842 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;");
			global::javax.net.ssl.HttpsURLConnection._getCipherSuite29843 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getCipherSuite", "()Ljava/lang/String;");
			global::javax.net.ssl.HttpsURLConnection._getPeerPrincipal29844 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;");
			global::javax.net.ssl.HttpsURLConnection._getLocalPrincipal29845 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;");
			global::javax.net.ssl.HttpsURLConnection._getLocalCertificates29846 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getLocalCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HttpsURLConnection._getServerCertificates29847 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getServerCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HttpsURLConnection._setDefaultHostnameVerifier29848 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "setDefaultHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V");
			global::javax.net.ssl.HttpsURLConnection._getDefaultHostnameVerifier29849 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getDefaultHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;");
			global::javax.net.ssl.HttpsURLConnection._setDefaultSSLSocketFactory29850 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "setDefaultSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V");
			global::javax.net.ssl.HttpsURLConnection._getDefaultSSLSocketFactory29851 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getDefaultSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
			global::javax.net.ssl.HttpsURLConnection._setSSLSocketFactory29852 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "setSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V");
			global::javax.net.ssl.HttpsURLConnection._getSSLSocketFactory29853 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
			global::javax.net.ssl.HttpsURLConnection._HttpsURLConnection29854 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.HttpsURLConnection))]
	internal sealed partial class HttpsURLConnection_ : javax.net.ssl.HttpsURLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpsURLConnection_()
		{
			InitJNI();
		}
		internal HttpsURLConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCipherSuite29855;
		public override global::java.lang.String getCipherSuite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._getCipherSuite29855)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._getCipherSuite29855)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalCertificates29856;
		public override global::java.security.cert.Certificate[] getLocalCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._getLocalCertificates29856)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._getLocalCertificates29856)) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getServerCertificates29857;
		public override global::java.security.cert.Certificate[] getServerCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._getServerCertificates29857)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._getServerCertificates29857)) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _disconnect29858;
		public override void disconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._disconnect29858);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._disconnect29858);
		}
		internal static global::MonoJavaBridge.MethodId _usingProxy29859;
		public override bool usingProxy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._usingProxy29859);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._usingProxy29859);
		}
		internal static global::MonoJavaBridge.MethodId _connect29860;
		public override void connect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._connect29860);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._connect29860);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.HttpsURLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/HttpsURLConnection"));
			global::javax.net.ssl.HttpsURLConnection_._getCipherSuite29855 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "getCipherSuite", "()Ljava/lang/String;");
			global::javax.net.ssl.HttpsURLConnection_._getLocalCertificates29856 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "getLocalCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HttpsURLConnection_._getServerCertificates29857 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "getServerCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HttpsURLConnection_._disconnect29858 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "disconnect", "()V");
			global::javax.net.ssl.HttpsURLConnection_._usingProxy29859 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "usingProxy", "()Z");
			global::javax.net.ssl.HttpsURLConnection_._connect29860 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "connect", "()V");
		}
	}
}
