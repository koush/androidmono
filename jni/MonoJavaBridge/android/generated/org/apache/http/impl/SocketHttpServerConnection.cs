namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketHttpServerConnection : org.apache.http.impl.AbstractHttpServerConnection, HttpInetConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketHttpServerConnection()
		{
			InitJNI();
		}
		protected SocketHttpServerConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown25943;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._shutdown25943);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._shutdown25943);
		}
		internal static global::MonoJavaBridge.MethodId _close25944;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._close25944);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._close25944);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen25945;
		public override bool isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._isOpen25945);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._isOpen25945);
		}
		internal static global::MonoJavaBridge.MethodId _bind25946;
		protected virtual void bind(java.net.Socket arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._bind25946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._bind25946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress25947;
		public virtual global::java.net.InetAddress getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._getLocalAddress25947)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._getLocalAddress25947)) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort25948;
		public virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._getLocalPort25948);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._getLocalPort25948);
		}
		protected new global::java.net.Socket Socket
		{
			get
			{
				return getSocket();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocket25949;
		protected virtual global::java.net.Socket getSocket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._getSocket25949)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._getSocket25949)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout25950;
		public override void setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._setSocketTimeout25950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._setSocketTimeout25950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SocketTimeout
		{
			get
			{
				return getSocketTimeout();
			}
			set
			{
				setSocketTimeout(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout25951;
		public override int getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._getSocketTimeout25951);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._getSocketTimeout25951);
		}
		public new global::java.net.InetAddress RemoteAddress
		{
			get
			{
				return getRemoteAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress25952;
		public virtual global::java.net.InetAddress getRemoteAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._getRemoteAddress25952)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._getRemoteAddress25952)) as java.net.InetAddress;
		}
		public new int RemotePort
		{
			get
			{
				return getRemotePort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort25953;
		public virtual int getRemotePort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._getRemotePort25953);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._getRemotePort25953);
		}
		internal static global::MonoJavaBridge.MethodId _assertOpen25954;
		protected override void assertOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._assertOpen25954);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._assertOpen25954);
		}
		internal static global::MonoJavaBridge.MethodId _assertNotOpen25955;
		protected virtual void assertNotOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._assertNotOpen25955);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._assertNotOpen25955);
		}
		internal static global::MonoJavaBridge.MethodId _createHttpDataReceiver25956;
		protected virtual global::org.apache.http.io.SessionInputBuffer createHttpDataReceiver(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionInputBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._createHttpDataReceiver25956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionInputBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionInputBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._createHttpDataReceiver25956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionInputBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpDataTransmitter25957;
		protected virtual global::org.apache.http.io.SessionOutputBuffer createHttpDataTransmitter(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionOutputBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._createHttpDataTransmitter25957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionOutputBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionOutputBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._createHttpDataTransmitter25957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionOutputBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _SocketHttpServerConnection25958;
		public SocketHttpServerConnection()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._SocketHttpServerConnection25958);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.SocketHttpServerConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/SocketHttpServerConnection"));
			global::org.apache.http.impl.SocketHttpServerConnection._shutdown25943 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.SocketHttpServerConnection._close25944 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "close", "()V");
			global::org.apache.http.impl.SocketHttpServerConnection._isOpen25945 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "isOpen", "()Z");
			global::org.apache.http.impl.SocketHttpServerConnection._bind25946 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "bind", "(Ljava/net/Socket;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.SocketHttpServerConnection._getLocalAddress25947 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.impl.SocketHttpServerConnection._getLocalPort25948 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getLocalPort", "()I");
			global::org.apache.http.impl.SocketHttpServerConnection._getSocket25949 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getSocket", "()Ljava/net/Socket;");
			global::org.apache.http.impl.SocketHttpServerConnection._setSocketTimeout25950 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.impl.SocketHttpServerConnection._getSocketTimeout25951 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.impl.SocketHttpServerConnection._getRemoteAddress25952 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.impl.SocketHttpServerConnection._getRemotePort25953 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getRemotePort", "()I");
			global::org.apache.http.impl.SocketHttpServerConnection._assertOpen25954 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "assertOpen", "()V");
			global::org.apache.http.impl.SocketHttpServerConnection._assertNotOpen25955 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "assertNotOpen", "()V");
			global::org.apache.http.impl.SocketHttpServerConnection._createHttpDataReceiver25956 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "createHttpDataReceiver", "(Ljava/net/Socket;ILorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/SessionInputBuffer;");
			global::org.apache.http.impl.SocketHttpServerConnection._createHttpDataTransmitter25957 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "createHttpDataTransmitter", "(Ljava/net/Socket;ILorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/SessionOutputBuffer;");
			global::org.apache.http.impl.SocketHttpServerConnection._SocketHttpServerConnection25958 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "<init>", "()V");
		}
	}
}
