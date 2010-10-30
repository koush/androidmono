namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DatagramSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DatagramSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close21391;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._close21391);
		}
		internal static global::MonoJavaBridge.MethodId _send21392;
		public virtual void send(java.net.DatagramPacket arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._send21392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort21393;
		public virtual int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getPort21393);
		}
		public new global::java.nio.channels.DatagramChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel21394;
		public virtual global::java.nio.channels.DatagramChannel getChannel()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getChannel21394)) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect21395;
		public virtual void connect(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._connect21395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connect21396;
		public virtual void connect(java.net.InetAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._connect21396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isClosed21397;
		public virtual bool isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isClosed21397);
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
		internal static global::MonoJavaBridge.MethodId _getBroadcast21398;
		public virtual bool getBroadcast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getBroadcast21398);
		}
		internal static global::MonoJavaBridge.MethodId _bind21399;
		public virtual void bind(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._bind21399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _disconnect21400;
		public virtual void disconnect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._disconnect21400);
		}
		internal static global::MonoJavaBridge.MethodId _isConnected21401;
		public virtual bool isConnected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isConnected21401);
		}
		public new global::java.net.SocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress21402;
		public virtual global::java.net.SocketAddress getLocalSocketAddress()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalSocketAddress21402)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize21403;
		public virtual void setReceiveBufferSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setReceiveBufferSize21403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize21404;
		public virtual int getReceiveBufferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getReceiveBufferSize21404);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout21405;
		public virtual void setSoTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setSoTimeout21405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSoTimeout21406;
		public virtual int getSoTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getSoTimeout21406);
		}
		internal static global::MonoJavaBridge.MethodId _setSendBufferSize21407;
		public virtual void setSendBufferSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setSendBufferSize21407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSendBufferSize21408;
		public virtual int getSendBufferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getSendBufferSize21408);
		}
		public new global::java.net.SocketAddress RemoteSocketAddress
		{
			get
			{
				return getRemoteSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteSocketAddress21409;
		public virtual global::java.net.SocketAddress getRemoteSocketAddress()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getRemoteSocketAddress21409)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isBound21410;
		public virtual bool isBound()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isBound21410);
		}
		public new global::java.net.InetAddress InetAddress
		{
			get
			{
				return getInetAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress21411;
		public virtual global::java.net.InetAddress getInetAddress()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getInetAddress21411)) as java.net.InetAddress;
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress21412;
		public virtual global::java.net.InetAddress getLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalAddress21412)) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort21413;
		public virtual int getLocalPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalPort21413);
		}
		internal static global::MonoJavaBridge.MethodId _setTrafficClass21414;
		public virtual void setTrafficClass(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setTrafficClass21414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTrafficClass21415;
		public virtual int getTrafficClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getTrafficClass21415);
		}
		internal static global::MonoJavaBridge.MethodId _setReuseAddress21416;
		public virtual void setReuseAddress(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setReuseAddress21416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getReuseAddress21417;
		public virtual bool getReuseAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getReuseAddress21417);
		}
		internal static global::MonoJavaBridge.MethodId _receive21418;
		public virtual void receive(java.net.DatagramPacket arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._receive21418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBroadcast21419;
		public virtual void setBroadcast(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setBroadcast21419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.net.DatagramSocketImplFactory DatagramSocketImplFactory
		{
			set
			{
				setDatagramSocketImplFactory(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDatagramSocketImplFactory21420;
		public static void setDatagramSocketImplFactory(java.net.DatagramSocketImplFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setDatagramSocketImplFactory21420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket21421;
		public DatagramSocket(java.net.SocketAddress arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket21421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket21422;
		public DatagramSocket() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket21422);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket21423;
		protected DatagramSocket(java.net.DatagramSocketImpl arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket21423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket21424;
		public DatagramSocket(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket21424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket21425;
		public DatagramSocket(int arg0, java.net.InetAddress arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket21425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DatagramSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocket"));
			global::java.net.DatagramSocket._close21391 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "close", "()V");
			global::java.net.DatagramSocket._send21392 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "send", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocket._getPort21393 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getPort", "()I");
			global::java.net.DatagramSocket._getChannel21394 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getChannel", "()Ljava/nio/channels/DatagramChannel;");
			global::java.net.DatagramSocket._connect21395 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramSocket._connect21396 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/InetAddress;I)V");
			global::java.net.DatagramSocket._isClosed21397 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "isClosed", "()Z");
			global::java.net.DatagramSocket._getBroadcast21398 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getBroadcast", "()Z");
			global::java.net.DatagramSocket._bind21399 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramSocket._disconnect21400 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "disconnect", "()V");
			global::java.net.DatagramSocket._isConnected21401 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "isConnected", "()Z");
			global::java.net.DatagramSocket._getLocalSocketAddress21402 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.DatagramSocket._setReceiveBufferSize21403 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setReceiveBufferSize", "(I)V");
			global::java.net.DatagramSocket._getReceiveBufferSize21404 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getReceiveBufferSize", "()I");
			global::java.net.DatagramSocket._setSoTimeout21405 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setSoTimeout", "(I)V");
			global::java.net.DatagramSocket._getSoTimeout21406 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getSoTimeout", "()I");
			global::java.net.DatagramSocket._setSendBufferSize21407 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setSendBufferSize", "(I)V");
			global::java.net.DatagramSocket._getSendBufferSize21408 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getSendBufferSize", "()I");
			global::java.net.DatagramSocket._getRemoteSocketAddress21409 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getRemoteSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.DatagramSocket._isBound21410 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "isBound", "()Z");
			global::java.net.DatagramSocket._getInetAddress21411 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			global::java.net.DatagramSocket._getLocalAddress21412 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::java.net.DatagramSocket._getLocalPort21413 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getLocalPort", "()I");
			global::java.net.DatagramSocket._setTrafficClass21414 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setTrafficClass", "(I)V");
			global::java.net.DatagramSocket._getTrafficClass21415 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getTrafficClass", "()I");
			global::java.net.DatagramSocket._setReuseAddress21416 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setReuseAddress", "(Z)V");
			global::java.net.DatagramSocket._getReuseAddress21417 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getReuseAddress", "()Z");
			global::java.net.DatagramSocket._receive21418 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "receive", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocket._setBroadcast21419 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setBroadcast", "(Z)V");
			global::java.net.DatagramSocket._setDatagramSocketImplFactory21420 = @__env.GetStaticMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setDatagramSocketImplFactory", "(Ljava/net/DatagramSocketImplFactory;)V");
			global::java.net.DatagramSocket._DatagramSocket21421 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramSocket._DatagramSocket21422 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "()V");
			global::java.net.DatagramSocket._DatagramSocket21423 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/DatagramSocketImpl;)V");
			global::java.net.DatagramSocket._DatagramSocket21424 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(I)V");
			global::java.net.DatagramSocket._DatagramSocket21425 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(ILjava/net/InetAddress;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
