namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpResponseInterceptor_))]
	public interface HttpResponseInterceptor  : global::MonoJavaBridge.IJavaObject 
	{
		void process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpResponseInterceptor))]
	public sealed partial class HttpResponseInterceptor_ : java.lang.Object, HttpResponseInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpResponseInterceptor_()
		{
			InitJNI();
		}
		internal HttpResponseInterceptor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process31548;
		 void org.apache.http.HttpResponseInterceptor.process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponseInterceptor_._process31548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponseInterceptor_.staticClass, global::org.apache.http.HttpResponseInterceptor_._process31548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpResponseInterceptor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpResponseInterceptor"));
			global::org.apache.http.HttpResponseInterceptor_._process31548 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponseInterceptor_.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V");
		}
	}
}
