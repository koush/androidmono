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
		internal static global::net.sf.jni4net.jni.MethodId _write12279;
		public virtual long write(java.nio.ByteBuffer[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.nio.channels.SocketChannel._write12279, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._write12279, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write12280;
		public abstract int write(java.nio.ByteBuffer arg0);
		internal static global::net.sf.jni4net.jni.MethodId _write12281;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::net.sf.jni4net.jni.MethodId _read12282;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::net.sf.jni4net.jni.MethodId _read12283;
		public virtual long read(java.nio.ByteBuffer[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.nio.channels.SocketChannel._read12283, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._read12283, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _read12284;
		public abstract int read(java.nio.ByteBuffer arg0);
		internal static global::net.sf.jni4net.jni.MethodId _open12285;
		public static global::java.nio.channels.SocketChannel open(java.net.SocketAddress arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SocketChannel>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._open12285, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _open12286;
		public static global::java.nio.channels.SocketChannel open() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SocketChannel>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._open12286));
		}
		internal static global::net.sf.jni4net.jni.MethodId _connect12287;
		public abstract bool connect(java.net.SocketAddress arg0);
		internal static global::net.sf.jni4net.jni.MethodId _socket12288;
		public abstract global::java.net.Socket socket();
		internal static global::net.sf.jni4net.jni.MethodId _isConnected12289;
		public abstract bool isConnected();
		internal static global::net.sf.jni4net.jni.MethodId _validOps12290;
		public sealed override int validOps() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.channels.SocketChannel._validOps12290);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._validOps12290);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isConnectionPending12291;
		public abstract bool isConnectionPending();
		internal static global::net.sf.jni4net.jni.MethodId _finishConnect12292;
		public abstract bool finishConnect();
		internal static global::net.sf.jni4net.jni.MethodId _SocketChannel12293;
		protected SocketChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.channels.SocketChannel.staticClass, global::java.nio.channels.SocketChannel._SocketChannel12293, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.channels.SocketChannel.staticClass = @__class;
			global::java.nio.channels.SocketChannel._write12279 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.SocketChannel._write12280 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel._write12281 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel._read12282 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.SocketChannel._read12283 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.SocketChannel._read12284 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.SocketChannel._open12285 = @__env.GetStaticMethodID(global::java.nio.channels.SocketChannel.staticClass, "open", "(Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.SocketChannel._open12286 = @__env.GetStaticMethodID(global::java.nio.channels.SocketChannel.staticClass, "open", "()Ljava/nio/channels/SocketChannel;");
			global::java.nio.channels.SocketChannel._connect12287 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "connect", "(Ljava/net/SocketAddress;)Z");
			global::java.nio.channels.SocketChannel._socket12288 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "socket", "()Ljava/net/Socket;");
			global::java.nio.channels.SocketChannel._isConnected12289 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "isConnected", "()Z");
			global::java.nio.channels.SocketChannel._validOps12290 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.SocketChannel._isConnectionPending12291 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "isConnectionPending", "()Z");
			global::java.nio.channels.SocketChannel._finishConnect12292 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "finishConnect", "()Z");
			global::java.nio.channels.SocketChannel._SocketChannel12293 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
		}
	}
}
