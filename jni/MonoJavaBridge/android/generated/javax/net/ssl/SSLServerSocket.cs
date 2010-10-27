namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLServerSocket_))]
	public abstract partial class SSLServerSocket : java.net.ServerSocket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLServerSocket()
		{
			InitJNI();
		}
		protected SSLServerSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites29995;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites29996;
		public abstract global::java.lang.String[] getEnabledCipherSuites();
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites29997;
		public abstract void setEnabledCipherSuites(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols29998;
		public abstract global::java.lang.String[] getSupportedProtocols();
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols29999;
		public abstract global::java.lang.String[] getEnabledProtocols();
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols30000;
		public abstract void setEnabledProtocols(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _setUseClientMode30001;
		public abstract void setUseClientMode(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getUseClientMode30002;
		public abstract bool getUseClientMode();
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth30003;
		public abstract void setNeedClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth30004;
		public abstract bool getNeedClientAuth();
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth30005;
		public abstract void setWantClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth30006;
		public abstract bool getWantClientAuth();
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation30007;
		public abstract void setEnableSessionCreation(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation30008;
		public abstract bool getEnableSessionCreation();
		internal static global::MonoJavaBridge.MethodId _SSLServerSocket30009;
		protected SSLServerSocket() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._SSLServerSocket30009);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLServerSocket30010;
		protected SSLServerSocket(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._SSLServerSocket30010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLServerSocket30011;
		protected SSLServerSocket(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._SSLServerSocket30011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLServerSocket30012;
		protected SSLServerSocket(int arg0, int arg1, java.net.InetAddress arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._SSLServerSocket30012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLServerSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLServerSocket"));
			global::javax.net.ssl.SSLServerSocket._getSupportedCipherSuites29995 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket._getEnabledCipherSuites29996 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket._setEnabledCipherSuites29997 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLServerSocket._getSupportedProtocols29998 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket._getEnabledProtocols29999 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket._setEnabledProtocols30000 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLServerSocket._setUseClientMode30001 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLServerSocket._getUseClientMode30002 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLServerSocket._setNeedClientAuth30003 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLServerSocket._getNeedClientAuth30004 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLServerSocket._setWantClientAuth30005 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLServerSocket._getWantClientAuth30006 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLServerSocket._setEnableSessionCreation30007 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLServerSocket._getEnableSessionCreation30008 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getEnableSessionCreation", "()Z");
			global::javax.net.ssl.SSLServerSocket._SSLServerSocket30009 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "()V");
			global::javax.net.ssl.SSLServerSocket._SSLServerSocket30010 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "(I)V");
			global::javax.net.ssl.SSLServerSocket._SSLServerSocket30011 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "(II)V");
			global::javax.net.ssl.SSLServerSocket._SSLServerSocket30012 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "(IILjava/net/InetAddress;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLServerSocket))]
	internal sealed partial class SSLServerSocket_ : javax.net.ssl.SSLServerSocket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLServerSocket_()
		{
			InitJNI();
		}
		internal SSLServerSocket_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites30013;
		public override global::java.lang.String[] getSupportedCipherSuites()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getSupportedCipherSuites30013)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getSupportedCipherSuites30013)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites30014;
		public override global::java.lang.String[] getEnabledCipherSuites()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getEnabledCipherSuites30014)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getEnabledCipherSuites30014)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites30015;
		public override void setEnabledCipherSuites(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._setEnabledCipherSuites30015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._setEnabledCipherSuites30015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols30016;
		public override global::java.lang.String[] getSupportedProtocols()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getSupportedProtocols30016)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getSupportedProtocols30016)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols30017;
		public override global::java.lang.String[] getEnabledProtocols()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getEnabledProtocols30017)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getEnabledProtocols30017)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols30018;
		public override void setEnabledProtocols(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._setEnabledProtocols30018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._setEnabledProtocols30018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUseClientMode30019;
		public override void setUseClientMode(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._setUseClientMode30019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._setUseClientMode30019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseClientMode30020;
		public override bool getUseClientMode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getUseClientMode30020);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getUseClientMode30020);
		}
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth30021;
		public override void setNeedClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._setNeedClientAuth30021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._setNeedClientAuth30021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth30022;
		public override bool getNeedClientAuth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getNeedClientAuth30022);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getNeedClientAuth30022);
		}
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth30023;
		public override void setWantClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._setWantClientAuth30023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._setWantClientAuth30023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth30024;
		public override bool getWantClientAuth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getWantClientAuth30024);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getWantClientAuth30024);
		}
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation30025;
		public override void setEnableSessionCreation(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._setEnableSessionCreation30025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._setEnableSessionCreation30025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation30026;
		public override bool getEnableSessionCreation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getEnableSessionCreation30026);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getEnableSessionCreation30026);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLServerSocket_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLServerSocket"));
			global::javax.net.ssl.SSLServerSocket_._getSupportedCipherSuites30013 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket_._getEnabledCipherSuites30014 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket_._setEnabledCipherSuites30015 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLServerSocket_._getSupportedProtocols30016 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket_._getEnabledProtocols30017 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket_._setEnabledProtocols30018 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLServerSocket_._setUseClientMode30019 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLServerSocket_._getUseClientMode30020 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLServerSocket_._setNeedClientAuth30021 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLServerSocket_._getNeedClientAuth30022 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLServerSocket_._setWantClientAuth30023 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLServerSocket_._getWantClientAuth30024 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLServerSocket_._setEnableSessionCreation30025 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLServerSocket_._getEnableSessionCreation30026 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getEnableSessionCreation", "()Z");
		}
	}
}
