namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ServerSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ServerSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.ServerSocket.staticClass, "toString", "()Ljava/lang/String;", ref global::java.net.ServerSocket._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, "close", "()V", ref global::java.net.ServerSocket._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.net.Socket accept()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.ServerSocket.staticClass, "accept", "()Ljava/net/Socket;", ref global::java.net.ServerSocket._m2) as java.net.Socket;
		}
		public new global::java.nio.channels.ServerSocketChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.nio.channels.ServerSocketChannel getChannel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.ServerSocket.staticClass, "getChannel", "()Ljava/nio/channels/ServerSocketChannel;", ref global::java.net.ServerSocket._m3) as java.nio.channels.ServerSocketChannel;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.ServerSocket.staticClass, "isClosed", "()Z", ref global::java.net.ServerSocket._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void bind(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V", ref global::java.net.ServerSocket._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void bind(java.net.SocketAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, "bind", "(Ljava/net/SocketAddress;I)V", ref global::java.net.ServerSocket._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.net.SocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.net.SocketAddress getLocalSocketAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.ServerSocket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;", ref global::java.net.ServerSocket._m7) as java.net.SocketAddress;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setReceiveBufferSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, "setReceiveBufferSize", "(I)V", ref global::java.net.ServerSocket._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getReceiveBufferSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.ServerSocket.staticClass, "getReceiveBufferSize", "()I", ref global::java.net.ServerSocket._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setSoTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, "setSoTimeout", "(I)V", ref global::java.net.ServerSocket._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getSoTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.ServerSocket.staticClass, "getSoTimeout", "()I", ref global::java.net.ServerSocket._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool isBound()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.ServerSocket.staticClass, "isBound", "()Z", ref global::java.net.ServerSocket._m12);
		}
		public new global::java.net.InetAddress InetAddress
		{
			get
			{
				return getInetAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.net.InetAddress getInetAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.ServerSocket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;", ref global::java.net.ServerSocket._m13) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int getLocalPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.ServerSocket.staticClass, "getLocalPort", "()I", ref global::java.net.ServerSocket._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setReuseAddress(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, "setReuseAddress", "(Z)V", ref global::java.net.ServerSocket._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool getReuseAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.ServerSocket.staticClass, "getReuseAddress", "()Z", ref global::java.net.ServerSocket._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setPerformancePreferences(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, "setPerformancePreferences", "(III)V", ref global::java.net.ServerSocket._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		protected virtual void implAccept(java.net.Socket arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ServerSocket.staticClass, "implAccept", "(Ljava/net/Socket;)V", ref global::java.net.ServerSocket._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.net.SocketImplFactory SocketFactory
		{
			set
			{
				setSocketFactory(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static void setSocketFactory(java.net.SocketImplFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._m19.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._m19 = @__env.GetStaticMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setSocketFactory", "(Ljava/net/SocketImplFactory;)V");
			@__env.CallStaticVoidMethod(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public ServerSocket() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._m20.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._m20 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._m20);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public ServerSocket(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._m21.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._m21 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public ServerSocket(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._m22.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._m22 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public ServerSocket(int arg0, int arg1, java.net.InetAddress arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ServerSocket._m23.native == global::System.IntPtr.Zero)
				global::java.net.ServerSocket._m23 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "(IILjava/net/InetAddress;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ServerSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ServerSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ServerSocket"));
		}
	}
}
