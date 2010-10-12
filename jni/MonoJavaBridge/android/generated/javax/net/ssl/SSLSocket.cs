namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLSocket_))]
	public abstract partial class SSLSocket : java.net.Socket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLSocket()
		{
			InitJNI();
		}
		protected SSLSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites15999;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		internal static global::MonoJavaBridge.MethodId _getSession16000;
		public abstract global::javax.net.ssl.SSLSession getSession();
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites16001;
		public abstract global::java.lang.String[] getEnabledCipherSuites();
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites16002;
		public abstract void setEnabledCipherSuites(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols16003;
		public abstract global::java.lang.String[] getSupportedProtocols();
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols16004;
		public abstract global::java.lang.String[] getEnabledProtocols();
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols16005;
		public abstract void setEnabledProtocols(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _addHandshakeCompletedListener16006;
		public abstract void addHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0);
		internal static global::MonoJavaBridge.MethodId _removeHandshakeCompletedListener16007;
		public abstract void removeHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0);
		internal static global::MonoJavaBridge.MethodId _startHandshake16008;
		public abstract void startHandshake();
		internal static global::MonoJavaBridge.MethodId _setUseClientMode16009;
		public abstract void setUseClientMode(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getUseClientMode16010;
		public abstract bool getUseClientMode();
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth16011;
		public abstract void setNeedClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth16012;
		public abstract bool getNeedClientAuth();
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth16013;
		public abstract void setWantClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth16014;
		public abstract bool getWantClientAuth();
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation16015;
		public abstract void setEnableSessionCreation(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation16016;
		public abstract bool getEnableSessionCreation();
		internal static global::MonoJavaBridge.MethodId _SSLSocket16017;
		protected SSLSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket16017);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket16018;
		protected SSLSocket(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket16018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket16019;
		protected SSLSocket(java.net.InetAddress arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket16019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket16020;
		protected SSLSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket16020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket16021;
		protected SSLSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket16021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSocket"));
			global::javax.net.ssl.SSLSocket._getSupportedCipherSuites15999 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket._getSession16000 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLSocket._getEnabledCipherSuites16001 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket._setEnabledCipherSuites16002 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLSocket._getSupportedProtocols16003 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket._getEnabledProtocols16004 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket._setEnabledProtocols16005 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLSocket._addHandshakeCompletedListener16006 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "addHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V");
			global::javax.net.ssl.SSLSocket._removeHandshakeCompletedListener16007 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "removeHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V");
			global::javax.net.ssl.SSLSocket._startHandshake16008 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "startHandshake", "()V");
			global::javax.net.ssl.SSLSocket._setUseClientMode16009 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLSocket._getUseClientMode16010 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLSocket._setNeedClientAuth16011 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLSocket._getNeedClientAuth16012 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLSocket._setWantClientAuth16013 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLSocket._getWantClientAuth16014 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLSocket._setEnableSessionCreation16015 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLSocket._getEnableSessionCreation16016 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getEnableSessionCreation", "()Z");
			global::javax.net.ssl.SSLSocket._SSLSocket16017 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "()V");
			global::javax.net.ssl.SSLSocket._SSLSocket16018 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::javax.net.ssl.SSLSocket._SSLSocket16019 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/net/InetAddress;I)V");
			global::javax.net.ssl.SSLSocket._SSLSocket16020 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V");
			global::javax.net.ssl.SSLSocket._SSLSocket16021 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLSocket))]
	public sealed partial class SSLSocket_ : javax.net.ssl.SSLSocket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLSocket_()
		{
			InitJNI();
		}
		internal SSLSocket_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites16022;
		public override global::java.lang.String[] getSupportedCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getSupportedCipherSuites16022)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getSupportedCipherSuites16022)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getSession16023;
		public override global::javax.net.ssl.SSLSession getSession() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getSession16023)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getSession16023)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites16024;
		public override global::java.lang.String[] getEnabledCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getEnabledCipherSuites16024)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getEnabledCipherSuites16024)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites16025;
		public override void setEnabledCipherSuites(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setEnabledCipherSuites16025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setEnabledCipherSuites16025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols16026;
		public override global::java.lang.String[] getSupportedProtocols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getSupportedProtocols16026)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getSupportedProtocols16026)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols16027;
		public override global::java.lang.String[] getEnabledProtocols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getEnabledProtocols16027)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getEnabledProtocols16027)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols16028;
		public override void setEnabledProtocols(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setEnabledProtocols16028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setEnabledProtocols16028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHandshakeCompletedListener16029;
		public override void addHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._addHandshakeCompletedListener16029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._addHandshakeCompletedListener16029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHandshakeCompletedListener16030;
		public override void removeHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._removeHandshakeCompletedListener16030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._removeHandshakeCompletedListener16030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startHandshake16031;
		public override void startHandshake() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._startHandshake16031);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._startHandshake16031);
		}
		internal static global::MonoJavaBridge.MethodId _setUseClientMode16032;
		public override void setUseClientMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setUseClientMode16032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setUseClientMode16032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseClientMode16033;
		public override bool getUseClientMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getUseClientMode16033);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getUseClientMode16033);
		}
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth16034;
		public override void setNeedClientAuth(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setNeedClientAuth16034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setNeedClientAuth16034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth16035;
		public override bool getNeedClientAuth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getNeedClientAuth16035);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getNeedClientAuth16035);
		}
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth16036;
		public override void setWantClientAuth(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setWantClientAuth16036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setWantClientAuth16036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth16037;
		public override bool getWantClientAuth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getWantClientAuth16037);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getWantClientAuth16037);
		}
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation16038;
		public override void setEnableSessionCreation(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setEnableSessionCreation16038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setEnableSessionCreation16038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation16039;
		public override bool getEnableSessionCreation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getEnableSessionCreation16039);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getEnableSessionCreation16039);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSocket_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSocket"));
			global::javax.net.ssl.SSLSocket_._getSupportedCipherSuites16022 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket_._getSession16023 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLSocket_._getEnabledCipherSuites16024 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket_._setEnabledCipherSuites16025 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLSocket_._getSupportedProtocols16026 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket_._getEnabledProtocols16027 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket_._setEnabledProtocols16028 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLSocket_._addHandshakeCompletedListener16029 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "addHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V");
			global::javax.net.ssl.SSLSocket_._removeHandshakeCompletedListener16030 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "removeHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V");
			global::javax.net.ssl.SSLSocket_._startHandshake16031 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "startHandshake", "()V");
			global::javax.net.ssl.SSLSocket_._setUseClientMode16032 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLSocket_._getUseClientMode16033 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLSocket_._setNeedClientAuth16034 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLSocket_._getNeedClientAuth16035 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLSocket_._setWantClientAuth16036 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLSocket_._getWantClientAuth16037 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLSocket_._setEnableSessionCreation16038 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLSocket_._getEnableSessionCreation16039 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getEnableSessionCreation", "()Z");
		}
	}
}
