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
		internal static global::MonoJavaBridge.MethodId _wrap29793;
		public virtual global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer[] arg0, java.nio.ByteBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._wrap29793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._wrap29793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _wrap29794;
		public abstract global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer[] arg0, int arg1, int arg2, java.nio.ByteBuffer arg3);
		internal static global::MonoJavaBridge.MethodId _wrap29795;
		public virtual global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._wrap29795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._wrap29795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites29796;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		internal static global::MonoJavaBridge.MethodId _unwrap29797;
		public virtual global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._unwrap29797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._unwrap29797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _unwrap29798;
		public virtual global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._unwrap29798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._unwrap29798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _unwrap29799;
		public abstract global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer[] arg1, int arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _getSession29800;
		public abstract global::javax.net.ssl.SSLSession getSession();
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites29801;
		public abstract global::java.lang.String[] getEnabledCipherSuites();
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites29802;
		public abstract void setEnabledCipherSuites(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols29803;
		public abstract global::java.lang.String[] getSupportedProtocols();
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols29804;
		public abstract global::java.lang.String[] getEnabledProtocols();
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols29805;
		public abstract void setEnabledProtocols(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _setUseClientMode29806;
		public abstract void setUseClientMode(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getUseClientMode29807;
		public abstract bool getUseClientMode();
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth29808;
		public abstract void setNeedClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth29809;
		public abstract bool getNeedClientAuth();
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth29810;
		public abstract void setWantClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth29811;
		public abstract bool getWantClientAuth();
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation29812;
		public abstract void setEnableSessionCreation(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation29813;
		public abstract bool getEnableSessionCreation();
		internal static global::MonoJavaBridge.MethodId _getPeerHost29814;
		public virtual global::java.lang.String getPeerHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._getPeerHost29814)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._getPeerHost29814)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPeerPort29815;
		public virtual int getPeerPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._getPeerPort29815);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._getPeerPort29815);
		}
		internal static global::MonoJavaBridge.MethodId _getDelegatedTask29816;
		public abstract global::java.lang.Runnable getDelegatedTask();
		internal static global::MonoJavaBridge.MethodId _closeInbound29817;
		public abstract void closeInbound();
		internal static global::MonoJavaBridge.MethodId _isInboundDone29818;
		public abstract bool isInboundDone();
		internal static global::MonoJavaBridge.MethodId _closeOutbound29819;
		public abstract void closeOutbound();
		internal static global::MonoJavaBridge.MethodId _isOutboundDone29820;
		public abstract bool isOutboundDone();
		internal static global::MonoJavaBridge.MethodId _beginHandshake29821;
		public abstract void beginHandshake();
		internal static global::MonoJavaBridge.MethodId _getHandshakeStatus29822;
		public abstract global::javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus();
		internal static global::MonoJavaBridge.MethodId _SSLEngine29823;
		protected SSLEngine(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._SSLEngine29823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLEngine29824;
		protected SSLEngine()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._SSLEngine29824);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLEngine.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngine"));
			global::javax.net.ssl.SSLEngine._wrap29793 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "wrap", "([Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._wrap29794 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "wrap", "([Ljava/nio/ByteBuffer;IILjava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._wrap29795 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "wrap", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._getSupportedCipherSuites29796 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine._unwrap29797 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._unwrap29798 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._unwrap29799 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;II)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._getSession29800 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLEngine._getEnabledCipherSuites29801 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine._setEnabledCipherSuites29802 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLEngine._getSupportedProtocols29803 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine._getEnabledProtocols29804 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine._setEnabledProtocols29805 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLEngine._setUseClientMode29806 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLEngine._getUseClientMode29807 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLEngine._setNeedClientAuth29808 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLEngine._getNeedClientAuth29809 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLEngine._setWantClientAuth29810 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLEngine._getWantClientAuth29811 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLEngine._setEnableSessionCreation29812 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLEngine._getEnableSessionCreation29813 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getEnableSessionCreation", "()Z");
			global::javax.net.ssl.SSLEngine._getPeerHost29814 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getPeerHost", "()Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine._getPeerPort29815 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getPeerPort", "()I");
			global::javax.net.ssl.SSLEngine._getDelegatedTask29816 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getDelegatedTask", "()Ljava/lang/Runnable;");
			global::javax.net.ssl.SSLEngine._closeInbound29817 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "closeInbound", "()V");
			global::javax.net.ssl.SSLEngine._isInboundDone29818 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "isInboundDone", "()Z");
			global::javax.net.ssl.SSLEngine._closeOutbound29819 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "closeOutbound", "()V");
			global::javax.net.ssl.SSLEngine._isOutboundDone29820 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "isOutboundDone", "()Z");
			global::javax.net.ssl.SSLEngine._beginHandshake29821 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "beginHandshake", "()V");
			global::javax.net.ssl.SSLEngine._getHandshakeStatus29822 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
			global::javax.net.ssl.SSLEngine._SSLEngine29823 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::javax.net.ssl.SSLEngine._SSLEngine29824 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _wrap29825;
		public override global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer[] arg0, int arg1, int arg2, java.nio.ByteBuffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._wrap29825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._wrap29825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites29826;
		public override global::java.lang.String[] getSupportedCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getSupportedCipherSuites29826)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getSupportedCipherSuites29826)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _unwrap29827;
		public override global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._unwrap29827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._unwrap29827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _getSession29828;
		public override global::javax.net.ssl.SSLSession getSession() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getSession29828)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getSession29828)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites29829;
		public override global::java.lang.String[] getEnabledCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getEnabledCipherSuites29829)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getEnabledCipherSuites29829)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites29830;
		public override void setEnabledCipherSuites(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setEnabledCipherSuites29830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setEnabledCipherSuites29830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols29831;
		public override global::java.lang.String[] getSupportedProtocols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getSupportedProtocols29831)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getSupportedProtocols29831)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols29832;
		public override global::java.lang.String[] getEnabledProtocols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getEnabledProtocols29832)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getEnabledProtocols29832)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols29833;
		public override void setEnabledProtocols(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setEnabledProtocols29833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setEnabledProtocols29833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUseClientMode29834;
		public override void setUseClientMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setUseClientMode29834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setUseClientMode29834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseClientMode29835;
		public override bool getUseClientMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getUseClientMode29835);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getUseClientMode29835);
		}
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth29836;
		public override void setNeedClientAuth(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setNeedClientAuth29836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setNeedClientAuth29836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth29837;
		public override bool getNeedClientAuth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getNeedClientAuth29837);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getNeedClientAuth29837);
		}
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth29838;
		public override void setWantClientAuth(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setWantClientAuth29838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setWantClientAuth29838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth29839;
		public override bool getWantClientAuth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getWantClientAuth29839);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getWantClientAuth29839);
		}
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation29840;
		public override void setEnableSessionCreation(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setEnableSessionCreation29840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setEnableSessionCreation29840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation29841;
		public override bool getEnableSessionCreation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getEnableSessionCreation29841);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getEnableSessionCreation29841);
		}
		internal static global::MonoJavaBridge.MethodId _getDelegatedTask29842;
		public override global::java.lang.Runnable getDelegatedTask() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Runnable>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getDelegatedTask29842)) as java.lang.Runnable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Runnable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getDelegatedTask29842)) as java.lang.Runnable;
		}
		internal static global::MonoJavaBridge.MethodId _closeInbound29843;
		public override void closeInbound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._closeInbound29843);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._closeInbound29843);
		}
		internal static global::MonoJavaBridge.MethodId _isInboundDone29844;
		public override bool isInboundDone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._isInboundDone29844);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._isInboundDone29844);
		}
		internal static global::MonoJavaBridge.MethodId _closeOutbound29845;
		public override void closeOutbound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._closeOutbound29845);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._closeOutbound29845);
		}
		internal static global::MonoJavaBridge.MethodId _isOutboundDone29846;
		public override bool isOutboundDone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._isOutboundDone29846);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._isOutboundDone29846);
		}
		internal static global::MonoJavaBridge.MethodId _beginHandshake29847;
		public override void beginHandshake() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._beginHandshake29847);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._beginHandshake29847);
		}
		internal static global::MonoJavaBridge.MethodId _getHandshakeStatus29848;
		public override global::javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getHandshakeStatus29848)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getHandshakeStatus29848)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLEngine_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngine"));
			global::javax.net.ssl.SSLEngine_._wrap29825 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "wrap", "([Ljava/nio/ByteBuffer;IILjava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine_._getSupportedCipherSuites29826 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine_._unwrap29827 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;II)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine_._getSession29828 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLEngine_._getEnabledCipherSuites29829 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine_._setEnabledCipherSuites29830 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLEngine_._getSupportedProtocols29831 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine_._getEnabledProtocols29832 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine_._setEnabledProtocols29833 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLEngine_._setUseClientMode29834 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLEngine_._getUseClientMode29835 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLEngine_._setNeedClientAuth29836 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLEngine_._getNeedClientAuth29837 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLEngine_._setWantClientAuth29838 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLEngine_._getWantClientAuth29839 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLEngine_._setEnableSessionCreation29840 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLEngine_._getEnableSessionCreation29841 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getEnableSessionCreation", "()Z");
			global::javax.net.ssl.SSLEngine_._getDelegatedTask29842 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getDelegatedTask", "()Ljava/lang/Runnable;");
			global::javax.net.ssl.SSLEngine_._closeInbound29843 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "closeInbound", "()V");
			global::javax.net.ssl.SSLEngine_._isInboundDone29844 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "isInboundDone", "()Z");
			global::javax.net.ssl.SSLEngine_._closeOutbound29845 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "closeOutbound", "()V");
			global::javax.net.ssl.SSLEngine_._isOutboundDone29846 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "isOutboundDone", "()Z");
			global::javax.net.ssl.SSLEngine_._beginHandshake29847 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "beginHandshake", "()V");
			global::javax.net.ssl.SSLEngine_._getHandshakeStatus29848 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
		}
	}
}
