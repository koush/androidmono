namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpService : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual void handleException(org.apache.http.HttpException arg0, org.apache.http.HttpResponse arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpService.staticClass, "handleException", "(Lorg/apache/http/HttpException;Lorg/apache/http/HttpResponse;)V", ref global::org.apache.http.protocol.HttpService._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::org.apache.http.@params.HttpParams Params
		{
			get
			{
				return getParams();
			}
			set
			{
				setParams(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.apache.http.@params.HttpParams getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.protocol.HttpService.staticClass, "getParams", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.protocol.HttpService._m1) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setParams(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpService.staticClass, "setParams", "(Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.protocol.HttpService._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.protocol.HttpProcessor HttpProcessor
		{
			set
			{
				setHttpProcessor(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setHttpProcessor(org.apache.http.protocol.HttpProcessor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpService.staticClass, "setHttpProcessor", "(Lorg/apache/http/protocol/HttpProcessor;)V", ref global::org.apache.http.protocol.HttpService._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.ConnectionReuseStrategy ConnReuseStrategy
		{
			set
			{
				setConnReuseStrategy(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setConnReuseStrategy(org.apache.http.ConnectionReuseStrategy arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpService.staticClass, "setConnReuseStrategy", "(Lorg/apache/http/ConnectionReuseStrategy;)V", ref global::org.apache.http.protocol.HttpService._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.HttpResponseFactory ResponseFactory
		{
			set
			{
				setResponseFactory(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setResponseFactory(org.apache.http.HttpResponseFactory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpService.staticClass, "setResponseFactory", "(Lorg/apache/http/HttpResponseFactory;)V", ref global::org.apache.http.protocol.HttpService._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.protocol.HttpRequestHandlerResolver HandlerResolver
		{
			set
			{
				setHandlerResolver(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setHandlerResolver(org.apache.http.protocol.HttpRequestHandlerResolver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpService.staticClass, "setHandlerResolver", "(Lorg/apache/http/protocol/HttpRequestHandlerResolver;)V", ref global::org.apache.http.protocol.HttpService._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.protocol.HttpExpectationVerifier ExpectationVerifier
		{
			set
			{
				setExpectationVerifier(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setExpectationVerifier(org.apache.http.protocol.HttpExpectationVerifier arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpService.staticClass, "setExpectationVerifier", "(Lorg/apache/http/protocol/HttpExpectationVerifier;)V", ref global::org.apache.http.protocol.HttpService._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void handleRequest(org.apache.http.HttpServerConnection arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpService.staticClass, "handleRequest", "(Lorg/apache/http/HttpServerConnection;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.protocol.HttpService._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual void doService(org.apache.http.HttpRequest arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpService.staticClass, "doService", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.protocol.HttpService._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public HttpService(org.apache.http.protocol.HttpProcessor arg0, org.apache.http.ConnectionReuseStrategy arg1, org.apache.http.HttpResponseFactory arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.HttpService._m10.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.HttpService._m10 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "<init>", "(Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/ConnectionReuseStrategy;Lorg/apache/http/HttpResponseFactory;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static HttpService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpService.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpService"));
		}
		internal static void InitJNI()
		{
		}
	}
}
