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
		internal static global::MonoJavaBridge.MethodId _setVersion33680;
		public virtual void setVersion(org.apache.http.HttpVersion arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean._setVersion33680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._setVersion33680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUserAgent33681;
		public virtual void setUserAgent(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean._setUserAgent33681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._setUserAgent33681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHttpElementCharset33682;
		public virtual void setHttpElementCharset(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean._setHttpElementCharset33682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._setHttpElementCharset33682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentCharset33683;
		public virtual void setContentCharset(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean._setContentCharset33683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._setContentCharset33683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUseExpectContinue33684;
		public virtual void setUseExpectContinue(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean._setUseExpectContinue33684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._setUseExpectContinue33684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HttpProtocolParamBean33685;
		public HttpProtocolParamBean(org.apache.http.@params.HttpParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.HttpProtocolParamBean.staticClass, global::org.apache.http.@params.HttpProtocolParamBean._HttpProtocolParamBean33685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpProtocolParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/@params/HttpProtocolParamBean"));
			global::org.apache.http.@params.HttpProtocolParamBean._setVersion33680 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setVersion", "(Lorg/apache/http/HttpVersion;)V");
			global::org.apache.http.@params.HttpProtocolParamBean._setUserAgent33681 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setUserAgent", "(Ljava/lang/String;)V");
			global::org.apache.http.@params.HttpProtocolParamBean._setHttpElementCharset33682 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setHttpElementCharset", "(Ljava/lang/String;)V");
			global::org.apache.http.@params.HttpProtocolParamBean._setContentCharset33683 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setContentCharset", "(Ljava/lang/String;)V");
			global::org.apache.http.@params.HttpProtocolParamBean._setUseExpectContinue33684 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "setUseExpectContinue", "(Z)V");
			global::org.apache.http.@params.HttpProtocolParamBean._HttpProtocolParamBean33685 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpProtocolParamBean.staticClass, "<init>", "(Lorg/apache/http/@params/HttpParams;)V");
		}
	}
}
