namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class DatagramSocketImpl : java.lang.Object, SocketOptions
	{ 
		internal static global::java.lang.Class staticClass; 
		static DatagramSocketImpl() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.net.DatagramSocketImpl), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected DatagramSocketImpl(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOption11715; 
		public abstract global::java.lang.Object getOption(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setOption11716; 
		public abstract void setOption(int arg0, java.lang.Object arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _join11717; 
		protected abstract void join(java.net.InetAddress arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _close11718; 
		protected abstract void close(); 
		internal static global::net.sf.jni4net.jni.MethodId _peek11719; 
		protected abstract int peek(java.net.InetAddress arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _send11720; 
		protected abstract void send(java.net.DatagramPacket arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _create11721; 
		protected abstract void create(); 
		internal static global::net.sf.jni4net.jni.MethodId _connect11722; 
		protected virtual void connect(java.net.InetAddress arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocketImpl)) 
				@__env.CallVoidMethod(this, global::java.net.DatagramSocketImpl._connect11722, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._connect11722, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _peekData11723; 
		protected abstract int peekData(java.net.DatagramPacket arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getFileDescriptor11724; 
		protected virtual global::java.io.FileDescriptor getFileDescriptor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocketImpl)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.DatagramSocketImpl._getFileDescriptor11724)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._getFileDescriptor11724)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bind11725; 
		protected abstract void bind(int arg0, java.net.InetAddress arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _disconnect11726; 
		protected virtual void disconnect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocketImpl)) 
				@__env.CallVoidMethod(this, global::java.net.DatagramSocketImpl._disconnect11726); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._disconnect11726); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalPort11727; 
		protected virtual int getLocalPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocketImpl)) 
				return @__env.CallIntMethod(this, global::java.net.DatagramSocketImpl._getLocalPort11727); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._getLocalPort11727); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _receive11728; 
		protected abstract void receive(java.net.DatagramPacket arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setTTL11729; 
		protected abstract void setTTL(byte arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getTTL11730; 
		protected abstract byte getTTL(); 
		internal static global::net.sf.jni4net.jni.MethodId _setTimeToLive11731; 
		protected abstract void setTimeToLive(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getTimeToLive11732; 
		protected abstract int getTimeToLive(); 
		internal static global::net.sf.jni4net.jni.MethodId _leave11733; 
		protected abstract void leave(java.net.InetAddress arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _joinGroup11734; 
		protected abstract void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _leaveGroup11735; 
		protected abstract void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramSocketImpl11736; 
		public DatagramSocketImpl()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramSocketImpl.staticClass, global::java.net.DatagramSocketImpl._DatagramSocketImpl11736, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.DatagramSocketImpl.staticClass = @__class; 
			global::java.net.DatagramSocketImpl._getOption11715 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "getOption", "(I)Ljava/lang/Object;"); 
			global::java.net.DatagramSocketImpl._setOption11716 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "setOption", "(ILjava/lang/Object;)V"); 
			global::java.net.DatagramSocketImpl._join11717 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "join", "(Ljava/net/InetAddress;)V"); 
			global::java.net.DatagramSocketImpl._close11718 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "close", "()V"); 
			global::java.net.DatagramSocketImpl._peek11719 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "peek", "(Ljava/net/InetAddress;)I"); 
			global::java.net.DatagramSocketImpl._send11720 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "send", "(Ljava/net/DatagramPacket;)V"); 
			global::java.net.DatagramSocketImpl._create11721 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "create", "()V"); 
			global::java.net.DatagramSocketImpl._connect11722 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "connect", "(Ljava/net/InetAddress;I)V"); 
			global::java.net.DatagramSocketImpl._peekData11723 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "peekData", "(Ljava/net/DatagramPacket;)I"); 
			global::java.net.DatagramSocketImpl._getFileDescriptor11724 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;"); 
			global::java.net.DatagramSocketImpl._bind11725 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "bind", "(ILjava/net/InetAddress;)V"); 
			global::java.net.DatagramSocketImpl._disconnect11726 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "disconnect", "()V"); 
			global::java.net.DatagramSocketImpl._getLocalPort11727 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "getLocalPort", "()I"); 
			global::java.net.DatagramSocketImpl._receive11728 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "receive", "(Ljava/net/DatagramPacket;)V"); 
			global::java.net.DatagramSocketImpl._setTTL11729 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "setTTL", "(B)V"); 
			global::java.net.DatagramSocketImpl._getTTL11730 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "getTTL", "()B"); 
			global::java.net.DatagramSocketImpl._setTimeToLive11731 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "setTimeToLive", "(I)V"); 
			global::java.net.DatagramSocketImpl._getTimeToLive11732 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "getTimeToLive", "()I"); 
			global::java.net.DatagramSocketImpl._leave11733 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "leave", "(Ljava/net/InetAddress;)V"); 
			global::java.net.DatagramSocketImpl._joinGroup11734 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V"); 
			global::java.net.DatagramSocketImpl._leaveGroup11735 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V"); 
			global::java.net.DatagramSocketImpl._DatagramSocketImpl11736 = @__env.GetMethodID(global::java.net.DatagramSocketImpl.staticClass, "<init>", "()V"); 
		} 
	} 
} 
