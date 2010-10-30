namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLSocket_))]
	public abstract partial class SSLSocket : java.net.Socket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites30069;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		internal static global::MonoJavaBridge.MethodId _getSession30070;
		public abstract global::javax.net.ssl.SSLSession getSession();
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites30071;
		public abstract global::java.lang.String[] getEnabledCipherSuites();
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites30072;
		public abstract void setEnabledCipherSuites(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols30073;
		public abstract global::java.lang.String[] getSupportedProtocols();
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols30074;
		public abstract global::java.lang.String[] getEnabledProtocols();
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols30075;
		public abstract void setEnabledProtocols(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _addHandshakeCompletedListener30076;
		public abstract void addHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0);
		internal static global::MonoJavaBridge.MethodId _removeHandshakeCompletedListener30077;
		public abstract void removeHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0);
		internal static global::MonoJavaBridge.MethodId _startHandshake30078;
		public abstract void startHandshake();
		internal static global::MonoJavaBridge.MethodId _setUseClientMode30079;
		public abstract void setUseClientMode(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getUseClientMode30080;
		public abstract bool getUseClientMode();
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth30081;
		public abstract void setNeedClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth30082;
		public abstract bool getNeedClientAuth();
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth30083;
		public abstract void setWantClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth30084;
		public abstract bool getWantClientAuth();
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation30085;
		public abstract void setEnableSessionCreation(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation30086;
		public abstract bool getEnableSessionCreation();
		internal static global::MonoJavaBridge.MethodId _SSLSocket30087;
		protected SSLSocket() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket._SSLSocket30087.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket._SSLSocket30087 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket30087);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket30088;
		protected SSLSocket(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket._SSLSocket30088.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket._SSLSocket30088 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket30088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket30089;
		protected SSLSocket(java.net.InetAddress arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket._SSLSocket30089.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket._SSLSocket30089 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/net/InetAddress;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket30089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket30090;
		protected SSLSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket._SSLSocket30090.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket._SSLSocket30090 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket30090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket30091;
		protected SSLSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket._SSLSocket30091.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket._SSLSocket30091 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket30091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static SSLSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSocket"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLSocket))]
	internal sealed partial class SSLSocket_ : javax.net.ssl.SSLSocket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SSLSocket_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites30092;
		public override global::java.lang.String[] getSupportedCipherSuites()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._getSupportedCipherSuites30092.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._getSupportedCipherSuites30092 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getSupportedCipherSuites30092)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getSession30093;
		public override global::javax.net.ssl.SSLSession getSession()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._getSession30093.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._getSession30093 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getSession30093)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites30094;
		public override global::java.lang.String[] getEnabledCipherSuites()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._getEnabledCipherSuites30094.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._getEnabledCipherSuites30094 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getEnabledCipherSuites30094)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites30095;
		public override void setEnabledCipherSuites(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._setEnabledCipherSuites30095.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._setEnabledCipherSuites30095 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setEnabledCipherSuites30095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols30096;
		public override global::java.lang.String[] getSupportedProtocols()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._getSupportedProtocols30096.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._getSupportedProtocols30096 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getSupportedProtocols30096)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols30097;
		public override global::java.lang.String[] getEnabledProtocols()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._getEnabledProtocols30097.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._getEnabledProtocols30097 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getEnabledProtocols30097)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols30098;
		public override void setEnabledProtocols(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._setEnabledProtocols30098.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._setEnabledProtocols30098 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setEnabledProtocols30098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHandshakeCompletedListener30099;
		public override void addHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._addHandshakeCompletedListener30099.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._addHandshakeCompletedListener30099 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "addHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._addHandshakeCompletedListener30099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHandshakeCompletedListener30100;
		public override void removeHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._removeHandshakeCompletedListener30100.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._removeHandshakeCompletedListener30100 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "removeHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._removeHandshakeCompletedListener30100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startHandshake30101;
		public override void startHandshake()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._startHandshake30101.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._startHandshake30101 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "startHandshake", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._startHandshake30101);
		}
		internal static global::MonoJavaBridge.MethodId _setUseClientMode30102;
		public override void setUseClientMode(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._setUseClientMode30102.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._setUseClientMode30102 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setUseClientMode", "(Z)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setUseClientMode30102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseClientMode30103;
		public override bool getUseClientMode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._getUseClientMode30103.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._getUseClientMode30103 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getUseClientMode", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getUseClientMode30103);
		}
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth30104;
		public override void setNeedClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._setNeedClientAuth30104.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._setNeedClientAuth30104 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setNeedClientAuth", "(Z)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setNeedClientAuth30104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth30105;
		public override bool getNeedClientAuth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._getNeedClientAuth30105.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._getNeedClientAuth30105 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getNeedClientAuth", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getNeedClientAuth30105);
		}
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth30106;
		public override void setWantClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._setWantClientAuth30106.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._setWantClientAuth30106 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setWantClientAuth", "(Z)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setWantClientAuth30106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth30107;
		public override bool getWantClientAuth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._getWantClientAuth30107.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._getWantClientAuth30107 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getWantClientAuth", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getWantClientAuth30107);
		}
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation30108;
		public override void setEnableSessionCreation(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._setEnableSessionCreation30108.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._setEnableSessionCreation30108 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setEnableSessionCreation", "(Z)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setEnableSessionCreation30108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation30109;
		public override bool getEnableSessionCreation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket_._getEnableSessionCreation30109.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket_._getEnableSessionCreation30109 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getEnableSessionCreation", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getEnableSessionCreation30109);
		}
		static SSLSocket_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSocket_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSocket"));
		}
		internal static void InitJNI()
		{
		}
	}
}
