namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnRouteParams : java.lang.Object, ConnRoutePNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConnRouteParams()
		{
			InitJNI();
		}
		protected ConnRouteParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress25497;
		public static global::java.net.InetAddress getLocalAddress(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.conn.@params.ConnRouteParams.staticClass, global::org.apache.http.conn.@params.ConnRouteParams._getLocalAddress25497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultProxy25498;
		public static void setDefaultProxy(org.apache.http.@params.HttpParams arg0, org.apache.http.HttpHost arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.conn.@params.ConnRouteParams.staticClass, global::org.apache.http.conn.@params.ConnRouteParams._setDefaultProxy25498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLocalAddress25499;
		public static void setLocalAddress(org.apache.http.@params.HttpParams arg0, java.net.InetAddress arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.conn.@params.ConnRouteParams.staticClass, global::org.apache.http.conn.@params.ConnRouteParams._setLocalAddress25499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setForcedRoute25500;
		public static void setForcedRoute(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.routing.HttpRoute arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.conn.@params.ConnRouteParams.staticClass, global::org.apache.http.conn.@params.ConnRouteParams._setForcedRoute25500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultProxy25501;
		public static global::org.apache.http.HttpHost getDefaultProxy(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.conn.@params.ConnRouteParams.staticClass, global::org.apache.http.conn.@params.ConnRouteParams._getDefaultProxy25501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _getForcedRoute25502;
		public static global::org.apache.http.conn.routing.HttpRoute getForcedRoute(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.conn.@params.ConnRouteParams.staticClass, global::org.apache.http.conn.@params.ConnRouteParams._getForcedRoute25502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.FieldId _NO_HOST25503;
		public static global::org.apache.http.HttpHost NO_HOST
		{
			get
			{
				return default(global::org.apache.http.HttpHost);
			}
		}
		internal static global::MonoJavaBridge.FieldId _NO_ROUTE25504;
		public static global::org.apache.http.conn.routing.HttpRoute NO_ROUTE
		{
			get
			{
				return default(global::org.apache.http.conn.routing.HttpRoute);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnRouteParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/@params/ConnRouteParams"));
			global::org.apache.http.conn.@params.ConnRouteParams._getLocalAddress25497 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, "getLocalAddress", "(Lorg/apache/http/@params/HttpParams;)Ljava/net/InetAddress;");
			global::org.apache.http.conn.@params.ConnRouteParams._setDefaultProxy25498 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, "setDefaultProxy", "(Lorg/apache/http/@params/HttpParams;Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.conn.@params.ConnRouteParams._setLocalAddress25499 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, "setLocalAddress", "(Lorg/apache/http/@params/HttpParams;Ljava/net/InetAddress;)V");
			global::org.apache.http.conn.@params.ConnRouteParams._setForcedRoute25500 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, "setForcedRoute", "(Lorg/apache/http/@params/HttpParams;Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::org.apache.http.conn.@params.ConnRouteParams._getDefaultProxy25501 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, "getDefaultProxy", "(Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.@params.ConnRouteParams._getForcedRoute25502 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParams.staticClass, "getForcedRoute", "(Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/conn/routing/HttpRoute;");
		}
	}
}
