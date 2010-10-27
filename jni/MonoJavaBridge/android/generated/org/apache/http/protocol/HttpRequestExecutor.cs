namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpRequestExecutor : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpRequestExecutor()
		{
			InitJNI();
		}
		protected HttpRequestExecutor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _execute33895;
		public virtual global::org.apache.http.HttpResponse execute(org.apache.http.HttpRequest arg0, org.apache.http.HttpClientConnection arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestExecutor._execute33895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, global::org.apache.http.protocol.HttpRequestExecutor._execute33895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _canResponseHaveBody33896;
		protected virtual bool canResponseHaveBody(org.apache.http.HttpRequest arg0, org.apache.http.HttpResponse arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestExecutor._canResponseHaveBody33896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, global::org.apache.http.protocol.HttpRequestExecutor._canResponseHaveBody33896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _preProcess33897;
		public virtual void preProcess(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpProcessor arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestExecutor._preProcess33897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, global::org.apache.http.protocol.HttpRequestExecutor._preProcess33897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _doSendRequest33898;
		protected virtual global::org.apache.http.HttpResponse doSendRequest(org.apache.http.HttpRequest arg0, org.apache.http.HttpClientConnection arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestExecutor._doSendRequest33898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, global::org.apache.http.protocol.HttpRequestExecutor._doSendRequest33898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _doReceiveResponse33899;
		protected virtual global::org.apache.http.HttpResponse doReceiveResponse(org.apache.http.HttpRequest arg0, org.apache.http.HttpClientConnection arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestExecutor._doReceiveResponse33899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, global::org.apache.http.protocol.HttpRequestExecutor._doReceiveResponse33899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _postProcess33900;
		public virtual void postProcess(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpProcessor arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestExecutor._postProcess33900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestExecutor.staticClass, global::org.apache.http.protocol.HttpRequestExecutor._postProcess33900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _HttpRequestExecutor33901;
		public HttpRequestExecutor() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.HttpRequestExecutor.staticClass, global::org.apache.http.protocol.HttpRequestExecutor._HttpRequestExecutor33901);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpRequestExecutor.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpRequestExecutor"));
			global::org.apache.http.protocol.HttpRequestExecutor._execute33895 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "execute", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpClientConnection;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.protocol.HttpRequestExecutor._canResponseHaveBody33896 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "canResponseHaveBody", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpResponse;)Z");
			global::org.apache.http.protocol.HttpRequestExecutor._preProcess33897 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "preProcess", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.HttpRequestExecutor._doSendRequest33898 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "doSendRequest", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpClientConnection;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.protocol.HttpRequestExecutor._doReceiveResponse33899 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "doReceiveResponse", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpClientConnection;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.protocol.HttpRequestExecutor._postProcess33900 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "postProcess", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.HttpRequestExecutor._HttpRequestExecutor33901 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestExecutor.staticClass, "<init>", "()V");
		}
	}
}
