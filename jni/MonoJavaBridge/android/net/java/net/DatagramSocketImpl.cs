namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class DatagramSocketImpl : java.lang.Object, SocketOptions
	{ 
		internal static global::java.lang.Class staticClass; 
		static DatagramSocketImpl() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.net.DatagramSocketImpl), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected DatagramSocketImpl(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOption10889; 
		public abstract java.lang.Object getOption(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setOption10890; 
		public abstract void setOption(int arg0, java.lang.Object arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _join10891; 
		protected abstract void join(java.net.InetAddress arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _close10892; 
		protected abstract void close(); 
		internal static global::net.sf.jni4net.jni.MethodId _peek10893; 
		protected abstract int peek(java.net.InetAddress arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _send10894; 
		protected abstract void send(java.net.DatagramPacket arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _create10895; 
		protected abstract void create(); 
		internal static global::net.sf.jni4net.jni.MethodId _connect10896; 
		protected virtual void connect(java.net.InetAddress arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocketImpl)) 
				@__env.CallVoidMethod(this, _connect10896, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramSocketImpl.staticClass, _connect10896, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _peekData10897; 
		protected abstract int peekData(java.net.DatagramPacket arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getFileDescriptor10898; 
		protected virtual java.io.FileDescriptor getFileDescriptor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocketImpl)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _getFileDescriptor10898)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.DatagramSocketImpl.staticClass, _getFileDescriptor10898)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bind10899; 
		protected abstract void bind(int arg0, java.net.InetAddress arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _disconnect10900; 
		protected virtual void disconnect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocketImpl)) 
				@__env.CallVoidMethod(this, _disconnect10900); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramSocketImpl.staticClass, _disconnect10900); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalPort10901; 
		protected virtual int getLocalPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocketImpl)) 
				return @__env.CallIntMethod(this, _getLocalPort10901); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.DatagramSocketImpl.staticClass, _getLocalPort10901); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _receive10902; 
		protected abstract void receive(java.net.DatagramPacket arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setTTL10903; 
		protected abstract void setTTL(byte arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getTTL10904; 
		protected abstract byte getTTL(); 
		internal static global::net.sf.jni4net.jni.MethodId _setTimeToLive10905; 
		protected abstract void setTimeToLive(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getTimeToLive10906; 
		protected abstract int getTimeToLive(); 
		internal static global::net.sf.jni4net.jni.MethodId _leave10907; 
		protected abstract void leave(java.net.InetAddress arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _joinGroup10908; 
		protected abstract void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _leaveGroup10909; 
		protected abstract void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramSocketImpl10910; 
		public DatagramSocketImpl()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramSocketImpl.staticClass, _DatagramSocketImpl10910, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.DatagramSocketImpl.staticClass = @__class; 
			global::java.net.DatagramSocketImpl._getOption10889 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "getOption", "(I)Ljava/lang/Object;"); 
			global::java.net.DatagramSocketImpl._setOption10890 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "setOption", "(ILjava/lang/Object;)V"); 
			global::java.net.DatagramSocketImpl._join10891 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "join", "(Ljava/net/InetAddress;)V"); 
			global::java.net.DatagramSocketImpl._close10892 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "close", "()V"); 
			global::java.net.DatagramSocketImpl._peek10893 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "peek", "(Ljava/net/InetAddress;)I"); 
			global::java.net.DatagramSocketImpl._send10894 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "send", "(Ljava/net/DatagramPacket;)V"); 
			global::java.net.DatagramSocketImpl._create10895 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "create", "()V"); 
			global::java.net.DatagramSocketImpl._connect10896 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "connect", "(Ljava/net/InetAddress;I)V"); 
			global::java.net.DatagramSocketImpl._peekData10897 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "peekData", "(Ljava/net/DatagramPacket;)I"); 
			global::java.net.DatagramSocketImpl._getFileDescriptor10898 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;"); 
			global::java.net.DatagramSocketImpl._bind10899 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "bind", "(ILjava/net/InetAddress;)V"); 
			global::java.net.DatagramSocketImpl._disconnect10900 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "disconnect", "()V"); 
			global::java.net.DatagramSocketImpl._getLocalPort10901 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "getLocalPort", "()I"); 
			global::java.net.DatagramSocketImpl._receive10902 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "receive", "(Ljava/net/DatagramPacket;)V"); 
			global::java.net.DatagramSocketImpl._setTTL10903 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "setTTL", "(B)V"); 
			global::java.net.DatagramSocketImpl._getTTL10904 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "getTTL", "()B"); 
			global::java.net.DatagramSocketImpl._setTimeToLive10905 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "setTimeToLive", "(I)V"); 
			global::java.net.DatagramSocketImpl._getTimeToLive10906 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "getTimeToLive", "()I"); 
			global::java.net.DatagramSocketImpl._leave10907 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "leave", "(Ljava/net/InetAddress;)V"); 
			global::java.net.DatagramSocketImpl._joinGroup10908 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V"); 
			global::java.net.DatagramSocketImpl._leaveGroup10909 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V"); 
			global::java.net.DatagramSocketImpl._DatagramSocketImpl10910 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "<init>", "()V"); 
		} 
	} 
} 
