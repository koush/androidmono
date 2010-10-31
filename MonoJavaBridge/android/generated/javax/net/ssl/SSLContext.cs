namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLContext : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::javax.net.ssl.SSLContext Default
		{
			get
			{
				return getDefault();
			}
			set
			{
				setDefault(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.net.ssl.SSLContext getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLContext._m0.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLContext._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getDefault", "()Ljavax/net/ssl/SSLContext;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._m0)) as javax.net.ssl.SSLContext;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::javax.net.ssl.SSLContext getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLContext._m1.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLContext._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/net/ssl/SSLContext;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLContext;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::javax.net.ssl.SSLContext getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLContext._m2.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLContext._m2 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/SSLContext;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLContext;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::javax.net.ssl.SSLContext getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLContext._m3.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLContext._m3 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/net/ssl/SSLContext;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLContext;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void init(javax.net.ssl.KeyManager[] arg0, javax.net.ssl.TrustManager[] arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLContext.staticClass, "init", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRandom;)V", ref global::javax.net.ssl.SSLContext._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.String Protocol
		{
			get
			{
				return getProtocol();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getProtocol()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLContext.staticClass, "getProtocol", "()Ljava/lang/String;", ref global::javax.net.ssl.SSLContext._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void setDefault(javax.net.ssl.SSLContext arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLContext._m6.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLContext._m6 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "setDefault", "(Ljavax/net/ssl/SSLContext;)V");
			@__env.CallStaticVoidMethod(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLContext.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::javax.net.ssl.SSLContext._m7) as java.security.Provider;
		}
		public new global::javax.net.ssl.SSLSocketFactory SocketFactory
		{
			get
			{
				return getSocketFactory();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::javax.net.ssl.SSLSocketFactory getSocketFactory()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLContext.staticClass, "getSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", ref global::javax.net.ssl.SSLContext._m8) as javax.net.ssl.SSLSocketFactory;
		}
		public new global::javax.net.ssl.SSLServerSocketFactory ServerSocketFactory
		{
			get
			{
				return getServerSocketFactory();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::javax.net.ssl.SSLServerSocketFactory getServerSocketFactory()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLContext.staticClass, "getServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;", ref global::javax.net.ssl.SSLContext._m9) as javax.net.ssl.SSLServerSocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::javax.net.ssl.SSLEngine createSSLEngine()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLContext.staticClass, "createSSLEngine", "()Ljavax/net/ssl/SSLEngine;", ref global::javax.net.ssl.SSLContext._m10) as javax.net.ssl.SSLEngine;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::javax.net.ssl.SSLEngine createSSLEngine(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLContext.staticClass, "createSSLEngine", "(Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;", ref global::javax.net.ssl.SSLContext._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as javax.net.ssl.SSLEngine;
		}
		public new global::javax.net.ssl.SSLSessionContext ServerSessionContext
		{
			get
			{
				return getServerSessionContext();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::javax.net.ssl.SSLSessionContext getServerSessionContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSessionContext>(this, global::javax.net.ssl.SSLContext.staticClass, "getServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", ref global::javax.net.ssl.SSLContext._m12) as javax.net.ssl.SSLSessionContext;
		}
		public new global::javax.net.ssl.SSLSessionContext ClientSessionContext
		{
			get
			{
				return getClientSessionContext();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::javax.net.ssl.SSLSessionContext getClientSessionContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSessionContext>(this, global::javax.net.ssl.SSLContext.staticClass, "getClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", ref global::javax.net.ssl.SSLContext._m13) as javax.net.ssl.SSLSessionContext;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected SSLContext(javax.net.ssl.SSLContextSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLContext._m14.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLContext._m14 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "<init>", "(Ljavax/net/ssl/SSLContextSpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static SSLContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLContext"));
		}
	}
}
