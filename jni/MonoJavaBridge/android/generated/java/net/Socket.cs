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
		internal static global::MonoJavaBridge.MethodId _toString21603;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._toString21603)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._toString21603)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close21604;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._close21604);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._close21604);
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort21605;
		public virtual int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getPort21605);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getPort21605);
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream21606;
		public virtual global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getInputStream21606)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getInputStream21606)) as java.io.InputStream;
		}
		public new global::java.nio.channels.SocketChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel21607;
		public virtual global::java.nio.channels.SocketChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getChannel21607)) as java.nio.channels.SocketChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getChannel21607)) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect21608;
		public virtual void connect(java.net.SocketAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._connect21608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._connect21608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect21609;
		public virtual void connect(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._connect21609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._connect21609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isClosed21610;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isClosed21610);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isClosed21610);
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream21611;
		public virtual global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getOutputStream21611)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getOutputStream21611)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _bind21612;
		public virtual void bind(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._bind21612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._bind21612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isConnected21613;
		public virtual bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isConnected21613);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isConnected21613);
		}
		public new global::java.net.SocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress21614;
		public virtual global::java.net.SocketAddress getLocalSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getLocalSocketAddress21614)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getLocalSocketAddress21614)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _shutdownInput21615;
		public virtual void shutdownInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._shutdownInput21615);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._shutdownInput21615);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownOutput21616;
		public virtual void shutdownOutput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._shutdownOutput21616);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._shutdownOutput21616);
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize21617;
		public virtual void setReceiveBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setReceiveBufferSize21617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setReceiveBufferSize21617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize21618;
		public virtual int getReceiveBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getReceiveBufferSize21618);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getReceiveBufferSize21618);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout21619;
		public virtual void setSoTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setSoTimeout21619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setSoTimeout21619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSoTimeout21620;
		public virtual int getSoTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getSoTimeout21620);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getSoTimeout21620);
		}
		internal static global::MonoJavaBridge.MethodId _setSendBufferSize21621;
		public virtual void setSendBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setSendBufferSize21621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setSendBufferSize21621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSendBufferSize21622;
		public virtual int getSendBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getSendBufferSize21622);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getSendBufferSize21622);
		}
		public new global::java.net.SocketAddress RemoteSocketAddress
		{
			get
			{
				return getRemoteSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteSocketAddress21623;
		public virtual global::java.net.SocketAddress getRemoteSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getRemoteSocketAddress21623)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getRemoteSocketAddress21623)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isBound21624;
		public virtual bool isBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isBound21624);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isBound21624);
		}
		internal static global::MonoJavaBridge.MethodId _isOutputShutdown21625;
		public virtual bool isOutputShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isOutputShutdown21625);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isOutputShutdown21625);
		}
		internal static global::MonoJavaBridge.MethodId _isInputShutdown21626;
		public virtual bool isInputShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isInputShutdown21626);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isInputShutdown21626);
		}
		public new global::java.net.InetAddress InetAddress
		{
			get
			{
				return getInetAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress21627;
		public virtual global::java.net.InetAddress getInetAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getInetAddress21627)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getInetAddress21627)) as java.net.InetAddress;
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress21628;
		public virtual global::java.net.InetAddress getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getLocalAddress21628)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getLocalAddress21628)) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort21629;
		public virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getLocalPort21629);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getLocalPort21629);
		}
		internal static global::MonoJavaBridge.MethodId _setTcpNoDelay21630;
		public virtual void setTcpNoDelay(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setTcpNoDelay21630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setTcpNoDelay21630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTcpNoDelay21631;
		public virtual bool getTcpNoDelay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getTcpNoDelay21631);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getTcpNoDelay21631);
		}
		internal static global::MonoJavaBridge.MethodId _setSoLinger21632;
		public virtual void setSoLinger(bool arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setSoLinger21632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setSoLinger21632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int SoLinger
		{
			get
			{
				return getSoLinger();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSoLinger21633;
		public virtual int getSoLinger() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getSoLinger21633);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getSoLinger21633);
		}
		internal static global::MonoJavaBridge.MethodId _sendUrgentData21634;
		public virtual void sendUrgentData(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._sendUrgentData21634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._sendUrgentData21634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOOBInline21635;
		public virtual void setOOBInline(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setOOBInline21635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setOOBInline21635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOOBInline21636;
		public virtual bool getOOBInline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getOOBInline21636);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getOOBInline21636);
		}
		internal static global::MonoJavaBridge.MethodId _setKeepAlive21637;
		public virtual void setKeepAlive(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setKeepAlive21637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setKeepAlive21637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getKeepAlive21638;
		public virtual bool getKeepAlive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getKeepAlive21638);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getKeepAlive21638);
		}
		internal static global::MonoJavaBridge.MethodId _setTrafficClass21639;
		public virtual void setTrafficClass(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setTrafficClass21639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setTrafficClass21639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTrafficClass21640;
		public virtual int getTrafficClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getTrafficClass21640);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getTrafficClass21640);
		}
		internal static global::MonoJavaBridge.MethodId _setReuseAddress21641;
		public virtual void setReuseAddress(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setReuseAddress21641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setReuseAddress21641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getReuseAddress21642;
		public virtual bool getReuseAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getReuseAddress21642);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getReuseAddress21642);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketImplFactory21643;
		public static void setSocketImplFactory(java.net.SocketImplFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.Socket.staticClass, global::java.net.Socket._setSocketImplFactory21643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPerformancePreferences21644;
		public virtual void setPerformancePreferences(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setPerformancePreferences21644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setPerformancePreferences21644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _Socket21645;
		public Socket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21645);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21646;
		public Socket(java.net.Proxy arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21647;
		protected Socket(java.net.SocketImpl arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21648;
		public Socket(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21649;
		public Socket(java.net.InetAddress arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21650;
		public Socket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21651;
		public Socket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21652;
		public Socket(java.lang.String arg0, int arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21653;
		public Socket(java.net.InetAddress arg0, int arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Socket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Socket"));
			global::java.net.Socket._toString21603 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.Socket._close21604 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "close", "()V");
			global::java.net.Socket._getPort21605 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getPort", "()I");
			global::java.net.Socket._getInputStream21606 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.net.Socket._getChannel21607 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getChannel", "()Ljava/nio/channels/SocketChannel;");
			global::java.net.Socket._connect21608 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "connect", "(Ljava/net/SocketAddress;I)V");
			global::java.net.Socket._connect21609 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "connect", "(Ljava/net/SocketAddress;)V");
			global::java.net.Socket._isClosed21610 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isClosed", "()Z");
			global::java.net.Socket._getOutputStream21611 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.net.Socket._bind21612 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::java.net.Socket._isConnected21613 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isConnected", "()Z");
			global::java.net.Socket._getLocalSocketAddress21614 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.Socket._shutdownInput21615 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "shutdownInput", "()V");
			global::java.net.Socket._shutdownOutput21616 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "shutdownOutput", "()V");
			global::java.net.Socket._setReceiveBufferSize21617 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setReceiveBufferSize", "(I)V");
			global::java.net.Socket._getReceiveBufferSize21618 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getReceiveBufferSize", "()I");
			global::java.net.Socket._setSoTimeout21619 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setSoTimeout", "(I)V");
			global::java.net.Socket._getSoTimeout21620 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getSoTimeout", "()I");
			global::java.net.Socket._setSendBufferSize21621 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setSendBufferSize", "(I)V");
			global::java.net.Socket._getSendBufferSize21622 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getSendBufferSize", "()I");
			global::java.net.Socket._getRemoteSocketAddress21623 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getRemoteSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.Socket._isBound21624 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isBound", "()Z");
			global::java.net.Socket._isOutputShutdown21625 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isOutputShutdown", "()Z");
			global::java.net.Socket._isInputShutdown21626 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isInputShutdown", "()Z");
			global::java.net.Socket._getInetAddress21627 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			global::java.net.Socket._getLocalAddress21628 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::java.net.Socket._getLocalPort21629 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getLocalPort", "()I");
			global::java.net.Socket._setTcpNoDelay21630 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setTcpNoDelay", "(Z)V");
			global::java.net.Socket._getTcpNoDelay21631 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getTcpNoDelay", "()Z");
			global::java.net.Socket._setSoLinger21632 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setSoLinger", "(ZI)V");
			global::java.net.Socket._getSoLinger21633 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getSoLinger", "()I");
			global::java.net.Socket._sendUrgentData21634 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "sendUrgentData", "(I)V");
			global::java.net.Socket._setOOBInline21635 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setOOBInline", "(Z)V");
			global::java.net.Socket._getOOBInline21636 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getOOBInline", "()Z");
			global::java.net.Socket._setKeepAlive21637 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setKeepAlive", "(Z)V");
			global::java.net.Socket._getKeepAlive21638 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getKeepAlive", "()Z");
			global::java.net.Socket._setTrafficClass21639 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setTrafficClass", "(I)V");
			global::java.net.Socket._getTrafficClass21640 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getTrafficClass", "()I");
			global::java.net.Socket._setReuseAddress21641 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setReuseAddress", "(Z)V");
			global::java.net.Socket._getReuseAddress21642 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getReuseAddress", "()Z");
			global::java.net.Socket._setSocketImplFactory21643 = @__env.GetStaticMethodIDNoThrow(global::java.net.Socket.staticClass, "setSocketImplFactory", "(Ljava/net/SocketImplFactory;)V");
			global::java.net.Socket._setPerformancePreferences21644 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setPerformancePreferences", "(III)V");
			global::java.net.Socket._Socket21645 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "()V");
			global::java.net.Socket._Socket21646 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/Proxy;)V");
			global::java.net.Socket._Socket21647 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/SocketImpl;)V");
			global::java.net.Socket._Socket21648 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.net.Socket._Socket21649 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;I)V");
			global::java.net.Socket._Socket21650 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V");
			global::java.net.Socket._Socket21651 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V");
			global::java.net.Socket._Socket21652 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;IZ)V");
			global::java.net.Socket._Socket21653 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;IZ)V");
		}
	}
}
