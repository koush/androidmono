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
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites23446;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites23447;
		public abstract global::java.lang.String[] getEnabledCipherSuites();
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites23448;
		public abstract void setEnabledCipherSuites(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols23449;
		public abstract global::java.lang.String[] getSupportedProtocols();
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols23450;
		public abstract global::java.lang.String[] getEnabledProtocols();
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols23451;
		public abstract void setEnabledProtocols(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _setUseClientMode23452;
		public abstract void setUseClientMode(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getUseClientMode23453;
		public abstract bool getUseClientMode();
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth23454;
		public abstract void setNeedClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth23455;
		public abstract bool getNeedClientAuth();
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth23456;
		public abstract void setWantClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth23457;
		public abstract bool getWantClientAuth();
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation23458;
		public abstract void setEnableSessionCreation(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation23459;
		public abstract bool getEnableSessionCreation();
		internal static global::MonoJavaBridge.MethodId _SSLServerSocket23460;
		protected SSLServerSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._SSLServerSocket23460);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLServerSocket23461;
		protected SSLServerSocket(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._SSLServerSocket23461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLServerSocket23462;
		protected SSLServerSocket(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._SSLServerSocket23462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLServerSocket23463;
		protected SSLServerSocket(int arg0, int arg1, java.net.InetAddress arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocket.staticClass, global::javax.net.ssl.SSLServerSocket._SSLServerSocket23463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLServerSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLServerSocket"));
			global::javax.net.ssl.SSLServerSocket._getSupportedCipherSuites23446 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket._getEnabledCipherSuites23447 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket._setEnabledCipherSuites23448 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLServerSocket._getSupportedProtocols23449 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket._getEnabledProtocols23450 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket._setEnabledProtocols23451 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLServerSocket._setUseClientMode23452 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLServerSocket._getUseClientMode23453 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLServerSocket._setNeedClientAuth23454 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLServerSocket._getNeedClientAuth23455 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLServerSocket._setWantClientAuth23456 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLServerSocket._getWantClientAuth23457 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLServerSocket._setEnableSessionCreation23458 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLServerSocket._getEnableSessionCreation23459 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "getEnableSessionCreation", "()Z");
			global::javax.net.ssl.SSLServerSocket._SSLServerSocket23460 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "()V");
			global::javax.net.ssl.SSLServerSocket._SSLServerSocket23461 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "(I)V");
			global::javax.net.ssl.SSLServerSocket._SSLServerSocket23462 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "(II)V");
			global::javax.net.ssl.SSLServerSocket._SSLServerSocket23463 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket.staticClass, "<init>", "(IILjava/net/InetAddress;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLServerSocket))]
	public sealed partial class SSLServerSocket_ : javax.net.ssl.SSLServerSocket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLServerSocket_()
		{
			InitJNI();
		}
		internal SSLServerSocket_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites23464;
		public override global::java.lang.String[] getSupportedCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getSupportedCipherSuites23464)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getSupportedCipherSuites23464)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites23465;
		public override global::java.lang.String[] getEnabledCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getEnabledCipherSuites23465)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getEnabledCipherSuites23465)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites23466;
		public override void setEnabledCipherSuites(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._setEnabledCipherSuites23466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._setEnabledCipherSuites23466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols23467;
		public override global::java.lang.String[] getSupportedProtocols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getSupportedProtocols23467)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getSupportedProtocols23467)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols23468;
		public override global::java.lang.String[] getEnabledProtocols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getEnabledProtocols23468)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getEnabledProtocols23468)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols23469;
		public override void setEnabledProtocols(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._setEnabledProtocols23469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._setEnabledProtocols23469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUseClientMode23470;
		public override void setUseClientMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._setUseClientMode23470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._setUseClientMode23470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseClientMode23471;
		public override bool getUseClientMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getUseClientMode23471);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getUseClientMode23471);
		}
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth23472;
		public override void setNeedClientAuth(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._setNeedClientAuth23472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._setNeedClientAuth23472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth23473;
		public override bool getNeedClientAuth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getNeedClientAuth23473);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getNeedClientAuth23473);
		}
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth23474;
		public override void setWantClientAuth(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._setWantClientAuth23474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._setWantClientAuth23474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth23475;
		public override bool getWantClientAuth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getWantClientAuth23475);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getWantClientAuth23475);
		}
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation23476;
		public override void setEnableSessionCreation(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._setEnableSessionCreation23476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._setEnableSessionCreation23476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation23477;
		public override bool getEnableSessionCreation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_._getEnableSessionCreation23477);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocket_.staticClass, global::javax.net.ssl.SSLServerSocket_._getEnableSessionCreation23477);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLServerSocket_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLServerSocket"));
			global::javax.net.ssl.SSLServerSocket_._getSupportedCipherSuites23464 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket_._getEnabledCipherSuites23465 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket_._setEnabledCipherSuites23466 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLServerSocket_._getSupportedProtocols23467 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket_._getEnabledProtocols23468 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocket_._setEnabledProtocols23469 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLServerSocket_._setUseClientMode23470 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLServerSocket_._getUseClientMode23471 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLServerSocket_._setNeedClientAuth23472 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLServerSocket_._getNeedClientAuth23473 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLServerSocket_._setWantClientAuth23474 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLServerSocket_._getWantClientAuth23475 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLServerSocket_._setEnableSessionCreation23476 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLServerSocket_._getEnableSessionCreation23477 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocket_.staticClass, "getEnableSessionCreation", "()Z");
		}
	}
}
