namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnManagerParamBean : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConnManagerParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new long Timeout
		{
			set
			{
				setTimeout(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setTimeout(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.@params.ConnManagerParamBean.staticClass, "setTimeout", "(J)V", ref global::org.apache.http.conn.@params.ConnManagerParamBean._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxTotalConnections
		{
			set
			{
				setMaxTotalConnections(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setMaxTotalConnections(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.@params.ConnManagerParamBean.staticClass, "setMaxTotalConnections", "(I)V", ref global::org.apache.http.conn.@params.ConnManagerParamBean._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.conn.@params.ConnPerRouteBean ConnectionsPerRoute
		{
			set
			{
				setConnectionsPerRoute(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setConnectionsPerRoute(org.apache.http.conn.@params.ConnPerRouteBean arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.@params.ConnManagerParamBean.staticClass, "setConnectionsPerRoute", "(Lorg/apache/http/conn/params/ConnPerRouteBean;)V", ref global::org.apache.http.conn.@params.ConnManagerParamBean._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public ConnManagerParamBean(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.@params.ConnManagerParamBean._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.@params.ConnManagerParamBean._m3 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.@params.ConnManagerParamBean.staticClass, global::org.apache.http.conn.@params.ConnManagerParamBean._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ConnManagerParamBean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnManagerParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/params/ConnManagerParamBean"));
		}
		internal static void InitJNI()
		{
		}
	}
}
