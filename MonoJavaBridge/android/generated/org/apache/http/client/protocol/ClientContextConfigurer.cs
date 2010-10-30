namespace org.apache.http.client.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClientContextConfigurer : java.lang.Object, ClientContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClientContextConfigurer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::org.apache.http.cookie.CookieSpecRegistry CookieSpecRegistry
		{
			set
			{
				setCookieSpecRegistry(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCookieSpecRegistry32032;
		public virtual void setCookieSpecRegistry(org.apache.http.cookie.CookieSpecRegistry arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, global::org.apache.http.client.protocol.ClientContextConfigurer._setCookieSpecRegistry32032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.auth.AuthSchemeRegistry AuthSchemeRegistry
		{
			set
			{
				setAuthSchemeRegistry(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAuthSchemeRegistry32033;
		public virtual void setAuthSchemeRegistry(org.apache.http.auth.AuthSchemeRegistry arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, global::org.apache.http.client.protocol.ClientContextConfigurer._setAuthSchemeRegistry32033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.client.CookieStore CookieStore
		{
			set
			{
				setCookieStore(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCookieStore32034;
		public virtual void setCookieStore(org.apache.http.client.CookieStore arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, global::org.apache.http.client.protocol.ClientContextConfigurer._setCookieStore32034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.client.CredentialsProvider CredentialsProvider
		{
			set
			{
				setCredentialsProvider(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCredentialsProvider32035;
		public virtual void setCredentialsProvider(org.apache.http.client.CredentialsProvider arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, global::org.apache.http.client.protocol.ClientContextConfigurer._setCredentialsProvider32035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List AuthSchemePref
		{
			set
			{
				setAuthSchemePref(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAuthSchemePref32036;
		public virtual void setAuthSchemePref(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, global::org.apache.http.client.protocol.ClientContextConfigurer._setAuthSchemePref32036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ClientContextConfigurer32037;
		public ClientContextConfigurer(org.apache.http.protocol.HttpContext arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.protocol.ClientContextConfigurer.staticClass, global::org.apache.http.client.protocol.ClientContextConfigurer._ClientContextConfigurer32037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ClientContextConfigurer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/protocol/ClientContextConfigurer"));
			global::org.apache.http.client.protocol.ClientContextConfigurer._setCookieSpecRegistry32032 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "setCookieSpecRegistry", "(Lorg/apache/http/cookie/CookieSpecRegistry;)V");
			global::org.apache.http.client.protocol.ClientContextConfigurer._setAuthSchemeRegistry32033 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "setAuthSchemeRegistry", "(Lorg/apache/http/auth/AuthSchemeRegistry;)V");
			global::org.apache.http.client.protocol.ClientContextConfigurer._setCookieStore32034 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "setCookieStore", "(Lorg/apache/http/client/CookieStore;)V");
			global::org.apache.http.client.protocol.ClientContextConfigurer._setCredentialsProvider32035 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "setCredentialsProvider", "(Lorg/apache/http/client/CredentialsProvider;)V");
			global::org.apache.http.client.protocol.ClientContextConfigurer._setAuthSchemePref32036 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "setAuthSchemePref", "(Ljava/util/List;)V");
			global::org.apache.http.client.protocol.ClientContextConfigurer._ClientContextConfigurer32037 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "<init>", "(Lorg/apache/http/protocol/HttpContext;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
