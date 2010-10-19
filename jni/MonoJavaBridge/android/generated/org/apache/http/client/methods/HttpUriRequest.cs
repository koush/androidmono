namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.methods.HttpUriRequest_))]
	public interface HttpUriRequest : HttpRequest
	{
		global::java.lang.String getMethod();
		global::java.net.URI getURI();
		void abort();
		bool isAborted();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.methods.HttpUriRequest))]
	public sealed partial class HttpUriRequest_ : java.lang.Object, HttpUriRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpUriRequest_()
		{
			InitJNI();
		}
		internal HttpUriRequest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getMethod25292;
		 global::java.lang.String org.apache.http.client.methods.HttpUriRequest.getMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getMethod25292)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._getMethod25292)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI25293;
		 global::java.net.URI org.apache.http.client.methods.HttpUriRequest.getURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getURI25293)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._getURI25293)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _abort25294;
		 void org.apache.http.client.methods.HttpUriRequest.abort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._abort25294);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._abort25294);
		}
		internal static global::MonoJavaBridge.MethodId _isAborted25295;
		 bool org.apache.http.client.methods.HttpUriRequest.isAborted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._isAborted25295);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._isAborted25295);
		}
		internal static global::MonoJavaBridge.MethodId _getRequestLine25296;
		 global::org.apache.http.RequestLine org.apache.http.HttpRequest.getRequestLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getRequestLine25296)) as org.apache.http.RequestLine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._getRequestLine25296)) as org.apache.http.RequestLine;
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion25297;
		 global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getProtocolVersion25297)) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._getProtocolVersion25297)) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getParams25298;
		 global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getParams25298)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._getParams25298)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams25299;
		 void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._setParams25299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._setParams25299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders25300;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getHeaders25300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._getHeaders25300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _containsHeader25301;
		 bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._containsHeader25301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._containsHeader25301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstHeader25302;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getFirstHeader25302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._getFirstHeader25302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getLastHeader25303;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getLastHeader25303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._getLastHeader25303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getAllHeaders25304;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getAllHeaders25304)) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._getAllHeaders25304)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _addHeader25305;
		 void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._addHeader25305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._addHeader25305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHeader25306;
		 void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._addHeader25306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._addHeader25306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader25307;
		 void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._setHeader25307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._setHeader25307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader25308;
		 void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._setHeader25308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._setHeader25308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeaders25309;
		 void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._setHeaders25309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._setHeaders25309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader25310;
		 void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._removeHeader25310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._removeHeader25310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeaders25311;
		 void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._removeHeaders25311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._removeHeaders25311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator25312;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._headerIterator25312)) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._headerIterator25312)) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator25313;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._headerIterator25313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, global::org.apache.http.client.methods.HttpUriRequest_._headerIterator25313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpUriRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpUriRequest"));
			global::org.apache.http.client.methods.HttpUriRequest_._getMethod25292 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.client.methods.HttpUriRequest_._getURI25293 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getURI", "()Ljava/net/URI;");
			global::org.apache.http.client.methods.HttpUriRequest_._abort25294 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "abort", "()V");
			global::org.apache.http.client.methods.HttpUriRequest_._isAborted25295 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "isAborted", "()Z");
			global::org.apache.http.client.methods.HttpUriRequest_._getRequestLine25296 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getRequestLine", "()Lorg/apache/http/RequestLine;");
			global::org.apache.http.client.methods.HttpUriRequest_._getProtocolVersion25297 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.client.methods.HttpUriRequest_._getParams25298 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.client.methods.HttpUriRequest_._setParams25299 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setParams", "(Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._getHeaders25300 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			global::org.apache.http.client.methods.HttpUriRequest_._containsHeader25301 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "containsHeader", "(Ljava/lang/String;)Z");
			global::org.apache.http.client.methods.HttpUriRequest_._getFirstHeader25302 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.client.methods.HttpUriRequest_._getLastHeader25303 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.client.methods.HttpUriRequest_._getAllHeaders25304 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;");
			global::org.apache.http.client.methods.HttpUriRequest_._addHeader25305 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "addHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._addHeader25306 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._setHeader25307 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._setHeader25308 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._setHeaders25309 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._removeHeader25310 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._removeHeaders25311 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "removeHeaders", "(Ljava/lang/String;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._headerIterator25312 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "headerIterator", "()Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.client.methods.HttpUriRequest_._headerIterator25313 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
		}
	}
}
