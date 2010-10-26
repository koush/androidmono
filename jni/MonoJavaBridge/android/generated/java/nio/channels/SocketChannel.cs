namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.SocketChannel_))]
	public abstract partial class SocketChannel : java.nio.channels.spi.AbstractSelectableChannel, ByteChannel, ScatteringByteChannel, GatheringByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketChannel()
		{
			InitJNI();
		}
		protected SocketChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write22628;
		public virtual long write(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel._write22628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._write22628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22629;
		public abstract int write(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _write22630;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read22631;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read22632;
		public virtual long read(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel._read22632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._read22632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read22633;
		public abstract int read(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _open22634;
		public static global::java.nio.channels.SocketChannel open(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._open22634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _open22635;
		public static global::java.nio.channels.SocketChannel open() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._open22635)) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect22636;
		public abstract bool connect(java.net.SocketAddress arg0);
		internal static global::MonoJavaBridge.MethodId _socket22637;
		public abstract global::java.net.Socket socket();
		internal static global::MonoJavaBridge.MethodId _isConnected22638;
		public abstract bool isConnected();
		internal static global::MonoJavaBridge.MethodId _validOps22639;
		public sealed override int validOps() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel._validOps22639);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._validOps22639);
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionPending22640;
		public abstract bool isConnectionPending();
		internal static global::MonoJavaBridge.MethodId _finishConnect22641;
		public abstract bool finishConnect();
		internal static global::MonoJavaBridge.MethodId _SocketChannel22642;
		protected SocketChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._SocketChannel22642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SocketChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SocketChannel"));
			global::java.nio.channels.SocketChannel._write22628 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.SocketChannel._write22629 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel._write22630 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel._read22631 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel._read22632 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.SocketChannel._read22633 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel._open22634 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "open", "(Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.SocketChannel._open22635 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "open", "()Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.SocketChannel._connect22636 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "connect", "(Ljava/net/SocketAddress;)Z");
			global::java.nio.channels.SocketChannel._socket22637 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "socket", "()Ljava/net/Socket;");
			global::java.nio.channels.SocketChannel._isConnected22638 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "isConnected", "()Z");
			global::java.nio.channels.SocketChannel._validOps22639 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.SocketChannel._isConnectionPending22640 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "isConnectionPending", "()Z");
			global::java.nio.channels.SocketChannel._finishConnect22641 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "finishConnect", "()Z");
			global::java.nio.channels.SocketChannel._SocketChannel22642 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.SocketChannel))]
	internal sealed partial class SocketChannel_ : java.nio.channels.SocketChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketChannel_()
		{
			InitJNI();
		}
		internal SocketChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write22643;
		public override int write(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._write22643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._write22643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22644;
		public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._write22644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._write22644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read22645;
		public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._read22645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._read22645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read22646;
		public override int read(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._read22646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._read22646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connect22647;
		public override bool connect(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._connect22647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._connect22647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _socket22648;
		public override global::java.net.Socket socket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._socket22648)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._socket22648)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _isConnected22649;
		public override bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._isConnected22649);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._isConnected22649);
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionPending22650;
		public override bool isConnectionPending() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._isConnectionPending22650);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._isConnectionPending22650);
		}
		internal static global::MonoJavaBridge.MethodId _finishConnect22651;
		public override bool finishConnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._finishConnect22651);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._finishConnect22651);
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel22652;
		protected override void implCloseSelectableChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._implCloseSelectableChannel22652);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._implCloseSelectableChannel22652);
		}
		internal static global::MonoJavaBridge.MethodId _implConfigureBlocking22653;
		protected override void implConfigureBlocking(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._implConfigureBlocking22653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._implConfigureBlocking22653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SocketChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SocketChannel"));
			global::java.nio.channels.SocketChannel_._write22643 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel_._write22644 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel_._read22645 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel_._read22646 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel_._connect22647 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "connect", "(Ljava/net/SocketAddress;)Z");
			global::java.nio.channels.SocketChannel_._socket22648 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "socket", "()Ljava/net/Socket;");
			global::java.nio.channels.SocketChannel_._isConnected22649 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "isConnected", "()Z");
			global::java.nio.channels.SocketChannel_._isConnectionPending22650 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "isConnectionPending", "()Z");
			global::java.nio.channels.SocketChannel_._finishConnect22651 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "finishConnect", "()Z");
			global::java.nio.channels.SocketChannel_._implCloseSelectableChannel22652 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "implCloseSelectableChannel", "()V");
			global::java.nio.channels.SocketChannel_._implConfigureBlocking22653 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "implConfigureBlocking", "(Z)V");
		}
	}
}
