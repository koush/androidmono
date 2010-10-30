namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DatagramSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DatagramSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, "close", "()V", ref global::java.net.DatagramSocket._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void send(java.net.DatagramPacket arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, "send", "(Ljava/net/DatagramPacket;)V", ref global::java.net.DatagramSocket._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocket.staticClass, "getPort", "()I", ref global::java.net.DatagramSocket._m2);
		}
		public new global::java.nio.channels.DatagramChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.nio.channels.DatagramChannel getChannel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramSocket.staticClass, "getChannel", "()Ljava/nio/channels/DatagramChannel;", ref global::java.net.DatagramSocket._m3) as java.nio.channels.DatagramChannel;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void connect(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/SocketAddress;)V", ref global::java.net.DatagramSocket._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void connect(java.net.InetAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/InetAddress;I)V", ref global::java.net.DatagramSocket._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.DatagramSocket.staticClass, "isClosed", "()Z", ref global::java.net.DatagramSocket._m6);
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
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool getBroadcast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.DatagramSocket.staticClass, "getBroadcast", "()Z", ref global::java.net.DatagramSocket._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void bind(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V", ref global::java.net.DatagramSocket._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void disconnect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, "disconnect", "()V", ref global::java.net.DatagramSocket._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isConnected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.DatagramSocket.staticClass, "isConnected", "()Z", ref global::java.net.DatagramSocket._m10);
		}
		public new global::java.net.SocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.net.SocketAddress getLocalSocketAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramSocket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;", ref global::java.net.DatagramSocket._m11) as java.net.SocketAddress;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setReceiveBufferSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, "setReceiveBufferSize", "(I)V", ref global::java.net.DatagramSocket._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int getReceiveBufferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocket.staticClass, "getReceiveBufferSize", "()I", ref global::java.net.DatagramSocket._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setSoTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, "setSoTimeout", "(I)V", ref global::java.net.DatagramSocket._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int getSoTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocket.staticClass, "getSoTimeout", "()I", ref global::java.net.DatagramSocket._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setSendBufferSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, "setSendBufferSize", "(I)V", ref global::java.net.DatagramSocket._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual int getSendBufferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocket.staticClass, "getSendBufferSize", "()I", ref global::java.net.DatagramSocket._m17);
		}
		public new global::java.net.SocketAddress RemoteSocketAddress
		{
			get
			{
				return getRemoteSocketAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.net.SocketAddress getRemoteSocketAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramSocket.staticClass, "getRemoteSocketAddress", "()Ljava/net/SocketAddress;", ref global::java.net.DatagramSocket._m18) as java.net.SocketAddress;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool isBound()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.DatagramSocket.staticClass, "isBound", "()Z", ref global::java.net.DatagramSocket._m19);
		}
		public new global::java.net.InetAddress InetAddress
		{
			get
			{
				return getInetAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.net.InetAddress getInetAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramSocket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;", ref global::java.net.DatagramSocket._m20) as java.net.InetAddress;
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::java.net.InetAddress getLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramSocket.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;", ref global::java.net.DatagramSocket._m21) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual int getLocalPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocket.staticClass, "getLocalPort", "()I", ref global::java.net.DatagramSocket._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setTrafficClass(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, "setTrafficClass", "(I)V", ref global::java.net.DatagramSocket._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual int getTrafficClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocket.staticClass, "getTrafficClass", "()I", ref global::java.net.DatagramSocket._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setReuseAddress(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, "setReuseAddress", "(Z)V", ref global::java.net.DatagramSocket._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool getReuseAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.DatagramSocket.staticClass, "getReuseAddress", "()Z", ref global::java.net.DatagramSocket._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void receive(java.net.DatagramPacket arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, "receive", "(Ljava/net/DatagramPacket;)V", ref global::java.net.DatagramSocket._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setBroadcast(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocket.staticClass, "setBroadcast", "(Z)V", ref global::java.net.DatagramSocket._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.net.DatagramSocketImplFactory DatagramSocketImplFactory
		{
			set
			{
				setDatagramSocketImplFactory(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static void setDatagramSocketImplFactory(java.net.DatagramSocketImplFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocket._m29.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocket._m29 = @__env.GetStaticMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setDatagramSocketImplFactory", "(Ljava/net/DatagramSocketImplFactory;)V");
			@__env.CallStaticVoidMethod(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public DatagramSocket(java.net.SocketAddress arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocket._m30.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocket._m30 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/SocketAddress;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public DatagramSocket() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocket._m31.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocket._m31 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._m31);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		protected DatagramSocket(java.net.DatagramSocketImpl arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocket._m32.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocket._m32 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/DatagramSocketImpl;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public DatagramSocket(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocket._m33.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocket._m33 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public DatagramSocket(int arg0, java.net.InetAddress arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocket._m34.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocket._m34 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(ILjava/net/InetAddress;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DatagramSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocket"));
		}
		internal static void InitJNI()
		{
		}
	}
}
