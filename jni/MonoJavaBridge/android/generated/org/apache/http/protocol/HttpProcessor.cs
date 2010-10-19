namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.protocol.HttpProcessor_))]
	public interface HttpProcessor : HttpRequestInterceptor, HttpResponseInterceptor
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.protocol.HttpProcessor))]
	public sealed partial class HttpProcessor_ : java.lang.Object, HttpProcessor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpProcessor_()
		{
			InitJNI();
		}
		internal HttpProcessor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process27091;
		 void org.apache.http.HttpRequestInterceptor.process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpProcessor_._process27091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpProcessor_.staticClass, global::org.apache.http.protocol.HttpProcessor_._process27091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _process27092;
		 void org.apache.http.HttpResponseInterceptor.process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpProcessor_._process27092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpProcessor_.staticClass, global::org.apache.http.protocol.HttpProcessor_._process27092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpProcessor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpProcessor"));
			global::org.apache.http.protocol.HttpProcessor_._process27091 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpProcessor_.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.HttpProcessor_._process27092 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpProcessor_.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V");
		}
	}
}
