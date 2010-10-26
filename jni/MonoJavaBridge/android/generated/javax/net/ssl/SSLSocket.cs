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
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites30068;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		internal static global::MonoJavaBridge.MethodId _getSession30069;
		public abstract global::javax.net.ssl.SSLSession getSession();
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites30070;
		public abstract global::java.lang.String[] getEnabledCipherSuites();
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites30071;
		public abstract void setEnabledCipherSuites(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols30072;
		public abstract global::java.lang.String[] getSupportedProtocols();
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols30073;
		public abstract global::java.lang.String[] getEnabledProtocols();
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols30074;
		public abstract void setEnabledProtocols(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _addHandshakeCompletedListener30075;
		public abstract void addHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0);
		internal static global::MonoJavaBridge.MethodId _removeHandshakeCompletedListener30076;
		public abstract void removeHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0);
		internal static global::MonoJavaBridge.MethodId _startHandshake30077;
		public abstract void startHandshake();
		internal static global::MonoJavaBridge.MethodId _setUseClientMode30078;
		public abstract void setUseClientMode(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getUseClientMode30079;
		public abstract bool getUseClientMode();
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth30080;
		public abstract void setNeedClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth30081;
		public abstract bool getNeedClientAuth();
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth30082;
		public abstract void setWantClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth30083;
		public abstract bool getWantClientAuth();
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation30084;
		public abstract void setEnableSessionCreation(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation30085;
		public abstract bool getEnableSessionCreation();
		internal static global::MonoJavaBridge.MethodId _SSLSocket30086;
		protected SSLSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket30086);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket30087;
		protected SSLSocket(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket30087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket30088;
		protected SSLSocket(java.net.InetAddress arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket30088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket30089;
		protected SSLSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket30089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket30090;
		protected SSLSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket30090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSocket"));
			global::javax.net.ssl.SSLSocket._getSupportedCipherSuites30068 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket._getSession30069 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLSocket._getEnabledCipherSuites30070 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket._setEnabledCipherSuites30071 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLSocket._getSupportedProtocols30072 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket._getEnabledProtocols30073 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket._setEnabledProtocols30074 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLSocket._addHandshakeCompletedListener30075 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "addHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V");
			global::javax.net.ssl.SSLSocket._removeHandshakeCompletedListener30076 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "removeHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V");
			global::javax.net.ssl.SSLSocket._startHandshake30077 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "startHandshake", "()V");
			global::javax.net.ssl.SSLSocket._setUseClientMode30078 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLSocket._getUseClientMode30079 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLSocket._setNeedClientAuth30080 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLSocket._getNeedClientAuth30081 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLSocket._setWantClientAuth30082 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLSocket._getWantClientAuth30083 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLSocket._setEnableSessionCreation30084 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLSocket._getEnableSessionCreation30085 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getEnableSessionCreation", "()Z");
			global::javax.net.ssl.SSLSocket._SSLSocket30086 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "()V");
			global::javax.net.ssl.SSLSocket._SSLSocket30087 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::javax.net.ssl.SSLSocket._SSLSocket30088 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/net/InetAddress;I)V");
			global::javax.net.ssl.SSLSocket._SSLSocket30089 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V");
			global::javax.net.ssl.SSLSocket._SSLSocket30090 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLSocket))]
	internal sealed partial class SSLSocket_ : javax.net.ssl.SSLSocket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLSocket_()
		{
			InitJNI();
		}
		internal SSLSocket_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites30091;
		public override global::java.lang.String[] getSupportedCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getSupportedCipherSuites30091)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getSupportedCipherSuites30091)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getSession30092;
		public override global::javax.net.ssl.SSLSession getSession() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getSession30092)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getSession30092)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites30093;
		public override global::java.lang.String[] getEnabledCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getEnabledCipherSuites30093)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getEnabledCipherSuites30093)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites30094;
		public override void setEnabledCipherSuites(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setEnabledCipherSuites30094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setEnabledCipherSuites30094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols30095;
		public override global::java.lang.String[] getSupportedProtocols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getSupportedProtocols30095)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getSupportedProtocols30095)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols30096;
		public override global::java.lang.String[] getEnabledProtocols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getEnabledProtocols30096)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getEnabledProtocols30096)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols30097;
		public override void setEnabledProtocols(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setEnabledProtocols30097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setEnabledProtocols30097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHandshakeCompletedListener30098;
		public override void addHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._addHandshakeCompletedListener30098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._addHandshakeCompletedListener30098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHandshakeCompletedListener30099;
		public override void removeHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._removeHandshakeCompletedListener30099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._removeHandshakeCompletedListener30099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startHandshake30100;
		public override void startHandshake() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._startHandshake30100);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._startHandshake30100);
		}
		internal static global::MonoJavaBridge.MethodId _setUseClientMode30101;
		public override void setUseClientMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setUseClientMode30101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setUseClientMode30101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseClientMode30102;
		public override bool getUseClientMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getUseClientMode30102);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getUseClientMode30102);
		}
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth30103;
		public override void setNeedClientAuth(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setNeedClientAuth30103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setNeedClientAuth30103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth30104;
		public override bool getNeedClientAuth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getNeedClientAuth30104);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getNeedClientAuth30104);
		}
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth30105;
		public override void setWantClientAuth(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setWantClientAuth30105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setWantClientAuth30105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth30106;
		public override bool getWantClientAuth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getWantClientAuth30106);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getWantClientAuth30106);
		}
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation30107;
		public override void setEnableSessionCreation(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setEnableSessionCreation30107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setEnableSessionCreation30107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation30108;
		public override bool getEnableSessionCreation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getEnableSessionCreation30108);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getEnableSessionCreation30108);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSocket_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSocket"));
			global::javax.net.ssl.SSLSocket_._getSupportedCipherSuites30091 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket_._getSession30092 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLSocket_._getEnabledCipherSuites30093 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket_._setEnabledCipherSuites30094 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLSocket_._getSupportedProtocols30095 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket_._getEnabledProtocols30096 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket_._setEnabledProtocols30097 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLSocket_._addHandshakeCompletedListener30098 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "addHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V");
			global::javax.net.ssl.SSLSocket_._removeHandshakeCompletedListener30099 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "removeHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V");
			global::javax.net.ssl.SSLSocket_._startHandshake30100 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "startHandshake", "()V");
			global::javax.net.ssl.SSLSocket_._setUseClientMode30101 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLSocket_._getUseClientMode30102 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLSocket_._setNeedClientAuth30103 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLSocket_._getNeedClientAuth30104 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLSocket_._setWantClientAuth30105 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLSocket_._getWantClientAuth30106 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLSocket_._setEnableSessionCreation30107 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLSocket_._getEnableSessionCreation30108 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getEnableSessionCreation", "()Z");
		}
	}
}
