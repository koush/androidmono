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
		internal static global::MonoJavaBridge.MethodId _toString21722;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._toString21722)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._toString21722)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close21723;
		public virtual void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._close21723);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._close21723);
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort21724;
		public virtual int getPort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getPort21724);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getPort21724);
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream21725;
		public virtual global::java.io.InputStream getInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getInputStream21725)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getInputStream21725)) as java.io.InputStream;
		}
		public new global::java.nio.channels.SocketChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel21726;
		public virtual global::java.nio.channels.SocketChannel getChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getChannel21726)) as java.nio.channels.SocketChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getChannel21726)) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect21727;
		public virtual void connect(java.net.SocketAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._connect21727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._connect21727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect21728;
		public virtual void connect(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._connect21728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._connect21728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isClosed21729;
		public virtual bool isClosed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isClosed21729);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isClosed21729);
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream21730;
		public virtual global::java.io.OutputStream getOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getOutputStream21730)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getOutputStream21730)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _bind21731;
		public virtual void bind(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._bind21731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._bind21731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isConnected21732;
		public virtual bool isConnected()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isConnected21732);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isConnected21732);
		}
		public new global::java.net.SocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress21733;
		public virtual global::java.net.SocketAddress getLocalSocketAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getLocalSocketAddress21733)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getLocalSocketAddress21733)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _shutdownInput21734;
		public virtual void shutdownInput()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._shutdownInput21734);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._shutdownInput21734);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownOutput21735;
		public virtual void shutdownOutput()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._shutdownOutput21735);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._shutdownOutput21735);
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize21736;
		public virtual void setReceiveBufferSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setReceiveBufferSize21736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setReceiveBufferSize21736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize21737;
		public virtual int getReceiveBufferSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getReceiveBufferSize21737);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getReceiveBufferSize21737);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout21738;
		public virtual void setSoTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setSoTimeout21738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setSoTimeout21738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSoTimeout21739;
		public virtual int getSoTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getSoTimeout21739);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getSoTimeout21739);
		}
		internal static global::MonoJavaBridge.MethodId _setSendBufferSize21740;
		public virtual void setSendBufferSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setSendBufferSize21740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setSendBufferSize21740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSendBufferSize21741;
		public virtual int getSendBufferSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getSendBufferSize21741);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getSendBufferSize21741);
		}
		public new global::java.net.SocketAddress RemoteSocketAddress
		{
			get
			{
				return getRemoteSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteSocketAddress21742;
		public virtual global::java.net.SocketAddress getRemoteSocketAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getRemoteSocketAddress21742)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getRemoteSocketAddress21742)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isBound21743;
		public virtual bool isBound()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isBound21743);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isBound21743);
		}
		internal static global::MonoJavaBridge.MethodId _isOutputShutdown21744;
		public virtual bool isOutputShutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isOutputShutdown21744);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isOutputShutdown21744);
		}
		internal static global::MonoJavaBridge.MethodId _isInputShutdown21745;
		public virtual bool isInputShutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isInputShutdown21745);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isInputShutdown21745);
		}
		public new global::java.net.InetAddress InetAddress
		{
			get
			{
				return getInetAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress21746;
		public virtual global::java.net.InetAddress getInetAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getInetAddress21746)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getInetAddress21746)) as java.net.InetAddress;
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress21747;
		public virtual global::java.net.InetAddress getLocalAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getLocalAddress21747)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getLocalAddress21747)) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort21748;
		public virtual int getLocalPort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getLocalPort21748);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getLocalPort21748);
		}
		internal static global::MonoJavaBridge.MethodId _setTcpNoDelay21749;
		public virtual void setTcpNoDelay(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setTcpNoDelay21749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setTcpNoDelay21749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTcpNoDelay21750;
		public virtual bool getTcpNoDelay()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getTcpNoDelay21750);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getTcpNoDelay21750);
		}
		internal static global::MonoJavaBridge.MethodId _setSoLinger21751;
		public virtual void setSoLinger(bool arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setSoLinger21751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setSoLinger21751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int SoLinger
		{
			get
			{
				return getSoLinger();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSoLinger21752;
		public virtual int getSoLinger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getSoLinger21752);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getSoLinger21752);
		}
		internal static global::MonoJavaBridge.MethodId _sendUrgentData21753;
		public virtual void sendUrgentData(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._sendUrgentData21753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._sendUrgentData21753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOOBInline21754;
		public virtual void setOOBInline(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setOOBInline21754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setOOBInline21754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOOBInline21755;
		public virtual bool getOOBInline()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getOOBInline21755);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getOOBInline21755);
		}
		internal static global::MonoJavaBridge.MethodId _setKeepAlive21756;
		public virtual void setKeepAlive(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setKeepAlive21756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setKeepAlive21756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getKeepAlive21757;
		public virtual bool getKeepAlive()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getKeepAlive21757);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getKeepAlive21757);
		}
		internal static global::MonoJavaBridge.MethodId _setTrafficClass21758;
		public virtual void setTrafficClass(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setTrafficClass21758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setTrafficClass21758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTrafficClass21759;
		public virtual int getTrafficClass()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getTrafficClass21759);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getTrafficClass21759);
		}
		internal static global::MonoJavaBridge.MethodId _setReuseAddress21760;
		public virtual void setReuseAddress(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setReuseAddress21760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setReuseAddress21760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getReuseAddress21761;
		public virtual bool getReuseAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getReuseAddress21761);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getReuseAddress21761);
		}
		public static global::java.net.SocketImplFactory SocketImplFactory
		{
			set
			{
				setSocketImplFactory(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSocketImplFactory21762;
		public static void setSocketImplFactory(java.net.SocketImplFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.Socket.staticClass, global::java.net.Socket._setSocketImplFactory21762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPerformancePreferences21763;
		public virtual void setPerformancePreferences(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setPerformancePreferences21763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setPerformancePreferences21763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _Socket21764;
		public Socket() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21764);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21765;
		public Socket(java.net.Proxy arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21766;
		protected Socket(java.net.SocketImpl arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21767;
		public Socket(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21768;
		public Socket(java.net.InetAddress arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21769;
		public Socket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21770;
		public Socket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21771;
		public Socket(java.lang.String arg0, int arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket21772;
		public Socket(java.net.InetAddress arg0, int arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket21772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Socket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Socket"));
			global::java.net.Socket._toString21722 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.Socket._close21723 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "close", "()V");
			global::java.net.Socket._getPort21724 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getPort", "()I");
			global::java.net.Socket._getInputStream21725 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.net.Socket._getChannel21726 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getChannel", "()Ljava/nio/channels/SocketChannel;");
			global::java.net.Socket._connect21727 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "connect", "(Ljava/net/SocketAddress;I)V");
			global::java.net.Socket._connect21728 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "connect", "(Ljava/net/SocketAddress;)V");
			global::java.net.Socket._isClosed21729 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isClosed", "()Z");
			global::java.net.Socket._getOutputStream21730 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.net.Socket._bind21731 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::java.net.Socket._isConnected21732 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isConnected", "()Z");
			global::java.net.Socket._getLocalSocketAddress21733 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.Socket._shutdownInput21734 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "shutdownInput", "()V");
			global::java.net.Socket._shutdownOutput21735 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "shutdownOutput", "()V");
			global::java.net.Socket._setReceiveBufferSize21736 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setReceiveBufferSize", "(I)V");
			global::java.net.Socket._getReceiveBufferSize21737 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getReceiveBufferSize", "()I");
			global::java.net.Socket._setSoTimeout21738 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setSoTimeout", "(I)V");
			global::java.net.Socket._getSoTimeout21739 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getSoTimeout", "()I");
			global::java.net.Socket._setSendBufferSize21740 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setSendBufferSize", "(I)V");
			global::java.net.Socket._getSendBufferSize21741 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getSendBufferSize", "()I");
			global::java.net.Socket._getRemoteSocketAddress21742 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getRemoteSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.Socket._isBound21743 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isBound", "()Z");
			global::java.net.Socket._isOutputShutdown21744 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isOutputShutdown", "()Z");
			global::java.net.Socket._isInputShutdown21745 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isInputShutdown", "()Z");
			global::java.net.Socket._getInetAddress21746 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			global::java.net.Socket._getLocalAddress21747 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::java.net.Socket._getLocalPort21748 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getLocalPort", "()I");
			global::java.net.Socket._setTcpNoDelay21749 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setTcpNoDelay", "(Z)V");
			global::java.net.Socket._getTcpNoDelay21750 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getTcpNoDelay", "()Z");
			global::java.net.Socket._setSoLinger21751 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setSoLinger", "(ZI)V");
			global::java.net.Socket._getSoLinger21752 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getSoLinger", "()I");
			global::java.net.Socket._sendUrgentData21753 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "sendUrgentData", "(I)V");
			global::java.net.Socket._setOOBInline21754 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setOOBInline", "(Z)V");
			global::java.net.Socket._getOOBInline21755 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getOOBInline", "()Z");
			global::java.net.Socket._setKeepAlive21756 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setKeepAlive", "(Z)V");
			global::java.net.Socket._getKeepAlive21757 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getKeepAlive", "()Z");
			global::java.net.Socket._setTrafficClass21758 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setTrafficClass", "(I)V");
			global::java.net.Socket._getTrafficClass21759 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getTrafficClass", "()I");
			global::java.net.Socket._setReuseAddress21760 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setReuseAddress", "(Z)V");
			global::java.net.Socket._getReuseAddress21761 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getReuseAddress", "()Z");
			global::java.net.Socket._setSocketImplFactory21762 = @__env.GetStaticMethodIDNoThrow(global::java.net.Socket.staticClass, "setSocketImplFactory", "(Ljava/net/SocketImplFactory;)V");
			global::java.net.Socket._setPerformancePreferences21763 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setPerformancePreferences", "(III)V");
			global::java.net.Socket._Socket21764 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "()V");
			global::java.net.Socket._Socket21765 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/Proxy;)V");
			global::java.net.Socket._Socket21766 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/SocketImpl;)V");
			global::java.net.Socket._Socket21767 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.net.Socket._Socket21768 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;I)V");
			global::java.net.Socket._Socket21769 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V");
			global::java.net.Socket._Socket21770 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V");
			global::java.net.Socket._Socket21771 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;IZ)V");
			global::java.net.Socket._Socket21772 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;IZ)V");
		}
	}
}
