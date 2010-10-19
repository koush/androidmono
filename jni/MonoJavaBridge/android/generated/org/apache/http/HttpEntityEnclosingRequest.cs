namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpEntityEnclosingRequest_))]
	public interface HttpEntityEnclosingRequest : HttpRequest
	{
		global::org.apache.http.HttpEntity getEntity();
		void setEntity(org.apache.http.HttpEntity arg0);
		bool expectContinue();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpEntityEnclosingRequest))]
	public sealed partial class HttpEntityEnclosingRequest_ : java.lang.Object, HttpEntityEnclosingRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpEntityEnclosingRequest_()
		{
			InitJNI();
		}
		internal HttpEntityEnclosingRequest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEntity24943;
		 global::org.apache.http.HttpEntity org.apache.http.HttpEntityEnclosingRequest.getEntity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpEntity>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getEntity24943)) as org.apache.http.HttpEntity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpEntity>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._getEntity24943)) as org.apache.http.HttpEntity;
		}
		internal static global::MonoJavaBridge.MethodId _setEntity24944;
		 void org.apache.http.HttpEntityEnclosingRequest.setEntity(org.apache.http.HttpEntity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._setEntity24944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._setEntity24944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _expectContinue24945;
		 bool org.apache.http.HttpEntityEnclosingRequest.expectContinue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._expectContinue24945);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._expectContinue24945);
		}
		internal static global::MonoJavaBridge.MethodId _getRequestLine24946;
		 global::org.apache.http.RequestLine org.apache.http.HttpRequest.getRequestLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getRequestLine24946)) as org.apache.http.RequestLine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._getRequestLine24946)) as org.apache.http.RequestLine;
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion24947;
		 global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getProtocolVersion24947)) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._getProtocolVersion24947)) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getParams24948;
		 global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getParams24948)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._getParams24948)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams24949;
		 void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._setParams24949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._setParams24949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders24950;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getHeaders24950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._getHeaders24950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _containsHeader24951;
		 bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._containsHeader24951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._containsHeader24951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstHeader24952;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getFirstHeader24952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._getFirstHeader24952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getLastHeader24953;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getLastHeader24953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._getLastHeader24953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getAllHeaders24954;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getAllHeaders24954)) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._getAllHeaders24954)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _addHeader24955;
		 void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._addHeader24955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._addHeader24955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHeader24956;
		 void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._addHeader24956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._addHeader24956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader24957;
		 void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._setHeader24957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._setHeader24957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader24958;
		 void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._setHeader24958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._setHeader24958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeaders24959;
		 void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._setHeaders24959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._setHeaders24959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader24960;
		 void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._removeHeader24960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._removeHeader24960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeaders24961;
		 void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._removeHeaders24961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._removeHeaders24961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator24962;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._headerIterator24962)) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._headerIterator24962)) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator24963;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._headerIterator24963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, global::org.apache.http.HttpEntityEnclosingRequest_._headerIterator24963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpEntityEnclosingRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpEntityEnclosingRequest"));
			global::org.apache.http.HttpEntityEnclosingRequest_._getEntity24943 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getEntity", "()Lorg/apache/http/HttpEntity;");
			global::org.apache.http.HttpEntityEnclosingRequest_._setEntity24944 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "setEntity", "(Lorg/apache/http/HttpEntity;)V");
			global::org.apache.http.HttpEntityEnclosingRequest_._expectContinue24945 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "expectContinue", "()Z");
			global::org.apache.http.HttpEntityEnclosingRequest_._getRequestLine24946 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getRequestLine", "()Lorg/apache/http/RequestLine;");
			global::org.apache.http.HttpEntityEnclosingRequest_._getProtocolVersion24947 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.HttpEntityEnclosingRequest_._getParams24948 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.HttpEntityEnclosingRequest_._setParams24949 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "setParams", "(Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.HttpEntityEnclosingRequest_._getHeaders24950 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			global::org.apache.http.HttpEntityEnclosingRequest_._containsHeader24951 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "containsHeader", "(Ljava/lang/String;)Z");
			global::org.apache.http.HttpEntityEnclosingRequest_._getFirstHeader24952 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.HttpEntityEnclosingRequest_._getLastHeader24953 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.HttpEntityEnclosingRequest_._getAllHeaders24954 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;");
			global::org.apache.http.HttpEntityEnclosingRequest_._addHeader24955 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "addHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpEntityEnclosingRequest_._addHeader24956 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.HttpEntityEnclosingRequest_._setHeader24957 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.HttpEntityEnclosingRequest_._setHeader24958 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "setHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpEntityEnclosingRequest_._setHeaders24959 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpEntityEnclosingRequest_._removeHeader24960 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpEntityEnclosingRequest_._removeHeaders24961 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "removeHeaders", "(Ljava/lang/String;)V");
			global::org.apache.http.HttpEntityEnclosingRequest_._headerIterator24962 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "headerIterator", "()Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.HttpEntityEnclosingRequest_._headerIterator24963 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
		}
	}
}
