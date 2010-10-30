namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpRequest_))]
	public partial interface HttpRequest : HttpMessage
	{
		global::org.apache.http.RequestLine getRequestLine();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpRequest))]
	internal sealed partial class HttpRequest_ : java.lang.Object, HttpRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpRequest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getRequestLine31617;
		global::org.apache.http.RequestLine org.apache.http.HttpRequest.getRequestLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.RequestLine>(this, global::org.apache.http.HttpRequest_.staticClass, "getRequestLine", "()Lorg/apache/http/RequestLine;", ref global::org.apache.http.HttpRequest_._getRequestLine31617) as org.apache.http.RequestLine;
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion31618;
		global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.HttpRequest_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.HttpRequest_._getProtocolVersion31618) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getParams31619;
		global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.HttpRequest_.staticClass, "getParams", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.HttpRequest_._getParams31619) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams31620;
		void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpRequest_.staticClass, "setParams", "(Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.HttpRequest_._setParams31620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders31621;
		global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.Header>(this, global::org.apache.http.HttpRequest_.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", ref global::org.apache.http.HttpRequest_._getHeaders31621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _containsHeader31622;
		bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpRequest_.staticClass, "containsHeader", "(Ljava/lang/String;)Z", ref global::org.apache.http.HttpRequest_._containsHeader31622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstHeader31623;
		global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.HttpRequest_.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", ref global::org.apache.http.HttpRequest_._getFirstHeader31623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getLastHeader31624;
		global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.HttpRequest_.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", ref global::org.apache.http.HttpRequest_._getLastHeader31624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getAllHeaders31625;
		global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.Header>(this, global::org.apache.http.HttpRequest_.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;", ref global::org.apache.http.HttpRequest_._getAllHeaders31625) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _addHeader31626;
		void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpRequest_.staticClass, "addHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.HttpRequest_._addHeader31626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHeader31627;
		void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpRequest_.staticClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.apache.http.HttpRequest_._addHeader31627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader31628;
		void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpRequest_.staticClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.apache.http.HttpRequest_._setHeader31628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader31629;
		void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpRequest_.staticClass, "setHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.HttpRequest_._setHeader31629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeaders31630;
		void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpRequest_.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V", ref global::org.apache.http.HttpRequest_._setHeaders31630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader31631;
		void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpRequest_.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.HttpRequest_._removeHeader31631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeaders31632;
		void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpRequest_.staticClass, "removeHeaders", "(Ljava/lang/String;)V", ref global::org.apache.http.HttpRequest_._removeHeaders31632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator31633;
		global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderIterator>(this, global::org.apache.http.HttpRequest_.staticClass, "headerIterator", "()Lorg/apache/http/HeaderIterator;", ref global::org.apache.http.HttpRequest_._headerIterator31633) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator31634;
		global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderIterator>(this, global::org.apache.http.HttpRequest_.staticClass, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", ref global::org.apache.http.HttpRequest_._headerIterator31634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HeaderIterator;
		}
		static HttpRequest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpRequest"));
		}
		internal static void InitJNI()
		{
		}
	}
}
