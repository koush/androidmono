namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class DatagramChannel : java.nio.channels.spi.AbstractSelectableChannel, ByteChannel, ScatteringByteChannel, GatheringByteChannel
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DatagramChannel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.DatagramChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected DatagramChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write12156; 
		public virtual long write(java.nio.ByteBuffer[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::java.nio.channels.DatagramChannel._write12156, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._write12156, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write12157; 
		public abstract int write(java.nio.ByteBuffer arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _write12158; 
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _send12159; 
		public abstract int send(java.nio.ByteBuffer arg0, java.net.SocketAddress arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _read12160; 
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _read12161; 
		public virtual long read(java.nio.ByteBuffer[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::java.nio.channels.DatagramChannel._read12161, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._read12161, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read12162; 
		public abstract int read(java.nio.ByteBuffer arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _open12163; 
		public static global::java.nio.channels.DatagramChannel open() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.DatagramChannel>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._open12163)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect12164; 
		public abstract global::java.nio.channels.DatagramChannel connect(java.net.SocketAddress arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _socket12165; 
		public abstract global::java.net.DatagramSocket socket(); 
		internal static global::net.sf.jni4net.jni.MethodId _disconnect12166; 
		public abstract global::java.nio.channels.DatagramChannel disconnect(); 
		internal static global::net.sf.jni4net.jni.MethodId _isConnected12167; 
		public abstract bool isConnected(); 
		internal static global::net.sf.jni4net.jni.MethodId _receive12168; 
		public abstract global::java.net.SocketAddress receive(java.nio.ByteBuffer arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _validOps12169; 
		public sealed override int validOps() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.nio.channels.DatagramChannel._validOps12169); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._validOps12169); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramChannel12170; 
		protected DatagramChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._DatagramChannel12170, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.DatagramChannel.staticClass = @__class; 
			global::java.nio.channels.DatagramChannel._write12156 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J"); 
			global::java.nio.channels.DatagramChannel._write12157 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I"); 
			global::java.nio.channels.DatagramChannel._write12158 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J"); 
			global::java.nio.channels.DatagramChannel._send12159 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I"); 
			global::java.nio.channels.DatagramChannel._read12160 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J"); 
			global::java.nio.channels.DatagramChannel._read12161 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J"); 
			global::java.nio.channels.DatagramChannel._read12162 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I"); 
			global::java.nio.channels.DatagramChannel._open12163 = @__env.GetStaticMethodID(global::java.nio.channels.DatagramChannel.staticClass, "open", "()Ljava/nio/channels/DatagramChannel;"); 
			global::java.nio.channels.DatagramChannel._connect12164 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;"); 
			global::java.nio.channels.DatagramChannel._socket12165 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "socket", "()Ljava/net/DatagramSocket;"); 
			global::java.nio.channels.DatagramChannel._disconnect12166 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "disconnect", "()Ljava/nio/channels/DatagramChannel;"); 
			global::java.nio.channels.DatagramChannel._isConnected12167 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "isConnected", "()Z"); 
			global::java.nio.channels.DatagramChannel._receive12168 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;"); 
			global::java.nio.channels.DatagramChannel._validOps12169 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "validOps", "()I"); 
			global::java.nio.channels.DatagramChannel._DatagramChannel12170 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V"); 
		} 
	} 
} 
