namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DatagramSocket : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static DatagramSocket() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.net.DatagramSocket), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _close11680; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, global::java.net.DatagramSocket._close11680); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._close11680); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _send11681; 
		public virtual void send(java.net.DatagramPacket arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, global::java.net.DatagramSocket._send11681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._send11681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChannel11682; 
		public virtual global::java.nio.channels.DatagramChannel getChannel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.DatagramChannel>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.DatagramSocket._getChannel11682)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.DatagramChannel>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getChannel11682)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPort11683; 
		public virtual int getPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallIntMethod(this, global::java.net.DatagramSocket._getPort11683); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getPort11683); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect11684; 
		public virtual void connect(java.net.InetAddress arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, global::java.net.DatagramSocket._connect11684, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._connect11684, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect11685; 
		public virtual void connect(java.net.SocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, global::java.net.DatagramSocket._connect11685, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._connect11685, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClosed11686; 
		public virtual bool isClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallBooleanMethod(this, global::java.net.DatagramSocket._isClosed11686); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isClosed11686); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBroadcast11687; 
		public virtual bool getBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallBooleanMethod(this, global::java.net.DatagramSocket._getBroadcast11687); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getBroadcast11687); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bind11688; 
		public virtual void bind(java.net.SocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, global::java.net.DatagramSocket._bind11688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._bind11688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _disconnect11689; 
		public virtual void disconnect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, global::java.net.DatagramSocket._disconnect11689); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._disconnect11689); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isConnected11690; 
		public virtual bool isConnected() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallBooleanMethod(this, global::java.net.DatagramSocket._isConnected11690); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isConnected11690); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalSocketAddress11691; 
		public virtual global::java.net.SocketAddress getLocalSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.DatagramSocket._getLocalSocketAddress11691)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalSocketAddress11691)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReceiveBufferSize11692; 
		public virtual void setReceiveBufferSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, global::java.net.DatagramSocket._setReceiveBufferSize11692, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setReceiveBufferSize11692, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReceiveBufferSize11693; 
		public virtual int getReceiveBufferSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallIntMethod(this, global::java.net.DatagramSocket._getReceiveBufferSize11693); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getReceiveBufferSize11693); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoTimeout11694; 
		public virtual void setSoTimeout(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, global::java.net.DatagramSocket._setSoTimeout11694, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setSoTimeout11694, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSoTimeout11695; 
		public virtual int getSoTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallIntMethod(this, global::java.net.DatagramSocket._getSoTimeout11695); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getSoTimeout11695); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSendBufferSize11696; 
		public virtual void setSendBufferSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, global::java.net.DatagramSocket._setSendBufferSize11696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setSendBufferSize11696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSendBufferSize11697; 
		public virtual int getSendBufferSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallIntMethod(this, global::java.net.DatagramSocket._getSendBufferSize11697); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getSendBufferSize11697); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRemoteSocketAddress11698; 
		public virtual global::java.net.SocketAddress getRemoteSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.DatagramSocket._getRemoteSocketAddress11698)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getRemoteSocketAddress11698)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBound11699; 
		public virtual bool isBound() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallBooleanMethod(this, global::java.net.DatagramSocket._isBound11699); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isBound11699); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInetAddress11700; 
		public virtual global::java.net.InetAddress getInetAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.DatagramSocket._getInetAddress11700)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getInetAddress11700)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalAddress11701; 
		public virtual global::java.net.InetAddress getLocalAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.DatagramSocket._getLocalAddress11701)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalAddress11701)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalPort11702; 
		public virtual int getLocalPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallIntMethod(this, global::java.net.DatagramSocket._getLocalPort11702); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalPort11702); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTrafficClass11703; 
		public virtual void setTrafficClass(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, global::java.net.DatagramSocket._setTrafficClass11703, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setTrafficClass11703, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTrafficClass11704; 
		public virtual int getTrafficClass() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallIntMethod(this, global::java.net.DatagramSocket._getTrafficClass11704); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getTrafficClass11704); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReuseAddress11705; 
		public virtual void setReuseAddress(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, global::java.net.DatagramSocket._setReuseAddress11705, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setReuseAddress11705, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReuseAddress11706; 
		public virtual bool getReuseAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				return @__env.CallBooleanMethod(this, global::java.net.DatagramSocket._getReuseAddress11706); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getReuseAddress11706); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _receive11707; 
		public virtual void receive(java.net.DatagramPacket arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, global::java.net.DatagramSocket._receive11707, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._receive11707, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBroadcast11708; 
		public virtual void setBroadcast(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramSocket)) 
				@__env.CallVoidMethod(this, global::java.net.DatagramSocket._setBroadcast11708, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setBroadcast11708, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDatagramSocketImplFactory11709; 
		public static void setDatagramSocketImplFactory(java.net.DatagramSocketImplFactory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setDatagramSocketImplFactory11709, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramSocket11710; 
		public DatagramSocket()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket11710, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramSocket11711; 
		protected DatagramSocket(java.net.DatagramSocketImpl arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket11711, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramSocket11712; 
		public DatagramSocket(java.net.SocketAddress arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket11712, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramSocket11713; 
		public DatagramSocket(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket11713, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramSocket11714; 
		public DatagramSocket(int arg0, java.net.InetAddress arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket11714, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.DatagramSocket.staticClass = @__class; 
			global::java.net.DatagramSocket._close11680 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "close", "()V"); 
			global::java.net.DatagramSocket._send11681 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "send", "(Ljava/net/DatagramPacket;)V"); 
			global::java.net.DatagramSocket._getChannel11682 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getChannel", "()Ljava/nio/channels/DatagramChannel;"); 
			global::java.net.DatagramSocket._getPort11683 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getPort", "()I"); 
			global::java.net.DatagramSocket._connect11684 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/InetAddress;I)V"); 
			global::java.net.DatagramSocket._connect11685 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/SocketAddress;)V"); 
			global::java.net.DatagramSocket._isClosed11686 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "isClosed", "()Z"); 
			global::java.net.DatagramSocket._getBroadcast11687 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getBroadcast", "()Z"); 
			global::java.net.DatagramSocket._bind11688 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V"); 
			global::java.net.DatagramSocket._disconnect11689 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "disconnect", "()V"); 
			global::java.net.DatagramSocket._isConnected11690 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "isConnected", "()Z"); 
			global::java.net.DatagramSocket._getLocalSocketAddress11691 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;"); 
			global::java.net.DatagramSocket._setReceiveBufferSize11692 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "setReceiveBufferSize", "(I)V"); 
			global::java.net.DatagramSocket._getReceiveBufferSize11693 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getReceiveBufferSize", "()I"); 
			global::java.net.DatagramSocket._setSoTimeout11694 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "setSoTimeout", "(I)V"); 
			global::java.net.DatagramSocket._getSoTimeout11695 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getSoTimeout", "()I"); 
			global::java.net.DatagramSocket._setSendBufferSize11696 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "setSendBufferSize", "(I)V"); 
			global::java.net.DatagramSocket._getSendBufferSize11697 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getSendBufferSize", "()I"); 
			global::java.net.DatagramSocket._getRemoteSocketAddress11698 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getRemoteSocketAddress", "()Ljava/net/SocketAddress;"); 
			global::java.net.DatagramSocket._isBound11699 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "isBound", "()Z"); 
			global::java.net.DatagramSocket._getInetAddress11700 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;"); 
			global::java.net.DatagramSocket._getLocalAddress11701 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;"); 
			global::java.net.DatagramSocket._getLocalPort11702 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getLocalPort", "()I"); 
			global::java.net.DatagramSocket._setTrafficClass11703 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "setTrafficClass", "(I)V"); 
			global::java.net.DatagramSocket._getTrafficClass11704 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getTrafficClass", "()I"); 
			global::java.net.DatagramSocket._setReuseAddress11705 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "setReuseAddress", "(Z)V"); 
			global::java.net.DatagramSocket._getReuseAddress11706 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "getReuseAddress", "()Z"); 
			global::java.net.DatagramSocket._receive11707 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "receive", "(Ljava/net/DatagramPacket;)V"); 
			global::java.net.DatagramSocket._setBroadcast11708 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "setBroadcast", "(Z)V"); 
			global::java.net.DatagramSocket._setDatagramSocketImplFactory11709 = @__env.GetStaticMethodID(global::java.net.DatagramSocket.staticClass, "setDatagramSocketImplFactory", "(Ljava/net/DatagramSocketImplFactory;)V"); 
			global::java.net.DatagramSocket._DatagramSocket11710 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "<init>", "()V"); 
			global::java.net.DatagramSocket._DatagramSocket11711 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/DatagramSocketImpl;)V"); 
			global::java.net.DatagramSocket._DatagramSocket11712 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/SocketAddress;)V"); 
			global::java.net.DatagramSocket._DatagramSocket11713 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "<init>", "(I)V"); 
			global::java.net.DatagramSocket._DatagramSocket11714 = @__env.GetMethodID(global::java.net.DatagramSocket.staticClass, "<init>", "(ILjava/net/InetAddress;)V"); 
		} 
	} 
} 
