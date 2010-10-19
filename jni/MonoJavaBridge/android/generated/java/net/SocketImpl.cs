namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.SocketImpl_))]
	public abstract partial class SocketImpl : java.lang.Object, SocketOptions
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketImpl()
		{
			InitJNI();
		}
		protected SocketImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOption16077;
		public abstract global::java.lang.Object getOption(int arg0);
		internal static global::MonoJavaBridge.MethodId _setOption16078;
		public abstract void setOption(int arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _toString16079;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl._toString16079)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._toString16079)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close16080;
		protected abstract void close();
		internal static global::MonoJavaBridge.MethodId _accept16081;
		protected abstract void accept(java.net.SocketImpl arg0);
		internal static global::MonoJavaBridge.MethodId _getPort16082;
		protected virtual int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.SocketImpl._getPort16082);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getPort16082);
		}
		internal static global::MonoJavaBridge.MethodId _create16083;
		protected abstract void create(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getInputStream16084;
		protected abstract global::java.io.InputStream getInputStream();
		internal static global::MonoJavaBridge.MethodId _available16085;
		protected abstract int available();
		internal static global::MonoJavaBridge.MethodId _connect16086;
		protected abstract void connect(java.net.SocketAddress arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _connect16087;
		protected abstract void connect(java.net.InetAddress arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _connect16088;
		protected abstract void connect(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getOutputStream16089;
		protected abstract global::java.io.OutputStream getOutputStream();
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor16090;
		protected virtual global::java.io.FileDescriptor getFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl._getFileDescriptor16090)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getFileDescriptor16090)) as java.io.FileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _listen16091;
		protected abstract void listen(int arg0);
		internal static global::MonoJavaBridge.MethodId _bind16092;
		protected abstract void bind(java.net.InetAddress arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _shutdownInput16093;
		protected virtual void shutdownInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl._shutdownInput16093);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._shutdownInput16093);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownOutput16094;
		protected virtual void shutdownOutput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl._shutdownOutput16094);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._shutdownOutput16094);
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress16095;
		protected virtual global::java.net.InetAddress getInetAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl._getInetAddress16095)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getInetAddress16095)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort16096;
		protected virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.SocketImpl._getLocalPort16096);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._getLocalPort16096);
		}
		internal static global::MonoJavaBridge.MethodId _sendUrgentData16097;
		protected abstract void sendUrgentData(int arg0);
		internal static global::MonoJavaBridge.MethodId _setPerformancePreferences16098;
		protected virtual void setPerformancePreferences(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl._setPerformancePreferences16098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._setPerformancePreferences16098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _supportsUrgentData16099;
		protected virtual bool supportsUrgentData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.SocketImpl._supportsUrgentData16099);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.SocketImpl.staticClass, global::java.net.SocketImpl._supportsUrgentData16099);
		}
		internal static global::MonoJavaBridge.MethodId _SocketImpl16100;
		public SocketImpl()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketImpl.staticClass, global::java.net.SocketImpl._SocketImpl16100);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketImpl"));
			global::java.net.SocketImpl._getOption16077 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getOption", "(I)Ljava/lang/Object;");
			global::java.net.SocketImpl._setOption16078 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "setOption", "(ILjava/lang/Object;)V");
			global::java.net.SocketImpl._toString16079 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.SocketImpl._close16080 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "close", "()V");
			global::java.net.SocketImpl._accept16081 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "accept", "(Ljava/net/SocketImpl;)V");
			global::java.net.SocketImpl._getPort16082 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getPort", "()I");
			global::java.net.SocketImpl._create16083 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "create", "(Z)V");
			global::java.net.SocketImpl._getInputStream16084 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.net.SocketImpl._available16085 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "available", "()I");
			global::java.net.SocketImpl._connect16086 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "connect", "(Ljava/net/SocketAddress;I)V");
			global::java.net.SocketImpl._connect16087 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "connect", "(Ljava/net/InetAddress;I)V");
			global::java.net.SocketImpl._connect16088 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "connect", "(Ljava/lang/String;I)V");
			global::java.net.SocketImpl._getOutputStream16089 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.net.SocketImpl._getFileDescriptor16090 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::java.net.SocketImpl._listen16091 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "listen", "(I)V");
			global::java.net.SocketImpl._bind16092 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "bind", "(Ljava/net/InetAddress;I)V");
			global::java.net.SocketImpl._shutdownInput16093 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "shutdownInput", "()V");
			global::java.net.SocketImpl._shutdownOutput16094 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "shutdownOutput", "()V");
			global::java.net.SocketImpl._getInetAddress16095 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			global::java.net.SocketImpl._getLocalPort16096 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "getLocalPort", "()I");
			global::java.net.SocketImpl._sendUrgentData16097 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "sendUrgentData", "(I)V");
			global::java.net.SocketImpl._setPerformancePreferences16098 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "setPerformancePreferences", "(III)V");
			global::java.net.SocketImpl._supportsUrgentData16099 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "supportsUrgentData", "()Z");
			global::java.net.SocketImpl._SocketImpl16100 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.SocketImpl))]
	public sealed partial class SocketImpl_ : java.net.SocketImpl
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketImpl_()
		{
			InitJNI();
		}
		internal SocketImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOption16101;
		public override global::java.lang.Object getOption(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl_._getOption16101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._getOption16101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setOption16102;
		public override void setOption(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._setOption16102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._setOption16102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _close16103;
		protected override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._close16103);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._close16103);
		}
		internal static global::MonoJavaBridge.MethodId _accept16104;
		protected override void accept(java.net.SocketImpl arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._accept16104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._accept16104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _create16105;
		protected override void create(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._create16105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._create16105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream16106;
		protected override global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl_._getInputStream16106)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._getInputStream16106)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _available16107;
		protected override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.SocketImpl_._available16107);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._available16107);
		}
		internal static global::MonoJavaBridge.MethodId _connect16108;
		protected override void connect(java.net.SocketAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._connect16108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._connect16108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect16109;
		protected override void connect(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._connect16109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._connect16109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect16110;
		protected override void connect(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._connect16110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._connect16110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream16111;
		protected override global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SocketImpl_._getOutputStream16111)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._getOutputStream16111)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _listen16112;
		protected override void listen(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._listen16112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._listen16112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bind16113;
		protected override void bind(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._bind16113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._bind16113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendUrgentData16114;
		protected override void sendUrgentData(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.SocketImpl_._sendUrgentData16114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.SocketImpl_.staticClass, global::java.net.SocketImpl_._sendUrgentData16114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketImpl"));
			global::java.net.SocketImpl_._getOption16101 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "getOption", "(I)Ljava/lang/Object;");
			global::java.net.SocketImpl_._setOption16102 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "setOption", "(ILjava/lang/Object;)V");
			global::java.net.SocketImpl_._close16103 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "close", "()V");
			global::java.net.SocketImpl_._accept16104 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "accept", "(Ljava/net/SocketImpl;)V");
			global::java.net.SocketImpl_._create16105 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "create", "(Z)V");
			global::java.net.SocketImpl_._getInputStream16106 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.net.SocketImpl_._available16107 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "available", "()I");
			global::java.net.SocketImpl_._connect16108 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "connect", "(Ljava/net/SocketAddress;I)V");
			global::java.net.SocketImpl_._connect16109 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "connect", "(Ljava/net/InetAddress;I)V");
			global::java.net.SocketImpl_._connect16110 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "connect", "(Ljava/lang/String;I)V");
			global::java.net.SocketImpl_._getOutputStream16111 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.net.SocketImpl_._listen16112 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "listen", "(I)V");
			global::java.net.SocketImpl_._bind16113 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "bind", "(Ljava/net/InetAddress;I)V");
			global::java.net.SocketImpl_._sendUrgentData16114 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl_.staticClass, "sendUrgentData", "(I)V");
		}
	}
}
