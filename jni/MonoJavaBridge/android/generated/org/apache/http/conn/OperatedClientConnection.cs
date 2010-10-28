namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.OperatedClientConnection_))]
	public partial interface OperatedClientConnection : HttpClientConnection, HttpInetConnection
	{
		void update(java.net.Socket arg0, org.apache.http.HttpHost arg1, bool arg2, org.apache.http.@params.HttpParams arg3);
		bool isSecure();
		global::java.net.Socket getSocket();
		global::org.apache.http.HttpHost getTargetHost();
		void opening(java.net.Socket arg0, org.apache.http.HttpHost arg1);
		void openCompleted(bool arg0, org.apache.http.@params.HttpParams arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.OperatedClientConnection))]
	internal sealed partial class OperatedClientConnection_ : java.lang.Object, OperatedClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OperatedClientConnection_()
		{
			InitJNI();
		}
		internal OperatedClientConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _update32150;
		void org.apache.http.conn.OperatedClientConnection.update(java.net.Socket arg0, org.apache.http.HttpHost arg1, bool arg2, org.apache.http.@params.HttpParams arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._update32150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._update32150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32151;
		bool org.apache.http.conn.OperatedClientConnection.isSecure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._isSecure32151);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._isSecure32151);
		}
		internal static global::MonoJavaBridge.MethodId _getSocket32152;
		global::java.net.Socket org.apache.http.conn.OperatedClientConnection.getSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getSocket32152)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getSocket32152)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHost32153;
		global::org.apache.http.HttpHost org.apache.http.conn.OperatedClientConnection.getTargetHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getTargetHost32153)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getTargetHost32153)) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _opening32154;
		void org.apache.http.conn.OperatedClientConnection.opening(java.net.Socket arg0, org.apache.http.HttpHost arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._opening32154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._opening32154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _openCompleted32155;
		void org.apache.http.conn.OperatedClientConnection.openCompleted(bool arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._openCompleted32155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._openCompleted32155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _flush32156;
		void org.apache.http.HttpClientConnection.flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._flush32156);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._flush32156);
		}
		internal static global::MonoJavaBridge.MethodId _isResponseAvailable32157;
		bool org.apache.http.HttpClientConnection.isResponseAvailable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._isResponseAvailable32157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._isResponseAvailable32157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader32158;
		void org.apache.http.HttpClientConnection.sendRequestHeader(org.apache.http.HttpRequest arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._sendRequestHeader32158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._sendRequestHeader32158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestEntity32159;
		void org.apache.http.HttpClientConnection.sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._sendRequestEntity32159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._sendRequestEntity32159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader32160;
		global::org.apache.http.HttpResponse org.apache.http.HttpClientConnection.receiveResponseHeader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._receiveResponseHeader32160)) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._receiveResponseHeader32160)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseEntity32161;
		void org.apache.http.HttpClientConnection.receiveResponseEntity(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._receiveResponseEntity32161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._receiveResponseEntity32161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown32162;
		void org.apache.http.HttpConnection.shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._shutdown32162);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._shutdown32162);
		}
		internal static global::MonoJavaBridge.MethodId _close32163;
		void org.apache.http.HttpConnection.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._close32163);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._close32163);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen32164;
		bool org.apache.http.HttpConnection.isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._isOpen32164);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._isOpen32164);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics32165;
		global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getMetrics32165)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getMetrics32165)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale32166;
		bool org.apache.http.HttpConnection.isStale()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._isStale32166);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._isStale32166);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout32167;
		void org.apache.http.HttpConnection.setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._setSocketTimeout32167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._setSocketTimeout32167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout32168;
		int org.apache.http.HttpConnection.getSocketTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getSocketTimeout32168);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getSocketTimeout32168);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress32169;
		global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getLocalAddress32169)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getLocalAddress32169)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort32170;
		int org.apache.http.HttpInetConnection.getLocalPort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getLocalPort32170);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getLocalPort32170);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress32171;
		global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getRemoteAddress32171)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getRemoteAddress32171)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort32172;
		int org.apache.http.HttpInetConnection.getRemotePort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_._getRemotePort32172);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.OperatedClientConnection_.staticClass, global::org.apache.http.conn.OperatedClientConnection_._getRemotePort32172);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.OperatedClientConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/OperatedClientConnection"));
			global::org.apache.http.conn.OperatedClientConnection_._update32150 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "update", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.conn.OperatedClientConnection_._isSecure32151 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "isSecure", "()Z");
			global::org.apache.http.conn.OperatedClientConnection_._getSocket32152 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getSocket", "()Ljava/net/Socket;");
			global::org.apache.http.conn.OperatedClientConnection_._getTargetHost32153 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.OperatedClientConnection_._opening32154 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "opening", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.conn.OperatedClientConnection_._openCompleted32155 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "openCompleted", "(ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.conn.OperatedClientConnection_._flush32156 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "flush", "()V");
			global::org.apache.http.conn.OperatedClientConnection_._isResponseAvailable32157 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "isResponseAvailable", "(I)Z");
			global::org.apache.http.conn.OperatedClientConnection_._sendRequestHeader32158 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.conn.OperatedClientConnection_._sendRequestEntity32159 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.conn.OperatedClientConnection_._receiveResponseHeader32160 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.conn.OperatedClientConnection_._receiveResponseEntity32161 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.conn.OperatedClientConnection_._shutdown32162 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.conn.OperatedClientConnection_._close32163 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "close", "()V");
			global::org.apache.http.conn.OperatedClientConnection_._isOpen32164 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.conn.OperatedClientConnection_._getMetrics32165 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.conn.OperatedClientConnection_._isStale32166 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "isStale", "()Z");
			global::org.apache.http.conn.OperatedClientConnection_._setSocketTimeout32167 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.conn.OperatedClientConnection_._getSocketTimeout32168 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.conn.OperatedClientConnection_._getLocalAddress32169 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.OperatedClientConnection_._getLocalPort32170 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getLocalPort", "()I");
			global::org.apache.http.conn.OperatedClientConnection_._getRemoteAddress32171 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.conn.OperatedClientConnection_._getRemotePort32172 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.OperatedClientConnection_.staticClass, "getRemotePort", "()I");
		}
	}
}
