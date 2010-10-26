namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.DatagramSocketImpl_))]
	public abstract partial class DatagramSocketImpl : java.lang.Object, SocketOptions
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatagramSocketImpl()
		{
			InitJNI();
		}
		protected DatagramSocketImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOption21425;
		public abstract global::java.lang.Object getOption(int arg0);
		internal static global::MonoJavaBridge.MethodId _setOption21426;
		public abstract void setOption(int arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _join21427;
		protected abstract void join(java.net.InetAddress arg0);
		internal static global::MonoJavaBridge.MethodId _close21428;
		protected abstract void close();
		internal static global::MonoJavaBridge.MethodId _peek21429;
		protected abstract int peek(java.net.InetAddress arg0);
		internal static global::MonoJavaBridge.MethodId _send21430;
		protected abstract void send(java.net.DatagramPacket arg0);
		internal static global::MonoJavaBridge.MethodId _create21431;
		protected abstract void create();
		internal static global::MonoJavaBridge.MethodId _connect21432;
		protected virtual void connect(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl._connect21432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._connect21432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _peekData21433;
		protected abstract int peekData(java.net.DatagramPacket arg0);
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor21434;
		protected virtual global::java.io.FileDescriptor getFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocketImpl._getFileDescriptor21434)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._getFileDescriptor21434)) as java.io.FileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _bind21435;
		protected abstract void bind(int arg0, java.net.InetAddress arg1);
		internal static global::MonoJavaBridge.MethodId _disconnect21436;
		protected virtual void disconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl._disconnect21436);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._disconnect21436);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort21437;
		protected virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl._getLocalPort21437);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._getLocalPort21437);
		}
		internal static global::MonoJavaBridge.MethodId _receive21438;
		protected abstract void receive(java.net.DatagramPacket arg0);
		internal static global::MonoJavaBridge.MethodId _setTTL21439;
		protected abstract void setTTL(byte arg0);
		internal static global::MonoJavaBridge.MethodId _getTTL21440;
		protected abstract byte getTTL();
		internal static global::MonoJavaBridge.MethodId _setTimeToLive21441;
		protected abstract void setTimeToLive(int arg0);
		internal static global::MonoJavaBridge.MethodId _getTimeToLive21442;
		protected abstract int getTimeToLive();
		internal static global::MonoJavaBridge.MethodId _leave21443;
		protected abstract void leave(java.net.InetAddress arg0);
		internal static global::MonoJavaBridge.MethodId _joinGroup21444;
		protected abstract void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1);
		internal static global::MonoJavaBridge.MethodId _leaveGroup21445;
		protected abstract void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1);
		internal static global::MonoJavaBridge.MethodId _DatagramSocketImpl21446;
		public DatagramSocketImpl()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._DatagramSocketImpl21446);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocketImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocketImpl"));
			global::java.net.DatagramSocketImpl._getOption21425 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getOption", "(I)Ljava/lang/Object;");
			global::java.net.DatagramSocketImpl._setOption21426 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "setOption", "(ILjava/lang/Object;)V");
			global::java.net.DatagramSocketImpl._join21427 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "join", "(Ljava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl._close21428 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "close", "()V");
			global::java.net.DatagramSocketImpl._peek21429 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "peek", "(Ljava/net/InetAddress;)I");
			global::java.net.DatagramSocketImpl._send21430 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "send", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocketImpl._create21431 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "create", "()V");
			global::java.net.DatagramSocketImpl._connect21432 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "connect", "(Ljava/net/InetAddress;I)V");
			global::java.net.DatagramSocketImpl._peekData21433 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "peekData", "(Ljava/net/DatagramPacket;)I");
			global::java.net.DatagramSocketImpl._getFileDescriptor21434 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::java.net.DatagramSocketImpl._bind21435 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "bind", "(ILjava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl._disconnect21436 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "disconnect", "()V");
			global::java.net.DatagramSocketImpl._getLocalPort21437 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getLocalPort", "()I");
			global::java.net.DatagramSocketImpl._receive21438 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "receive", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocketImpl._setTTL21439 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "setTTL", "(B)V");
			global::java.net.DatagramSocketImpl._getTTL21440 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getTTL", "()B");
			global::java.net.DatagramSocketImpl._setTimeToLive21441 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "setTimeToLive", "(I)V");
			global::java.net.DatagramSocketImpl._getTimeToLive21442 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getTimeToLive", "()I");
			global::java.net.DatagramSocketImpl._leave21443 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "leave", "(Ljava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl._joinGroup21444 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::java.net.DatagramSocketImpl._leaveGroup21445 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::java.net.DatagramSocketImpl._DatagramSocketImpl21446 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.DatagramSocketImpl))]
	internal sealed partial class DatagramSocketImpl_ : java.net.DatagramSocketImpl
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatagramSocketImpl_()
		{
			InitJNI();
		}
		internal DatagramSocketImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOption21447;
		public override global::java.lang.Object getOption(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._getOption21447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._getOption21447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setOption21448;
		public override void setOption(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._setOption21448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._setOption21448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _join21449;
		protected override void join(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._join21449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._join21449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close21450;
		protected override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._close21450);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._close21450);
		}
		internal static global::MonoJavaBridge.MethodId _peek21451;
		protected override int peek(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._peek21451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._peek21451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _send21452;
		protected override void send(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._send21452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._send21452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _create21453;
		protected override void create() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._create21453);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._create21453);
		}
		internal static global::MonoJavaBridge.MethodId _peekData21454;
		protected override int peekData(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._peekData21454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._peekData21454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bind21455;
		protected override void bind(int arg0, java.net.InetAddress arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._bind21455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._bind21455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _receive21456;
		protected override void receive(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._receive21456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._receive21456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTTL21457;
		protected override void setTTL(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._setTTL21457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._setTTL21457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTTL21458;
		protected override byte getTTL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._getTTL21458);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._getTTL21458);
		}
		internal static global::MonoJavaBridge.MethodId _setTimeToLive21459;
		protected override void setTimeToLive(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._setTimeToLive21459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._setTimeToLive21459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeToLive21460;
		protected override int getTimeToLive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._getTimeToLive21460);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._getTimeToLive21460);
		}
		internal static global::MonoJavaBridge.MethodId _leave21461;
		protected override void leave(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._leave21461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._leave21461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _joinGroup21462;
		protected override void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._joinGroup21462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._joinGroup21462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _leaveGroup21463;
		protected override void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._leaveGroup21463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._leaveGroup21463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocketImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocketImpl"));
			global::java.net.DatagramSocketImpl_._getOption21447 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "getOption", "(I)Ljava/lang/Object;");
			global::java.net.DatagramSocketImpl_._setOption21448 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "setOption", "(ILjava/lang/Object;)V");
			global::java.net.DatagramSocketImpl_._join21449 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "join", "(Ljava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl_._close21450 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "close", "()V");
			global::java.net.DatagramSocketImpl_._peek21451 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "peek", "(Ljava/net/InetAddress;)I");
			global::java.net.DatagramSocketImpl_._send21452 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "send", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocketImpl_._create21453 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "create", "()V");
			global::java.net.DatagramSocketImpl_._peekData21454 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "peekData", "(Ljava/net/DatagramPacket;)I");
			global::java.net.DatagramSocketImpl_._bind21455 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "bind", "(ILjava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl_._receive21456 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "receive", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocketImpl_._setTTL21457 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "setTTL", "(B)V");
			global::java.net.DatagramSocketImpl_._getTTL21458 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "getTTL", "()B");
			global::java.net.DatagramSocketImpl_._setTimeToLive21459 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "setTimeToLive", "(I)V");
			global::java.net.DatagramSocketImpl_._getTimeToLive21460 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "getTimeToLive", "()I");
			global::java.net.DatagramSocketImpl_._leave21461 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "leave", "(Ljava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl_._joinGroup21462 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::java.net.DatagramSocketImpl_._leaveGroup21463 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
		}
	}
}
