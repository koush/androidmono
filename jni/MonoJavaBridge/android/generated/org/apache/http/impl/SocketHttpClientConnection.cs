namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketHttpClientConnection : org.apache.http.impl.AbstractHttpClientConnection, HttpInetConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketHttpClientConnection()
		{
			InitJNI();
		}
		protected SocketHttpClientConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown25927;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._shutdown25927);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._shutdown25927);
		}
		internal static global::MonoJavaBridge.MethodId _close25928;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._close25928);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._close25928);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen25929;
		public override bool isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._isOpen25929);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._isOpen25929);
		}
		internal static global::MonoJavaBridge.MethodId _bind25930;
		protected virtual void bind(java.net.Socket arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._bind25930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._bind25930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress25931;
		public virtual global::java.net.InetAddress getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._getLocalAddress25931)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._getLocalAddress25931)) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort25932;
		public virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._getLocalPort25932);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._getLocalPort25932);
		}
		protected new global::java.net.Socket Socket
		{
			get
			{
				return getSocket();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocket25933;
		protected virtual global::java.net.Socket getSocket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._getSocket25933)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._getSocket25933)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout25934;
		public override void setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._setSocketTimeout25934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._setSocketTimeout25934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout25935;
		public override int getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._getSocketTimeout25935);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._getSocketTimeout25935);
		}
		public new global::java.net.InetAddress RemoteAddress
		{
			get
			{
				return getRemoteAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress25936;
		public virtual global::java.net.InetAddress getRemoteAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._getRemoteAddress25936)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._getRemoteAddress25936)) as java.net.InetAddress;
		}
		public new int RemotePort
		{
			get
			{
				return getRemotePort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort25937;
		public virtual int getRemotePort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._getRemotePort25937);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._getRemotePort25937);
		}
		internal static global::MonoJavaBridge.MethodId _assertOpen25938;
		protected override void assertOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._assertOpen25938);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._assertOpen25938);
		}
		internal static global::MonoJavaBridge.MethodId _assertNotOpen25939;
		protected virtual void assertNotOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._assertNotOpen25939);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._assertNotOpen25939);
		}
		internal static global::MonoJavaBridge.MethodId _createSessionInputBuffer25940;
		protected virtual global::org.apache.http.io.SessionInputBuffer createSessionInputBuffer(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionInputBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._createSessionInputBuffer25940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionInputBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionInputBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._createSessionInputBuffer25940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionInputBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _createSessionOutputBuffer25941;
		protected virtual global::org.apache.http.io.SessionOutputBuffer createSessionOutputBuffer(java.net.Socket arg0, int arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionOutputBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection._createSessionOutputBuffer25941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionOutputBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.io.SessionOutputBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._createSessionOutputBuffer25941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.io.SessionOutputBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _SocketHttpClientConnection25942;
		public SocketHttpClientConnection()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.SocketHttpClientConnection.staticClass, global::org.apache.http.impl.SocketHttpClientConnection._SocketHttpClientConnection25942);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.SocketHttpClientConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/SocketHttpClientConnection"));
			global::org.apache.http.impl.SocketHttpClientConnection._shutdown25927 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.SocketHttpClientConnection._close25928 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "close", "()V");
			global::org.apache.http.impl.SocketHttpClientConnection._isOpen25929 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "isOpen", "()Z");
			global::org.apache.http.impl.SocketHttpClientConnection._bind25930 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "bind", "(Ljava/net/Socket;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.SocketHttpClientConnection._getLocalAddress25931 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.impl.SocketHttpClientConnection._getLocalPort25932 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "getLocalPort", "()I");
			global::org.apache.http.impl.SocketHttpClientConnection._getSocket25933 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "getSocket", "()Ljava/net/Socket;");
			global::org.apache.http.impl.SocketHttpClientConnection._setSocketTimeout25934 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.impl.SocketHttpClientConnection._getSocketTimeout25935 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "getSocketTimeout", "()I");
			global::org.apache.http.impl.SocketHttpClientConnection._getRemoteAddress25936 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.impl.SocketHttpClientConnection._getRemotePort25937 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "getRemotePort", "()I");
			global::org.apache.http.impl.SocketHttpClientConnection._assertOpen25938 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "assertOpen", "()V");
			global::org.apache.http.impl.SocketHttpClientConnection._assertNotOpen25939 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "assertNotOpen", "()V");
			global::org.apache.http.impl.SocketHttpClientConnection._createSessionInputBuffer25940 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "createSessionInputBuffer", "(Ljava/net/Socket;ILorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/SessionInputBuffer;");
			global::org.apache.http.impl.SocketHttpClientConnection._createSessionOutputBuffer25941 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "createSessionOutputBuffer", "(Ljava/net/Socket;ILorg/apache/http/@params/HttpParams;)Lorg/apache/http/io/SessionOutputBuffer;");
			global::org.apache.http.impl.SocketHttpClientConnection._SocketHttpClientConnection25942 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.SocketHttpClientConnection.staticClass, "<init>", "()V");
		}
	}
}
