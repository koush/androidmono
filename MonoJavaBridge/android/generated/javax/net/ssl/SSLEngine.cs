namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLEngine_))]
	public abstract partial class SSLEngine : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLEngine(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _wrap29912;
		public virtual global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer[] arg0, java.nio.ByteBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLEngine.staticClass, "wrap", "([Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", ref global::javax.net.ssl.SSLEngine._wrap29912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _wrap29913;
		public abstract global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer[] arg0, int arg1, int arg2, java.nio.ByteBuffer arg3);
		internal static global::MonoJavaBridge.MethodId _wrap29914;
		public virtual global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLEngine.staticClass, "wrap", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", ref global::javax.net.ssl.SSLEngine._wrap29914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites29915;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		internal static global::MonoJavaBridge.MethodId _unwrap29916;
		public virtual global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLEngine.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", ref global::javax.net.ssl.SSLEngine._unwrap29916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _unwrap29917;
		public virtual global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLEngine.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", ref global::javax.net.ssl.SSLEngine._unwrap29917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _unwrap29918;
		public abstract global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer[] arg1, int arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _getSession29919;
		public abstract global::javax.net.ssl.SSLSession getSession();
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites29920;
		public abstract global::java.lang.String[] getEnabledCipherSuites();
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites29921;
		public abstract void setEnabledCipherSuites(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols29922;
		public abstract global::java.lang.String[] getSupportedProtocols();
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols29923;
		public abstract global::java.lang.String[] getEnabledProtocols();
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols29924;
		public abstract void setEnabledProtocols(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _setUseClientMode29925;
		public abstract void setUseClientMode(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getUseClientMode29926;
		public abstract bool getUseClientMode();
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth29927;
		public abstract void setNeedClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth29928;
		public abstract bool getNeedClientAuth();
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth29929;
		public abstract void setWantClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth29930;
		public abstract bool getWantClientAuth();
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation29931;
		public abstract void setEnableSessionCreation(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation29932;
		public abstract bool getEnableSessionCreation();
		internal static global::MonoJavaBridge.MethodId _getPeerHost29933;
		public virtual global::java.lang.String getPeerHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLEngine.staticClass, "getPeerHost", "()Ljava/lang/String;", ref global::javax.net.ssl.SSLEngine._getPeerHost29933) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPeerPort29934;
		public virtual int getPeerPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.net.ssl.SSLEngine.staticClass, "getPeerPort", "()I", ref global::javax.net.ssl.SSLEngine._getPeerPort29934);
		}
		internal static global::MonoJavaBridge.MethodId _getDelegatedTask29935;
		public abstract global::java.lang.Runnable getDelegatedTask();
		internal static global::MonoJavaBridge.MethodId _closeInbound29936;
		public abstract void closeInbound();
		internal static global::MonoJavaBridge.MethodId _isInboundDone29937;
		public abstract bool isInboundDone();
		internal static global::MonoJavaBridge.MethodId _closeOutbound29938;
		public abstract void closeOutbound();
		internal static global::MonoJavaBridge.MethodId _isOutboundDone29939;
		public abstract bool isOutboundDone();
		internal static global::MonoJavaBridge.MethodId _beginHandshake29940;
		public abstract void beginHandshake();
		internal static global::MonoJavaBridge.MethodId _getHandshakeStatus29941;
		public abstract global::javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus();
		internal static global::MonoJavaBridge.MethodId _SSLEngine29942;
		protected SSLEngine(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLEngine._SSLEngine29942.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLEngine._SSLEngine29942 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._SSLEngine29942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLEngine29943;
		protected SSLEngine() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLEngine._SSLEngine29943.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLEngine._SSLEngine29943 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._SSLEngine29943);
			Init(@__env, handle);
		}
		static SSLEngine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLEngine.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngine"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLEngine))]
	internal sealed partial class SSLEngine_ : javax.net.ssl.SSLEngine
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SSLEngine_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _wrap29944;
		public override global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer[] arg0, int arg1, int arg2, java.nio.ByteBuffer arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "wrap", "([Ljava/nio/ByteBuffer;IILjava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", ref global::javax.net.ssl.SSLEngine_._wrap29944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites29945;
		public override global::java.lang.String[] getSupportedCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLEngine_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLEngine_._getSupportedCipherSuites29945) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _unwrap29946;
		public override global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer[] arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;II)Ljavax/net/ssl/SSLEngineResult;", ref global::javax.net.ssl.SSLEngine_._unwrap29946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _getSession29947;
		public override global::javax.net.ssl.SSLSession getSession()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSession>(this, global::javax.net.ssl.SSLEngine_.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;", ref global::javax.net.ssl.SSLEngine_._getSession29947) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites29948;
		public override global::java.lang.String[] getEnabledCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLEngine_.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLEngine_._getEnabledCipherSuites29948) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites29949;
		public override void setEnabledCipherSuites(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V", ref global::javax.net.ssl.SSLEngine_._setEnabledCipherSuites29949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols29950;
		public override global::java.lang.String[] getSupportedProtocols()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLEngine_.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLEngine_._getSupportedProtocols29950) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols29951;
		public override global::java.lang.String[] getEnabledProtocols()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLEngine_.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLEngine_._getEnabledProtocols29951) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols29952;
		public override void setEnabledProtocols(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V", ref global::javax.net.ssl.SSLEngine_._setEnabledProtocols29952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUseClientMode29953;
		public override void setUseClientMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "setUseClientMode", "(Z)V", ref global::javax.net.ssl.SSLEngine_._setUseClientMode29953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseClientMode29954;
		public override bool getUseClientMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "getUseClientMode", "()Z", ref global::javax.net.ssl.SSLEngine_._getUseClientMode29954);
		}
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth29955;
		public override void setNeedClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "setNeedClientAuth", "(Z)V", ref global::javax.net.ssl.SSLEngine_._setNeedClientAuth29955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth29956;
		public override bool getNeedClientAuth()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "getNeedClientAuth", "()Z", ref global::javax.net.ssl.SSLEngine_._getNeedClientAuth29956);
		}
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth29957;
		public override void setWantClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "setWantClientAuth", "(Z)V", ref global::javax.net.ssl.SSLEngine_._setWantClientAuth29957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth29958;
		public override bool getWantClientAuth()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "getWantClientAuth", "()Z", ref global::javax.net.ssl.SSLEngine_._getWantClientAuth29958);
		}
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation29959;
		public override void setEnableSessionCreation(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "setEnableSessionCreation", "(Z)V", ref global::javax.net.ssl.SSLEngine_._setEnableSessionCreation29959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation29960;
		public override bool getEnableSessionCreation()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "getEnableSessionCreation", "()Z", ref global::javax.net.ssl.SSLEngine_._getEnableSessionCreation29960);
		}
		internal static global::MonoJavaBridge.MethodId _getDelegatedTask29961;
		public override global::java.lang.Runnable getDelegatedTask()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Runnable>(this, global::javax.net.ssl.SSLEngine_.staticClass, "getDelegatedTask", "()Ljava/lang/Runnable;", ref global::javax.net.ssl.SSLEngine_._getDelegatedTask29961) as java.lang.Runnable;
		}
		internal static global::MonoJavaBridge.MethodId _closeInbound29962;
		public override void closeInbound()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "closeInbound", "()V", ref global::javax.net.ssl.SSLEngine_._closeInbound29962);
		}
		internal static global::MonoJavaBridge.MethodId _isInboundDone29963;
		public override bool isInboundDone()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "isInboundDone", "()Z", ref global::javax.net.ssl.SSLEngine_._isInboundDone29963);
		}
		internal static global::MonoJavaBridge.MethodId _closeOutbound29964;
		public override void closeOutbound()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "closeOutbound", "()V", ref global::javax.net.ssl.SSLEngine_._closeOutbound29964);
		}
		internal static global::MonoJavaBridge.MethodId _isOutboundDone29965;
		public override bool isOutboundDone()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "isOutboundDone", "()Z", ref global::javax.net.ssl.SSLEngine_._isOutboundDone29965);
		}
		internal static global::MonoJavaBridge.MethodId _beginHandshake29966;
		public override void beginHandshake()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "beginHandshake", "()V", ref global::javax.net.ssl.SSLEngine_._beginHandshake29966);
		}
		internal static global::MonoJavaBridge.MethodId _getHandshakeStatus29967;
		public override global::javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<javax.net.ssl.SSLEngineResult.HandshakeStatus>(this, global::javax.net.ssl.SSLEngine_.staticClass, "getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", ref global::javax.net.ssl.SSLEngine_._getHandshakeStatus29967) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
		}
		static SSLEngine_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLEngine_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngine"));
		}
		internal static void InitJNI()
		{
		}
	}
}
