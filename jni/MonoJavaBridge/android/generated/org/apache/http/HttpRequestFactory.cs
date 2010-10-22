namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpRequestFactory_))]
	public partial interface HttpRequestFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.HttpRequest newHttpRequest(org.apache.http.RequestLine arg0);
		global::org.apache.http.HttpRequest newHttpRequest(java.lang.String arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpRequestFactory))]
	public sealed partial class HttpRequestFactory_ : java.lang.Object, HttpRequestFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpRequestFactory_()
		{
			InitJNI();
		}
		internal HttpRequestFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newHttpRequest31516;
		 global::org.apache.http.HttpRequest org.apache.http.HttpRequestFactory.newHttpRequest(org.apache.http.RequestLine arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpRequestFactory_._newHttpRequest31516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpRequestFactory_.staticClass, global::org.apache.http.HttpRequestFactory_._newHttpRequest31516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequest;
		}
		internal static global::MonoJavaBridge.MethodId _newHttpRequest31517;
		 global::org.apache.http.HttpRequest org.apache.http.HttpRequestFactory.newHttpRequest(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpRequestFactory_._newHttpRequest31517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpRequestFactory_.staticClass, global::org.apache.http.HttpRequestFactory_._newHttpRequest31517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpRequest;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpRequestFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpRequestFactory"));
			global::org.apache.http.HttpRequestFactory_._newHttpRequest31516 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpRequestFactory_.staticClass, "newHttpRequest", "(Lorg/apache/http/RequestLine;)Lorg/apache/http/HttpRequest;");
			global::org.apache.http.HttpRequestFactory_._newHttpRequest31517 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpRequestFactory_.staticClass, "newHttpRequest", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/HttpRequest;");
		}
	}
}
