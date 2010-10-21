namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnRouteParamBean : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConnRouteParamBean()
		{
			InitJNI();
		}
		protected ConnRouteParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultProxy32084;
		public virtual void setDefaultProxy(org.apache.http.HttpHost arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnRouteParamBean._setDefaultProxy32084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnRouteParamBean.staticClass, global::org.apache.http.conn.@params.ConnRouteParamBean._setDefaultProxy32084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLocalAddress32085;
		public virtual void setLocalAddress(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnRouteParamBean._setLocalAddress32085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnRouteParamBean.staticClass, global::org.apache.http.conn.@params.ConnRouteParamBean._setLocalAddress32085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setForcedRoute32086;
		public virtual void setForcedRoute(org.apache.http.conn.routing.HttpRoute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnRouteParamBean._setForcedRoute32086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnRouteParamBean.staticClass, global::org.apache.http.conn.@params.ConnRouteParamBean._setForcedRoute32086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConnRouteParamBean32087;
		public ConnRouteParamBean(org.apache.http.@params.HttpParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.@params.ConnRouteParamBean.staticClass, global::org.apache.http.conn.@params.ConnRouteParamBean._ConnRouteParamBean32087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnRouteParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/@params/ConnRouteParamBean"));
			global::org.apache.http.conn.@params.ConnRouteParamBean._setDefaultProxy32084 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParamBean.staticClass, "setDefaultProxy", "(Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.conn.@params.ConnRouteParamBean._setLocalAddress32085 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParamBean.staticClass, "setLocalAddress", "(Ljava/net/InetAddress;)V");
			global::org.apache.http.conn.@params.ConnRouteParamBean._setForcedRoute32086 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParamBean.staticClass, "setForcedRoute", "(Lorg/apache/http/conn/routing/HttpRoute;)V");
			global::org.apache.http.conn.@params.ConnRouteParamBean._ConnRouteParamBean32087 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnRouteParamBean.staticClass, "<init>", "(Lorg/apache/http/@params/HttpParams;)V");
		}
	}
}
