namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnRouteParamBean : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConnRouteParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::org.apache.http.HttpHost DefaultProxy
		{
			set
			{
				setDefaultProxy(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultProxy32203;
		public virtual void setDefaultProxy(org.apache.http.HttpHost arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.@params.ConnRouteParamBean.staticClass, "setDefaultProxy", "(Lorg/apache/http/HttpHost;)V", ref global::org.apache.http.conn.@params.ConnRouteParamBean._setDefaultProxy32203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.net.InetAddress LocalAddress
		{
			set
			{
				setLocalAddress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLocalAddress32204;
		public virtual void setLocalAddress(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.@params.ConnRouteParamBean.staticClass, "setLocalAddress", "(Ljava/net/InetAddress;)V", ref global::org.apache.http.conn.@params.ConnRouteParamBean._setLocalAddress32204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.conn.routing.HttpRoute ForcedRoute
		{
			set
			{
				setForcedRoute(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setForcedRoute32205;
		public virtual void setForcedRoute(org.apache.http.conn.routing.HttpRoute arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.@params.ConnRouteParamBean.staticClass, "setForcedRoute", "(Lorg/apache/http/conn/routing/HttpRoute;)V", ref global::org.apache.http.conn.@params.ConnRouteParamBean._setForcedRoute32205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConnRouteParamBean32206;
		public ConnRouteParamBean(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnRouteParamBean._ConnRouteParamBean32206.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnRouteParamBean._ConnRouteParamBean32206 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.@params.ConnRouteParamBean.staticClass, global::org.apache.http.conn.@params.ConnRouteParamBean._ConnRouteParamBean32206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ConnRouteParamBean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnRouteParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/params/ConnRouteParamBean"));
		}
		internal static void InitJNI()
		{
		}
	}
}
