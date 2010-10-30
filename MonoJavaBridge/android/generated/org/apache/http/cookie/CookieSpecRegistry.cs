namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CookieSpecRegistry : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CookieSpecRegistry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public void register(java.lang.String arg0, org.apache.http.cookie.CookieSpecFactory arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.CookieSpecRegistry.staticClass, "register", "(Ljava/lang/String;Lorg/apache/http/cookie/CookieSpecFactory;)V", ref global::org.apache.http.cookie.CookieSpecRegistry._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.CookieSpecRegistry.staticClass, "setItems", "(Ljava/util/Map;)V", ref global::org.apache.http.cookie.CookieSpecRegistry._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void unregister(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.CookieSpecRegistry.staticClass, "unregister", "(Ljava/lang/String;)V", ref global::org.apache.http.cookie.CookieSpecRegistry._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::org.apache.http.cookie.CookieSpec getCookieSpec(java.lang.String arg0, org.apache.http.@params.HttpParams arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.cookie.CookieSpec>(this, global::org.apache.http.cookie.CookieSpecRegistry.staticClass, "getCookieSpec", "(Ljava/lang/String;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;", ref global::org.apache.http.cookie.CookieSpecRegistry._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.cookie.CookieSpec;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::org.apache.http.cookie.CookieSpec getCookieSpec(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.cookie.CookieSpec>(this, global::org.apache.http.cookie.CookieSpecRegistry.staticClass, "getCookieSpec", "(Ljava/lang/String;)Lorg/apache/http/cookie/CookieSpec;", ref global::org.apache.http.cookie.CookieSpecRegistry._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.cookie.CookieSpec;
		}
		public new global::java.util.List SpecNames
		{
			get
			{
				return getSpecNames();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::java.util.List getSpecNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::org.apache.http.cookie.CookieSpecRegistry.staticClass, "getSpecNames", "()Ljava/util/List;", ref global::org.apache.http.cookie.CookieSpecRegistry._m5) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public CookieSpecRegistry() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.cookie.CookieSpecRegistry._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.cookie.CookieSpecRegistry._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpecRegistry.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.CookieSpecRegistry.staticClass, global::org.apache.http.cookie.CookieSpecRegistry._m6);
			Init(@__env, handle);
		}
		static CookieSpecRegistry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.CookieSpecRegistry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/CookieSpecRegistry"));
		}
		internal static void InitJNI()
		{
		}
	}
}
