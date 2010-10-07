namespace org.apache.http.conn.ssl
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SSLSocketFactory : java.lang.Object, org.apache.http.conn.scheme.LayeredSocketFactory
	{
		internal static global::java.lang.Class staticClass;
		static SSLSocketFactory()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.conn.ssl.SSLSocketFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.conn.ssl.SSLSocketFactory(@__env);
			}
		}
		protected SSLSocketFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _createSocket14505;
		public virtual global::java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.ssl.SSLSocketFactory._createSocket14505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._createSocket14505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createSocket14506;
		public virtual global::java.net.Socket createSocket() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.ssl.SSLSocketFactory._createSocket14506));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._createSocket14506));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSocketFactory14507;
		public static global::org.apache.http.conn.ssl.SSLSocketFactory getSocketFactory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.ssl.SSLSocketFactory>(@__env, @__env.CallStaticObjectMethodPtr(org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._getSocketFactory14507));
		}
		internal static global::net.sf.jni4net.jni.MethodId _connectSocket14508;
		public virtual global::java.net.Socket connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.ssl.SSLSocketFactory._connectSocket14508, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._connectSocket14508, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSecure14509;
		public virtual bool isSecure(java.net.Socket arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.ssl.SSLSocketFactory._isSecure14509, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._isSecure14509, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHostnameVerifier14510;
		public virtual void setHostnameVerifier(org.apache.http.conn.ssl.X509HostnameVerifier arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.ssl.SSLSocketFactory._setHostnameVerifier14510, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._setHostnameVerifier14510, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHostnameVerifier14511;
		public virtual global::org.apache.http.conn.ssl.X509HostnameVerifier getHostnameVerifier() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.conn.ssl.X509HostnameVerifier>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.ssl.SSLSocketFactory._getHostnameVerifier14511));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.conn.ssl.X509HostnameVerifier>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._getHostnameVerifier14511));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SSLSocketFactory14512;
		public SSLSocketFactory(java.lang.String arg0, java.security.KeyStore arg1, java.lang.String arg2, java.security.KeyStore arg3, java.security.SecureRandom arg4, org.apache.http.conn.scheme.HostNameResolver arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory14512, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SSLSocketFactory14513;
		public SSLSocketFactory(java.security.KeyStore arg0, java.lang.String arg1, java.security.KeyStore arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory14513, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SSLSocketFactory14514;
		public SSLSocketFactory(java.security.KeyStore arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory14514, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SSLSocketFactory14515;
		public SSLSocketFactory(java.security.KeyStore arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory14515, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		internal static global::net.sf.jni4net.jni.FieldId _ALLOW_ALL_HOSTNAME_VERIFIER14516;
		public static global::org.apache.http.conn.ssl.X509HostnameVerifier ALLOW_ALL_HOSTNAME_VERIFIER
		{
			get
			{
				return default(global::org.apache.http.conn.ssl.X509HostnameVerifier);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _BROWSER_COMPATIBLE_HOSTNAME_VERIFIER14517;
		public static global::org.apache.http.conn.ssl.X509HostnameVerifier BROWSER_COMPATIBLE_HOSTNAME_VERIFIER
		{
			get
			{
				return default(global::org.apache.http.conn.ssl.X509HostnameVerifier);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _STRICT_HOSTNAME_VERIFIER14518;
		public static global::org.apache.http.conn.ssl.X509HostnameVerifier STRICT_HOSTNAME_VERIFIER
		{
			get
			{
				return default(global::org.apache.http.conn.ssl.X509HostnameVerifier);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass = @__class;
			global::org.apache.http.conn.ssl.SSLSocketFactory._createSocket14505 = @__env.GetMethodID(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;");
			global::org.apache.http.conn.ssl.SSLSocketFactory._createSocket14506 = @__env.GetMethodID(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;");
			global::org.apache.http.conn.ssl.SSLSocketFactory._getSocketFactory14507 = @__env.GetStaticMethodID(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "getSocketFactory", "()Lorg/apache/http/conn/ssl/SSLSocketFactory;");
			global::org.apache.http.conn.ssl.SSLSocketFactory._connectSocket14508 = @__env.GetMethodID(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/@params/HttpParams;)Ljava/net/Socket;");
			global::org.apache.http.conn.ssl.SSLSocketFactory._isSecure14509 = @__env.GetMethodID(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "isSecure", "(Ljava/net/Socket;)Z");
			global::org.apache.http.conn.ssl.SSLSocketFactory._setHostnameVerifier14510 = @__env.GetMethodID(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "setHostnameVerifier", "(Lorg/apache/http/conn/ssl/X509HostnameVerifier;)V");
			global::org.apache.http.conn.ssl.SSLSocketFactory._getHostnameVerifier14511 = @__env.GetMethodID(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "getHostnameVerifier", "()Lorg/apache/http/conn/ssl/X509HostnameVerifier;");
			global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory14512 = @__env.GetMethodID(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "<init>", "(Ljava/lang/String;Ljava/security/KeyStore;Ljava/lang/String;Ljava/security/KeyStore;Ljava/security/SecureRandom;Lorg/apache/http/conn/scheme/HostNameResolver;)V");
			global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory14513 = @__env.GetMethodID(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "<init>", "(Ljava/security/KeyStore;Ljava/lang/String;Ljava/security/KeyStore;)V");
			global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory14514 = @__env.GetMethodID(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "<init>", "(Ljava/security/KeyStore;Ljava/lang/String;)V");
			global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory14515 = @__env.GetMethodID(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "<init>", "(Ljava/security/KeyStore;)V");
		}
	}
}
