namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpRequestExecutor : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpRequestExecutor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _execute33896;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.HttpRequest arg0, org.apache.http.HttpClientConnection arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.HttpRequestExecutor._execute33896.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.HttpRequestExecutor._execute33896 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "execute", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpClientConnection;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, global::org.apache.http.protocol.HttpRequestExecutor._execute33896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _canResponseHaveBody33897;
		protected virtual bool canResponseHaveBody(org.apache.http.HttpRequest arg0, org.apache.http.HttpResponse arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.HttpRequestExecutor._canResponseHaveBody33897.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.HttpRequestExecutor._canResponseHaveBody33897 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "canResponseHaveBody", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpResponse;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, global::org.apache.http.protocol.HttpRequestExecutor._canResponseHaveBody33897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _preProcess33898;
		public virtual void preProcess(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpProcessor arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.HttpRequestExecutor._preProcess33898.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.HttpRequestExecutor._preProcess33898 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "preProcess", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/protocol/HttpContext;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, global::org.apache.http.protocol.HttpRequestExecutor._preProcess33898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _doSendRequest33899;
		protected virtual global::org.apache.http.HttpResponse doSendRequest(org.apache.http.HttpRequest arg0, org.apache.http.HttpClientConnection arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.HttpRequestExecutor._doSendRequest33899.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.HttpRequestExecutor._doSendRequest33899 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "doSendRequest", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpClientConnection;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, global::org.apache.http.protocol.HttpRequestExecutor._doSendRequest33899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _doReceiveResponse33900;
		protected virtual global::org.apache.http.HttpResponse doReceiveResponse(org.apache.http.HttpRequest arg0, org.apache.http.HttpClientConnection arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.HttpRequestExecutor._doReceiveResponse33900.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.HttpRequestExecutor._doReceiveResponse33900 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "doReceiveResponse", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpClientConnection;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, global::org.apache.http.protocol.HttpRequestExecutor._doReceiveResponse33900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _postProcess33901;
		public virtual void postProcess(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpProcessor arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.HttpRequestExecutor._postProcess33901.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.HttpRequestExecutor._postProcess33901 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "postProcess", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/protocol/HttpContext;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, global::org.apache.http.protocol.HttpRequestExecutor._postProcess33901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _HttpRequestExecutor33902;
		public HttpRequestExecutor() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.HttpRequestExecutor._HttpRequestExecutor33902.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.HttpRequestExecutor._HttpRequestExecutor33902 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.HttpRequestExecutor.staticClass, global::org.apache.http.protocol.HttpRequestExecutor._HttpRequestExecutor33902);
			Init(@__env, handle);
		}
		static HttpRequestExecutor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpRequestExecutor.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpRequestExecutor"));
		}
		internal static void InitJNI()
		{
		}
	}
}
