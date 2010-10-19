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
		internal static global::MonoJavaBridge.MethodId _close15728;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._close15728);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._close15728);
		}
		internal static global::MonoJavaBridge.MethodId _send15729;
		public virtual void send(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._send15729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._send15729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort15730;
		public virtual int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getPort15730);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getPort15730);
		}
		public new global::java.nio.channels.DatagramChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel15731;
		public virtual global::java.nio.channels.DatagramChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getChannel15731)) as java.nio.channels.DatagramChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getChannel15731)) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect15732;
		public virtual void connect(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._connect15732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._connect15732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connect15733;
		public virtual void connect(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._connect15733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._connect15733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isClosed15734;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._isClosed15734);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isClosed15734);
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
		internal static global::MonoJavaBridge.MethodId _getBroadcast15735;
		public virtual bool getBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._getBroadcast15735);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getBroadcast15735);
		}
		internal static global::MonoJavaBridge.MethodId _bind15736;
		public virtual void bind(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._bind15736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._bind15736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _disconnect15737;
		public virtual void disconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._disconnect15737);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._disconnect15737);
		}
		internal static global::MonoJavaBridge.MethodId _isConnected15738;
		public virtual bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._isConnected15738);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isConnected15738);
		}
		public new global::java.net.SocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress15739;
		public virtual global::java.net.SocketAddress getLocalSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getLocalSocketAddress15739)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalSocketAddress15739)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize15740;
		public virtual void setReceiveBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setReceiveBufferSize15740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setReceiveBufferSize15740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize15741;
		public virtual int getReceiveBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getReceiveBufferSize15741);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getReceiveBufferSize15741);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout15742;
		public virtual void setSoTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setSoTimeout15742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setSoTimeout15742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSoTimeout15743;
		public virtual int getSoTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getSoTimeout15743);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getSoTimeout15743);
		}
		internal static global::MonoJavaBridge.MethodId _setSendBufferSize15744;
		public virtual void setSendBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setSendBufferSize15744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setSendBufferSize15744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSendBufferSize15745;
		public virtual int getSendBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getSendBufferSize15745);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getSendBufferSize15745);
		}
		public new global::java.net.SocketAddress RemoteSocketAddress
		{
			get
			{
				return getRemoteSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteSocketAddress15746;
		public virtual global::java.net.SocketAddress getRemoteSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getRemoteSocketAddress15746)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getRemoteSocketAddress15746)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isBound15747;
		public virtual bool isBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._isBound15747);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isBound15747);
		}
		public new global::java.net.InetAddress InetAddress
		{
			get
			{
				return getInetAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress15748;
		public virtual global::java.net.InetAddress getInetAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getInetAddress15748)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getInetAddress15748)) as java.net.InetAddress;
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress15749;
		public virtual global::java.net.InetAddress getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getLocalAddress15749)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalAddress15749)) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort15750;
		public virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getLocalPort15750);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalPort15750);
		}
		internal static global::MonoJavaBridge.MethodId _setTrafficClass15751;
		public virtual void setTrafficClass(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setTrafficClass15751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setTrafficClass15751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTrafficClass15752;
		public virtual int getTrafficClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getTrafficClass15752);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getTrafficClass15752);
		}
		internal static global::MonoJavaBridge.MethodId _setReuseAddress15753;
		public virtual void setReuseAddress(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setReuseAddress15753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setReuseAddress15753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getReuseAddress15754;
		public virtual bool getReuseAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._getReuseAddress15754);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getReuseAddress15754);
		}
		internal static global::MonoJavaBridge.MethodId _receive15755;
		public virtual void receive(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._receive15755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._receive15755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBroadcast15756;
		public virtual void setBroadcast(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setBroadcast15756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setBroadcast15756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDatagramSocketImplFactory15757;
		public static void setDatagramSocketImplFactory(java.net.DatagramSocketImplFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setDatagramSocketImplFactory15757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket15758;
		public DatagramSocket(java.net.SocketAddress arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket15758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket15759;
		public DatagramSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket15759);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket15760;
		protected DatagramSocket(java.net.DatagramSocketImpl arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket15760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket15761;
		public DatagramSocket(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket15761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket15762;
		public DatagramSocket(int arg0, java.net.InetAddress arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket15762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocket"));
			global::java.net.DatagramSocket._close15728 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "close", "()V");
			global::java.net.DatagramSocket._send15729 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "send", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocket._getPort15730 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getPort", "()I");
			global::java.net.DatagramSocket._getChannel15731 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getChannel", "()Ljava/nio/channels/DatagramChannel;");
			global::java.net.DatagramSocket._connect15732 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramSocket._connect15733 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/InetAddress;I)V");
			global::java.net.DatagramSocket._isClosed15734 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "isClosed", "()Z");
			global::java.net.DatagramSocket._getBroadcast15735 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getBroadcast", "()Z");
			global::java.net.DatagramSocket._bind15736 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramSocket._disconnect15737 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "disconnect", "()V");
			global::java.net.DatagramSocket._isConnected15738 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "isConnected", "()Z");
			global::java.net.DatagramSocket._getLocalSocketAddress15739 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.DatagramSocket._setReceiveBufferSize15740 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setReceiveBufferSize", "(I)V");
			global::java.net.DatagramSocket._getReceiveBufferSize15741 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getReceiveBufferSize", "()I");
			global::java.net.DatagramSocket._setSoTimeout15742 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setSoTimeout", "(I)V");
			global::java.net.DatagramSocket._getSoTimeout15743 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getSoTimeout", "()I");
			global::java.net.DatagramSocket._setSendBufferSize15744 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setSendBufferSize", "(I)V");
			global::java.net.DatagramSocket._getSendBufferSize15745 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getSendBufferSize", "()I");
			global::java.net.DatagramSocket._getRemoteSocketAddress15746 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getRemoteSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.DatagramSocket._isBound15747 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "isBound", "()Z");
			global::java.net.DatagramSocket._getInetAddress15748 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			global::java.net.DatagramSocket._getLocalAddress15749 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::java.net.DatagramSocket._getLocalPort15750 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getLocalPort", "()I");
			global::java.net.DatagramSocket._setTrafficClass15751 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setTrafficClass", "(I)V");
			global::java.net.DatagramSocket._getTrafficClass15752 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getTrafficClass", "()I");
			global::java.net.DatagramSocket._setReuseAddress15753 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setReuseAddress", "(Z)V");
			global::java.net.DatagramSocket._getReuseAddress15754 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getReuseAddress", "()Z");
			global::java.net.DatagramSocket._receive15755 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "receive", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocket._setBroadcast15756 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setBroadcast", "(Z)V");
			global::java.net.DatagramSocket._setDatagramSocketImplFactory15757 = @__env.GetStaticMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setDatagramSocketImplFactory", "(Ljava/net/DatagramSocketImplFactory;)V");
			global::java.net.DatagramSocket._DatagramSocket15758 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramSocket._DatagramSocket15759 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "()V");
			global::java.net.DatagramSocket._DatagramSocket15760 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/DatagramSocketImpl;)V");
			global::java.net.DatagramSocket._DatagramSocket15761 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(I)V");
			global::java.net.DatagramSocket._DatagramSocket15762 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(ILjava/net/InetAddress;)V");
		}
	}
}
