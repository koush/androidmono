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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setCookieSpecRegistry(org.apache.http.cookie.CookieSpecRegistry arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "setCookieSpecRegistry", "(Lorg/apache/http/cookie/CookieSpecRegistry;)V", ref global::org.apache.http.client.protocol.ClientContextConfigurer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.auth.AuthSchemeRegistry AuthSchemeRegistry
		{
			set
			{
				setAuthSchemeRegistry(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setAuthSchemeRegistry(org.apache.http.auth.AuthSchemeRegistry arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "setAuthSchemeRegistry", "(Lorg/apache/http/auth/AuthSchemeRegistry;)V", ref global::org.apache.http.client.protocol.ClientContextConfigurer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.client.CookieStore CookieStore
		{
			set
			{
				setCookieStore(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setCookieStore(org.apache.http.client.CookieStore arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "setCookieStore", "(Lorg/apache/http/client/CookieStore;)V", ref global::org.apache.http.client.protocol.ClientContextConfigurer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.client.CredentialsProvider CredentialsProvider
		{
			set
			{
				setCredentialsProvider(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setCredentialsProvider(org.apache.http.client.CredentialsProvider arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "setCredentialsProvider", "(Lorg/apache/http/client/CredentialsProvider;)V", ref global::org.apache.http.client.protocol.ClientContextConfigurer._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List AuthSchemePref
		{
			set
			{
				setAuthSchemePref(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setAuthSchemePref(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "setAuthSchemePref", "(Ljava/util/List;)V", ref global::org.apache.http.client.protocol.ClientContextConfigurer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ClientContextConfigurer(org.apache.http.protocol.HttpContext arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.protocol.ClientContextConfigurer._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.protocol.ClientContextConfigurer._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "<init>", "(Lorg/apache/http/protocol/HttpContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.protocol.ClientContextConfigurer.staticClass, global::org.apache.http.client.protocol.ClientContextConfigurer._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ClientContextConfigurer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/protocol/ClientContextConfigurer"));
		}
	}
}
