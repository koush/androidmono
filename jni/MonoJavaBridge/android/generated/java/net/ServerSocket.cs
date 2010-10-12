namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ServerSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ServerSocket()
		{
			InitJNI();
		}
		protected ServerSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString13734;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ServerSocket._toString13734)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._toString13734)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close13735;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._close13735);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._close13735);
		}
		internal static global::MonoJavaBridge.MethodId _accept13736;
		public virtual global::java.net.Socket accept() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ServerSocket._accept13736)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._accept13736)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _getChannel13737;
		public virtual global::java.nio.channels.ServerSocketChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ServerSocket._getChannel13737)) as java.nio.channels.ServerSocketChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getChannel13737)) as java.nio.channels.ServerSocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _isClosed13738;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.ServerSocket._isClosed13738);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._isClosed13738);
		}
		internal static global::MonoJavaBridge.MethodId _bind13739;
		public virtual void bind(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._bind13739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._bind13739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bind13740;
		public virtual void bind(java.net.SocketAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._bind13740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._bind13740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress13741;
		public virtual global::java.net.SocketAddress getLocalSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ServerSocket._getLocalSocketAddress13741)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getLocalSocketAddress13741)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize13742;
		public virtual void setReceiveBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._setReceiveBufferSize13742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setReceiveBufferSize13742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize13743;
		public virtual int getReceiveBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.ServerSocket._getReceiveBufferSize13743);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getReceiveBufferSize13743);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout13744;
		public virtual void setSoTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._setSoTimeout13744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setSoTimeout13744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSoTimeout13745;
		public virtual int getSoTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.ServerSocket._getSoTimeout13745);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getSoTimeout13745);
		}
		internal static global::MonoJavaBridge.MethodId _isBound13746;
		public virtual bool isBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.ServerSocket._isBound13746);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._isBound13746);
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress13747;
		public virtual global::java.net.InetAddress getInetAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ServerSocket._getInetAddress13747)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getInetAddress13747)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort13748;
		public virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.ServerSocket._getLocalPort13748);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getLocalPort13748);
		}
		internal static global::MonoJavaBridge.MethodId _setReuseAddress13749;
		public virtual void setReuseAddress(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._setReuseAddress13749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setReuseAddress13749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReuseAddress13750;
		public virtual bool getReuseAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.ServerSocket._getReuseAddress13750);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getReuseAddress13750);
		}
		internal static global::MonoJavaBridge.MethodId _setPerformancePreferences13751;
		public virtual void setPerformancePreferences(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._setPerformancePreferences13751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setPerformancePreferences13751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _implAccept13752;
		protected virtual void implAccept(java.net.Socket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._implAccept13752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._implAccept13752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSocketFactory13753;
		public static void setSocketFactory(java.net.SocketImplFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setSocketFactory13753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket13754;
		public ServerSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket13754);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket13755;
		public ServerSocket(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket13755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket13756;
		public ServerSocket(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket13756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket13757;
		public ServerSocket(int arg0, int arg1, java.net.InetAddress arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket13757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ServerSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ServerSocket"));
			global::java.net.ServerSocket._toString13734 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.ServerSocket._close13735 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "close", "()V");
			global::java.net.ServerSocket._accept13736 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "accept", "()Ljava/net/Socket;");
			global::java.net.ServerSocket._getChannel13737 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getChannel", "()Ljava/nio/channels/ServerSocketChannel;");
			global::java.net.ServerSocket._isClosed13738 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "isClosed", "()Z");
			global::java.net.ServerSocket._bind13739 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::java.net.ServerSocket._bind13740 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "bind", "(Ljava/net/SocketAddress;I)V");
			global::java.net.ServerSocket._getLocalSocketAddress13741 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.ServerSocket._setReceiveBufferSize13742 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setReceiveBufferSize", "(I)V");
			global::java.net.ServerSocket._getReceiveBufferSize13743 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getReceiveBufferSize", "()I");
			global::java.net.ServerSocket._setSoTimeout13744 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setSoTimeout", "(I)V");
			global::java.net.ServerSocket._getSoTimeout13745 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getSoTimeout", "()I");
			global::java.net.ServerSocket._isBound13746 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "isBound", "()Z");
			global::java.net.ServerSocket._getInetAddress13747 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			global::java.net.ServerSocket._getLocalPort13748 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getLocalPort", "()I");
			global::java.net.ServerSocket._setReuseAddress13749 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setReuseAddress", "(Z)V");
			global::java.net.ServerSocket._getReuseAddress13750 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getReuseAddress", "()Z");
			global::java.net.ServerSocket._setPerformancePreferences13751 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setPerformancePreferences", "(III)V");
			global::java.net.ServerSocket._implAccept13752 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "implAccept", "(Ljava/net/Socket;)V");
			global::java.net.ServerSocket._setSocketFactory13753 = @__env.GetStaticMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setSocketFactory", "(Ljava/net/SocketImplFactory;)V");
			global::java.net.ServerSocket._ServerSocket13754 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "()V");
			global::java.net.ServerSocket._ServerSocket13755 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "(I)V");
			global::java.net.ServerSocket._ServerSocket13756 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "(II)V");
			global::java.net.ServerSocket._ServerSocket13757 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "(IILjava/net/InetAddress;)V");
		}
	}
}
