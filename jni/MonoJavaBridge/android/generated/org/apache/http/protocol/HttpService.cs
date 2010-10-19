namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpService : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpService()
		{
			InitJNI();
		}
		protected HttpService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _handleException27122;
		protected virtual void handleException(org.apache.http.HttpException arg0, org.apache.http.HttpResponse arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._handleException27122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._handleException27122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getParams27123;
		public virtual global::org.apache.http.@params.HttpParams getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._getParams27123)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._getParams27123)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams27124;
		public virtual void setParams(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._setParams27124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._setParams27124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHttpProcessor27125;
		public virtual void setHttpProcessor(org.apache.http.protocol.HttpProcessor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._setHttpProcessor27125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._setHttpProcessor27125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setConnReuseStrategy27126;
		public virtual void setConnReuseStrategy(org.apache.http.ConnectionReuseStrategy arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._setConnReuseStrategy27126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._setConnReuseStrategy27126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setResponseFactory27127;
		public virtual void setResponseFactory(org.apache.http.HttpResponseFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._setResponseFactory27127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._setResponseFactory27127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHandlerResolver27128;
		public virtual void setHandlerResolver(org.apache.http.protocol.HttpRequestHandlerResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._setHandlerResolver27128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._setHandlerResolver27128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExpectationVerifier27129;
		public virtual void setExpectationVerifier(org.apache.http.protocol.HttpExpectationVerifier arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._setExpectationVerifier27129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._setExpectationVerifier27129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _handleRequest27130;
		public virtual void handleRequest(org.apache.http.HttpServerConnection arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._handleRequest27130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._handleRequest27130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _doService27131;
		protected virtual void doService(org.apache.http.HttpRequest arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._doService27131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._doService27131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _HttpService27132;
		public HttpService(org.apache.http.protocol.HttpProcessor arg0, org.apache.http.ConnectionReuseStrategy arg1, org.apache.http.HttpResponseFactory arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._HttpService27132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpService.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpService"));
			global::org.apache.http.protocol.HttpService._handleException27122 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "handleException", "(Lorg/apache/http/HttpException;Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.protocol.HttpService._getParams27123 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "getParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.protocol.HttpService._setParams27124 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "setParams", "(Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.protocol.HttpService._setHttpProcessor27125 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "setHttpProcessor", "(Lorg/apache/http/protocol/HttpProcessor;)V");
			global::org.apache.http.protocol.HttpService._setConnReuseStrategy27126 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "setConnReuseStrategy", "(Lorg/apache/http/ConnectionReuseStrategy;)V");
			global::org.apache.http.protocol.HttpService._setResponseFactory27127 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "setResponseFactory", "(Lorg/apache/http/HttpResponseFactory;)V");
			global::org.apache.http.protocol.HttpService._setHandlerResolver27128 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "setHandlerResolver", "(Lorg/apache/http/protocol/HttpRequestHandlerResolver;)V");
			global::org.apache.http.protocol.HttpService._setExpectationVerifier27129 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "setExpectationVerifier", "(Lorg/apache/http/protocol/HttpExpectationVerifier;)V");
			global::org.apache.http.protocol.HttpService._handleRequest27130 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "handleRequest", "(Lorg/apache/http/HttpServerConnection;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.HttpService._doService27131 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "doService", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.HttpService._HttpService27132 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "<init>", "(Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/ConnectionReuseStrategy;Lorg/apache/http/HttpResponseFactory;)V");
		}
	}
}
