namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHttpClient : org.apache.http.impl.client.AbstractHttpClient
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultHttpClient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createHttpParams32883;
		protected override global::org.apache.http.@params.HttpParams createHttpParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createHttpParams32883.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createHttpParams32883 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpParams", "()Lorg/apache/http/params/HttpParams;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createHttpParams32883) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpContext32884;
		protected override global::org.apache.http.protocol.HttpContext createHttpContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createHttpContext32884.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createHttpContext32884 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpContext", "()Lorg/apache/http/protocol/HttpContext;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.protocol.HttpContext>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createHttpContext32884) as org.apache.http.protocol.HttpContext;
		}
		internal static global::MonoJavaBridge.MethodId _createRequestExecutor32885;
		protected override global::org.apache.http.protocol.HttpRequestExecutor createRequestExecutor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createRequestExecutor32885.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createRequestExecutor32885 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createRequestExecutor32885) as org.apache.http.protocol.HttpRequestExecutor;
		}
		internal static global::MonoJavaBridge.MethodId _createClientConnectionManager32886;
		protected override global::org.apache.http.conn.ClientConnectionManager createClientConnectionManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createClientConnectionManager32886.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createClientConnectionManager32886 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createClientConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionManager>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createClientConnectionManager32886) as org.apache.http.conn.ClientConnectionManager;
		}
		internal static global::MonoJavaBridge.MethodId _createAuthSchemeRegistry32887;
		protected override global::org.apache.http.auth.AuthSchemeRegistry createAuthSchemeRegistry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createAuthSchemeRegistry32887.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createAuthSchemeRegistry32887 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createAuthSchemeRegistry", "()Lorg/apache/http/auth/AuthSchemeRegistry;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.auth.AuthSchemeRegistry>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createAuthSchemeRegistry32887) as org.apache.http.auth.AuthSchemeRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _createCookieSpecRegistry32888;
		protected override global::org.apache.http.cookie.CookieSpecRegistry createCookieSpecRegistry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createCookieSpecRegistry32888.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createCookieSpecRegistry32888 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createCookieSpecRegistry", "()Lorg/apache/http/cookie/CookieSpecRegistry;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.cookie.CookieSpecRegistry>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createCookieSpecRegistry32888) as org.apache.http.cookie.CookieSpecRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionReuseStrategy32889;
		protected override global::org.apache.http.ConnectionReuseStrategy createConnectionReuseStrategy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createConnectionReuseStrategy32889.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createConnectionReuseStrategy32889 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.ConnectionReuseStrategy>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createConnectionReuseStrategy32889) as org.apache.http.ConnectionReuseStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionKeepAliveStrategy32890;
		protected override global::org.apache.http.conn.ConnectionKeepAliveStrategy createConnectionKeepAliveStrategy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createConnectionKeepAliveStrategy32890.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createConnectionKeepAliveStrategy32890 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ConnectionKeepAliveStrategy>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createConnectionKeepAliveStrategy32890) as org.apache.http.conn.ConnectionKeepAliveStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpProcessor32891;
		protected override global::org.apache.http.protocol.BasicHttpProcessor createHttpProcessor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createHttpProcessor32891.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createHttpProcessor32891 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.protocol.BasicHttpProcessor>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createHttpProcessor32891) as org.apache.http.protocol.BasicHttpProcessor;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpRequestRetryHandler32892;
		protected override global::org.apache.http.client.HttpRequestRetryHandler createHttpRequestRetryHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createHttpRequestRetryHandler32892.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createHttpRequestRetryHandler32892 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.HttpRequestRetryHandler>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createHttpRequestRetryHandler32892) as org.apache.http.client.HttpRequestRetryHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createRedirectHandler32893;
		protected override global::org.apache.http.client.RedirectHandler createRedirectHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createRedirectHandler32893.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createRedirectHandler32893 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.RedirectHandler>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createRedirectHandler32893) as org.apache.http.client.RedirectHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createTargetAuthenticationHandler32894;
		protected override global::org.apache.http.client.AuthenticationHandler createTargetAuthenticationHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createTargetAuthenticationHandler32894.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createTargetAuthenticationHandler32894 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.AuthenticationHandler>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createTargetAuthenticationHandler32894) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createProxyAuthenticationHandler32895;
		protected override global::org.apache.http.client.AuthenticationHandler createProxyAuthenticationHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createProxyAuthenticationHandler32895.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createProxyAuthenticationHandler32895 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.AuthenticationHandler>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createProxyAuthenticationHandler32895) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createCookieStore32896;
		protected override global::org.apache.http.client.CookieStore createCookieStore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createCookieStore32896.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createCookieStore32896 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createCookieStore", "()Lorg/apache/http/client/CookieStore;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.CookieStore>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createCookieStore32896) as org.apache.http.client.CookieStore;
		}
		internal static global::MonoJavaBridge.MethodId _createCredentialsProvider32897;
		protected override global::org.apache.http.client.CredentialsProvider createCredentialsProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createCredentialsProvider32897.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createCredentialsProvider32897 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.CredentialsProvider>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createCredentialsProvider32897) as org.apache.http.client.CredentialsProvider;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpRoutePlanner32898;
		protected override global::org.apache.http.conn.routing.HttpRoutePlanner createHttpRoutePlanner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createHttpRoutePlanner32898.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createHttpRoutePlanner32898 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.routing.HttpRoutePlanner>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createHttpRoutePlanner32898) as org.apache.http.conn.routing.HttpRoutePlanner;
		}
		internal static global::MonoJavaBridge.MethodId _createUserTokenHandler32899;
		protected override global::org.apache.http.client.UserTokenHandler createUserTokenHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._createUserTokenHandler32899.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._createUserTokenHandler32899 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.UserTokenHandler>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createUserTokenHandler32899) as org.apache.http.client.UserTokenHandler;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpClient32900;
		public DefaultHttpClient(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient32900.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient32900 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient32900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpClient32901;
		public DefaultHttpClient() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient32901.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient32901 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient32901);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpClient32902;
		public DefaultHttpClient(org.apache.http.conn.ClientConnectionManager arg0, org.apache.http.@params.HttpParams arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient32902.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient32902 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient32902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DefaultHttpClient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultHttpClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultHttpClient"));
		}
		internal static void InitJNI()
		{
		}
	}
}
