namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.HttpsURLConnection_))]
	public abstract partial class HttpsURLConnection : java.net.HttpURLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpsURLConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setHostnameVerifier(javax.net.ssl.HostnameVerifier arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.HttpsURLConnection.staticClass, "setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", ref global::javax.net.ssl.HttpsURLConnection._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::javax.net.ssl.HostnameVerifier getHostnameVerifier()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.HostnameVerifier>(this, global::javax.net.ssl.HttpsURLConnection.staticClass, "getHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;", ref global::javax.net.ssl.HttpsURLConnection._m1) as javax.net.ssl.HostnameVerifier;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.lang.String getCipherSuite();
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.security.Principal getPeerPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::javax.net.ssl.HttpsURLConnection.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;", ref global::javax.net.ssl.HttpsURLConnection._m3) as java.security.Principal;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.security.Principal getLocalPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::javax.net.ssl.HttpsURLConnection.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;", ref global::javax.net.ssl.HttpsURLConnection._m4) as java.security.Principal;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.security.cert.Certificate[] getLocalCertificates();
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::java.security.cert.Certificate[] getServerCertificates();
		private static global::MonoJavaBridge.MethodId _m7;
		public static void setDefaultHostnameVerifier(javax.net.ssl.HostnameVerifier arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.HttpsURLConnection._m7.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.HttpsURLConnection._m7 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "setDefaultHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V");
			@__env.CallStaticVoidMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::javax.net.ssl.HostnameVerifier getDefaultHostnameVerifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.HttpsURLConnection._m8.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.HttpsURLConnection._m8 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getDefaultHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.HostnameVerifier>(@__env.CallStaticObjectMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._m8)) as javax.net.ssl.HostnameVerifier;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static void setDefaultSSLSocketFactory(javax.net.ssl.SSLSocketFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.HttpsURLConnection._m9.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.HttpsURLConnection._m9 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "setDefaultSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V");
			@__env.CallStaticVoidMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::javax.net.ssl.SSLSocketFactory getDefaultSSLSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.HttpsURLConnection._m10.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.HttpsURLConnection._m10 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "getDefaultSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._m10)) as javax.net.ssl.SSLSocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setSSLSocketFactory(javax.net.ssl.SSLSocketFactory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.HttpsURLConnection.staticClass, "setSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V", ref global::javax.net.ssl.HttpsURLConnection._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::javax.net.ssl.SSLSocketFactory getSSLSocketFactory()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.HttpsURLConnection.staticClass, "getSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", ref global::javax.net.ssl.HttpsURLConnection._m12) as javax.net.ssl.SSLSocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected HttpsURLConnection(java.net.URL arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.HttpsURLConnection._m13.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.HttpsURLConnection._m13 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.HttpsURLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.HttpsURLConnection.staticClass, global::javax.net.ssl.HttpsURLConnection._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static HttpsURLConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.HttpsURLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/HttpsURLConnection"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.HttpsURLConnection))]
	internal sealed partial class HttpsURLConnection_ : javax.net.ssl.HttpsURLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpsURLConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getCipherSuite()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.HttpsURLConnection_.staticClass, "getCipherSuite", "()Ljava/lang/String;", ref global::javax.net.ssl.HttpsURLConnection_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.security.cert.Certificate[] getLocalCertificates()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::javax.net.ssl.HttpsURLConnection_.staticClass, "getLocalCertificates", "()[Ljava/security/cert/Certificate;", ref global::javax.net.ssl.HttpsURLConnection_._m1) as java.security.cert.Certificate[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.security.cert.Certificate[] getServerCertificates()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.Certificate>(this, global::javax.net.ssl.HttpsURLConnection_.staticClass, "getServerCertificates", "()[Ljava/security/cert/Certificate;", ref global::javax.net.ssl.HttpsURLConnection_._m2) as java.security.cert.Certificate[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void disconnect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.HttpsURLConnection_.staticClass, "disconnect", "()V", ref global::javax.net.ssl.HttpsURLConnection_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool usingProxy()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.HttpsURLConnection_.staticClass, "usingProxy", "()Z", ref global::javax.net.ssl.HttpsURLConnection_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void connect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.HttpsURLConnection_.staticClass, "connect", "()V", ref global::javax.net.ssl.HttpsURLConnection_._m5);
		}
		static HttpsURLConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.HttpsURLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/HttpsURLConnection"));
		}
	}
}
