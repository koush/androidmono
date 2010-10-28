namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketHttpClientConnection : org.apache.http.impl.AbstractHttpClientConnection, HttpInetConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketHttpClientConnection()
		{
			InitJNI();
		}
		protected SocketHttpClientConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown32669;
		public override void shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._shutdown32669);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._shutdown32669);
		}
		internal static global::MonoJavaBridge.MethodId _close32670;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._close32670);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._close32670);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen32671;
		public override bool isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._isOpen32671);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._isOpen32671);
		}
		internal static global::MonoJavaBridge.MethodId _bind32672;
		protected virtual void bind(java.net.Socket arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._bind32672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._bind32672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress32673;
		public virtual global::java.net.InetAddress getLocalAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._getLocalAddress32673)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._getLocalAddress32673)) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort32674;
		public virtual int getLocalPort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._getLocalPort32674);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._getLocalPort32674);
		}
		protected new global::java.net.Socket Socket
		{
			get
			{
				return getSocket();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocket32675;
		protected virtual global::java.net.Socket getSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._getSocket32675)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._getSocket32675)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout32676;
		public override void setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._setSocketTimeout32676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._setSocketTimeout32676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout32677;
		public override int getSocketTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._getSocketTimeout32677);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._getSocketTimeout32677);
		}
		public new global::java.net.InetAddress RemoteAddress
		{
			get
			{
				return getRemoteAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress32678;
		public virtual global::java.net.InetAddress getRemoteAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._getRemoteAddress32678)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._getRemoteAddress32678)) as java.net.InetAddress;
		}
		public new int RemotePort
		{
			get
			{
				return getRemotePort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort32679;
		public virtual int getRemotePort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._getRemotePort32679);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._getRemotePort32679);
		}
		internal static global::MonoJavaBridge.MethodId _assertOpen32680;
		protected override void assertOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._assertOpen32680);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._assertOpen32680);
		}
		internal static global::MonoJavaBridge.MethodId _assertNotOpen32681;
		protected virtual void assertNotOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._assertNotOpen32681);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._assertNotOpen32681);
		}
		internal static global::MonoJavaBridge.MethodId _createSessionInputBuffer32682;
		protected virtual global::org.apache.http.io.SessionInputBuffer createSessionInputBuffer(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionInputBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._createSessionInputBuffer32682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionInputBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionInputBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._createSessionInputBuffer32682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionInputBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _createSessionOutputBuffer32683;
		protected virtual global::org.apache.http.io.SessionOutputBuffer createSessionOutputBuffer(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionOutputBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._createSessionOutputBuffer32683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionOutputBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionOutputBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._createSessionOutputBuffer32683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionOutputBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _SocketHttpClientConnection32684;
		public SocketHttpClientConnection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._SocketHttpClientConnection32684);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.SocketHttpClientConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/SocketHttpClientConnection"));
			global::org.apache.http.impl.SocketHttpClientConnection._shutdown32669 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.SocketHttpClientConnection._close32670 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "close", "()V");
			global::org.apache.http.impl.SocketHttpClientConnection._isOpen32671 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "isOpen", "()Z");
			global::org.apache.http.impl.SocketHttpClientConnection._bind32672 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "bind", "(Ljava/net/Socket;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.SocketHttpClientConnection._getLocalAddress32673 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.impl.SocketHttpClientConnection._getLocalPort32674 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "getLocalPort", "()I");
			global::org.apache.http.impl.SocketHttpClientConnection._getSocket32675 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "getSocket", "()Ljava/net/Socket;");
			global::org.apache.http.impl.SocketHttpClientConnection._setSocketTimeout32676 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.impl.SocketHttpClientConnection._getSocketTimeout32677 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.impl.SocketHttpClientConnection._getRemoteAddress32678 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.impl.SocketHttpClientConnection._getRemotePort32679 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "getRemotePort", "()I");
			global::org.apache.http.impl.SocketHttpClientConnection._assertOpen32680 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "assertOpen", "()V");
			global::org.apache.http.impl.SocketHttpClientConnection._assertNotOpen32681 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "assertNotOpen", "()V");
			global::org.apache.http.impl.SocketHttpClientConnection._createSessionInputBuffer32682 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "createSessionInputBuffer", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/SessionInputBuffer;");
			global::org.apache.http.impl.SocketHttpClientConnection._createSessionOutputBuffer32683 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "createSessionOutputBuffer", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/SessionOutputBuffer;");
			global::org.apache.http.impl.SocketHttpClientConnection._SocketHttpClientConnection32684 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "<init>", "()V");
		}
	}
}
