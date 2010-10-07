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
		internal static global::net.sf.jni4net.jni.MethodId _write12885;
		public virtual long write(java.nio.ByteBuffer[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.nio.channels.DatagramChannel._write12885, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._write12885, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write12886;
		public abstract int write(java.nio.ByteBuffer arg0);
		internal static global::net.sf.jni4net.jni.MethodId _write12887;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::net.sf.jni4net.jni.MethodId _send12888;
		public abstract int send(java.nio.ByteBuffer arg0, java.net.SocketAddress arg1);
		internal static global::net.sf.jni4net.jni.MethodId _read12889;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::net.sf.jni4net.jni.MethodId _read12890;
		public virtual long read(java.nio.ByteBuffer[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.nio.channels.DatagramChannel._read12890, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._read12890, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _read12891;
		public abstract int read(java.nio.ByteBuffer arg0);
		internal static global::net.sf.jni4net.jni.MethodId _open12892;
		public static global::java.nio.channels.DatagramChannel open() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.DatagramChannel>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._open12892));
		}
		internal static global::net.sf.jni4net.jni.MethodId _connect12893;
		public abstract global::java.nio.channels.DatagramChannel connect(java.net.SocketAddress arg0);
		internal static global::net.sf.jni4net.jni.MethodId _socket12894;
		public abstract global::java.net.DatagramSocket socket();
		internal static global::net.sf.jni4net.jni.MethodId _disconnect12895;
		public abstract global::java.nio.channels.DatagramChannel disconnect();
		internal static global::net.sf.jni4net.jni.MethodId _isConnected12896;
		public abstract bool isConnected();
		internal static global::net.sf.jni4net.jni.MethodId _receive12897;
		public abstract global::java.net.SocketAddress receive(java.nio.ByteBuffer arg0);
		internal static global::net.sf.jni4net.jni.MethodId _validOps12898;
		public sealed override int validOps() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.channels.DatagramChannel._validOps12898);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._validOps12898);
		}
		internal static global::net.sf.jni4net.jni.MethodId _DatagramChannel12899;
		protected DatagramChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.channels.DatagramChannel.staticClass, global::java.nio.channels.DatagramChannel._DatagramChannel12899, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.channels.DatagramChannel.staticClass = @__class;
			global::java.nio.channels.DatagramChannel._write12885 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.DatagramChannel._write12886 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.DatagramChannel._write12887 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.DatagramChannel._send12888 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I");
			global::java.nio.channels.DatagramChannel._read12889 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.DatagramChannel._read12890 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.DatagramChannel._read12891 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.DatagramChannel._open12892 = @__env.GetStaticMethodID(global::java.nio.channels.DatagramChannel.staticClass, "open", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel._connect12893 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel._socket12894 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "socket", "()Ljava/net/DatagramSocket;");
			global::java.nio.channels.DatagramChannel._disconnect12895 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "disconnect", "()Ljava/nio/channels/DatagramChannel;");
			global::java.nio.channels.DatagramChannel._isConnected12896 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "isConnected", "()Z");
			global::java.nio.channels.DatagramChannel._receive12897 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;");
			global::java.nio.channels.DatagramChannel._validOps12898 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.DatagramChannel._DatagramChannel12899 = @__env.GetMethodID(global::java.nio.channels.DatagramChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
		}
	}
}
