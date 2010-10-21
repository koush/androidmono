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
		internal static global::MonoJavaBridge.MethodId _getState31993;
		 global::java.lang.Object org.apache.http.conn.ManagedClientConnection.getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getState31993)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getState31993)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setState31994;
		 void org.apache.http.conn.ManagedClientConnection.setState(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._setState31994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._setState31994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _open31995;
		 void org.apache.http.conn.ManagedClientConnection.open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._open31995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._open31995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isSecure31996;
		 bool org.apache.http.conn.ManagedClientConnection.isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isSecure31996);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isSecure31996);
		}
		internal static global::MonoJavaBridge.MethodId _getRoute31997;
		 global::org.apache.http.conn.routing.HttpRoute org.apache.http.conn.ManagedClientConnection.getRoute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getRoute31997)) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getRoute31997)) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _getSSLSession31998;
		 global::javax.net.ssl.SSLSession org.apache.http.conn.ManagedClientConnection.getSSLSession() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getSSLSession31998)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getSSLSession31998)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget31999;
		 void org.apache.http.conn.ManagedClientConnection.tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._tunnelTarget31999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._tunnelTarget31999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy32000;
		 void org.apache.http.conn.ManagedClientConnection.tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._tunnelProxy32000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._tunnelProxy32000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol32001;
		 void org.apache.http.conn.ManagedClientConnection.layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._layerProtocol32001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._layerProtocol32001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _markReusable32002;
		 void org.apache.http.conn.ManagedClientConnection.markReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._markReusable32002);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._markReusable32002);
		}
		internal static global::MonoJavaBridge.MethodId _unmarkReusable32003;
		 void org.apache.http.conn.ManagedClientConnection.unmarkReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._unmarkReusable32003);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._unmarkReusable32003);
		}
		internal static global::MonoJavaBridge.MethodId _isMarkedReusable32004;
		 bool org.apache.http.conn.ManagedClientConnection.isMarkedReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isMarkedReusable32004);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isMarkedReusable32004);
		}
		internal static global::MonoJavaBridge.MethodId _setIdleDuration32005;
		 void org.apache.http.conn.ManagedClientConnection.setIdleDuration(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._setIdleDuration32005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._setIdleDuration32005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _flush32006;
		 void org.apache.http.HttpClientConnection.flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._flush32006);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._flush32006);
		}
		internal static global::MonoJavaBridge.MethodId _isResponseAvailable32007;
		 bool org.apache.http.HttpClientConnection.isResponseAvailable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isResponseAvailable32007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isResponseAvailable32007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader32008;
		 void org.apache.http.HttpClientConnection.sendRequestHeader(org.apache.http.HttpRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._sendRequestHeader32008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._sendRequestHeader32008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestEntity32009;
		 void org.apache.http.HttpClientConnection.sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._sendRequestEntity32009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._sendRequestEntity32009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader32010;
		 global::org.apache.http.HttpResponse org.apache.http.HttpClientConnection.receiveResponseHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseHeader32010)) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseHeader32010)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseEntity32011;
		 void org.apache.http.HttpClientConnection.receiveResponseEntity(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseEntity32011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._receiveResponseEntity32011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown32012;
		 void org.apache.http.HttpConnection.shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._shutdown32012);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._shutdown32012);
		}
		internal static global::MonoJavaBridge.MethodId _close32013;
		 void org.apache.http.HttpConnection.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._close32013);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._close32013);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen32014;
		 bool org.apache.http.HttpConnection.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isOpen32014);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isOpen32014);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics32015;
		 global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getMetrics32015)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getMetrics32015)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale32016;
		 bool org.apache.http.HttpConnection.isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._isStale32016);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._isStale32016);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout32017;
		 void org.apache.http.HttpConnection.setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._setSocketTimeout32017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._setSocketTimeout32017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout32018;
		 int org.apache.http.HttpConnection.getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getSocketTimeout32018);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getSocketTimeout32018);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress32019;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getLocalAddress32019)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getLocalAddress32019)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort32020;
		 int org.apache.http.HttpInetConnection.getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getLocalPort32020);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getLocalPort32020);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress32021;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getRemoteAddress32021)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getRemoteAddress32021)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort32022;
		 int org.apache.http.HttpInetConnection.getRemotePort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._getRemotePort32022);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._getRemotePort32022);
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection32023;
		 void org.apache.http.conn.ConnectionReleaseTrigger.releaseConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._releaseConnection32023);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._releaseConnection32023);
		}
		internal static global::MonoJavaBridge.MethodId _abortConnection32024;
		 void org.apache.http.conn.ConnectionReleaseTrigger.abortConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_._abortConnection32024);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ManagedClientConnection_.staticClass, global::org.apache.http.conn.ManagedClientConnection_._abortConnection32024);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ManagedClientConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ManagedClientConnection"));
			global::org.apache.http.conn.ManagedClientConnection_._getState31993 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getState", "()Ljava/lang/Object;");
			global::org.apache.http.conn.ManagedClientConnection_._setState31994 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setState", "(Ljava/lang/Object;)V");
			global::org.apache.http.conn.ManagedClientConnection_._open31995 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._isSecure31996 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isSecure", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._getRoute31997 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.conn.ManagedClientConnection_._getSSLSession31998 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getSSLSession", "()Ljavax/net/ssl/SSLSession;");
			global::org.apache.http.conn.ManagedClientConnection_._tunnelTarget31999 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "tunnelTarget", "(ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._tunnelProxy32000 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._layerProtocol32001 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.ManagedClientConnection_._markReusable32002 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "markReusable", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._unmarkReusable32003 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "unmarkReusable", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._isMarkedReusable32004 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isMarkedReusable", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._setIdleDuration32005 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setIdleDuration", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.conn.ManagedClientConnection_._flush32006 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "flush", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._isResponseAvailable32007 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isResponseAvailable", "(I)Z");
			global::org.apache.http.conn.ManagedClientConnection_._sendRequestHeader32008 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.conn.ManagedClientConnection_._sendRequestEntity32009 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.conn.ManagedClientConnection_._receiveResponseHeader32010 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.conn.ManagedClientConnection_._receiveResponseEntity32011 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.conn.ManagedClientConnection_._shutdown32012 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._close32013 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "close", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._isOpen32014 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._getMetrics32015 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.conn.ManagedClientConnection_._isStale32016 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "isStale", "()Z");
			global::org.apache.http.conn.ManagedClientConnection_._setSocketTimeout32017 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.conn.ManagedClientConnection_._getSocketTimeout32018 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.conn.ManagedClientConnection_._getLocalAddress32019 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.ManagedClientConnection_._getLocalPort32020 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getLocalPort", "()I");
			global::org.apache.http.conn.ManagedClientConnection_._getRemoteAddress32021 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.ManagedClientConnection_._getRemotePort32022 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "getRemotePort", "()I");
			global::org.apache.http.conn.ManagedClientConnection_._releaseConnection32023 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "releaseConnection", "()V");
			global::org.apache.http.conn.ManagedClientConnection_._abortConnection32024 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ManagedClientConnection_.staticClass, "abortConnection", "()V");
		}
	}
}
