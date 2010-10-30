namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLServerSocketFactory_))]
	public abstract partial class SSLServerSocketFactory : javax.net.ServerSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLServerSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefault30028;
		public static global::javax.net.ServerSocketFactory getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLServerSocketFactory._getDefault30028.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLServerSocketFactory._getDefault30028 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLServerSocketFactory.staticClass, "getDefault", "()Ljavax/net/ServerSocketFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLServerSocketFactory.staticClass, global::javax.net.ssl.SSLServerSocketFactory._getDefault30028)) as javax.net.ServerSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultCipherSuites30029;
		public abstract global::java.lang.String[] getDefaultCipherSuites();
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites30030;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		internal static global::MonoJavaBridge.MethodId _SSLServerSocketFactory30031;
		protected SSLServerSocketFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLServerSocketFactory._SSLServerSocketFactory30031.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLServerSocketFactory._SSLServerSocketFactory30031 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocketFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocketFactory.staticClass, global::javax.net.ssl.SSLServerSocketFactory._SSLServerSocketFactory30031);
			Init(@__env, handle);
		}
		static SSLServerSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLServerSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLServerSocketFactory"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLServerSocketFactory))]
	internal sealed partial class SSLServerSocketFactory_ : javax.net.ssl.SSLServerSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SSLServerSocketFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultCipherSuites30032;
		public override global::java.lang.String[] getDefaultCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLServerSocketFactory_.staticClass, "getDefaultCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLServerSocketFactory_._getDefaultCipherSuites30032) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites30033;
		public override global::java.lang.String[] getSupportedCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLServerSocketFactory_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLServerSocketFactory_._getSupportedCipherSuites30033) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket30034;
		public override global::java.net.ServerSocket createServerSocket(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLServerSocketFactory_.staticClass, "createServerSocket", "(I)Ljava/net/ServerSocket;", ref global::javax.net.ssl.SSLServerSocketFactory_._createServerSocket30034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.ServerSocket;
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket30035;
		public override global::java.net.ServerSocket createServerSocket(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLServerSocketFactory_.staticClass, "createServerSocket", "(II)Ljava/net/ServerSocket;", ref global::javax.net.ssl.SSLServerSocketFactory_._createServerSocket30035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.net.ServerSocket;
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket30036;
		public override global::java.net.ServerSocket createServerSocket(int arg0, int arg1, java.net.InetAddress arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLServerSocketFactory_.staticClass, "createServerSocket", "(IILjava/net/InetAddress;)Ljava/net/ServerSocket;", ref global::javax.net.ssl.SSLServerSocketFactory_._createServerSocket30036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.net.ServerSocket;
		}
		static SSLServerSocketFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLServerSocketFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLServerSocketFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
