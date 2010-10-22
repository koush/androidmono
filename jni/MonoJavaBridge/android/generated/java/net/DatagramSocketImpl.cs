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
		internal static global::MonoJavaBridge.MethodId _getOption21307;
		public abstract global::java.lang.Object getOption(int arg0);
		internal static global::MonoJavaBridge.MethodId _setOption21308;
		public abstract void setOption(int arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _join21309;
		protected abstract void join(java.net.InetAddress arg0);
		internal static global::MonoJavaBridge.MethodId _close21310;
		protected abstract void close();
		internal static global::MonoJavaBridge.MethodId _peek21311;
		protected abstract int peek(java.net.InetAddress arg0);
		internal static global::MonoJavaBridge.MethodId _send21312;
		protected abstract void send(java.net.DatagramPacket arg0);
		internal static global::MonoJavaBridge.MethodId _create21313;
		protected abstract void create();
		internal static global::MonoJavaBridge.MethodId _connect21314;
		protected virtual void connect(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl._connect21314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._connect21314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _peekData21315;
		protected abstract int peekData(java.net.DatagramPacket arg0);
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor21316;
		protected virtual global::java.io.FileDescriptor getFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocketImpl._getFileDescriptor21316)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._getFileDescriptor21316)) as java.io.FileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _bind21317;
		protected abstract void bind(int arg0, java.net.InetAddress arg1);
		internal static global::MonoJavaBridge.MethodId _disconnect21318;
		protected virtual void disconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl._disconnect21318);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._disconnect21318);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort21319;
		protected virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl._getLocalPort21319);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._getLocalPort21319);
		}
		internal static global::MonoJavaBridge.MethodId _receive21320;
		protected abstract void receive(java.net.DatagramPacket arg0);
		internal static global::MonoJavaBridge.MethodId _setTTL21321;
		protected abstract void setTTL(byte arg0);
		internal static global::MonoJavaBridge.MethodId _getTTL21322;
		protected abstract byte getTTL();
		internal static global::MonoJavaBridge.MethodId _setTimeToLive21323;
		protected abstract void setTimeToLive(int arg0);
		internal static global::MonoJavaBridge.MethodId _getTimeToLive21324;
		protected abstract int getTimeToLive();
		internal static global::MonoJavaBridge.MethodId _leave21325;
		protected abstract void leave(java.net.InetAddress arg0);
		internal static global::MonoJavaBridge.MethodId _joinGroup21326;
		protected abstract void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1);
		internal static global::MonoJavaBridge.MethodId _leaveGroup21327;
		protected abstract void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1);
		internal static global::MonoJavaBridge.MethodId _DatagramSocketImpl21328;
		public DatagramSocketImpl()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._DatagramSocketImpl21328);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocketImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocketImpl"));
			global::java.net.DatagramSocketImpl._getOption21307 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getOption", "(I)Ljava/lang/Object;");
			global::java.net.DatagramSocketImpl._setOption21308 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "setOption", "(ILjava/lang/Object;)V");
			global::java.net.DatagramSocketImpl._join21309 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "join", "(Ljava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl._close21310 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "close", "()V");
			global::java.net.DatagramSocketImpl._peek21311 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "peek", "(Ljava/net/InetAddress;)I");
			global::java.net.DatagramSocketImpl._send21312 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "send", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocketImpl._create21313 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "create", "()V");
			global::java.net.DatagramSocketImpl._connect21314 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "connect", "(Ljava/net/InetAddress;I)V");
			global::java.net.DatagramSocketImpl._peekData21315 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "peekData", "(Ljava/net/DatagramPacket;)I");
			global::java.net.DatagramSocketImpl._getFileDescriptor21316 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::java.net.DatagramSocketImpl._bind21317 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "bind", "(ILjava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl._disconnect21318 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "disconnect", "()V");
			global::java.net.DatagramSocketImpl._getLocalPort21319 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getLocalPort", "()I");
			global::java.net.DatagramSocketImpl._receive21320 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "receive", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocketImpl._setTTL21321 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "setTTL", "(B)V");
			global::java.net.DatagramSocketImpl._getTTL21322 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getTTL", "()B");
			global::java.net.DatagramSocketImpl._setTimeToLive21323 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "setTimeToLive", "(I)V");
			global::java.net.DatagramSocketImpl._getTimeToLive21324 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getTimeToLive", "()I");
			global::java.net.DatagramSocketImpl._leave21325 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "leave", "(Ljava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl._joinGroup21326 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::java.net.DatagramSocketImpl._leaveGroup21327 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::java.net.DatagramSocketImpl._DatagramSocketImpl21328 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.DatagramSocketImpl))]
	public sealed partial class DatagramSocketImpl_ : java.net.DatagramSocketImpl
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatagramSocketImpl_()
		{
			InitJNI();
		}
		internal DatagramSocketImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOption21329;
		public override global::java.lang.Object getOption(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._getOption21329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._getOption21329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setOption21330;
		public override void setOption(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._setOption21330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._setOption21330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _join21331;
		protected override void join(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._join21331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._join21331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close21332;
		protected override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._close21332);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._close21332);
		}
		internal static global::MonoJavaBridge.MethodId _peek21333;
		protected override int peek(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._peek21333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._peek21333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _send21334;
		protected override void send(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._send21334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._send21334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _create21335;
		protected override void create() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._create21335);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._create21335);
		}
		internal static global::MonoJavaBridge.MethodId _peekData21336;
		protected override int peekData(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._peekData21336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._peekData21336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bind21337;
		protected override void bind(int arg0, java.net.InetAddress arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._bind21337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._bind21337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _receive21338;
		protected override void receive(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._receive21338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._receive21338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTTL21339;
		protected override void setTTL(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._setTTL21339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._setTTL21339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTTL21340;
		protected override byte getTTL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._getTTL21340);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._getTTL21340);
		}
		internal static global::MonoJavaBridge.MethodId _setTimeToLive21341;
		protected override void setTimeToLive(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._setTimeToLive21341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._setTimeToLive21341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeToLive21342;
		protected override int getTimeToLive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._getTimeToLive21342);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._getTimeToLive21342);
		}
		internal static global::MonoJavaBridge.MethodId _leave21343;
		protected override void leave(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._leave21343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._leave21343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _joinGroup21344;
		protected override void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._joinGroup21344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._joinGroup21344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _leaveGroup21345;
		protected override void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._leaveGroup21345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._leaveGroup21345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocketImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocketImpl"));
			global::java.net.DatagramSocketImpl_._getOption21329 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "getOption", "(I)Ljava/lang/Object;");
			global::java.net.DatagramSocketImpl_._setOption21330 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "setOption", "(ILjava/lang/Object;)V");
			global::java.net.DatagramSocketImpl_._join21331 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "join", "(Ljava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl_._close21332 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "close", "()V");
			global::java.net.DatagramSocketImpl_._peek21333 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "peek", "(Ljava/net/InetAddress;)I");
			global::java.net.DatagramSocketImpl_._send21334 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "send", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocketImpl_._create21335 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "create", "()V");
			global::java.net.DatagramSocketImpl_._peekData21336 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "peekData", "(Ljava/net/DatagramPacket;)I");
			global::java.net.DatagramSocketImpl_._bind21337 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "bind", "(ILjava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl_._receive21338 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "receive", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocketImpl_._setTTL21339 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "setTTL", "(B)V");
			global::java.net.DatagramSocketImpl_._getTTL21340 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "getTTL", "()B");
			global::java.net.DatagramSocketImpl_._setTimeToLive21341 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "setTimeToLive", "(I)V");
			global::java.net.DatagramSocketImpl_._getTimeToLive21342 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "getTimeToLive", "()I");
			global::java.net.DatagramSocketImpl_._leave21343 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "leave", "(Ljava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl_._joinGroup21344 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::java.net.DatagramSocketImpl_._leaveGroup21345 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
		}
	}
}
