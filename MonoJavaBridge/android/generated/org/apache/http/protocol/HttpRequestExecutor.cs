namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpRequestExecutor : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpRequestExecutor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.HttpRequest arg0, org.apache.http.HttpClientConnection arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "execute", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpClientConnection;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;", ref global::org.apache.http.protocol.HttpRequestExecutor._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.HttpResponse;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected virtual bool canResponseHaveBody(org.apache.http.HttpRequest arg0, org.apache.http.HttpResponse arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "canResponseHaveBody", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpResponse;)Z", ref global::org.apache.http.protocol.HttpRequestExecutor._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void preProcess(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpProcessor arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "preProcess", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.protocol.HttpRequestExecutor._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual global::org.apache.http.HttpResponse doSendRequest(org.apache.http.HttpRequest arg0, org.apache.http.HttpClientConnection arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "doSendRequest", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpClientConnection;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;", ref global::org.apache.http.protocol.HttpRequestExecutor._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.HttpResponse;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual global::org.apache.http.HttpResponse doReceiveResponse(org.apache.http.HttpRequest arg0, org.apache.http.HttpClientConnection arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "doReceiveResponse", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpClientConnection;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;", ref global::org.apache.http.protocol.HttpRequestExecutor._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.HttpResponse;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void postProcess(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpProcessor arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "postProcess", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.protocol.HttpRequestExecutor._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public HttpRequestExecutor() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.HttpRequestExecutor._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.HttpRequestExecutor._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.HttpRequestExecutor.staticClass, global::org.apache.http.protocol.HttpRequestExecutor._m6);
			Init(@__env, handle);
		}
		static HttpRequestExecutor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpRequestExecutor.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpRequestExecutor"));
		}
	}
}
