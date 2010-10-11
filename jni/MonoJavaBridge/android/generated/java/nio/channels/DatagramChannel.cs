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
		internal static global::MonoJavaBridge.MethodId _write14387;
		public virtual long write(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel._write14387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._write14387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write14388;
		public abstract int write(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _write14389;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _send14390;
		public abstract int send(java.nio.ByteBuffer arg0, java.net.SocketAddress arg1);
		internal static global::MonoJavaBridge.MethodId _read14391;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read14392;
		public virtual long read(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel._read14392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._read14392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read14393;
		public abstract int read(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _open14394;
		public static global::java.nio.channels.DatagramChannel open() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._open14394)) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect14395;
		public abstract global::java.nio.channels.DatagramChannel connect(java.net.SocketAddress arg0);
		internal static global::MonoJavaBridge.MethodId _socket14396;
		public abstract global::java.net.DatagramSocket socket();
		internal static global::MonoJavaBridge.MethodId _disconnect14397;
		public abstract global::java.nio.channels.DatagramChannel disconnect();
		internal static global::MonoJavaBridge.MethodId _isConnected14398;
		public abstract bool isConnected();
		internal static global::MonoJavaBridge.MethodId _receive14399;
		public abstract global::java.net.SocketAddress receive(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _validOps14400;
		public sealed override int validOps() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel._validOps14400);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._validOps14400);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramChannel14401;
		protected DatagramChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._DatagramChannel14401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.DatagramChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/DatagramChannel"));
			global::java.nio.channels.DatagramChannel._write14387 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.DatagramChannel._write14388 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.DatagramChannel._write14389 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.DatagramChannel._send14390 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I");
			global::java.nio.channels.DatagramChannel._read14391 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.DatagramChannel._read14392 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.DatagramChannel._read14393 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.DatagramChannel._open14394 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "open", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel._connect14395 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel._socket14396 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "socket", "()Ljava/net/DatagramSocket;");
			global::java.nio.channels.DatagramChannel._disconnect14397 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "disconnect", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel._isConnected14398 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "isConnected", "()Z");
			global::java.nio.channels.DatagramChannel._receive14399 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;");
			global::java.nio.channels.DatagramChannel._validOps14400 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.DatagramChannel._DatagramChannel14401 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
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
		internal static global::MonoJavaBridge.MethodId _write14402;
		public override int write(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._write14402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._write14402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write14403;
		public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._write14403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._write14403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _send14404;
		public override int send(java.nio.ByteBuffer arg0, java.net.SocketAddress arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._send14404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._send14404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _read14405;
		public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._read14405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._read14405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read14406;
		public override int read(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._read14406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._read14406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connect14407;
		public override global::java.nio.channels.DatagramChannel connect(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._connect14407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.DatagramChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._connect14407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _socket14408;
		public override global::java.net.DatagramSocket socket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._socket14408)) as java.net.DatagramSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._socket14408)) as java.net.DatagramSocket;
		}
		internal static global::MonoJavaBridge.MethodId _disconnect14409;
		public override global::java.nio.channels.DatagramChannel disconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._disconnect14409)) as java.nio.channels.DatagramChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._disconnect14409)) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _isConnected14410;
		public override bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._isConnected14410);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._isConnected14410);
		}
		internal static global::MonoJavaBridge.MethodId _receive14411;
		public override global::java.net.SocketAddress receive(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._receive14411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._receive14411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel14412;
		protected override void implCloseSelectableChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._implCloseSelectableChannel14412);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._implCloseSelectableChannel14412);
		}
		internal static global::MonoJavaBridge.MethodId _implConfigureBlocking14413;
		protected override void implConfigureBlocking(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_._implConfigureBlocking14413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.DatagramChannel_.staticClass, global::java.nio.channels.DatagramChannel_._implConfigureBlocking14413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.DatagramChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/DatagramChannel"));
			global::java.nio.channels.DatagramChannel_._write14402 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.DatagramChannel_._write14403 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.DatagramChannel_._send14404 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I");
			global::java.nio.channels.DatagramChannel_._read14405 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.DatagramChannel_._read14406 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.DatagramChannel_._connect14407 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel_._socket14408 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "socket", "()Ljava/net/DatagramSocket;");
			global::java.nio.channels.DatagramChannel_._disconnect14409 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "disconnect", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel_._isConnected14410 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "isConnected", "()Z");
			global::java.nio.channels.DatagramChannel_._receive14411 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;");
			global::java.nio.channels.DatagramChannel_._implCloseSelectableChannel14412 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "implCloseSelectableChannel", "()V");
			global::java.nio.channels.DatagramChannel_._implConfigureBlocking14413 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel_.staticClass, "implConfigureBlocking", "(Z)V");
		}
	}
}
