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
		internal static global::MonoJavaBridge.MethodId _write22420;
		public virtual long write(java.nio.ByteBuffer[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel._write22420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._write22420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22421;
		public abstract int write(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _write22422;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _send22423;
		public abstract int send(java.nio.ByteBuffer arg0, java.net.SocketAddress arg1);
		internal static global::MonoJavaBridge.MethodId _read22424;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read22425;
		public virtual long read(java.nio.ByteBuffer[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel._read22425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._read22425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read22426;
		public abstract int read(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _open22427;
		public static global::java.nio.channels.DatagramChannel open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._open22427)) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect22428;
		public abstract global::java.nio.channels.DatagramChannel connect(java.net.SocketAddress arg0);
		internal static global::MonoJavaBridge.MethodId _socket22429;
		public abstract global::java.net.DatagramSocket socket();
		internal static global::MonoJavaBridge.MethodId _disconnect22430;
		public abstract global::java.nio.channels.DatagramChannel disconnect();
		internal static global::MonoJavaBridge.MethodId _isConnected22431;
		public abstract bool isConnected();
		internal static global::MonoJavaBridge.MethodId _receive22432;
		public abstract global::java.net.SocketAddress receive(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _validOps22433;
		public sealed override int validOps()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel._validOps22433);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._validOps22433);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramChannel22434;
		protected DatagramChannel(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._DatagramChannel22434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.DatagramChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/DatagramChannel"));
			global::java.nio.channels.DatagramChannel._write22420 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.DatagramChannel._write22421 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.DatagramChannel._write22422 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.DatagramChannel._send22423 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I");
			global::java.nio.channels.DatagramChannel._read22424 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.DatagramChannel._read22425 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.DatagramChannel._read22426 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.DatagramChannel._open22427 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "open", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel._connect22428 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel._socket22429 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "socket", "()Ljava/net/DatagramSocket;");
			global::java.nio.channels.DatagramChannel._disconnect22430 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "disconnect", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel._isConnected22431 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "isConnected", "()Z");
			global::java.nio.channels.DatagramChannel._receive22432 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;");
			global::java.nio.channels.DatagramChannel._validOps22433 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.DatagramChannel._DatagramChannel22434 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.DatagramChannel))]
	internal sealed partial class DatagramChannel_ : java.nio.channels.DatagramChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatagramChannel_()
		{
			InitJNI();
		}
		internal DatagramChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write22435;
		public override int write(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._write22435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._write22435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22436;
		public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._write22436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._write22436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _send22437;
		public override int send(java.nio.ByteBuffer arg0, java.net.SocketAddress arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._send22437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._send22437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _read22438;
		public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._read22438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._read22438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read22439;
		public override int read(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._read22439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._read22439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connect22440;
		public override global::java.nio.channels.DatagramChannel connect(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._connect22440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.DatagramChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._connect22440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _socket22441;
		public override global::java.net.DatagramSocket socket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._socket22441)) as java.net.DatagramSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._socket22441)) as java.net.DatagramSocket;
		}
		internal static global::MonoJavaBridge.MethodId _disconnect22442;
		public override global::java.nio.channels.DatagramChannel disconnect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._disconnect22442)) as java.nio.channels.DatagramChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._disconnect22442)) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _isConnected22443;
		public override bool isConnected()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._isConnected22443);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._isConnected22443);
		}
		internal static global::MonoJavaBridge.MethodId _receive22444;
		public override global::java.net.SocketAddress receive(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._receive22444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._receive22444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel22445;
		protected override void implCloseSelectableChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._implCloseSelectableChannel22445);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._implCloseSelectableChannel22445);
		}
		internal static global::MonoJavaBridge.MethodId _implConfigureBlocking22446;
		protected override void implConfigureBlocking(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._implConfigureBlocking22446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._implConfigureBlocking22446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.DatagramChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/DatagramChannel"));
			global::java.nio.channels.DatagramChannel_._write22435 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.DatagramChannel_._write22436 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.DatagramChannel_._send22437 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I");
			global::java.nio.channels.DatagramChannel_._read22438 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.DatagramChannel_._read22439 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.DatagramChannel_._connect22440 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel_._socket22441 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "socket", "()Ljava/net/DatagramSocket;");
			global::java.nio.channels.DatagramChannel_._disconnect22442 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "disconnect", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel_._isConnected22443 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "isConnected", "()Z");
			global::java.nio.channels.DatagramChannel_._receive22444 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;");
			global::java.nio.channels.DatagramChannel_._implCloseSelectableChannel22445 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "implCloseSelectableChannel", "()V");
			global::java.nio.channels.DatagramChannel_._implConfigureBlocking22446 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "implConfigureBlocking", "(Z)V");
		}
	}
}
