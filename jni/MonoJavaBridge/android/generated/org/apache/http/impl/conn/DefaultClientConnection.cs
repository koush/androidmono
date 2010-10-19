namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultClientConnection : org.apache.http.impl.SocketHttpClientConnection, org.apache.http.conn.OperatedClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DefaultClientConnection()
		{
			InitJNI();
		}
		protected DefaultClientConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown26283;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._shutdown26283);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._shutdown26283);
		}
		internal static global::MonoJavaBridge.MethodId _close26284;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._close26284);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._close26284);
		}
		internal static global::MonoJavaBridge.MethodId _update26285;
		public virtual void update(java.net.Socket arg0, org.apache.http.HttpHost arg1, bool arg2, org.apache.http.@params.HttpParams arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._update26285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._update26285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _isSecure26286;
		public virtual bool isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._isSecure26286);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._isSecure26286);
		}
		public new global::java.net.Socket Socket
		{
			get
			{
				return getSocket();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocket26287;
		public virtual global::java.net.Socket getSocket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._getSocket26287)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._getSocket26287)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader26288;
		public override void sendRequestHeader(org.apache.http.HttpRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._sendRequestHeader26288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._sendRequestHeader26288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader26289;
		public override global::org.apache.http.HttpResponse receiveResponseHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._receiveResponseHeader26289)) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._receiveResponseHeader26289)) as org.apache.http.HttpResponse;
		}
		public new global::org.apache.http.HttpHost TargetHost
		{
			get
			{
				return getTargetHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHost26290;
		public virtual global::org.apache.http.HttpHost getTargetHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._getTargetHost26290)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._getTargetHost26290)) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _opening26291;
		public virtual void opening(java.net.Socket arg0, org.apache.http.HttpHost arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._opening26291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._opening26291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _openCompleted26292;
		public virtual void openCompleted(bool arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._openCompleted26292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._openCompleted26292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createResponseParser26293;
		protected override global::org.apache.http.io.HttpMessageParser createResponseParser(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.HttpResponseFactory arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageParser>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._createResponseParser26293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.HttpMessageParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._createResponseParser26293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.HttpMessageParser;
		}
		internal static global::MonoJavaBridge.MethodId _createSessionInputBuffer26294;
		protected override global::org.apache.http.io.SessionInputBuffer createSessionInputBuffer(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionInputBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._createSessionInputBuffer26294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionInputBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionInputBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._createSessionInputBuffer26294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionInputBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _createSessionOutputBuffer26295;
		protected override global::org.apache.http.io.SessionOutputBuffer createSessionOutputBuffer(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionOutputBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._createSessionOutputBuffer26295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionOutputBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionOutputBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._createSessionOutputBuffer26295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionOutputBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultClientConnection26296;
		public DefaultClientConnection()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._DefaultClientConnection26296);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.DefaultClientConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/DefaultClientConnection"));
			global::org.apache.http.impl.conn.DefaultClientConnection._shutdown26283 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.DefaultClientConnection._close26284 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "close", "()V");
			global::org.apache.http.impl.conn.DefaultClientConnection._update26285 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "update", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.DefaultClientConnection._isSecure26286 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "isSecure", "()Z");
			global::org.apache.http.impl.conn.DefaultClientConnection._getSocket26287 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "getSocket", "()Ljava/net/Socket;");
			global::org.apache.http.impl.conn.DefaultClientConnection._sendRequestHeader26288 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.impl.conn.DefaultClientConnection._receiveResponseHeader26289 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.conn.DefaultClientConnection._getTargetHost26290 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.impl.conn.DefaultClientConnection._opening26291 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "opening", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.impl.conn.DefaultClientConnection._openCompleted26292 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "openCompleted", "(ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.DefaultClientConnection._createResponseParser26293 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "createResponseParser", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpResponseFactory;Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/HttpMessageParser;");
			global::org.apache.http.impl.conn.DefaultClientConnection._createSessionInputBuffer26294 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "createSessionInputBuffer", "(Ljava/net/Socket;ILorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/SessionInputBuffer;");
			global::org.apache.http.impl.conn.DefaultClientConnection._createSessionOutputBuffer26295 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "createSessionOutputBuffer", "(Ljava/net/Socket;ILorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/SessionOutputBuffer;");
			global::org.apache.http.impl.conn.DefaultClientConnection._DefaultClientConnection26296 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "<init>", "()V");
		}
	}
}
