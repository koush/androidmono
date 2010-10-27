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
		public new global::java.lang.String ConnectionManagerFactoryClassName
		{
			set
			{
				setConnectionManagerFactoryClassName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setConnectionManagerFactoryClassName31998;
		public virtual void setConnectionManagerFactoryClassName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setConnectionManagerFactoryClassName31998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setConnectionManagerFactoryClassName31998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.conn.ClientConnectionManagerFactory ConnectionManagerFactory
		{
			set
			{
				setConnectionManagerFactory(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setConnectionManagerFactory31999;
		public virtual void setConnectionManagerFactory(org.apache.http.conn.ClientConnectionManagerFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setConnectionManagerFactory31999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setConnectionManagerFactory31999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool HandleRedirects
		{
			set
			{
				setHandleRedirects(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHandleRedirects32000;
		public virtual void setHandleRedirects(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setHandleRedirects32000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setHandleRedirects32000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool RejectRelativeRedirect
		{
			set
			{
				setRejectRelativeRedirect(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setRejectRelativeRedirect32001;
		public virtual void setRejectRelativeRedirect(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setRejectRelativeRedirect32001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setRejectRelativeRedirect32001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxRedirects
		{
			set
			{
				setMaxRedirects(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxRedirects32002;
		public virtual void setMaxRedirects(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setMaxRedirects32002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setMaxRedirects32002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool AllowCircularRedirects
		{
			set
			{
				setAllowCircularRedirects(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAllowCircularRedirects32003;
		public virtual void setAllowCircularRedirects(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setAllowCircularRedirects32003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setAllowCircularRedirects32003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool HandleAuthentication
		{
			set
			{
				setHandleAuthentication(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHandleAuthentication32004;
		public virtual void setHandleAuthentication(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setHandleAuthentication32004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setHandleAuthentication32004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String CookiePolicy
		{
			set
			{
				setCookiePolicy(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCookiePolicy32005;
		public virtual void setCookiePolicy(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setCookiePolicy32005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setCookiePolicy32005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.HttpHost VirtualHost
		{
			set
			{
				setVirtualHost(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVirtualHost32006;
		public virtual void setVirtualHost(org.apache.http.HttpHost arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setVirtualHost32006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setVirtualHost32006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Collection DefaultHeaders
		{
			set
			{
				setDefaultHeaders(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultHeaders32007;
		public virtual void setDefaultHeaders(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setDefaultHeaders32007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setDefaultHeaders32007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.HttpHost DefaultHost
		{
			set
			{
				setDefaultHost(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultHost32008;
		public virtual void setDefaultHost(org.apache.http.HttpHost arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean._setDefaultHost32008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._setDefaultHost32008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ClientParamBean32009;
		public ClientParamBean(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.@params.ClientParamBean.staticClass, global::org.apache.http.client.@params.ClientParamBean._ClientParamBean32009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.@params.ClientParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/params/ClientParamBean"));
			global::org.apache.http.client.@params.ClientParamBean._setConnectionManagerFactoryClassName31998 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setConnectionManagerFactoryClassName", "(Ljava/lang/String;)V");
			global::org.apache.http.client.@params.ClientParamBean._setConnectionManagerFactory31999 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setConnectionManagerFactory", "(Lorg/apache/http/conn/ClientConnectionManagerFactory;)V");
			global::org.apache.http.client.@params.ClientParamBean._setHandleRedirects32000 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setHandleRedirects", "(Z)V");
			global::org.apache.http.client.@params.ClientParamBean._setRejectRelativeRedirect32001 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setRejectRelativeRedirect", "(Z)V");
			global::org.apache.http.client.@params.ClientParamBean._setMaxRedirects32002 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setMaxRedirects", "(I)V");
			global::org.apache.http.client.@params.ClientParamBean._setAllowCircularRedirects32003 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setAllowCircularRedirects", "(Z)V");
			global::org.apache.http.client.@params.ClientParamBean._setHandleAuthentication32004 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setHandleAuthentication", "(Z)V");
			global::org.apache.http.client.@params.ClientParamBean._setCookiePolicy32005 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setCookiePolicy", "(Ljava/lang/String;)V");
			global::org.apache.http.client.@params.ClientParamBean._setVirtualHost32006 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setVirtualHost", "(Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.client.@params.ClientParamBean._setDefaultHeaders32007 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setDefaultHeaders", "(Ljava/util/Collection;)V");
			global::org.apache.http.client.@params.ClientParamBean._setDefaultHost32008 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "setDefaultHost", "(Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.client.@params.ClientParamBean._ClientParamBean32009 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.@params.ClientParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
		}
	}
}
