namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLSocketFactory_))]
	public abstract partial class SSLSocketFactory : javax.net.SocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefault30110;
		public static global::javax.net.SocketFactory getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocketFactory._getDefault30110.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocketFactory._getDefault30110 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLSocketFactory.staticClass, "getDefault", "()Ljavax/net/SocketFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLSocketFactory.staticClass, global::javax.net.ssl.SSLSocketFactory._getDefault30110)) as javax.net.SocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket30111;
		public abstract global::java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3);
		internal static global::MonoJavaBridge.MethodId _getDefaultCipherSuites30112;
		public abstract global::java.lang.String[] getDefaultCipherSuites();
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites30113;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		internal static global::MonoJavaBridge.MethodId _SSLSocketFactory30114;
		public SSLSocketFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLSocketFactory._SSLSocketFactory30114.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLSocketFactory._SSLSocketFactory30114 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocketFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocketFactory.staticClass, global::javax.net.ssl.SSLSocketFactory._SSLSocketFactory30114);
			Init(@__env, handle);
		}
		static SSLSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSocketFactory"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLSocketFactory))]
	internal sealed partial class SSLSocketFactory_ : javax.net.ssl.SSLSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SSLSocketFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createSocket30115;
		public override global::java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLSocketFactory_.staticClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", ref global::javax.net.ssl.SSLSocketFactory_._createSocket30115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultCipherSuites30116;
		public override global::java.lang.String[] getDefaultCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLSocketFactory_.staticClass, "getDefaultCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLSocketFactory_._getDefaultCipherSuites30116) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites30117;
		public override global::java.lang.String[] getSupportedCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLSocketFactory_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLSocketFactory_._getSupportedCipherSuites30117) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _createSocket30118;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLSocketFactory_.staticClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;", ref global::javax.net.ssl.SSLSocketFactory_._createSocket30118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket30119;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLSocketFactory_.staticClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;", ref global::javax.net.ssl.SSLSocketFactory_._createSocket30119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket30120;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLSocketFactory_.staticClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;", ref global::javax.net.ssl.SSLSocketFactory_._createSocket30120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket30121;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLSocketFactory_.staticClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;", ref global::javax.net.ssl.SSLSocketFactory_._createSocket30121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.net.Socket;
		}
		static SSLSocketFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSocketFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSocketFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
