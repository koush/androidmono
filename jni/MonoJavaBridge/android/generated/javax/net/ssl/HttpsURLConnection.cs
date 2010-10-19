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
		internal static global::MonoJavaBridge.MethodId _setHostnameVerifier23292;
		public virtual void setHostnameVerifier(javax.net.ssl.HostnameVerifier arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._setHostnameVerifier23292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._setHostnameVerifier23292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHostnameVerifier23293;
		public virtual global::javax.net.ssl.HostnameVerifier getHostnameVerifier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.HostnameVerifier>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._getHostnameVerifier23293)) as javax.net.ssl.HostnameVerifier;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.HostnameVerifier>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getHostnameVerifier23293)) as javax.net.ssl.HostnameVerifier;
		}
		internal static global::MonoJavaBridge.MethodId _getCipherSuite23294;
		public abstract global::java.lang.String getCipherSuite();
		internal static global::MonoJavaBridge.MethodId _getPeerPrincipal23295;
		public virtual global::java.security.Principal getPeerPrincipal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._getPeerPrincipal23295)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getPeerPrincipal23295)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPrincipal23296;
		public virtual global::java.security.Principal getLocalPrincipal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._getLocalPrincipal23296)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getLocalPrincipal23296)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalCertificates23297;
		public abstract global::java.security.cert.Certificate[] getLocalCertificates();
		internal static global::MonoJavaBridge.MethodId _getServerCertificates23298;
		public abstract global::java.security.cert.Certificate[] getServerCertificates();
		internal static global::MonoJavaBridge.MethodId _setDefaultHostnameVerifier23299;
		public static void setDefaultHostnameVerifier(javax.net.ssl.HostnameVerifier arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._setDefaultHostnameVerifier23299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultHostnameVerifier23300;
		public static global::javax.net.ssl.HostnameVerifier getDefaultHostnameVerifier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.HostnameVerifier>(@__env.CallStaticObjectMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getDefaultHostnameVerifier23300)) as javax.net.ssl.HostnameVerifier;
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultSSLSocketFactory23301;
		public static void setDefaultSSLSocketFactory(javax.net.ssl.SSLSocketFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._setDefaultSSLSocketFactory23301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultSSLSocketFactory23302;
		public static global::javax.net.ssl.SSLSocketFactory getDefaultSSLSocketFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getDefaultSSLSocketFactory23302)) as javax.net.ssl.SSLSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setSSLSocketFactory23303;
		public virtual void setSSLSocketFactory(javax.net.ssl.SSLSocketFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._setSSLSocketFactory23303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._setSSLSocketFactory23303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSSLSocketFactory23304;
		public virtual global::javax.net.ssl.SSLSocketFactory getSSLSocketFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection._getSSLSocketFactory23304)) as javax.net.ssl.SSLSocketFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._getSSLSocketFactory23304)) as javax.net.ssl.SSLSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _HttpsURLConnection23305;
		protected HttpsURLConnection(java.net.URL arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._HttpsURLConnection23305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.HttpsURLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/HttpsURLConnection"));
			global::javax.net.ssl.HttpsURLConnection._setHostnameVerifier23292 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V");
			global::javax.net.ssl.HttpsURLConnection._getHostnameVerifier23293 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;");
			global::javax.net.ssl.HttpsURLConnection._getCipherSuite23294 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getCipherSuite", "()Ljava/lang/String;");
			global::javax.net.ssl.HttpsURLConnection._getPeerPrincipal23295 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;");
			global::javax.net.ssl.HttpsURLConnection._getLocalPrincipal23296 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;");
			global::javax.net.ssl.HttpsURLConnection._getLocalCertificates23297 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getLocalCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HttpsURLConnection._getServerCertificates23298 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getServerCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HttpsURLConnection._setDefaultHostnameVerifier23299 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "setDefaultHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V");
			global::javax.net.ssl.HttpsURLConnection._getDefaultHostnameVerifier23300 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getDefaultHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;");
			global::javax.net.ssl.HttpsURLConnection._setDefaultSSLSocketFactory23301 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "setDefaultSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V");
			global::javax.net.ssl.HttpsURLConnection._getDefaultSSLSocketFactory23302 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getDefaultSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
			global::javax.net.ssl.HttpsURLConnection._setSSLSocketFactory23303 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "setSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V");
			global::javax.net.ssl.HttpsURLConnection._getSSLSocketFactory23304 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
			global::javax.net.ssl.HttpsURLConnection._HttpsURLConnection23305 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.HttpsURLConnection))]
	public sealed partial class HttpsURLConnection_ : javax.net.ssl.HttpsURLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpsURLConnection_()
		{
			InitJNI();
		}
		internal HttpsURLConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCipherSuite23306;
		public override global::java.lang.String getCipherSuite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._getCipherSuite23306)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._getCipherSuite23306)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalCertificates23307;
		public override global::java.security.cert.Certificate[] getLocalCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._getLocalCertificates23307)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._getLocalCertificates23307)) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getServerCertificates23308;
		public override global::java.security.cert.Certificate[] getServerCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._getServerCertificates23308)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._getServerCertificates23308)) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _disconnect23309;
		public override void disconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._disconnect23309);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._disconnect23309);
		}
		internal static global::MonoJavaBridge.MethodId _usingProxy23310;
		public override bool usingProxy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._usingProxy23310);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._usingProxy23310);
		}
		internal static global::MonoJavaBridge.MethodId _connect23311;
		public override void connect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_._connect23311);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.HttpsURLConnection_.staticClass, global::javax.net.ssl.HttpsURLConnection_._connect23311);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.HttpsURLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/HttpsURLConnection"));
			global::javax.net.ssl.HttpsURLConnection_._getCipherSuite23306 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "getCipherSuite", "()Ljava/lang/String;");
			global::javax.net.ssl.HttpsURLConnection_._getLocalCertificates23307 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "getLocalCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HttpsURLConnection_._getServerCertificates23308 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "getServerCertificates", "()[Ljava/security/cert/Certificate;");
			global::javax.net.ssl.HttpsURLConnection_._disconnect23309 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "disconnect", "()V");
			global::javax.net.ssl.HttpsURLConnection_._usingProxy23310 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "usingProxy", "()Z");
			global::javax.net.ssl.HttpsURLConnection_._connect23311 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection_.staticClass, "connect", "()V");
		}
	}
}
