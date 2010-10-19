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
		internal static global::MonoJavaBridge.MethodId _createHttpParams26141;
		protected override global::org.apache.http.@params.HttpParams createHttpParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createHttpParams26141)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createHttpParams26141)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpContext26142;
		protected override global::org.apache.http.protocol.HttpContext createHttpContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.protocol.HttpContext>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createHttpContext26142)) as org.apache.http.protocol.HttpContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.protocol.HttpContext>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createHttpContext26142)) as org.apache.http.protocol.HttpContext;
		}
		internal static global::MonoJavaBridge.MethodId _createRequestExecutor26143;
		protected override global::org.apache.http.protocol.HttpRequestExecutor createRequestExecutor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createRequestExecutor26143)) as org.apache.http.protocol.HttpRequestExecutor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createRequestExecutor26143)) as org.apache.http.protocol.HttpRequestExecutor;
		}
		internal static global::MonoJavaBridge.MethodId _createClientConnectionManager26144;
		protected override global::org.apache.http.conn.ClientConnectionManager createClientConnectionManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createClientConnectionManager26144)) as org.apache.http.conn.ClientConnectionManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createClientConnectionManager26144)) as org.apache.http.conn.ClientConnectionManager;
		}
		internal static global::MonoJavaBridge.MethodId _createAuthSchemeRegistry26145;
		protected override global::org.apache.http.auth.AuthSchemeRegistry createAuthSchemeRegistry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createAuthSchemeRegistry26145)) as org.apache.http.auth.AuthSchemeRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createAuthSchemeRegistry26145)) as org.apache.http.auth.AuthSchemeRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _createCookieSpecRegistry26146;
		protected override global::org.apache.http.cookie.CookieSpecRegistry createCookieSpecRegistry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createCookieSpecRegistry26146)) as org.apache.http.cookie.CookieSpecRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createCookieSpecRegistry26146)) as org.apache.http.cookie.CookieSpecRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionReuseStrategy26147;
		protected override global::org.apache.http.ConnectionReuseStrategy createConnectionReuseStrategy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.ConnectionReuseStrategy>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createConnectionReuseStrategy26147)) as org.apache.http.ConnectionReuseStrategy;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.ConnectionReuseStrategy>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createConnectionReuseStrategy26147)) as org.apache.http.ConnectionReuseStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionKeepAliveStrategy26148;
		protected override global::org.apache.http.conn.ConnectionKeepAliveStrategy createConnectionKeepAliveStrategy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ConnectionKeepAliveStrategy>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createConnectionKeepAliveStrategy26148)) as org.apache.http.conn.ConnectionKeepAliveStrategy;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ConnectionKeepAliveStrategy>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createConnectionKeepAliveStrategy26148)) as org.apache.http.conn.ConnectionKeepAliveStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpProcessor26149;
		protected override global::org.apache.http.protocol.BasicHttpProcessor createHttpProcessor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createHttpProcessor26149)) as org.apache.http.protocol.BasicHttpProcessor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createHttpProcessor26149)) as org.apache.http.protocol.BasicHttpProcessor;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpRequestRetryHandler26150;
		protected override global::org.apache.http.client.HttpRequestRetryHandler createHttpRequestRetryHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.HttpRequestRetryHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createHttpRequestRetryHandler26150)) as org.apache.http.client.HttpRequestRetryHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.HttpRequestRetryHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createHttpRequestRetryHandler26150)) as org.apache.http.client.HttpRequestRetryHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createRedirectHandler26151;
		protected override global::org.apache.http.client.RedirectHandler createRedirectHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RedirectHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createRedirectHandler26151)) as org.apache.http.client.RedirectHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RedirectHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createRedirectHandler26151)) as org.apache.http.client.RedirectHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createTargetAuthenticationHandler26152;
		protected override global::org.apache.http.client.AuthenticationHandler createTargetAuthenticationHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createTargetAuthenticationHandler26152)) as org.apache.http.client.AuthenticationHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createTargetAuthenticationHandler26152)) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createProxyAuthenticationHandler26153;
		protected override global::org.apache.http.client.AuthenticationHandler createProxyAuthenticationHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createProxyAuthenticationHandler26153)) as org.apache.http.client.AuthenticationHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createProxyAuthenticationHandler26153)) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createCookieStore26154;
		protected override global::org.apache.http.client.CookieStore createCookieStore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CookieStore>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createCookieStore26154)) as org.apache.http.client.CookieStore;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CookieStore>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createCookieStore26154)) as org.apache.http.client.CookieStore;
		}
		internal static global::MonoJavaBridge.MethodId _createCredentialsProvider26155;
		protected override global::org.apache.http.client.CredentialsProvider createCredentialsProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CredentialsProvider>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createCredentialsProvider26155)) as org.apache.http.client.CredentialsProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CredentialsProvider>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createCredentialsProvider26155)) as org.apache.http.client.CredentialsProvider;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpRoutePlanner26156;
		protected override global::org.apache.http.conn.routing.HttpRoutePlanner createHttpRoutePlanner() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.routing.HttpRoutePlanner>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createHttpRoutePlanner26156)) as org.apache.http.conn.routing.HttpRoutePlanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.routing.HttpRoutePlanner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createHttpRoutePlanner26156)) as org.apache.http.conn.routing.HttpRoutePlanner;
		}
		internal static global::MonoJavaBridge.MethodId _createUserTokenHandler26157;
		protected override global::org.apache.http.client.UserTokenHandler createUserTokenHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.UserTokenHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient._createUserTokenHandler26157)) as org.apache.http.client.UserTokenHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.UserTokenHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._createUserTokenHandler26157)) as org.apache.http.client.UserTokenHandler;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpClient26158;
		public DefaultHttpClient(org.apache.http.@params.HttpParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient26158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpClient26159;
		public DefaultHttpClient()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient26159);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpClient26160;
		public DefaultHttpClient(org.apache.http.conn.ClientConnectionManager arg0, org.apache.http.@params.HttpParams arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultHttpClient.staticClass, global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient26160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultHttpClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultHttpClient"));
			global::org.apache.http.impl.client.DefaultHttpClient._createHttpParams26141 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.impl.client.DefaultHttpClient._createHttpContext26142 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpContext", "()Lorg/apache/http/protocol/HttpContext;");
			global::org.apache.http.impl.client.DefaultHttpClient._createRequestExecutor26143 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;");
			global::org.apache.http.impl.client.DefaultHttpClient._createClientConnectionManager26144 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createClientConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
			global::org.apache.http.impl.client.DefaultHttpClient._createAuthSchemeRegistry26145 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createAuthSchemeRegistry", "()Lorg/apache/http/auth/AuthSchemeRegistry;");
			global::org.apache.http.impl.client.DefaultHttpClient._createCookieSpecRegistry26146 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createCookieSpecRegistry", "()Lorg/apache/http/cookie/CookieSpecRegistry;");
			global::org.apache.http.impl.client.DefaultHttpClient._createConnectionReuseStrategy26147 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;");
			global::org.apache.http.impl.client.DefaultHttpClient._createConnectionKeepAliveStrategy26148 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;");
			global::org.apache.http.impl.client.DefaultHttpClient._createHttpProcessor26149 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;");
			global::org.apache.http.impl.client.DefaultHttpClient._createHttpRequestRetryHandler26150 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;");
			global::org.apache.http.impl.client.DefaultHttpClient._createRedirectHandler26151 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;");
			global::org.apache.http.impl.client.DefaultHttpClient._createTargetAuthenticationHandler26152 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.DefaultHttpClient._createProxyAuthenticationHandler26153 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.DefaultHttpClient._createCookieStore26154 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createCookieStore", "()Lorg/apache/http/client/CookieStore;");
			global::org.apache.http.impl.client.DefaultHttpClient._createCredentialsProvider26155 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;");
			global::org.apache.http.impl.client.DefaultHttpClient._createHttpRoutePlanner26156 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createHttpRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;");
			global::org.apache.http.impl.client.DefaultHttpClient._createUserTokenHandler26157 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "createUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;");
			global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient26158 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "<init>", "(Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient26159 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "<init>", "()V");
			global::org.apache.http.impl.client.DefaultHttpClient._DefaultHttpClient26160 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultHttpClient.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/@params/HttpParams;)V");
		}
	}
}
