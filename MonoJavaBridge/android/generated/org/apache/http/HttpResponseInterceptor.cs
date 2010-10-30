namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpResponseInterceptor_))]
	public partial interface HttpResponseInterceptor  : global::MonoJavaBridge.IJavaObject 
	{
		void process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpResponseInterceptor))]
	internal sealed partial class HttpResponseInterceptor_ : java.lang.Object, HttpResponseInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpResponseInterceptor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process31667;
		void org.apache.http.HttpResponseInterceptor.process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpResponseInterceptor_.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.HttpResponseInterceptor_._process31667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static HttpResponseInterceptor_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpResponseInterceptor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpResponseInterceptor"));
		}
		internal static void InitJNI()
		{
		}
	}
}
