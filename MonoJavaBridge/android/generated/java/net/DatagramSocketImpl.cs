namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.DatagramSocketImpl_))]
	public abstract partial class DatagramSocketImpl : java.lang.Object, SocketOptions
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DatagramSocketImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOption21426;
		public abstract global::java.lang.Object getOption(int arg0);
		internal static global::MonoJavaBridge.MethodId _setOption21427;
		public abstract void setOption(int arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _join21428;
		protected abstract void join(java.net.InetAddress arg0);
		internal static global::MonoJavaBridge.MethodId _close21429;
		protected abstract void close();
		internal static global::MonoJavaBridge.MethodId _peek21430;
		protected abstract int peek(java.net.InetAddress arg0);
		internal static global::MonoJavaBridge.MethodId _send21431;
		protected abstract void send(java.net.DatagramPacket arg0);
		internal static global::MonoJavaBridge.MethodId _create21432;
		protected abstract void create();
		internal static global::MonoJavaBridge.MethodId _connect21433;
		protected virtual void connect(java.net.InetAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl._connect21433.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl._connect21433 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "connect", "(Ljava/net/InetAddress;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._connect21433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _peekData21434;
		protected abstract int peekData(java.net.DatagramPacket arg0);
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor21435;
		protected virtual global::java.io.FileDescriptor getFileDescriptor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl._getFileDescriptor21435.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl._getFileDescriptor21435 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.io.FileDescriptor>(this, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._getFileDescriptor21435) as java.io.FileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _bind21436;
		protected abstract void bind(int arg0, java.net.InetAddress arg1);
		internal static global::MonoJavaBridge.MethodId _disconnect21437;
		protected virtual void disconnect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl._disconnect21437.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl._disconnect21437 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "disconnect", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._disconnect21437);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort21438;
		protected virtual int getLocalPort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl._getLocalPort21438.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl._getLocalPort21438 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getLocalPort", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._getLocalPort21438);
		}
		internal static global::MonoJavaBridge.MethodId _receive21439;
		protected abstract void receive(java.net.DatagramPacket arg0);
		internal static global::MonoJavaBridge.MethodId _setTTL21440;
		protected abstract void setTTL(byte arg0);
		internal static global::MonoJavaBridge.MethodId _getTTL21441;
		protected abstract byte getTTL();
		internal static global::MonoJavaBridge.MethodId _setTimeToLive21442;
		protected abstract void setTimeToLive(int arg0);
		internal static global::MonoJavaBridge.MethodId _getTimeToLive21443;
		protected abstract int getTimeToLive();
		internal static global::MonoJavaBridge.MethodId _leave21444;
		protected abstract void leave(java.net.InetAddress arg0);
		internal static global::MonoJavaBridge.MethodId _joinGroup21445;
		protected abstract void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1);
		internal static global::MonoJavaBridge.MethodId _leaveGroup21446;
		protected abstract void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1);
		internal static global::MonoJavaBridge.MethodId _DatagramSocketImpl21447;
		public DatagramSocketImpl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl._DatagramSocketImpl21447.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl._DatagramSocketImpl21447 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._DatagramSocketImpl21447);
			Init(@__env, handle);
		}
		static DatagramSocketImpl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocketImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocketImpl"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.DatagramSocketImpl))]
	internal sealed partial class DatagramSocketImpl_ : java.net.DatagramSocketImpl
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DatagramSocketImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOption21448;
		public override global::java.lang.Object getOption(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._getOption21448.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._getOption21448 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "getOption", "(I)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._getOption21448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setOption21449;
		public override void setOption(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._setOption21449.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._setOption21449 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "setOption", "(ILjava/lang/Object;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._setOption21449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _join21450;
		protected override void join(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._join21450.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._join21450 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "join", "(Ljava/net/InetAddress;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._join21450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close21451;
		protected override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._close21451.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._close21451 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "close", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._close21451);
		}
		internal static global::MonoJavaBridge.MethodId _peek21452;
		protected override int peek(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._peek21452.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._peek21452 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "peek", "(Ljava/net/InetAddress;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._peek21452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _send21453;
		protected override void send(java.net.DatagramPacket arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._send21453.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._send21453 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "send", "(Ljava/net/DatagramPacket;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._send21453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _create21454;
		protected override void create()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._create21454.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._create21454 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "create", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._create21454);
		}
		internal static global::MonoJavaBridge.MethodId _peekData21455;
		protected override int peekData(java.net.DatagramPacket arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._peekData21455.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._peekData21455 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "peekData", "(Ljava/net/DatagramPacket;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._peekData21455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bind21456;
		protected override void bind(int arg0, java.net.InetAddress arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._bind21456.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._bind21456 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "bind", "(ILjava/net/InetAddress;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._bind21456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _receive21457;
		protected override void receive(java.net.DatagramPacket arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._receive21457.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._receive21457 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "receive", "(Ljava/net/DatagramPacket;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._receive21457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTTL21458;
		protected override void setTTL(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._setTTL21458.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._setTTL21458 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "setTTL", "(B)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._setTTL21458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTTL21459;
		protected override byte getTTL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._getTTL21459.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._getTTL21459 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "getTTL", "()B");
			return @__env.CallByteMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._getTTL21459);
		}
		internal static global::MonoJavaBridge.MethodId _setTimeToLive21460;
		protected override void setTimeToLive(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._setTimeToLive21460.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._setTimeToLive21460 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "setTimeToLive", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._setTimeToLive21460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeToLive21461;
		protected override int getTimeToLive()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._getTimeToLive21461.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._getTimeToLive21461 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "getTimeToLive", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._getTimeToLive21461);
		}
		internal static global::MonoJavaBridge.MethodId _leave21462;
		protected override void leave(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._leave21462.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._leave21462 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "leave", "(Ljava/net/InetAddress;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._leave21462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _joinGroup21463;
		protected override void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._joinGroup21463.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._joinGroup21463 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._joinGroup21463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _leaveGroup21464;
		protected override void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl_._leaveGroup21464.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl_._leaveGroup21464 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._leaveGroup21464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static DatagramSocketImpl_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocketImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocketImpl"));
		}
		internal static void InitJNI()
		{
		}
	}
}
