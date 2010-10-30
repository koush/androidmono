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
		internal static global::MonoJavaBridge.MethodId _setVersion33799;
		public virtual void setVersion(org.apache.http.HttpVersion arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParamBean._setVersion33799.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParamBean._setVersion33799 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setVersion", "(Lorg/apache/http/HttpVersion;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._setVersion33799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String UserAgent
		{
			set
			{
				setUserAgent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setUserAgent33800;
		public virtual void setUserAgent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParamBean._setUserAgent33800.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParamBean._setUserAgent33800 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setUserAgent", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._setUserAgent33800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String HttpElementCharset
		{
			set
			{
				setHttpElementCharset(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHttpElementCharset33801;
		public virtual void setHttpElementCharset(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParamBean._setHttpElementCharset33801.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParamBean._setHttpElementCharset33801 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setHttpElementCharset", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._setHttpElementCharset33801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String ContentCharset
		{
			set
			{
				setContentCharset(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setContentCharset33802;
		public virtual void setContentCharset(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParamBean._setContentCharset33802.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParamBean._setContentCharset33802 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setContentCharset", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._setContentCharset33802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool UseExpectContinue
		{
			set
			{
				setUseExpectContinue(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setUseExpectContinue33803;
		public virtual void setUseExpectContinue(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParamBean._setUseExpectContinue33803.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParamBean._setUseExpectContinue33803 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setUseExpectContinue", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._setUseExpectContinue33803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HttpProtocolParamBean33804;
		public HttpProtocolParamBean(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpProtocolParamBean._HttpProtocolParamBean33804.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpProtocolParamBean._HttpProtocolParamBean33804 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._HttpProtocolParamBean33804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
