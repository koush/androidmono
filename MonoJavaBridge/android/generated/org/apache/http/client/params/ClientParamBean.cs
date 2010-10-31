namespace org.apache.http.client.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClientParamBean : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClientParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String ConnectionManagerFactoryClassName
		{
			set
			{
				setConnectionManagerFactoryClassName(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setConnectionManagerFactoryClassName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.@params.ClientParamBean.staticClass, "setConnectionManagerFactoryClassName", "(Ljava/lang/String;)V", ref global::org.apache.http.client.@params.ClientParamBean._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.conn.ClientConnectionManagerFactory ConnectionManagerFactory
		{
			set
			{
				setConnectionManagerFactory(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setConnectionManagerFactory(org.apache.http.conn.ClientConnectionManagerFactory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.@params.ClientParamBean.staticClass, "setConnectionManagerFactory", "(Lorg/apache/http/conn/ClientConnectionManagerFactory;)V", ref global::org.apache.http.client.@params.ClientParamBean._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool HandleRedirects
		{
			set
			{
				setHandleRedirects(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setHandleRedirects(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.@params.ClientParamBean.staticClass, "setHandleRedirects", "(Z)V", ref global::org.apache.http.client.@params.ClientParamBean._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool RejectRelativeRedirect
		{
			set
			{
				setRejectRelativeRedirect(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setRejectRelativeRedirect(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.@params.ClientParamBean.staticClass, "setRejectRelativeRedirect", "(Z)V", ref global::org.apache.http.client.@params.ClientParamBean._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxRedirects
		{
			set
			{
				setMaxRedirects(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setMaxRedirects(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.@params.ClientParamBean.staticClass, "setMaxRedirects", "(I)V", ref global::org.apache.http.client.@params.ClientParamBean._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool AllowCircularRedirects
		{
			set
			{
				setAllowCircularRedirects(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setAllowCircularRedirects(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.@params.ClientParamBean.staticClass, "setAllowCircularRedirects", "(Z)V", ref global::org.apache.http.client.@params.ClientParamBean._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool HandleAuthentication
		{
			set
			{
				setHandleAuthentication(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setHandleAuthentication(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.@params.ClientParamBean.staticClass, "setHandleAuthentication", "(Z)V", ref global::org.apache.http.client.@params.ClientParamBean._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String CookiePolicy
		{
			set
			{
				setCookiePolicy(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setCookiePolicy(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.@params.ClientParamBean.staticClass, "setCookiePolicy", "(Ljava/lang/String;)V", ref global::org.apache.http.client.@params.ClientParamBean._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.HttpHost VirtualHost
		{
			set
			{
				setVirtualHost(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setVirtualHost(org.apache.http.HttpHost arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.@params.ClientParamBean.staticClass, "setVirtualHost", "(Lorg/apache/http/HttpHost;)V", ref global::org.apache.http.client.@params.ClientParamBean._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Collection DefaultHeaders
		{
			set
			{
				setDefaultHeaders(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setDefaultHeaders(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.@params.ClientParamBean.staticClass, "setDefaultHeaders", "(Ljava/util/Collection;)V", ref global::org.apache.http.client.@params.ClientParamBean._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.HttpHost DefaultHost
		{
			set
			{
				setDefaultHost(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setDefaultHost(org.apache.http.HttpHost arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.@params.ClientParamBean.staticClass, "setDefaultHost", "(Lorg/apache/http/HttpHost;)V", ref global::org.apache.http.client.@params.ClientParamBean._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public ClientParamBean(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.@params.ClientParamBean._m11.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.@params.ClientParamBean._m11 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ClientParamBean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.@params.ClientParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/params/ClientParamBean"));
		}
	}
}
