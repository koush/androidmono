namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpEntityEnclosingRequest_))]
	public partial interface HttpEntityEnclosingRequest : HttpRequest
	{
		global::org.apache.http.HttpEntity getEntity();
		void setEntity(org.apache.http.HttpEntity arg0);
		bool expectContinue();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpEntityEnclosingRequest))]
	internal sealed partial class HttpEntityEnclosingRequest_ : java.lang.Object, HttpEntityEnclosingRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpEntityEnclosingRequest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEntity31551;
		global::org.apache.http.HttpEntity org.apache.http.HttpEntityEnclosingRequest.getEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._getEntity31551.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._getEntity31551 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getEntity", "()Lorg/apache/http/HttpEntity;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpEntity>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getEntity31551)) as org.apache.http.HttpEntity;
		}
		internal static global::MonoJavaBridge.MethodId _setEntity31552;
		void org.apache.http.HttpEntityEnclosingRequest.setEntity(org.apache.http.HttpEntity arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._setEntity31552.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._setEntity31552 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "setEntity", "(Lorg/apache/http/HttpEntity;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._setEntity31552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _expectContinue31553;
		bool org.apache.http.HttpEntityEnclosingRequest.expectContinue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._expectContinue31553.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._expectContinue31553 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "expectContinue", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._expectContinue31553);
		}
		internal static global::MonoJavaBridge.MethodId _getRequestLine31554;
		global::org.apache.http.RequestLine org.apache.http.HttpRequest.getRequestLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._getRequestLine31554.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._getRequestLine31554 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getRequestLine", "()Lorg/apache/http/RequestLine;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getRequestLine31554)) as org.apache.http.RequestLine;
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion31555;
		global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._getProtocolVersion31555.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._getProtocolVersion31555 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getProtocolVersion31555)) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getParams31556;
		global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._getParams31556.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._getParams31556 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getParams", "()Lorg/apache/http/params/HttpParams;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getParams31556)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams31557;
		void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._setParams31557.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._setParams31557 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "setParams", "(Lorg/apache/http/params/HttpParams;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._setParams31557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders31558;
		global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._getHeaders31558.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._getHeaders31558 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getHeaders31558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _containsHeader31559;
		bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._containsHeader31559.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._containsHeader31559 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "containsHeader", "(Ljava/lang/String;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._containsHeader31559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstHeader31560;
		global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._getFirstHeader31560.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._getFirstHeader31560 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getFirstHeader31560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getLastHeader31561;
		global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._getLastHeader31561.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._getLastHeader31561 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getLastHeader31561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getAllHeaders31562;
		global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._getAllHeaders31562.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._getAllHeaders31562 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._getAllHeaders31562)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _addHeader31563;
		void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._addHeader31563.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._addHeader31563 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "addHeader", "(Lorg/apache/http/Header;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._addHeader31563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHeader31564;
		void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._addHeader31564.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._addHeader31564 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._addHeader31564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader31565;
		void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._setHeader31565.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._setHeader31565 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._setHeader31565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader31566;
		void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._setHeader31566.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._setHeader31566 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "setHeader", "(Lorg/apache/http/Header;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._setHeader31566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeaders31567;
		void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._setHeaders31567.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._setHeaders31567 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._setHeaders31567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader31568;
		void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._removeHeader31568.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._removeHeader31568 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._removeHeader31568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeaders31569;
		void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._removeHeaders31569.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._removeHeaders31569 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "removeHeaders", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._removeHeaders31569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator31570;
		global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._headerIterator31570.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._headerIterator31570 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "headerIterator", "()Lorg/apache/http/HeaderIterator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._headerIterator31570)) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator31571;
		global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpEntityEnclosingRequest_._headerIterator31571.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpEntityEnclosingRequest_._headerIterator31571 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpEntityEnclosingRequest_.staticClass, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpEntityEnclosingRequest_._headerIterator31571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
		}
		static HttpEntityEnclosingRequest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpEntityEnclosingRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpEntityEnclosingRequest"));
		}
		internal static void InitJNI()
		{
		}
	}
}
