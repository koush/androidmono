namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ConnPerRouteBean : java.lang.Object, ConnPerRoute
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ConnPerRouteBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int DefaultMax
		{
			get
			{
				return getDefaultMax();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public int getDefaultMax()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "getDefaultMax", "()I", ref global::org.apache.http.conn.@params.ConnPerRouteBean._m0);
		}
		public new int DefaultMaxPerRoute
		{
			set
			{
				setDefaultMaxPerRoute(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public void setDefaultMaxPerRoute(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "setDefaultMaxPerRoute", "(I)V", ref global::org.apache.http.conn.@params.ConnPerRouteBean._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void setMaxForRoute(org.apache.http.conn.routing.HttpRoute arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "setMaxForRoute", "(Lorg/apache/http/conn/routing/HttpRoute;I)V", ref global::org.apache.http.conn.@params.ConnPerRouteBean._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public int getMaxForRoute(org.apache.http.conn.routing.HttpRoute arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "getMaxForRoute", "(Lorg/apache/http/conn/routing/HttpRoute;)I", ref global::org.apache.http.conn.@params.ConnPerRouteBean._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Map MaxForRoutes
		{
			set
			{
				setMaxForRoutes(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void setMaxForRoutes(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "setMaxForRoutes", "(Ljava/util/Map;)V", ref global::org.apache.http.conn.@params.ConnPerRouteBean._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ConnPerRouteBean(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnPerRouteBean._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnPerRouteBean._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.@params.ConnPerRouteBean.staticClass, global::org.apache.http.conn.@params.ConnPerRouteBean._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ConnPerRouteBean() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnPerRouteBean._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnPerRouteBean._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.@params.ConnPerRouteBean.staticClass, global::org.apache.http.conn.@params.ConnPerRouteBean._m6);
			Init(@__env, handle);
		}
		public static int DEFAULT_MAX_CONNECTIONS_PER_ROUTE
		{
			get
			{
				return 2;
			}
		}
		static ConnPerRouteBean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/params/ConnPerRouteBean"));
		}
		internal static void InitJNI()
		{
		}
	}
}
