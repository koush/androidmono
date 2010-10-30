namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MulticastSocket : java.net.DatagramSocket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MulticastSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _send21610;
		public virtual void send(java.net.DatagramPacket arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._send21610.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._send21610 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "send", "(Ljava/net/DatagramPacket;B)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._send21610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bind21611;
		public override void bind(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._bind21611.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._bind21611 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._bind21611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTTL21612;
		public virtual void setTTL(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._setTTL21612.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._setTTL21612 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setTTL", "(B)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setTTL21612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTTL21613;
		public virtual byte getTTL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._getTTL21613.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._getTTL21613 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getTTL", "()B");
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getTTL21613);
		}
		internal static global::MonoJavaBridge.MethodId _setTimeToLive21614;
		public virtual void setTimeToLive(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._setTimeToLive21614.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._setTimeToLive21614 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setTimeToLive", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setTimeToLive21614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTimeToLive21615;
		public virtual int getTimeToLive()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._getTimeToLive21615.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._getTimeToLive21615 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getTimeToLive", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getTimeToLive21615);
		}
		internal static global::MonoJavaBridge.MethodId _joinGroup21616;
		public virtual void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._joinGroup21616.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._joinGroup21616 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._joinGroup21616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _joinGroup21617;
		public virtual void joinGroup(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._joinGroup21617.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._joinGroup21617 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "joinGroup", "(Ljava/net/InetAddress;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._joinGroup21617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _leaveGroup21618;
		public virtual void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._leaveGroup21618.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._leaveGroup21618 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._leaveGroup21618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _leaveGroup21619;
		public virtual void leaveGroup(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._leaveGroup21619.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._leaveGroup21619 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "leaveGroup", "(Ljava/net/InetAddress;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._leaveGroup21619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterface21620;
		public virtual void setInterface(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._setInterface21620.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._setInterface21620 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setInterface", "(Ljava/net/InetAddress;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setInterface21620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getInterface21621;
		public virtual global::java.net.InetAddress getInterface()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._getInterface21621.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._getInterface21621 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getInterface", "()Ljava/net/InetAddress;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getInterface21621) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setNetworkInterface21622;
		public virtual void setNetworkInterface(java.net.NetworkInterface arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._setNetworkInterface21622.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._setNetworkInterface21622 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setNetworkInterface", "(Ljava/net/NetworkInterface;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setNetworkInterface21622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNetworkInterface21623;
		public virtual global::java.net.NetworkInterface getNetworkInterface()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._getNetworkInterface21623.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._getNetworkInterface21623 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getNetworkInterface", "()Ljava/net/NetworkInterface;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.NetworkInterface>(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getNetworkInterface21623) as java.net.NetworkInterface;
		}
		internal static global::MonoJavaBridge.MethodId _setLoopbackMode21624;
		public virtual void setLoopbackMode(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._setLoopbackMode21624.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._setLoopbackMode21624 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setLoopbackMode", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setLoopbackMode21624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLoopbackMode21625;
		public virtual bool getLoopbackMode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._getLoopbackMode21625.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._getLoopbackMode21625 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getLoopbackMode", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getLoopbackMode21625);
		}
		internal static global::MonoJavaBridge.MethodId _MulticastSocket21626;
		public MulticastSocket() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._MulticastSocket21626.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._MulticastSocket21626 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._MulticastSocket21626);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MulticastSocket21627;
		public MulticastSocket(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._MulticastSocket21627.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._MulticastSocket21627 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._MulticastSocket21627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MulticastSocket21628;
		public MulticastSocket(java.net.SocketAddress arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.MulticastSocket._MulticastSocket21628.native == global::System.IntPtr.Zero)
				global::java.net.MulticastSocket._MulticastSocket21628 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "<init>", "(Ljava/net/SocketAddress;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._MulticastSocket21628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MulticastSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.MulticastSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/MulticastSocket"));
		}
		internal static void InitJNI()
		{
		}
	}
}
