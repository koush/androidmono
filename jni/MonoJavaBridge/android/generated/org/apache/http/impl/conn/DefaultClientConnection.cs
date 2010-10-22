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
		internal static global::MonoJavaBridge.MethodId _shutdown32906;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._shutdown32906);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._shutdown32906);
		}
		internal static global::MonoJavaBridge.MethodId _close32907;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._close32907);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._close32907);
		}
		internal static global::MonoJavaBridge.MethodId _update32908;
		public virtual void update(java.net.Socket arg0, org.apache.http.HttpHost arg1, bool arg2, org.apache.http.@params.HttpParams arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._update32908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._update32908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32909;
		public virtual bool isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._isSecure32909);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._isSecure32909);
		}
		public new global::java.net.Socket Socket
		{
			get
			{
				return getSocket();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocket32910;
		public virtual global::java.net.Socket getSocket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._getSocket32910)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._getSocket32910)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader32911;
		public override void sendRequestHeader(org.apache.http.HttpRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._sendRequestHeader32911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._sendRequestHeader32911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader32912;
		public override global::org.apache.http.HttpResponse receiveResponseHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._receiveResponseHeader32912)) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._receiveResponseHeader32912)) as org.apache.http.HttpResponse;
		}
		public new global::org.apache.http.HttpHost TargetHost
		{
			get
			{
				return getTargetHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetHost32913;
		public virtual global::org.apache.http.HttpHost getTargetHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._getTargetHost32913)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpHost>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._getTargetHost32913)) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _opening32914;
		public virtual void opening(java.net.Socket arg0, org.apache.http.HttpHost arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._opening32914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._opening32914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _openCompleted32915;
		public virtual void openCompleted(bool arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._openCompleted32915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._openCompleted32915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createResponseParser32916;
		protected override global::org.apache.http.io.HttpMessageParser createResponseParser(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.HttpResponseFactory arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageParser>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._createResponseParser32916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.HttpMessageParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.HttpMessageParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._createResponseParser32916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.HttpMessageParser;
		}
		internal static global::MonoJavaBridge.MethodId _createSessionInputBuffer32917;
		protected override global::org.apache.http.io.SessionInputBuffer createSessionInputBuffer(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionInputBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._createSessionInputBuffer32917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionInputBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionInputBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._createSessionInputBuffer32917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionInputBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _createSessionOutputBuffer32918;
		protected override global::org.apache.http.io.SessionOutputBuffer createSessionOutputBuffer(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionOutputBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection._createSessionOutputBuffer32918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionOutputBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionOutputBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._createSessionOutputBuffer32918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionOutputBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultClientConnection32919;
		public DefaultClientConnection()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.DefaultClientConnection.staticClass, global::org.apache.http.impl.conn.DefaultClientConnection._DefaultClientConnection32919);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.DefaultClientConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/DefaultClientConnection"));
			global::org.apache.http.impl.conn.DefaultClientConnection._shutdown32906 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.DefaultClientConnection._close32907 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "close", "()V");
			global::org.apache.http.impl.conn.DefaultClientConnection._update32908 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "update", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.DefaultClientConnection._isSecure32909 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "isSecure", "()Z");
			global::org.apache.http.impl.conn.DefaultClientConnection._getSocket32910 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "getSocket", "()Ljava/net/Socket;");
			global::org.apache.http.impl.conn.DefaultClientConnection._sendRequestHeader32911 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.impl.conn.DefaultClientConnection._receiveResponseHeader32912 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.conn.DefaultClientConnection._getTargetHost32913 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "getTargetHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.impl.conn.DefaultClientConnection._opening32914 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "opening", "(Ljava/net/Socket;Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.impl.conn.DefaultClientConnection._openCompleted32915 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "openCompleted", "(ZLorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.DefaultClientConnection._createResponseParser32916 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "createResponseParser", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpResponseFactory;Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/HttpMessageParser;");
			global::org.apache.http.impl.conn.DefaultClientConnection._createSessionInputBuffer32917 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "createSessionInputBuffer", "(Ljava/net/Socket;ILorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/SessionInputBuffer;");
			global::org.apache.http.impl.conn.DefaultClientConnection._createSessionOutputBuffer32918 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "createSessionOutputBuffer", "(Ljava/net/Socket;ILorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/SessionOutputBuffer;");
			global::org.apache.http.impl.conn.DefaultClientConnection._DefaultClientConnection32919 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnection.staticClass, "<init>", "()V");
		}
	}
}
