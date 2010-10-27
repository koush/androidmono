namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpProtocolParamBean : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpProtocolParamBean()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _setVersion33798;
		public virtual void setVersion(org.apache.http.HttpVersion arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean._setVersion33798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._setVersion33798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String UserAgent
		{
			set
			{
				setUserAgent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setUserAgent33799;
		public virtual void setUserAgent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean._setUserAgent33799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._setUserAgent33799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String HttpElementCharset
		{
			set
			{
				setHttpElementCharset(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHttpElementCharset33800;
		public virtual void setHttpElementCharset(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean._setHttpElementCharset33800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._setHttpElementCharset33800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String ContentCharset
		{
			set
			{
				setContentCharset(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setContentCharset33801;
		public virtual void setContentCharset(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean._setContentCharset33801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._setContentCharset33801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool UseExpectContinue
		{
			set
			{
				setUseExpectContinue(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setUseExpectContinue33802;
		public virtual void setUseExpectContinue(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean._setUseExpectContinue33802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._setUseExpectContinue33802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HttpProtocolParamBean33803;
		public HttpProtocolParamBean(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._HttpProtocolParamBean33803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpProtocolParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/HttpProtocolParamBean"));
			global::org.apache.http.@params.HttpProtocolParamBean._setVersion33798 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setVersion", "(Lorg/apache/http/HttpVersion;)V");
			global::org.apache.http.@params.HttpProtocolParamBean._setUserAgent33799 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setUserAgent", "(Ljava/lang/String;)V");
			global::org.apache.http.@params.HttpProtocolParamBean._setHttpElementCharset33800 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setHttpElementCharset", "(Ljava/lang/String;)V");
			global::org.apache.http.@params.HttpProtocolParamBean._setContentCharset33801 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setContentCharset", "(Ljava/lang/String;)V");
			global::org.apache.http.@params.HttpProtocolParamBean._setUseExpectContinue33802 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setUseExpectContinue", "(Z)V");
			global::org.apache.http.@params.HttpProtocolParamBean._HttpProtocolParamBean33803 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
		}
	}
}
