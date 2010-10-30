namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultRequestDirector : java.lang.Object, org.apache.http.client.RequestDirector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultRequestDirector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _execute32914;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._execute32914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _handleResponse32915;
		protected virtual global::org.apache.http.impl.client.RoutedRequest handleResponse(org.apache.http.impl.client.RoutedRequest arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._handleResponse32915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.impl.client.RoutedRequest;
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection32916;
		protected virtual void releaseConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._releaseConnection32916);
		}
		internal static global::MonoJavaBridge.MethodId _determineRoute32917;
		protected virtual global::org.apache.http.conn.routing.HttpRoute determineRoute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._determineRoute32917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _rewriteRequestURI32918;
		protected virtual void rewriteRequestURI(org.apache.http.impl.client.RequestWrapper arg0, org.apache.http.conn.routing.HttpRoute arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._rewriteRequestURI32918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _establishRoute32919;
		protected virtual void establishRoute(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._establishRoute32919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createTunnelToTarget32920;
		protected virtual bool createTunnelToTarget(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._createTunnelToTarget32920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createTunnelToProxy32921;
		protected virtual bool createTunnelToProxy(org.apache.http.conn.routing.HttpRoute arg0, int arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._createTunnelToProxy32921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _createConnectRequest32922;
		protected virtual global::org.apache.http.HttpRequest createConnectRequest(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._createConnectRequest32922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpRequest;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultRequestDirector32923;
		public DefaultRequestDirector(org.apache.http.protocol.HttpRequestExecutor arg0, org.apache.http.conn.ClientConnectionManager arg1, org.apache.http.ConnectionReuseStrategy arg2, org.apache.http.conn.ConnectionKeepAliveStrategy arg3, org.apache.http.conn.routing.HttpRoutePlanner arg4, org.apache.http.protocol.HttpProcessor arg5, org.apache.http.client.HttpRequestRetryHandler arg6, org.apache.http.client.RedirectHandler arg7, org.apache.http.client.AuthenticationHandler arg8, org.apache.http.client.AuthenticationHandler arg9, org.apache.http.client.UserTokenHandler arg10, org.apache.http.@params.HttpParams arg11) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._DefaultRequestDirector32923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
			Init(@__env, handle);
		}
		static DefaultRequestDirector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultRequestDirector.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultRequestDirector"));
			global::org.apache.http.impl.client.DefaultRequestDirector._execute32914 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.client.DefaultRequestDirector._handleResponse32915 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "handleResponse", "(Lorg/apache/http/impl/client/RoutedRequest;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/impl/client/RoutedRequest;");
			global::org.apache.http.impl.client.DefaultRequestDirector._releaseConnection32916 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "releaseConnection", "()V");
			global::org.apache.http.impl.client.DefaultRequestDirector._determineRoute32917 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.client.DefaultRequestDirector._rewriteRequestURI32918 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "rewriteRequestURI", "(Lorg/apache/http/impl/client/RequestWrapper;Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::org.apache.http.impl.client.DefaultRequestDirector._establishRoute32919 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "establishRoute", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.impl.client.DefaultRequestDirector._createTunnelToTarget32920 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "createTunnelToTarget", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;)Z");
			global::org.apache.http.impl.client.DefaultRequestDirector._createTunnelToProxy32921 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "createTunnelToProxy", "(Lorg/apache/http/conn/routing/HttpRoute;ILorg/apache/http/protocol/HttpContext;)Z");
			global::org.apache.http.impl.client.DefaultRequestDirector._createConnectRequest32922 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "createConnectRequest", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpRequest;");
			global::org.apache.http.impl.client.DefaultRequestDirector._DefaultRequestDirector32923 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "<init>", "(Lorg/apache/http/protocol/HttpRequestExecutor;Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/ConnectionReuseStrategy;Lorg/apache/http/conn/ConnectionKeepAliveStrategy;Lorg/apache/http/conn/routing/HttpRoutePlanner;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/client/HttpRequestRetryHandler;Lorg/apache/http/client/RedirectHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/UserTokenHandler;Lorg/apache/http/params/HttpParams;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
