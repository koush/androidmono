namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.ManagedClientConnection_))]
	public interface ManagedClientConnection : HttpClientConnection, HttpInetConnection, ConnectionReleaseTrigger
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
	public sealed partial class ManagedClientConnection_ : java.lang.Object, ManagedClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ManagedClientConnection_()
		{
			InitJNI();
		}
		internal ManagedClientConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getState16326;
		 global::java.lang.Object org.apache.http.conn.ManagedClientConnection.getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getState16326)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getState16326)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setState16327;
		 void org.apache.http.conn.ManagedClientConnection.setState(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._setState16327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._setState16327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _open16328;
		 void org.apache.http.conn.ManagedClientConnection.open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._open16328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._open16328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isSecure16329;
		 bool org.apache.http.conn.ManagedClientConnection.isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isSecure16329);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isSecure16329);
		}
		internal static global::MonoJavaBridge.MethodId _getRoute16330;
		 global::org.apache.http.conn.routing.HttpRoute org.apache.http.conn.ManagedClientConnection.getRoute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getRoute16330)) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getRoute16330)) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _getSSLSession16331;
		 global::javax.net.ssl.SSLSession org.apache.http.conn.ManagedClientConnection.getSSLSession() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getSSLSession16331)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getSSLSession16331)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget16332;
		 void org.apache.http.conn.ManagedClientConnection.tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._tunnelTarget16332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._tunnelTarget16332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy16333;
		 void org.apache.http.conn.ManagedClientConnection.tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._tunnelProxy16333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._tunnelProxy16333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol16334;
		 void org.apache.http.conn.ManagedClientConnection.layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._layerProtocol16334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._layerProtocol16334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _markReusable16335;
		 void org.apache.http.conn.ManagedClientConnection.markReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._markReusable16335);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._markReusable16335);
		}
		internal static global::MonoJavaBridge.MethodId _unmarkReusable16336;
		 void org.apache.http.conn.ManagedClientConnection.unmarkReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._unmarkReusable16336);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._unmarkReusable16336);
		}
		internal static global::MonoJavaBridge.MethodId _isMarkedReusable16337;
		 bool org.apache.http.conn.ManagedClientConnection.isMarkedReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isMarkedReusable16337);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isMarkedReusable16337);
		}
		internal static global::MonoJavaBridge.MethodId _setIdleDuration16338;
		 void org.apache.http.conn.ManagedClientConnection.setIdleDuration(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._setIdleDuration16338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._setIdleDuration16338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _flush16339;
		 void org.apache.http.HttpClientConnection.flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._flush16339);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._flush16339);
		}
		internal static global::MonoJavaBridge.MethodId _isResponseAvailable16340;
		 bool org.apache.http.HttpClientConnection.isResponseAvailable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isResponseAvailable16340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isResponseAvailable16340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader16341;
		 void org.apache.http.HttpClientConnection.sendRequestHeader(org.apache.http.HttpRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._sendRequestHeader16341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._sendRequestHeader16341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestEntity16342;
		 void org.apache.http.HttpClientConnection.sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._sendRequestEntity16342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._sendRequestEntity16342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader16343;
		 global::org.apache.http.HttpResponse org.apache.http.HttpClientConnection.receiveResponseHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseHeader16343)) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseHeader16343)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseEntity16344;
		 void org.apache.http.HttpClientConnection.receiveResponseEntity(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseEntity16344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseEntity16344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown16345;
		 void org.apache.http.HttpConnection.shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._shutdown16345);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._shutdown16345);
		}
		internal static global::MonoJavaBridge.MethodId _close16346;
		 void org.apache.http.HttpConnection.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._close16346);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._close16346);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen16347;
		 bool org.apache.http.HttpConnection.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isOpen16347);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isOpen16347);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics16348;
		 global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getMetrics16348)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getMetrics16348)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale16349;
		 bool org.apache.http.HttpConnection.isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isStale16349);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isStale16349);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout16350;
		 void org.apache.http.HttpConnection.setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._setSocketTimeout16350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._setSocketTimeout16350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout16351;
		 int org.apache.http.HttpConnection.getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getSocketTimeout16351);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getSocketTimeout16351);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress16352;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getLocalAddress16352)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getLocalAddress16352)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort16353;
		 int org.apache.http.HttpInetConnection.getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getLocalPort16353);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getLocalPort16353);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress16354;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getRemoteAddress16354)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getRemoteAddress16354)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort16355;
		 int org.apache.http.HttpInetConnection.getRemotePort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getRemotePort16355);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getRemotePort16355);
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection16356;
		 void org.apache.http.conn.ConnectionReleaseTrigger.releaseConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._releaseConnection16356);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._releaseConnection16356);
		}
		internal static global::MonoJavaBridge.MethodId _abortConnection16357;
		 void org.apache.http.conn.ConnectionReleaseTrigger.abortConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._abortConnection16357);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._abortConnection16357);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ManagedClientConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ManagedClientConnection"));
			global::org.apache.http.conn.ManagedClientConnection_._getState16326 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getState", "()Ljava/lang/Object;");
			global::org.apache.http.conn.ManagedClientConnection_._setState16327 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setState", "(Ljava/lang/Object;)V");
			global::org.apache.http.conn.ManagedClientConnection_._open16328 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._isSecure16329 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isSecure", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._getRoute16330 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.conn.ManagedClientConnection_._getSSLSession16331 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getSSLSession", "()Ljavax/net/ssl/SSLSession;");
			global::org.apache.http.conn.ManagedClientConnection_._tunnelTarget16332 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "tunnelTarget", "(ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._tunnelProxy16333 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._layerProtocol16334 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._markReusable16335 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "markReusable", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._unmarkReusable16336 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "unmarkReusable", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._isMarkedReusable16337 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isMarkedReusable", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._setIdleDuration16338 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setIdleDuration", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.conn.ManagedClientConnection_._flush16339 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "flush", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._isResponseAvailable16340 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isResponseAvailable", "(I)Z");
			global::org.apache.http.conn.ManagedClientConnection_._sendRequestHeader16341 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.conn.ManagedClientConnection_._sendRequestEntity16342 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.conn.ManagedClientConnection_._receiveResponseHeader16343 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.conn.ManagedClientConnection_._receiveResponseEntity16344 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.conn.ManagedClientConnection_._shutdown16345 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._close16346 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "close", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._isOpen16347 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._getMetrics16348 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.conn.ManagedClientConnection_._isStale16349 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isStale", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._setSocketTimeout16350 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.conn.ManagedClientConnection_._getSocketTimeout16351 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.conn.ManagedClientConnection_._getLocalAddress16352 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.ManagedClientConnection_._getLocalPort16353 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getLocalPort", "()I");
			global::org.apache.http.conn.ManagedClientConnection_._getRemoteAddress16354 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.ManagedClientConnection_._getRemotePort16355 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRemotePort", "()I");
			global::org.apache.http.conn.ManagedClientConnection_._releaseConnection16356 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "releaseConnection", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._abortConnection16357 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "abortConnection", "()V");
		}
	}
}
