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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getMethod", "()Ljava/lang/String;", ref global::org.apache.http.client.methods.HttpUriRequest_._getMethod31963) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI31964;
		global::java.net.URI org.apache.http.client.methods.HttpUriRequest.getURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URI>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getURI", "()Ljava/net/URI;", ref global::org.apache.http.client.methods.HttpUriRequest_._getURI31964) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _abort31965;
		void org.apache.http.client.methods.HttpUriRequest.abort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "abort", "()V", ref global::org.apache.http.client.methods.HttpUriRequest_._abort31965);
		}
		internal static global::MonoJavaBridge.MethodId _isAborted31966;
		bool org.apache.http.client.methods.HttpUriRequest.isAborted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "isAborted", "()Z", ref global::org.apache.http.client.methods.HttpUriRequest_._isAborted31966);
		}
		internal static global::MonoJavaBridge.MethodId _getRequestLine31967;
		global::org.apache.http.RequestLine org.apache.http.HttpRequest.getRequestLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.RequestLine>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getRequestLine", "()Lorg/apache/http/RequestLine;", ref global::org.apache.http.client.methods.HttpUriRequest_._getRequestLine31967) as org.apache.http.RequestLine;
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion31968;
		global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.client.methods.HttpUriRequest_._getProtocolVersion31968) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getParams31969;
		global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getParams", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.client.methods.HttpUriRequest_._getParams31969) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams31970;
		void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setParams", "(Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._setParams31970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders31971;
		global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.Header>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", ref global::org.apache.http.client.methods.HttpUriRequest_._getHeaders31971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _containsHeader31972;
		bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "containsHeader", "(Ljava/lang/String;)Z", ref global::org.apache.http.client.methods.HttpUriRequest_._containsHeader31972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstHeader31973;
		global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", ref global::org.apache.http.client.methods.HttpUriRequest_._getFirstHeader31973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getLastHeader31974;
		global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", ref global::org.apache.http.client.methods.HttpUriRequest_._getLastHeader31974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getAllHeaders31975;
		global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.Header>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;", ref global::org.apache.http.client.methods.HttpUriRequest_._getAllHeaders31975) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _addHeader31976;
		void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "addHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._addHeader31976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHeader31977;
		void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._addHeader31977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader31978;
		void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._setHeader31978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader31979;
		void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._setHeader31979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeaders31980;
		void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._setHeaders31980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader31981;
		void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._removeHeader31981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeaders31982;
		void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "removeHeaders", "(Ljava/lang/String;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._removeHeaders31982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator31983;
		global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderIterator>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "headerIterator", "()Lorg/apache/http/HeaderIterator;", ref global::org.apache.http.client.methods.HttpUriRequest_._headerIterator31983) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator31984;
		global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderIterator>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", ref global::org.apache.http.client.methods.HttpUriRequest_._headerIterator31984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HeaderIterator;
		}
		static HttpUriRequest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpUriRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpUriRequest"));
		}
		internal static void InitJNI()
		{
		}
	}
}
