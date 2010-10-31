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
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String org.apache.http.client.methods.HttpUriRequest.getMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getMethod", "()Ljava/lang/String;", ref global::org.apache.http.client.methods.HttpUriRequest_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.net.URI org.apache.http.client.methods.HttpUriRequest.getURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URI>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getURI", "()Ljava/net/URI;", ref global::org.apache.http.client.methods.HttpUriRequest_._m1) as java.net.URI;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.apache.http.client.methods.HttpUriRequest.abort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "abort", "()V", ref global::org.apache.http.client.methods.HttpUriRequest_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool org.apache.http.client.methods.HttpUriRequest.isAborted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "isAborted", "()Z", ref global::org.apache.http.client.methods.HttpUriRequest_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::org.apache.http.RequestLine org.apache.http.HttpRequest.getRequestLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.RequestLine>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getRequestLine", "()Lorg/apache/http/RequestLine;", ref global::org.apache.http.client.methods.HttpUriRequest_._m4) as org.apache.http.RequestLine;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.client.methods.HttpUriRequest_._m5) as org.apache.http.ProtocolVersion;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getParams", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.client.methods.HttpUriRequest_._m6) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setParams", "(Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.Header>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", ref global::org.apache.http.client.methods.HttpUriRequest_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header[];
		}
		private static global::MonoJavaBridge.MethodId _m9;
		bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "containsHeader", "(Ljava/lang/String;)Z", ref global::org.apache.http.client.methods.HttpUriRequest_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", ref global::org.apache.http.client.methods.HttpUriRequest_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", ref global::org.apache.http.client.methods.HttpUriRequest_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.Header>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;", ref global::org.apache.http.client.methods.HttpUriRequest_._m12) as org.apache.http.Header[];
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "addHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "removeHeaders", "(Ljava/lang/String;)V", ref global::org.apache.http.client.methods.HttpUriRequest_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderIterator>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "headerIterator", "()Lorg/apache/http/HeaderIterator;", ref global::org.apache.http.client.methods.HttpUriRequest_._m20) as org.apache.http.HeaderIterator;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderIterator>(this, global::org.apache.http.client.methods.HttpUriRequest_.staticClass, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", ref global::org.apache.http.client.methods.HttpUriRequest_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HeaderIterator;
		}
		static HttpUriRequest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpUriRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpUriRequest"));
		}
	}
}
