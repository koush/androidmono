namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpInetConnection_))]
	public partial interface HttpInetConnection : HttpConnection
	{
		global::java.net.InetAddress getLocalAddress();
		int getLocalPort();
		global::java.net.InetAddress getRemoteAddress();
		int getRemotePort();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpInetConnection))]
	internal sealed partial class HttpInetConnection_ : java.lang.Object, HttpInetConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpInetConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.HttpInetConnection_._m0) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int org.apache.http.HttpInetConnection.getLocalPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "getLocalPort", "()I", ref global::org.apache.http.HttpInetConnection_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.HttpInetConnection_._m2) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int org.apache.http.HttpInetConnection.getRemotePort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "getRemotePort", "()I", ref global::org.apache.http.HttpInetConnection_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.apache.http.HttpConnection.shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "shutdown", "()V", ref global::org.apache.http.HttpInetConnection_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.apache.http.HttpConnection.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "close", "()V", ref global::org.apache.http.HttpInetConnection_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool org.apache.http.HttpConnection.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "isOpen", "()Z", ref global::org.apache.http.HttpInetConnection_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpConnectionMetrics>(this, global::org.apache.http.HttpInetConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", ref global::org.apache.http.HttpInetConnection_._m7) as org.apache.http.HttpConnectionMetrics;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		bool org.apache.http.HttpConnection.isStale()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "isStale", "()Z", ref global::org.apache.http.HttpInetConnection_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void org.apache.http.HttpConnection.setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "setSocketTimeout", "(I)V", ref global::org.apache.http.HttpInetConnection_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		int org.apache.http.HttpConnection.getSocketTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "getSocketTimeout", "()I", ref global::org.apache.http.HttpInetConnection_._m10);
		}
		static HttpInetConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpInetConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpInetConnection"));
		}
	}
}
