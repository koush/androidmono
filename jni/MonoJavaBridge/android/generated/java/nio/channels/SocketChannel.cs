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
		internal static global::MonoJavaBridge.MethodId _write16912;
		public virtual long write(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel._write16912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._write16912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write16913;
		public abstract int write(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _write16914;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read16915;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read16916;
		public virtual long read(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel._read16916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._read16916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read16917;
		public abstract int read(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _open16918;
		public static global::java.nio.channels.SocketChannel open(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._open16918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _open16919;
		public static global::java.nio.channels.SocketChannel open() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._open16919)) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect16920;
		public abstract bool connect(java.net.SocketAddress arg0);
		internal static global::MonoJavaBridge.MethodId _socket16921;
		public abstract global::java.net.Socket socket();
		internal static global::MonoJavaBridge.MethodId _isConnected16922;
		public abstract bool isConnected();
		internal static global::MonoJavaBridge.MethodId _validOps16923;
		public sealed override int validOps() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel._validOps16923);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._validOps16923);
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionPending16924;
		public abstract bool isConnectionPending();
		internal static global::MonoJavaBridge.MethodId _finishConnect16925;
		public abstract bool finishConnect();
		internal static global::MonoJavaBridge.MethodId _SocketChannel16926;
		protected SocketChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._SocketChannel16926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SocketChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SocketChannel"));
			global::java.nio.channels.SocketChannel._write16912 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.SocketChannel._write16913 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel._write16914 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel._read16915 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel._read16916 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.SocketChannel._read16917 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel._open16918 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "open", "(Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.SocketChannel._open16919 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "open", "()Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.SocketChannel._connect16920 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "connect", "(Ljava/net/SocketAddress;)Z");
			global::java.nio.channels.SocketChannel._socket16921 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "socket", "()Ljava/net/Socket;");
			global::java.nio.channels.SocketChannel._isConnected16922 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "isConnected", "()Z");
			global::java.nio.channels.SocketChannel._validOps16923 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.SocketChannel._isConnectionPending16924 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "isConnectionPending", "()Z");
			global::java.nio.channels.SocketChannel._finishConnect16925 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "finishConnect", "()Z");
			global::java.nio.channels.SocketChannel._SocketChannel16926 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
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
		internal static global::MonoJavaBridge.MethodId _write16927;
		public override int write(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._write16927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._write16927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write16928;
		public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._write16928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._write16928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read16929;
		public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._read16929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._read16929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read16930;
		public override int read(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._read16930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._read16930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connect16931;
		public override bool connect(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._connect16931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._connect16931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _socket16932;
		public override global::java.net.Socket socket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._socket16932)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._socket16932)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _isConnected16933;
		public override bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._isConnected16933);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._isConnected16933);
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionPending16934;
		public override bool isConnectionPending() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._isConnectionPending16934);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._isConnectionPending16934);
		}
		internal static global::MonoJavaBridge.MethodId _finishConnect16935;
		public override bool finishConnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._finishConnect16935);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._finishConnect16935);
		}
		internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel16936;
		protected override void implCloseSelectableChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._implCloseSelectableChannel16936);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._implCloseSelectableChannel16936);
		}
		internal static global::MonoJavaBridge.MethodId _implConfigureBlocking16937;
		protected override void implConfigureBlocking(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_._implConfigureBlocking16937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.SocketChannel_.staticClass, global::java.nio.channels.SocketChannel_._implConfigureBlocking16937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SocketChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SocketChannel"));
			global::java.nio.channels.SocketChannel_._write16927 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel_._write16928 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel_._read16929 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel_._read16930 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel_._connect16931 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "connect", "(Ljava/net/SocketAddress;)Z");
			global::java.nio.channels.SocketChannel_._socket16932 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "socket", "()Ljava/net/Socket;");
			global::java.nio.channels.SocketChannel_._isConnected16933 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "isConnected", "()Z");
			global::java.nio.channels.SocketChannel_._isConnectionPending16934 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "isConnectionPending", "()Z");
			global::java.nio.channels.SocketChannel_._finishConnect16935 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "finishConnect", "()Z");
			global::java.nio.channels.SocketChannel_._implCloseSelectableChannel16936 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "implCloseSelectableChannel", "()V");
			global::java.nio.channels.SocketChannel_._implConfigureBlocking16937 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel_.staticClass, "implConfigureBlocking", "(Z)V");
		}
	}
}
