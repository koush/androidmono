namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.client.AbstractHttpClient_))]
	public abstract partial class AbstractHttpClient : java.lang.Object, org.apache.http.client.HttpClient
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpClient()
		{
			InitJNI();
		}
		protected AbstractHttpClient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParams26028;
		public virtual global::org.apache.http.@params.HttpParams getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getParams26028)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getParams26028)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams26029;
		public virtual void setParams(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setParams26029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setParams26029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _execute26030;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute26030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute26030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute26031;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute26031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute26031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute26032;
		public virtual global::java.lang.Object execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute26032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute26032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute26033;
		public virtual global::java.lang.Object execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2, org.apache.http.protocol.HttpContext arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute26033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute26033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute26034;
		public virtual global::java.lang.Object execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute26034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute26034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute26035;
		public virtual global::java.lang.Object execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute26035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute26035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute26036;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.client.methods.HttpUriRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute26036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute26036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute26037;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute26037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute26037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionManager26038;
		public virtual global::org.apache.http.conn.ClientConnectionManager getConnectionManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getConnectionManager26038)) as org.apache.http.conn.ClientConnectionManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getConnectionManager26038)) as org.apache.http.conn.ClientConnectionManager;
		}
		internal static global::MonoJavaBridge.MethodId _setCookieStore26039;
		public virtual void setCookieStore(org.apache.http.client.CookieStore arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setCookieStore26039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setCookieStore26039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCredentialsProvider26040;
		public virtual void setCredentialsProvider(org.apache.http.client.CredentialsProvider arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setCredentialsProvider26040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setCredentialsProvider26040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createHttpParams26041;
		protected abstract global::org.apache.http.@params.HttpParams createHttpParams();
		internal static global::MonoJavaBridge.MethodId _createHttpContext26042;
		protected abstract global::org.apache.http.protocol.HttpContext createHttpContext();
		internal static global::MonoJavaBridge.MethodId _createRequestExecutor26043;
		protected abstract global::org.apache.http.protocol.HttpRequestExecutor createRequestExecutor();
		internal static global::MonoJavaBridge.MethodId _createClientConnectionManager26044;
		protected abstract global::org.apache.http.conn.ClientConnectionManager createClientConnectionManager();
		internal static global::MonoJavaBridge.MethodId _createAuthSchemeRegistry26045;
		protected abstract global::org.apache.http.auth.AuthSchemeRegistry createAuthSchemeRegistry();
		internal static global::MonoJavaBridge.MethodId _createCookieSpecRegistry26046;
		protected abstract global::org.apache.http.cookie.CookieSpecRegistry createCookieSpecRegistry();
		internal static global::MonoJavaBridge.MethodId _createConnectionReuseStrategy26047;
		protected abstract global::org.apache.http.ConnectionReuseStrategy createConnectionReuseStrategy();
		internal static global::MonoJavaBridge.MethodId _createConnectionKeepAliveStrategy26048;
		protected abstract global::org.apache.http.conn.ConnectionKeepAliveStrategy createConnectionKeepAliveStrategy();
		internal static global::MonoJavaBridge.MethodId _createHttpProcessor26049;
		protected abstract global::org.apache.http.protocol.BasicHttpProcessor createHttpProcessor();
		internal static global::MonoJavaBridge.MethodId _createHttpRequestRetryHandler26050;
		protected abstract global::org.apache.http.client.HttpRequestRetryHandler createHttpRequestRetryHandler();
		internal static global::MonoJavaBridge.MethodId _createRedirectHandler26051;
		protected abstract global::org.apache.http.client.RedirectHandler createRedirectHandler();
		internal static global::MonoJavaBridge.MethodId _createTargetAuthenticationHandler26052;
		protected abstract global::org.apache.http.client.AuthenticationHandler createTargetAuthenticationHandler();
		internal static global::MonoJavaBridge.MethodId _createProxyAuthenticationHandler26053;
		protected abstract global::org.apache.http.client.AuthenticationHandler createProxyAuthenticationHandler();
		internal static global::MonoJavaBridge.MethodId _createCookieStore26054;
		protected abstract global::org.apache.http.client.CookieStore createCookieStore();
		internal static global::MonoJavaBridge.MethodId _createCredentialsProvider26055;
		protected abstract global::org.apache.http.client.CredentialsProvider createCredentialsProvider();
		internal static global::MonoJavaBridge.MethodId _createHttpRoutePlanner26056;
		protected abstract global::org.apache.http.conn.routing.HttpRoutePlanner createHttpRoutePlanner();
		internal static global::MonoJavaBridge.MethodId _createUserTokenHandler26057;
		protected abstract global::org.apache.http.client.UserTokenHandler createUserTokenHandler();
		internal static global::MonoJavaBridge.MethodId _getRequestExecutor26058;
		public virtual global::org.apache.http.protocol.HttpRequestExecutor getRequestExecutor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getRequestExecutor26058)) as org.apache.http.protocol.HttpRequestExecutor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getRequestExecutor26058)) as org.apache.http.protocol.HttpRequestExecutor;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthSchemes26059;
		public virtual global::org.apache.http.auth.AuthSchemeRegistry getAuthSchemes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getAuthSchemes26059)) as org.apache.http.auth.AuthSchemeRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getAuthSchemes26059)) as org.apache.http.auth.AuthSchemeRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _setAuthSchemes26060;
		public virtual void setAuthSchemes(org.apache.http.auth.AuthSchemeRegistry arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setAuthSchemes26060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setAuthSchemes26060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCookieSpecs26061;
		public virtual global::org.apache.http.cookie.CookieSpecRegistry getCookieSpecs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getCookieSpecs26061)) as org.apache.http.cookie.CookieSpecRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getCookieSpecs26061)) as org.apache.http.cookie.CookieSpecRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _setCookieSpecs26062;
		public virtual void setCookieSpecs(org.apache.http.cookie.CookieSpecRegistry arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setCookieSpecs26062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setCookieSpecs26062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionReuseStrategy26063;
		public virtual global::org.apache.http.ConnectionReuseStrategy getConnectionReuseStrategy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.ConnectionReuseStrategy>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getConnectionReuseStrategy26063)) as org.apache.http.ConnectionReuseStrategy;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.ConnectionReuseStrategy>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getConnectionReuseStrategy26063)) as org.apache.http.ConnectionReuseStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _setReuseStrategy26064;
		public virtual void setReuseStrategy(org.apache.http.ConnectionReuseStrategy arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setReuseStrategy26064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setReuseStrategy26064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionKeepAliveStrategy26065;
		public virtual global::org.apache.http.conn.ConnectionKeepAliveStrategy getConnectionKeepAliveStrategy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ConnectionKeepAliveStrategy>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getConnectionKeepAliveStrategy26065)) as org.apache.http.conn.ConnectionKeepAliveStrategy;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ConnectionKeepAliveStrategy>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getConnectionKeepAliveStrategy26065)) as org.apache.http.conn.ConnectionKeepAliveStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _setKeepAliveStrategy26066;
		public virtual void setKeepAliveStrategy(org.apache.http.conn.ConnectionKeepAliveStrategy arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setKeepAliveStrategy26066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setKeepAliveStrategy26066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHttpRequestRetryHandler26067;
		public virtual global::org.apache.http.client.HttpRequestRetryHandler getHttpRequestRetryHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.HttpRequestRetryHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getHttpRequestRetryHandler26067)) as org.apache.http.client.HttpRequestRetryHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.HttpRequestRetryHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getHttpRequestRetryHandler26067)) as org.apache.http.client.HttpRequestRetryHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setHttpRequestRetryHandler26068;
		public virtual void setHttpRequestRetryHandler(org.apache.http.client.HttpRequestRetryHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setHttpRequestRetryHandler26068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setHttpRequestRetryHandler26068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRedirectHandler26069;
		public virtual global::org.apache.http.client.RedirectHandler getRedirectHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RedirectHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getRedirectHandler26069)) as org.apache.http.client.RedirectHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RedirectHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getRedirectHandler26069)) as org.apache.http.client.RedirectHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setRedirectHandler26070;
		public virtual void setRedirectHandler(org.apache.http.client.RedirectHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setRedirectHandler26070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setRedirectHandler26070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTargetAuthenticationHandler26071;
		public virtual global::org.apache.http.client.AuthenticationHandler getTargetAuthenticationHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getTargetAuthenticationHandler26071)) as org.apache.http.client.AuthenticationHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getTargetAuthenticationHandler26071)) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setTargetAuthenticationHandler26072;
		public virtual void setTargetAuthenticationHandler(org.apache.http.client.AuthenticationHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setTargetAuthenticationHandler26072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setTargetAuthenticationHandler26072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getProxyAuthenticationHandler26073;
		public virtual global::org.apache.http.client.AuthenticationHandler getProxyAuthenticationHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getProxyAuthenticationHandler26073)) as org.apache.http.client.AuthenticationHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getProxyAuthenticationHandler26073)) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setProxyAuthenticationHandler26074;
		public virtual void setProxyAuthenticationHandler(org.apache.http.client.AuthenticationHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setProxyAuthenticationHandler26074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setProxyAuthenticationHandler26074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCookieStore26075;
		public virtual global::org.apache.http.client.CookieStore getCookieStore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CookieStore>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getCookieStore26075)) as org.apache.http.client.CookieStore;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CookieStore>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getCookieStore26075)) as org.apache.http.client.CookieStore;
		}
		internal static global::MonoJavaBridge.MethodId _getCredentialsProvider26076;
		public virtual global::org.apache.http.client.CredentialsProvider getCredentialsProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CredentialsProvider>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getCredentialsProvider26076)) as org.apache.http.client.CredentialsProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CredentialsProvider>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getCredentialsProvider26076)) as org.apache.http.client.CredentialsProvider;
		}
		internal static global::MonoJavaBridge.MethodId _getRoutePlanner26077;
		public virtual global::org.apache.http.conn.routing.HttpRoutePlanner getRoutePlanner() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.routing.HttpRoutePlanner>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getRoutePlanner26077)) as org.apache.http.conn.routing.HttpRoutePlanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.routing.HttpRoutePlanner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getRoutePlanner26077)) as org.apache.http.conn.routing.HttpRoutePlanner;
		}
		internal static global::MonoJavaBridge.MethodId _setRoutePlanner26078;
		public virtual void setRoutePlanner(org.apache.http.conn.routing.HttpRoutePlanner arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setRoutePlanner26078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setRoutePlanner26078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUserTokenHandler26079;
		public virtual global::org.apache.http.client.UserTokenHandler getUserTokenHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.UserTokenHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getUserTokenHandler26079)) as org.apache.http.client.UserTokenHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.UserTokenHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getUserTokenHandler26079)) as org.apache.http.client.UserTokenHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setUserTokenHandler26080;
		public virtual void setUserTokenHandler(org.apache.http.client.UserTokenHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setUserTokenHandler26080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setUserTokenHandler26080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHttpProcessor26081;
		protected virtual global::org.apache.http.protocol.BasicHttpProcessor getHttpProcessor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getHttpProcessor26081)) as org.apache.http.protocol.BasicHttpProcessor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getHttpProcessor26081)) as org.apache.http.protocol.BasicHttpProcessor;
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor26082;
		public virtual void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._addResponseInterceptor26082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._addResponseInterceptor26082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor26083;
		public virtual void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._addResponseInterceptor26083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._addResponseInterceptor26083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptor26084;
		public virtual global::org.apache.http.HttpResponseInterceptor getResponseInterceptor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseInterceptor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getResponseInterceptor26084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponseInterceptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseInterceptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getResponseInterceptor26084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponseInterceptor;
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptorCount26085;
		public virtual int getResponseInterceptorCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getResponseInterceptorCount26085);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getResponseInterceptorCount26085);
		}
		internal static global::MonoJavaBridge.MethodId _clearResponseInterceptors26086;
		public virtual void clearResponseInterceptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._clearResponseInterceptors26086);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._clearResponseInterceptors26086);
		}
		internal static global::MonoJavaBridge.MethodId _removeResponseInterceptorByClass26087;
		public virtual void removeResponseInterceptorByClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._removeResponseInterceptorByClass26087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._removeResponseInterceptorByClass26087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor26088;
		public virtual void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._addRequestInterceptor26088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._addRequestInterceptor26088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor26089;
		public virtual void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._addRequestInterceptor26089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._addRequestInterceptor26089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptor26090;
		public virtual global::org.apache.http.HttpRequestInterceptor getRequestInterceptor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequestInterceptor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getRequestInterceptor26090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequestInterceptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequestInterceptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getRequestInterceptor26090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequestInterceptor;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptorCount26091;
		public virtual int getRequestInterceptorCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getRequestInterceptorCount26091);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getRequestInterceptorCount26091);
		}
		internal static global::MonoJavaBridge.MethodId _clearRequestInterceptors26092;
		public virtual void clearRequestInterceptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._clearRequestInterceptors26092);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._clearRequestInterceptors26092);
		}
		internal static global::MonoJavaBridge.MethodId _removeRequestInterceptorByClass26093;
		public virtual void removeRequestInterceptorByClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._removeRequestInterceptorByClass26093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._removeRequestInterceptorByClass26093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createClientRequestDirector26094;
		protected virtual global::org.apache.http.client.RequestDirector createClientRequestDirector(org.apache.http.protocol.HttpRequestExecutor arg0, org.apache.http.conn.ClientConnectionManager arg1, org.apache.http.ConnectionReuseStrategy arg2, org.apache.http.conn.ConnectionKeepAliveStrategy arg3, org.apache.http.conn.routing.HttpRoutePlanner arg4, org.apache.http.protocol.HttpProcessor arg5, org.apache.http.client.HttpRequestRetryHandler arg6, org.apache.http.client.RedirectHandler arg7, org.apache.http.client.AuthenticationHandler arg8, org.apache.http.client.AuthenticationHandler arg9, org.apache.http.client.UserTokenHandler arg10, org.apache.http.@params.HttpParams arg11) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RequestDirector>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._createClientRequestDirector26094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11))) as org.apache.http.client.RequestDirector;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RequestDirector>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._createClientRequestDirector26094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11))) as org.apache.http.client.RequestDirector;
		}
		internal static global::MonoJavaBridge.MethodId _determineParams26095;
		protected virtual global::org.apache.http.@params.HttpParams determineParams(org.apache.http.HttpRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._determineParams26095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._determineParams26095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpClient26096;
		protected AbstractHttpClient(org.apache.http.conn.ClientConnectionManager arg0, org.apache.http.@params.HttpParams arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._AbstractHttpClient26096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.AbstractHttpClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/AbstractHttpClient"));
			global::org.apache.http.impl.client.AbstractHttpClient._getParams26028 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.impl.client.AbstractHttpClient._setParams26029 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setParams", "(Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._execute26030 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.client.AbstractHttpClient._execute26031 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.client.AbstractHttpClient._execute26032 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseHandler;)Ljava/lang/Object;");
			global::org.apache.http.impl.client.AbstractHttpClient._execute26033 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/ResponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;");
			global::org.apache.http.impl.client.AbstractHttpClient._execute26034 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;");
			global::org.apache.http.impl.client.AbstractHttpClient._execute26035 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/ResponseHandler;)Ljava/lang/Object;");
			global::org.apache.http.impl.client.AbstractHttpClient._execute26036 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.client.AbstractHttpClient._execute26037 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.client.AbstractHttpClient._getConnectionManager26038 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
			global::org.apache.http.impl.client.AbstractHttpClient._setCookieStore26039 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setCookieStore", "(Lorg/apache/http/client/CookieStore;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._setCredentialsProvider26040 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setCredentialsProvider", "(Lorg/apache/http/client/CredentialsProvider;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._createHttpParams26041 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createHttpParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.impl.client.AbstractHttpClient._createHttpContext26042 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createHttpContext", "()Lorg/apache/http/protocol/HttpContext;");
			global::org.apache.http.impl.client.AbstractHttpClient._createRequestExecutor26043 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;");
			global::org.apache.http.impl.client.AbstractHttpClient._createClientConnectionManager26044 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createClientConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
			global::org.apache.http.impl.client.AbstractHttpClient._createAuthSchemeRegistry26045 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createAuthSchemeRegistry", "()Lorg/apache/http/auth/AuthSchemeRegistry;");
			global::org.apache.http.impl.client.AbstractHttpClient._createCookieSpecRegistry26046 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createCookieSpecRegistry", "()Lorg/apache/http/cookie/CookieSpecRegistry;");
			global::org.apache.http.impl.client.AbstractHttpClient._createConnectionReuseStrategy26047 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;");
			global::org.apache.http.impl.client.AbstractHttpClient._createConnectionKeepAliveStrategy26048 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;");
			global::org.apache.http.impl.client.AbstractHttpClient._createHttpProcessor26049 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;");
			global::org.apache.http.impl.client.AbstractHttpClient._createHttpRequestRetryHandler26050 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._createRedirectHandler26051 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._createTargetAuthenticationHandler26052 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._createProxyAuthenticationHandler26053 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._createCookieStore26054 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createCookieStore", "()Lorg/apache/http/client/CookieStore;");
			global::org.apache.http.impl.client.AbstractHttpClient._createCredentialsProvider26055 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;");
			global::org.apache.http.impl.client.AbstractHttpClient._createHttpRoutePlanner26056 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createHttpRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;");
			global::org.apache.http.impl.client.AbstractHttpClient._createUserTokenHandler26057 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._getRequestExecutor26058 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;");
			global::org.apache.http.impl.client.AbstractHttpClient._getAuthSchemes26059 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getAuthSchemes", "()Lorg/apache/http/auth/AuthSchemeRegistry;");
			global::org.apache.http.impl.client.AbstractHttpClient._setAuthSchemes26060 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setAuthSchemes", "(Lorg/apache/http/auth/AuthSchemeRegistry;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getCookieSpecs26061 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getCookieSpecs", "()Lorg/apache/http/cookie/CookieSpecRegistry;");
			global::org.apache.http.impl.client.AbstractHttpClient._setCookieSpecs26062 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setCookieSpecs", "(Lorg/apache/http/cookie/CookieSpecRegistry;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getConnectionReuseStrategy26063 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;");
			global::org.apache.http.impl.client.AbstractHttpClient._setReuseStrategy26064 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setReuseStrategy", "(Lorg/apache/http/ConnectionReuseStrategy;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getConnectionKeepAliveStrategy26065 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;");
			global::org.apache.http.impl.client.AbstractHttpClient._setKeepAliveStrategy26066 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setKeepAliveStrategy", "(Lorg/apache/http/conn/ConnectionKeepAliveStrategy;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getHttpRequestRetryHandler26067 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._setHttpRequestRetryHandler26068 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setHttpRequestRetryHandler", "(Lorg/apache/http/client/HttpRequestRetryHandler;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getRedirectHandler26069 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._setRedirectHandler26070 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setRedirectHandler", "(Lorg/apache/http/client/RedirectHandler;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getTargetAuthenticationHandler26071 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._setTargetAuthenticationHandler26072 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setTargetAuthenticationHandler", "(Lorg/apache/http/client/AuthenticationHandler;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getProxyAuthenticationHandler26073 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._setProxyAuthenticationHandler26074 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setProxyAuthenticationHandler", "(Lorg/apache/http/client/AuthenticationHandler;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getCookieStore26075 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getCookieStore", "()Lorg/apache/http/client/CookieStore;");
			global::org.apache.http.impl.client.AbstractHttpClient._getCredentialsProvider26076 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;");
			global::org.apache.http.impl.client.AbstractHttpClient._getRoutePlanner26077 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;");
			global::org.apache.http.impl.client.AbstractHttpClient._setRoutePlanner26078 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setRoutePlanner", "(Lorg/apache/http/conn/routing/HttpRoutePlanner;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getUserTokenHandler26079 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._setUserTokenHandler26080 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setUserTokenHandler", "(Lorg/apache/http/client/UserTokenHandler;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getHttpProcessor26081 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;");
			global::org.apache.http.impl.client.AbstractHttpClient._addResponseInterceptor26082 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._addResponseInterceptor26083 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getResponseInterceptor26084 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getResponseInterceptor", "(I)Lorg/apache/http/HttpResponseInterceptor;");
			global::org.apache.http.impl.client.AbstractHttpClient._getResponseInterceptorCount26085 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getResponseInterceptorCount", "()I");
			global::org.apache.http.impl.client.AbstractHttpClient._clearResponseInterceptors26086 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "clearResponseInterceptors", "()V");
			global::org.apache.http.impl.client.AbstractHttpClient._removeResponseInterceptorByClass26087 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "removeResponseInterceptorByClass", "(Ljava/lang/Class;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._addRequestInterceptor26088 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V");
			global::org.apache.http.impl.client.AbstractHttpClient._addRequestInterceptor26089 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getRequestInterceptor26090 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getRequestInterceptor", "(I)Lorg/apache/http/HttpRequestInterceptor;");
			global::org.apache.http.impl.client.AbstractHttpClient._getRequestInterceptorCount26091 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getRequestInterceptorCount", "()I");
			global::org.apache.http.impl.client.AbstractHttpClient._clearRequestInterceptors26092 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "clearRequestInterceptors", "()V");
			global::org.apache.http.impl.client.AbstractHttpClient._removeRequestInterceptorByClass26093 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "removeRequestInterceptorByClass", "(Ljava/lang/Class;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._createClientRequestDirector26094 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createClientRequestDirector", "(Lorg/apache/http/protocol/HttpRequestExecutor;Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/ConnectionReuseStrategy;Lorg/apache/http/conn/ConnectionKeepAliveStrategy;Lorg/apache/http/conn/routing/HttpRoutePlanner;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/client/HttpRequestRetryHandler;Lorg/apache/http/client/RedirectHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/UserTokenHandler;Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/client/RequestDirector;");
			global::org.apache.http.impl.client.AbstractHttpClient._determineParams26095 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "determineParams", "(Lorg/apache/http/HttpRequest;)Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.impl.client.AbstractHttpClient._AbstractHttpClient26096 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/@params/HttpParams;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.client.AbstractHttpClient))]
	public sealed partial class AbstractHttpClient_ : org.apache.http.impl.client.AbstractHttpClient
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpClient_()
		{
			InitJNI();
		}
		internal AbstractHttpClient_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createHttpParams26097;
		protected override global::org.apache.http.@params.HttpParams createHttpParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpParams26097)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpParams26097)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpContext26098;
		protected override global::org.apache.http.protocol.HttpContext createHttpContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.protocol.HttpContext>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpContext26098)) as org.apache.http.protocol.HttpContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.protocol.HttpContext>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpContext26098)) as org.apache.http.protocol.HttpContext;
		}
		internal static global::MonoJavaBridge.MethodId _createRequestExecutor26099;
		protected override global::org.apache.http.protocol.HttpRequestExecutor createRequestExecutor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createRequestExecutor26099)) as org.apache.http.protocol.HttpRequestExecutor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createRequestExecutor26099)) as org.apache.http.protocol.HttpRequestExecutor;
		}
		internal static global::MonoJavaBridge.MethodId _createClientConnectionManager26100;
		protected override global::org.apache.http.conn.ClientConnectionManager createClientConnectionManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createClientConnectionManager26100)) as org.apache.http.conn.ClientConnectionManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createClientConnectionManager26100)) as org.apache.http.conn.ClientConnectionManager;
		}
		internal static global::MonoJavaBridge.MethodId _createAuthSchemeRegistry26101;
		protected override global::org.apache.http.auth.AuthSchemeRegistry createAuthSchemeRegistry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createAuthSchemeRegistry26101)) as org.apache.http.auth.AuthSchemeRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createAuthSchemeRegistry26101)) as org.apache.http.auth.AuthSchemeRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _createCookieSpecRegistry26102;
		protected override global::org.apache.http.cookie.CookieSpecRegistry createCookieSpecRegistry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createCookieSpecRegistry26102)) as org.apache.http.cookie.CookieSpecRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createCookieSpecRegistry26102)) as org.apache.http.cookie.CookieSpecRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionReuseStrategy26103;
		protected override global::org.apache.http.ConnectionReuseStrategy createConnectionReuseStrategy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.ConnectionReuseStrategy>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createConnectionReuseStrategy26103)) as org.apache.http.ConnectionReuseStrategy;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.ConnectionReuseStrategy>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createConnectionReuseStrategy26103)) as org.apache.http.ConnectionReuseStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionKeepAliveStrategy26104;
		protected override global::org.apache.http.conn.ConnectionKeepAliveStrategy createConnectionKeepAliveStrategy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ConnectionKeepAliveStrategy>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createConnectionKeepAliveStrategy26104)) as org.apache.http.conn.ConnectionKeepAliveStrategy;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ConnectionKeepAliveStrategy>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createConnectionKeepAliveStrategy26104)) as org.apache.http.conn.ConnectionKeepAliveStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpProcessor26105;
		protected override global::org.apache.http.protocol.BasicHttpProcessor createHttpProcessor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpProcessor26105)) as org.apache.http.protocol.BasicHttpProcessor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpProcessor26105)) as org.apache.http.protocol.BasicHttpProcessor;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpRequestRetryHandler26106;
		protected override global::org.apache.http.client.HttpRequestRetryHandler createHttpRequestRetryHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.HttpRequestRetryHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpRequestRetryHandler26106)) as org.apache.http.client.HttpRequestRetryHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.HttpRequestRetryHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpRequestRetryHandler26106)) as org.apache.http.client.HttpRequestRetryHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createRedirectHandler26107;
		protected override global::org.apache.http.client.RedirectHandler createRedirectHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RedirectHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createRedirectHandler26107)) as org.apache.http.client.RedirectHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RedirectHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createRedirectHandler26107)) as org.apache.http.client.RedirectHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createTargetAuthenticationHandler26108;
		protected override global::org.apache.http.client.AuthenticationHandler createTargetAuthenticationHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createTargetAuthenticationHandler26108)) as org.apache.http.client.AuthenticationHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createTargetAuthenticationHandler26108)) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createProxyAuthenticationHandler26109;
		protected override global::org.apache.http.client.AuthenticationHandler createProxyAuthenticationHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createProxyAuthenticationHandler26109)) as org.apache.http.client.AuthenticationHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createProxyAuthenticationHandler26109)) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createCookieStore26110;
		protected override global::org.apache.http.client.CookieStore createCookieStore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CookieStore>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createCookieStore26110)) as org.apache.http.client.CookieStore;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CookieStore>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createCookieStore26110)) as org.apache.http.client.CookieStore;
		}
		internal static global::MonoJavaBridge.MethodId _createCredentialsProvider26111;
		protected override global::org.apache.http.client.CredentialsProvider createCredentialsProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CredentialsProvider>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createCredentialsProvider26111)) as org.apache.http.client.CredentialsProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CredentialsProvider>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createCredentialsProvider26111)) as org.apache.http.client.CredentialsProvider;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpRoutePlanner26112;
		protected override global::org.apache.http.conn.routing.HttpRoutePlanner createHttpRoutePlanner() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.routing.HttpRoutePlanner>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpRoutePlanner26112)) as org.apache.http.conn.routing.HttpRoutePlanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.routing.HttpRoutePlanner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpRoutePlanner26112)) as org.apache.http.conn.routing.HttpRoutePlanner;
		}
		internal static global::MonoJavaBridge.MethodId _createUserTokenHandler26113;
		protected override global::org.apache.http.client.UserTokenHandler createUserTokenHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.UserTokenHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createUserTokenHandler26113)) as org.apache.http.client.UserTokenHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.UserTokenHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createUserTokenHandler26113)) as org.apache.http.client.UserTokenHandler;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.AbstractHttpClient_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/AbstractHttpClient"));
			global::org.apache.http.impl.client.AbstractHttpClient_._createHttpParams26097 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createHttpParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createHttpContext26098 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createHttpContext", "()Lorg/apache/http/protocol/HttpContext;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createRequestExecutor26099 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createClientConnectionManager26100 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createClientConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createAuthSchemeRegistry26101 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createAuthSchemeRegistry", "()Lorg/apache/http/auth/AuthSchemeRegistry;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createCookieSpecRegistry26102 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createCookieSpecRegistry", "()Lorg/apache/http/cookie/CookieSpecRegistry;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createConnectionReuseStrategy26103 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createConnectionKeepAliveStrategy26104 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createHttpProcessor26105 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createHttpRequestRetryHandler26106 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createRedirectHandler26107 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createTargetAuthenticationHandler26108 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createProxyAuthenticationHandler26109 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createCookieStore26110 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createCookieStore", "()Lorg/apache/http/client/CookieStore;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createCredentialsProvider26111 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createHttpRoutePlanner26112 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createHttpRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createUserTokenHandler26113 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;");
		}
	}
}
