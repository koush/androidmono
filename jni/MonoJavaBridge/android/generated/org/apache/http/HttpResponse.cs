namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpResponse_))]
	public interface HttpResponse : HttpMessage
	{
		void setLocale(java.util.Locale arg0);
		global::java.util.Locale getLocale();
		global::org.apache.http.StatusLine getStatusLine();
		void setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1);
		void setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1, java.lang.String arg2);
		void setStatusLine(org.apache.http.StatusLine arg0);
		void setStatusCode(int arg0);
		void setReasonPhrase(java.lang.String arg0);
		global::org.apache.http.HttpEntity getEntity();
		void setEntity(org.apache.http.HttpEntity arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpResponse))]
	public sealed partial class HttpResponse_ : java.lang.Object, HttpResponse
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpResponse_()
		{
			InitJNI();
		}
		internal HttpResponse_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setLocale25029;
		 void org.apache.http.HttpResponse.setLocale(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setLocale25029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._setLocale25029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLocale25030;
		 global::java.util.Locale org.apache.http.HttpResponse.getLocale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getLocale25030)) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._getLocale25030)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _getStatusLine25031;
		 global::org.apache.http.StatusLine org.apache.http.HttpResponse.getStatusLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.StatusLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getStatusLine25031)) as org.apache.http.StatusLine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.StatusLine>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._getStatusLine25031)) as org.apache.http.StatusLine;
		}
		internal static global::MonoJavaBridge.MethodId _setStatusLine25032;
		 void org.apache.http.HttpResponse.setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setStatusLine25032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._setStatusLine25032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setStatusLine25033;
		 void org.apache.http.HttpResponse.setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setStatusLine25033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._setStatusLine25033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setStatusLine25034;
		 void org.apache.http.HttpResponse.setStatusLine(org.apache.http.StatusLine arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setStatusLine25034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._setStatusLine25034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStatusCode25035;
		 void org.apache.http.HttpResponse.setStatusCode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setStatusCode25035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._setStatusCode25035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setReasonPhrase25036;
		 void org.apache.http.HttpResponse.setReasonPhrase(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setReasonPhrase25036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._setReasonPhrase25036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEntity25037;
		 global::org.apache.http.HttpEntity org.apache.http.HttpResponse.getEntity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpEntity>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getEntity25037)) as org.apache.http.HttpEntity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpEntity>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._getEntity25037)) as org.apache.http.HttpEntity;
		}
		internal static global::MonoJavaBridge.MethodId _setEntity25038;
		 void org.apache.http.HttpResponse.setEntity(org.apache.http.HttpEntity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setEntity25038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._setEntity25038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion25039;
		 global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getProtocolVersion25039)) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._getProtocolVersion25039)) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getParams25040;
		 global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getParams25040)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._getParams25040)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams25041;
		 void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setParams25041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._setParams25041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders25042;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getHeaders25042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._getHeaders25042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _containsHeader25043;
		 bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._containsHeader25043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._containsHeader25043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstHeader25044;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getFirstHeader25044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._getFirstHeader25044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getLastHeader25045;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getLastHeader25045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._getLastHeader25045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getAllHeaders25046;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getAllHeaders25046)) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._getAllHeaders25046)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _addHeader25047;
		 void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._addHeader25047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._addHeader25047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHeader25048;
		 void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._addHeader25048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._addHeader25048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader25049;
		 void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setHeader25049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._setHeader25049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader25050;
		 void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setHeader25050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._setHeader25050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeaders25051;
		 void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setHeaders25051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._setHeaders25051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader25052;
		 void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._removeHeader25052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._removeHeader25052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeaders25053;
		 void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._removeHeaders25053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._removeHeaders25053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator25054;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._headerIterator25054)) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._headerIterator25054)) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator25055;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._headerIterator25055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_.staticClass, global::org.apache.http.HttpResponse_._headerIterator25055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpResponse_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpResponse"));
			global::org.apache.http.HttpResponse_._setLocale25029 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setLocale", "(Ljava/util/Locale;)V");
			global::org.apache.http.HttpResponse_._getLocale25030 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getLocale", "()Ljava/util/Locale;");
			global::org.apache.http.HttpResponse_._getStatusLine25031 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getStatusLine", "()Lorg/apache/http/StatusLine;");
			global::org.apache.http.HttpResponse_._setStatusLine25032 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setStatusLine", "(Lorg/apache/http/ProtocolVersion;I)V");
			global::org.apache.http.HttpResponse_._setStatusLine25033 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setStatusLine", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V");
			global::org.apache.http.HttpResponse_._setStatusLine25034 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setStatusLine", "(Lorg/apache/http/StatusLine;)V");
			global::org.apache.http.HttpResponse_._setStatusCode25035 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setStatusCode", "(I)V");
			global::org.apache.http.HttpResponse_._setReasonPhrase25036 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setReasonPhrase", "(Ljava/lang/String;)V");
			global::org.apache.http.HttpResponse_._getEntity25037 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getEntity", "()Lorg/apache/http/HttpEntity;");
			global::org.apache.http.HttpResponse_._setEntity25038 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setEntity", "(Lorg/apache/http/HttpEntity;)V");
			global::org.apache.http.HttpResponse_._getProtocolVersion25039 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.HttpResponse_._getParams25040 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.HttpResponse_._setParams25041 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setParams", "(Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.HttpResponse_._getHeaders25042 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			global::org.apache.http.HttpResponse_._containsHeader25043 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "containsHeader", "(Ljava/lang/String;)Z");
			global::org.apache.http.HttpResponse_._getFirstHeader25044 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.HttpResponse_._getLastHeader25045 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.HttpResponse_._getAllHeaders25046 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;");
			global::org.apache.http.HttpResponse_._addHeader25047 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "addHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpResponse_._addHeader25048 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.HttpResponse_._setHeader25049 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.HttpResponse_._setHeader25050 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpResponse_._setHeaders25051 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpResponse_._removeHeader25052 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpResponse_._removeHeaders25053 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "removeHeaders", "(Ljava/lang/String;)V");
			global::org.apache.http.HttpResponse_._headerIterator25054 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "headerIterator", "()Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.HttpResponse_._headerIterator25055 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
		}
	}
}
