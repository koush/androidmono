namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.SocketChannel_))]
	public abstract partial class SocketChannel : java.nio.channels.spi.AbstractSelectableChannel, ByteChannel, ScatteringByteChannel, GatheringByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SocketChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write22629;
		public virtual long write(java.nio.ByteBuffer[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel._write22629.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel._write22629 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._write22629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22630;
		public abstract int write(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _write22631;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read22632;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read22633;
		public virtual long read(java.nio.ByteBuffer[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel._read22633.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel._read22633 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._read22633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read22634;
		public abstract int read(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _open22635;
		public static global::java.nio.channels.SocketChannel open(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel._open22635.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel._open22635 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "open", "(Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._open22635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _open22636;
		public static global::java.nio.channels.SocketChannel open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel._open22636.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel._open22636 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "open", "()Ljava/nio/channels/SocketChannel;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._open22636)) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect22637;
		public abstract bool connect(java.net.SocketAddress arg0);
		internal static global::MonoJavaBridge.MethodId _socket22638;
		public abstract global::java.net.Socket socket();
		internal static global::MonoJavaBridge.MethodId _isConnected22639;
		public abstract bool isConnected();
		internal static global::MonoJavaBridge.MethodId _validOps22640;
		public sealed override int validOps()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel._validOps22640.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel._validOps22640 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "validOps", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._validOps22640);
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionPending22641;
		public abstract bool isConnectionPending();
		internal static global::MonoJavaBridge.MethodId _finishConnect22642;
		public abstract bool finishConnect();
		internal static global::MonoJavaBridge.MethodId _SocketChannel22643;
		protected SocketChannel(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel._SocketChannel22643.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel._SocketChannel22643 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._SocketChannel22643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SocketChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SocketChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SocketChannel"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.SocketChannel))]
	internal sealed partial class SocketChannel_ : java.nio.channels.SocketChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SocketChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write22644;
		public override int write(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel_._write22644.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel_._write22644 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._write22644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22645;
		public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel_._write22645.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel_._write22645 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._write22645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read22646;
		public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel_._read22646.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel_._read22646 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._read22646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read22647;
		public override int read(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel_._read22647.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel_._read22647 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._read22647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connect22648;
		public override bool connect(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel_._connect22648.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel_._connect22648 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "connect", "(Ljava/net/SocketAddress;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._connect22648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _socket22649;
		public override global::java.net.Socket socket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel_._socket22649.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel_._socket22649 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "socket", "()Ljava/net/Socket;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._socket22649)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _isConnected22650;
		public override bool isConnected()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel_._isConnected22650.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel_._isConnected22650 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "isConnected", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._isConnected22650);
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionPending22651;
		public override bool isConnectionPending()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel_._isConnectionPending22651.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel_._isConnectionPending22651 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "isConnectionPending", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._isConnectionPending22651);
		}
		internal static global::MonoJavaBridge.MethodId _finishConnect22652;
		public override bool finishConnect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel_._finishConnect22652.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel_._finishConnect22652 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "finishConnect", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._finishConnect22652);
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel22653;
		protected override void implCloseSelectableChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel_._implCloseSelectableChannel22653.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel_._implCloseSelectableChannel22653 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "implCloseSelectableChannel", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._implCloseSelectableChannel22653);
		}
		internal static global::MonoJavaBridge.MethodId _implConfigureBlocking22654;
		protected override void implConfigureBlocking(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel_._implConfigureBlocking22654.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel_._implConfigureBlocking22654 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "implConfigureBlocking", "(Z)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._implConfigureBlocking22654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SocketChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SocketChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SocketChannel"));
		}
		internal static void InitJNI()
		{
		}
	}
}
