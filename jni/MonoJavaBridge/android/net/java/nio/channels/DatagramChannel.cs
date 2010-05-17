namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class DatagramChannel : java.nio.channels.spi.AbstractSelectableChannel, ByteChannel, ScatteringByteChannel, GatheringByteChannel
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DatagramChannel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.DatagramChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected DatagramChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write11316; 
		public virtual long write(java.nio.ByteBuffer[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.DatagramChannel)) 
				return @__env.CallLongMethod(this, _write11316, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.nio.channels.DatagramChannel.staticClass, _write11316, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write11317; 
		public abstract int write(java.nio.ByteBuffer arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _write11318; 
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _send11319; 
		public abstract int send(java.nio.ByteBuffer arg0, java.net.SocketAddress arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _read11320; 
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _read11321; 
		public virtual long read(java.nio.ByteBuffer[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.DatagramChannel)) 
				return @__env.CallLongMethod(this, _read11321, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.nio.channels.DatagramChannel.staticClass, _read11321, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read11322; 
		public abstract int read(java.nio.ByteBuffer arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _open11323; 
		public static java.nio.channels.DatagramChannel open() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.DatagramChannel>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.DatagramChannel.staticClass, _open11323)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect11324; 
		public abstract java.nio.channels.DatagramChannel connect(java.net.SocketAddress arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _socket11325; 
		public abstract java.net.DatagramSocket socket(); 
		internal static global::net.sf.jni4net.jni.MethodId _disconnect11326; 
		public abstract java.nio.channels.DatagramChannel disconnect(); 
		internal static global::net.sf.jni4net.jni.MethodId _isConnected11327; 
		public abstract bool isConnected(); 
		internal static global::net.sf.jni4net.jni.MethodId _receive11328; 
		public abstract java.net.SocketAddress receive(java.nio.ByteBuffer arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _validOps11329; 
		public sealed override int validOps() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.DatagramChannel)) 
				return @__env.CallIntMethod(this, _validOps11329); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.channels.DatagramChannel.staticClass, _validOps11329); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramChannel11330; 
		protected DatagramChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.DatagramChannel.staticClass, _DatagramChannel11330, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.DatagramChannel.staticClass = @__class; 
			global::java.nio.channels.DatagramChannel._write11316 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J"); 
			global::java.nio.channels.DatagramChannel._write11317 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I"); 
			global::java.nio.channels.DatagramChannel._write11318 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J"); 
			global::java.nio.channels.DatagramChannel._send11319 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I"); 
			global::java.nio.channels.DatagramChannel._read11320 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J"); 
			global::java.nio.channels.DatagramChannel._read11321 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J"); 
			global::java.nio.channels.DatagramChannel._read11322 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I"); 
			global::java.nio.channels.DatagramChannel._open11323 = @__env.GetStaticMethodID(global::java.nio.channels.DatagramChannel.staticClass, "open", "()Ljava/nio/channels/DatagramChannel;"); 
			global::java.nio.channels.DatagramChannel._connect11324 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;"); 
			global::java.nio.channels.DatagramChannel._socket11325 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "socket", "()Ljava/net/DatagramSocket;"); 
			global::java.nio.channels.DatagramChannel._disconnect11326 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "disconnect", "()Ljava/nio/channels/DatagramChannel;"); 
			global::java.nio.channels.DatagramChannel._isConnected11327 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "isConnected", "()Z"); 
			global::java.nio.channels.DatagramChannel._receive11328 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;"); 
			global::java.nio.channels.DatagramChannel._validOps11329 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "validOps", "()I"); 
			global::java.nio.channels.DatagramChannel._DatagramChannel11330 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V"); 
		} 
	} 
} 
