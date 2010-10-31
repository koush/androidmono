namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AuthSchemeRegistry : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AuthSchemeRegistry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public void register(java.lang.String arg0, org.apache.http.auth.AuthSchemeFactory arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "register", "(Ljava/lang/String;Lorg/apache/http/auth/AuthSchemeFactory;)V", ref global::org.apache.http.auth.AuthSchemeRegistry._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.util.Map Items
		{
			set
			{
				setItems(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public void setItems(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "setItems", "(Ljava/util/Map;)V", ref global::org.apache.http.auth.AuthSchemeRegistry._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void unregister(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "unregister", "(Ljava/lang/String;)V", ref global::org.apache.http.auth.AuthSchemeRegistry._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::org.apache.http.auth.AuthScheme getAuthScheme(java.lang.String arg0, org.apache.http.@params.HttpParams arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.auth.AuthScheme>(this, global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "getAuthScheme", "(Ljava/lang/String;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/auth/AuthScheme;", ref global::org.apache.http.auth.AuthSchemeRegistry._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.auth.AuthScheme;
		}
		public new global::java.util.List SchemeNames
		{
			get
			{
				return getSchemeNames();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.util.List getSchemeNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "getSchemeNames", "()Ljava/util/List;", ref global::org.apache.http.auth.AuthSchemeRegistry._m4) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public AuthSchemeRegistry() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.AuthSchemeRegistry._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.AuthSchemeRegistry._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthSchemeRegistry.staticClass, global::org.apache.http.auth.AuthSchemeRegistry._m5);
			Init(@__env, handle);
		}
		static AuthSchemeRegistry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AuthSchemeRegistry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AuthSchemeRegistry"));
		}
	}
}
