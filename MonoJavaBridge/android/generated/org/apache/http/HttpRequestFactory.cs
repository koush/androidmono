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
		internal static global::MonoJavaBridge.MethodId _newHttpRequest31635;
		global::org.apache.http.HttpRequest org.apache.http.HttpRequestFactory.newHttpRequest(org.apache.http.RequestLine arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpRequestFactory_._newHttpRequest31635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequest;
		}
		internal static global::MonoJavaBridge.MethodId _newHttpRequest31636;
		global::org.apache.http.HttpRequest org.apache.http.HttpRequestFactory.newHttpRequest(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpRequestFactory_._newHttpRequest31636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpRequest;
		}
		static HttpRequestFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpRequestFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpRequestFactory"));
			global::org.apache.http.HttpRequestFactory_._newHttpRequest31635 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpRequestFactory_.staticClass, "newHttpRequest", "(Lorg/apache/http/RequestLine;)Lorg/apache/http/HttpRequest;");
			global::org.apache.http.HttpRequestFactory_._newHttpRequest31636 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpRequestFactory_.staticClass, "newHttpRequest", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/HttpRequest;");
		}
		internal static void InitJNI()
		{
		}
	}
}
