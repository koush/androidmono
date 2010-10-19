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
		internal static global::MonoJavaBridge.MethodId _getState25411;
		 global::java.lang.Object org.apache.http.conn.ManagedClientConnection.getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getState25411)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getState25411)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setState25412;
		 void org.apache.http.conn.ManagedClientConnection.setState(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._setState25412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._setState25412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _open25413;
		 void org.apache.http.conn.ManagedClientConnection.open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._open25413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._open25413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isSecure25414;
		 bool org.apache.http.conn.ManagedClientConnection.isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isSecure25414);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isSecure25414);
		}
		internal static global::MonoJavaBridge.MethodId _getRoute25415;
		 global::org.apache.http.conn.routing.HttpRoute org.apache.http.conn.ManagedClientConnection.getRoute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getRoute25415)) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getRoute25415)) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _getSSLSession25416;
		 global::javax.net.ssl.SSLSession org.apache.http.conn.ManagedClientConnection.getSSLSession() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getSSLSession25416)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getSSLSession25416)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget25417;
		 void org.apache.http.conn.ManagedClientConnection.tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._tunnelTarget25417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._tunnelTarget25417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy25418;
		 void org.apache.http.conn.ManagedClientConnection.tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._tunnelProxy25418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._tunnelProxy25418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol25419;
		 void org.apache.http.conn.ManagedClientConnection.layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._layerProtocol25419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._layerProtocol25419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _markReusable25420;
		 void org.apache.http.conn.ManagedClientConnection.markReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._markReusable25420);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._markReusable25420);
		}
		internal static global::MonoJavaBridge.MethodId _unmarkReusable25421;
		 void org.apache.http.conn.ManagedClientConnection.unmarkReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._unmarkReusable25421);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._unmarkReusable25421);
		}
		internal static global::MonoJavaBridge.MethodId _isMarkedReusable25422;
		 bool org.apache.http.conn.ManagedClientConnection.isMarkedReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isMarkedReusable25422);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isMarkedReusable25422);
		}
		internal static global::MonoJavaBridge.MethodId _setIdleDuration25423;
		 void org.apache.http.conn.ManagedClientConnection.setIdleDuration(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._setIdleDuration25423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._setIdleDuration25423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _flush25424;
		 void org.apache.http.HttpClientConnection.flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._flush25424);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._flush25424);
		}
		internal static global::MonoJavaBridge.MethodId _isResponseAvailable25425;
		 bool org.apache.http.HttpClientConnection.isResponseAvailable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isResponseAvailable25425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isResponseAvailable25425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader25426;
		 void org.apache.http.HttpClientConnection.sendRequestHeader(org.apache.http.HttpRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._sendRequestHeader25426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._sendRequestHeader25426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestEntity25427;
		 void org.apache.http.HttpClientConnection.sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._sendRequestEntity25427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._sendRequestEntity25427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader25428;
		 global::org.apache.http.HttpResponse org.apache.http.HttpClientConnection.receiveResponseHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseHeader25428)) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseHeader25428)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseEntity25429;
		 void org.apache.http.HttpClientConnection.receiveResponseEntity(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseEntity25429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseEntity25429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown25430;
		 void org.apache.http.HttpConnection.shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._shutdown25430);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._shutdown25430);
		}
		internal static global::MonoJavaBridge.MethodId _close25431;
		 void org.apache.http.HttpConnection.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._close25431);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._close25431);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen25432;
		 bool org.apache.http.HttpConnection.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isOpen25432);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isOpen25432);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics25433;
		 global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getMetrics25433)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getMetrics25433)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale25434;
		 bool org.apache.http.HttpConnection.isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isStale25434);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isStale25434);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout25435;
		 void org.apache.http.HttpConnection.setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._setSocketTimeout25435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._setSocketTimeout25435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout25436;
		 int org.apache.http.HttpConnection.getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getSocketTimeout25436);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getSocketTimeout25436);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress25437;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getLocalAddress25437)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getLocalAddress25437)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort25438;
		 int org.apache.http.HttpInetConnection.getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getLocalPort25438);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getLocalPort25438);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress25439;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getRemoteAddress25439)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getRemoteAddress25439)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort25440;
		 int org.apache.http.HttpInetConnection.getRemotePort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getRemotePort25440);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getRemotePort25440);
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection25441;
		 void org.apache.http.conn.ConnectionReleaseTrigger.releaseConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._releaseConnection25441);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._releaseConnection25441);
		}
		internal static global::MonoJavaBridge.MethodId _abortConnection25442;
		 void org.apache.http.conn.ConnectionReleaseTrigger.abortConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._abortConnection25442);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._abortConnection25442);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ManagedClientConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ManagedClientConnection"));
			global::org.apache.http.conn.ManagedClientConnection_._getState25411 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getState", "()Ljava/lang/Object;");
			global::org.apache.http.conn.ManagedClientConnection_._setState25412 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setState", "(Ljava/lang/Object;)V");
			global::org.apache.http.conn.ManagedClientConnection_._open25413 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._isSecure25414 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isSecure", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._getRoute25415 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.conn.ManagedClientConnection_._getSSLSession25416 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getSSLSession", "()Ljavax/net/ssl/SSLSession;");
			global::org.apache.http.conn.ManagedClientConnection_._tunnelTarget25417 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "tunnelTarget", "(ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._tunnelProxy25418 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._layerProtocol25419 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._markReusable25420 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "markReusable", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._unmarkReusable25421 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "unmarkReusable", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._isMarkedReusable25422 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isMarkedReusable", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._setIdleDuration25423 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setIdleDuration", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.conn.ManagedClientConnection_._flush25424 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "flush", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._isResponseAvailable25425 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isResponseAvailable", "(I)Z");
			global::org.apache.http.conn.ManagedClientConnection_._sendRequestHeader25426 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.conn.ManagedClientConnection_._sendRequestEntity25427 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.conn.ManagedClientConnection_._receiveResponseHeader25428 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.conn.ManagedClientConnection_._receiveResponseEntity25429 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.conn.ManagedClientConnection_._shutdown25430 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._close25431 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "close", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._isOpen25432 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._getMetrics25433 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.conn.ManagedClientConnection_._isStale25434 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isStale", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._setSocketTimeout25435 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.conn.ManagedClientConnection_._getSocketTimeout25436 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.conn.ManagedClientConnection_._getLocalAddress25437 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.ManagedClientConnection_._getLocalPort25438 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getLocalPort", "()I");
			global::org.apache.http.conn.ManagedClientConnection_._getRemoteAddress25439 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.ManagedClientConnection_._getRemotePort25440 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRemotePort", "()I");
			global::org.apache.http.conn.ManagedClientConnection_._releaseConnection25441 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "releaseConnection", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._abortConnection25442 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "abortConnection", "()V");
		}
	}
}
