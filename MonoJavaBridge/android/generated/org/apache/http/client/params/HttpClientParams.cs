namespace org.apache.http.client.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpClientParams : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpClientParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void setCookiePolicy(org.apache.http.@params.HttpParams arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.@params.HttpClientParams._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.@params.HttpClientParams._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "setCookiePolicy", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static bool isRedirecting(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.@params.HttpClientParams._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.@params.HttpClientParams._m1 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "isRedirecting", "(Lorg/apache/http/params/HttpParams;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void setRedirecting(org.apache.http.@params.HttpParams arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.@params.HttpClientParams._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.@params.HttpClientParams._m2 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "setRedirecting", "(Lorg/apache/http/params/HttpParams;Z)V");
			@__env.CallStaticVoidMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static bool isAuthenticating(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.@params.HttpClientParams._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.@params.HttpClientParams._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "isAuthenticating", "(Lorg/apache/http/params/HttpParams;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void setAuthenticating(org.apache.http.@params.HttpParams arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.@params.HttpClientParams._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.@params.HttpClientParams._m4 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "setAuthenticating", "(Lorg/apache/http/params/HttpParams;Z)V");
			@__env.CallStaticVoidMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.lang.String getCookiePolicy(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.@params.HttpClientParams._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.@params.HttpClientParams._m5 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "getCookiePolicy", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		static HttpClientParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.@params.HttpClientParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/params/HttpClientParams"));
		}
		internal static void InitJNI()
		{
		}
	}
}
