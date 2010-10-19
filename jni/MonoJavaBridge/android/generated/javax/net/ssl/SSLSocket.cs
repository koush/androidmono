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
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites23519;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		internal static global::MonoJavaBridge.MethodId _getSession23520;
		public abstract global::javax.net.ssl.SSLSession getSession();
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites23521;
		public abstract global::java.lang.String[] getEnabledCipherSuites();
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites23522;
		public abstract void setEnabledCipherSuites(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols23523;
		public abstract global::java.lang.String[] getSupportedProtocols();
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols23524;
		public abstract global::java.lang.String[] getEnabledProtocols();
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols23525;
		public abstract void setEnabledProtocols(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _addHandshakeCompletedListener23526;
		public abstract void addHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0);
		internal static global::MonoJavaBridge.MethodId _removeHandshakeCompletedListener23527;
		public abstract void removeHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0);
		internal static global::MonoJavaBridge.MethodId _startHandshake23528;
		public abstract void startHandshake();
		internal static global::MonoJavaBridge.MethodId _setUseClientMode23529;
		public abstract void setUseClientMode(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getUseClientMode23530;
		public abstract bool getUseClientMode();
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth23531;
		public abstract void setNeedClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth23532;
		public abstract bool getNeedClientAuth();
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth23533;
		public abstract void setWantClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth23534;
		public abstract bool getWantClientAuth();
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation23535;
		public abstract void setEnableSessionCreation(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation23536;
		public abstract bool getEnableSessionCreation();
		internal static global::MonoJavaBridge.MethodId _SSLSocket23537;
		protected SSLSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket23537);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket23538;
		protected SSLSocket(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket23538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket23539;
		protected SSLSocket(java.net.InetAddress arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket23539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket23540;
		protected SSLSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket23540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocket23541;
		protected SSLSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocket.staticClass, global::javax.net.ssl.SSLSocket._SSLSocket23541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSocket"));
			global::javax.net.ssl.SSLSocket._getSupportedCipherSuites23519 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket._getSession23520 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLSocket._getEnabledCipherSuites23521 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket._setEnabledCipherSuites23522 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLSocket._getSupportedProtocols23523 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket._getEnabledProtocols23524 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket._setEnabledProtocols23525 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLSocket._addHandshakeCompletedListener23526 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "addHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V");
			global::javax.net.ssl.SSLSocket._removeHandshakeCompletedListener23527 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "removeHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V");
			global::javax.net.ssl.SSLSocket._startHandshake23528 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "startHandshake", "()V");
			global::javax.net.ssl.SSLSocket._setUseClientMode23529 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLSocket._getUseClientMode23530 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLSocket._setNeedClientAuth23531 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLSocket._getNeedClientAuth23532 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLSocket._setWantClientAuth23533 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLSocket._getWantClientAuth23534 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLSocket._setEnableSessionCreation23535 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLSocket._getEnableSessionCreation23536 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "getEnableSessionCreation", "()Z");
			global::javax.net.ssl.SSLSocket._SSLSocket23537 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "()V");
			global::javax.net.ssl.SSLSocket._SSLSocket23538 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::javax.net.ssl.SSLSocket._SSLSocket23539 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/net/InetAddress;I)V");
			global::javax.net.ssl.SSLSocket._SSLSocket23540 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V");
			global::javax.net.ssl.SSLSocket._SSLSocket23541 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket.staticClass, "<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V");
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
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites23542;
		public override global::java.lang.String[] getSupportedCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getSupportedCipherSuites23542)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getSupportedCipherSuites23542)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getSession23543;
		public override global::javax.net.ssl.SSLSession getSession() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getSession23543)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getSession23543)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites23544;
		public override global::java.lang.String[] getEnabledCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getEnabledCipherSuites23544)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getEnabledCipherSuites23544)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites23545;
		public override void setEnabledCipherSuites(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setEnabledCipherSuites23545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setEnabledCipherSuites23545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols23546;
		public override global::java.lang.String[] getSupportedProtocols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getSupportedProtocols23546)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getSupportedProtocols23546)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols23547;
		public override global::java.lang.String[] getEnabledProtocols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getEnabledProtocols23547)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getEnabledProtocols23547)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols23548;
		public override void setEnabledProtocols(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setEnabledProtocols23548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setEnabledProtocols23548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHandshakeCompletedListener23549;
		public override void addHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._addHandshakeCompletedListener23549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._addHandshakeCompletedListener23549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHandshakeCompletedListener23550;
		public override void removeHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._removeHandshakeCompletedListener23550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._removeHandshakeCompletedListener23550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startHandshake23551;
		public override void startHandshake() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._startHandshake23551);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._startHandshake23551);
		}
		internal static global::MonoJavaBridge.MethodId _setUseClientMode23552;
		public override void setUseClientMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setUseClientMode23552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setUseClientMode23552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseClientMode23553;
		public override bool getUseClientMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getUseClientMode23553);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getUseClientMode23553);
		}
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth23554;
		public override void setNeedClientAuth(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setNeedClientAuth23554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setNeedClientAuth23554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth23555;
		public override bool getNeedClientAuth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getNeedClientAuth23555);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getNeedClientAuth23555);
		}
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth23556;
		public override void setWantClientAuth(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setWantClientAuth23556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setWantClientAuth23556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth23557;
		public override bool getWantClientAuth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getWantClientAuth23557);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getWantClientAuth23557);
		}
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation23558;
		public override void setEnableSessionCreation(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._setEnableSessionCreation23558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._setEnableSessionCreation23558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation23559;
		public override bool getEnableSessionCreation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_._getEnableSessionCreation23559);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLSocket_.staticClass, global::javax.net.ssl.SSLSocket_._getEnableSessionCreation23559);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSocket_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSocket"));
			global::javax.net.ssl.SSLSocket_._getSupportedCipherSuites23542 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket_._getSession23543 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLSocket_._getEnabledCipherSuites23544 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket_._setEnabledCipherSuites23545 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLSocket_._getSupportedProtocols23546 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket_._getEnabledProtocols23547 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocket_._setEnabledProtocols23548 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLSocket_._addHandshakeCompletedListener23549 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "addHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V");
			global::javax.net.ssl.SSLSocket_._removeHandshakeCompletedListener23550 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "removeHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V");
			global::javax.net.ssl.SSLSocket_._startHandshake23551 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "startHandshake", "()V");
			global::javax.net.ssl.SSLSocket_._setUseClientMode23552 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLSocket_._getUseClientMode23553 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLSocket_._setNeedClientAuth23554 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLSocket_._getNeedClientAuth23555 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLSocket_._setWantClientAuth23556 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLSocket_._getWantClientAuth23557 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLSocket_._setEnableSessionCreation23558 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLSocket_._getEnableSessionCreation23559 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocket_.staticClass, "getEnableSessionCreation", "()Z");
		}
	}
}
