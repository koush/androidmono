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
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object org.apache.http.conn.ManagedClientConnection.getState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getState", "()Ljava/lang/Object;", ref global::org.apache.http.conn.ManagedClientConnection_._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.apache.http.conn.ManagedClientConnection.setState(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setState", "(Ljava/lang/Object;)V", ref global::org.apache.http.conn.ManagedClientConnection_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.apache.http.conn.ManagedClientConnection.open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.conn.ManagedClientConnection_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool org.apache.http.conn.ManagedClientConnection.isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isSecure", "()Z", ref global::org.apache.http.conn.ManagedClientConnection_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::org.apache.http.conn.routing.HttpRoute org.apache.http.conn.ManagedClientConnection.getRoute()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.HttpRoute>(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;", ref global::org.apache.http.conn.ManagedClientConnection_._m4) as org.apache.http.conn.routing.HttpRoute;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::javax.net.ssl.SSLSession org.apache.http.conn.ManagedClientConnection.getSSLSession()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSession>(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getSSLSession", "()Ljavax/net/ssl/SSLSession;", ref global::org.apache.http.conn.ManagedClientConnection_._m5) as javax.net.ssl.SSLSession;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.apache.http.conn.ManagedClientConnection.tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.conn.ManagedClientConnection_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void org.apache.http.conn.ManagedClientConnection.tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.conn.ManagedClientConnection_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void org.apache.http.conn.ManagedClientConnection.layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.conn.ManagedClientConnection_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void org.apache.http.conn.ManagedClientConnection.markReusable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "markReusable", "()V", ref global::org.apache.http.conn.ManagedClientConnection_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void org.apache.http.conn.ManagedClientConnection.unmarkReusable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "unmarkReusable", "()V", ref global::org.apache.http.conn.ManagedClientConnection_._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		bool org.apache.http.conn.ManagedClientConnection.isMarkedReusable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isMarkedReusable", "()Z", ref global::org.apache.http.conn.ManagedClientConnection_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void org.apache.http.conn.ManagedClientConnection.setIdleDuration(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setIdleDuration", "(JLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.conn.ManagedClientConnection_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void org.apache.http.HttpClientConnection.flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "flush", "()V", ref global::org.apache.http.conn.ManagedClientConnection_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		bool org.apache.http.HttpClientConnection.isResponseAvailable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isResponseAvailable", "(I)Z", ref global::org.apache.http.conn.ManagedClientConnection_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void org.apache.http.HttpClientConnection.sendRequestHeader(org.apache.http.HttpRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V", ref global::org.apache.http.conn.ManagedClientConnection_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void org.apache.http.HttpClientConnection.sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", ref global::org.apache.http.conn.ManagedClientConnection_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		global::org.apache.http.HttpResponse org.apache.http.HttpClientConnection.receiveResponseHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;", ref global::org.apache.http.conn.ManagedClientConnection_._m17) as org.apache.http.HttpResponse;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void org.apache.http.HttpClientConnection.receiveResponseEntity(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V", ref global::org.apache.http.conn.ManagedClientConnection_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		void org.apache.http.HttpConnection.shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "shutdown", "()V", ref global::org.apache.http.conn.ManagedClientConnection_._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		void org.apache.http.HttpConnection.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "close", "()V", ref global::org.apache.http.conn.ManagedClientConnection_._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		bool org.apache.http.HttpConnection.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isOpen", "()Z", ref global::org.apache.http.conn.ManagedClientConnection_._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpConnectionMetrics>(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", ref global::org.apache.http.conn.ManagedClientConnection_._m22) as org.apache.http.HttpConnectionMetrics;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		bool org.apache.http.HttpConnection.isStale()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isStale", "()Z", ref global::org.apache.http.conn.ManagedClientConnection_._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		void org.apache.http.HttpConnection.setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setSocketTimeout", "(I)V", ref global::org.apache.http.conn.ManagedClientConnection_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		int org.apache.http.HttpConnection.getSocketTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getSocketTimeout", "()I", ref global::org.apache.http.conn.ManagedClientConnection_._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.conn.ManagedClientConnection_._m26) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		int org.apache.http.HttpInetConnection.getLocalPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getLocalPort", "()I", ref global::org.apache.http.conn.ManagedClientConnection_._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.conn.ManagedClientConnection_._m28) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		int org.apache.http.HttpInetConnection.getRemotePort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRemotePort", "()I", ref global::org.apache.http.conn.ManagedClientConnection_._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		void org.apache.http.conn.ConnectionReleaseTrigger.releaseConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "releaseConnection", "()V", ref global::org.apache.http.conn.ManagedClientConnection_._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		void org.apache.http.conn.ConnectionReleaseTrigger.abortConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ManagedClientConnection_.staticClass, "abortConnection", "()V", ref global::org.apache.http.conn.ManagedClientConnection_._m31);
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
