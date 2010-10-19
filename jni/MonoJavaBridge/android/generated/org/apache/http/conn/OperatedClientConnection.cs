namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.OperatedClientConnection_))]
	public interface OperatedClientConnection : HttpClientConnection, HttpInetConnection
	{
		void update(java.net.Socket arg0, org.apache.http.HttpHost arg1, bool arg2, org.apache.http.@params.HttpParams arg3);
		bool isSecure();
		global::java.net.Socket getSocket();
		global::org.apache.http.HttpHost getTargetHost();
		void opening(java.net.Socket arg0, org.apache.http.HttpHost arg1);
		void openCompleted(bool arg0, org.apache.http.@params.HttpParams arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.OperatedClientConnection))]
	public sealed partial class OperatedClientConnection_ : java.lang.Object, OperatedClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OperatedClientConnection_()
		{
			InitJNI();
		}
		internal OperatedClientConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _update25449;
		 void org.apache.http.conn.OperatedClientConnection.update(java.net.Socket arg0, org.apache.http.HttpHost arg1, bool arg2, org.apache.http.@params.HttpParams arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._update25449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._update25449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _isSecure25450;
		 bool org.apache.http.conn.OperatedClientConnection.isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._isSecure25450);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._isSecure25450);
		}
		internal static global::MonoJavaBridge.MethodId _getSocket25451;
		 global::java.net.Socket org.apache.http.conn.OperatedClientConnection.getSocket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getSocket25451)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getSocket25451)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHost25452;
		 global::org.apache.http.HttpHost org.apache.http.conn.OperatedClientConnection.getTargetHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getTargetHost25452)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getTargetHost25452)) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _opening25453;
		 void org.apache.http.conn.OperatedClientConnection.opening(java.net.Socket arg0, org.apache.http.HttpHost arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._opening25453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._opening25453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _openCompleted25454;
		 void org.apache.http.conn.OperatedClientConnection.openCompleted(bool arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._openCompleted25454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._openCompleted25454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _flush25455;
		 void org.apache.http.HttpClientConnection.flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._flush25455);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._flush25455);
		}
		internal static global::MonoJavaBridge.MethodId _isResponseAvailable25456;
		 bool org.apache.http.HttpClientConnection.isResponseAvailable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._isResponseAvailable25456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._isResponseAvailable25456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader25457;
		 void org.apache.http.HttpClientConnection.sendRequestHeader(org.apache.http.HttpRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._sendRequestHeader25457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._sendRequestHeader25457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestEntity25458;
		 void org.apache.http.HttpClientConnection.sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._sendRequestEntity25458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._sendRequestEntity25458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader25459;
		 global::org.apache.http.HttpResponse org.apache.http.HttpClientConnection.receiveResponseHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._receiveResponseHeader25459)) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._receiveResponseHeader25459)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseEntity25460;
		 void org.apache.http.HttpClientConnection.receiveResponseEntity(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._receiveResponseEntity25460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._receiveResponseEntity25460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown25461;
		 void org.apache.http.HttpConnection.shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._shutdown25461);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._shutdown25461);
		}
		internal static global::MonoJavaBridge.MethodId _close25462;
		 void org.apache.http.HttpConnection.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._close25462);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._close25462);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen25463;
		 bool org.apache.http.HttpConnection.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._isOpen25463);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._isOpen25463);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics25464;
		 global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getMetrics25464)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getMetrics25464)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale25465;
		 bool org.apache.http.HttpConnection.isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._isStale25465);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._isStale25465);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout25466;
		 void org.apache.http.HttpConnection.setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._setSocketTimeout25466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._setSocketTimeout25466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout25467;
		 int org.apache.http.HttpConnection.getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getSocketTimeout25467);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getSocketTimeout25467);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress25468;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getLocalAddress25468)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getLocalAddress25468)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort25469;
		 int org.apache.http.HttpInetConnection.getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getLocalPort25469);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getLocalPort25469);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress25470;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getRemoteAddress25470)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getRemoteAddress25470)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort25471;
		 int org.apache.http.HttpInetConnection.getRemotePort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getRemotePort25471);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getRemotePort25471);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.OperatedClientConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/OperatedClientConnection"));
			global::org.apache.http.conn.OperatedClientConnection_._update25449 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "update", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.OperatedClientConnection_._isSecure25450 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "isSecure", "()Z");
			global::org.apache.http.conn.OperatedClientConnection_._getSocket25451 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getSocket", "()Ljava/net/Socket;");
			global::org.apache.http.conn.OperatedClientConnection_._getTargetHost25452 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.OperatedClientConnection_._opening25453 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "opening", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.conn.OperatedClientConnection_._openCompleted25454 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "openCompleted", "(ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.OperatedClientConnection_._flush25455 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "flush", "()V");
			global::org.apache.http.conn.OperatedClientConnection_._isResponseAvailable25456 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "isResponseAvailable", "(I)Z");
			global::org.apache.http.conn.OperatedClientConnection_._sendRequestHeader25457 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.conn.OperatedClientConnection_._sendRequestEntity25458 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.conn.OperatedClientConnection_._receiveResponseHeader25459 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.conn.OperatedClientConnection_._receiveResponseEntity25460 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.conn.OperatedClientConnection_._shutdown25461 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.conn.OperatedClientConnection_._close25462 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "close", "()V");
			global::org.apache.http.conn.OperatedClientConnection_._isOpen25463 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.conn.OperatedClientConnection_._getMetrics25464 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.conn.OperatedClientConnection_._isStale25465 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "isStale", "()Z");
			global::org.apache.http.conn.OperatedClientConnection_._setSocketTimeout25466 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.conn.OperatedClientConnection_._getSocketTimeout25467 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.conn.OperatedClientConnection_._getLocalAddress25468 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.OperatedClientConnection_._getLocalPort25469 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getLocalPort", "()I");
			global::org.apache.http.conn.OperatedClientConnection_._getRemoteAddress25470 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.OperatedClientConnection_._getRemotePort25471 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getRemotePort", "()I");
		}
	}
}
