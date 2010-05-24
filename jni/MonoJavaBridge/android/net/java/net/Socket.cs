namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Socket : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Socket() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.net.Socket), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.net.Socket(@__env); 
			} 
		} 
		protected Socket(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11818; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11818)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _toString11818)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close11819; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _close11819); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _close11819); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChannel11820; 
		public virtual java.nio.channels.SocketChannel getChannel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SocketChannel>(@__env, @__env.CallObjectMethodPtr(this, _getChannel11820)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SocketChannel>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _getChannel11820)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPort11821; 
		public virtual int getPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallIntMethod(this, _getPort11821); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.Socket.staticClass, _getPort11821); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputStream11822; 
		public virtual java.io.InputStream getInputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, _getInputStream11822)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _getInputStream11822)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect11823; 
		public virtual void connect(java.net.SocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _connect11823, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _connect11823, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect11824; 
		public virtual void connect(java.net.SocketAddress arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _connect11824, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _connect11824, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClosed11825; 
		public virtual bool isClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _isClosed11825); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _isClosed11825); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOutputStream11826; 
		public virtual java.io.OutputStream getOutputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, _getOutputStream11826)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _getOutputStream11826)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bind11827; 
		public virtual void bind(java.net.SocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _bind11827, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _bind11827, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isConnected11828; 
		public virtual bool isConnected() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _isConnected11828); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _isConnected11828); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalSocketAddress11829; 
		public virtual java.net.SocketAddress getLocalSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallObjectMethodPtr(this, _getLocalSocketAddress11829)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _getLocalSocketAddress11829)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shutdownInput11830; 
		public virtual void shutdownInput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _shutdownInput11830); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _shutdownInput11830); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shutdownOutput11831; 
		public virtual void shutdownOutput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _shutdownOutput11831); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _shutdownOutput11831); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReceiveBufferSize11832; 
		public virtual void setReceiveBufferSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setReceiveBufferSize11832, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setReceiveBufferSize11832, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReceiveBufferSize11833; 
		public virtual int getReceiveBufferSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallIntMethod(this, _getReceiveBufferSize11833); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.Socket.staticClass, _getReceiveBufferSize11833); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoTimeout11834; 
		public virtual void setSoTimeout(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setSoTimeout11834, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setSoTimeout11834, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSoTimeout11835; 
		public virtual int getSoTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallIntMethod(this, _getSoTimeout11835); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.Socket.staticClass, _getSoTimeout11835); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSendBufferSize11836; 
		public virtual void setSendBufferSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setSendBufferSize11836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setSendBufferSize11836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSendBufferSize11837; 
		public virtual int getSendBufferSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallIntMethod(this, _getSendBufferSize11837); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.Socket.staticClass, _getSendBufferSize11837); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRemoteSocketAddress11838; 
		public virtual java.net.SocketAddress getRemoteSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallObjectMethodPtr(this, _getRemoteSocketAddress11838)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _getRemoteSocketAddress11838)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBound11839; 
		public virtual bool isBound() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _isBound11839); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _isBound11839); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOutputShutdown11840; 
		public virtual bool isOutputShutdown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _isOutputShutdown11840); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _isOutputShutdown11840); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInputShutdown11841; 
		public virtual bool isInputShutdown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _isInputShutdown11841); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _isInputShutdown11841); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInetAddress11842; 
		public virtual java.net.InetAddress getInetAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, _getInetAddress11842)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _getInetAddress11842)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalAddress11843; 
		public virtual java.net.InetAddress getLocalAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, _getLocalAddress11843)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _getLocalAddress11843)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalPort11844; 
		public virtual int getLocalPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallIntMethod(this, _getLocalPort11844); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.Socket.staticClass, _getLocalPort11844); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTcpNoDelay11845; 
		public virtual void setTcpNoDelay(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setTcpNoDelay11845, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setTcpNoDelay11845, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTcpNoDelay11846; 
		public virtual bool getTcpNoDelay() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _getTcpNoDelay11846); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _getTcpNoDelay11846); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoLinger11847; 
		public virtual void setSoLinger(bool arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setSoLinger11847, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setSoLinger11847, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSoLinger11848; 
		public virtual int getSoLinger() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallIntMethod(this, _getSoLinger11848); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.Socket.staticClass, _getSoLinger11848); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendUrgentData11849; 
		public virtual void sendUrgentData(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _sendUrgentData11849, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _sendUrgentData11849, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOOBInline11850; 
		public virtual void setOOBInline(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setOOBInline11850, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setOOBInline11850, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOOBInline11851; 
		public virtual bool getOOBInline() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _getOOBInline11851); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _getOOBInline11851); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeepAlive11852; 
		public virtual void setKeepAlive(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setKeepAlive11852, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setKeepAlive11852, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeepAlive11853; 
		public virtual bool getKeepAlive() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _getKeepAlive11853); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _getKeepAlive11853); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTrafficClass11854; 
		public virtual void setTrafficClass(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setTrafficClass11854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setTrafficClass11854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTrafficClass11855; 
		public virtual int getTrafficClass() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallIntMethod(this, _getTrafficClass11855); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.Socket.staticClass, _getTrafficClass11855); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReuseAddress11856; 
		public virtual void setReuseAddress(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setReuseAddress11856, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setReuseAddress11856, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReuseAddress11857; 
		public virtual bool getReuseAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _getReuseAddress11857); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _getReuseAddress11857); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSocketImplFactory11858; 
		public static void setSocketImplFactory(java.net.SocketImplFactory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.net.Socket.staticClass, _setSocketImplFactory11858, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPerformancePreferences11859; 
		public virtual void setPerformancePreferences(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setPerformancePreferences11859, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setPerformancePreferences11859, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11860; 
		public Socket()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11860, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11861; 
		public Socket(java.net.Proxy arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11861, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11862; 
		protected Socket(java.net.SocketImpl arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11862, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11863; 
		public Socket(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11863, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11864; 
		public Socket(java.net.InetAddress arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11864, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11865; 
		public Socket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11865, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11866; 
		public Socket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11866, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11867; 
		public Socket(java.lang.String arg0, int arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11867, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11868; 
		public Socket(java.net.InetAddress arg0, int arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11868, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.Socket.staticClass = @__class; 
			global::java.net.Socket._toString11818 = @__env.GetMethodID(global::java.net.Socket.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.Socket._close11819 = @__env.GetMethodID(global::java.net.Socket.staticClass, "close", "()V"); 
			global::java.net.Socket._getChannel11820 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getChannel", "()Ljava/nio/channels/SocketChannel;"); 
			global::java.net.Socket._getPort11821 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getPort", "()I"); 
			global::java.net.Socket._getInputStream11822 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getInputStream", "()Ljava/io/InputStream;"); 
			global::java.net.Socket._connect11823 = @__env.GetMethodID(global::java.net.Socket.staticClass, "connect", "(Ljava/net/SocketAddress;)V"); 
			global::java.net.Socket._connect11824 = @__env.GetMethodID(global::java.net.Socket.staticClass, "connect", "(Ljava/net/SocketAddress;I)V"); 
			global::java.net.Socket._isClosed11825 = @__env.GetMethodID(global::java.net.Socket.staticClass, "isClosed", "()Z"); 
			global::java.net.Socket._getOutputStream11826 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;"); 
			global::java.net.Socket._bind11827 = @__env.GetMethodID(global::java.net.Socket.staticClass, "bind", "(Ljava/net/SocketAddress;)V"); 
			global::java.net.Socket._isConnected11828 = @__env.GetMethodID(global::java.net.Socket.staticClass, "isConnected", "()Z"); 
			global::java.net.Socket._getLocalSocketAddress11829 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;"); 
			global::java.net.Socket._shutdownInput11830 = @__env.GetMethodID(global::java.net.Socket.staticClass, "shutdownInput", "()V"); 
			global::java.net.Socket._shutdownOutput11831 = @__env.GetMethodID(global::java.net.Socket.staticClass, "shutdownOutput", "()V"); 
			global::java.net.Socket._setReceiveBufferSize11832 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setReceiveBufferSize", "(I)V"); 
			global::java.net.Socket._getReceiveBufferSize11833 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getReceiveBufferSize", "()I"); 
			global::java.net.Socket._setSoTimeout11834 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setSoTimeout", "(I)V"); 
			global::java.net.Socket._getSoTimeout11835 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getSoTimeout", "()I"); 
			global::java.net.Socket._setSendBufferSize11836 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setSendBufferSize", "(I)V"); 
			global::java.net.Socket._getSendBufferSize11837 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getSendBufferSize", "()I"); 
			global::java.net.Socket._getRemoteSocketAddress11838 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getRemoteSocketAddress", "()Ljava/net/SocketAddress;"); 
			global::java.net.Socket._isBound11839 = @__env.GetMethodID(global::java.net.Socket.staticClass, "isBound", "()Z"); 
			global::java.net.Socket._isOutputShutdown11840 = @__env.GetMethodID(global::java.net.Socket.staticClass, "isOutputShutdown", "()Z"); 
			global::java.net.Socket._isInputShutdown11841 = @__env.GetMethodID(global::java.net.Socket.staticClass, "isInputShutdown", "()Z"); 
			global::java.net.Socket._getInetAddress11842 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;"); 
			global::java.net.Socket._getLocalAddress11843 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;"); 
			global::java.net.Socket._getLocalPort11844 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getLocalPort", "()I"); 
			global::java.net.Socket._setTcpNoDelay11845 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setTcpNoDelay", "(Z)V"); 
			global::java.net.Socket._getTcpNoDelay11846 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getTcpNoDelay", "()Z"); 
			global::java.net.Socket._setSoLinger11847 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setSoLinger", "(ZI)V"); 
			global::java.net.Socket._getSoLinger11848 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getSoLinger", "()I"); 
			global::java.net.Socket._sendUrgentData11849 = @__env.GetMethodID(global::java.net.Socket.staticClass, "sendUrgentData", "(I)V"); 
			global::java.net.Socket._setOOBInline11850 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setOOBInline", "(Z)V"); 
			global::java.net.Socket._getOOBInline11851 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getOOBInline", "()Z"); 
			global::java.net.Socket._setKeepAlive11852 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setKeepAlive", "(Z)V"); 
			global::java.net.Socket._getKeepAlive11853 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getKeepAlive", "()Z"); 
			global::java.net.Socket._setTrafficClass11854 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setTrafficClass", "(I)V"); 
			global::java.net.Socket._getTrafficClass11855 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getTrafficClass", "()I"); 
			global::java.net.Socket._setReuseAddress11856 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setReuseAddress", "(Z)V"); 
			global::java.net.Socket._getReuseAddress11857 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getReuseAddress", "()Z"); 
			global::java.net.Socket._setSocketImplFactory11858 = @__env.GetStaticMethodID(global::java.net.Socket.staticClass, "setSocketImplFactory", "(Ljava/net/SocketImplFactory;)V"); 
			global::java.net.Socket._setPerformancePreferences11859 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setPerformancePreferences", "(III)V"); 
			global::java.net.Socket._Socket11860 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "()V"); 
			global::java.net.Socket._Socket11861 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/Proxy;)V"); 
			global::java.net.Socket._Socket11862 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/SocketImpl;)V"); 
			global::java.net.Socket._Socket11863 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;I)V"); 
			global::java.net.Socket._Socket11864 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;I)V"); 
			global::java.net.Socket._Socket11865 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V"); 
			global::java.net.Socket._Socket11866 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V"); 
			global::java.net.Socket._Socket11867 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;IZ)V"); 
			global::java.net.Socket._Socket11868 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;IZ)V"); 
		} 
	} 
} 
