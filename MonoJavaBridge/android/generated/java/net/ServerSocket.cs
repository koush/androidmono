namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ServerSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ServerSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString21698;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._toString21698.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._toString21698 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._toString21698) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close21699;
		public virtual void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._close21699.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._close21699 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._close21699);
		}
		internal static global::MonoJavaBridge.MethodId _accept21700;
		public virtual global::java.net.Socket accept()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._accept21700.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._accept21700 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "accept", "()Ljava/net/Socket;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._accept21700) as java.net.Socket;
		}
		public new global::java.nio.channels.ServerSocketChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel21701;
		public virtual global::java.nio.channels.ServerSocketChannel getChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._getChannel21701.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._getChannel21701 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getChannel", "()Ljava/nio/channels/ServerSocketChannel;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getChannel21701) as java.nio.channels.ServerSocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _isClosed21702;
		public virtual bool isClosed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._isClosed21702.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._isClosed21702 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "isClosed", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._isClosed21702);
		}
		internal static global::MonoJavaBridge.MethodId _bind21703;
		public virtual void bind(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._bind21703.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._bind21703 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._bind21703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bind21704;
		public virtual void bind(java.net.SocketAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._bind21704.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._bind21704 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "bind", "(Ljava/net/SocketAddress;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._bind21704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.net.SocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress21705;
		public virtual global::java.net.SocketAddress getLocalSocketAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._getLocalSocketAddress21705.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._getLocalSocketAddress21705 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getLocalSocketAddress21705) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize21706;
		public virtual void setReceiveBufferSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._setReceiveBufferSize21706.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._setReceiveBufferSize21706 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setReceiveBufferSize", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setReceiveBufferSize21706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize21707;
		public virtual int getReceiveBufferSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._getReceiveBufferSize21707.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._getReceiveBufferSize21707 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getReceiveBufferSize", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getReceiveBufferSize21707);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout21708;
		public virtual void setSoTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._setSoTimeout21708.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._setSoTimeout21708 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setSoTimeout", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setSoTimeout21708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSoTimeout21709;
		public virtual int getSoTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._getSoTimeout21709.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._getSoTimeout21709 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getSoTimeout", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getSoTimeout21709);
		}
		internal static global::MonoJavaBridge.MethodId _isBound21710;
		public virtual bool isBound()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._isBound21710.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._isBound21710 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "isBound", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._isBound21710);
		}
		public new global::java.net.InetAddress InetAddress
		{
			get
			{
				return getInetAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress21711;
		public virtual global::java.net.InetAddress getInetAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._getInetAddress21711.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._getInetAddress21711 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getInetAddress21711) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort21712;
		public virtual int getLocalPort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._getLocalPort21712.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._getLocalPort21712 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getLocalPort", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getLocalPort21712);
		}
		internal static global::MonoJavaBridge.MethodId _setReuseAddress21713;
		public virtual void setReuseAddress(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._setReuseAddress21713.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._setReuseAddress21713 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setReuseAddress", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setReuseAddress21713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getReuseAddress21714;
		public virtual bool getReuseAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._getReuseAddress21714.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._getReuseAddress21714 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getReuseAddress", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getReuseAddress21714);
		}
		internal static global::MonoJavaBridge.MethodId _setPerformancePreferences21715;
		public virtual void setPerformancePreferences(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._setPerformancePreferences21715.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._setPerformancePreferences21715 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setPerformancePreferences", "(III)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setPerformancePreferences21715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _implAccept21716;
		protected virtual void implAccept(java.net.Socket arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._implAccept21716.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._implAccept21716 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "implAccept", "(Ljava/net/Socket;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._implAccept21716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.net.SocketImplFactory SocketFactory
		{
			set
			{
				setSocketFactory(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSocketFactory21717;
		public static void setSocketFactory(java.net.SocketImplFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._setSocketFactory21717.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._setSocketFactory21717 = @__env.GetStaticMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setSocketFactory", "(Ljava/net/SocketImplFactory;)V");
			@__env.CallStaticVoidMethod(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setSocketFactory21717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket21718;
		public ServerSocket() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._ServerSocket21718.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._ServerSocket21718 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket21718);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket21719;
		public ServerSocket(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._ServerSocket21719.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._ServerSocket21719 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket21719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket21720;
		public ServerSocket(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._ServerSocket21720.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._ServerSocket21720 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket21720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket21721;
		public ServerSocket(int arg0, int arg1, java.net.InetAddress arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._ServerSocket21721.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._ServerSocket21721 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "(IILjava/net/InetAddress;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket21721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ServerSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ServerSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ServerSocket"));
		}
		internal static void InitJNI()
		{
		}
	}
}
