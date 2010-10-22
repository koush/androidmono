namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultRequestDirector : java.lang.Object, org.apache.http.client.RequestDirector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DefaultRequestDirector()
		{
			InitJNI();
		}
		protected DefaultRequestDirector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _execute32795;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector._execute32795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._execute32795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _handleResponse32796;
		protected virtual global::org.apache.http.impl.client.RoutedRequest handleResponse(org.apache.http.impl.client.RoutedRequest arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector._handleResponse32796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.impl.client.RoutedRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._handleResponse32796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.impl.client.RoutedRequest;
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection32797;
		protected virtual void releaseConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector._releaseConnection32797);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._releaseConnection32797);
		}
		internal static global::MonoJavaBridge.MethodId _determineRoute32798;
		protected virtual global::org.apache.http.conn.routing.HttpRoute determineRoute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector._determineRoute32798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._determineRoute32798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _rewriteRequestURI32799;
		protected virtual void rewriteRequestURI(org.apache.http.impl.client.RequestWrapper arg0, org.apache.http.conn.routing.HttpRoute arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector._rewriteRequestURI32799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._rewriteRequestURI32799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _establishRoute32800;
		protected virtual void establishRoute(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector._establishRoute32800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._establishRoute32800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createTunnelToTarget32801;
		protected virtual bool createTunnelToTarget(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector._createTunnelToTarget32801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._createTunnelToTarget32801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createTunnelToProxy32802;
		protected virtual bool createTunnelToProxy(org.apache.http.conn.routing.HttpRoute arg0, int arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector._createTunnelToProxy32802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._createTunnelToProxy32802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _createConnectRequest32803;
		protected virtual global::org.apache.http.HttpRequest createConnectRequest(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector._createConnectRequest32803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._createConnectRequest32803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpRequest;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultRequestDirector32804;
		public DefaultRequestDirector(org.apache.http.protocol.HttpRequestExecutor arg0, org.apache.http.conn.ClientConnectionManager arg1, org.apache.http.ConnectionReuseStrategy arg2, org.apache.http.conn.ConnectionKeepAliveStrategy arg3, org.apache.http.conn.routing.HttpRoutePlanner arg4, org.apache.http.protocol.HttpProcessor arg5, org.apache.http.client.HttpRequestRetryHandler arg6, org.apache.http.client.RedirectHandler arg7, org.apache.http.client.AuthenticationHandler arg8, org.apache.http.client.AuthenticationHandler arg9, org.apache.http.client.UserTokenHandler arg10, org.apache.http.@params.HttpParams arg11)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultRequestDirector.staticClass, global::org.apache.http.impl.client.DefaultRequestDirector._DefaultRequestDirector32804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultRequestDirector.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultRequestDirector"));
			global::org.apache.http.impl.client.DefaultRequestDirector._execute32795 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.client.DefaultRequestDirector._handleResponse32796 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "handleResponse", "(Lorg/apache/http/impl/client/RoutedRequest;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/impl/client/RoutedRequest;");
			global::org.apache.http.impl.client.DefaultRequestDirector._releaseConnection32797 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "releaseConnection", "()V");
			global::org.apache.http.impl.client.DefaultRequestDirector._determineRoute32798 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.client.DefaultRequestDirector._rewriteRequestURI32799 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "rewriteRequestURI", "(Lorg/apache/http/impl/client/RequestWrapper;Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::org.apache.http.impl.client.DefaultRequestDirector._establishRoute32800 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "establishRoute", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.impl.client.DefaultRequestDirector._createTunnelToTarget32801 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "createTunnelToTarget", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;)Z");
			global::org.apache.http.impl.client.DefaultRequestDirector._createTunnelToProxy32802 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "createTunnelToProxy", "(Lorg/apache/http/conn/routing/HttpRoute;ILorg/apache/http/protocol/HttpContext;)Z");
			global::org.apache.http.impl.client.DefaultRequestDirector._createConnectRequest32803 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "createConnectRequest", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpRequest;");
			global::org.apache.http.impl.client.DefaultRequestDirector._DefaultRequestDirector32804 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultRequestDirector.staticClass, "<init>", "(Lorg/apache/http/protocol/HttpRequestExecutor;Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/ConnectionReuseStrategy;Lorg/apache/http/conn/ConnectionKeepAliveStrategy;Lorg/apache/http/conn/routing/HttpRoutePlanner;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/client/HttpRequestRetryHandler;Lorg/apache/http/client/RedirectHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/AuthenticationHandler;Lorg/apache/http/client/UserTokenHandler;Lorg/apache/http/@params/HttpParams;)V");
		}
	}
}
