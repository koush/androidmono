namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DatagramSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatagramSocket()
		{
			InitJNI();
		}
		protected DatagramSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close21272;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._close21272);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._close21272);
		}
		internal static global::MonoJavaBridge.MethodId _send21273;
		public virtual void send(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._send21273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._send21273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort21274;
		public virtual int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getPort21274);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getPort21274);
		}
		public new global::java.nio.channels.DatagramChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel21275;
		public virtual global::java.nio.channels.DatagramChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getChannel21275)) as java.nio.channels.DatagramChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getChannel21275)) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect21276;
		public virtual void connect(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._connect21276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._connect21276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connect21277;
		public virtual void connect(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._connect21277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._connect21277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isClosed21278;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._isClosed21278);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isClosed21278);
		}
		public new bool Broadcast
		{
			get
			{
				return getBroadcast();
			}
			set
			{
				setBroadcast(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBroadcast21279;
		public virtual bool getBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._getBroadcast21279);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getBroadcast21279);
		}
		internal static global::MonoJavaBridge.MethodId _bind21280;
		public virtual void bind(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._bind21280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._bind21280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _disconnect21281;
		public virtual void disconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._disconnect21281);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._disconnect21281);
		}
		internal static global::MonoJavaBridge.MethodId _isConnected21282;
		public virtual bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._isConnected21282);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isConnected21282);
		}
		public new global::java.net.SocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress21283;
		public virtual global::java.net.SocketAddress getLocalSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getLocalSocketAddress21283)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalSocketAddress21283)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize21284;
		public virtual void setReceiveBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setReceiveBufferSize21284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setReceiveBufferSize21284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize21285;
		public virtual int getReceiveBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getReceiveBufferSize21285);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getReceiveBufferSize21285);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout21286;
		public virtual void setSoTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setSoTimeout21286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setSoTimeout21286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSoTimeout21287;
		public virtual int getSoTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getSoTimeout21287);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getSoTimeout21287);
		}
		internal static global::MonoJavaBridge.MethodId _setSendBufferSize21288;
		public virtual void setSendBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setSendBufferSize21288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setSendBufferSize21288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSendBufferSize21289;
		public virtual int getSendBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getSendBufferSize21289);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getSendBufferSize21289);
		}
		public new global::java.net.SocketAddress RemoteSocketAddress
		{
			get
			{
				return getRemoteSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteSocketAddress21290;
		public virtual global::java.net.SocketAddress getRemoteSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getRemoteSocketAddress21290)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getRemoteSocketAddress21290)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isBound21291;
		public virtual bool isBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._isBound21291);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isBound21291);
		}
		public new global::java.net.InetAddress InetAddress
		{
			get
			{
				return getInetAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress21292;
		public virtual global::java.net.InetAddress getInetAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getInetAddress21292)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getInetAddress21292)) as java.net.InetAddress;
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress21293;
		public virtual global::java.net.InetAddress getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getLocalAddress21293)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalAddress21293)) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort21294;
		public virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getLocalPort21294);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalPort21294);
		}
		internal static global::MonoJavaBridge.MethodId _setTrafficClass21295;
		public virtual void setTrafficClass(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setTrafficClass21295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setTrafficClass21295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTrafficClass21296;
		public virtual int getTrafficClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getTrafficClass21296);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getTrafficClass21296);
		}
		internal static global::MonoJavaBridge.MethodId _setReuseAddress21297;
		public virtual void setReuseAddress(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setReuseAddress21297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setReuseAddress21297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getReuseAddress21298;
		public virtual bool getReuseAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._getReuseAddress21298);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getReuseAddress21298);
		}
		internal static global::MonoJavaBridge.MethodId _receive21299;
		public virtual void receive(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._receive21299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._receive21299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBroadcast21300;
		public virtual void setBroadcast(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setBroadcast21300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setBroadcast21300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDatagramSocketImplFactory21301;
		public static void setDatagramSocketImplFactory(java.net.DatagramSocketImplFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setDatagramSocketImplFactory21301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket21302;
		public DatagramSocket(java.net.SocketAddress arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket21302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket21303;
		public DatagramSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket21303);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket21304;
		protected DatagramSocket(java.net.DatagramSocketImpl arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket21304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket21305;
		public DatagramSocket(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket21305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket21306;
		public DatagramSocket(int arg0, java.net.InetAddress arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket21306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocket"));
			global::java.net.DatagramSocket._close21272 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "close", "()V");
			global::java.net.DatagramSocket._send21273 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "send", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocket._getPort21274 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getPort", "()I");
			global::java.net.DatagramSocket._getChannel21275 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getChannel", "()Ljava/nio/channels/DatagramChannel;");
			global::java.net.DatagramSocket._connect21276 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramSocket._connect21277 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/InetAddress;I)V");
			global::java.net.DatagramSocket._isClosed21278 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "isClosed", "()Z");
			global::java.net.DatagramSocket._getBroadcast21279 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getBroadcast", "()Z");
			global::java.net.DatagramSocket._bind21280 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramSocket._disconnect21281 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "disconnect", "()V");
			global::java.net.DatagramSocket._isConnected21282 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "isConnected", "()Z");
			global::java.net.DatagramSocket._getLocalSocketAddress21283 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.DatagramSocket._setReceiveBufferSize21284 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setReceiveBufferSize", "(I)V");
			global::java.net.DatagramSocket._getReceiveBufferSize21285 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getReceiveBufferSize", "()I");
			global::java.net.DatagramSocket._setSoTimeout21286 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setSoTimeout", "(I)V");
			global::java.net.DatagramSocket._getSoTimeout21287 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getSoTimeout", "()I");
			global::java.net.DatagramSocket._setSendBufferSize21288 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setSendBufferSize", "(I)V");
			global::java.net.DatagramSocket._getSendBufferSize21289 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getSendBufferSize", "()I");
			global::java.net.DatagramSocket._getRemoteSocketAddress21290 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getRemoteSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.DatagramSocket._isBound21291 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "isBound", "()Z");
			global::java.net.DatagramSocket._getInetAddress21292 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			global::java.net.DatagramSocket._getLocalAddress21293 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::java.net.DatagramSocket._getLocalPort21294 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getLocalPort", "()I");
			global::java.net.DatagramSocket._setTrafficClass21295 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setTrafficClass", "(I)V");
			global::java.net.DatagramSocket._getTrafficClass21296 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getTrafficClass", "()I");
			global::java.net.DatagramSocket._setReuseAddress21297 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setReuseAddress", "(Z)V");
			global::java.net.DatagramSocket._getReuseAddress21298 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getReuseAddress", "()Z");
			global::java.net.DatagramSocket._receive21299 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "receive", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocket._setBroadcast21300 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setBroadcast", "(Z)V");
			global::java.net.DatagramSocket._setDatagramSocketImplFactory21301 = @__env.GetStaticMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setDatagramSocketImplFactory", "(Ljava/net/DatagramSocketImplFactory;)V");
			global::java.net.DatagramSocket._DatagramSocket21302 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramSocket._DatagramSocket21303 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "()V");
			global::java.net.DatagramSocket._DatagramSocket21304 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/DatagramSocketImpl;)V");
			global::java.net.DatagramSocket._DatagramSocket21305 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(I)V");
			global::java.net.DatagramSocket._DatagramSocket21306 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(ILjava/net/InetAddress;)V");
		}
	}
}
