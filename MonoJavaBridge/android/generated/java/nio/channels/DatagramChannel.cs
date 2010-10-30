namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.DatagramChannel_))]
	public abstract partial class DatagramChannel : java.nio.channels.spi.AbstractSelectableChannel, ByteChannel, ScatteringByteChannel, GatheringByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DatagramChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual long write(java.nio.ByteBuffer[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.DatagramChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J", ref global::java.nio.channels.DatagramChannel._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract int write(java.nio.ByteBuffer arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract int send(java.nio.ByteBuffer arg0, java.net.SocketAddress arg1);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual long read(java.nio.ByteBuffer[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.DatagramChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J", ref global::java.nio.channels.DatagramChannel._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract int read(java.nio.ByteBuffer arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.nio.channels.DatagramChannel open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.DatagramChannel._m7.native == global::System.IntPtr.Zero)
				global::java.nio.channels.DatagramChannel._m7 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "open", "()Ljava/nio/channels/DatagramChannel;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._m7)) as java.nio.channels.DatagramChannel;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::java.nio.channels.DatagramChannel connect(java.net.SocketAddress arg0);
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract global::java.net.DatagramSocket socket();
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract global::java.nio.channels.DatagramChannel disconnect();
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract bool isConnected();
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract global::java.net.SocketAddress receive(java.nio.ByteBuffer arg0);
		private static global::MonoJavaBridge.MethodId _m13;
		public sealed override int validOps()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.DatagramChannel.staticClass, "validOps", "()I", ref global::java.nio.channels.DatagramChannel._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected DatagramChannel(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.DatagramChannel._m14.native == global::System.IntPtr.Zero)
				global::java.nio.channels.DatagramChannel._m14 = @__env.GetMethodIDNoThrow(global::java.nio.channels.DatagramChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DatagramChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.DatagramChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/DatagramChannel"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.DatagramChannel))]
	internal sealed partial class DatagramChannel_ : java.nio.channels.DatagramChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DatagramChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int write(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.DatagramChannel_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J", ref global::java.nio.channels.DatagramChannel_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int send(java.nio.ByteBuffer arg0, java.net.SocketAddress arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I", ref global::java.nio.channels.DatagramChannel_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J", ref global::java.nio.channels.DatagramChannel_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int read(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.DatagramChannel_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.nio.channels.DatagramChannel connect(java.net.SocketAddress arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;", ref global::java.nio.channels.DatagramChannel_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.channels.DatagramChannel;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.net.DatagramSocket socket()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "socket", "()Ljava/net/DatagramSocket;", ref global::java.nio.channels.DatagramChannel_._m6) as java.net.DatagramSocket;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.nio.channels.DatagramChannel disconnect()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "disconnect", "()Ljava/nio/channels/DatagramChannel;", ref global::java.nio.channels.DatagramChannel_._m7) as java.nio.channels.DatagramChannel;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool isConnected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "isConnected", "()Z", ref global::java.nio.channels.DatagramChannel_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.net.SocketAddress receive(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;", ref global::java.nio.channels.DatagramChannel_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.SocketAddress;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override void implCloseSelectableChannel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "implCloseSelectableChannel", "()V", ref global::java.nio.channels.DatagramChannel_._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected override void implConfigureBlocking(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.DatagramChannel_.staticClass, "implConfigureBlocking", "(Z)V", ref global::java.nio.channels.DatagramChannel_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static DatagramChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.DatagramChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/DatagramChannel"));
		}
		internal static void InitJNI()
		{
		}
	}
}
