namespace org.apache.http.client.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClientParamBean : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClientParamBean()
		{
			InitJNI();
		}
		protected ClientParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setConnectionManagerFactoryClassName25314;
		public virtual void setConnectionManagerFactoryClassName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setConnectionManagerFactoryClassName25314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setConnectionManagerFactoryClassName25314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setConnectionManagerFactory25315;
		public virtual void setConnectionManagerFactory(org.apache.http.conn.ClientConnectionManagerFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setConnectionManagerFactory25315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setConnectionManagerFactory25315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHandleRedirects25316;
		public virtual void setHandleRedirects(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setHandleRedirects25316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setHandleRedirects25316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRejectRelativeRedirect25317;
		public virtual void setRejectRelativeRedirect(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setRejectRelativeRedirect25317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setRejectRelativeRedirect25317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxRedirects25318;
		public virtual void setMaxRedirects(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setMaxRedirects25318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setMaxRedirects25318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAllowCircularRedirects25319;
		public virtual void setAllowCircularRedirects(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setAllowCircularRedirects25319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setAllowCircularRedirects25319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHandleAuthentication25320;
		public virtual void setHandleAuthentication(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setHandleAuthentication25320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setHandleAuthentication25320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCookiePolicy25321;
		public virtual void setCookiePolicy(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setCookiePolicy25321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setCookiePolicy25321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVirtualHost25322;
		public virtual void setVirtualHost(org.apache.http.HttpHost arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setVirtualHost25322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setVirtualHost25322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultHeaders25323;
		public virtual void setDefaultHeaders(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setDefaultHeaders25323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setDefaultHeaders25323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultHost25324;
		public virtual void setDefaultHost(org.apache.http.HttpHost arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setDefaultHost25324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setDefaultHost25324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ClientParamBean25325;
		public ClientParamBean(org.apache.http.@params.HttpParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._ClientParamBean25325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.@params.ClientParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/@params/ClientParamBean"));
			global::org.apache.http.client.@params.ClientParamBean._setConnectionManagerFactoryClassName25314 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setConnectionManagerFactoryClassName", "(Ljava/lang/String;)V");
			global::org.apache.http.client.@params.ClientParamBean._setConnectionManagerFactory25315 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setConnectionManagerFactory", "(Lorg/apache/http/conn/ClientConnectionManagerFactory;)V");
			global::org.apache.http.client.@params.ClientParamBean._setHandleRedirects25316 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setHandleRedirects", "(Z)V");
			global::org.apache.http.client.@params.ClientParamBean._setRejectRelativeRedirect25317 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setRejectRelativeRedirect", "(Z)V");
			global::org.apache.http.client.@params.ClientParamBean._setMaxRedirects25318 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setMaxRedirects", "(I)V");
			global::org.apache.http.client.@params.ClientParamBean._setAllowCircularRedirects25319 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setAllowCircularRedirects", "(Z)V");
			global::org.apache.http.client.@params.ClientParamBean._setHandleAuthentication25320 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setHandleAuthentication", "(Z)V");
			global::org.apache.http.client.@params.ClientParamBean._setCookiePolicy25321 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setCookiePolicy", "(Ljava/lang/String;)V");
			global::org.apache.http.client.@params.ClientParamBean._setVirtualHost25322 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setVirtualHost", "(Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.client.@params.ClientParamBean._setDefaultHeaders25323 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setDefaultHeaders", "(Ljava/util/Collection;)V");
			global::org.apache.http.client.@params.ClientParamBean._setDefaultHost25324 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setDefaultHost", "(Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.client.@params.ClientParamBean._ClientParamBean25325 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "<init>", "(Lorg/apache/http/@params/HttpParams;)V");
		}
	}
}
