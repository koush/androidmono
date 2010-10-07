namespace java.nio.channels
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class SocketChannel : java.nio.channels.spi.AbstractSelectableChannel, ByteChannel, ScatteringByteChannel, GatheringByteChannel
	{
		internal new static global::java.lang.Class staticClass;
		static SocketChannel()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.SocketChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected SocketChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _write13008;
		public virtual long write(java.nio.ByteBuffer[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.nio.channels.SocketChannel._write13008, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._write13008, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write13009;
		public abstract int write(java.nio.ByteBuffer arg0);
		internal static global::net.sf.jni4net.jni.MethodId _write13010;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::net.sf.jni4net.jni.MethodId _read13011;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::net.sf.jni4net.jni.MethodId _read13012;
		public virtual long read(java.nio.ByteBuffer[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.nio.channels.SocketChannel._read13012, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._read13012, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _read13013;
		public abstract int read(java.nio.ByteBuffer arg0);
		internal static global::net.sf.jni4net.jni.MethodId _open13014;
		public static global::java.nio.channels.SocketChannel open(java.net.SocketAddress arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SocketChannel>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._open13014, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _open13015;
		public static global::java.nio.channels.SocketChannel open() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SocketChannel>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._open13015));
		}
		internal static global::net.sf.jni4net.jni.MethodId _connect13016;
		public abstract bool connect(java.net.SocketAddress arg0);
		internal static global::net.sf.jni4net.jni.MethodId _socket13017;
		public abstract global::java.net.Socket socket();
		internal static global::net.sf.jni4net.jni.MethodId _isConnected13018;
		public abstract bool isConnected();
		internal static global::net.sf.jni4net.jni.MethodId _validOps13019;
		public sealed override int validOps() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.channels.SocketChannel._validOps13019);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._validOps13019);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isConnectionPending13020;
		public abstract bool isConnectionPending();
		internal static global::net.sf.jni4net.jni.MethodId _finishConnect13021;
		public abstract bool finishConnect();
		internal static global::net.sf.jni4net.jni.MethodId _SocketChannel13022;
		protected SocketChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._SocketChannel13022, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.channels.SocketChannel.staticClass = @__class;
			global::java.nio.channels.SocketChannel._write13008 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.SocketChannel._write13009 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel._write13010 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel._read13011 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel._read13012 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.SocketChannel._read13013 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel._open13014 = @__env.GetStaticMethodID(global::java.nio.channels.SocketChannel.staticClass, "open", "(Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.SocketChannel._open13015 = @__env.GetStaticMethodID(global::java.nio.channels.SocketChannel.staticClass, "open", "()Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.SocketChannel._connect13016 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "connect", "(Ljava/net/SocketAddress;)Z");
			global::java.nio.channels.SocketChannel._socket13017 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "socket", "()Ljava/net/Socket;");
			global::java.nio.channels.SocketChannel._isConnected13018 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "isConnected", "()Z");
			global::java.nio.channels.SocketChannel._validOps13019 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.SocketChannel._isConnectionPending13020 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "isConnectionPending", "()Z");
			global::java.nio.channels.SocketChannel._finishConnect13021 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "finishConnect", "()Z");
			global::java.nio.channels.SocketChannel._SocketChannel13022 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
		}
	}
}
