namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLServerSocketFactory_))]
	public abstract partial class SSLServerSocketFactory : javax.net.ServerSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLServerSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.net.ServerSocketFactory getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLServerSocketFactory._m0.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLServerSocketFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLServerSocketFactory.staticClass, "getDefault", "()Ljavax/net/ServerSocketFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLServerSocketFactory.staticClass, global::javax.net.ssl.SSLServerSocketFactory._m0)) as javax.net.ServerSocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.lang.String[] getDefaultCipherSuites();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		private static global::MonoJavaBridge.MethodId _m3;
		protected SSLServerSocketFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLServerSocketFactory._m3.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLServerSocketFactory._m3 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocketFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocketFactory.staticClass, global::javax.net.ssl.SSLServerSocketFactory._m3);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String[] getDefaultCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLServerSocketFactory_.staticClass, "getDefaultCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLServerSocketFactory_._m0) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String[] getSupportedCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLServerSocketFactory_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;", ref global::javax.net.ssl.SSLServerSocketFactory_._m1) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.net.ServerSocket createServerSocket(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLServerSocketFactory_.staticClass, "createServerSocket", "(I)Ljava/net/ServerSocket;", ref global::javax.net.ssl.SSLServerSocketFactory_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.ServerSocket;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.net.ServerSocket createServerSocket(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLServerSocketFactory_.staticClass, "createServerSocket", "(II)Ljava/net/ServerSocket;", ref global::javax.net.ssl.SSLServerSocketFactory_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.net.ServerSocket;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.net.ServerSocket createServerSocket(int arg0, int arg1, java.net.InetAddress arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLServerSocketFactory_.staticClass, "createServerSocket", "(IILjava/net/InetAddress;)Ljava/net/ServerSocket;", ref global::javax.net.ssl.SSLServerSocketFactory_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.net.ServerSocket;
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
