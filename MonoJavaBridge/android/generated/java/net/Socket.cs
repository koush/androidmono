namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Socket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Socket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.Socket.staticClass, "toString", "()Ljava/lang/String;", ref global::java.net.Socket._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "close", "()V", ref global::java.net.Socket._m1);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.Socket.staticClass, "getPort", "()I", ref global::java.net.Socket._m2);
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.io.InputStream getInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.Socket.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::java.net.Socket._m3) as java.io.InputStream;
		}
		public new global::java.nio.channels.SocketChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.nio.channels.SocketChannel getChannel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.Socket.staticClass, "getChannel", "()Ljava/nio/channels/SocketChannel;", ref global::java.net.Socket._m4) as java.nio.channels.SocketChannel;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void connect(java.net.SocketAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "connect", "(Ljava/net/SocketAddress;I)V", ref global::java.net.Socket._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void connect(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "connect", "(Ljava/net/SocketAddress;)V", ref global::java.net.Socket._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Socket.staticClass, "isClosed", "()Z", ref global::java.net.Socket._m7);
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.io.OutputStream getOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.Socket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::java.net.Socket._m8) as java.io.OutputStream;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void bind(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "bind", "(Ljava/net/SocketAddress;)V", ref global::java.net.Socket._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isConnected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Socket.staticClass, "isConnected", "()Z", ref global::java.net.Socket._m10);
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.Socket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;", ref global::java.net.Socket._m11) as java.net.SocketAddress;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void shutdownInput()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "shutdownInput", "()V", ref global::java.net.Socket._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void shutdownOutput()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "shutdownOutput", "()V", ref global::java.net.Socket._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setReceiveBufferSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "setReceiveBufferSize", "(I)V", ref global::java.net.Socket._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int getReceiveBufferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.Socket.staticClass, "getReceiveBufferSize", "()I", ref global::java.net.Socket._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setSoTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "setSoTimeout", "(I)V", ref global::java.net.Socket._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual int getSoTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.Socket.staticClass, "getSoTimeout", "()I", ref global::java.net.Socket._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setSendBufferSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "setSendBufferSize", "(I)V", ref global::java.net.Socket._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int getSendBufferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.Socket.staticClass, "getSendBufferSize", "()I", ref global::java.net.Socket._m19);
		}
		public new global::java.net.SocketAddress RemoteSocketAddress
		{
			get
			{
				return getRemoteSocketAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.net.SocketAddress getRemoteSocketAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.Socket.staticClass, "getRemoteSocketAddress", "()Ljava/net/SocketAddress;", ref global::java.net.Socket._m20) as java.net.SocketAddress;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool isBound()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Socket.staticClass, "isBound", "()Z", ref global::java.net.Socket._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool isOutputShutdown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Socket.staticClass, "isOutputShutdown", "()Z", ref global::java.net.Socket._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool isInputShutdown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Socket.staticClass, "isInputShutdown", "()Z", ref global::java.net.Socket._m23);
		}
		public new global::java.net.InetAddress InetAddress
		{
			get
			{
				return getInetAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual global::java.net.InetAddress getInetAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.Socket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;", ref global::java.net.Socket._m24) as java.net.InetAddress;
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.net.InetAddress getLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.Socket.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;", ref global::java.net.Socket._m25) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual int getLocalPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.Socket.staticClass, "getLocalPort", "()I", ref global::java.net.Socket._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void setTcpNoDelay(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "setTcpNoDelay", "(Z)V", ref global::java.net.Socket._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual bool getTcpNoDelay()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Socket.staticClass, "getTcpNoDelay", "()Z", ref global::java.net.Socket._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void setSoLinger(bool arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "setSoLinger", "(ZI)V", ref global::java.net.Socket._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int SoLinger
		{
			get
			{
				return getSoLinger();
			}
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual int getSoLinger()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.Socket.staticClass, "getSoLinger", "()I", ref global::java.net.Socket._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void sendUrgentData(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "sendUrgentData", "(I)V", ref global::java.net.Socket._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setOOBInline(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "setOOBInline", "(Z)V", ref global::java.net.Socket._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual bool getOOBInline()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Socket.staticClass, "getOOBInline", "()Z", ref global::java.net.Socket._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void setKeepAlive(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "setKeepAlive", "(Z)V", ref global::java.net.Socket._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual bool getKeepAlive()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Socket.staticClass, "getKeepAlive", "()Z", ref global::java.net.Socket._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void setTrafficClass(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "setTrafficClass", "(I)V", ref global::java.net.Socket._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual int getTrafficClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.Socket.staticClass, "getTrafficClass", "()I", ref global::java.net.Socket._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual void setReuseAddress(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "setReuseAddress", "(Z)V", ref global::java.net.Socket._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual bool getReuseAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.Socket.staticClass, "getReuseAddress", "()Z", ref global::java.net.Socket._m39);
		}
		public static global::java.net.SocketImplFactory SocketImplFactory
		{
			set
			{
				setSocketImplFactory(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public static void setSocketImplFactory(java.net.SocketImplFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Socket._m40.native == global::System.IntPtr.Zero)
				global::java.net.Socket._m40 = @__env.GetStaticMethodIDNoThrow(global::java.net.Socket.staticClass, "setSocketImplFactory", "(Ljava/net/SocketImplFactory;)V");
			@__env.CallStaticVoidMethod(java.net.Socket.staticClass, global::java.net.Socket._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual void setPerformancePreferences(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.Socket.staticClass, "setPerformancePreferences", "(III)V", ref global::java.net.Socket._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public Socket() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Socket._m42.native == global::System.IntPtr.Zero)
				global::java.net.Socket._m42 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._m42);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public Socket(java.net.Proxy arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Socket._m43.native == global::System.IntPtr.Zero)
				global::java.net.Socket._m43 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/Proxy;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		protected Socket(java.net.SocketImpl arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Socket._m44.native == global::System.IntPtr.Zero)
				global::java.net.Socket._m44 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/SocketImpl;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public Socket(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Socket._m45.native == global::System.IntPtr.Zero)
				global::java.net.Socket._m45 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public Socket(java.net.InetAddress arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Socket._m46.native == global::System.IntPtr.Zero)
				global::java.net.Socket._m46 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public Socket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Socket._m47.native == global::System.IntPtr.Zero)
				global::java.net.Socket._m47 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public Socket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Socket._m48.native == global::System.IntPtr.Zero)
				global::java.net.Socket._m48 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public Socket(java.lang.String arg0, int arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Socket._m49.native == global::System.IntPtr.Zero)
				global::java.net.Socket._m49 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;IZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public Socket(java.net.InetAddress arg0, int arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.Socket._m50.native == global::System.IntPtr.Zero)
				global::java.net.Socket._m50 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;IZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Socket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Socket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Socket"));
		}
		internal static void InitJNI()
		{
		}
	}
}
