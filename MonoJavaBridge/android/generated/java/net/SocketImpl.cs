namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.SocketImpl_))]
	public abstract partial class SocketImpl : java.lang.Object, SocketOptions
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SocketImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOption21776;
		public abstract global::java.lang.Object getOption(int arg0);
		internal static global::MonoJavaBridge.MethodId _setOption21777;
		public abstract void setOption(int arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _toString21778;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.SocketImpl.staticClass, "toString", "()Ljava/lang/String;", ref global::java.net.SocketImpl._toString21778) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close21779;
		protected abstract void close();
		internal static global::MonoJavaBridge.MethodId _accept21780;
		protected abstract void accept(java.net.SocketImpl arg0);
		internal static global::MonoJavaBridge.MethodId _getPort21781;
		protected virtual int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.SocketImpl.staticClass, "getPort", "()I", ref global::java.net.SocketImpl._getPort21781);
		}
		internal static global::MonoJavaBridge.MethodId _create21782;
		protected abstract void create(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getInputStream21783;
		protected abstract global::java.io.InputStream getInputStream();
		internal static global::MonoJavaBridge.MethodId _available21784;
		protected abstract int available();
		internal static global::MonoJavaBridge.MethodId _connect21785;
		protected abstract void connect(java.net.SocketAddress arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _connect21786;
		protected abstract void connect(java.net.InetAddress arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _connect21787;
		protected abstract void connect(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getOutputStream21788;
		protected abstract global::java.io.OutputStream getOutputStream();
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor21789;
		protected virtual global::java.io.FileDescriptor getFileDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.io.FileDescriptor>(this, global::java.net.SocketImpl.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;", ref global::java.net.SocketImpl._getFileDescriptor21789) as java.io.FileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _listen21790;
		protected abstract void listen(int arg0);
		internal static global::MonoJavaBridge.MethodId _bind21791;
		protected abstract void bind(java.net.InetAddress arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _shutdownInput21792;
		protected virtual void shutdownInput()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl.staticClass, "shutdownInput", "()V", ref global::java.net.SocketImpl._shutdownInput21792);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownOutput21793;
		protected virtual void shutdownOutput()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl.staticClass, "shutdownOutput", "()V", ref global::java.net.SocketImpl._shutdownOutput21793);
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress21794;
		protected virtual global::java.net.InetAddress getInetAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.SocketImpl.staticClass, "getInetAddress", "()Ljava/net/InetAddress;", ref global::java.net.SocketImpl._getInetAddress21794) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort21795;
		protected virtual int getLocalPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.SocketImpl.staticClass, "getLocalPort", "()I", ref global::java.net.SocketImpl._getLocalPort21795);
		}
		internal static global::MonoJavaBridge.MethodId _sendUrgentData21796;
		protected abstract void sendUrgentData(int arg0);
		internal static global::MonoJavaBridge.MethodId _setPerformancePreferences21797;
		protected virtual void setPerformancePreferences(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl.staticClass, "setPerformancePreferences", "(III)V", ref global::java.net.SocketImpl._setPerformancePreferences21797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _supportsUrgentData21798;
		protected virtual bool supportsUrgentData()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.SocketImpl.staticClass, "supportsUrgentData", "()Z", ref global::java.net.SocketImpl._supportsUrgentData21798);
		}
		internal static global::MonoJavaBridge.MethodId _SocketImpl21799;
		public SocketImpl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.SocketImpl._SocketImpl21799.native == global::System.IntPtr.Zero)
				global::java.net.SocketImpl._SocketImpl21799 = @__env.GetMethodIDNoThrow(global::java.net.SocketImpl.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketImpl.staticClass, global::java.net.SocketImpl._SocketImpl21799);
			Init(@__env, handle);
		}
		static SocketImpl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketImpl"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.SocketImpl))]
	internal sealed partial class SocketImpl_ : java.net.SocketImpl
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SocketImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOption21800;
		public override global::java.lang.Object getOption(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.SocketImpl_.staticClass, "getOption", "(I)Ljava/lang/Object;", ref global::java.net.SocketImpl_._getOption21800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setOption21801;
		public override void setOption(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "setOption", "(ILjava/lang/Object;)V", ref global::java.net.SocketImpl_._setOption21801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _close21802;
		protected override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "close", "()V", ref global::java.net.SocketImpl_._close21802);
		}
		internal static global::MonoJavaBridge.MethodId _accept21803;
		protected override void accept(java.net.SocketImpl arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "accept", "(Ljava/net/SocketImpl;)V", ref global::java.net.SocketImpl_._accept21803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _create21804;
		protected override void create(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "create", "(Z)V", ref global::java.net.SocketImpl_._create21804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream21805;
		protected override global::java.io.InputStream getInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.SocketImpl_.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::java.net.SocketImpl_._getInputStream21805) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _available21806;
		protected override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.SocketImpl_.staticClass, "available", "()I", ref global::java.net.SocketImpl_._available21806);
		}
		internal static global::MonoJavaBridge.MethodId _connect21807;
		protected override void connect(java.net.SocketAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "connect", "(Ljava/net/SocketAddress;I)V", ref global::java.net.SocketImpl_._connect21807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect21808;
		protected override void connect(java.net.InetAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "connect", "(Ljava/net/InetAddress;I)V", ref global::java.net.SocketImpl_._connect21808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect21809;
		protected override void connect(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "connect", "(Ljava/lang/String;I)V", ref global::java.net.SocketImpl_._connect21809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream21810;
		protected override global::java.io.OutputStream getOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.SocketImpl_.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::java.net.SocketImpl_._getOutputStream21810) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _listen21811;
		protected override void listen(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "listen", "(I)V", ref global::java.net.SocketImpl_._listen21811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bind21812;
		protected override void bind(java.net.InetAddress arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "bind", "(Ljava/net/InetAddress;I)V", ref global::java.net.SocketImpl_._bind21812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendUrgentData21813;
		protected override void sendUrgentData(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.SocketImpl_.staticClass, "sendUrgentData", "(I)V", ref global::java.net.SocketImpl_._sendUrgentData21813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SocketImpl_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketImpl"));
		}
		internal static void InitJNI()
		{
		}
	}
}
