namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketHttpServerConnection : org.apache.http.impl.AbstractHttpServerConnection, HttpInetConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SocketHttpServerConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown32685;
		public override void shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._shutdown32685);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._shutdown32685);
		}
		internal static global::MonoJavaBridge.MethodId _close32686;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._close32686);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._close32686);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen32687;
		public override bool isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._isOpen32687);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._isOpen32687);
		}
		internal static global::MonoJavaBridge.MethodId _bind32688;
		protected virtual void bind(java.net.Socket arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._bind32688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._bind32688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress32689;
		public virtual global::java.net.InetAddress getLocalAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._getLocalAddress32689)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._getLocalAddress32689)) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort32690;
		public virtual int getLocalPort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._getLocalPort32690);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._getLocalPort32690);
		}
		protected new global::java.net.Socket Socket
		{
			get
			{
				return getSocket();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocket32691;
		protected virtual global::java.net.Socket getSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._getSocket32691)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._getSocket32691)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout32692;
		public override void setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._setSocketTimeout32692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._setSocketTimeout32692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout32693;
		public override int getSocketTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._getSocketTimeout32693);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._getSocketTimeout32693);
		}
		public new global::java.net.InetAddress RemoteAddress
		{
			get
			{
				return getRemoteAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress32694;
		public virtual global::java.net.InetAddress getRemoteAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._getRemoteAddress32694)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._getRemoteAddress32694)) as java.net.InetAddress;
		}
		public new int RemotePort
		{
			get
			{
				return getRemotePort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort32695;
		public virtual int getRemotePort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._getRemotePort32695);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._getRemotePort32695);
		}
		internal static global::MonoJavaBridge.MethodId _assertOpen32696;
		protected override void assertOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._assertOpen32696);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._assertOpen32696);
		}
		internal static global::MonoJavaBridge.MethodId _assertNotOpen32697;
		protected virtual void assertNotOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._assertNotOpen32697);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._assertNotOpen32697);
		}
		internal static global::MonoJavaBridge.MethodId _createHttpDataReceiver32698;
		protected virtual global::org.apache.http.io.SessionInputBuffer createHttpDataReceiver(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionInputBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._createHttpDataReceiver32698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionInputBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionInputBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._createHttpDataReceiver32698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionInputBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _createHttpDataTransmitter32699;
		protected virtual global::org.apache.http.io.SessionOutputBuffer createHttpDataTransmitter(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionOutputBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection._createHttpDataTransmitter32699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionOutputBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionOutputBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._createHttpDataTransmitter32699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionOutputBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _SocketHttpServerConnection32700;
		public SocketHttpServerConnection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._SocketHttpServerConnection32700);
			Init(@__env, handle);
		}
		static SocketHttpServerConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.SocketHttpServerConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/SocketHttpServerConnection"));
			global::org.apache.http.impl.SocketHttpServerConnection._shutdown32685 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.SocketHttpServerConnection._close32686 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "close", "()V");
			global::org.apache.http.impl.SocketHttpServerConnection._isOpen32687 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "isOpen", "()Z");
			global::org.apache.http.impl.SocketHttpServerConnection._bind32688 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "bind", "(Ljava/net/Socket;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.SocketHttpServerConnection._getLocalAddress32689 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.impl.SocketHttpServerConnection._getLocalPort32690 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getLocalPort", "()I");
			global::org.apache.http.impl.SocketHttpServerConnection._getSocket32691 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getSocket", "()Ljava/net/Socket;");
			global::org.apache.http.impl.SocketHttpServerConnection._setSocketTimeout32692 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.impl.SocketHttpServerConnection._getSocketTimeout32693 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.impl.SocketHttpServerConnection._getRemoteAddress32694 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.impl.SocketHttpServerConnection._getRemotePort32695 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getRemotePort", "()I");
			global::org.apache.http.impl.SocketHttpServerConnection._assertOpen32696 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "assertOpen", "()V");
			global::org.apache.http.impl.SocketHttpServerConnection._assertNotOpen32697 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "assertNotOpen", "()V");
			global::org.apache.http.impl.SocketHttpServerConnection._createHttpDataReceiver32698 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "createHttpDataReceiver", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/SessionInputBuffer;");
			global::org.apache.http.impl.SocketHttpServerConnection._createHttpDataTransmitter32699 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "createHttpDataTransmitter", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/SessionOutputBuffer;");
			global::org.apache.http.impl.SocketHttpServerConnection._SocketHttpServerConnection32700 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
