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
		internal static global::MonoJavaBridge.MethodId _getOption15763;
		public abstract global::java.lang.Object getOption(int arg0);
		internal static global::MonoJavaBridge.MethodId _setOption15764;
		public abstract void setOption(int arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _join15765;
		protected abstract void join(java.net.InetAddress arg0);
		internal static global::MonoJavaBridge.MethodId _close15766;
		protected abstract void close();
		internal static global::MonoJavaBridge.MethodId _peek15767;
		protected abstract int peek(java.net.InetAddress arg0);
		internal static global::MonoJavaBridge.MethodId _send15768;
		protected abstract void send(java.net.DatagramPacket arg0);
		internal static global::MonoJavaBridge.MethodId _create15769;
		protected abstract void create();
		internal static global::MonoJavaBridge.MethodId _connect15770;
		protected virtual void connect(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl._connect15770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._connect15770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _peekData15771;
		protected abstract int peekData(java.net.DatagramPacket arg0);
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor15772;
		protected virtual global::java.io.FileDescriptor getFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocketImpl._getFileDescriptor15772)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._getFileDescriptor15772)) as java.io.FileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _bind15773;
		protected abstract void bind(int arg0, java.net.InetAddress arg1);
		internal static global::MonoJavaBridge.MethodId _disconnect15774;
		protected virtual void disconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl._disconnect15774);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._disconnect15774);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort15775;
		protected virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl._getLocalPort15775);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._getLocalPort15775);
		}
		internal static global::MonoJavaBridge.MethodId _receive15776;
		protected abstract void receive(java.net.DatagramPacket arg0);
		internal static global::MonoJavaBridge.MethodId _setTTL15777;
		protected abstract void setTTL(byte arg0);
		internal static global::MonoJavaBridge.MethodId _getTTL15778;
		protected abstract byte getTTL();
		internal static global::MonoJavaBridge.MethodId _setTimeToLive15779;
		protected abstract void setTimeToLive(int arg0);
		internal static global::MonoJavaBridge.MethodId _getTimeToLive15780;
		protected abstract int getTimeToLive();
		internal static global::MonoJavaBridge.MethodId _leave15781;
		protected abstract void leave(java.net.InetAddress arg0);
		internal static global::MonoJavaBridge.MethodId _joinGroup15782;
		protected abstract void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1);
		internal static global::MonoJavaBridge.MethodId _leaveGroup15783;
		protected abstract void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1);
		internal static global::MonoJavaBridge.MethodId _DatagramSocketImpl15784;
		public DatagramSocketImpl()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._DatagramSocketImpl15784);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocketImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocketImpl"));
			global::java.net.DatagramSocketImpl._getOption15763 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getOption", "(I)Ljava/lang/Object;");
			global::java.net.DatagramSocketImpl._setOption15764 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "setOption", "(ILjava/lang/Object;)V");
			global::java.net.DatagramSocketImpl._join15765 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "join", "(Ljava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl._close15766 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "close", "()V");
			global::java.net.DatagramSocketImpl._peek15767 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "peek", "(Ljava/net/InetAddress;)I");
			global::java.net.DatagramSocketImpl._send15768 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "send", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocketImpl._create15769 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "create", "()V");
			global::java.net.DatagramSocketImpl._connect15770 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "connect", "(Ljava/net/InetAddress;I)V");
			global::java.net.DatagramSocketImpl._peekData15771 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "peekData", "(Ljava/net/DatagramPacket;)I");
			global::java.net.DatagramSocketImpl._getFileDescriptor15772 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::java.net.DatagramSocketImpl._bind15773 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "bind", "(ILjava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl._disconnect15774 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "disconnect", "()V");
			global::java.net.DatagramSocketImpl._getLocalPort15775 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getLocalPort", "()I");
			global::java.net.DatagramSocketImpl._receive15776 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "receive", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocketImpl._setTTL15777 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "setTTL", "(B)V");
			global::java.net.DatagramSocketImpl._getTTL15778 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getTTL", "()B");
			global::java.net.DatagramSocketImpl._setTimeToLive15779 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "setTimeToLive", "(I)V");
			global::java.net.DatagramSocketImpl._getTimeToLive15780 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "getTimeToLive", "()I");
			global::java.net.DatagramSocketImpl._leave15781 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "leave", "(Ljava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl._joinGroup15782 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::java.net.DatagramSocketImpl._leaveGroup15783 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::java.net.DatagramSocketImpl._DatagramSocketImpl15784 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _getOption15785;
		public override global::java.lang.Object getOption(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._getOption15785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._getOption15785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setOption15786;
		public override void setOption(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._setOption15786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._setOption15786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _join15787;
		protected override void join(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._join15787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._join15787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close15788;
		protected override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._close15788);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._close15788);
		}
		internal static global::MonoJavaBridge.MethodId _peek15789;
		protected override int peek(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._peek15789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._peek15789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _send15790;
		protected override void send(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._send15790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._send15790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _create15791;
		protected override void create() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._create15791);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._create15791);
		}
		internal static global::MonoJavaBridge.MethodId _peekData15792;
		protected override int peekData(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._peekData15792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._peekData15792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bind15793;
		protected override void bind(int arg0, java.net.InetAddress arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._bind15793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._bind15793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _receive15794;
		protected override void receive(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._receive15794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._receive15794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTTL15795;
		protected override void setTTL(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._setTTL15795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._setTTL15795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTTL15796;
		protected override byte getTTL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._getTTL15796);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._getTTL15796);
		}
		internal static global::MonoJavaBridge.MethodId _setTimeToLive15797;
		protected override void setTimeToLive(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._setTimeToLive15797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._setTimeToLive15797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeToLive15798;
		protected override int getTimeToLive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._getTimeToLive15798);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._getTimeToLive15798);
		}
		internal static global::MonoJavaBridge.MethodId _leave15799;
		protected override void leave(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._leave15799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._leave15799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _joinGroup15800;
		protected override void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._joinGroup15800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._joinGroup15800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _leaveGroup15801;
		protected override void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_._leaveGroup15801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocketImpl_.staticClass, global::java.net.DatagramSocketImpl_._leaveGroup15801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocketImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocketImpl"));
			global::java.net.DatagramSocketImpl_._getOption15785 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "getOption", "(I)Ljava/lang/Object;");
			global::java.net.DatagramSocketImpl_._setOption15786 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "setOption", "(ILjava/lang/Object;)V");
			global::java.net.DatagramSocketImpl_._join15787 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "join", "(Ljava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl_._close15788 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "close", "()V");
			global::java.net.DatagramSocketImpl_._peek15789 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "peek", "(Ljava/net/InetAddress;)I");
			global::java.net.DatagramSocketImpl_._send15790 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "send", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocketImpl_._create15791 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "create", "()V");
			global::java.net.DatagramSocketImpl_._peekData15792 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "peekData", "(Ljava/net/DatagramPacket;)I");
			global::java.net.DatagramSocketImpl_._bind15793 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "bind", "(ILjava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl_._receive15794 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "receive", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocketImpl_._setTTL15795 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "setTTL", "(B)V");
			global::java.net.DatagramSocketImpl_._getTTL15796 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "getTTL", "()B");
			global::java.net.DatagramSocketImpl_._setTimeToLive15797 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "setTimeToLive", "(I)V");
			global::java.net.DatagramSocketImpl_._getTimeToLive15798 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "getTimeToLive", "()I");
			global::java.net.DatagramSocketImpl_._leave15799 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "leave", "(Ljava/net/InetAddress;)V");
			global::java.net.DatagramSocketImpl_._joinGroup15800 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::java.net.DatagramSocketImpl_._leaveGroup15801 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl_.staticClass, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
		}
	}
}
