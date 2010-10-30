namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLServerSocket_))]
	public abstract partial class SSLServerSocket : java.net.ServerSocket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLServerSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.lang.String[] getEnabledCipherSuites();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract void setEnabledCipherSuites(java.lang.String[] arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::java.lang.String[] getSupportedProtocols();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.lang.String[] getEnabledProtocols();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract void setEnabledProtocols(java.lang.String[] arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract void setUseClientMode(bool arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract bool getUseClientMode();
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract void setNeedClientAuth(bool arg0);
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract bool getNeedClientAuth();
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract void setWantClientAuth(bool arg0);
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract bool getWantClientAuth();
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract void setEnableSessionCreation(bool arg0);
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract bool getEnableSessionCreation();
		private static global::MonoJavaBridge.MethodId _m14;
		protected SSLServerSocket() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLServerSocket._m14.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLServerSocket._m14 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._m14);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected SSLServerSocket(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLServerSocket._m15.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLServerSocket._m15 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected SSLServerSocket(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLServerSocket._m16.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLServerSocket._m16 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected SSLServerSocket(int arg0, int arg1, java.net.InetAddress arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLServerSocket._m17.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLServerSocket._m17 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "(IILjava/net/InetAddress;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String[] getSupportedCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLServerSocket_._m0) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String[] getEnabledCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLServerSocket_._m1) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setEnabledCipherSuites(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V", ref global::javax.net.ssl.SSLServerSocket_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.String[] getSupportedProtocols()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLServerSocket_._m3) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.String[] getEnabledProtocols()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLServerSocket_._m4) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void setEnabledProtocols(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V", ref global::javax.net.ssl.SSLServerSocket_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void setUseClientMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "setUseClientMode", "(Z)V", ref global::javax.net.ssl.SSLServerSocket_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool getUseClientMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getUseClientMode", "()Z", ref global::javax.net.ssl.SSLServerSocket_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void setNeedClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "setNeedClientAuth", "(Z)V", ref global::javax.net.ssl.SSLServerSocket_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool getNeedClientAuth()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getNeedClientAuth", "()Z", ref global::javax.net.ssl.SSLServerSocket_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void setWantClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "setWantClientAuth", "(Z)V", ref global::javax.net.ssl.SSLServerSocket_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool getWantClientAuth()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getWantClientAuth", "()Z", ref global::javax.net.ssl.SSLServerSocket_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override void setEnableSessionCreation(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "setEnableSessionCreation", "(Z)V", ref global::javax.net.ssl.SSLServerSocket_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override bool getEnableSessionCreation()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLServerSocket_.staticClass, "getEnableSessionCreation", "()Z", ref global::javax.net.ssl.SSLServerSocket_._m13);
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
