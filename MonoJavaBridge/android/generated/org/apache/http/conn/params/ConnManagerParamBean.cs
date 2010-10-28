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
		internal static global::MonoJavaBridge.MethodId _setTimeout32179;
		public virtual void setTimeout(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnManagerParamBean._setTimeout32179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnManagerParamBean.staticClass, global::org.apache.http.conn.@params.ConnManagerParamBean._setTimeout32179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxTotalConnections
		{
			set
			{
				setMaxTotalConnections(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxTotalConnections32180;
		public virtual void setMaxTotalConnections(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnManagerParamBean._setMaxTotalConnections32180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnManagerParamBean.staticClass, global::org.apache.http.conn.@params.ConnManagerParamBean._setMaxTotalConnections32180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.conn.@params.ConnPerRouteBean ConnectionsPerRoute
		{
			set
			{
				setConnectionsPerRoute(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setConnectionsPerRoute32181;
		public virtual void setConnectionsPerRoute(org.apache.http.conn.@params.ConnPerRouteBean arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnManagerParamBean._setConnectionsPerRoute32181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnManagerParamBean.staticClass, global::org.apache.http.conn.@params.ConnManagerParamBean._setConnectionsPerRoute32181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConnManagerParamBean32182;
		public ConnManagerParamBean(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.@params.ConnManagerParamBean.staticClass, global::org.apache.http.conn.@params.ConnManagerParamBean._ConnManagerParamBean32182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ConnManagerParamBean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnManagerParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/params/ConnManagerParamBean"));
			global::org.apache.http.conn.@params.ConnManagerParamBean._setTimeout32179 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParamBean.staticClass, "setTimeout", "(J)V");
			global::org.apache.http.conn.@params.ConnManagerParamBean._setMaxTotalConnections32180 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParamBean.staticClass, "setMaxTotalConnections", "(I)V");
			global::org.apache.http.conn.@params.ConnManagerParamBean._setConnectionsPerRoute32181 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParamBean.staticClass, "setConnectionsPerRoute", "(Lorg/apache/http/conn/params/ConnPerRouteBean;)V");
			global::org.apache.http.conn.@params.ConnManagerParamBean._ConnManagerParamBean32182 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnManagerParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
