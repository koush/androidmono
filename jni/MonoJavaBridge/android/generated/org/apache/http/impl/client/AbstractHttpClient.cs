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
		internal static global::MonoJavaBridge.MethodId _getParams32769;
		public virtual global::org.apache.http.@params.HttpParams getParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getParams32769)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getParams32769)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams32770;
		public virtual void setParams(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setParams32770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setParams32770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _execute32771;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute32771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute32771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute32772;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute32772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute32772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute32773;
		public virtual global::java.lang.Object execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute32773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute32773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute32774;
		public virtual global::java.lang.Object execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2, org.apache.http.protocol.HttpContext arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute32774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute32774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute32775;
		public virtual global::java.lang.Object execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute32775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute32775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute32776;
		public virtual global::java.lang.Object execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute32776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute32776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute32777;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.client.methods.HttpUriRequest arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute32777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute32777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute32778;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._execute32778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._execute32778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionManager32779;
		public virtual global::org.apache.http.conn.ClientConnectionManager getConnectionManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getConnectionManager32779)) as org.apache.http.conn.ClientConnectionManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getConnectionManager32779)) as org.apache.http.conn.ClientConnectionManager;
		}
		internal static global::MonoJavaBridge.MethodId _setCookieStore32780;
		public virtual void setCookieStore(org.apache.http.client.CookieStore arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setCookieStore32780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setCookieStore32780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCredentialsProvider32781;
		public virtual void setCredentialsProvider(org.apache.http.client.CredentialsProvider arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setCredentialsProvider32781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setCredentialsProvider32781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createHttpParams32782;
		protected abstract global::org.apache.http.@params.HttpParams createHttpParams();
		internal static global::MonoJavaBridge.MethodId _createHttpContext32783;
		protected abstract global::org.apache.http.protocol.HttpContext createHttpContext();
		internal static global::MonoJavaBridge.MethodId _createRequestExecutor32784;
		protected abstract global::org.apache.http.protocol.HttpRequestExecutor createRequestExecutor();
		internal static global::MonoJavaBridge.MethodId _createClientConnectionManager32785;
		protected abstract global::org.apache.http.conn.ClientConnectionManager createClientConnectionManager();
		internal static global::MonoJavaBridge.MethodId _createAuthSchemeRegistry32786;
		protected abstract global::org.apache.http.auth.AuthSchemeRegistry createAuthSchemeRegistry();
		internal static global::MonoJavaBridge.MethodId _createCookieSpecRegistry32787;
		protected abstract global::org.apache.http.cookie.CookieSpecRegistry createCookieSpecRegistry();
		internal static global::MonoJavaBridge.MethodId _createConnectionReuseStrategy32788;
		protected abstract global::org.apache.http.ConnectionReuseStrategy createConnectionReuseStrategy();
		internal static global::MonoJavaBridge.MethodId _createConnectionKeepAliveStrategy32789;
		protected abstract global::org.apache.http.conn.ConnectionKeepAliveStrategy createConnectionKeepAliveStrategy();
		internal static global::MonoJavaBridge.MethodId _createHttpProcessor32790;
		protected abstract global::org.apache.http.protocol.BasicHttpProcessor createHttpProcessor();
		internal static global::MonoJavaBridge.MethodId _createHttpRequestRetryHandler32791;
		protected abstract global::org.apache.http.client.HttpRequestRetryHandler createHttpRequestRetryHandler();
		internal static global::MonoJavaBridge.MethodId _createRedirectHandler32792;
		protected abstract global::org.apache.http.client.RedirectHandler createRedirectHandler();
		internal static global::MonoJavaBridge.MethodId _createTargetAuthenticationHandler32793;
		protected abstract global::org.apache.http.client.AuthenticationHandler createTargetAuthenticationHandler();
		internal static global::MonoJavaBridge.MethodId _createProxyAuthenticationHandler32794;
		protected abstract global::org.apache.http.client.AuthenticationHandler createProxyAuthenticationHandler();
		internal static global::MonoJavaBridge.MethodId _createCookieStore32795;
		protected abstract global::org.apache.http.client.CookieStore createCookieStore();
		internal static global::MonoJavaBridge.MethodId _createCredentialsProvider32796;
		protected abstract global::org.apache.http.client.CredentialsProvider createCredentialsProvider();
		internal static global::MonoJavaBridge.MethodId _createHttpRoutePlanner32797;
		protected abstract global::org.apache.http.conn.routing.HttpRoutePlanner createHttpRoutePlanner();
		internal static global::MonoJavaBridge.MethodId _createUserTokenHandler32798;
		protected abstract global::org.apache.http.client.UserTokenHandler createUserTokenHandler();
		internal static global::MonoJavaBridge.MethodId _getRequestExecutor32799;
		public virtual global::org.apache.http.protocol.HttpRequestExecutor getRequestExecutor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getRequestExecutor32799)) as org.apache.http.protocol.HttpRequestExecutor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getRequestExecutor32799)) as org.apache.http.protocol.HttpRequestExecutor;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthSchemes32800;
		public virtual global::org.apache.http.auth.AuthSchemeRegistry getAuthSchemes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.auth.AuthSchemeRegistry>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getAuthSchemes32800)) as org.apache.http.auth.AuthSchemeRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.auth.AuthSchemeRegistry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getAuthSchemes32800)) as org.apache.http.auth.AuthSchemeRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _setAuthSchemes32801;
		public virtual void setAuthSchemes(org.apache.http.auth.AuthSchemeRegistry arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setAuthSchemes32801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setAuthSchemes32801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCookieSpecs32802;
		public virtual global::org.apache.http.cookie.CookieSpecRegistry getCookieSpecs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.cookie.CookieSpecRegistry>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getCookieSpecs32802)) as org.apache.http.cookie.CookieSpecRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.cookie.CookieSpecRegistry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getCookieSpecs32802)) as org.apache.http.cookie.CookieSpecRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _setCookieSpecs32803;
		public virtual void setCookieSpecs(org.apache.http.cookie.CookieSpecRegistry arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setCookieSpecs32803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setCookieSpecs32803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionReuseStrategy32804;
		public virtual global::org.apache.http.ConnectionReuseStrategy getConnectionReuseStrategy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.ConnectionReuseStrategy>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getConnectionReuseStrategy32804)) as org.apache.http.ConnectionReuseStrategy;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.ConnectionReuseStrategy>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getConnectionReuseStrategy32804)) as org.apache.http.ConnectionReuseStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _setReuseStrategy32805;
		public virtual void setReuseStrategy(org.apache.http.ConnectionReuseStrategy arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setReuseStrategy32805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setReuseStrategy32805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionKeepAliveStrategy32806;
		public virtual global::org.apache.http.conn.ConnectionKeepAliveStrategy getConnectionKeepAliveStrategy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ConnectionKeepAliveStrategy>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getConnectionKeepAliveStrategy32806)) as org.apache.http.conn.ConnectionKeepAliveStrategy;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ConnectionKeepAliveStrategy>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getConnectionKeepAliveStrategy32806)) as org.apache.http.conn.ConnectionKeepAliveStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _setKeepAliveStrategy32807;
		public virtual void setKeepAliveStrategy(org.apache.http.conn.ConnectionKeepAliveStrategy arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setKeepAliveStrategy32807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setKeepAliveStrategy32807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHttpRequestRetryHandler32808;
		public virtual global::org.apache.http.client.HttpRequestRetryHandler getHttpRequestRetryHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.HttpRequestRetryHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getHttpRequestRetryHandler32808)) as org.apache.http.client.HttpRequestRetryHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.HttpRequestRetryHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getHttpRequestRetryHandler32808)) as org.apache.http.client.HttpRequestRetryHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setHttpRequestRetryHandler32809;
		public virtual void setHttpRequestRetryHandler(org.apache.http.client.HttpRequestRetryHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setHttpRequestRetryHandler32809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setHttpRequestRetryHandler32809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRedirectHandler32810;
		public virtual global::org.apache.http.client.RedirectHandler getRedirectHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RedirectHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getRedirectHandler32810)) as org.apache.http.client.RedirectHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RedirectHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getRedirectHandler32810)) as org.apache.http.client.RedirectHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setRedirectHandler32811;
		public virtual void setRedirectHandler(org.apache.http.client.RedirectHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setRedirectHandler32811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setRedirectHandler32811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTargetAuthenticationHandler32812;
		public virtual global::org.apache.http.client.AuthenticationHandler getTargetAuthenticationHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getTargetAuthenticationHandler32812)) as org.apache.http.client.AuthenticationHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getTargetAuthenticationHandler32812)) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setTargetAuthenticationHandler32813;
		public virtual void setTargetAuthenticationHandler(org.apache.http.client.AuthenticationHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setTargetAuthenticationHandler32813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setTargetAuthenticationHandler32813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getProxyAuthenticationHandler32814;
		public virtual global::org.apache.http.client.AuthenticationHandler getProxyAuthenticationHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getProxyAuthenticationHandler32814)) as org.apache.http.client.AuthenticationHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getProxyAuthenticationHandler32814)) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setProxyAuthenticationHandler32815;
		public virtual void setProxyAuthenticationHandler(org.apache.http.client.AuthenticationHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setProxyAuthenticationHandler32815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setProxyAuthenticationHandler32815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCookieStore32816;
		public virtual global::org.apache.http.client.CookieStore getCookieStore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CookieStore>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getCookieStore32816)) as org.apache.http.client.CookieStore;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CookieStore>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getCookieStore32816)) as org.apache.http.client.CookieStore;
		}
		internal static global::MonoJavaBridge.MethodId _getCredentialsProvider32817;
		public virtual global::org.apache.http.client.CredentialsProvider getCredentialsProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CredentialsProvider>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getCredentialsProvider32817)) as org.apache.http.client.CredentialsProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CredentialsProvider>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getCredentialsProvider32817)) as org.apache.http.client.CredentialsProvider;
		}
		internal static global::MonoJavaBridge.MethodId _getRoutePlanner32818;
		public virtual global::org.apache.http.conn.routing.HttpRoutePlanner getRoutePlanner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.routing.HttpRoutePlanner>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getRoutePlanner32818)) as org.apache.http.conn.routing.HttpRoutePlanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.routing.HttpRoutePlanner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getRoutePlanner32818)) as org.apache.http.conn.routing.HttpRoutePlanner;
		}
		internal static global::MonoJavaBridge.MethodId _setRoutePlanner32819;
		public virtual void setRoutePlanner(org.apache.http.conn.routing.HttpRoutePlanner arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setRoutePlanner32819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setRoutePlanner32819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUserTokenHandler32820;
		public virtual global::org.apache.http.client.UserTokenHandler getUserTokenHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.UserTokenHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getUserTokenHandler32820)) as org.apache.http.client.UserTokenHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.UserTokenHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getUserTokenHandler32820)) as org.apache.http.client.UserTokenHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setUserTokenHandler32821;
		public virtual void setUserTokenHandler(org.apache.http.client.UserTokenHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._setUserTokenHandler32821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._setUserTokenHandler32821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHttpProcessor32822;
		protected virtual global::org.apache.http.protocol.BasicHttpProcessor getHttpProcessor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.protocol.BasicHttpProcessor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getHttpProcessor32822)) as org.apache.http.protocol.BasicHttpProcessor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.protocol.BasicHttpProcessor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getHttpProcessor32822)) as org.apache.http.protocol.BasicHttpProcessor;
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor32823;
		public virtual void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._addResponseInterceptor32823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._addResponseInterceptor32823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor32824;
		public virtual void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._addResponseInterceptor32824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._addResponseInterceptor32824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptor32825;
		public virtual global::org.apache.http.HttpResponseInterceptor getResponseInterceptor(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseInterceptor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getResponseInterceptor32825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponseInterceptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseInterceptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getResponseInterceptor32825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponseInterceptor;
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptorCount32826;
		public virtual int getResponseInterceptorCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getResponseInterceptorCount32826);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getResponseInterceptorCount32826);
		}
		internal static global::MonoJavaBridge.MethodId _clearResponseInterceptors32827;
		public virtual void clearResponseInterceptors()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._clearResponseInterceptors32827);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._clearResponseInterceptors32827);
		}
		internal static global::MonoJavaBridge.MethodId _removeResponseInterceptorByClass32828;
		public virtual void removeResponseInterceptorByClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._removeResponseInterceptorByClass32828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._removeResponseInterceptorByClass32828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor32829;
		public virtual void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._addRequestInterceptor32829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._addRequestInterceptor32829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor32830;
		public virtual void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._addRequestInterceptor32830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._addRequestInterceptor32830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptor32831;
		public virtual global::org.apache.http.HttpRequestInterceptor getRequestInterceptor(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequestInterceptor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getRequestInterceptor32831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequestInterceptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequestInterceptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getRequestInterceptor32831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequestInterceptor;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptorCount32832;
		public virtual int getRequestInterceptorCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._getRequestInterceptorCount32832);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._getRequestInterceptorCount32832);
		}
		internal static global::MonoJavaBridge.MethodId _clearRequestInterceptors32833;
		public virtual void clearRequestInterceptors()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._clearRequestInterceptors32833);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._clearRequestInterceptors32833);
		}
		internal static global::MonoJavaBridge.MethodId _removeRequestInterceptorByClass32834;
		public virtual void removeRequestInterceptorByClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._removeRequestInterceptorByClass32834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._removeRequestInterceptorByClass32834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createClientRequestDirector32835;
		protected virtual global::org.apache.http.client.RequestDirector createClientRequestDirector(org.apache.http.protocol.HttpRequestExecutor arg0, org.apache.http.conn.ClientConnectionManager arg1, org.apache.http.ConnectionReuseStrategy arg2, org.apache.http.conn.ConnectionKeepAliveStrategy arg3, org.apache.http.conn.routing.HttpRoutePlanner arg4, org.apache.http.protocol.HttpProcessor arg5, org.apache.http.client.HttpRequestRetryHandler arg6, org.apache.http.client.RedirectHandler arg7, org.apache.http.client.AuthenticationHandler arg8, org.apache.http.client.AuthenticationHandler arg9, org.apache.http.client.UserTokenHandler arg10, org.apache.http.@params.HttpParams arg11)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RequestDirector>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._createClientRequestDirector32835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11))) as org.apache.http.client.RequestDirector;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RequestDirector>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._createClientRequestDirector32835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11))) as org.apache.http.client.RequestDirector;
		}
		internal static global::MonoJavaBridge.MethodId _determineParams32836;
		protected virtual global::org.apache.http.@params.HttpParams determineParams(org.apache.http.HttpRequest arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient._determineParams32836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._determineParams32836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpClient32837;
		protected AbstractHttpClient(org.apache.http.conn.ClientConnectionManager arg0, org.apache.http.@params.HttpParams arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.AbstractHttpClient.staticClass, global::org.apache.http.impl.client.AbstractHttpClient._AbstractHttpClient32837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.AbstractHttpClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/AbstractHttpClient"));
			global::org.apache.http.impl.client.AbstractHttpClient._getParams32769 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getParams", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.impl.client.AbstractHttpClient._setParams32770 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setParams", "(Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._execute32771 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.client.AbstractHttpClient._execute32772 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.client.AbstractHttpClient._execute32773 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseHandler;)Ljava/lang/Object;");
			global::org.apache.http.impl.client.AbstractHttpClient._execute32774 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/ResponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;");
			global::org.apache.http.impl.client.AbstractHttpClient._execute32775 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;");
			global::org.apache.http.impl.client.AbstractHttpClient._execute32776 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/ResponseHandler;)Ljava/lang/Object;");
			global::org.apache.http.impl.client.AbstractHttpClient._execute32777 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.client.AbstractHttpClient._execute32778 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.client.AbstractHttpClient._getConnectionManager32779 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
			global::org.apache.http.impl.client.AbstractHttpClient._setCookieStore32780 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setCookieStore", "(Lorg/apache/http/client/CookieStore;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._setCredentialsProvider32781 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setCredentialsProvider", "(Lorg/apache/http/client/CredentialsProvider;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._createHttpParams32782 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createHttpParams", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.impl.client.AbstractHttpClient._createHttpContext32783 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createHttpContext", "()Lorg/apache/http/protocol/HttpContext;");
			global::org.apache.http.impl.client.AbstractHttpClient._createRequestExecutor32784 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;");
			global::org.apache.http.impl.client.AbstractHttpClient._createClientConnectionManager32785 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createClientConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
			global::org.apache.http.impl.client.AbstractHttpClient._createAuthSchemeRegistry32786 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createAuthSchemeRegistry", "()Lorg/apache/http/auth/AuthSchemeRegistry;");
			global::org.apache.http.impl.client.AbstractHttpClient._createCookieSpecRegistry32787 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createCookieSpecRegistry", "()Lorg/apache/http/cookie/CookieSpecRegistry;");
			global::org.apache.http.impl.client.AbstractHttpClient._createConnectionReuseStrategy32788 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;");
			global::org.apache.http.impl.client.AbstractHttpClient._createConnectionKeepAliveStrategy32789 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;");
			global::org.apache.http.impl.client.AbstractHttpClient._createHttpProcessor32790 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;");
			global::org.apache.http.impl.client.AbstractHttpClient._createHttpRequestRetryHandler32791 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._createRedirectHandler32792 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._createTargetAuthenticationHandler32793 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._createProxyAuthenticationHandler32794 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._createCookieStore32795 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createCookieStore", "()Lorg/apache/http/client/CookieStore;");
			global::org.apache.http.impl.client.AbstractHttpClient._createCredentialsProvider32796 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;");
			global::org.apache.http.impl.client.AbstractHttpClient._createHttpRoutePlanner32797 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createHttpRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;");
			global::org.apache.http.impl.client.AbstractHttpClient._createUserTokenHandler32798 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._getRequestExecutor32799 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;");
			global::org.apache.http.impl.client.AbstractHttpClient._getAuthSchemes32800 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getAuthSchemes", "()Lorg/apache/http/auth/AuthSchemeRegistry;");
			global::org.apache.http.impl.client.AbstractHttpClient._setAuthSchemes32801 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setAuthSchemes", "(Lorg/apache/http/auth/AuthSchemeRegistry;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getCookieSpecs32802 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getCookieSpecs", "()Lorg/apache/http/cookie/CookieSpecRegistry;");
			global::org.apache.http.impl.client.AbstractHttpClient._setCookieSpecs32803 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setCookieSpecs", "(Lorg/apache/http/cookie/CookieSpecRegistry;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getConnectionReuseStrategy32804 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;");
			global::org.apache.http.impl.client.AbstractHttpClient._setReuseStrategy32805 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setReuseStrategy", "(Lorg/apache/http/ConnectionReuseStrategy;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getConnectionKeepAliveStrategy32806 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;");
			global::org.apache.http.impl.client.AbstractHttpClient._setKeepAliveStrategy32807 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setKeepAliveStrategy", "(Lorg/apache/http/conn/ConnectionKeepAliveStrategy;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getHttpRequestRetryHandler32808 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._setHttpRequestRetryHandler32809 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setHttpRequestRetryHandler", "(Lorg/apache/http/client/HttpRequestRetryHandler;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getRedirectHandler32810 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._setRedirectHandler32811 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setRedirectHandler", "(Lorg/apache/http/client/RedirectHandler;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getTargetAuthenticationHandler32812 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._setTargetAuthenticationHandler32813 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setTargetAuthenticationHandler", "(Lorg/apache/http/client/AuthenticationHandler;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getProxyAuthenticationHandler32814 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._setProxyAuthenticationHandler32815 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setProxyAuthenticationHandler", "(Lorg/apache/http/client/AuthenticationHandler;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getCookieStore32816 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getCookieStore", "()Lorg/apache/http/client/CookieStore;");
			global::org.apache.http.impl.client.AbstractHttpClient._getCredentialsProvider32817 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;");
			global::org.apache.http.impl.client.AbstractHttpClient._getRoutePlanner32818 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;");
			global::org.apache.http.impl.client.AbstractHttpClient._setRoutePlanner32819 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setRoutePlanner", "(Lorg/apache/http/conn/routing/HttpRoutePlanner;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getUserTokenHandler32820 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient._setUserTokenHandler32821 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "setUserTokenHandler", "(Lorg/apache/http/client/UserTokenHandler;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getHttpProcessor32822 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;");
			global::org.apache.http.impl.client.AbstractHttpClient._addResponseInterceptor32823 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._addResponseInterceptor32824 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getResponseInterceptor32825 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getResponseInterceptor", "(I)Lorg/apache/http/HttpResponseInterceptor;");
			global::org.apache.http.impl.client.AbstractHttpClient._getResponseInterceptorCount32826 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getResponseInterceptorCount", "()I");
			global::org.apache.http.impl.client.AbstractHttpClient._clearResponseInterceptors32827 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "clearResponseInterceptors", "()V");
			global::org.apache.http.impl.client.AbstractHttpClient._removeResponseInterceptorByClass32828 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "removeResponseInterceptorByClass", "(Ljava/lang/Class;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._addRequestInterceptor32829 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V");
			global::org.apache.http.impl.client.AbstractHttpClient._addRequestInterceptor32830 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._getRequestInterceptor32831 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getRequestInterceptor", "(I)Lorg/apache/http/HttpRequestInterceptor;");
			global::org.apache.http.impl.client.AbstractHttpClient._getRequestInterceptorCount32832 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "getRequestInterceptorCount", "()I");
			global::org.apache.http.impl.client.AbstractHttpClient._clearRequestInterceptors32833 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "clearRequestInterceptors", "()V");
			global::org.apache.http.impl.client.AbstractHttpClient._removeRequestInterceptorByClass32834 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "removeRequestInterceptorByClass", "(Ljava/lang/Class;)V");
			global::org.apache.http.impl.client.AbstractHttpClient._createClientRequestDirector32835 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "createClientRequestDirector", "(Lorg/apache/http/protocol/HttpRequestExecutor;Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/ConnectionReuseStrategy;Lorg/apache/http/conn/ConnectionKeepAliveStrategy;Lorg/apache/http/conn/routing/HttpRoutePlanner;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/client/HttpRequestRetryHandler;Lorg/apache/http/client/RedirectHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/UserTokenHandler;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/client/RequestDirector;");
			global::org.apache.http.impl.client.AbstractHttpClient._determineParams32836 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "determineParams", "(Lorg/apache/http/HttpRequest;)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.impl.client.AbstractHttpClient._AbstractHttpClient32837 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/params/HttpParams;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.client.AbstractHttpClient))]
	internal sealed partial class AbstractHttpClient_ : org.apache.http.impl.client.AbstractHttpClient
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpClient_()
		{
			InitJNI();
		}
		internal AbstractHttpClient_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createHttpParams32838;
		protected override global::org.apache.http.@params.HttpParams createHttpParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpParams32838)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpParams32838)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpContext32839;
		protected override global::org.apache.http.protocol.HttpContext createHttpContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.protocol.HttpContext>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpContext32839)) as org.apache.http.protocol.HttpContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.protocol.HttpContext>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpContext32839)) as org.apache.http.protocol.HttpContext;
		}
		internal static global::MonoJavaBridge.MethodId _createRequestExecutor32840;
		protected override global::org.apache.http.protocol.HttpRequestExecutor createRequestExecutor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createRequestExecutor32840)) as org.apache.http.protocol.HttpRequestExecutor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createRequestExecutor32840)) as org.apache.http.protocol.HttpRequestExecutor;
		}
		internal static global::MonoJavaBridge.MethodId _createClientConnectionManager32841;
		protected override global::org.apache.http.conn.ClientConnectionManager createClientConnectionManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createClientConnectionManager32841)) as org.apache.http.conn.ClientConnectionManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createClientConnectionManager32841)) as org.apache.http.conn.ClientConnectionManager;
		}
		internal static global::MonoJavaBridge.MethodId _createAuthSchemeRegistry32842;
		protected override global::org.apache.http.auth.AuthSchemeRegistry createAuthSchemeRegistry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.auth.AuthSchemeRegistry>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createAuthSchemeRegistry32842)) as org.apache.http.auth.AuthSchemeRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.auth.AuthSchemeRegistry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createAuthSchemeRegistry32842)) as org.apache.http.auth.AuthSchemeRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _createCookieSpecRegistry32843;
		protected override global::org.apache.http.cookie.CookieSpecRegistry createCookieSpecRegistry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.cookie.CookieSpecRegistry>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createCookieSpecRegistry32843)) as org.apache.http.cookie.CookieSpecRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.cookie.CookieSpecRegistry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createCookieSpecRegistry32843)) as org.apache.http.cookie.CookieSpecRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionReuseStrategy32844;
		protected override global::org.apache.http.ConnectionReuseStrategy createConnectionReuseStrategy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.ConnectionReuseStrategy>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createConnectionReuseStrategy32844)) as org.apache.http.ConnectionReuseStrategy;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.ConnectionReuseStrategy>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createConnectionReuseStrategy32844)) as org.apache.http.ConnectionReuseStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionKeepAliveStrategy32845;
		protected override global::org.apache.http.conn.ConnectionKeepAliveStrategy createConnectionKeepAliveStrategy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ConnectionKeepAliveStrategy>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createConnectionKeepAliveStrategy32845)) as org.apache.http.conn.ConnectionKeepAliveStrategy;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ConnectionKeepAliveStrategy>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createConnectionKeepAliveStrategy32845)) as org.apache.http.conn.ConnectionKeepAliveStrategy;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpProcessor32846;
		protected override global::org.apache.http.protocol.BasicHttpProcessor createHttpProcessor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.protocol.BasicHttpProcessor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpProcessor32846)) as org.apache.http.protocol.BasicHttpProcessor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.protocol.BasicHttpProcessor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpProcessor32846)) as org.apache.http.protocol.BasicHttpProcessor;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpRequestRetryHandler32847;
		protected override global::org.apache.http.client.HttpRequestRetryHandler createHttpRequestRetryHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.HttpRequestRetryHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpRequestRetryHandler32847)) as org.apache.http.client.HttpRequestRetryHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.HttpRequestRetryHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpRequestRetryHandler32847)) as org.apache.http.client.HttpRequestRetryHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createRedirectHandler32848;
		protected override global::org.apache.http.client.RedirectHandler createRedirectHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RedirectHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createRedirectHandler32848)) as org.apache.http.client.RedirectHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.RedirectHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createRedirectHandler32848)) as org.apache.http.client.RedirectHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createTargetAuthenticationHandler32849;
		protected override global::org.apache.http.client.AuthenticationHandler createTargetAuthenticationHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createTargetAuthenticationHandler32849)) as org.apache.http.client.AuthenticationHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createTargetAuthenticationHandler32849)) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createProxyAuthenticationHandler32850;
		protected override global::org.apache.http.client.AuthenticationHandler createProxyAuthenticationHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createProxyAuthenticationHandler32850)) as org.apache.http.client.AuthenticationHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.AuthenticationHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createProxyAuthenticationHandler32850)) as org.apache.http.client.AuthenticationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _createCookieStore32851;
		protected override global::org.apache.http.client.CookieStore createCookieStore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CookieStore>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createCookieStore32851)) as org.apache.http.client.CookieStore;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CookieStore>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createCookieStore32851)) as org.apache.http.client.CookieStore;
		}
		internal static global::MonoJavaBridge.MethodId _createCredentialsProvider32852;
		protected override global::org.apache.http.client.CredentialsProvider createCredentialsProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CredentialsProvider>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createCredentialsProvider32852)) as org.apache.http.client.CredentialsProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.CredentialsProvider>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createCredentialsProvider32852)) as org.apache.http.client.CredentialsProvider;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpRoutePlanner32853;
		protected override global::org.apache.http.conn.routing.HttpRoutePlanner createHttpRoutePlanner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.routing.HttpRoutePlanner>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpRoutePlanner32853)) as org.apache.http.conn.routing.HttpRoutePlanner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.routing.HttpRoutePlanner>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createHttpRoutePlanner32853)) as org.apache.http.conn.routing.HttpRoutePlanner;
		}
		internal static global::MonoJavaBridge.MethodId _createUserTokenHandler32854;
		protected override global::org.apache.http.client.UserTokenHandler createUserTokenHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.UserTokenHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_._createUserTokenHandler32854)) as org.apache.http.client.UserTokenHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.client.UserTokenHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, global::org.apache.http.impl.client.AbstractHttpClient_._createUserTokenHandler32854)) as org.apache.http.client.UserTokenHandler;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.AbstractHttpClient_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/AbstractHttpClient"));
			global::org.apache.http.impl.client.AbstractHttpClient_._createHttpParams32838 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createHttpParams", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createHttpContext32839 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createHttpContext", "()Lorg/apache/http/protocol/HttpContext;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createRequestExecutor32840 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createRequestExecutor", "()Lorg/apache/http/protocol/HttpRequestExecutor;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createClientConnectionManager32841 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createClientConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createAuthSchemeRegistry32842 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createAuthSchemeRegistry", "()Lorg/apache/http/auth/AuthSchemeRegistry;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createCookieSpecRegistry32843 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createCookieSpecRegistry", "()Lorg/apache/http/cookie/CookieSpecRegistry;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createConnectionReuseStrategy32844 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createConnectionReuseStrategy", "()Lorg/apache/http/ConnectionReuseStrategy;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createConnectionKeepAliveStrategy32845 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createConnectionKeepAliveStrategy", "()Lorg/apache/http/conn/ConnectionKeepAliveStrategy;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createHttpProcessor32846 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createHttpProcessor", "()Lorg/apache/http/protocol/BasicHttpProcessor;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createHttpRequestRetryHandler32847 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createHttpRequestRetryHandler", "()Lorg/apache/http/client/HttpRequestRetryHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createRedirectHandler32848 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createRedirectHandler", "()Lorg/apache/http/client/RedirectHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createTargetAuthenticationHandler32849 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createTargetAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createProxyAuthenticationHandler32850 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createProxyAuthenticationHandler", "()Lorg/apache/http/client/AuthenticationHandler;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createCookieStore32851 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createCookieStore", "()Lorg/apache/http/client/CookieStore;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createCredentialsProvider32852 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createCredentialsProvider", "()Lorg/apache/http/client/CredentialsProvider;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createHttpRoutePlanner32853 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createHttpRoutePlanner", "()Lorg/apache/http/conn/routing/HttpRoutePlanner;");
			global::org.apache.http.impl.client.AbstractHttpClient_._createUserTokenHandler32854 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractHttpClient_.staticClass, "createUserTokenHandler", "()Lorg/apache/http/client/UserTokenHandler;");
		}
	}
}
