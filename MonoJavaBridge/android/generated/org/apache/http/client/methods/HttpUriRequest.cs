namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.methods.HttpUriRequest_))]
	public partial interface HttpUriRequest : HttpRequest
	{
		global::java.lang.String getMethod();
		global::java.net.URI getURI();
		void abort();
		bool isAborted();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.methods.HttpUriRequest))]
	internal sealed partial class HttpUriRequest_ : java.lang.Object, HttpUriRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpUriRequest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getMethod31963;
		global::java.lang.String org.apache.http.client.methods.HttpUriRequest.getMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getMethod31963)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI31964;
		global::java.net.URI org.apache.http.client.methods.HttpUriRequest.getURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getURI31964)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _abort31965;
		void org.apache.http.client.methods.HttpUriRequest.abort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._abort31965);
		}
		internal static global::MonoJavaBridge.MethodId _isAborted31966;
		bool org.apache.http.client.methods.HttpUriRequest.isAborted()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._isAborted31966);
		}
		internal static global::MonoJavaBridge.MethodId _getRequestLine31967;
		global::org.apache.http.RequestLine org.apache.http.HttpRequest.getRequestLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getRequestLine31967)) as org.apache.http.RequestLine;
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion31968;
		global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getProtocolVersion31968)) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getParams31969;
		global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getParams31969)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams31970;
		void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._setParams31970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders31971;
		global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getHeaders31971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _containsHeader31972;
		bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._containsHeader31972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstHeader31973;
		global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getFirstHeader31973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getLastHeader31974;
		global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getLastHeader31974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getAllHeaders31975;
		global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._getAllHeaders31975)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _addHeader31976;
		void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._addHeader31976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHeader31977;
		void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._addHeader31977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader31978;
		void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._setHeader31978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader31979;
		void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._setHeader31979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeaders31980;
		void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._setHeaders31980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader31981;
		void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._removeHeader31981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeaders31982;
		void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._removeHeaders31982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator31983;
		global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._headerIterator31983)) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator31984;
		global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpUriRequest_._headerIterator31984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
		}
		static HttpUriRequest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpUriRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpUriRequest"));
			global::org.apache.http.client.methods.HttpUriRequest_._getMethod31963 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.client.methods.HttpUriRequest_._getURI31964 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getURI", "()Ljava/net/URI;");
			global::org.apache.http.client.methods.HttpUriRequest_._abort31965 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "abort", "()V");
			global::org.apache.http.client.methods.HttpUriRequest_._isAborted31966 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "isAborted", "()Z");
			global::org.apache.http.client.methods.HttpUriRequest_._getRequestLine31967 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getRequestLine", "()Lorg/apache/http/RequestLine;");
			global::org.apache.http.client.methods.HttpUriRequest_._getProtocolVersion31968 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.client.methods.HttpUriRequest_._getParams31969 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getParams", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.client.methods.HttpUriRequest_._setParams31970 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setParams", "(Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._getHeaders31971 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			global::org.apache.http.client.methods.HttpUriRequest_._containsHeader31972 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "containsHeader", "(Ljava/lang/String;)Z");
			global::org.apache.http.client.methods.HttpUriRequest_._getFirstHeader31973 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.client.methods.HttpUriRequest_._getLastHeader31974 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.client.methods.HttpUriRequest_._getAllHeaders31975 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;");
			global::org.apache.http.client.methods.HttpUriRequest_._addHeader31976 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "addHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._addHeader31977 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._setHeader31978 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._setHeader31979 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._setHeaders31980 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._removeHeader31981 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._removeHeaders31982 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "removeHeaders", "(Ljava/lang/String;)V");
			global::org.apache.http.client.methods.HttpUriRequest_._headerIterator31983 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "headerIterator", "()Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.client.methods.HttpUriRequest_._headerIterator31984 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
