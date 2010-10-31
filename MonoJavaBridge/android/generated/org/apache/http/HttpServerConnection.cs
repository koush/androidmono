namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpServerConnection_))]
	public partial interface HttpServerConnection : HttpConnection
	{
		void flush();
		global::org.apache.http.HttpRequest receiveRequestHeader();
		void receiveRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0);
		void sendResponseHeader(org.apache.http.HttpResponse arg0);
		void sendResponseEntity(org.apache.http.HttpResponse arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpServerConnection))]
	internal sealed partial class HttpServerConnection_ : java.lang.Object, HttpServerConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpServerConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.apache.http.HttpServerConnection.flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpServerConnection_.staticClass, "flush", "()V", ref global::org.apache.http.HttpServerConnection_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.apache.http.HttpRequest org.apache.http.HttpServerConnection.receiveRequestHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpRequest>(this, global::org.apache.http.HttpServerConnection_.staticClass, "receiveRequestHeader", "()Lorg/apache/http/HttpRequest;", ref global::org.apache.http.HttpServerConnection_._m1) as org.apache.http.HttpRequest;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.apache.http.HttpServerConnection.receiveRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpServerConnection_.staticClass, "receiveRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", ref global::org.apache.http.HttpServerConnection_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.apache.http.HttpServerConnection.sendResponseHeader(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpServerConnection_.staticClass, "sendResponseHeader", "(Lorg/apache/http/HttpResponse;)V", ref global::org.apache.http.HttpServerConnection_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.apache.http.HttpServerConnection.sendResponseEntity(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpServerConnection_.staticClass, "sendResponseEntity", "(Lorg/apache/http/HttpResponse;)V", ref global::org.apache.http.HttpServerConnection_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.apache.http.HttpConnection.shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpServerConnection_.staticClass, "shutdown", "()V", ref global::org.apache.http.HttpServerConnection_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.apache.http.HttpConnection.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpServerConnection_.staticClass, "close", "()V", ref global::org.apache.http.HttpServerConnection_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		bool org.apache.http.HttpConnection.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpServerConnection_.staticClass, "isOpen", "()Z", ref global::org.apache.http.HttpServerConnection_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpConnectionMetrics>(this, global::org.apache.http.HttpServerConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", ref global::org.apache.http.HttpServerConnection_._m8) as org.apache.http.HttpConnectionMetrics;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		bool org.apache.http.HttpConnection.isStale()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpServerConnection_.staticClass, "isStale", "()Z", ref global::org.apache.http.HttpServerConnection_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void org.apache.http.HttpConnection.setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpServerConnection_.staticClass, "setSocketTimeout", "(I)V", ref global::org.apache.http.HttpServerConnection_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		int org.apache.http.HttpConnection.getSocketTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.HttpServerConnection_.staticClass, "getSocketTimeout", "()I", ref global::org.apache.http.HttpServerConnection_._m11);
		}
		static HttpServerConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpServerConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpServerConnection"));
		}
	}
}
