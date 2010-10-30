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
		internal static global::MonoJavaBridge.MethodId _getDefault29882;
		public static global::javax.net.ssl.SSLContext getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLContext._getDefault29882.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLContext._getDefault29882 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getDefault", "()Ljavax/net/ssl/SSLContext;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._getDefault29882)) as javax.net.ssl.SSLContext;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance29883;
		public static global::javax.net.ssl.SSLContext getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLContext._getInstance29883.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLContext._getInstance29883 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/net/ssl/SSLContext;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._getInstance29883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLContext;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance29884;
		public static global::javax.net.ssl.SSLContext getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLContext._getInstance29884.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLContext._getInstance29884 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/SSLContext;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._getInstance29884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLContext;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance29885;
		public static global::javax.net.ssl.SSLContext getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLContext._getInstance29885.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLContext._getInstance29885 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/net/ssl/SSLContext;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._getInstance29885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLContext;
		}
		internal static global::MonoJavaBridge.MethodId _init29886;
		public virtual void init(javax.net.ssl.KeyManager[] arg0, javax.net.ssl.TrustManager[] arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLContext.staticClass, "init", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRandom;)V", ref global::javax.net.ssl.SSLContext._init29886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.String Protocol
		{
			get
			{
				return getProtocol();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocol29887;
		public virtual global::java.lang.String getProtocol()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLContext.staticClass, "getProtocol", "()Ljava/lang/String;", ref global::javax.net.ssl.SSLContext._getProtocol29887) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setDefault29888;
		public static void setDefault(javax.net.ssl.SSLContext arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLContext._setDefault29888.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLContext._setDefault29888 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "setDefault", "(Ljavax/net/ssl/SSLContext;)V");
			@__env.CallStaticVoidMethod(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._setDefault29888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider29889;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLContext.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::javax.net.ssl.SSLContext._getProvider29889) as java.security.Provider;
		}
		public new global::javax.net.ssl.SSLSocketFactory SocketFactory
		{
			get
			{
				return getSocketFactory();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocketFactory29890;
		public virtual global::javax.net.ssl.SSLSocketFactory getSocketFactory()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLContext.staticClass, "getSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", ref global::javax.net.ssl.SSLContext._getSocketFactory29890) as javax.net.ssl.SSLSocketFactory;
		}
		public new global::javax.net.ssl.SSLServerSocketFactory ServerSocketFactory
		{
			get
			{
				return getServerSocketFactory();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServerSocketFactory29891;
		public virtual global::javax.net.ssl.SSLServerSocketFactory getServerSocketFactory()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLContext.staticClass, "getServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;", ref global::javax.net.ssl.SSLContext._getServerSocketFactory29891) as javax.net.ssl.SSLServerSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _createSSLEngine29892;
		public virtual global::javax.net.ssl.SSLEngine createSSLEngine()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLContext.staticClass, "createSSLEngine", "()Ljavax/net/ssl/SSLEngine;", ref global::javax.net.ssl.SSLContext._createSSLEngine29892) as javax.net.ssl.SSLEngine;
		}
		internal static global::MonoJavaBridge.MethodId _createSSLEngine29893;
		public virtual global::javax.net.ssl.SSLEngine createSSLEngine(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLContext.staticClass, "createSSLEngine", "(Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;", ref global::javax.net.ssl.SSLContext._createSSLEngine29893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as javax.net.ssl.SSLEngine;
		}
		public new global::javax.net.ssl.SSLSessionContext ServerSessionContext
		{
			get
			{
				return getServerSessionContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServerSessionContext29894;
		public virtual global::javax.net.ssl.SSLSessionContext getServerSessionContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSessionContext>(this, global::javax.net.ssl.SSLContext.staticClass, "getServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", ref global::javax.net.ssl.SSLContext._getServerSessionContext29894) as javax.net.ssl.SSLSessionContext;
		}
		public new global::javax.net.ssl.SSLSessionContext ClientSessionContext
		{
			get
			{
				return getClientSessionContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClientSessionContext29895;
		public virtual global::javax.net.ssl.SSLSessionContext getClientSessionContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSessionContext>(this, global::javax.net.ssl.SSLContext.staticClass, "getClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", ref global::javax.net.ssl.SSLContext._getClientSessionContext29895) as javax.net.ssl.SSLSessionContext;
		}
		internal static global::MonoJavaBridge.MethodId _SSLContext29896;
		protected SSLContext(javax.net.ssl.SSLContextSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLContext._SSLContext29896.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLContext._SSLContext29896 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContext.staticClass, "<init>", "(Ljavax/net/ssl/SSLContextSpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLContext.staticClass, global::javax.net.ssl.SSLContext._SSLContext29896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static SSLContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLContext"));
		}
		internal static void InitJNI()
		{
		}
	}
}
