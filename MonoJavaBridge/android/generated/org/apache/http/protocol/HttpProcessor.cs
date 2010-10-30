namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.protocol.HttpProcessor_))]
	public partial interface HttpProcessor : HttpRequestInterceptor, HttpResponseInterceptor
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.protocol.HttpProcessor))]
	internal sealed partial class HttpProcessor_ : java.lang.Object, HttpProcessor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpProcessor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process33894;
		void org.apache.http.HttpRequestInterceptor.process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.HttpProcessor_._process33894.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.HttpProcessor_._process33894 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpProcessor_.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpProcessor_._process33894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _process33895;
		void org.apache.http.HttpResponseInterceptor.process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.HttpProcessor_._process33895.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.HttpProcessor_._process33895 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpProcessor_.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpProcessor_._process33895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static HttpProcessor_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpProcessor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpProcessor"));
		}
		internal static void InitJNI()
		{
		}
	}
}
