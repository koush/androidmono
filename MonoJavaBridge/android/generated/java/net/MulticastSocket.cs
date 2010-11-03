namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MulticastSocket : java.net.DatagramSocket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MulticastSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void send(java.net.DatagramPacket arg0, byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, "send", "(Ljava/net/DatagramPacket;B)V", ref global::java.net.MulticastSocket._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void bind(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V", ref global::java.net.MulticastSocket._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setTTL(byte arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, "setTTL", "(B)V", ref global::java.net.MulticastSocket._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new byte TTL
		{
			get
			{
				return getTTL();
			}
			set
			{
				setTTL(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual byte getTTL()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.net.MulticastSocket.staticClass, "getTTL", "()B", ref global::java.net.MulticastSocket._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setTimeToLive(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, "setTimeToLive", "(I)V", ref global::java.net.MulticastSocket._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int TimeToLive
		{
			get
			{
				return getTimeToLive();
			}
			set
			{
				setTimeToLive(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getTimeToLive()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.MulticastSocket.staticClass, "getTimeToLive", "()I", ref global::java.net.MulticastSocket._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", ref global::java.net.MulticastSocket._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void joinGroup(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, "joinGroup", "(Ljava/net/InetAddress;)V", ref global::java.net.MulticastSocket._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", ref global::java.net.MulticastSocket._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void leaveGroup(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, "leaveGroup", "(Ljava/net/InetAddress;)V", ref global::java.net.MulticastSocket._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setInterface(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, "setInterface", "(Ljava/net/InetAddress;)V", ref global::java.net.MulticastSocket._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.net.InetAddress Interface
		{
			get
			{
				return getInterface();
			}
			set
			{
				setInterface(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.net.InetAddress getInterface()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.MulticastSocket.staticClass, "getInterface", "()Ljava/net/InetAddress;", ref global::java.net.MulticastSocket._m11) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setNetworkInterface(java.net.NetworkInterface arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, "setNetworkInterface", "(Ljava/net/NetworkInterface;)V", ref global::java.net.MulticastSocket._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.net.NetworkInterface NetworkInterface
		{
			get
			{
				return getNetworkInterface();
			}
			set
			{
				setNetworkInterface(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.net.NetworkInterface getNetworkInterface()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.NetworkInterface>(this, global::java.net.MulticastSocket.staticClass, "getNetworkInterface", "()Ljava/net/NetworkInterface;", ref global::java.net.MulticastSocket._m13) as java.net.NetworkInterface;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setLoopbackMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, "setLoopbackMode", "(Z)V", ref global::java.net.MulticastSocket._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool LoopbackMode
		{
			get
			{
				return getLoopbackMode();
			}
			set
			{
				setLoopbackMode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool getLoopbackMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.MulticastSocket.staticClass, "getLoopbackMode", "()Z", ref global::java.net.MulticastSocket._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public MulticastSocket() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._m16.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._m16 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._m16);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public MulticastSocket(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._m17.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._m17 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public MulticastSocket(java.net.SocketAddress arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._m18.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._m18 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "<init>", "(Ljava/net/SocketAddress;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MulticastSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.MulticastSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/MulticastSocket"));
		}
	}
}
