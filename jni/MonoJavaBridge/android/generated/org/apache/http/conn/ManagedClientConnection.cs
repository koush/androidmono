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
		static ManagedClientConnection_()
		{
			InitJNI();
		}
		internal ManagedClientConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getState32111;
		 global::java.lang.Object org.apache.http.conn.ManagedClientConnection.getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getState32111)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getState32111)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setState32112;
		 void org.apache.http.conn.ManagedClientConnection.setState(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._setState32112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._setState32112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _open32113;
		 void org.apache.http.conn.ManagedClientConnection.open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._open32113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._open32113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32114;
		 bool org.apache.http.conn.ManagedClientConnection.isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isSecure32114);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isSecure32114);
		}
		internal static global::MonoJavaBridge.MethodId _getRoute32115;
		 global::org.apache.http.conn.routing.HttpRoute org.apache.http.conn.ManagedClientConnection.getRoute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getRoute32115)) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getRoute32115)) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _getSSLSession32116;
		 global::javax.net.ssl.SSLSession org.apache.http.conn.ManagedClientConnection.getSSLSession() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getSSLSession32116)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getSSLSession32116)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget32117;
		 void org.apache.http.conn.ManagedClientConnection.tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._tunnelTarget32117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._tunnelTarget32117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy32118;
		 void org.apache.http.conn.ManagedClientConnection.tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._tunnelProxy32118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._tunnelProxy32118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol32119;
		 void org.apache.http.conn.ManagedClientConnection.layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._layerProtocol32119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._layerProtocol32119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _markReusable32120;
		 void org.apache.http.conn.ManagedClientConnection.markReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._markReusable32120);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._markReusable32120);
		}
		internal static global::MonoJavaBridge.MethodId _unmarkReusable32121;
		 void org.apache.http.conn.ManagedClientConnection.unmarkReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._unmarkReusable32121);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._unmarkReusable32121);
		}
		internal static global::MonoJavaBridge.MethodId _isMarkedReusable32122;
		 bool org.apache.http.conn.ManagedClientConnection.isMarkedReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isMarkedReusable32122);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isMarkedReusable32122);
		}
		internal static global::MonoJavaBridge.MethodId _setIdleDuration32123;
		 void org.apache.http.conn.ManagedClientConnection.setIdleDuration(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._setIdleDuration32123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._setIdleDuration32123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _flush32124;
		 void org.apache.http.HttpClientConnection.flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._flush32124);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._flush32124);
		}
		internal static global::MonoJavaBridge.MethodId _isResponseAvailable32125;
		 bool org.apache.http.HttpClientConnection.isResponseAvailable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isResponseAvailable32125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isResponseAvailable32125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader32126;
		 void org.apache.http.HttpClientConnection.sendRequestHeader(org.apache.http.HttpRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._sendRequestHeader32126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._sendRequestHeader32126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestEntity32127;
		 void org.apache.http.HttpClientConnection.sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._sendRequestEntity32127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._sendRequestEntity32127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader32128;
		 global::org.apache.http.HttpResponse org.apache.http.HttpClientConnection.receiveResponseHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseHeader32128)) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseHeader32128)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseEntity32129;
		 void org.apache.http.HttpClientConnection.receiveResponseEntity(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseEntity32129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseEntity32129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown32130;
		 void org.apache.http.HttpConnection.shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._shutdown32130);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._shutdown32130);
		}
		internal static global::MonoJavaBridge.MethodId _close32131;
		 void org.apache.http.HttpConnection.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._close32131);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._close32131);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen32132;
		 bool org.apache.http.HttpConnection.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isOpen32132);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isOpen32132);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics32133;
		 global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getMetrics32133)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getMetrics32133)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale32134;
		 bool org.apache.http.HttpConnection.isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isStale32134);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isStale32134);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout32135;
		 void org.apache.http.HttpConnection.setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._setSocketTimeout32135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._setSocketTimeout32135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout32136;
		 int org.apache.http.HttpConnection.getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getSocketTimeout32136);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getSocketTimeout32136);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress32137;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getLocalAddress32137)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getLocalAddress32137)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort32138;
		 int org.apache.http.HttpInetConnection.getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getLocalPort32138);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getLocalPort32138);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress32139;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getRemoteAddress32139)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getRemoteAddress32139)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort32140;
		 int org.apache.http.HttpInetConnection.getRemotePort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getRemotePort32140);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getRemotePort32140);
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection32141;
		 void org.apache.http.conn.ConnectionReleaseTrigger.releaseConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._releaseConnection32141);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._releaseConnection32141);
		}
		internal static global::MonoJavaBridge.MethodId _abortConnection32142;
		 void org.apache.http.conn.ConnectionReleaseTrigger.abortConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._abortConnection32142);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._abortConnection32142);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ManagedClientConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ManagedClientConnection"));
			global::org.apache.http.conn.ManagedClientConnection_._getState32111 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getState", "()Ljava/lang/Object;");
			global::org.apache.http.conn.ManagedClientConnection_._setState32112 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setState", "(Ljava/lang/Object;)V");
			global::org.apache.http.conn.ManagedClientConnection_._open32113 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._isSecure32114 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isSecure", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._getRoute32115 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.conn.ManagedClientConnection_._getSSLSession32116 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getSSLSession", "()Ljavax/net/ssl/SSLSession;");
			global::org.apache.http.conn.ManagedClientConnection_._tunnelTarget32117 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "tunnelTarget", "(ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._tunnelProxy32118 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._layerProtocol32119 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._markReusable32120 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "markReusable", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._unmarkReusable32121 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "unmarkReusable", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._isMarkedReusable32122 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isMarkedReusable", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._setIdleDuration32123 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setIdleDuration", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.conn.ManagedClientConnection_._flush32124 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "flush", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._isResponseAvailable32125 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isResponseAvailable", "(I)Z");
			global::org.apache.http.conn.ManagedClientConnection_._sendRequestHeader32126 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.conn.ManagedClientConnection_._sendRequestEntity32127 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.conn.ManagedClientConnection_._receiveResponseHeader32128 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.conn.ManagedClientConnection_._receiveResponseEntity32129 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.conn.ManagedClientConnection_._shutdown32130 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._close32131 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "close", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._isOpen32132 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._getMetrics32133 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.conn.ManagedClientConnection_._isStale32134 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isStale", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._setSocketTimeout32135 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.conn.ManagedClientConnection_._getSocketTimeout32136 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.conn.ManagedClientConnection_._getLocalAddress32137 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.ManagedClientConnection_._getLocalPort32138 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getLocalPort", "()I");
			global::org.apache.http.conn.ManagedClientConnection_._getRemoteAddress32139 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.ManagedClientConnection_._getRemotePort32140 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRemotePort", "()I");
			global::org.apache.http.conn.ManagedClientConnection_._releaseConnection32141 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "releaseConnection", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._abortConnection32142 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "abortConnection", "()V");
		}
	}
}
