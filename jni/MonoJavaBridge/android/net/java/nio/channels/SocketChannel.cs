namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SocketChannel : java.nio.channels.spi.AbstractSelectableChannel, ByteChannel, ScatteringByteChannel, GatheringByteChannel
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SocketChannel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.SocketChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SocketChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write11419; 
		public virtual long write(java.nio.ByteBuffer[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.SocketChannel)) 
				return @__env.CallLongMethod(this, _write11419, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.nio.channels.SocketChannel.staticClass, _write11419, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write11420; 
		public abstract int write(java.nio.ByteBuffer arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _write11421; 
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _read11422; 
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _read11423; 
		public virtual long read(java.nio.ByteBuffer[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.SocketChannel)) 
				return @__env.CallLongMethod(this, _read11423, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.nio.channels.SocketChannel.staticClass, _read11423, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read11424; 
		public abstract int read(java.nio.ByteBuffer arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _open11425; 
		public static java.nio.channels.SocketChannel open(java.net.SocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SocketChannel>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.SocketChannel.staticClass, _open11425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _open11426; 
		public static java.nio.channels.SocketChannel open() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SocketChannel>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.SocketChannel.staticClass, _open11426)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect11427; 
		public abstract bool connect(java.net.SocketAddress arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _socket11428; 
		public abstract java.net.Socket socket(); 
		internal static global::net.sf.jni4net.jni.MethodId _isConnected11429; 
		public abstract bool isConnected(); 
		internal static global::net.sf.jni4net.jni.MethodId _validOps11430; 
		public sealed override int validOps() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.SocketChannel)) 
				return @__env.CallIntMethod(this, _validOps11430); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.channels.SocketChannel.staticClass, _validOps11430); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isConnectionPending11431; 
		public abstract bool isConnectionPending(); 
		internal static global::net.sf.jni4net.jni.MethodId _finishConnect11432; 
		public abstract bool finishConnect(); 
		internal static global::net.sf.jni4net.jni.MethodId _SocketChannel11433; 
		protected SocketChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.SocketChannel.staticClass, _SocketChannel11433, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.SocketChannel.staticClass = @__class; 
			global::java.nio.channels.SocketChannel._write11419 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J"); 
			global::java.nio.channels.SocketChannel._write11420 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I"); 
			global::java.nio.channels.SocketChannel._write11421 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J"); 
			global::java.nio.channels.SocketChannel._read11422 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J"); 
			global::java.nio.channels.SocketChannel._read11423 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J"); 
			global::java.nio.channels.SocketChannel._read11424 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I"); 
			global::java.nio.channels.SocketChannel._open11425 = @__env.GetStaticMethodID(global::java.nio.channels.SocketChannel.staticClass, "open", "(Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;"); 
			global::java.nio.channels.SocketChannel._open11426 = @__env.GetStaticMethodID(global::java.nio.channels.SocketChannel.staticClass, "open", "()Ljava/nio/channels/SocketChannel;"); 
			global::java.nio.channels.SocketChannel._connect11427 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "connect", "(Ljava/net/SocketAddress;)Z"); 
			global::java.nio.channels.SocketChannel._socket11428 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "socket", "()Ljava/net/Socket;"); 
			global::java.nio.channels.SocketChannel._isConnected11429 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "isConnected", "()Z"); 
			global::java.nio.channels.SocketChannel._validOps11430 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "validOps", "()I"); 
			global::java.nio.channels.SocketChannel._isConnectionPending11431 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "isConnectionPending", "()Z"); 
			global::java.nio.channels.SocketChannel._finishConnect11432 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "finishConnect", "()Z"); 
			global::java.nio.channels.SocketChannel._SocketChannel11433 = @__env.GetMethodID(global::java.nio.channels.SocketChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V"); 
		} 
	} 
} 
