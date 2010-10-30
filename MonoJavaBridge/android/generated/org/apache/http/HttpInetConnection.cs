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
		internal static global::MonoJavaBridge.MethodId _getLocalAddress31589;
		global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.HttpInetConnection_._getLocalAddress31589) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort31590;
		int org.apache.http.HttpInetConnection.getLocalPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "getLocalPort", "()I", ref global::org.apache.http.HttpInetConnection_._getLocalPort31590);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress31591;
		global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.HttpInetConnection_._getRemoteAddress31591) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort31592;
		int org.apache.http.HttpInetConnection.getRemotePort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "getRemotePort", "()I", ref global::org.apache.http.HttpInetConnection_._getRemotePort31592);
		}
		internal static global::MonoJavaBridge.MethodId _shutdown31593;
		void org.apache.http.HttpConnection.shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "shutdown", "()V", ref global::org.apache.http.HttpInetConnection_._shutdown31593);
		}
		internal static global::MonoJavaBridge.MethodId _close31594;
		void org.apache.http.HttpConnection.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "close", "()V", ref global::org.apache.http.HttpInetConnection_._close31594);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen31595;
		bool org.apache.http.HttpConnection.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "isOpen", "()Z", ref global::org.apache.http.HttpInetConnection_._isOpen31595);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics31596;
		global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpConnectionMetrics>(this, global::org.apache.http.HttpInetConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", ref global::org.apache.http.HttpInetConnection_._getMetrics31596) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale31597;
		bool org.apache.http.HttpConnection.isStale()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "isStale", "()Z", ref global::org.apache.http.HttpInetConnection_._isStale31597);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout31598;
		void org.apache.http.HttpConnection.setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "setSocketTimeout", "(I)V", ref global::org.apache.http.HttpInetConnection_._setSocketTimeout31598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout31599;
		int org.apache.http.HttpConnection.getSocketTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.HttpInetConnection_.staticClass, "getSocketTimeout", "()I", ref global::org.apache.http.HttpInetConnection_._getSocketTimeout31599);
		}
		static HttpInetConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpInetConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpInetConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
