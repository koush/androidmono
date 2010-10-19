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
		internal static global::MonoJavaBridge.MethodId _getState26216;
		public abstract global::java.lang.Object getState();
		internal static global::MonoJavaBridge.MethodId _setState26217;
		public abstract void setState(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _open26218;
		public abstract void open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2);
		internal static global::MonoJavaBridge.MethodId _getRoute26219;
		public abstract global::org.apache.http.conn.routing.HttpRoute getRoute();
		internal static global::MonoJavaBridge.MethodId _tunnelTarget26220;
		public abstract void tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1);
		internal static global::MonoJavaBridge.MethodId _tunnelProxy26221;
		public abstract void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2);
		internal static global::MonoJavaBridge.MethodId _layerProtocol26222;
		public abstract void layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1);
		internal static global::MonoJavaBridge.MethodId _shutdown26223;
		public abstract void shutdown();
		internal static global::MonoJavaBridge.MethodId _close26224;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _flush26225;
		public virtual void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._flush26225);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._flush26225);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen26226;
		public virtual bool isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isOpen26226);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isOpen26226);
		}
		internal static global::MonoJavaBridge.MethodId _getManager26227;
		protected virtual global::org.apache.http.conn.ClientConnectionManager getManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getManager26227)) as org.apache.http.conn.ClientConnectionManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getManager26227)) as org.apache.http.conn.ClientConnectionManager;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure26228;
		public virtual bool isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isSecure26228);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isSecure26228);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress26229;
		public virtual global::java.net.InetAddress getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalAddress26229)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalAddress26229)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort26230;
		public virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalPort26230);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalPort26230);
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection26231;
		public virtual void releaseConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._releaseConnection26231);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._releaseConnection26231);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics26232;
		public virtual global::org.apache.http.HttpConnectionMetrics getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getMetrics26232)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getMetrics26232)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isResponseAvailable26233;
		public virtual bool isResponseAvailable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isResponseAvailable26233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isResponseAvailable26233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader26234;
		public virtual void sendRequestHeader(org.apache.http.HttpRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestHeader26234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestHeader26234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestEntity26235;
		public virtual void sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestEntity26235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestEntity26235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader26236;
		public virtual global::org.apache.http.HttpResponse receiveResponseHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseHeader26236)) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseHeader26236)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseEntity26237;
		public virtual void receiveResponseEntity(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseEntity26237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseEntity26237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStale26238;
		public virtual bool isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isStale26238);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isStale26238);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout26239;
		public virtual void setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._setSocketTimeout26239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._setSocketTimeout26239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout26240;
		public virtual int getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSocketTimeout26240);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSocketTimeout26240);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress26241;
		public virtual global::java.net.InetAddress getRemoteAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemoteAddress26241)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemoteAddress26241)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort26242;
		public virtual int getRemotePort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemotePort26242);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemotePort26242);
		}
		internal static global::MonoJavaBridge.MethodId _abortConnection26243;
		public virtual void abortConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._abortConnection26243);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._abortConnection26243);
		}
		internal static global::MonoJavaBridge.MethodId _getSSLSession26244;
		public virtual global::javax.net.ssl.SSLSession getSSLSession() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSSLSession26244)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSSLSession26244)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _markReusable26245;
		public virtual void markReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._markReusable26245);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._markReusable26245);
		}
		internal static global::MonoJavaBridge.MethodId _unmarkReusable26246;
		public virtual void unmarkReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._unmarkReusable26246);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._unmarkReusable26246);
		}
		internal static global::MonoJavaBridge.MethodId _isMarkedReusable26247;
		public virtual bool isMarkedReusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isMarkedReusable26247);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._isMarkedReusable26247);
		}
		internal static global::MonoJavaBridge.MethodId _setIdleDuration26248;
		public virtual void setIdleDuration(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._setIdleDuration26248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._setIdleDuration26248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _detach26249;
		protected virtual void detach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._detach26249);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._detach26249);
		}
		internal static global::MonoJavaBridge.MethodId _getWrappedConnection26250;
		protected virtual global::org.apache.http.conn.OperatedClientConnection getWrappedConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.OperatedClientConnection>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getWrappedConnection26250)) as org.apache.http.conn.OperatedClientConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.OperatedClientConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._getWrappedConnection26250)) as org.apache.http.conn.OperatedClientConnection;
		}
		internal static global::MonoJavaBridge.MethodId _assertNotAborted26251;
		protected virtual void assertNotAborted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertNotAborted26251);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertNotAborted26251);
		}
		internal static global::MonoJavaBridge.MethodId _assertValid26252;
		protected virtual void assertValid(org.apache.http.conn.OperatedClientConnection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertValid26252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertValid26252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractClientConnAdapter26253;
		protected AbstractClientConnAdapter(org.apache.http.conn.ClientConnectionManager arg0, org.apache.http.conn.OperatedClientConnection arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter._AbstractClientConnAdapter26253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractClientConnAdapter"));
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getState26216 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getState", "()Ljava/lang/Object;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._setState26217 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "setState", "(Ljava/lang/Object;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._open26218 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRoute26219 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._tunnelTarget26220 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "tunnelTarget", "(ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._tunnelProxy26221 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._layerProtocol26222 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._shutdown26223 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._close26224 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "close", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._flush26225 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "flush", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._isOpen26226 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isOpen", "()Z");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getManager26227 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._isSecure26228 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isSecure", "()Z");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalAddress26229 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getLocalPort26230 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getLocalPort", "()I");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._releaseConnection26231 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "releaseConnection", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getMetrics26232 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._isResponseAvailable26233 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isResponseAvailable", "(I)Z");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestHeader26234 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._sendRequestEntity26235 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseHeader26236 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._receiveResponseEntity26237 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._isStale26238 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isStale", "()Z");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._setSocketTimeout26239 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSocketTimeout26240 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemoteAddress26241 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getRemotePort26242 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getRemotePort", "()I");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._abortConnection26243 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "abortConnection", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getSSLSession26244 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getSSLSession", "()Ljavax/net/ssl/SSLSession;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._markReusable26245 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "markReusable", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._unmarkReusable26246 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "unmarkReusable", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._isMarkedReusable26247 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "isMarkedReusable", "()Z");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._setIdleDuration26248 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "setIdleDuration", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._detach26249 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "detach", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._getWrappedConnection26250 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "getWrappedConnection", "()Lorg/apache/http/conn/OperatedClientConnection;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertNotAborted26251 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "assertNotAborted", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._assertValid26252 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "assertValid", "(Lorg/apache/http/conn/OperatedClientConnection;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter._AbstractClientConnAdapter26253 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter.staticClass, "<init>", "(Lorg/apache/http/conn/ClientConnectionManager;Lorg/apache/http/conn/OperatedClientConnection;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.conn.AbstractClientConnAdapter))]
	public sealed partial class AbstractClientConnAdapter_ : org.apache.http.impl.conn.AbstractClientConnAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractClientConnAdapter_()
		{
			InitJNI();
		}
		internal AbstractClientConnAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getState26254;
		public override global::java.lang.Object getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getState26254)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getState26254)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setState26255;
		public override void setState(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._setState26255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._setState26255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _open26256;
		public override void open(org.apache.http.conn.routing.HttpRoute arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._open26256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._open26256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getRoute26257;
		public override global::org.apache.http.conn.routing.HttpRoute getRoute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getRoute26257)) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getRoute26257)) as org.apache.http.conn.routing.HttpRoute;
		}
		internal static global::MonoJavaBridge.MethodId _tunnelTarget26258;
		public override void tunnelTarget(bool arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelTarget26258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelTarget26258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tunnelProxy26259;
		public override void tunnelProxy(org.apache.http.HttpHost arg0, bool arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelProxy26259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelProxy26259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _layerProtocol26260;
		public override void layerProtocol(org.apache.http.protocol.HttpContext arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._layerProtocol26260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._layerProtocol26260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown26261;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._shutdown26261);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._shutdown26261);
		}
		internal static global::MonoJavaBridge.MethodId _close26262;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._close26262);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, global::org.apache.http.impl.conn.AbstractClientConnAdapter_._close26262);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/AbstractClientConnAdapter"));
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getState26254 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "getState", "()Ljava/lang/Object;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._setState26255 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "setState", "(Ljava/lang/Object;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._open26256 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "open", "(Lorg/apache/http/conn/routing/HttpRoute;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._getRoute26257 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "getRoute", "()Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelTarget26258 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "tunnelTarget", "(ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._tunnelProxy26259 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "tunnelProxy", "(Lorg/apache/http/HttpHost;ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._layerProtocol26260 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "layerProtocol", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._shutdown26261 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.AbstractClientConnAdapter_._close26262 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.AbstractClientConnAdapter_.staticClass, "close", "()V");
		}
	}
}
