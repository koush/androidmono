namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.protocol.HttpRequestHandler_))]
	public partial interface HttpRequestHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void handle(org.apache.http.HttpRequest arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.protocol.HttpRequestHandler))]
	internal sealed partial class HttpRequestHandler_ : java.lang.Object, HttpRequestHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpRequestHandler_()
		{
			InitJNI();
		}
		internal HttpRequestHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _handle33902;
		 void org.apache.http.protocol.HttpRequestHandler.handle(org.apache.http.HttpRequest arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestHandler_._handle33902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestHandler_.staticClass, global::org.apache.http.protocol.HttpRequestHandler_._handle33902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpRequestHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpRequestHandler"));
			global::org.apache.http.protocol.HttpRequestHandler_._handle33902 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestHandler_.staticClass, "handle", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V");
		}
	}
}
