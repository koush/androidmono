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
		internal static global::MonoJavaBridge.MethodId _write22510;
		public virtual long write(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel._write22510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._write22510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22511;
		public abstract int write(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _write22512;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read22513;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read22514;
		public virtual long read(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel._read22514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._read22514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read22515;
		public abstract int read(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _open22516;
		public static global::java.nio.channels.SocketChannel open(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._open22516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _open22517;
		public static global::java.nio.channels.SocketChannel open() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._open22517)) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect22518;
		public abstract bool connect(java.net.SocketAddress arg0);
		internal static global::MonoJavaBridge.MethodId _socket22519;
		public abstract global::java.net.Socket socket();
		internal static global::MonoJavaBridge.MethodId _isConnected22520;
		public abstract bool isConnected();
		internal static global::MonoJavaBridge.MethodId _validOps22521;
		public sealed override int validOps() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel._validOps22521);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._validOps22521);
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionPending22522;
		public abstract bool isConnectionPending();
		internal static global::MonoJavaBridge.MethodId _finishConnect22523;
		public abstract bool finishConnect();
		internal static global::MonoJavaBridge.MethodId _SocketChannel22524;
		protected SocketChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._SocketChannel22524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SocketChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SocketChannel"));
			global::java.nio.channels.SocketChannel._write22510 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.SocketChannel._write22511 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel._write22512 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel._read22513 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel._read22514 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.SocketChannel._read22515 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel._open22516 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "open", "(Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.SocketChannel._open22517 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "open", "()Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.SocketChannel._connect22518 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "connect", "(Ljava/net/SocketAddress;)Z");
			global::java.nio.channels.SocketChannel._socket22519 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "socket", "()Ljava/net/Socket;");
			global::java.nio.channels.SocketChannel._isConnected22520 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "isConnected", "()Z");
			global::java.nio.channels.SocketChannel._validOps22521 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.SocketChannel._isConnectionPending22522 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "isConnectionPending", "()Z");
			global::java.nio.channels.SocketChannel._finishConnect22523 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "finishConnect", "()Z");
			global::java.nio.channels.SocketChannel._SocketChannel22524 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.SocketChannel))]
	public sealed partial class SocketChannel_ : java.nio.channels.SocketChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketChannel_()
		{
			InitJNI();
		}
		internal SocketChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write22525;
		public override int write(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._write22525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._write22525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22526;
		public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._write22526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._write22526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read22527;
		public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._read22527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._read22527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read22528;
		public override int read(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._read22528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._read22528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connect22529;
		public override bool connect(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._connect22529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._connect22529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _socket22530;
		public override global::java.net.Socket socket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._socket22530)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._socket22530)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _isConnected22531;
		public override bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._isConnected22531);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._isConnected22531);
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionPending22532;
		public override bool isConnectionPending() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._isConnectionPending22532);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._isConnectionPending22532);
		}
		internal static global::MonoJavaBridge.MethodId _finishConnect22533;
		public override bool finishConnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._finishConnect22533);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._finishConnect22533);
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel22534;
		protected override void implCloseSelectableChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._implCloseSelectableChannel22534);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._implCloseSelectableChannel22534);
		}
		internal static global::MonoJavaBridge.MethodId _implConfigureBlocking22535;
		protected override void implConfigureBlocking(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._implConfigureBlocking22535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._implConfigureBlocking22535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SocketChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SocketChannel"));
			global::java.nio.channels.SocketChannel_._write22525 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel_._write22526 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel_._read22527 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel_._read22528 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel_._connect22529 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "connect", "(Ljava/net/SocketAddress;)Z");
			global::java.nio.channels.SocketChannel_._socket22530 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "socket", "()Ljava/net/Socket;");
			global::java.nio.channels.SocketChannel_._isConnected22531 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "isConnected", "()Z");
			global::java.nio.channels.SocketChannel_._isConnectionPending22532 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "isConnectionPending", "()Z");
			global::java.nio.channels.SocketChannel_._finishConnect22533 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "finishConnect", "()Z");
			global::java.nio.channels.SocketChannel_._implCloseSelectableChannel22534 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "implCloseSelectableChannel", "()V");
			global::java.nio.channels.SocketChannel_._implConfigureBlocking22535 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "implConfigureBlocking", "(Z)V");
		}
	}
}
