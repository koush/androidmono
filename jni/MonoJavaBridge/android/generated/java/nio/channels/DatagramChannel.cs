namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.DatagramChannel_))]
	public abstract partial class DatagramChannel : java.nio.channels.spi.AbstractSelectableChannel, ByteChannel, ScatteringByteChannel, GatheringByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatagramChannel()
		{
			InitJNI();
		}
		protected DatagramChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write16708;
		public virtual long write(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel._write16708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._write16708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write16709;
		public abstract int write(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _write16710;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _send16711;
		public abstract int send(java.nio.ByteBuffer arg0, java.net.SocketAddress arg1);
		internal static global::MonoJavaBridge.MethodId _read16712;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read16713;
		public virtual long read(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel._read16713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._read16713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read16714;
		public abstract int read(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _open16715;
		public static global::java.nio.channels.DatagramChannel open() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._open16715)) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect16716;
		public abstract global::java.nio.channels.DatagramChannel connect(java.net.SocketAddress arg0);
		internal static global::MonoJavaBridge.MethodId _socket16717;
		public abstract global::java.net.DatagramSocket socket();
		internal static global::MonoJavaBridge.MethodId _disconnect16718;
		public abstract global::java.nio.channels.DatagramChannel disconnect();
		internal static global::MonoJavaBridge.MethodId _isConnected16719;
		public abstract bool isConnected();
		internal static global::MonoJavaBridge.MethodId _receive16720;
		public abstract global::java.net.SocketAddress receive(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _validOps16721;
		public sealed override int validOps() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel._validOps16721);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._validOps16721);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramChannel16722;
		protected DatagramChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._DatagramChannel16722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.DatagramChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/DatagramChannel"));
			global::java.nio.channels.DatagramChannel._write16708 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.DatagramChannel._write16709 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.DatagramChannel._write16710 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.DatagramChannel._send16711 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I");
			global::java.nio.channels.DatagramChannel._read16712 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.DatagramChannel._read16713 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.DatagramChannel._read16714 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.DatagramChannel._open16715 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "open", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel._connect16716 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel._socket16717 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "socket", "()Ljava/net/DatagramSocket;");
			global::java.nio.channels.DatagramChannel._disconnect16718 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "disconnect", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel._isConnected16719 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "isConnected", "()Z");
			global::java.nio.channels.DatagramChannel._receive16720 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;");
			global::java.nio.channels.DatagramChannel._validOps16721 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.DatagramChannel._DatagramChannel16722 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.DatagramChannel))]
	public sealed partial class DatagramChannel_ : java.nio.channels.DatagramChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatagramChannel_()
		{
			InitJNI();
		}
		internal DatagramChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write16723;
		public override int write(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._write16723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._write16723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write16724;
		public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._write16724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._write16724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _send16725;
		public override int send(java.nio.ByteBuffer arg0, java.net.SocketAddress arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._send16725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._send16725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _read16726;
		public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._read16726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._read16726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read16727;
		public override int read(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._read16727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._read16727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connect16728;
		public override global::java.nio.channels.DatagramChannel connect(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._connect16728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.DatagramChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._connect16728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _socket16729;
		public override global::java.net.DatagramSocket socket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._socket16729)) as java.net.DatagramSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._socket16729)) as java.net.DatagramSocket;
		}
		internal static global::MonoJavaBridge.MethodId _disconnect16730;
		public override global::java.nio.channels.DatagramChannel disconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._disconnect16730)) as java.nio.channels.DatagramChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._disconnect16730)) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _isConnected16731;
		public override bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._isConnected16731);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._isConnected16731);
		}
		internal static global::MonoJavaBridge.MethodId _receive16732;
		public override global::java.net.SocketAddress receive(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._receive16732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._receive16732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel16733;
		protected override void implCloseSelectableChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._implCloseSelectableChannel16733);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._implCloseSelectableChannel16733);
		}
		internal static global::MonoJavaBridge.MethodId _implConfigureBlocking16734;
		protected override void implConfigureBlocking(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._implConfigureBlocking16734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._implConfigureBlocking16734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.DatagramChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/DatagramChannel"));
			global::java.nio.channels.DatagramChannel_._write16723 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.DatagramChannel_._write16724 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.DatagramChannel_._send16725 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I");
			global::java.nio.channels.DatagramChannel_._read16726 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.DatagramChannel_._read16727 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.DatagramChannel_._connect16728 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel_._socket16729 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "socket", "()Ljava/net/DatagramSocket;");
			global::java.nio.channels.DatagramChannel_._disconnect16730 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "disconnect", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel_._isConnected16731 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "isConnected", "()Z");
			global::java.nio.channels.DatagramChannel_._receive16732 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;");
			global::java.nio.channels.DatagramChannel_._implCloseSelectableChannel16733 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "implCloseSelectableChannel", "()V");
			global::java.nio.channels.DatagramChannel_._implConfigureBlocking16734 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "implConfigureBlocking", "(Z)V");
		}
	}
}
