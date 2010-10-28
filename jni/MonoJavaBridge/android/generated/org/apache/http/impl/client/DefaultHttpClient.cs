namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHttpClient : org.apache.http.impl.client.AbstractHttpClient
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DefaultHttpClient()
		{
			InitJNI();
		}
		protected DefaultHttpClient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createHttpParams32883;
		protected override global::org.apache.http.@params.HttpParams createHttpParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createHttpParams32883)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createHttpParams32883)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpContext32884;
		protected override global::org.apache.http.protocol.HttpContext createHttpContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.protocol.HttpContext>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createHttpContext32884)) as org.apache.http.protocol.HttpContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.protocol.HttpContext>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createHttpContext32884)) as org.apache.http.protocol.HttpContext;
		}
		internal static global::MonoJavaBridge.MethodId _createRequestExecutor32885;
		protected override global::org.apache.http.protocol.HttpRequestExecutor createRequestExecutor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createRequestExecutor32885)) as org.apache.http.protocol.HttpRequestExecutor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createRequestExecutor32885)) as org.apache.http.protocol.HttpRequestExecutor;
		}
		internal static global::MonoJavaBridge.MethodId _createClientConnectionManager32886;
		protected override global::org.apache.http.conn.ClientConnectionManager createClientConnectionManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createClientConnectionManager32886)) as org.apache.http.conn.ClientConnectionManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createClientConnectionManager32886)) as org.apache.http.conn.ClientConnectionManager;
		}
		internal static global::MonoJavaBridge.MethodId _createAuthSchemeRegistry32887;
		protected override global::org.apache.http.auth.AuthSchemeRegistry createAuthSchemeRegistry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.auth.AuthSchemeRegistry>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createAuthSchemeRegistry32887)) as org.apache.http.auth.AuthSchemeRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.auth.AuthSchemeRegistry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createAuthSchemeRegistry32887)) as org.apache.http.auth.AuthSchemeRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _createCookieSpecRegistry32888;
		protected override global::org.apache.http.cookie.CookieSpecRegistry createCookieSpecRegistry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.cookie.CookieSpecRegistry>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createCookieSpecRegistry32888)) as org.apache.http.cookie.CookieSpecRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.cookie.CookieSpecRegistry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createCookieSpecRegistry32888)) as org.apache.http.cookie.CookieSpecRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionReuseStrategy32889;
		protected override global::org.apache.http.ConnectionReuseStrategy createConnectionReuseStrategy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.ConnectionReuseStrategy>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createConnectionReuseStrategy32889)) as org.apache.http.ConnectionReuseStrategy;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.ConnectionReuseStrategy>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createConnectionReuseStrategy32889)) as org.apache.http.ConnectionReuseStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionKeepAliveStrategy32890;
		protected override global::org.apache.http.conn.ConnectionKeepAliveStrategy createConnectionKeepAliveStrategy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ConnectionKeepAliveStrategy>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createConnectionKeepAliveStrategy32890)) as org.apache.http.conn.ConnectionKeepAliveStrategy;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ConnectionKeepAliveStrategy>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createConnectionKeepAliveStrategy32890)) as org.apache.http.conn.ConnectionKeepAliveStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpProcessor32891;
		protected override global::org.apache.http.protocol.BasicHttpProcessor createHttpProcessor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.protocol.BasicHttpProcessor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createHttpProcessor32891)) as org.apache.http.protocol.BasicHttpProcessor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.protocol.BasicHttpProcessor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createHttpProcessor32891)) as org.apache.http.protocol.BasicHttpProcessor;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpRequestRetryHandler32892;
		protected override global::org.apache.http.client.HttpRequestRetryHandler createHttpRequestRetryHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.HttpRequestRetryHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createHttpRequestRetryHandler32892)) as org.apache.http.client.HttpRequestRetryHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.HttpRequestRetryHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createHttpRequestRetryHandler32892)) as org.apache.http.client.HttpRequestRetryHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createRedirectHandler32893;
		protected override global::org.apache.http.client.RedirectHandler createRedirectHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RedirectHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createRedirectHandler32893)) as org.apache.http.client.RedirectHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RedirectHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createRedirectHandler32893)) as org.apache.http.client.RedirectHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createTargetAuthenticationHandler32894;
		protected override global::org.apache.http.client.AuthenticationHandler createTargetAuthenticationHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createTargetAuthenticationHandler32894)) as org.apache.http.client.AuthenticationHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createTargetAuthenticationHandler32894)) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createProxyAuthenticationHandler32895;
		protected override global::org.apache.http.client.AuthenticationHandler createProxyAuthenticationHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createProxyAuthenticationHandler32895)) as org.apache.http.client.AuthenticationHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createProxyAuthenticationHandler32895)) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createCookieStore32896;
		protected override global::org.apache.http.client.CookieStore createCookieStore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CookieStore>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createCookieStore32896)) as org.apache.http.client.CookieStore;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CookieStore>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createCookieStore32896)) as org.apache.http.client.CookieStore;
		}
		internal static global::MonoJavaBridge.MethodId _createCredentialsProvider32897;
		protected override global::org.apache.http.client.CredentialsProvider createCredentialsProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CredentialsProvider>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createCredentialsProvider32897)) as org.apache.http.client.CredentialsProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CredentialsProvider>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createCredentialsProvider32897)) as org.apache.http.client.CredentialsProvider;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpRoutePlanner32898;
		protected override global::org.apache.http.conn.routing.HttpRoutePlanner createHttpRoutePlanner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.routing.HttpRoutePlanner>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createHttpRoutePlanner32898)) as org.apache.http.conn.routing.HttpRoutePlanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.routing.HttpRoutePlanner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createHttpRoutePlanner32898)) as org.apache.http.conn.routing.HttpRoutePlanner;
		}
		internal static global::MonoJavaBridge.MethodId _createUserTokenHandler32899;
		protected override global::org.apache.http.client.UserTokenHandler createUserTokenHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.UserTokenHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createUserTokenHandler32899)) as org.apache.http.client.UserTokenHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.UserTokenHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createUserTokenHandler32899)) as org.apache.http.client.UserTokenHandler;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpClient32900;
		public DefaultHttpClient(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient32900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpClient32901;
		public DefaultHttpClient() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient32901);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpClient32902;
		public DefaultHttpClient(org.apache.http.conn.ClientConnectionManager arg0, org.apache.http.@params.HttpParams arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient32902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultHttpClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultHttpClient"));
			global::org.apache.http.impl.client.DefaultHttpClient._createHttpParams32883 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpParams", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.impl.client.DefaultHttpClient._createHttpContext32884 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpContext", "()Lorg/apache/http/protocol/HttpContext;");
			global::org.apache.http.impl.client.DefaultHttpClient._createRequestExecutor32885 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;");
			global::org.apache.http.impl.client.DefaultHttpClient._createClientConnectionManager32886 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createClientConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
			global::org.apache.http.impl.client.DefaultHttpClient._createAuthSchemeRegistry32887 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createAuthSchemeRegistry", "()Lorg/apache/http/auth/AuthSchemeRegistry;");
			global::org.apache.http.impl.client.DefaultHttpClient._createCookieSpecRegistry32888 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createCookieSpecRegistry", "()Lorg/apache/http/cookie/CookieSpecRegistry;");
			global::org.apache.http.impl.client.DefaultHttpClient._createConnectionReuseStrategy32889 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;");
			global::org.apache.http.impl.client.DefaultHttpClient._createConnectionKeepAliveStrategy32890 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;");
			global::org.apache.http.impl.client.DefaultHttpClient._createHttpProcessor32891 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;");
			global::org.apache.http.impl.client.DefaultHttpClient._createHttpRequestRetryHandler32892 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;");
			global::org.apache.http.impl.client.DefaultHttpClient._createRedirectHandler32893 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;");
			global::org.apache.http.impl.client.DefaultHttpClient._createTargetAuthenticationHandler32894 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.DefaultHttpClient._createProxyAuthenticationHandler32895 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.DefaultHttpClient._createCookieStore32896 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createCookieStore", "()Lorg/apache/http/client/CookieStore;");
			global::org.apache.http.impl.client.DefaultHttpClient._createCredentialsProvider32897 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;");
			global::org.apache.http.impl.client.DefaultHttpClient._createHttpRoutePlanner32898 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;");
			global::org.apache.http.impl.client.DefaultHttpClient._createUserTokenHandler32899 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;");
			global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient32900 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient32901 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "<init>", "()V");
			global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient32902 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/params/HttpParams;)V");
		}
	}
}
