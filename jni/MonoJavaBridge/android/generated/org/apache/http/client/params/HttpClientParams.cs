namespace org.apache.http.client.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpClientParams : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpClientParams()
		{
			InitJNI();
		}
		protected HttpClientParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setCookiePolicy31897;
		public static void setCookiePolicy(org.apache.http.@params.HttpParams arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._setCookiePolicy31897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isRedirecting31898;
		public static bool isRedirecting(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._isRedirecting31898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRedirecting31899;
		public static void setRedirecting(org.apache.http.@params.HttpParams arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._setRedirecting31899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isAuthenticating31900;
		public static bool isAuthenticating(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._isAuthenticating31900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAuthenticating31901;
		public static void setAuthenticating(org.apache.http.@params.HttpParams arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._setAuthenticating31901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCookiePolicy31902;
		public static global::java.lang.String getCookiePolicy(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._getCookiePolicy31902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.@params.HttpClientParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/@params/HttpClientParams"));
			global::org.apache.http.client.@params.HttpClientParams._setCookiePolicy31897 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "setCookiePolicy", "(Lorg/apache/http/@params/HttpParams;Ljava/lang/String;)V");
			global::org.apache.http.client.@params.HttpClientParams._isRedirecting31898 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "isRedirecting", "(Lorg/apache/http/@params/HttpParams;)Z");
			global::org.apache.http.client.@params.HttpClientParams._setRedirecting31899 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "setRedirecting", "(Lorg/apache/http/@params/HttpParams;Z)V");
			global::org.apache.http.client.@params.HttpClientParams._isAuthenticating31900 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "isAuthenticating", "(Lorg/apache/http/@params/HttpParams;)Z");
			global::org.apache.http.client.@params.HttpClientParams._setAuthenticating31901 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "setAuthenticating", "(Lorg/apache/http/@params/HttpParams;Z)V");
			global::org.apache.http.client.@params.HttpClientParams._getCookiePolicy31902 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "getCookiePolicy", "(Lorg/apache/http/@params/HttpParams;)Ljava/lang/String;");
		}
	}
}
