namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.protocol.HttpRequestHandlerResolver_))]
	public partial interface HttpRequestHandlerResolver  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.protocol.HttpRequestHandler lookup(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.protocol.HttpRequestHandlerResolver))]
	internal sealed partial class HttpRequestHandlerResolver_ : java.lang.Object, HttpRequestHandlerResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpRequestHandlerResolver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _lookup33910;
		global::org.apache.http.protocol.HttpRequestHandler org.apache.http.protocol.HttpRequestHandlerResolver.lookup(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.protocol.HttpRequestHandler>(this, global::org.apache.http.protocol.HttpRequestHandlerResolver_.staticClass, "lookup", "(Ljava/lang/String;)Lorg/apache/http/protocol/HttpRequestHandler;", ref global::org.apache.http.protocol.HttpRequestHandlerResolver_._lookup33910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.protocol.HttpRequestHandler;
		}
		static HttpRequestHandlerResolver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpRequestHandlerResolver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpRequestHandlerResolver"));
		}
		internal static void InitJNI()
		{
		}
	}
}
