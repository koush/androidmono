namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DatagramSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatagramSocket()
		{
			InitJNI();
		}
		protected DatagramSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close13603;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._close13603);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._close13603);
		}
		internal static global::MonoJavaBridge.MethodId _send13604;
		public virtual void send(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._send13604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._send13604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPort13605;
		public virtual int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getPort13605);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getPort13605);
		}
		internal static global::MonoJavaBridge.MethodId _getChannel13606;
		public virtual global::java.nio.channels.DatagramChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getChannel13606)) as java.nio.channels.DatagramChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getChannel13606)) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect13607;
		public virtual void connect(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._connect13607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._connect13607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connect13608;
		public virtual void connect(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._connect13608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._connect13608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isClosed13609;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._isClosed13609);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isClosed13609);
		}
		internal static global::MonoJavaBridge.MethodId _getBroadcast13610;
		public virtual bool getBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._getBroadcast13610);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getBroadcast13610);
		}
		internal static global::MonoJavaBridge.MethodId _bind13611;
		public virtual void bind(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._bind13611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._bind13611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _disconnect13612;
		public virtual void disconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._disconnect13612);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._disconnect13612);
		}
		internal static global::MonoJavaBridge.MethodId _isConnected13613;
		public virtual bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._isConnected13613);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isConnected13613);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress13614;
		public virtual global::java.net.SocketAddress getLocalSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getLocalSocketAddress13614)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalSocketAddress13614)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize13615;
		public virtual void setReceiveBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setReceiveBufferSize13615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setReceiveBufferSize13615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize13616;
		public virtual int getReceiveBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getReceiveBufferSize13616);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getReceiveBufferSize13616);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout13617;
		public virtual void setSoTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setSoTimeout13617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setSoTimeout13617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSoTimeout13618;
		public virtual int getSoTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getSoTimeout13618);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getSoTimeout13618);
		}
		internal static global::MonoJavaBridge.MethodId _setSendBufferSize13619;
		public virtual void setSendBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setSendBufferSize13619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setSendBufferSize13619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSendBufferSize13620;
		public virtual int getSendBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getSendBufferSize13620);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getSendBufferSize13620);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteSocketAddress13621;
		public virtual global::java.net.SocketAddress getRemoteSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getRemoteSocketAddress13621)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getRemoteSocketAddress13621)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isBound13622;
		public virtual bool isBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._isBound13622);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isBound13622);
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress13623;
		public virtual global::java.net.InetAddress getInetAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getInetAddress13623)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getInetAddress13623)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress13624;
		public virtual global::java.net.InetAddress getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getLocalAddress13624)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalAddress13624)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort13625;
		public virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getLocalPort13625);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalPort13625);
		}
		internal static global::MonoJavaBridge.MethodId _setTrafficClass13626;
		public virtual void setTrafficClass(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setTrafficClass13626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setTrafficClass13626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTrafficClass13627;
		public virtual int getTrafficClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getTrafficClass13627);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getTrafficClass13627);
		}
		internal static global::MonoJavaBridge.MethodId _setReuseAddress13628;
		public virtual void setReuseAddress(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setReuseAddress13628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setReuseAddress13628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReuseAddress13629;
		public virtual bool getReuseAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._getReuseAddress13629);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getReuseAddress13629);
		}
		internal static global::MonoJavaBridge.MethodId _receive13630;
		public virtual void receive(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._receive13630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._receive13630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBroadcast13631;
		public virtual void setBroadcast(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setBroadcast13631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setBroadcast13631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDatagramSocketImplFactory13632;
		public static void setDatagramSocketImplFactory(java.net.DatagramSocketImplFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setDatagramSocketImplFactory13632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket13633;
		public DatagramSocket(java.net.SocketAddress arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket13633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket13634;
		public DatagramSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket13634);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket13635;
		protected DatagramSocket(java.net.DatagramSocketImpl arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket13635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket13636;
		public DatagramSocket(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket13636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket13637;
		public DatagramSocket(int arg0, java.net.InetAddress arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket13637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocket"));
			global::java.net.DatagramSocket._close13603 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "close", "()V");
			global::java.net.DatagramSocket._send13604 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "send", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocket._getPort13605 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getPort", "()I");
			global::java.net.DatagramSocket._getChannel13606 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getChannel", "()Ljava/nio/channels/DatagramChannel;");
			global::java.net.DatagramSocket._connect13607 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramSocket._connect13608 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/InetAddress;I)V");
			global::java.net.DatagramSocket._isClosed13609 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "isClosed", "()Z");
			global::java.net.DatagramSocket._getBroadcast13610 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getBroadcast", "()Z");
			global::java.net.DatagramSocket._bind13611 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramSocket._disconnect13612 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "disconnect", "()V");
			global::java.net.DatagramSocket._isConnected13613 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "isConnected", "()Z");
			global::java.net.DatagramSocket._getLocalSocketAddress13614 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.DatagramSocket._setReceiveBufferSize13615 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setReceiveBufferSize", "(I)V");
			global::java.net.DatagramSocket._getReceiveBufferSize13616 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getReceiveBufferSize", "()I");
			global::java.net.DatagramSocket._setSoTimeout13617 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setSoTimeout", "(I)V");
			global::java.net.DatagramSocket._getSoTimeout13618 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getSoTimeout", "()I");
			global::java.net.DatagramSocket._setSendBufferSize13619 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setSendBufferSize", "(I)V");
			global::java.net.DatagramSocket._getSendBufferSize13620 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getSendBufferSize", "()I");
			global::java.net.DatagramSocket._getRemoteSocketAddress13621 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getRemoteSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.DatagramSocket._isBound13622 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "isBound", "()Z");
			global::java.net.DatagramSocket._getInetAddress13623 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			global::java.net.DatagramSocket._getLocalAddress13624 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::java.net.DatagramSocket._getLocalPort13625 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getLocalPort", "()I");
			global::java.net.DatagramSocket._setTrafficClass13626 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setTrafficClass", "(I)V");
			global::java.net.DatagramSocket._getTrafficClass13627 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getTrafficClass", "()I");
			global::java.net.DatagramSocket._setReuseAddress13628 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setReuseAddress", "(Z)V");
			global::java.net.DatagramSocket._getReuseAddress13629 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getReuseAddress", "()Z");
			global::java.net.DatagramSocket._receive13630 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "receive", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocket._setBroadcast13631 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setBroadcast", "(Z)V");
			global::java.net.DatagramSocket._setDatagramSocketImplFactory13632 = @__env.GetStaticMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setDatagramSocketImplFactory", "(Ljava/net/DatagramSocketImplFactory;)V");
			global::java.net.DatagramSocket._DatagramSocket13633 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramSocket._DatagramSocket13634 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "()V");
			global::java.net.DatagramSocket._DatagramSocket13635 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/DatagramSocketImpl;)V");
			global::java.net.DatagramSocket._DatagramSocket13636 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(I)V");
			global::java.net.DatagramSocket._DatagramSocket13637 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(ILjava/net/InetAddress;)V");
		}
	}
}
