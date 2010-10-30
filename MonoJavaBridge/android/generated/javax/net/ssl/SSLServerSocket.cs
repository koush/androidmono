namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLServerSocket_))]
	public abstract partial class SSLServerSocket : java.net.ServerSocket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLServerSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites29996;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites29997;
		public abstract global::java.lang.String[] getEnabledCipherSuites();
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites29998;
		public abstract void setEnabledCipherSuites(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols29999;
		public abstract global::java.lang.String[] getSupportedProtocols();
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols30000;
		public abstract global::java.lang.String[] getEnabledProtocols();
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols30001;
		public abstract void setEnabledProtocols(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _setUseClientMode30002;
		public abstract void setUseClientMode(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getUseClientMode30003;
		public abstract bool getUseClientMode();
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth30004;
		public abstract void setNeedClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth30005;
		public abstract bool getNeedClientAuth();
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth30006;
		public abstract void setWantClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth30007;
		public abstract bool getWantClientAuth();
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation30008;
		public abstract void setEnableSessionCreation(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation30009;
		public abstract bool getEnableSessionCreation();
		internal static global::MonoJavaBridge.MethodId _SSLServerSocket30010;
		protected SSLServerSocket() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLServerSocket._SSLServerSocket30010.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLServerSocket._SSLServerSocket30010 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._SSLServerSocket30010);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLServerSocket30011;
		protected SSLServerSocket(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLServerSocket._SSLServerSocket30011.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLServerSocket._SSLServerSocket30011 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._SSLServerSocket30011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLServerSocket30012;
		protected SSLServerSocket(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLServerSocket._SSLServerSocket30012.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLServerSocket._SSLServerSocket30012 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._SSLServerSocket30012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLServerSocket30013;
		protected SSLServerSocket(int arg0, int arg1, java.net.InetAddress arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLServerSocket._SSLServerSocket30013.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLServerSocket._SSLServerSocket30013 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "(IILjava/net/InetAddress;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._SSLServerSocket30013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static SSLServerSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLServerSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLServerSocket"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLServerSocket))]
	internal sealed partial class SSLServerSocket_ : javax.net.ssl.SSLServerSocket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SSLServerSocket_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites30014;
		public override global::java.lang.String[] getSupportedCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLServerSocket_._getSupportedCipherSuites30014) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites30015;
		public override global::java.lang.String[] getEnabledCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLServerSocket_._getEnabledCipherSuites30015) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites30016;
		public override void setEnabledCipherSuites(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V", ref global::javax.net.ssl.SSLServerSocket_._setEnabledCipherSuites30016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols30017;
		public override global::java.lang.String[] getSupportedProtocols()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLServerSocket_._getSupportedProtocols30017) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols30018;
		public override global::java.lang.String[] getEnabledProtocols()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLServerSocket_._getEnabledProtocols30018) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols30019;
		public override void setEnabledProtocols(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V", ref global::javax.net.ssl.SSLServerSocket_._setEnabledProtocols30019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUseClientMode30020;
		public override void setUseClientMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "setUseClientMode", "(Z)V", ref global::javax.net.ssl.SSLServerSocket_._setUseClientMode30020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseClientMode30021;
		public override bool getUseClientMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getUseClientMode", "()Z", ref global::javax.net.ssl.SSLServerSocket_._getUseClientMode30021);
		}
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth30022;
		public override void setNeedClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "setNeedClientAuth", "(Z)V", ref global::javax.net.ssl.SSLServerSocket_._setNeedClientAuth30022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth30023;
		public override bool getNeedClientAuth()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getNeedClientAuth", "()Z", ref global::javax.net.ssl.SSLServerSocket_._getNeedClientAuth30023);
		}
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth30024;
		public override void setWantClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "setWantClientAuth", "(Z)V", ref global::javax.net.ssl.SSLServerSocket_._setWantClientAuth30024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth30025;
		public override bool getWantClientAuth()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getWantClientAuth", "()Z", ref global::javax.net.ssl.SSLServerSocket_._getWantClientAuth30025);
		}
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation30026;
		public override void setEnableSessionCreation(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "setEnableSessionCreation", "(Z)V", ref global::javax.net.ssl.SSLServerSocket_._setEnableSessionCreation30026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation30027;
		public override bool getEnableSessionCreation()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getEnableSessionCreation", "()Z", ref global::javax.net.ssl.SSLServerSocket_._getEnableSessionCreation30027);
		}
		static SSLServerSocket_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLServerSocket_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLServerSocket"));
		}
		internal static void InitJNI()
		{
		}
	}
}
