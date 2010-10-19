namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Socket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Socket()
		{
			InitJNI();
		}
		protected Socket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString16023;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._toString16023)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._toString16023)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close16024;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._close16024);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._close16024);
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort16025;
		public virtual int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getPort16025);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getPort16025);
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream16026;
		public virtual global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getInputStream16026)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getInputStream16026)) as java.io.InputStream;
		}
		public new global::java.nio.channels.SocketChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel16027;
		public virtual global::java.nio.channels.SocketChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getChannel16027)) as java.nio.channels.SocketChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getChannel16027)) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect16028;
		public virtual void connect(java.net.SocketAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._connect16028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._connect16028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect16029;
		public virtual void connect(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._connect16029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._connect16029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isClosed16030;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isClosed16030);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isClosed16030);
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream16031;
		public virtual global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getOutputStream16031)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getOutputStream16031)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _bind16032;
		public virtual void bind(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._bind16032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._bind16032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isConnected16033;
		public virtual bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isConnected16033);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isConnected16033);
		}
		public new global::java.net.SocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress16034;
		public virtual global::java.net.SocketAddress getLocalSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getLocalSocketAddress16034)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getLocalSocketAddress16034)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _shutdownInput16035;
		public virtual void shutdownInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._shutdownInput16035);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._shutdownInput16035);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownOutput16036;
		public virtual void shutdownOutput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._shutdownOutput16036);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._shutdownOutput16036);
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize16037;
		public virtual void setReceiveBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setReceiveBufferSize16037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setReceiveBufferSize16037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ReceiveBufferSize
		{
			get
			{
				return getReceiveBufferSize();
			}
			set
			{
				setReceiveBufferSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize16038;
		public virtual int getReceiveBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getReceiveBufferSize16038);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getReceiveBufferSize16038);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout16039;
		public virtual void setSoTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setSoTimeout16039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setSoTimeout16039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SoTimeout
		{
			get
			{
				return getSoTimeout();
			}
			set
			{
				setSoTimeout(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSoTimeout16040;
		public virtual int getSoTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getSoTimeout16040);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getSoTimeout16040);
		}
		internal static global::MonoJavaBridge.MethodId _setSendBufferSize16041;
		public virtual void setSendBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setSendBufferSize16041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setSendBufferSize16041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SendBufferSize
		{
			get
			{
				return getSendBufferSize();
			}
			set
			{
				setSendBufferSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSendBufferSize16042;
		public virtual int getSendBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getSendBufferSize16042);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getSendBufferSize16042);
		}
		public new global::java.net.SocketAddress RemoteSocketAddress
		{
			get
			{
				return getRemoteSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteSocketAddress16043;
		public virtual global::java.net.SocketAddress getRemoteSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getRemoteSocketAddress16043)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getRemoteSocketAddress16043)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isBound16044;
		public virtual bool isBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isBound16044);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isBound16044);
		}
		internal static global::MonoJavaBridge.MethodId _isOutputShutdown16045;
		public virtual bool isOutputShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isOutputShutdown16045);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isOutputShutdown16045);
		}
		internal static global::MonoJavaBridge.MethodId _isInputShutdown16046;
		public virtual bool isInputShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isInputShutdown16046);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isInputShutdown16046);
		}
		public new global::java.net.InetAddress InetAddress
		{
			get
			{
				return getInetAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress16047;
		public virtual global::java.net.InetAddress getInetAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getInetAddress16047)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getInetAddress16047)) as java.net.InetAddress;
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress16048;
		public virtual global::java.net.InetAddress getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getLocalAddress16048)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getLocalAddress16048)) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort16049;
		public virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getLocalPort16049);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getLocalPort16049);
		}
		internal static global::MonoJavaBridge.MethodId _setTcpNoDelay16050;
		public virtual void setTcpNoDelay(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setTcpNoDelay16050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setTcpNoDelay16050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool TcpNoDelay
		{
			get
			{
				return getTcpNoDelay();
			}
			set
			{
				setTcpNoDelay(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTcpNoDelay16051;
		public virtual bool getTcpNoDelay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getTcpNoDelay16051);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getTcpNoDelay16051);
		}
		internal static global::MonoJavaBridge.MethodId _setSoLinger16052;
		public virtual void setSoLinger(bool arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setSoLinger16052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setSoLinger16052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int SoLinger
		{
			get
			{
				return getSoLinger();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSoLinger16053;
		public virtual int getSoLinger() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getSoLinger16053);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getSoLinger16053);
		}
		internal static global::MonoJavaBridge.MethodId _sendUrgentData16054;
		public virtual void sendUrgentData(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._sendUrgentData16054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._sendUrgentData16054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOOBInline16055;
		public virtual void setOOBInline(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setOOBInline16055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setOOBInline16055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool OOBInline
		{
			get
			{
				return getOOBInline();
			}
			set
			{
				setOOBInline(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOOBInline16056;
		public virtual bool getOOBInline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getOOBInline16056);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getOOBInline16056);
		}
		internal static global::MonoJavaBridge.MethodId _setKeepAlive16057;
		public virtual void setKeepAlive(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setKeepAlive16057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setKeepAlive16057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool KeepAlive
		{
			get
			{
				return getKeepAlive();
			}
			set
			{
				setKeepAlive(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeepAlive16058;
		public virtual bool getKeepAlive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getKeepAlive16058);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getKeepAlive16058);
		}
		internal static global::MonoJavaBridge.MethodId _setTrafficClass16059;
		public virtual void setTrafficClass(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setTrafficClass16059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setTrafficClass16059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int TrafficClass
		{
			get
			{
				return getTrafficClass();
			}
			set
			{
				setTrafficClass(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTrafficClass16060;
		public virtual int getTrafficClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getTrafficClass16060);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getTrafficClass16060);
		}
		internal static global::MonoJavaBridge.MethodId _setReuseAddress16061;
		public virtual void setReuseAddress(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setReuseAddress16061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setReuseAddress16061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ReuseAddress
		{
			get
			{
				return getReuseAddress();
			}
			set
			{
				setReuseAddress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReuseAddress16062;
		public virtual bool getReuseAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getReuseAddress16062);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getReuseAddress16062);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketImplFactory16063;
		public static void setSocketImplFactory(java.net.SocketImplFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.Socket.staticClass, global::java.net.Socket._setSocketImplFactory16063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPerformancePreferences16064;
		public virtual void setPerformancePreferences(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setPerformancePreferences16064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setPerformancePreferences16064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _Socket16065;
		public Socket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket16065);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket16066;
		public Socket(java.net.Proxy arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket16066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket16067;
		protected Socket(java.net.SocketImpl arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket16067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket16068;
		public Socket(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket16068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket16069;
		public Socket(java.net.InetAddress arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket16069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket16070;
		public Socket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket16070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket16071;
		public Socket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket16071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket16072;
		public Socket(java.lang.String arg0, int arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket16072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket16073;
		public Socket(java.net.InetAddress arg0, int arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket16073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Socket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Socket"));
			global::java.net.Socket._toString16023 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.Socket._close16024 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "close", "()V");
			global::java.net.Socket._getPort16025 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getPort", "()I");
			global::java.net.Socket._getInputStream16026 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.net.Socket._getChannel16027 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getChannel", "()Ljava/nio/channels/SocketChannel;");
			global::java.net.Socket._connect16028 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "connect", "(Ljava/net/SocketAddress;I)V");
			global::java.net.Socket._connect16029 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "connect", "(Ljava/net/SocketAddress;)V");
			global::java.net.Socket._isClosed16030 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isClosed", "()Z");
			global::java.net.Socket._getOutputStream16031 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.net.Socket._bind16032 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::java.net.Socket._isConnected16033 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isConnected", "()Z");
			global::java.net.Socket._getLocalSocketAddress16034 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.Socket._shutdownInput16035 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "shutdownInput", "()V");
			global::java.net.Socket._shutdownOutput16036 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "shutdownOutput", "()V");
			global::java.net.Socket._setReceiveBufferSize16037 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setReceiveBufferSize", "(I)V");
			global::java.net.Socket._getReceiveBufferSize16038 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getReceiveBufferSize", "()I");
			global::java.net.Socket._setSoTimeout16039 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setSoTimeout", "(I)V");
			global::java.net.Socket._getSoTimeout16040 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getSoTimeout", "()I");
			global::java.net.Socket._setSendBufferSize16041 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setSendBufferSize", "(I)V");
			global::java.net.Socket._getSendBufferSize16042 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getSendBufferSize", "()I");
			global::java.net.Socket._getRemoteSocketAddress16043 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getRemoteSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.Socket._isBound16044 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isBound", "()Z");
			global::java.net.Socket._isOutputShutdown16045 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isOutputShutdown", "()Z");
			global::java.net.Socket._isInputShutdown16046 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isInputShutdown", "()Z");
			global::java.net.Socket._getInetAddress16047 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			global::java.net.Socket._getLocalAddress16048 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::java.net.Socket._getLocalPort16049 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getLocalPort", "()I");
			global::java.net.Socket._setTcpNoDelay16050 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setTcpNoDelay", "(Z)V");
			global::java.net.Socket._getTcpNoDelay16051 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getTcpNoDelay", "()Z");
			global::java.net.Socket._setSoLinger16052 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setSoLinger", "(ZI)V");
			global::java.net.Socket._getSoLinger16053 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getSoLinger", "()I");
			global::java.net.Socket._sendUrgentData16054 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "sendUrgentData", "(I)V");
			global::java.net.Socket._setOOBInline16055 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setOOBInline", "(Z)V");
			global::java.net.Socket._getOOBInline16056 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getOOBInline", "()Z");
			global::java.net.Socket._setKeepAlive16057 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setKeepAlive", "(Z)V");
			global::java.net.Socket._getKeepAlive16058 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getKeepAlive", "()Z");
			global::java.net.Socket._setTrafficClass16059 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setTrafficClass", "(I)V");
			global::java.net.Socket._getTrafficClass16060 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getTrafficClass", "()I");
			global::java.net.Socket._setReuseAddress16061 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setReuseAddress", "(Z)V");
			global::java.net.Socket._getReuseAddress16062 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getReuseAddress", "()Z");
			global::java.net.Socket._setSocketImplFactory16063 = @__env.GetStaticMethodIDNoThrow(global::java.net.Socket.staticClass, "setSocketImplFactory", "(Ljava/net/SocketImplFactory;)V");
			global::java.net.Socket._setPerformancePreferences16064 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setPerformancePreferences", "(III)V");
			global::java.net.Socket._Socket16065 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "()V");
			global::java.net.Socket._Socket16066 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/Proxy;)V");
			global::java.net.Socket._Socket16067 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/SocketImpl;)V");
			global::java.net.Socket._Socket16068 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.net.Socket._Socket16069 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;I)V");
			global::java.net.Socket._Socket16070 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V");
			global::java.net.Socket._Socket16071 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V");
			global::java.net.Socket._Socket16072 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;IZ)V");
			global::java.net.Socket._Socket16073 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;IZ)V");
		}
	}
}
