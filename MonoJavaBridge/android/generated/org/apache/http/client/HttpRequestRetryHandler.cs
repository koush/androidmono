namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.HttpRequestRetryHandler_))]
	public partial interface HttpRequestRetryHandler  : global::MonoJavaBridge.IJavaObject 
	{
		bool retryRequest(java.io.IOException arg0, int arg1, org.apache.http.protocol.HttpContext arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.HttpRequestRetryHandler))]
	internal sealed partial class HttpRequestRetryHandler_ : java.lang.Object, HttpRequestRetryHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpRequestRetryHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _retryRequest31891;
		bool org.apache.http.client.HttpRequestRetryHandler.retryRequest(java.io.IOException arg0, int arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.client.HttpRequestRetryHandler_._retryRequest31891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static HttpRequestRetryHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.HttpRequestRetryHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/HttpRequestRetryHandler"));
			global::org.apache.http.client.HttpRequestRetryHandler_._retryRequest31891 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.HttpRequestRetryHandler_.staticClass, "retryRequest", "(Ljava/io/IOException;ILorg/apache/http/protocol/HttpContext;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
