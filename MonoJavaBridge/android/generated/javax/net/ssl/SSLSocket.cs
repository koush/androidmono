namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLSocket_))]
	public abstract partial class SSLSocket : java.net.Socket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::javax.net.ssl.SSLSession getSession();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.lang.String[] getEnabledCipherSuites();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void setEnabledCipherSuites(java.lang.String[] arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.lang.String[] getSupportedProtocols();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.lang.String[] getEnabledProtocols();
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract void setEnabledProtocols(java.lang.String[] arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract void addHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0);
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract void removeHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0);
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract void startHandshake();
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract void setUseClientMode(bool arg0);
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract bool getUseClientMode();
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract void setNeedClientAuth(bool arg0);
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract bool getNeedClientAuth();
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract void setWantClientAuth(bool arg0);
		private static global::MonoJavaBridge.MethodId _m15;
		public abstract bool getWantClientAuth();
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract void setEnableSessionCreation(bool arg0);
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract bool getEnableSessionCreation();
		private static global::MonoJavaBridge.MethodId _m18;
		protected SSLSocket() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket._m18.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket._m18 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._m18);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected SSLSocket(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket._m19.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket._m19 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		protected SSLSocket(java.net.InetAddress arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket._m20.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket._m20 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/net/InetAddress;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		protected SSLSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket._m21.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket._m21 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		protected SSLSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocket._m22.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocket._m22 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static SSLSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSocket"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLSocket))]
	internal sealed partial class SSLSocket_ : javax.net.ssl.SSLSocket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SSLSocket_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String[] getSupportedCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLSocket_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLSocket_._m0) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::javax.net.ssl.SSLSession getSession()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSession>(this, global::javax.net.ssl.SSLSocket_.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;", ref global::javax.net.ssl.SSLSocket_._m1) as javax.net.ssl.SSLSession;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String[] getEnabledCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLSocket_.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLSocket_._m2) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setEnabledCipherSuites(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSocket_.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V", ref global::javax.net.ssl.SSLSocket_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.String[] getSupportedProtocols()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLSocket_.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLSocket_._m4) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.lang.String[] getEnabledProtocols()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLSocket_.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLSocket_._m5) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void setEnabledProtocols(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSocket_.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V", ref global::javax.net.ssl.SSLSocket_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void addHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSocket_.staticClass, "addHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V", ref global::javax.net.ssl.SSLSocket_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void removeHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSocket_.staticClass, "removeHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V", ref global::javax.net.ssl.SSLSocket_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void startHandshake()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSocket_.staticClass, "startHandshake", "()V", ref global::javax.net.ssl.SSLSocket_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void setUseClientMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSocket_.staticClass, "setUseClientMode", "(Z)V", ref global::javax.net.ssl.SSLSocket_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool getUseClientMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLSocket_.staticClass, "getUseClientMode", "()Z", ref global::javax.net.ssl.SSLSocket_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override void setNeedClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSocket_.staticClass, "setNeedClientAuth", "(Z)V", ref global::javax.net.ssl.SSLSocket_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override bool getNeedClientAuth()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLSocket_.staticClass, "getNeedClientAuth", "()Z", ref global::javax.net.ssl.SSLSocket_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override void setWantClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSocket_.staticClass, "setWantClientAuth", "(Z)V", ref global::javax.net.ssl.SSLSocket_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override bool getWantClientAuth()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLSocket_.staticClass, "getWantClientAuth", "()Z", ref global::javax.net.ssl.SSLSocket_._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override void setEnableSessionCreation(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSocket_.staticClass, "setEnableSessionCreation", "(Z)V", ref global::javax.net.ssl.SSLSocket_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override bool getEnableSessionCreation()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLSocket_.staticClass, "getEnableSessionCreation", "()Z", ref global::javax.net.ssl.SSLSocket_._m17);
		}
		static SSLSocket_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSocket_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSocket"));
		}
	}
}
