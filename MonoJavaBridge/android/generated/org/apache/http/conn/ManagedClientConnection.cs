namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.ManagedClientConnection_))]
	public partial interface ManagedClientConnection : HttpClientConnection, HttpInetConnection, ConnectionReleaseTrigger
	{
		global::java.lang.Object getState();
		void setState(java.lang.Object arg0);
		void open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2);
		bool isSecure();
		global::org.apache.http.conn.routing.HttpRoute getRoute();
		global::javax.net.ssl.SSLSession getSSLSession();
		void tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1);
		void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2);
		void layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1);
		void markReusable();
		void unmarkReusable();
		bool isMarkedReusable();
		void setIdleDuration(long arg0, java.util.concurrent.TimeUnit arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.ManagedClientConnection))]
	internal sealed partial class ManagedClientConnection_ : java.lang.Object, ManagedClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ManagedClientConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getState32112;
		global::java.lang.Object org.apache.http.conn.ManagedClientConnection.getState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getState", "()Ljava/lang/Object;", ref global::org.apache.http.conn.ManagedClientConnection_._getState32112) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setState32113;
		void org.apache.http.conn.ManagedClientConnection.setState(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setState", "(Ljava/lang/Object;)V", ref global::org.apache.http.conn.ManagedClientConnection_._setState32113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _open32114;
		void org.apache.http.conn.ManagedClientConnection.open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.conn.ManagedClientConnection_._open32114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32115;
		bool org.apache.http.conn.ManagedClientConnection.isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isSecure", "()Z", ref global::org.apache.http.conn.ManagedClientConnection_._isSecure32115);
		}
		internal static global::MonoJavaBridge.MethodId _getRoute32116;
		global::org.apache.http.conn.routing.HttpRoute org.apache.http.conn.ManagedClientConnection.getRoute()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.HttpRoute>(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", ref global::org.apache.http.conn.ManagedClientConnection_._getRoute32116) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _getSSLSession32117;
		global::javax.net.ssl.SSLSession org.apache.http.conn.ManagedClientConnection.getSSLSession()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSession>(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getSSLSession", "()Ljavax/net/ssl/SSLSession;", ref global::org.apache.http.conn.ManagedClientConnection_._getSSLSession32117) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget32118;
		void org.apache.http.conn.ManagedClientConnection.tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.conn.ManagedClientConnection_._tunnelTarget32118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy32119;
		void org.apache.http.conn.ManagedClientConnection.tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.conn.ManagedClientConnection_._tunnelProxy32119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol32120;
		void org.apache.http.conn.ManagedClientConnection.layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.conn.ManagedClientConnection_._layerProtocol32120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _markReusable32121;
		void org.apache.http.conn.ManagedClientConnection.markReusable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "markReusable", "()V", ref global::org.apache.http.conn.ManagedClientConnection_._markReusable32121);
		}
		internal static global::MonoJavaBridge.MethodId _unmarkReusable32122;
		void org.apache.http.conn.ManagedClientConnection.unmarkReusable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "unmarkReusable", "()V", ref global::org.apache.http.conn.ManagedClientConnection_._unmarkReusable32122);
		}
		internal static global::MonoJavaBridge.MethodId _isMarkedReusable32123;
		bool org.apache.http.conn.ManagedClientConnection.isMarkedReusable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isMarkedReusable", "()Z", ref global::org.apache.http.conn.ManagedClientConnection_._isMarkedReusable32123);
		}
		internal static global::MonoJavaBridge.MethodId _setIdleDuration32124;
		void org.apache.http.conn.ManagedClientConnection.setIdleDuration(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setIdleDuration", "(JLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.conn.ManagedClientConnection_._setIdleDuration32124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _flush32125;
		void org.apache.http.HttpClientConnection.flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "flush", "()V", ref global::org.apache.http.conn.ManagedClientConnection_._flush32125);
		}
		internal static global::MonoJavaBridge.MethodId _isResponseAvailable32126;
		bool org.apache.http.HttpClientConnection.isResponseAvailable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isResponseAvailable", "(I)Z", ref global::org.apache.http.conn.ManagedClientConnection_._isResponseAvailable32126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader32127;
		void org.apache.http.HttpClientConnection.sendRequestHeader(org.apache.http.HttpRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V", ref global::org.apache.http.conn.ManagedClientConnection_._sendRequestHeader32127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestEntity32128;
		void org.apache.http.HttpClientConnection.sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", ref global::org.apache.http.conn.ManagedClientConnection_._sendRequestEntity32128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader32129;
		global::org.apache.http.HttpResponse org.apache.http.HttpClientConnection.receiveResponseHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;", ref global::org.apache.http.conn.ManagedClientConnection_._receiveResponseHeader32129) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseEntity32130;
		void org.apache.http.HttpClientConnection.receiveResponseEntity(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V", ref global::org.apache.http.conn.ManagedClientConnection_._receiveResponseEntity32130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown32131;
		void org.apache.http.HttpConnection.shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "shutdown", "()V", ref global::org.apache.http.conn.ManagedClientConnection_._shutdown32131);
		}
		internal static global::MonoJavaBridge.MethodId _close32132;
		void org.apache.http.HttpConnection.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "close", "()V", ref global::org.apache.http.conn.ManagedClientConnection_._close32132);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen32133;
		bool org.apache.http.HttpConnection.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isOpen", "()Z", ref global::org.apache.http.conn.ManagedClientConnection_._isOpen32133);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics32134;
		global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpConnectionMetrics>(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", ref global::org.apache.http.conn.ManagedClientConnection_._getMetrics32134) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale32135;
		bool org.apache.http.HttpConnection.isStale()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isStale", "()Z", ref global::org.apache.http.conn.ManagedClientConnection_._isStale32135);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout32136;
		void org.apache.http.HttpConnection.setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setSocketTimeout", "(I)V", ref global::org.apache.http.conn.ManagedClientConnection_._setSocketTimeout32136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout32137;
		int org.apache.http.HttpConnection.getSocketTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getSocketTimeout", "()I", ref global::org.apache.http.conn.ManagedClientConnection_._getSocketTimeout32137);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress32138;
		global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.conn.ManagedClientConnection_._getLocalAddress32138) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort32139;
		int org.apache.http.HttpInetConnection.getLocalPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getLocalPort", "()I", ref global::org.apache.http.conn.ManagedClientConnection_._getLocalPort32139);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress32140;
		global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.conn.ManagedClientConnection_._getRemoteAddress32140) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort32141;
		int org.apache.http.HttpInetConnection.getRemotePort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRemotePort", "()I", ref global::org.apache.http.conn.ManagedClientConnection_._getRemotePort32141);
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection32142;
		void org.apache.http.conn.ConnectionReleaseTrigger.releaseConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "releaseConnection", "()V", ref global::org.apache.http.conn.ManagedClientConnection_._releaseConnection32142);
		}
		internal static global::MonoJavaBridge.MethodId _abortConnection32143;
		void org.apache.http.conn.ConnectionReleaseTrigger.abortConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "abortConnection", "()V", ref global::org.apache.http.conn.ManagedClientConnection_._abortConnection32143);
		}
		static ManagedClientConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ManagedClientConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ManagedClientConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
