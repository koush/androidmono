namespace org.apache.http.conn.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLSocketFactory : java.lang.Object, org.apache.http.conn.scheme.LayeredSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", ref global::org.apache.http.conn.ssl.SSLSocketFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.net.Socket createSocket()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;", ref global::org.apache.http.conn.ssl.SSLSocketFactory._m1) as java.net.Socket;
		}
		public static global::org.apache.http.conn.ssl.SSLSocketFactory SocketFactory
		{
			get
			{
				return getSocketFactory();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::org.apache.http.conn.ssl.SSLSocketFactory getSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.SSLSocketFactory._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.SSLSocketFactory._m2 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "getSocketFactory", "()Lorg/apache/http/conn/ssl/SSLSocketFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._m2)) as org.apache.http.conn.ssl.SSLSocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.net.Socket connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/params/HttpParams;)Ljava/net/Socket;", ref global::org.apache.http.conn.ssl.SSLSocketFactory._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5)) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isSecure(java.net.Socket arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "isSecure", "(Ljava/net/Socket;)Z", ref global::org.apache.http.conn.ssl.SSLSocketFactory._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setHostnameVerifier(org.apache.http.conn.ssl.X509HostnameVerifier arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "setHostnameVerifier", "(Lorg/apache/http/conn/ssl/X509HostnameVerifier;)V", ref global::org.apache.http.conn.ssl.SSLSocketFactory._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.conn.ssl.X509HostnameVerifier HostnameVerifier
		{
			get
			{
				return getHostnameVerifier();
			}
			set
			{
				setHostnameVerifier(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::org.apache.http.conn.ssl.X509HostnameVerifier getHostnameVerifier()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ssl.X509HostnameVerifier>(this, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "getHostnameVerifier", "()Lorg/apache/http/conn/ssl/X509HostnameVerifier;", ref global::org.apache.http.conn.ssl.SSLSocketFactory._m6) as org.apache.http.conn.ssl.X509HostnameVerifier;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public SSLSocketFactory(java.lang.String arg0, java.security.KeyStore arg1, java.lang.String arg2, java.security.KeyStore arg3, java.security.SecureRandom arg4, org.apache.http.conn.scheme.HostNameResolver arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.SSLSocketFactory._m7.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.SSLSocketFactory._m7 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "<init>", "(Ljava/lang/String;Ljava/security/KeyStore;Ljava/lang/String;Ljava/security/KeyStore;Ljava/security/SecureRandom;Lorg/apache/http/conn/scheme/HostNameResolver;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public SSLSocketFactory(java.security.KeyStore arg0, java.lang.String arg1, java.security.KeyStore arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.SSLSocketFactory._m8.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.SSLSocketFactory._m8 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "<init>", "(Ljava/security/KeyStore;Ljava/lang/String;Ljava/security/KeyStore;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public SSLSocketFactory(java.security.KeyStore arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.SSLSocketFactory._m9.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.SSLSocketFactory._m9 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "<init>", "(Ljava/security/KeyStore;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public SSLSocketFactory(java.security.KeyStore arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.SSLSocketFactory._m10.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.SSLSocketFactory._m10 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "<init>", "(Ljava/security/KeyStore;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String TLS
		{
			get
			{
				return "TLS";
			}
		}
		public static global::java.lang.String SSL
		{
			get
			{
				return "SSL";
			}
		}
		public static global::java.lang.String SSLV2
		{
			get
			{
				return "SSLv2";
			}
		}
		internal static global::MonoJavaBridge.FieldId _ALLOW_ALL_HOSTNAME_VERIFIER7477;
		public static global::org.apache.http.conn.ssl.X509HostnameVerifier ALLOW_ALL_HOSTNAME_VERIFIER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ssl.X509HostnameVerifier>(@__env.GetStaticObjectField(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, _ALLOW_ALL_HOSTNAME_VERIFIER7477)) as org.apache.http.conn.ssl.X509HostnameVerifier;
			}
		}
		internal static global::MonoJavaBridge.FieldId _BROWSER_COMPATIBLE_HOSTNAME_VERIFIER7478;
		public static global::org.apache.http.conn.ssl.X509HostnameVerifier BROWSER_COMPATIBLE_HOSTNAME_VERIFIER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ssl.X509HostnameVerifier>(@__env.GetStaticObjectField(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, _BROWSER_COMPATIBLE_HOSTNAME_VERIFIER7478)) as org.apache.http.conn.ssl.X509HostnameVerifier;
			}
		}
		internal static global::MonoJavaBridge.FieldId _STRICT_HOSTNAME_VERIFIER7479;
		public static global::org.apache.http.conn.ssl.X509HostnameVerifier STRICT_HOSTNAME_VERIFIER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ssl.X509HostnameVerifier>(@__env.GetStaticObjectField(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, _STRICT_HOSTNAME_VERIFIER7479)) as org.apache.http.conn.ssl.X509HostnameVerifier;
			}
		}
		static SSLSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ssl/SSLSocketFactory"));
			global::org.apache.http.conn.ssl.SSLSocketFactory._ALLOW_ALL_HOSTNAME_VERIFIER7477 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "ALLOW_ALL_HOSTNAME_VERIFIER", "Lorg/apache/http/conn/ssl/X509HostnameVerifier;");
			global::org.apache.http.conn.ssl.SSLSocketFactory._BROWSER_COMPATIBLE_HOSTNAME_VERIFIER7478 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "BROWSER_COMPATIBLE_HOSTNAME_VERIFIER", "Lorg/apache/http/conn/ssl/X509HostnameVerifier;");
			global::org.apache.http.conn.ssl.SSLSocketFactory._STRICT_HOSTNAME_VERIFIER7479 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "STRICT_HOSTNAME_VERIFIER", "Lorg/apache/http/conn/ssl/X509HostnameVerifier;");
		}
		internal static void InitJNI()
		{
		}
	}
}
