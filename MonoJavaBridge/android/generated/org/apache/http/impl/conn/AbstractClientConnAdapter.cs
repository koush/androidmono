namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.conn.AbstractClientConnAdapter_))]
	public abstract partial class AbstractClientConnAdapter : java.lang.Object, org.apache.http.conn.ManagedClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractClientConnAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getState32958;
		public abstract global::java.lang.Object getState();
		internal static global::MonoJavaBridge.MethodId _setState32959;
		public abstract void setState(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _open32960;
		public abstract void open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2);
		internal static global::MonoJavaBridge.MethodId _getRoute32961;
		public abstract global::org.apache.http.conn.routing.HttpRoute getRoute();
		internal static global::MonoJavaBridge.MethodId _tunnelTarget32962;
		public abstract void tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1);
		internal static global::MonoJavaBridge.MethodId _tunnelProxy32963;
		public abstract void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2);
		internal static global::MonoJavaBridge.MethodId _layerProtocol32964;
		public abstract void layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1);
		internal static global::MonoJavaBridge.MethodId _shutdown32965;
		public abstract void shutdown();
		internal static global::MonoJavaBridge.MethodId _close32966;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _flush32967;
		public virtual void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._flush32967);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen32968;
		public virtual bool isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isOpen32968);
		}
		internal static global::MonoJavaBridge.MethodId _getManager32969;
		protected virtual global::org.apache.http.conn.ClientConnectionManager getManager()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getManager32969)) as org.apache.http.conn.ClientConnectionManager;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32970;
		public virtual bool isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isSecure32970);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress32971;
		public virtual global::java.net.InetAddress getLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalAddress32971)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort32972;
		public virtual int getLocalPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalPort32972);
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection32973;
		public virtual void releaseConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._releaseConnection32973);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics32974;
		public virtual global::org.apache.http.HttpConnectionMetrics getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getMetrics32974)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isResponseAvailable32975;
		public virtual bool isResponseAvailable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isResponseAvailable32975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader32976;
		public virtual void sendRequestHeader(org.apache.http.HttpRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestHeader32976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestEntity32977;
		public virtual void sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestEntity32977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader32978;
		public virtual global::org.apache.http.HttpResponse receiveResponseHeader()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseHeader32978)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseEntity32979;
		public virtual void receiveResponseEntity(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseEntity32979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStale32980;
		public virtual bool isStale()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isStale32980);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout32981;
		public virtual void setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._setSocketTimeout32981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout32982;
		public virtual int getSocketTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSocketTimeout32982);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress32983;
		public virtual global::java.net.InetAddress getRemoteAddress()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemoteAddress32983)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort32984;
		public virtual int getRemotePort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemotePort32984);
		}
		internal static global::MonoJavaBridge.MethodId _abortConnection32985;
		public virtual void abortConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._abortConnection32985);
		}
		internal static global::MonoJavaBridge.MethodId _getSSLSession32986;
		public virtual global::javax.net.ssl.SSLSession getSSLSession()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSSLSession32986)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _markReusable32987;
		public virtual void markReusable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._markReusable32987);
		}
		internal static global::MonoJavaBridge.MethodId _unmarkReusable32988;
		public virtual void unmarkReusable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._unmarkReusable32988);
		}
		internal static global::MonoJavaBridge.MethodId _isMarkedReusable32989;
		public virtual bool isMarkedReusable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isMarkedReusable32989);
		}
		internal static global::MonoJavaBridge.MethodId _setIdleDuration32990;
		public virtual void setIdleDuration(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._setIdleDuration32990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _detach32991;
		protected virtual void detach()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._detach32991);
		}
		internal static global::MonoJavaBridge.MethodId _getWrappedConnection32992;
		protected virtual global::org.apache.http.conn.OperatedClientConnection getWrappedConnection()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.OperatedClientConnection>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getWrappedConnection32992)) as org.apache.http.conn.OperatedClientConnection;
		}
		internal static global::MonoJavaBridge.MethodId _assertNotAborted32993;
		protected virtual void assertNotAborted()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertNotAborted32993);
		}
		internal static global::MonoJavaBridge.MethodId _assertValid32994;
		protected virtual void assertValid(org.apache.http.conn.OperatedClientConnection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertValid32994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractClientConnAdapter32995;
		protected AbstractClientConnAdapter(org.apache.http.conn.ClientConnectionManager arg0, org.apache.http.conn.OperatedClientConnection arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._AbstractClientConnAdapter32995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AbstractClientConnAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractClientConnAdapter"));
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getState32958 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getState", "()Ljava/lang/Object;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._setState32959 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "setState", "(Ljava/lang/Object;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._open32960 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRoute32961 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._tunnelTarget32962 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._tunnelProxy32963 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._layerProtocol32964 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._shutdown32965 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._close32966 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "close", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._flush32967 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "flush", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._isOpen32968 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isOpen", "()Z");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getManager32969 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._isSecure32970 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isSecure", "()Z");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalAddress32971 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalPort32972 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getLocalPort", "()I");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._releaseConnection32973 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "releaseConnection", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getMetrics32974 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._isResponseAvailable32975 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isResponseAvailable", "(I)Z");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestHeader32976 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestEntity32977 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseHeader32978 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseEntity32979 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._isStale32980 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isStale", "()Z");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._setSocketTimeout32981 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSocketTimeout32982 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemoteAddress32983 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemotePort32984 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getRemotePort", "()I");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._abortConnection32985 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "abortConnection", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSSLSession32986 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getSSLSession", "()Ljavax/net/ssl/SSLSession;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._markReusable32987 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "markReusable", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._unmarkReusable32988 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "unmarkReusable", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._isMarkedReusable32989 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isMarkedReusable", "()Z");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._setIdleDuration32990 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "setIdleDuration", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._detach32991 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "detach", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getWrappedConnection32992 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getWrappedConnection", "()Lorg/apache/http/conn/OperatedClientConnection;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertNotAborted32993 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "assertNotAborted", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertValid32994 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "assertValid", "(Lorg/apache/http/conn/OperatedClientConnection;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._AbstractClientConnAdapter32995 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/conn/OperatedClientConnection;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.conn.AbstractClientConnAdapter))]
	internal sealed partial class AbstractClientConnAdapter_ : org.apache.http.impl.conn.AbstractClientConnAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractClientConnAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getState32996;
		public override global::java.lang.Object getState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getState32996)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setState32997;
		public override void setState(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._setState32997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _open32998;
		public override void open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._open32998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getRoute32999;
		public override global::org.apache.http.conn.routing.HttpRoute getRoute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getRoute32999)) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget33000;
		public override void tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelTarget33000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy33001;
		public override void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelProxy33001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol33002;
		public override void layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._layerProtocol33002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown33003;
		public override void shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._shutdown33003);
		}
		internal static global::MonoJavaBridge.MethodId _close33004;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._close33004);
		}
		static AbstractClientConnAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractClientConnAdapter"));
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getState32996 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "getState", "()Ljava/lang/Object;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._setState32997 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "setState", "(Ljava/lang/Object;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._open32998 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getRoute32999 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelTarget33000 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelProxy33001 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._layerProtocol33002 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._shutdown33003 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._close33004 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "close", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
