namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpResponseFactory_))]
	public partial interface HttpResponseFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.HttpResponse newHttpResponse(org.apache.http.ProtocolVersion arg0, int arg1, org.apache.http.protocol.HttpContext arg2);
		global::org.apache.http.HttpResponse newHttpResponse(org.apache.http.StatusLine arg0, org.apache.http.protocol.HttpContext arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpResponseFactory))]
	internal sealed partial class HttpResponseFactory_ : java.lang.Object, HttpResponseFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpResponseFactory_()
		{
			InitJNI();
		}
		internal HttpResponseFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newHttpResponse31664;
		 global::org.apache.http.HttpResponse org.apache.http.HttpResponseFactory.newHttpResponse(org.apache.http.ProtocolVersion arg0, int arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponseFactory_._newHttpResponse31664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponseFactory_.staticClass, global::org.apache.http.HttpResponseFactory_._newHttpResponse31664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _newHttpResponse31665;
		 global::org.apache.http.HttpResponse org.apache.http.HttpResponseFactory.newHttpResponse(org.apache.http.StatusLine arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponseFactory_._newHttpResponse31665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponseFactory_.staticClass, global::org.apache.http.HttpResponseFactory_._newHttpResponse31665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpResponseFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpResponseFactory"));
			global::org.apache.http.HttpResponseFactory_._newHttpResponse31664 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponseFactory_.staticClass, "newHttpResponse", "(Lorg/apache/http/ProtocolVersion;ILorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.HttpResponseFactory_._newHttpResponse31665 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponseFactory_.staticClass, "newHttpResponse", "(Lorg/apache/http/StatusLine;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
		}
	}
}
