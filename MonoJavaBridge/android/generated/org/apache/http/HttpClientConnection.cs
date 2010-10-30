namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpClientConnection_))]
	public partial interface HttpClientConnection : HttpConnection
	{
		void flush();
		bool isResponseAvailable(int arg0);
		void sendRequestHeader(org.apache.http.HttpRequest arg0);
		void sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0);
		global::org.apache.http.HttpResponse receiveResponseHeader();
		void receiveResponseEntity(org.apache.http.HttpResponse arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpClientConnection))]
	internal sealed partial class HttpClientConnection_ : java.lang.Object, HttpClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpClientConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.apache.http.HttpClientConnection.flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "flush", "()V", ref global::org.apache.http.HttpClientConnection_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool org.apache.http.HttpClientConnection.isResponseAvailable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "isResponseAvailable", "(I)Z", ref global::org.apache.http.HttpClientConnection_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.apache.http.HttpClientConnection.sendRequestHeader(org.apache.http.HttpRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V", ref global::org.apache.http.HttpClientConnection_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.apache.http.HttpClientConnection.sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", ref global::org.apache.http.HttpClientConnection_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::org.apache.http.HttpResponse org.apache.http.HttpClientConnection.receiveResponseHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.HttpClientConnection_.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;", ref global::org.apache.http.HttpClientConnection_._m4) as org.apache.http.HttpResponse;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.apache.http.HttpClientConnection.receiveResponseEntity(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V", ref global::org.apache.http.HttpClientConnection_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.apache.http.HttpConnection.shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "shutdown", "()V", ref global::org.apache.http.HttpClientConnection_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void org.apache.http.HttpConnection.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "close", "()V", ref global::org.apache.http.HttpClientConnection_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		bool org.apache.http.HttpConnection.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "isOpen", "()Z", ref global::org.apache.http.HttpClientConnection_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpConnectionMetrics>(this, global::org.apache.http.HttpClientConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", ref global::org.apache.http.HttpClientConnection_._m9) as org.apache.http.HttpConnectionMetrics;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		bool org.apache.http.HttpConnection.isStale()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "isStale", "()Z", ref global::org.apache.http.HttpClientConnection_._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void org.apache.http.HttpConnection.setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "setSocketTimeout", "(I)V", ref global::org.apache.http.HttpClientConnection_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		int org.apache.http.HttpConnection.getSocketTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "getSocketTimeout", "()I", ref global::org.apache.http.HttpClientConnection_._m12);
		}
		static HttpClientConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpClientConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpClientConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
