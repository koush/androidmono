namespace org.apache.http.conn
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
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

	public partial class ManagedClientConnection_
	{
		public static global::java.lang.Class _class
		{
			get { return __ManagedClientConnection.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __ManagedClientConnection : java.lang.Object, ManagedClientConnection
	{
		internal static global::java.lang.Class staticClass;
		static __ManagedClientConnection()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.conn.__ManagedClientConnection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.conn.__ManagedClientConnection(@__env);
			}
		}
		internal __ManagedClientConnection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getState14411;
		 global::java.lang.Object org.apache.http.conn.ManagedClientConnection.getState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.__ManagedClientConnection._getState14411));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._getState14411));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setState14412;
		 void org.apache.http.conn.ManagedClientConnection.setState(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._setState14412, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._setState14412, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _open14413;
		 void org.apache.http.conn.ManagedClientConnection.open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._open14413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._open14413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSecure14414;
		 bool org.apache.http.conn.ManagedClientConnection.isSecure() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.__ManagedClientConnection._isSecure14414);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._isSecure14414);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRoute14415;
		 global::org.apache.http.conn.routing.HttpRoute org.apache.http.conn.ManagedClientConnection.getRoute() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.routing.HttpRoute>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.__ManagedClientConnection._getRoute14415));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.routing.HttpRoute>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._getRoute14415));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSSLSession14416;
		 global::javax.net.ssl.SSLSession org.apache.http.conn.ManagedClientConnection.getSSLSession() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<javax.net.ssl.SSLSession>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.__ManagedClientConnection._getSSLSession14416));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<javax.net.ssl.SSLSession>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._getSSLSession14416));
		}
		internal static global::net.sf.jni4net.jni.MethodId _tunnelTarget14417;
		 void org.apache.http.conn.ManagedClientConnection.tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._tunnelTarget14417, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._tunnelTarget14417, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _tunnelProxy14418;
		 void org.apache.http.conn.ManagedClientConnection.tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._tunnelProxy14418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._tunnelProxy14418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _layerProtocol14419;
		 void org.apache.http.conn.ManagedClientConnection.layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._layerProtocol14419, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._layerProtocol14419, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _markReusable14420;
		 void org.apache.http.conn.ManagedClientConnection.markReusable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._markReusable14420);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._markReusable14420);
		}
		internal static global::net.sf.jni4net.jni.MethodId _unmarkReusable14421;
		 void org.apache.http.conn.ManagedClientConnection.unmarkReusable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._unmarkReusable14421);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._unmarkReusable14421);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMarkedReusable14422;
		 bool org.apache.http.conn.ManagedClientConnection.isMarkedReusable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.__ManagedClientConnection._isMarkedReusable14422);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._isMarkedReusable14422);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIdleDuration14423;
		 void org.apache.http.conn.ManagedClientConnection.setIdleDuration(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._setIdleDuration14423, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._setIdleDuration14423, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flush14424;
		 void org.apache.http.HttpClientConnection.flush() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._flush14424);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._flush14424);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isResponseAvailable14425;
		 bool org.apache.http.HttpClientConnection.isResponseAvailable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.__ManagedClientConnection._isResponseAvailable14425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._isResponseAvailable14425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendRequestHeader14426;
		 void org.apache.http.HttpClientConnection.sendRequestHeader(org.apache.http.HttpRequest arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._sendRequestHeader14426, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._sendRequestHeader14426, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendRequestEntity14427;
		 void org.apache.http.HttpClientConnection.sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._sendRequestEntity14427, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._sendRequestEntity14427, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _receiveResponseHeader14428;
		 global::org.apache.http.HttpResponse org.apache.http.HttpClientConnection.receiveResponseHeader() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpResponse>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.__ManagedClientConnection._receiveResponseHeader14428));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpResponse>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._receiveResponseHeader14428));
		}
		internal static global::net.sf.jni4net.jni.MethodId _receiveResponseEntity14429;
		 void org.apache.http.HttpClientConnection.receiveResponseEntity(org.apache.http.HttpResponse arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._receiveResponseEntity14429, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._receiveResponseEntity14429, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _shutdown14430;
		 void org.apache.http.HttpConnection.shutdown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._shutdown14430);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._shutdown14430);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close14431;
		 void org.apache.http.HttpConnection.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._close14431);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._close14431);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOpen14432;
		 bool org.apache.http.HttpConnection.isOpen() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.__ManagedClientConnection._isOpen14432);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._isOpen14432);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMetrics14433;
		 global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpConnectionMetrics>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.__ManagedClientConnection._getMetrics14433));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpConnectionMetrics>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._getMetrics14433));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStale14434;
		 bool org.apache.http.HttpConnection.isStale() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.__ManagedClientConnection._isStale14434);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._isStale14434);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSocketTimeout14435;
		 void org.apache.http.HttpConnection.setSocketTimeout(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._setSocketTimeout14435, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._setSocketTimeout14435, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSocketTimeout14436;
		 int org.apache.http.HttpConnection.getSocketTimeout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.conn.__ManagedClientConnection._getSocketTimeout14436);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._getSocketTimeout14436);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocalAddress14437;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.__ManagedClientConnection._getLocalAddress14437));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._getLocalAddress14437));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocalPort14438;
		 int org.apache.http.HttpInetConnection.getLocalPort() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.conn.__ManagedClientConnection._getLocalPort14438);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._getLocalPort14438);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRemoteAddress14439;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.__ManagedClientConnection._getRemoteAddress14439));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._getRemoteAddress14439));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRemotePort14440;
		 int org.apache.http.HttpInetConnection.getRemotePort() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.conn.__ManagedClientConnection._getRemotePort14440);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._getRemotePort14440);
		}
		internal static global::net.sf.jni4net.jni.MethodId _releaseConnection14441;
		 void org.apache.http.conn.ConnectionReleaseTrigger.releaseConnection() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._releaseConnection14441);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._releaseConnection14441);
		}
		internal static global::net.sf.jni4net.jni.MethodId _abortConnection14442;
		 void org.apache.http.conn.ConnectionReleaseTrigger.abortConnection() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection._abortConnection14442);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ManagedClientConnection.staticClass, global::org.apache.http.conn.__ManagedClientConnection._abortConnection14442);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.conn.__ManagedClientConnection.staticClass = @__class;
			global::org.apache.http.conn.__ManagedClientConnection._getState14411 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.conn.ManagedClientConnection.getState", "()Ljava/lang/Object;");
			global::org.apache.http.conn.__ManagedClientConnection._setState14412 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.conn.ManagedClientConnection.setState", "(Ljava/lang/Object;)V");
			global::org.apache.http.conn.__ManagedClientConnection._open14413 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.conn.ManagedClientConnection.open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.__ManagedClientConnection._isSecure14414 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.conn.ManagedClientConnection.isSecure", "()Z");
			global::org.apache.http.conn.__ManagedClientConnection._getRoute14415 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.conn.ManagedClientConnection.getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.conn.__ManagedClientConnection._getSSLSession14416 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.conn.ManagedClientConnection.getSSLSession", "()Ljavax/net/ssl/SSLSession;");
			global::org.apache.http.conn.__ManagedClientConnection._tunnelTarget14417 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.conn.ManagedClientConnection.tunnelTarget", "(ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.__ManagedClientConnection._tunnelProxy14418 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.conn.ManagedClientConnection.tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.__ManagedClientConnection._layerProtocol14419 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.conn.ManagedClientConnection.layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.__ManagedClientConnection._markReusable14420 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.conn.ManagedClientConnection.markReusable", "()V");
			global::org.apache.http.conn.__ManagedClientConnection._unmarkReusable14421 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.conn.ManagedClientConnection.unmarkReusable", "()V");
			global::org.apache.http.conn.__ManagedClientConnection._isMarkedReusable14422 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.conn.ManagedClientConnection.isMarkedReusable", "()Z");
			global::org.apache.http.conn.__ManagedClientConnection._setIdleDuration14423 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.conn.ManagedClientConnection.setIdleDuration", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.conn.__ManagedClientConnection._flush14424 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpClientConnection.flush", "()V");
			global::org.apache.http.conn.__ManagedClientConnection._isResponseAvailable14425 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpClientConnection.isResponseAvailable", "(I)Z");
			global::org.apache.http.conn.__ManagedClientConnection._sendRequestHeader14426 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpClientConnection.sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.conn.__ManagedClientConnection._sendRequestEntity14427 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpClientConnection.sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.conn.__ManagedClientConnection._receiveResponseHeader14428 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpClientConnection.receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.conn.__ManagedClientConnection._receiveResponseEntity14429 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpClientConnection.receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.conn.__ManagedClientConnection._shutdown14430 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpConnection.shutdown", "()V");
			global::org.apache.http.conn.__ManagedClientConnection._close14431 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpConnection.close", "()V");
			global::org.apache.http.conn.__ManagedClientConnection._isOpen14432 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpConnection.isOpen", "()Z");
			global::org.apache.http.conn.__ManagedClientConnection._getMetrics14433 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpConnection.getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.conn.__ManagedClientConnection._isStale14434 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpConnection.isStale", "()Z");
			global::org.apache.http.conn.__ManagedClientConnection._setSocketTimeout14435 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpConnection.setSocketTimeout", "(I)V");
			global::org.apache.http.conn.__ManagedClientConnection._getSocketTimeout14436 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpConnection.getSocketTimeout", "()I");
			global::org.apache.http.conn.__ManagedClientConnection._getLocalAddress14437 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpInetConnection.getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.__ManagedClientConnection._getLocalPort14438 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpInetConnection.getLocalPort", "()I");
			global::org.apache.http.conn.__ManagedClientConnection._getRemoteAddress14439 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpInetConnection.getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.__ManagedClientConnection._getRemotePort14440 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.HttpInetConnection.getRemotePort", "()I");
			global::org.apache.http.conn.__ManagedClientConnection._releaseConnection14441 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.conn.ConnectionReleaseTrigger.releaseConnection", "()V");
			global::org.apache.http.conn.__ManagedClientConnection._abortConnection14442 = @__env.GetMethodID(global::org.apache.http.conn.__ManagedClientConnection.staticClass, "org.apache.http.conn.ConnectionReleaseTrigger.abortConnection", "()V");
		}
	}
}
