namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHttpClient : org.apache.http.impl.client.AbstractHttpClient
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultHttpClient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::org.apache.http.@params.HttpParams createHttpParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpParams", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.impl.client.DefaultHttpClient._m0) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override global::org.apache.http.protocol.HttpContext createHttpContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.protocol.HttpContext>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpContext", "()Lorg/apache/http/protocol/HttpContext;", ref global::org.apache.http.impl.client.DefaultHttpClient._m1) as org.apache.http.protocol.HttpContext;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override global::org.apache.http.protocol.HttpRequestExecutor createRequestExecutor()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;", ref global::org.apache.http.impl.client.DefaultHttpClient._m2) as org.apache.http.protocol.HttpRequestExecutor;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override global::org.apache.http.conn.ClientConnectionManager createClientConnectionManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionManager>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createClientConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;", ref global::org.apache.http.impl.client.DefaultHttpClient._m3) as org.apache.http.conn.ClientConnectionManager;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override global::org.apache.http.auth.AuthSchemeRegistry createAuthSchemeRegistry()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.auth.AuthSchemeRegistry>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createAuthSchemeRegistry", "()Lorg/apache/http/auth/AuthSchemeRegistry;", ref global::org.apache.http.impl.client.DefaultHttpClient._m4) as org.apache.http.auth.AuthSchemeRegistry;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override global::org.apache.http.cookie.CookieSpecRegistry createCookieSpecRegistry()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.cookie.CookieSpecRegistry>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createCookieSpecRegistry", "()Lorg/apache/http/cookie/CookieSpecRegistry;", ref global::org.apache.http.impl.client.DefaultHttpClient._m5) as org.apache.http.cookie.CookieSpecRegistry;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override global::org.apache.http.ConnectionReuseStrategy createConnectionReuseStrategy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.ConnectionReuseStrategy>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;", ref global::org.apache.http.impl.client.DefaultHttpClient._m6) as org.apache.http.ConnectionReuseStrategy;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override global::org.apache.http.conn.ConnectionKeepAliveStrategy createConnectionKeepAliveStrategy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ConnectionKeepAliveStrategy>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;", ref global::org.apache.http.impl.client.DefaultHttpClient._m7) as org.apache.http.conn.ConnectionKeepAliveStrategy;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override global::org.apache.http.protocol.BasicHttpProcessor createHttpProcessor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.protocol.BasicHttpProcessor>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;", ref global::org.apache.http.impl.client.DefaultHttpClient._m8) as org.apache.http.protocol.BasicHttpProcessor;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override global::org.apache.http.client.HttpRequestRetryHandler createHttpRequestRetryHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.HttpRequestRetryHandler>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;", ref global::org.apache.http.impl.client.DefaultHttpClient._m9) as org.apache.http.client.HttpRequestRetryHandler;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override global::org.apache.http.client.RedirectHandler createRedirectHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.RedirectHandler>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;", ref global::org.apache.http.impl.client.DefaultHttpClient._m10) as org.apache.http.client.RedirectHandler;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected override global::org.apache.http.client.AuthenticationHandler createTargetAuthenticationHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.AuthenticationHandler>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", ref global::org.apache.http.impl.client.DefaultHttpClient._m11) as org.apache.http.client.AuthenticationHandler;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected override global::org.apache.http.client.AuthenticationHandler createProxyAuthenticationHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.AuthenticationHandler>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;", ref global::org.apache.http.impl.client.DefaultHttpClient._m12) as org.apache.http.client.AuthenticationHandler;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected override global::org.apache.http.client.CookieStore createCookieStore()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.CookieStore>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createCookieStore", "()Lorg/apache/http/client/CookieStore;", ref global::org.apache.http.impl.client.DefaultHttpClient._m13) as org.apache.http.client.CookieStore;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected override global::org.apache.http.client.CredentialsProvider createCredentialsProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.CredentialsProvider>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;", ref global::org.apache.http.impl.client.DefaultHttpClient._m14) as org.apache.http.client.CredentialsProvider;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected override global::org.apache.http.conn.routing.HttpRoutePlanner createHttpRoutePlanner()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.routing.HttpRoutePlanner>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;", ref global::org.apache.http.impl.client.DefaultHttpClient._m15) as org.apache.http.conn.routing.HttpRoutePlanner;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected override global::org.apache.http.client.UserTokenHandler createUserTokenHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.client.UserTokenHandler>(this, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;", ref global::org.apache.http.impl.client.DefaultHttpClient._m16) as org.apache.http.client.UserTokenHandler;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public DefaultHttpClient(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._m17.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._m17 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public DefaultHttpClient() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._m18.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._m18 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._m18);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public DefaultHttpClient(org.apache.http.conn.ClientConnectionManager arg0, org.apache.http.@params.HttpParams arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultHttpClient._m19.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultHttpClient._m19 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DefaultHttpClient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultHttpClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultHttpClient"));
		}
	}
}
