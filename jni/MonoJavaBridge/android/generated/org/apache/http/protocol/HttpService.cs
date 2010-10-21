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
		internal static global::MonoJavaBridge.MethodId _handleException33806;
		protected virtual void handleException(org.apache.http.HttpException arg0, org.apache.http.HttpResponse arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._handleException33806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._handleException33806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getParams33807;
		public virtual global::org.apache.http.@params.HttpParams getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._getParams33807)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._getParams33807)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams33808;
		public virtual void setParams(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._setParams33808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._setParams33808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHttpProcessor33809;
		public virtual void setHttpProcessor(org.apache.http.protocol.HttpProcessor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._setHttpProcessor33809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._setHttpProcessor33809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setConnReuseStrategy33810;
		public virtual void setConnReuseStrategy(org.apache.http.ConnectionReuseStrategy arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._setConnReuseStrategy33810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._setConnReuseStrategy33810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setResponseFactory33811;
		public virtual void setResponseFactory(org.apache.http.HttpResponseFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._setResponseFactory33811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._setResponseFactory33811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHandlerResolver33812;
		public virtual void setHandlerResolver(org.apache.http.protocol.HttpRequestHandlerResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._setHandlerResolver33812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._setHandlerResolver33812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExpectationVerifier33813;
		public virtual void setExpectationVerifier(org.apache.http.protocol.HttpExpectationVerifier arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._setExpectationVerifier33813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._setExpectationVerifier33813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _handleRequest33814;
		public virtual void handleRequest(org.apache.http.HttpServerConnection arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._handleRequest33814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._handleRequest33814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _doService33815;
		protected virtual void doService(org.apache.http.HttpRequest arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService._doService33815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._doService33815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _HttpService33816;
		public HttpService(org.apache.http.protocol.HttpProcessor arg0, org.apache.http.ConnectionReuseStrategy arg1, org.apache.http.HttpResponseFactory arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.HttpService.staticClass, global::org.apache.http.protocol.HttpService._HttpService33816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpService.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpService"));
			global::org.apache.http.protocol.HttpService._handleException33806 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "handleException", "(Lorg/apache/http/HttpException;Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.protocol.HttpService._getParams33807 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "getParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.protocol.HttpService._setParams33808 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "setParams", "(Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.protocol.HttpService._setHttpProcessor33809 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "setHttpProcessor", "(Lorg/apache/http/protocol/HttpProcessor;)V");
			global::org.apache.http.protocol.HttpService._setConnReuseStrategy33810 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "setConnReuseStrategy", "(Lorg/apache/http/ConnectionReuseStrategy;)V");
			global::org.apache.http.protocol.HttpService._setResponseFactory33811 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "setResponseFactory", "(Lorg/apache/http/HttpResponseFactory;)V");
			global::org.apache.http.protocol.HttpService._setHandlerResolver33812 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "setHandlerResolver", "(Lorg/apache/http/protocol/HttpRequestHandlerResolver;)V");
			global::org.apache.http.protocol.HttpService._setExpectationVerifier33813 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "setExpectationVerifier", "(Lorg/apache/http/protocol/HttpExpectationVerifier;)V");
			global::org.apache.http.protocol.HttpService._handleRequest33814 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "handleRequest", "(Lorg/apache/http/HttpServerConnection;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.HttpService._doService33815 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "doService", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.HttpService._HttpService33816 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpService.staticClass, "<init>", "(Lorg/apache/http/protocol/HttpProcessor;Lorg/apache/http/ConnectionReuseStrategy;Lorg/apache/http/HttpResponseFactory;)V");
		}
	}
}
