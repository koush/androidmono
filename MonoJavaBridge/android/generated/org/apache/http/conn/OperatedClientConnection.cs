namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.OperatedClientConnection_))]
	public partial interface OperatedClientConnection : HttpClientConnection, HttpInetConnection
	{
		void update(java.net.Socket arg0, org.apache.http.HttpHost arg1, bool arg2, org.apache.http.@params.HttpParams arg3);
		bool isSecure();
		global::java.net.Socket getSocket();
		global::org.apache.http.HttpHost getTargetHost();
		void opening(java.net.Socket arg0, org.apache.http.HttpHost arg1);
		void openCompleted(bool arg0, org.apache.http.@params.HttpParams arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.OperatedClientConnection))]
	internal sealed partial class OperatedClientConnection_ : java.lang.Object, OperatedClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal OperatedClientConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _update32150;
		void org.apache.http.conn.OperatedClientConnection.update(java.net.Socket arg0, org.apache.http.HttpHost arg1, bool arg2, org.apache.http.@params.HttpParams arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "update", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.conn.OperatedClientConnection_._update32150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32151;
		bool org.apache.http.conn.OperatedClientConnection.isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "isSecure", "()Z", ref global::org.apache.http.conn.OperatedClientConnection_._isSecure32151);
		}
		internal static global::MonoJavaBridge.MethodId _getSocket32152;
		global::java.net.Socket org.apache.http.conn.OperatedClientConnection.getSocket()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getSocket", "()Ljava/net/Socket;", ref global::org.apache.http.conn.OperatedClientConnection_._getSocket32152) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHost32153;
		global::org.apache.http.HttpHost org.apache.http.conn.OperatedClientConnection.getTargetHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.HttpHost>(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;", ref global::org.apache.http.conn.OperatedClientConnection_._getTargetHost32153) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _opening32154;
		void org.apache.http.conn.OperatedClientConnection.opening(java.net.Socket arg0, org.apache.http.HttpHost arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "opening", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;)V", ref global::org.apache.http.conn.OperatedClientConnection_._opening32154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _openCompleted32155;
		void org.apache.http.conn.OperatedClientConnection.openCompleted(bool arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "openCompleted", "(ZLorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.conn.OperatedClientConnection_._openCompleted32155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _flush32156;
		void org.apache.http.HttpClientConnection.flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "flush", "()V", ref global::org.apache.http.conn.OperatedClientConnection_._flush32156);
		}
		internal static global::MonoJavaBridge.MethodId _isResponseAvailable32157;
		bool org.apache.http.HttpClientConnection.isResponseAvailable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "isResponseAvailable", "(I)Z", ref global::org.apache.http.conn.OperatedClientConnection_._isResponseAvailable32157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader32158;
		void org.apache.http.HttpClientConnection.sendRequestHeader(org.apache.http.HttpRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V", ref global::org.apache.http.conn.OperatedClientConnection_._sendRequestHeader32158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestEntity32159;
		void org.apache.http.HttpClientConnection.sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", ref global::org.apache.http.conn.OperatedClientConnection_._sendRequestEntity32159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader32160;
		global::org.apache.http.HttpResponse org.apache.http.HttpClientConnection.receiveResponseHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;", ref global::org.apache.http.conn.OperatedClientConnection_._receiveResponseHeader32160) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseEntity32161;
		void org.apache.http.HttpClientConnection.receiveResponseEntity(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V", ref global::org.apache.http.conn.OperatedClientConnection_._receiveResponseEntity32161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown32162;
		void org.apache.http.HttpConnection.shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "shutdown", "()V", ref global::org.apache.http.conn.OperatedClientConnection_._shutdown32162);
		}
		internal static global::MonoJavaBridge.MethodId _close32163;
		void org.apache.http.HttpConnection.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "close", "()V", ref global::org.apache.http.conn.OperatedClientConnection_._close32163);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen32164;
		bool org.apache.http.HttpConnection.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "isOpen", "()Z", ref global::org.apache.http.conn.OperatedClientConnection_._isOpen32164);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics32165;
		global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpConnectionMetrics>(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", ref global::org.apache.http.conn.OperatedClientConnection_._getMetrics32165) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale32166;
		bool org.apache.http.HttpConnection.isStale()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "isStale", "()Z", ref global::org.apache.http.conn.OperatedClientConnection_._isStale32166);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout32167;
		void org.apache.http.HttpConnection.setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "setSocketTimeout", "(I)V", ref global::org.apache.http.conn.OperatedClientConnection_._setSocketTimeout32167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout32168;
		int org.apache.http.HttpConnection.getSocketTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getSocketTimeout", "()I", ref global::org.apache.http.conn.OperatedClientConnection_._getSocketTimeout32168);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress32169;
		global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.conn.OperatedClientConnection_._getLocalAddress32169) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort32170;
		int org.apache.http.HttpInetConnection.getLocalPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getLocalPort", "()I", ref global::org.apache.http.conn.OperatedClientConnection_._getLocalPort32170);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress32171;
		global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.conn.OperatedClientConnection_._getRemoteAddress32171) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort32172;
		int org.apache.http.HttpInetConnection.getRemotePort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getRemotePort", "()I", ref global::org.apache.http.conn.OperatedClientConnection_._getRemotePort32172);
		}
		static OperatedClientConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.OperatedClientConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/OperatedClientConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
