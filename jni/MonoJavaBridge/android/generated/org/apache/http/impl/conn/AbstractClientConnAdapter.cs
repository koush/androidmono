namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.conn.AbstractClientConnAdapter_))]
	public abstract partial class AbstractClientConnAdapter : java.lang.Object, org.apache.http.conn.ManagedClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractClientConnAdapter()
		{
			InitJNI();
		}
		protected AbstractClientConnAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getState32957;
		public abstract global::java.lang.Object getState();
		internal static global::MonoJavaBridge.MethodId _setState32958;
		public abstract void setState(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _open32959;
		public abstract void open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2);
		internal static global::MonoJavaBridge.MethodId _getRoute32960;
		public abstract global::org.apache.http.conn.routing.HttpRoute getRoute();
		internal static global::MonoJavaBridge.MethodId _tunnelTarget32961;
		public abstract void tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1);
		internal static global::MonoJavaBridge.MethodId _tunnelProxy32962;
		public abstract void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2);
		internal static global::MonoJavaBridge.MethodId _layerProtocol32963;
		public abstract void layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1);
		internal static global::MonoJavaBridge.MethodId _shutdown32964;
		public abstract void shutdown();
		internal static global::MonoJavaBridge.MethodId _close32965;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _flush32966;
		public virtual void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._flush32966);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._flush32966);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen32967;
		public virtual bool isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isOpen32967);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isOpen32967);
		}
		internal static global::MonoJavaBridge.MethodId _getManager32968;
		protected virtual global::org.apache.http.conn.ClientConnectionManager getManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getManager32968)) as org.apache.http.conn.ClientConnectionManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getManager32968)) as org.apache.http.conn.ClientConnectionManager;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32969;
		public virtual bool isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isSecure32969);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isSecure32969);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress32970;
		public virtual global::java.net.InetAddress getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalAddress32970)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalAddress32970)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort32971;
		public virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalPort32971);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalPort32971);
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection32972;
		public virtual void releaseConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._releaseConnection32972);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._releaseConnection32972);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics32973;
		public virtual global::org.apache.http.HttpConnectionMetrics getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getMetrics32973)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getMetrics32973)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isResponseAvailable32974;
		public virtual bool isResponseAvailable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isResponseAvailable32974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isResponseAvailable32974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader32975;
		public virtual void sendRequestHeader(org.apache.http.HttpRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestHeader32975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestHeader32975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestEntity32976;
		public virtual void sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestEntity32976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestEntity32976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader32977;
		public virtual global::org.apache.http.HttpResponse receiveResponseHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseHeader32977)) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseHeader32977)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseEntity32978;
		public virtual void receiveResponseEntity(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseEntity32978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseEntity32978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStale32979;
		public virtual bool isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isStale32979);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isStale32979);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout32980;
		public virtual void setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._setSocketTimeout32980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._setSocketTimeout32980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout32981;
		public virtual int getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSocketTimeout32981);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSocketTimeout32981);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress32982;
		public virtual global::java.net.InetAddress getRemoteAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemoteAddress32982)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemoteAddress32982)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort32983;
		public virtual int getRemotePort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemotePort32983);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemotePort32983);
		}
		internal static global::MonoJavaBridge.MethodId _abortConnection32984;
		public virtual void abortConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._abortConnection32984);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._abortConnection32984);
		}
		internal static global::MonoJavaBridge.MethodId _getSSLSession32985;
		public virtual global::javax.net.ssl.SSLSession getSSLSession() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSSLSession32985)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSSLSession32985)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _markReusable32986;
		public virtual void markReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._markReusable32986);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._markReusable32986);
		}
		internal static global::MonoJavaBridge.MethodId _unmarkReusable32987;
		public virtual void unmarkReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._unmarkReusable32987);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._unmarkReusable32987);
		}
		internal static global::MonoJavaBridge.MethodId _isMarkedReusable32988;
		public virtual bool isMarkedReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isMarkedReusable32988);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isMarkedReusable32988);
		}
		internal static global::MonoJavaBridge.MethodId _setIdleDuration32989;
		public virtual void setIdleDuration(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._setIdleDuration32989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._setIdleDuration32989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _detach32990;
		protected virtual void detach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._detach32990);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._detach32990);
		}
		internal static global::MonoJavaBridge.MethodId _getWrappedConnection32991;
		protected virtual global::org.apache.http.conn.OperatedClientConnection getWrappedConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.OperatedClientConnection>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getWrappedConnection32991)) as org.apache.http.conn.OperatedClientConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.OperatedClientConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getWrappedConnection32991)) as org.apache.http.conn.OperatedClientConnection;
		}
		internal static global::MonoJavaBridge.MethodId _assertNotAborted32992;
		protected virtual void assertNotAborted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertNotAborted32992);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertNotAborted32992);
		}
		internal static global::MonoJavaBridge.MethodId _assertValid32993;
		protected virtual void assertValid(org.apache.http.conn.OperatedClientConnection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertValid32993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertValid32993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractClientConnAdapter32994;
		protected AbstractClientConnAdapter(org.apache.http.conn.ClientConnectionManager arg0, org.apache.http.conn.OperatedClientConnection arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._AbstractClientConnAdapter32994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractClientConnAdapter"));
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getState32957 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getState", "()Ljava/lang/Object;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._setState32958 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "setState", "(Ljava/lang/Object;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._open32959 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRoute32960 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._tunnelTarget32961 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._tunnelProxy32962 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._layerProtocol32963 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._shutdown32964 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._close32965 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "close", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._flush32966 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "flush", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._isOpen32967 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isOpen", "()Z");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getManager32968 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._isSecure32969 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isSecure", "()Z");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalAddress32970 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalPort32971 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getLocalPort", "()I");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._releaseConnection32972 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "releaseConnection", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getMetrics32973 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._isResponseAvailable32974 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isResponseAvailable", "(I)Z");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestHeader32975 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestEntity32976 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseHeader32977 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseEntity32978 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._isStale32979 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isStale", "()Z");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._setSocketTimeout32980 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSocketTimeout32981 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemoteAddress32982 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemotePort32983 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getRemotePort", "()I");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._abortConnection32984 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "abortConnection", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSSLSession32985 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getSSLSession", "()Ljavax/net/ssl/SSLSession;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._markReusable32986 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "markReusable", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._unmarkReusable32987 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "unmarkReusable", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._isMarkedReusable32988 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isMarkedReusable", "()Z");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._setIdleDuration32989 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "setIdleDuration", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._detach32990 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "detach", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getWrappedConnection32991 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getWrappedConnection", "()Lorg/apache/http/conn/OperatedClientConnection;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertNotAborted32992 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "assertNotAborted", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertValid32993 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "assertValid", "(Lorg/apache/http/conn/OperatedClientConnection;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._AbstractClientConnAdapter32994 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/conn/OperatedClientConnection;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.conn.AbstractClientConnAdapter))]
	internal sealed partial class AbstractClientConnAdapter_ : org.apache.http.impl.conn.AbstractClientConnAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractClientConnAdapter_()
		{
			InitJNI();
		}
		internal AbstractClientConnAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getState32995;
		public override global::java.lang.Object getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getState32995)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getState32995)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setState32996;
		public override void setState(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._setState32996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._setState32996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _open32997;
		public override void open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._open32997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._open32997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getRoute32998;
		public override global::org.apache.http.conn.routing.HttpRoute getRoute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getRoute32998)) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getRoute32998)) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget32999;
		public override void tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelTarget32999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelTarget32999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy33000;
		public override void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelProxy33000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelProxy33000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol33001;
		public override void layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._layerProtocol33001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._layerProtocol33001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown33002;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._shutdown33002);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._shutdown33002);
		}
		internal static global::MonoJavaBridge.MethodId _close33003;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._close33003);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._close33003);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractClientConnAdapter"));
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getState32995 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "getState", "()Ljava/lang/Object;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._setState32996 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "setState", "(Ljava/lang/Object;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._open32997 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getRoute32998 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelTarget32999 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelProxy33000 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._layerProtocol33001 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._shutdown33002 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._close33003 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "close", "()V");
		}
	}
}
