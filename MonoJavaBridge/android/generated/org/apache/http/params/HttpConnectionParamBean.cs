namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpConnectionParamBean : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpConnectionParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int SoTimeout
		{
			set
			{
				setSoTimeout(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setSoTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setSoTimeout", "(I)V", ref global::org.apache.http.@params.HttpConnectionParamBean._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool TcpNoDelay
		{
			set
			{
				setTcpNoDelay(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setTcpNoDelay(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setTcpNoDelay", "(Z)V", ref global::org.apache.http.@params.HttpConnectionParamBean._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SocketBufferSize
		{
			set
			{
				setSocketBufferSize(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setSocketBufferSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setSocketBufferSize", "(I)V", ref global::org.apache.http.@params.HttpConnectionParamBean._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Linger
		{
			set
			{
				setLinger(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setLinger(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setLinger", "(I)V", ref global::org.apache.http.@params.HttpConnectionParamBean._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ConnectionTimeout
		{
			set
			{
				setConnectionTimeout(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setConnectionTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setConnectionTimeout", "(I)V", ref global::org.apache.http.@params.HttpConnectionParamBean._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool StaleCheckingEnabled
		{
			set
			{
				setStaleCheckingEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setStaleCheckingEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setStaleCheckingEnabled", "(Z)V", ref global::org.apache.http.@params.HttpConnectionParamBean._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public HttpConnectionParamBean(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpConnectionParamBean._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpConnectionParamBean._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static HttpConnectionParamBean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpConnectionParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/HttpConnectionParamBean"));
		}
	}
}
