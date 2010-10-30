namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpProtocolParamBean : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpProtocolParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::org.apache.http.HttpVersion Version
		{
			set
			{
				setVersion(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setVersion(org.apache.http.HttpVersion arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setVersion", "(Lorg/apache/http/HttpVersion;)V", ref global::org.apache.http.@params.HttpProtocolParamBean._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String UserAgent
		{
			set
			{
				setUserAgent(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setUserAgent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setUserAgent", "(Ljava/lang/String;)V", ref global::org.apache.http.@params.HttpProtocolParamBean._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String HttpElementCharset
		{
			set
			{
				setHttpElementCharset(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setHttpElementCharset(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setHttpElementCharset", "(Ljava/lang/String;)V", ref global::org.apache.http.@params.HttpProtocolParamBean._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String ContentCharset
		{
			set
			{
				setContentCharset(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setContentCharset(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setContentCharset", "(Ljava/lang/String;)V", ref global::org.apache.http.@params.HttpProtocolParamBean._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool UseExpectContinue
		{
			set
			{
				setUseExpectContinue(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setUseExpectContinue(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setUseExpectContinue", "(Z)V", ref global::org.apache.http.@params.HttpProtocolParamBean._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public HttpProtocolParamBean(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParamBean._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParamBean._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static HttpProtocolParamBean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpProtocolParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/HttpProtocolParamBean"));
		}
		internal static void InitJNI()
		{
		}
	}
}
