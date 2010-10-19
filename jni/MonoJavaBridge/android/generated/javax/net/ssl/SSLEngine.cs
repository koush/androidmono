namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLEngine_))]
	public abstract partial class SSLEngine : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLEngine()
		{
			InitJNI();
		}
		protected SSLEngine(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _wrap23362;
		public virtual global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer[] arg0, java.nio.ByteBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._wrap23362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._wrap23362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _wrap23363;
		public abstract global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer[] arg0, int arg1, int arg2, java.nio.ByteBuffer arg3);
		internal static global::MonoJavaBridge.MethodId _wrap23364;
		public virtual global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._wrap23364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._wrap23364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites23365;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		internal static global::MonoJavaBridge.MethodId _unwrap23366;
		public virtual global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._unwrap23366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._unwrap23366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _unwrap23367;
		public virtual global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._unwrap23367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._unwrap23367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _unwrap23368;
		public abstract global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer[] arg1, int arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _getSession23369;
		public abstract global::javax.net.ssl.SSLSession getSession();
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites23370;
		public abstract global::java.lang.String[] getEnabledCipherSuites();
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites23371;
		public abstract void setEnabledCipherSuites(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols23372;
		public abstract global::java.lang.String[] getSupportedProtocols();
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols23373;
		public abstract global::java.lang.String[] getEnabledProtocols();
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols23374;
		public abstract void setEnabledProtocols(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _setUseClientMode23375;
		public abstract void setUseClientMode(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getUseClientMode23376;
		public abstract bool getUseClientMode();
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth23377;
		public abstract void setNeedClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth23378;
		public abstract bool getNeedClientAuth();
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth23379;
		public abstract void setWantClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth23380;
		public abstract bool getWantClientAuth();
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation23381;
		public abstract void setEnableSessionCreation(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation23382;
		public abstract bool getEnableSessionCreation();
		internal static global::MonoJavaBridge.MethodId _getPeerHost23383;
		public virtual global::java.lang.String getPeerHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._getPeerHost23383)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._getPeerHost23383)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPeerPort23384;
		public virtual int getPeerPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._getPeerPort23384);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._getPeerPort23384);
		}
		internal static global::MonoJavaBridge.MethodId _getDelegatedTask23385;
		public abstract global::java.lang.Runnable getDelegatedTask();
		internal static global::MonoJavaBridge.MethodId _closeInbound23386;
		public abstract void closeInbound();
		internal static global::MonoJavaBridge.MethodId _isInboundDone23387;
		public abstract bool isInboundDone();
		internal static global::MonoJavaBridge.MethodId _closeOutbound23388;
		public abstract void closeOutbound();
		internal static global::MonoJavaBridge.MethodId _isOutboundDone23389;
		public abstract bool isOutboundDone();
		internal static global::MonoJavaBridge.MethodId _beginHandshake23390;
		public abstract void beginHandshake();
		internal static global::MonoJavaBridge.MethodId _getHandshakeStatus23391;
		public abstract global::javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus();
		internal static global::MonoJavaBridge.MethodId _SSLEngine23392;
		protected SSLEngine(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._SSLEngine23392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLEngine23393;
		protected SSLEngine()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._SSLEngine23393);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLEngine.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngine"));
			global::javax.net.ssl.SSLEngine._wrap23362 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "wrap", "([Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._wrap23363 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "wrap", "([Ljava/nio/ByteBuffer;IILjava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._wrap23364 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "wrap", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._getSupportedCipherSuites23365 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine._unwrap23366 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._unwrap23367 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._unwrap23368 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;II)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._getSession23369 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLEngine._getEnabledCipherSuites23370 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine._setEnabledCipherSuites23371 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLEngine._getSupportedProtocols23372 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine._getEnabledProtocols23373 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine._setEnabledProtocols23374 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLEngine._setUseClientMode23375 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLEngine._getUseClientMode23376 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLEngine._setNeedClientAuth23377 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLEngine._getNeedClientAuth23378 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLEngine._setWantClientAuth23379 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLEngine._getWantClientAuth23380 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLEngine._setEnableSessionCreation23381 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLEngine._getEnableSessionCreation23382 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getEnableSessionCreation", "()Z");
			global::javax.net.ssl.SSLEngine._getPeerHost23383 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getPeerHost", "()Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine._getPeerPort23384 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getPeerPort", "()I");
			global::javax.net.ssl.SSLEngine._getDelegatedTask23385 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getDelegatedTask", "()Ljava/lang/Runnable;");
			global::javax.net.ssl.SSLEngine._closeInbound23386 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "closeInbound", "()V");
			global::javax.net.ssl.SSLEngine._isInboundDone23387 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "isInboundDone", "()Z");
			global::javax.net.ssl.SSLEngine._closeOutbound23388 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "closeOutbound", "()V");
			global::javax.net.ssl.SSLEngine._isOutboundDone23389 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "isOutboundDone", "()Z");
			global::javax.net.ssl.SSLEngine._beginHandshake23390 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "beginHandshake", "()V");
			global::javax.net.ssl.SSLEngine._getHandshakeStatus23391 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
			global::javax.net.ssl.SSLEngine._SSLEngine23392 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::javax.net.ssl.SSLEngine._SSLEngine23393 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLEngine))]
	public sealed partial class SSLEngine_ : javax.net.ssl.SSLEngine
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLEngine_()
		{
			InitJNI();
		}
		internal SSLEngine_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _wrap23394;
		public override global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer[] arg0, int arg1, int arg2, java.nio.ByteBuffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._wrap23394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._wrap23394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites23395;
		public override global::java.lang.String[] getSupportedCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getSupportedCipherSuites23395)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getSupportedCipherSuites23395)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _unwrap23396;
		public override global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._unwrap23396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._unwrap23396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _getSession23397;
		public override global::javax.net.ssl.SSLSession getSession() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getSession23397)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getSession23397)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites23398;
		public override global::java.lang.String[] getEnabledCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getEnabledCipherSuites23398)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getEnabledCipherSuites23398)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites23399;
		public override void setEnabledCipherSuites(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setEnabledCipherSuites23399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setEnabledCipherSuites23399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols23400;
		public override global::java.lang.String[] getSupportedProtocols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getSupportedProtocols23400)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getSupportedProtocols23400)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols23401;
		public override global::java.lang.String[] getEnabledProtocols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getEnabledProtocols23401)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getEnabledProtocols23401)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols23402;
		public override void setEnabledProtocols(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setEnabledProtocols23402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setEnabledProtocols23402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUseClientMode23403;
		public override void setUseClientMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setUseClientMode23403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setUseClientMode23403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseClientMode23404;
		public override bool getUseClientMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getUseClientMode23404);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getUseClientMode23404);
		}
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth23405;
		public override void setNeedClientAuth(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setNeedClientAuth23405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setNeedClientAuth23405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth23406;
		public override bool getNeedClientAuth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getNeedClientAuth23406);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getNeedClientAuth23406);
		}
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth23407;
		public override void setWantClientAuth(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setWantClientAuth23407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setWantClientAuth23407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth23408;
		public override bool getWantClientAuth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getWantClientAuth23408);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getWantClientAuth23408);
		}
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation23409;
		public override void setEnableSessionCreation(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setEnableSessionCreation23409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setEnableSessionCreation23409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation23410;
		public override bool getEnableSessionCreation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getEnableSessionCreation23410);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getEnableSessionCreation23410);
		}
		internal static global::MonoJavaBridge.MethodId _getDelegatedTask23411;
		public override global::java.lang.Runnable getDelegatedTask() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Runnable>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getDelegatedTask23411)) as java.lang.Runnable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Runnable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getDelegatedTask23411)) as java.lang.Runnable;
		}
		internal static global::MonoJavaBridge.MethodId _closeInbound23412;
		public override void closeInbound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._closeInbound23412);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._closeInbound23412);
		}
		internal static global::MonoJavaBridge.MethodId _isInboundDone23413;
		public override bool isInboundDone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._isInboundDone23413);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._isInboundDone23413);
		}
		internal static global::MonoJavaBridge.MethodId _closeOutbound23414;
		public override void closeOutbound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._closeOutbound23414);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._closeOutbound23414);
		}
		internal static global::MonoJavaBridge.MethodId _isOutboundDone23415;
		public override bool isOutboundDone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._isOutboundDone23415);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._isOutboundDone23415);
		}
		internal static global::MonoJavaBridge.MethodId _beginHandshake23416;
		public override void beginHandshake() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._beginHandshake23416);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._beginHandshake23416);
		}
		internal static global::MonoJavaBridge.MethodId _getHandshakeStatus23417;
		public override global::javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getHandshakeStatus23417)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getHandshakeStatus23417)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLEngine_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngine"));
			global::javax.net.ssl.SSLEngine_._wrap23394 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "wrap", "([Ljava/nio/ByteBuffer;IILjava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine_._getSupportedCipherSuites23395 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine_._unwrap23396 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;II)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine_._getSession23397 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLEngine_._getEnabledCipherSuites23398 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine_._setEnabledCipherSuites23399 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLEngine_._getSupportedProtocols23400 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine_._getEnabledProtocols23401 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine_._setEnabledProtocols23402 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLEngine_._setUseClientMode23403 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLEngine_._getUseClientMode23404 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLEngine_._setNeedClientAuth23405 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLEngine_._getNeedClientAuth23406 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLEngine_._setWantClientAuth23407 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLEngine_._getWantClientAuth23408 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLEngine_._setEnableSessionCreation23409 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLEngine_._getEnableSessionCreation23410 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getEnableSessionCreation", "()Z");
			global::javax.net.ssl.SSLEngine_._getDelegatedTask23411 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getDelegatedTask", "()Ljava/lang/Runnable;");
			global::javax.net.ssl.SSLEngine_._closeInbound23412 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "closeInbound", "()V");
			global::javax.net.ssl.SSLEngine_._isInboundDone23413 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "isInboundDone", "()Z");
			global::javax.net.ssl.SSLEngine_._closeOutbound23414 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "closeOutbound", "()V");
			global::javax.net.ssl.SSLEngine_._isOutboundDone23415 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "isOutboundDone", "()Z");
			global::javax.net.ssl.SSLEngine_._beginHandshake23416 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "beginHandshake", "()V");
			global::javax.net.ssl.SSLEngine_._getHandshakeStatus23417 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
		}
	}
}
