namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.ResponseHandler_))]
	public partial interface ResponseHandler  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object handleResponse(org.apache.http.HttpResponse arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.ResponseHandler))]
	internal sealed partial class ResponseHandler_ : java.lang.Object, ResponseHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ResponseHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object org.apache.http.client.ResponseHandler.handleResponse(org.apache.http.HttpResponse arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.ResponseHandler_.staticClass, "handleResponse", "(Lorg/apache/http/HttpResponse;)Ljava/lang/Object;", ref global::org.apache.http.client.ResponseHandler_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		static ResponseHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.ResponseHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/ResponseHandler"));
		}
	}
}
