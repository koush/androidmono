namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DatagramSocket : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static DatagramSocket() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.net.DatagramSocket), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.net.DatagramSocket(@__env); 
			} 
		} 
		protected DatagramSocket(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close10854; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, _close10854); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramSocket.staticClass, _close10854); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _send10855; 
		public virtual void send(java.net.DatagramPacket arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, _send10855, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramSocket.staticClass, _send10855, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChannel10856; 
		public virtual java.nio.channels.DatagramChannel getChannel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.DatagramChannel>(@__env, @__env.CallObjectMethodPtr(this, _getChannel10856)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.DatagramChannel>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.DatagramSocket.staticClass, _getChannel10856)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPort10857; 
		public virtual int getPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallIntMethod(this, _getPort10857); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.DatagramSocket.staticClass, _getPort10857); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect10858; 
		public virtual void connect(java.net.InetAddress arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, _connect10858, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramSocket.staticClass, _connect10858, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect10859; 
		public virtual void connect(java.net.SocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, _connect10859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramSocket.staticClass, _connect10859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClosed10860; 
		public virtual bool isClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallBooleanMethod(this, _isClosed10860); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.DatagramSocket.staticClass, _isClosed10860); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBroadcast10861; 
		public virtual bool getBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallBooleanMethod(this, _getBroadcast10861); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.DatagramSocket.staticClass, _getBroadcast10861); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bind10862; 
		public virtual void bind(java.net.SocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, _bind10862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramSocket.staticClass, _bind10862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _disconnect10863; 
		public virtual void disconnect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, _disconnect10863); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramSocket.staticClass, _disconnect10863); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isConnected10864; 
		public virtual bool isConnected() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallBooleanMethod(this, _isConnected10864); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.DatagramSocket.staticClass, _isConnected10864); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalSocketAddress10865; 
		public virtual java.net.SocketAddress getLocalSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallObjectMethodPtr(this, _getLocalSocketAddress10865)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.DatagramSocket.staticClass, _getLocalSocketAddress10865)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReceiveBufferSize10866; 
		public virtual void setReceiveBufferSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, _setReceiveBufferSize10866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramSocket.staticClass, _setReceiveBufferSize10866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReceiveBufferSize10867; 
		public virtual int getReceiveBufferSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallIntMethod(this, _getReceiveBufferSize10867); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.DatagramSocket.staticClass, _getReceiveBufferSize10867); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoTimeout10868; 
		public virtual void setSoTimeout(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, _setSoTimeout10868, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramSocket.staticClass, _setSoTimeout10868, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSoTimeout10869; 
		public virtual int getSoTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallIntMethod(this, _getSoTimeout10869); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.DatagramSocket.staticClass, _getSoTimeout10869); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSendBufferSize10870; 
		public virtual void setSendBufferSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, _setSendBufferSize10870, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramSocket.staticClass, _setSendBufferSize10870, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSendBufferSize10871; 
		public virtual int getSendBufferSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallIntMethod(this, _getSendBufferSize10871); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.DatagramSocket.staticClass, _getSendBufferSize10871); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRemoteSocketAddress10872; 
		public virtual java.net.SocketAddress getRemoteSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallObjectMethodPtr(this, _getRemoteSocketAddress10872)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.DatagramSocket.staticClass, _getRemoteSocketAddress10872)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBound10873; 
		public virtual bool isBound() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallBooleanMethod(this, _isBound10873); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.DatagramSocket.staticClass, _isBound10873); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInetAddress10874; 
		public virtual java.net.InetAddress getInetAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, _getInetAddress10874)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.DatagramSocket.staticClass, _getInetAddress10874)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalAddress10875; 
		public virtual java.net.InetAddress getLocalAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, _getLocalAddress10875)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.DatagramSocket.staticClass, _getLocalAddress10875)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalPort10876; 
		public virtual int getLocalPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallIntMethod(this, _getLocalPort10876); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.DatagramSocket.staticClass, _getLocalPort10876); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTrafficClass10877; 
		public virtual void setTrafficClass(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, _setTrafficClass10877, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramSocket.staticClass, _setTrafficClass10877, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTrafficClass10878; 
		public virtual int getTrafficClass() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallIntMethod(this, _getTrafficClass10878); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.DatagramSocket.staticClass, _getTrafficClass10878); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReuseAddress10879; 
		public virtual void setReuseAddress(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, _setReuseAddress10879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramSocket.staticClass, _setReuseAddress10879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReuseAddress10880; 
		public virtual bool getReuseAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallBooleanMethod(this, _getReuseAddress10880); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.DatagramSocket.staticClass, _getReuseAddress10880); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _receive10881; 
		public virtual void receive(java.net.DatagramPacket arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, _receive10881, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramSocket.staticClass, _receive10881, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBroadcast10882; 
		public virtual void setBroadcast(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, _setBroadcast10882, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramSocket.staticClass, _setBroadcast10882, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDatagramSocketImplFactory10883; 
		public static void setDatagramSocketImplFactory(java.net.DatagramSocketImplFactory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.net.DatagramSocket.staticClass, _setDatagramSocketImplFactory10883, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramSocket10884; 
		public DatagramSocket()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramSocket.staticClass, _DatagramSocket10884, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramSocket10885; 
		protected DatagramSocket(java.net.DatagramSocketImpl arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramSocket.staticClass, _DatagramSocket10885, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramSocket10886; 
		public DatagramSocket(java.net.SocketAddress arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramSocket.staticClass, _DatagramSocket10886, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramSocket10887; 
		public DatagramSocket(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramSocket.staticClass, _DatagramSocket10887, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramSocket10888; 
		public DatagramSocket(int arg0, java.net.InetAddress arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramSocket.staticClass, _DatagramSocket10888, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.DatagramSocket.staticClass = @__class; 
			global::java.net.DatagramSocket._close10854 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "close", "()V"); 
			global::java.net.DatagramSocket._send10855 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "send", "(Ljava/net/DatagramPacket;)V"); 
			global::java.net.DatagramSocket._getChannel10856 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getChannel", "()Ljava/nio/channels/DatagramChannel;"); 
			global::java.net.DatagramSocket._getPort10857 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getPort", "()I"); 
			global::java.net.DatagramSocket._connect10858 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/InetAddress;I)V"); 
			global::java.net.DatagramSocket._connect10859 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/SocketAddress;)V"); 
			global::java.net.DatagramSocket._isClosed10860 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "isClosed", "()Z"); 
			global::java.net.DatagramSocket._getBroadcast10861 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getBroadcast", "()Z"); 
			global::java.net.DatagramSocket._bind10862 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V"); 
			global::java.net.DatagramSocket._disconnect10863 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "disconnect", "()V"); 
			global::java.net.DatagramSocket._isConnected10864 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "isConnected", "()Z"); 
			global::java.net.DatagramSocket._getLocalSocketAddress10865 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;"); 
			global::java.net.DatagramSocket._setReceiveBufferSize10866 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "setReceiveBufferSize", "(I)V"); 
			global::java.net.DatagramSocket._getReceiveBufferSize10867 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getReceiveBufferSize", "()I"); 
			global::java.net.DatagramSocket._setSoTimeout10868 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "setSoTimeout", "(I)V"); 
			global::java.net.DatagramSocket._getSoTimeout10869 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getSoTimeout", "()I"); 
			global::java.net.DatagramSocket._setSendBufferSize10870 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "setSendBufferSize", "(I)V"); 
			global::java.net.DatagramSocket._getSendBufferSize10871 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getSendBufferSize", "()I"); 
			global::java.net.DatagramSocket._getRemoteSocketAddress10872 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getRemoteSocketAddress", "()Ljava/net/SocketAddress;"); 
			global::java.net.DatagramSocket._isBound10873 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "isBound", "()Z"); 
			global::java.net.DatagramSocket._getInetAddress10874 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;"); 
			global::java.net.DatagramSocket._getLocalAddress10875 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;"); 
			global::java.net.DatagramSocket._getLocalPort10876 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getLocalPort", "()I"); 
			global::java.net.DatagramSocket._setTrafficClass10877 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "setTrafficClass", "(I)V"); 
			global::java.net.DatagramSocket._getTrafficClass10878 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getTrafficClass", "()I"); 
			global::java.net.DatagramSocket._setReuseAddress10879 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "setReuseAddress", "(Z)V"); 
			global::java.net.DatagramSocket._getReuseAddress10880 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getReuseAddress", "()Z"); 
			global::java.net.DatagramSocket._receive10881 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "receive", "(Ljava/net/DatagramPacket;)V"); 
			global::java.net.DatagramSocket._setBroadcast10882 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "setBroadcast", "(Z)V"); 
			global::java.net.DatagramSocket._setDatagramSocketImplFactory10883 = @__env.GetStaticMethodID(global::java.net.DatagramSocket.staticClass, "setDatagramSocketImplFactory", "(Ljava/net/DatagramSocketImplFactory;)V"); 
			global::java.net.DatagramSocket._DatagramSocket10884 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "<init>", "()V"); 
			global::java.net.DatagramSocket._DatagramSocket10885 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/DatagramSocketImpl;)V"); 
			global::java.net.DatagramSocket._DatagramSocket10886 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/SocketAddress;)V"); 
			global::java.net.DatagramSocket._DatagramSocket10887 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "<init>", "(I)V"); 
			global::java.net.DatagramSocket._DatagramSocket10888 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "<init>", "(ILjava/net/InetAddress;)V"); 
		} 
	} 
} 
