namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.SocketChannel_))]
	public abstract partial class SocketChannel : java.nio.channels.spi.AbstractSelectableChannel, ByteChannel, ScatteringByteChannel, GatheringByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SocketChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual long write(java.nio.ByteBuffer[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.SocketChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J", ref global::java.nio.channels.SocketChannel._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract int write(java.nio.ByteBuffer arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual long read(java.nio.ByteBuffer[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.SocketChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J", ref global::java.nio.channels.SocketChannel._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract int read(java.nio.ByteBuffer arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.nio.channels.SocketChannel open(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel._m6.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel._m6 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "open", "(Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SocketChannel;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.nio.channels.SocketChannel open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel._m7.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel._m7 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "open", "()Ljava/nio/channels/SocketChannel;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._m7)) as java.nio.channels.SocketChannel;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract bool connect(java.net.SocketAddress arg0);
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract global::java.net.Socket socket();
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract bool isConnected();
		private static global::MonoJavaBridge.MethodId _m11;
		public sealed override int validOps()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.SocketChannel.staticClass, "validOps", "()I", ref global::java.nio.channels.SocketChannel._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract bool isConnectionPending();
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract bool finishConnect();
		private static global::MonoJavaBridge.MethodId _m14;
		protected SocketChannel(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SocketChannel._m14.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SocketChannel._m14 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SocketChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SocketChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SocketChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SocketChannel"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.SocketChannel))]
	internal sealed partial class SocketChannel_ : java.nio.channels.SocketChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SocketChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int write(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.SocketChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.SocketChannel_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.SocketChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J", ref global::java.nio.channels.SocketChannel_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.SocketChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J", ref global::java.nio.channels.SocketChannel_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int read(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.SocketChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.SocketChannel_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool connect(java.net.SocketAddress arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SocketChannel_.staticClass, "connect", "(Ljava/net/SocketAddress;)Z", ref global::java.nio.channels.SocketChannel_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.net.Socket socket()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SocketChannel_.staticClass, "socket", "()Ljava/net/Socket;", ref global::java.nio.channels.SocketChannel_._m5) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool isConnected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SocketChannel_.staticClass, "isConnected", "()Z", ref global::java.nio.channels.SocketChannel_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool isConnectionPending()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SocketChannel_.staticClass, "isConnectionPending", "()Z", ref global::java.nio.channels.SocketChannel_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool finishConnect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SocketChannel_.staticClass, "finishConnect", "()Z", ref global::java.nio.channels.SocketChannel_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override void implCloseSelectableChannel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.SocketChannel_.staticClass, "implCloseSelectableChannel", "()V", ref global::java.nio.channels.SocketChannel_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override void implConfigureBlocking(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.SocketChannel_.staticClass, "implConfigureBlocking", "(Z)V", ref global::java.nio.channels.SocketChannel_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SocketChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SocketChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SocketChannel"));
		}
	}
}
