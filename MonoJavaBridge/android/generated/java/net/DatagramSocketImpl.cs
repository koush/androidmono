namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.DatagramSocketImpl_))]
	public abstract partial class DatagramSocketImpl : java.lang.Object, SocketOptions
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DatagramSocketImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.Object getOption(int arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void setOption(int arg0, java.lang.Object arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		protected abstract void join(java.net.InetAddress arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		protected abstract void close();
		private static global::MonoJavaBridge.MethodId _m4;
		protected abstract int peek(java.net.InetAddress arg0);
		private static global::MonoJavaBridge.MethodId _m5;
		protected abstract void send(java.net.DatagramPacket arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		protected abstract void create();
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual void connect(java.net.InetAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl.staticClass, "connect", "(Ljava/net/InetAddress;I)V", ref global::java.net.DatagramSocketImpl._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected abstract int peekData(java.net.DatagramPacket arg0);
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual global::java.io.FileDescriptor getFileDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.io.FileDescriptor>(this, global::java.net.DatagramSocketImpl.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;", ref global::java.net.DatagramSocketImpl._m9) as java.io.FileDescriptor;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected abstract void bind(int arg0, java.net.InetAddress arg1);
		private static global::MonoJavaBridge.MethodId _m11;
		protected virtual void disconnect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl.staticClass, "disconnect", "()V", ref global::java.net.DatagramSocketImpl._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected virtual int getLocalPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocketImpl.staticClass, "getLocalPort", "()I", ref global::java.net.DatagramSocketImpl._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected abstract void receive(java.net.DatagramPacket arg0);
		private static global::MonoJavaBridge.MethodId _m14;
		protected abstract void setTTL(byte arg0);
		private static global::MonoJavaBridge.MethodId _m15;
		protected abstract byte getTTL();
		private static global::MonoJavaBridge.MethodId _m16;
		protected abstract void setTimeToLive(int arg0);
		private static global::MonoJavaBridge.MethodId _m17;
		protected abstract int getTimeToLive();
		private static global::MonoJavaBridge.MethodId _m18;
		protected abstract void leave(java.net.InetAddress arg0);
		private static global::MonoJavaBridge.MethodId _m19;
		protected abstract void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1);
		private static global::MonoJavaBridge.MethodId _m20;
		protected abstract void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1);
		private static global::MonoJavaBridge.MethodId _m21;
		public DatagramSocketImpl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramSocketImpl._m21.native == global::System.IntPtr.Zero)
				global::java.net.DatagramSocketImpl._m21 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocketImpl.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._m21);
			Init(@__env, handle);
		}
		static DatagramSocketImpl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocketImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocketImpl"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.DatagramSocketImpl))]
	internal sealed partial class DatagramSocketImpl_ : java.net.DatagramSocketImpl
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DatagramSocketImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object getOption(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "getOption", "(I)Ljava/lang/Object;", ref global::java.net.DatagramSocketImpl_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void setOption(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "setOption", "(ILjava/lang/Object;)V", ref global::java.net.DatagramSocketImpl_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void join(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "join", "(Ljava/net/InetAddress;)V", ref global::java.net.DatagramSocketImpl_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "close", "()V", ref global::java.net.DatagramSocketImpl_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override int peek(java.net.InetAddress arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "peek", "(Ljava/net/InetAddress;)I", ref global::java.net.DatagramSocketImpl_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void send(java.net.DatagramPacket arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "send", "(Ljava/net/DatagramPacket;)V", ref global::java.net.DatagramSocketImpl_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override void create()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "create", "()V", ref global::java.net.DatagramSocketImpl_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override int peekData(java.net.DatagramPacket arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "peekData", "(Ljava/net/DatagramPacket;)I", ref global::java.net.DatagramSocketImpl_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override void bind(int arg0, java.net.InetAddress arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "bind", "(ILjava/net/InetAddress;)V", ref global::java.net.DatagramSocketImpl_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override void receive(java.net.DatagramPacket arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "receive", "(Ljava/net/DatagramPacket;)V", ref global::java.net.DatagramSocketImpl_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override void setTTL(byte arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "setTTL", "(B)V", ref global::java.net.DatagramSocketImpl_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected override byte getTTL()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "getTTL", "()B", ref global::java.net.DatagramSocketImpl_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected override void setTimeToLive(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "setTimeToLive", "(I)V", ref global::java.net.DatagramSocketImpl_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected override int getTimeToLive()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "getTimeToLive", "()I", ref global::java.net.DatagramSocketImpl_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected override void leave(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "leave", "(Ljava/net/InetAddress;)V", ref global::java.net.DatagramSocketImpl_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected override void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", ref global::java.net.DatagramSocketImpl_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected override void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramSocketImpl_.staticClass, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", ref global::java.net.DatagramSocketImpl_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static DatagramSocketImpl_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocketImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocketImpl"));
		}
		internal static void InitJNI()
		{
		}
	}
}
