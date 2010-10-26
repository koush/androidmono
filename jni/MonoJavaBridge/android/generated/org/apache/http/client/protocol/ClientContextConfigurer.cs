namespace org.apache.http.client.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClientContextConfigurer : java.lang.Object, ClientContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClientContextConfigurer()
		{
			InitJNI();
		}
		protected ClientContextConfigurer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setCookieSpecRegistry32031;
		public virtual void setCookieSpecRegistry(org.apache.http.cookie.CookieSpecRegistry arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.ClientContextConfigurer._setCookieSpecRegistry32031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, global::org.apache.http.client.protocol.ClientContextConfigurer._setCookieSpecRegistry32031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAuthSchemeRegistry32032;
		public virtual void setAuthSchemeRegistry(org.apache.http.auth.AuthSchemeRegistry arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.ClientContextConfigurer._setAuthSchemeRegistry32032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, global::org.apache.http.client.protocol.ClientContextConfigurer._setAuthSchemeRegistry32032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCookieStore32033;
		public virtual void setCookieStore(org.apache.http.client.CookieStore arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.ClientContextConfigurer._setCookieStore32033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, global::org.apache.http.client.protocol.ClientContextConfigurer._setCookieStore32033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCredentialsProvider32034;
		public virtual void setCredentialsProvider(org.apache.http.client.CredentialsProvider arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.ClientContextConfigurer._setCredentialsProvider32034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, global::org.apache.http.client.protocol.ClientContextConfigurer._setCredentialsProvider32034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAuthSchemePref32035;
		public virtual void setAuthSchemePref(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.ClientContextConfigurer._setAuthSchemePref32035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, global::org.apache.http.client.protocol.ClientContextConfigurer._setAuthSchemePref32035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ClientContextConfigurer32036;
		public ClientContextConfigurer(org.apache.http.protocol.HttpContext arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.protocol.ClientContextConfigurer.staticClass, global::org.apache.http.client.protocol.ClientContextConfigurer._ClientContextConfigurer32036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/protocol/ClientContextConfigurer"));
			global::org.apache.http.client.protocol.ClientContextConfigurer._setCookieSpecRegistry32031 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "setCookieSpecRegistry", "(Lorg/apache/http/cookie/CookieSpecRegistry;)V");
			global::org.apache.http.client.protocol.ClientContextConfigurer._setAuthSchemeRegistry32032 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "setAuthSchemeRegistry", "(Lorg/apache/http/auth/AuthSchemeRegistry;)V");
			global::org.apache.http.client.protocol.ClientContextConfigurer._setCookieStore32033 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "setCookieStore", "(Lorg/apache/http/client/CookieStore;)V");
			global::org.apache.http.client.protocol.ClientContextConfigurer._setCredentialsProvider32034 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "setCredentialsProvider", "(Lorg/apache/http/client/CredentialsProvider;)V");
			global::org.apache.http.client.protocol.ClientContextConfigurer._setAuthSchemePref32035 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "setAuthSchemePref", "(Ljava/util/List;)V");
			global::org.apache.http.client.protocol.ClientContextConfigurer._ClientContextConfigurer32036 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ClientContextConfigurer.staticClass, "<init>", "(Lorg/apache/http/protocol/HttpContext;)V");
		}
	}
}
