namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Socket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Socket()
		{
			InitJNI();
		}
		protected Socket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString13758;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._toString13758)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._toString13758)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close13759;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._close13759);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._close13759);
		}
		internal static global::MonoJavaBridge.MethodId _getPort13760;
		public virtual int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getPort13760);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getPort13760);
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream13761;
		public virtual global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getInputStream13761)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getInputStream13761)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getChannel13762;
		public virtual global::java.nio.channels.SocketChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getChannel13762)) as java.nio.channels.SocketChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getChannel13762)) as java.nio.channels.SocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect13763;
		public virtual void connect(java.net.SocketAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._connect13763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._connect13763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect13764;
		public virtual void connect(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._connect13764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._connect13764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isClosed13765;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isClosed13765);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isClosed13765);
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream13766;
		public virtual global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getOutputStream13766)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getOutputStream13766)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _bind13767;
		public virtual void bind(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._bind13767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._bind13767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isConnected13768;
		public virtual bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isConnected13768);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isConnected13768);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress13769;
		public virtual global::java.net.SocketAddress getLocalSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getLocalSocketAddress13769)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getLocalSocketAddress13769)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _shutdownInput13770;
		public virtual void shutdownInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._shutdownInput13770);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._shutdownInput13770);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownOutput13771;
		public virtual void shutdownOutput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._shutdownOutput13771);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._shutdownOutput13771);
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize13772;
		public virtual void setReceiveBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setReceiveBufferSize13772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setReceiveBufferSize13772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize13773;
		public virtual int getReceiveBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getReceiveBufferSize13773);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getReceiveBufferSize13773);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout13774;
		public virtual void setSoTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setSoTimeout13774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setSoTimeout13774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSoTimeout13775;
		public virtual int getSoTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getSoTimeout13775);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getSoTimeout13775);
		}
		internal static global::MonoJavaBridge.MethodId _setSendBufferSize13776;
		public virtual void setSendBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setSendBufferSize13776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setSendBufferSize13776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSendBufferSize13777;
		public virtual int getSendBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getSendBufferSize13777);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getSendBufferSize13777);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteSocketAddress13778;
		public virtual global::java.net.SocketAddress getRemoteSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getRemoteSocketAddress13778)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getRemoteSocketAddress13778)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isBound13779;
		public virtual bool isBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isBound13779);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isBound13779);
		}
		internal static global::MonoJavaBridge.MethodId _isOutputShutdown13780;
		public virtual bool isOutputShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isOutputShutdown13780);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isOutputShutdown13780);
		}
		internal static global::MonoJavaBridge.MethodId _isInputShutdown13781;
		public virtual bool isInputShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._isInputShutdown13781);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._isInputShutdown13781);
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress13782;
		public virtual global::java.net.InetAddress getInetAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getInetAddress13782)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getInetAddress13782)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress13783;
		public virtual global::java.net.InetAddress getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Socket._getLocalAddress13783)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getLocalAddress13783)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort13784;
		public virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getLocalPort13784);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getLocalPort13784);
		}
		internal static global::MonoJavaBridge.MethodId _setTcpNoDelay13785;
		public virtual void setTcpNoDelay(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setTcpNoDelay13785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setTcpNoDelay13785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTcpNoDelay13786;
		public virtual bool getTcpNoDelay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getTcpNoDelay13786);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getTcpNoDelay13786);
		}
		internal static global::MonoJavaBridge.MethodId _setSoLinger13787;
		public virtual void setSoLinger(bool arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setSoLinger13787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setSoLinger13787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSoLinger13788;
		public virtual int getSoLinger() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getSoLinger13788);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getSoLinger13788);
		}
		internal static global::MonoJavaBridge.MethodId _sendUrgentData13789;
		public virtual void sendUrgentData(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._sendUrgentData13789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._sendUrgentData13789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOOBInline13790;
		public virtual void setOOBInline(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setOOBInline13790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setOOBInline13790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOOBInline13791;
		public virtual bool getOOBInline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getOOBInline13791);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getOOBInline13791);
		}
		internal static global::MonoJavaBridge.MethodId _setKeepAlive13792;
		public virtual void setKeepAlive(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setKeepAlive13792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setKeepAlive13792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeepAlive13793;
		public virtual bool getKeepAlive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getKeepAlive13793);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getKeepAlive13793);
		}
		internal static global::MonoJavaBridge.MethodId _setTrafficClass13794;
		public virtual void setTrafficClass(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setTrafficClass13794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setTrafficClass13794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTrafficClass13795;
		public virtual int getTrafficClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Socket._getTrafficClass13795);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getTrafficClass13795);
		}
		internal static global::MonoJavaBridge.MethodId _setReuseAddress13796;
		public virtual void setReuseAddress(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setReuseAddress13796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setReuseAddress13796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReuseAddress13797;
		public virtual bool getReuseAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.Socket._getReuseAddress13797);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._getReuseAddress13797);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketImplFactory13798;
		public static void setSocketImplFactory(java.net.SocketImplFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.Socket.staticClass, global::java.net.Socket._setSocketImplFactory13798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPerformancePreferences13799;
		public virtual void setPerformancePreferences(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.Socket._setPerformancePreferences13799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.Socket.staticClass, global::java.net.Socket._setPerformancePreferences13799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _Socket13800;
		public Socket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket13800);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket13801;
		public Socket(java.net.Proxy arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket13801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket13802;
		protected Socket(java.net.SocketImpl arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket13802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket13803;
		public Socket(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket13803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket13804;
		public Socket(java.net.InetAddress arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket13804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket13805;
		public Socket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket13805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket13806;
		public Socket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket13806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket13807;
		public Socket(java.lang.String arg0, int arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket13807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Socket13808;
		public Socket(java.net.InetAddress arg0, int arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Socket.staticClass, global::java.net.Socket._Socket13808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Socket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Socket"));
			global::java.net.Socket._toString13758 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.Socket._close13759 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "close", "()V");
			global::java.net.Socket._getPort13760 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getPort", "()I");
			global::java.net.Socket._getInputStream13761 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.net.Socket._getChannel13762 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getChannel", "()Ljava/nio/channels/SocketChannel;");
			global::java.net.Socket._connect13763 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "connect", "(Ljava/net/SocketAddress;I)V");
			global::java.net.Socket._connect13764 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "connect", "(Ljava/net/SocketAddress;)V");
			global::java.net.Socket._isClosed13765 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isClosed", "()Z");
			global::java.net.Socket._getOutputStream13766 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.net.Socket._bind13767 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::java.net.Socket._isConnected13768 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isConnected", "()Z");
			global::java.net.Socket._getLocalSocketAddress13769 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.Socket._shutdownInput13770 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "shutdownInput", "()V");
			global::java.net.Socket._shutdownOutput13771 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "shutdownOutput", "()V");
			global::java.net.Socket._setReceiveBufferSize13772 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setReceiveBufferSize", "(I)V");
			global::java.net.Socket._getReceiveBufferSize13773 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getReceiveBufferSize", "()I");
			global::java.net.Socket._setSoTimeout13774 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setSoTimeout", "(I)V");
			global::java.net.Socket._getSoTimeout13775 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getSoTimeout", "()I");
			global::java.net.Socket._setSendBufferSize13776 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setSendBufferSize", "(I)V");
			global::java.net.Socket._getSendBufferSize13777 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getSendBufferSize", "()I");
			global::java.net.Socket._getRemoteSocketAddress13778 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getRemoteSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.Socket._isBound13779 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isBound", "()Z");
			global::java.net.Socket._isOutputShutdown13780 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isOutputShutdown", "()Z");
			global::java.net.Socket._isInputShutdown13781 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "isInputShutdown", "()Z");
			global::java.net.Socket._getInetAddress13782 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			global::java.net.Socket._getLocalAddress13783 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::java.net.Socket._getLocalPort13784 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getLocalPort", "()I");
			global::java.net.Socket._setTcpNoDelay13785 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setTcpNoDelay", "(Z)V");
			global::java.net.Socket._getTcpNoDelay13786 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getTcpNoDelay", "()Z");
			global::java.net.Socket._setSoLinger13787 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setSoLinger", "(ZI)V");
			global::java.net.Socket._getSoLinger13788 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getSoLinger", "()I");
			global::java.net.Socket._sendUrgentData13789 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "sendUrgentData", "(I)V");
			global::java.net.Socket._setOOBInline13790 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setOOBInline", "(Z)V");
			global::java.net.Socket._getOOBInline13791 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getOOBInline", "()Z");
			global::java.net.Socket._setKeepAlive13792 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setKeepAlive", "(Z)V");
			global::java.net.Socket._getKeepAlive13793 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getKeepAlive", "()Z");
			global::java.net.Socket._setTrafficClass13794 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setTrafficClass", "(I)V");
			global::java.net.Socket._getTrafficClass13795 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getTrafficClass", "()I");
			global::java.net.Socket._setReuseAddress13796 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setReuseAddress", "(Z)V");
			global::java.net.Socket._getReuseAddress13797 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "getReuseAddress", "()Z");
			global::java.net.Socket._setSocketImplFactory13798 = @__env.GetStaticMethodIDNoThrow(global::java.net.Socket.staticClass, "setSocketImplFactory", "(Ljava/net/SocketImplFactory;)V");
			global::java.net.Socket._setPerformancePreferences13799 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "setPerformancePreferences", "(III)V");
			global::java.net.Socket._Socket13800 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "()V");
			global::java.net.Socket._Socket13801 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/Proxy;)V");
			global::java.net.Socket._Socket13802 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/SocketImpl;)V");
			global::java.net.Socket._Socket13803 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.net.Socket._Socket13804 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;I)V");
			global::java.net.Socket._Socket13805 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V");
			global::java.net.Socket._Socket13806 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V");
			global::java.net.Socket._Socket13807 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/lang/String;IZ)V");
			global::java.net.Socket._Socket13808 = @__env.GetMethodIDNoThrow(global::java.net.Socket.staticClass, "<init>", "(Ljava/net/InetAddress;IZ)V");
		}
	}
}
