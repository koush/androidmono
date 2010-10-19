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
		internal static global::MonoJavaBridge.MethodId _toString15999;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ServerSocket._toString15999)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._toString15999)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close16000;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._close16000);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._close16000);
		}
		internal static global::MonoJavaBridge.MethodId _accept16001;
		public virtual global::java.net.Socket accept() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ServerSocket._accept16001)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._accept16001)) as java.net.Socket;
		}
		public new global::java.nio.channels.ServerSocketChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel16002;
		public virtual global::java.nio.channels.ServerSocketChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ServerSocket._getChannel16002)) as java.nio.channels.ServerSocketChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getChannel16002)) as java.nio.channels.ServerSocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _isClosed16003;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.ServerSocket._isClosed16003);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._isClosed16003);
		}
		internal static global::MonoJavaBridge.MethodId _bind16004;
		public virtual void bind(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._bind16004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._bind16004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bind16005;
		public virtual void bind(java.net.SocketAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._bind16005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._bind16005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.net.SocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress16006;
		public virtual global::java.net.SocketAddress getLocalSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ServerSocket._getLocalSocketAddress16006)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getLocalSocketAddress16006)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize16007;
		public virtual void setReceiveBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._setReceiveBufferSize16007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setReceiveBufferSize16007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ReceiveBufferSize
		{
			get
			{
				return getReceiveBufferSize();
			}
			set
			{
				setReceiveBufferSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize16008;
		public virtual int getReceiveBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.ServerSocket._getReceiveBufferSize16008);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getReceiveBufferSize16008);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout16009;
		public virtual void setSoTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._setSoTimeout16009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setSoTimeout16009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SoTimeout
		{
			get
			{
				return getSoTimeout();
			}
			set
			{
				setSoTimeout(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSoTimeout16010;
		public virtual int getSoTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.ServerSocket._getSoTimeout16010);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getSoTimeout16010);
		}
		internal static global::MonoJavaBridge.MethodId _isBound16011;
		public virtual bool isBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.ServerSocket._isBound16011);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._isBound16011);
		}
		public new global::java.net.InetAddress InetAddress
		{
			get
			{
				return getInetAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress16012;
		public virtual global::java.net.InetAddress getInetAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ServerSocket._getInetAddress16012)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getInetAddress16012)) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort16013;
		public virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.ServerSocket._getLocalPort16013);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getLocalPort16013);
		}
		internal static global::MonoJavaBridge.MethodId _setReuseAddress16014;
		public virtual void setReuseAddress(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._setReuseAddress16014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setReuseAddress16014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ReuseAddress
		{
			get
			{
				return getReuseAddress();
			}
			set
			{
				setReuseAddress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReuseAddress16015;
		public virtual bool getReuseAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.ServerSocket._getReuseAddress16015);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getReuseAddress16015);
		}
		internal static global::MonoJavaBridge.MethodId _setPerformancePreferences16016;
		public virtual void setPerformancePreferences(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._setPerformancePreferences16016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setPerformancePreferences16016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _implAccept16017;
		protected virtual void implAccept(java.net.Socket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._implAccept16017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._implAccept16017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSocketFactory16018;
		public static void setSocketFactory(java.net.SocketImplFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setSocketFactory16018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket16019;
		public ServerSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket16019);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket16020;
		public ServerSocket(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket16020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket16021;
		public ServerSocket(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket16021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket16022;
		public ServerSocket(int arg0, int arg1, java.net.InetAddress arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket16022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ServerSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ServerSocket"));
			global::java.net.ServerSocket._toString15999 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.ServerSocket._close16000 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "close", "()V");
			global::java.net.ServerSocket._accept16001 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "accept", "()Ljava/net/Socket;");
			global::java.net.ServerSocket._getChannel16002 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getChannel", "()Ljava/nio/channels/ServerSocketChannel;");
			global::java.net.ServerSocket._isClosed16003 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "isClosed", "()Z");
			global::java.net.ServerSocket._bind16004 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::java.net.ServerSocket._bind16005 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "bind", "(Ljava/net/SocketAddress;I)V");
			global::java.net.ServerSocket._getLocalSocketAddress16006 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.ServerSocket._setReceiveBufferSize16007 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setReceiveBufferSize", "(I)V");
			global::java.net.ServerSocket._getReceiveBufferSize16008 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getReceiveBufferSize", "()I");
			global::java.net.ServerSocket._setSoTimeout16009 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setSoTimeout", "(I)V");
			global::java.net.ServerSocket._getSoTimeout16010 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getSoTimeout", "()I");
			global::java.net.ServerSocket._isBound16011 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "isBound", "()Z");
			global::java.net.ServerSocket._getInetAddress16012 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			global::java.net.ServerSocket._getLocalPort16013 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getLocalPort", "()I");
			global::java.net.ServerSocket._setReuseAddress16014 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setReuseAddress", "(Z)V");
			global::java.net.ServerSocket._getReuseAddress16015 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getReuseAddress", "()Z");
			global::java.net.ServerSocket._setPerformancePreferences16016 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setPerformancePreferences", "(III)V");
			global::java.net.ServerSocket._implAccept16017 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "implAccept", "(Ljava/net/Socket;)V");
			global::java.net.ServerSocket._setSocketFactory16018 = @__env.GetStaticMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setSocketFactory", "(Ljava/net/SocketImplFactory;)V");
			global::java.net.ServerSocket._ServerSocket16019 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "()V");
			global::java.net.ServerSocket._ServerSocket16020 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "(I)V");
			global::java.net.ServerSocket._ServerSocket16021 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "(II)V");
			global::java.net.ServerSocket._ServerSocket16022 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "(IILjava/net/InetAddress;)V");
		}
	}
}
