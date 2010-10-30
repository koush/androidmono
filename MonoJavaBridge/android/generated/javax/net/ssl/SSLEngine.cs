namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLEngine_))]
	public abstract partial class SSLEngine : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLEngine(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer[] arg0, java.nio.ByteBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLEngine.staticClass, "wrap", "([Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", ref global::javax.net.ssl.SSLEngine._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as javax.net.ssl.SSLEngineResult;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer[] arg0, int arg1, int arg2, java.nio.ByteBuffer arg3);
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLEngine.staticClass, "wrap", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", ref global::javax.net.ssl.SSLEngine._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as javax.net.ssl.SSLEngineResult;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLEngine.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", ref global::javax.net.ssl.SSLEngine._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as javax.net.ssl.SSLEngineResult;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLEngine.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", ref global::javax.net.ssl.SSLEngine._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as javax.net.ssl.SSLEngineResult;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer[] arg1, int arg2, int arg3);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::javax.net.ssl.SSLSession getSession();
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::java.lang.String[] getEnabledCipherSuites();
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract void setEnabledCipherSuites(java.lang.String[] arg0);
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract global::java.lang.String[] getSupportedProtocols();
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract global::java.lang.String[] getEnabledProtocols();
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract void setEnabledProtocols(java.lang.String[] arg0);
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract void setUseClientMode(bool arg0);
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract bool getUseClientMode();
		private static global::MonoJavaBridge.MethodId _m15;
		public abstract void setNeedClientAuth(bool arg0);
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract bool getNeedClientAuth();
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract void setWantClientAuth(bool arg0);
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract bool getWantClientAuth();
		private static global::MonoJavaBridge.MethodId _m19;
		public abstract void setEnableSessionCreation(bool arg0);
		private static global::MonoJavaBridge.MethodId _m20;
		public abstract bool getEnableSessionCreation();
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::java.lang.String getPeerHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLEngine.staticClass, "getPeerHost", "()Ljava/lang/String;", ref global::javax.net.ssl.SSLEngine._m21) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual int getPeerPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.net.ssl.SSLEngine.staticClass, "getPeerPort", "()I", ref global::javax.net.ssl.SSLEngine._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public abstract global::java.lang.Runnable getDelegatedTask();
		private static global::MonoJavaBridge.MethodId _m24;
		public abstract void closeInbound();
		private static global::MonoJavaBridge.MethodId _m25;
		public abstract bool isInboundDone();
		private static global::MonoJavaBridge.MethodId _m26;
		public abstract void closeOutbound();
		private static global::MonoJavaBridge.MethodId _m27;
		public abstract bool isOutboundDone();
		private static global::MonoJavaBridge.MethodId _m28;
		public abstract void beginHandshake();
		private static global::MonoJavaBridge.MethodId _m29;
		public abstract global::javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus();
		private static global::MonoJavaBridge.MethodId _m30;
		protected SSLEngine(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLEngine._m30.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLEngine._m30 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		protected SSLEngine() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLEngine._m31.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLEngine._m31 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._m31);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer[] arg0, int arg1, int arg2, java.nio.ByteBuffer arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "wrap", "([Ljava/nio/ByteBuffer;IILjava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;", ref global::javax.net.ssl.SSLEngine_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.net.ssl.SSLEngineResult;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String[] getSupportedCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLEngine_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLEngine_._m1) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer[] arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;II)Ljavax/net/ssl/SSLEngineResult;", ref global::javax.net.ssl.SSLEngine_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.net.ssl.SSLEngineResult;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::javax.net.ssl.SSLSession getSession()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSession>(this, global::javax.net.ssl.SSLEngine_.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;", ref global::javax.net.ssl.SSLEngine_._m3) as javax.net.ssl.SSLSession;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.String[] getEnabledCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLEngine_.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLEngine_._m4) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void setEnabledCipherSuites(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V", ref global::javax.net.ssl.SSLEngine_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.lang.String[] getSupportedProtocols()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLEngine_.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLEngine_._m6) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.lang.String[] getEnabledProtocols()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLEngine_.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLEngine_._m7) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void setEnabledProtocols(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V", ref global::javax.net.ssl.SSLEngine_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void setUseClientMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "setUseClientMode", "(Z)V", ref global::javax.net.ssl.SSLEngine_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool getUseClientMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "getUseClientMode", "()Z", ref global::javax.net.ssl.SSLEngine_._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override void setNeedClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "setNeedClientAuth", "(Z)V", ref global::javax.net.ssl.SSLEngine_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override bool getNeedClientAuth()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "getNeedClientAuth", "()Z", ref global::javax.net.ssl.SSLEngine_._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override void setWantClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "setWantClientAuth", "(Z)V", ref global::javax.net.ssl.SSLEngine_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override bool getWantClientAuth()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "getWantClientAuth", "()Z", ref global::javax.net.ssl.SSLEngine_._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override void setEnableSessionCreation(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "setEnableSessionCreation", "(Z)V", ref global::javax.net.ssl.SSLEngine_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override bool getEnableSessionCreation()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "getEnableSessionCreation", "()Z", ref global::javax.net.ssl.SSLEngine_._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override global::java.lang.Runnable getDelegatedTask()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Runnable>(this, global::javax.net.ssl.SSLEngine_.staticClass, "getDelegatedTask", "()Ljava/lang/Runnable;", ref global::javax.net.ssl.SSLEngine_._m17) as java.lang.Runnable;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override void closeInbound()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "closeInbound", "()V", ref global::javax.net.ssl.SSLEngine_._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override bool isInboundDone()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "isInboundDone", "()Z", ref global::javax.net.ssl.SSLEngine_._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override void closeOutbound()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "closeOutbound", "()V", ref global::javax.net.ssl.SSLEngine_._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override bool isOutboundDone()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "isOutboundDone", "()Z", ref global::javax.net.ssl.SSLEngine_._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public override void beginHandshake()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLEngine_.staticClass, "beginHandshake", "()V", ref global::javax.net.ssl.SSLEngine_._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public override global::javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<javax.net.ssl.SSLEngineResult.HandshakeStatus>(this, global::javax.net.ssl.SSLEngine_.staticClass, "getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", ref global::javax.net.ssl.SSLEngine_._m23) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
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
