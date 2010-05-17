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
		internal static global::net.sf.jni4net.jni.MethodId _toString10990; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString10990)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _toString10990)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close10991; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _close10991); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _close10991); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChannel10992; 
		public virtual java.nio.channels.SocketChannel getChannel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SocketChannel>(@__env, @__env.CallObjectMethodPtr(this, _getChannel10992)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SocketChannel>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _getChannel10992)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPort10993; 
		public virtual int getPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallIntMethod(this, _getPort10993); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.Socket.staticClass, _getPort10993); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputStream10994; 
		public virtual java.io.InputStream getInputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, _getInputStream10994)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _getInputStream10994)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect10995; 
		public virtual void connect(java.net.SocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _connect10995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _connect10995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect10996; 
		public virtual void connect(java.net.SocketAddress arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _connect10996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _connect10996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClosed10997; 
		public virtual bool isClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _isClosed10997); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _isClosed10997); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOutputStream10998; 
		public virtual java.io.OutputStream getOutputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, _getOutputStream10998)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _getOutputStream10998)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bind10999; 
		public virtual void bind(java.net.SocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _bind10999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _bind10999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isConnected11000; 
		public virtual bool isConnected() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _isConnected11000); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _isConnected11000); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalSocketAddress11001; 
		public virtual java.net.SocketAddress getLocalSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallObjectMethodPtr(this, _getLocalSocketAddress11001)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _getLocalSocketAddress11001)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shutdownInput11002; 
		public virtual void shutdownInput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _shutdownInput11002); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _shutdownInput11002); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shutdownOutput11003; 
		public virtual void shutdownOutput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _shutdownOutput11003); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _shutdownOutput11003); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReceiveBufferSize11004; 
		public virtual void setReceiveBufferSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setReceiveBufferSize11004, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setReceiveBufferSize11004, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReceiveBufferSize11005; 
		public virtual int getReceiveBufferSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallIntMethod(this, _getReceiveBufferSize11005); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.Socket.staticClass, _getReceiveBufferSize11005); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoTimeout11006; 
		public virtual void setSoTimeout(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setSoTimeout11006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setSoTimeout11006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSoTimeout11007; 
		public virtual int getSoTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallIntMethod(this, _getSoTimeout11007); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.Socket.staticClass, _getSoTimeout11007); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSendBufferSize11008; 
		public virtual void setSendBufferSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setSendBufferSize11008, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setSendBufferSize11008, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSendBufferSize11009; 
		public virtual int getSendBufferSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallIntMethod(this, _getSendBufferSize11009); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.Socket.staticClass, _getSendBufferSize11009); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRemoteSocketAddress11010; 
		public virtual java.net.SocketAddress getRemoteSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallObjectMethodPtr(this, _getRemoteSocketAddress11010)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _getRemoteSocketAddress11010)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBound11011; 
		public virtual bool isBound() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _isBound11011); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _isBound11011); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOutputShutdown11012; 
		public virtual bool isOutputShutdown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _isOutputShutdown11012); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _isOutputShutdown11012); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInputShutdown11013; 
		public virtual bool isInputShutdown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _isInputShutdown11013); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _isInputShutdown11013); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInetAddress11014; 
		public virtual java.net.InetAddress getInetAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, _getInetAddress11014)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _getInetAddress11014)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalAddress11015; 
		public virtual java.net.InetAddress getLocalAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, _getLocalAddress11015)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.Socket.staticClass, _getLocalAddress11015)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalPort11016; 
		public virtual int getLocalPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallIntMethod(this, _getLocalPort11016); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.Socket.staticClass, _getLocalPort11016); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTcpNoDelay11017; 
		public virtual void setTcpNoDelay(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setTcpNoDelay11017, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setTcpNoDelay11017, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTcpNoDelay11018; 
		public virtual bool getTcpNoDelay() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _getTcpNoDelay11018); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _getTcpNoDelay11018); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoLinger11019; 
		public virtual void setSoLinger(bool arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setSoLinger11019, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setSoLinger11019, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSoLinger11020; 
		public virtual int getSoLinger() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallIntMethod(this, _getSoLinger11020); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.Socket.staticClass, _getSoLinger11020); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendUrgentData11021; 
		public virtual void sendUrgentData(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _sendUrgentData11021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _sendUrgentData11021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOOBInline11022; 
		public virtual void setOOBInline(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setOOBInline11022, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setOOBInline11022, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOOBInline11023; 
		public virtual bool getOOBInline() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _getOOBInline11023); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _getOOBInline11023); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeepAlive11024; 
		public virtual void setKeepAlive(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setKeepAlive11024, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setKeepAlive11024, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeepAlive11025; 
		public virtual bool getKeepAlive() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _getKeepAlive11025); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _getKeepAlive11025); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTrafficClass11026; 
		public virtual void setTrafficClass(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setTrafficClass11026, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setTrafficClass11026, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTrafficClass11027; 
		public virtual int getTrafficClass() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallIntMethod(this, _getTrafficClass11027); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.Socket.staticClass, _getTrafficClass11027); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReuseAddress11028; 
		public virtual void setReuseAddress(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setReuseAddress11028, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setReuseAddress11028, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReuseAddress11029; 
		public virtual bool getReuseAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				return @__env.CallBooleanMethod(this, _getReuseAddress11029); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.Socket.staticClass, _getReuseAddress11029); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSocketImplFactory11030; 
		public static void setSocketImplFactory(java.net.SocketImplFactory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.net.Socket.staticClass, _setSocketImplFactory11030, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPerformancePreferences11031; 
		public virtual void setPerformancePreferences(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.Socket)) 
				@__env.CallVoidMethod(this, _setPerformancePreferences11031, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.Socket.staticClass, _setPerformancePreferences11031, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11032; 
		public Socket()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11032, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11033; 
		public Socket(java.net.Proxy arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11033, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11034; 
		protected Socket(java.net.SocketImpl arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11034, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11035; 
		public Socket(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11035, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11036; 
		public Socket(java.net.InetAddress arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11036, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11037; 
		public Socket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11037, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11038; 
		public Socket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11038, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11039; 
		public Socket(java.lang.String arg0, int arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11039, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Socket11040; 
		public Socket(java.net.InetAddress arg0, int arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.Socket.staticClass, _Socket11040, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.Socket.staticClass = @__class; 
			global::java.net.Socket._toString10990 = @__env.GetMethodID(global::java.net.Socket.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.Socket._close10991 = @__env.GetMethodID(global::java.net.Socket.staticClass, "close", "()V"); 
			global::java.net.Socket._getChannel10992 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getChannel", "()Ljava/nio/channels/SocketChannel;"); 
			global::java.net.Socket._getPort10993 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getPort", "()I"); 
			global::java.net.Socket._getInputStream10994 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getInputStream", "()Ljava/io/InputStream;"); 
			global::java.net.Socket._connect10995 = @__env.GetMethodID(global::java.net.Socket.staticClass, "connect", "(Ljava/net/SocketAddress;)V"); 
			global::java.net.Socket._connect10996 = @__env.GetMethodID(global::java.net.Socket.staticClass, "connect", "(Ljava/net/SocketAddress;I)V"); 
			global::java.net.Socket._isClosed10997 = @__env.GetMethodID(global::java.net.Socket.staticClass, "isClosed", "()Z"); 
			global::java.net.Socket._getOutputStream10998 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;"); 
			global::java.net.Socket._bind10999 = @__env.GetMethodID(global::java.net.Socket.staticClass, "bind", "(Ljava/net/SocketAddress;)V"); 
			global::java.net.Socket._isConnected11000 = @__env.GetMethodID(global::java.net.Socket.staticClass, "isConnected", "()Z"); 
			global::java.net.Socket._getLocalSocketAddress11001 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;"); 
			global::java.net.Socket._shutdownInput11002 = @__env.GetMethodID(global::java.net.Socket.staticClass, "shutdownInput", "()V"); 
			global::java.net.Socket._shutdownOutput11003 = @__env.GetMethodID(global::java.net.Socket.staticClass, "shutdownOutput", "()V"); 
			global::java.net.Socket._setReceiveBufferSize11004 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setReceiveBufferSize", "(I)V"); 
			global::java.net.Socket._getReceiveBufferSize11005 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getReceiveBufferSize", "()I"); 
			global::java.net.Socket._setSoTimeout11006 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setSoTimeout", "(I)V"); 
			global::java.net.Socket._getSoTimeout11007 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getSoTimeout", "()I"); 
			global::java.net.Socket._setSendBufferSize11008 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setSendBufferSize", "(I)V"); 
			global::java.net.Socket._getSendBufferSize11009 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getSendBufferSize", "()I"); 
			global::java.net.Socket._getRemoteSocketAddress11010 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getRemoteSocketAddress", "()Ljava/net/SocketAddress;"); 
			global::java.net.Socket._isBound11011 = @__env.GetMethodID(global::java.net.Socket.staticClass, "isBound", "()Z"); 
			global::java.net.Socket._isOutputShutdown11012 = @__env.GetMethodID(global::java.net.Socket.staticClass, "isOutputShutdown", "()Z"); 
			global::java.net.Socket._isInputShutdown11013 = @__env.GetMethodID(global::java.net.Socket.staticClass, "isInputShutdown", "()Z"); 
			global::java.net.Socket._getInetAddress11014 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;"); 
			global::java.net.Socket._getLocalAddress11015 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;"); 
			global::java.net.Socket._getLocalPort11016 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getLocalPort", "()I"); 
			global::java.net.Socket._setTcpNoDelay11017 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setTcpNoDelay", "(Z)V"); 
			global::java.net.Socket._getTcpNoDelay11018 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getTcpNoDelay", "()Z"); 
			global::java.net.Socket._setSoLinger11019 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setSoLinger", "(ZI)V"); 
			global::java.net.Socket._getSoLinger11020 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getSoLinger", "()I"); 
			global::java.net.Socket._sendUrgentData11021 = @__env.GetMethodID(global::java.net.Socket.staticClass, "sendUrgentData", "(I)V"); 
			global::java.net.Socket._setOOBInline11022 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setOOBInline", "(Z)V"); 
			global::java.net.Socket._getOOBInline11023 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getOOBInline", "()Z"); 
			global::java.net.Socket._setKeepAlive11024 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setKeepAlive", "(Z)V"); 
			global::java.net.Socket._getKeepAlive11025 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getKeepAlive", "()Z"); 
			global::java.net.Socket._setTrafficClass11026 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setTrafficClass", "(I)V"); 
			global::java.net.Socket._getTrafficClass11027 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getTrafficClass", "()I"); 
			global::java.net.Socket._setReuseAddress11028 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setReuseAddress", "(Z)V"); 
			global::java.net.Socket._getReuseAddress11029 = @__env.GetMethodID(global::java.net.Socket.staticClass, "getReuseAddress", "()Z"); 
			global::java.net.Socket._setSocketImplFactory11030 = @__env.GetStaticMethodID(global::java.net.Socket.staticClass, "setSocketImplFactory", "(Ljava/net/SocketImplFactory;)V"); 
			global::java.net.Socket._setPerformancePreferences11031 = @__env.GetMethodID(global::java.net.Socket.staticClass, "setPerformancePreferences", "(III)V"); 
			global::java.net.Socket._Socket11032 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "()V"); 
			global::java.net.Socket._Socket11033 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/Proxy;)V"); 
			global::java.net.Socket._Socket11034 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/SocketImpl;)V"); 
			global::java.net.Socket._Socket11035 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;I)V"); 
			global::java.net.Socket._Socket11036 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;I)V"); 
			global::java.net.Socket._Socket11037 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V"); 
			global::java.net.Socket._Socket11038 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V"); 
			global::java.net.Socket._Socket11039 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;IZ)V"); 
			global::java.net.Socket._Socket11040 = @__env.GetMethodID(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;IZ)V"); 
		} 
	} 
} 
