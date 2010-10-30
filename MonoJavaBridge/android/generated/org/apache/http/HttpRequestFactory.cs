namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpRequestFactory_))]
	public partial interface HttpRequestFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.HttpRequest newHttpRequest(org.apache.http.RequestLine arg0);
		global::org.apache.http.HttpRequest newHttpRequest(java.lang.String arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpRequestFactory))]
	internal sealed partial class HttpRequestFactory_ : java.lang.Object, HttpRequestFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpRequestFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.apache.http.HttpRequest org.apache.http.HttpRequestFactory.newHttpRequest(org.apache.http.RequestLine arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpRequest>(this, global::org.apache.http.HttpRequestFactory_.staticClass, "newHttpRequest", "(Lorg/apache/http/RequestLine;)Lorg/apache/http/HttpRequest;", ref global::org.apache.http.HttpRequestFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpRequest;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.apache.http.HttpRequest org.apache.http.HttpRequestFactory.newHttpRequest(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpRequest>(this, global::org.apache.http.HttpRequestFactory_.staticClass, "newHttpRequest", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/HttpRequest;", ref global::org.apache.http.HttpRequestFactory_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.HttpRequest;
		}
		static HttpRequestFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpRequestFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpRequestFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
