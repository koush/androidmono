namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.protocol.HttpRequestHandlerResolver_))]
	public interface HttpRequestHandlerResolver  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.protocol.HttpRequestHandler lookup(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.protocol.HttpRequestHandlerResolver))]
	public sealed partial class HttpRequestHandlerResolver_ : java.lang.Object, HttpRequestHandlerResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpRequestHandlerResolver_()
		{
			InitJNI();
		}
		internal HttpRequestHandlerResolver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _lookup33791;
		 global::org.apache.http.protocol.HttpRequestHandler org.apache.http.protocol.HttpRequestHandlerResolver.lookup(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.protocol.HttpRequestHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestHandlerResolver_._lookup33791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.protocol.HttpRequestHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.protocol.HttpRequestHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestHandlerResolver_.staticClass, global::org.apache.http.protocol.HttpRequestHandlerResolver_._lookup33791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.protocol.HttpRequestHandler;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpRequestHandlerResolver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpRequestHandlerResolver"));
			global::org.apache.http.protocol.HttpRequestHandlerResolver_._lookup33791 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestHandlerResolver_.staticClass, "lookup", "(Ljava/lang/String;)Lorg/apache/http/protocol/HttpRequestHandler;");
		}
	}
}
