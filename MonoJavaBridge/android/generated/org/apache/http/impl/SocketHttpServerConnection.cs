namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketHttpServerConnection : org.apache.http.impl.AbstractHttpServerConnection, HttpInetConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SocketHttpServerConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "shutdown", "()V", ref global::org.apache.http.impl.SocketHttpServerConnection._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "close", "()V", ref global::org.apache.http.impl.SocketHttpServerConnection._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "isOpen", "()Z", ref global::org.apache.http.impl.SocketHttpServerConnection._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual void bind(java.net.Socket arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "bind", "(Ljava/net/Socket;Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.impl.SocketHttpServerConnection._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.net.InetAddress getLocalAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.impl.SocketHttpServerConnection._m4) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getLocalPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getLocalPort", "()I", ref global::org.apache.http.impl.SocketHttpServerConnection._m5);
		}
		protected new global::java.net.Socket Socket
		{
			get
			{
				return getSocket();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected virtual global::java.net.Socket getSocket()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getSocket", "()Ljava/net/Socket;", ref global::org.apache.http.impl.SocketHttpServerConnection._m6) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "setSocketTimeout", "(I)V", ref global::org.apache.http.impl.SocketHttpServerConnection._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SocketTimeout
		{
			get
			{
				return getSocketTimeout();
			}
			set
			{
				setSocketTimeout(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override int getSocketTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getSocketTimeout", "()I", ref global::org.apache.http.impl.SocketHttpServerConnection._m8);
		}
		public new global::java.net.InetAddress RemoteAddress
		{
			get
			{
				return getRemoteAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.net.InetAddress getRemoteAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;", ref global::org.apache.http.impl.SocketHttpServerConnection._m9) as java.net.InetAddress;
		}
		public new int RemotePort
		{
			get
			{
				return getRemotePort();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getRemotePort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "getRemotePort", "()I", ref global::org.apache.http.impl.SocketHttpServerConnection._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected override void assertOpen()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "assertOpen", "()V", ref global::org.apache.http.impl.SocketHttpServerConnection._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected virtual void assertNotOpen()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "assertNotOpen", "()V", ref global::org.apache.http.impl.SocketHttpServerConnection._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected virtual global::org.apache.http.io.SessionInputBuffer createHttpDataReceiver(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.io.SessionInputBuffer>(this, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "createHttpDataReceiver", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/SessionInputBuffer;", ref global::org.apache.http.impl.SocketHttpServerConnection._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.io.SessionInputBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected virtual global::org.apache.http.io.SessionOutputBuffer createHttpDataTransmitter(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.io.SessionOutputBuffer>(this, global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "createHttpDataTransmitter", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)Lorg/apache/http/io/SessionOutputBuffer;", ref global::org.apache.http.impl.SocketHttpServerConnection._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.io.SessionOutputBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public SocketHttpServerConnection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.SocketHttpServerConnection._m15.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.SocketHttpServerConnection._m15 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpServerConnection.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.SocketHttpServerConnection.staticClass, global::org.apache.http.impl.SocketHttpServerConnection._m15);
			Init(@__env, handle);
		}
		static SocketHttpServerConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.SocketHttpServerConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/SocketHttpServerConnection"));
		}
	}
}
