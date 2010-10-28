namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultClientConnection : org.apache.http.impl.SocketHttpClientConnection, org.apache.http.conn.OperatedClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultClientConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown33025;
		public override void shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._shutdown33025);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._shutdown33025);
		}
		internal static global::MonoJavaBridge.MethodId _close33026;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._close33026);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._close33026);
		}
		internal static global::MonoJavaBridge.MethodId _update33027;
		public virtual void update(java.net.Socket arg0, org.apache.http.HttpHost arg1, bool arg2, org.apache.http.@params.HttpParams arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._update33027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._update33027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _isSecure33028;
		public virtual bool isSecure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._isSecure33028);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._isSecure33028);
		}
		public new global::java.net.Socket Socket
		{
			get
			{
				return getSocket();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocket33029;
		public virtual global::java.net.Socket getSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._getSocket33029)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._getSocket33029)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader33030;
		public override void sendRequestHeader(org.apache.http.HttpRequest arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._sendRequestHeader33030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._sendRequestHeader33030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader33031;
		public override global::org.apache.http.HttpResponse receiveResponseHeader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._receiveResponseHeader33031)) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._receiveResponseHeader33031)) as org.apache.http.HttpResponse;
		}
		public new global::org.apache.http.HttpHost TargetHost
		{
			get
			{
				return getTargetHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHost33032;
		public virtual global::org.apache.http.HttpHost getTargetHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._getTargetHost33032)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._getTargetHost33032)) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _opening33033;
		public virtual void opening(java.net.Socket arg0, org.apache.http.HttpHost arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._opening33033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._opening33033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _openCompleted33034;
		public virtual void openCompleted(bool arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._openCompleted33034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._openCompleted33034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createResponseParser33035;
		protected override global::org.apache.http.io.HttpMessageParser createResponseParser(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.HttpResponseFactory arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageParser>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._createResponseParser33035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.HttpMessageParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._createResponseParser33035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.HttpMessageParser;
		}
		internal static global::MonoJavaBridge.MethodId _createSessionInputBuffer33036;
		protected override global::org.apache.http.io.SessionInputBuffer createSessionInputBuffer(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionInputBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._createSessionInputBuffer33036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionInputBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionInputBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._createSessionInputBuffer33036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionInputBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _createSessionOutputBuffer33037;
		protected override global::org.apache.http.io.SessionOutputBuffer createSessionOutputBuffer(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionOutputBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._createSessionOutputBuffer33037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionOutputBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionOutputBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._createSessionOutputBuffer33037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionOutputBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultClientConnection33038;
		public DefaultClientConnection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._DefaultClientConnection33038);
			Init(@__env, handle);
		}
		static DefaultClientConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.DefaultClientConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/DefaultClientConnection"));
			global::org.apache.http.impl.conn.DefaultClientConnection._shutdown33025 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.DefaultClientConnection._close33026 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "close", "()V");
			global::org.apache.http.impl.conn.DefaultClientConnection._update33027 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "update", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.DefaultClientConnection._isSecure33028 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "isSecure", "()Z");
			global::org.apache.http.impl.conn.DefaultClientConnection._getSocket33029 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "getSocket", "()Ljava/net/Socket;");
			global::org.apache.http.impl.conn.DefaultClientConnection._sendRequestHeader33030 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.impl.conn.DefaultClientConnection._receiveResponseHeader33031 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.conn.DefaultClientConnection._getTargetHost33032 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.impl.conn.DefaultClientConnection._opening33033 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "opening", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.impl.conn.DefaultClientConnection._openCompleted33034 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "openCompleted", "(ZLorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.DefaultClientConnection._createResponseParser33035 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "createResponseParser", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpResponseFactory;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/io/HttpMessageParser;");
			global::org.apache.http.impl.conn.DefaultClientConnection._createSessionInputBuffer33036 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "createSessionInputBuffer", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/SessionInputBuffer;");
			global::org.apache.http.impl.conn.DefaultClientConnection._createSessionOutputBuffer33037 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "createSessionOutputBuffer", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/SessionOutputBuffer;");
			global::org.apache.http.impl.conn.DefaultClientConnection._DefaultClientConnection33038 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
