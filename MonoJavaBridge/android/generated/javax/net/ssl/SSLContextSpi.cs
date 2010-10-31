namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLContextSpi_))]
	public abstract partial class SSLContextSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLContextSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected abstract void engineInit(javax.net.ssl.KeyManager[] arg0, javax.net.ssl.TrustManager[] arg1, java.security.SecureRandom arg2);
		private static global::MonoJavaBridge.MethodId _m1;
		protected abstract global::javax.net.ssl.SSLSocketFactory engineGetSocketFactory();
		private static global::MonoJavaBridge.MethodId _m2;
		protected abstract global::javax.net.ssl.SSLServerSocketFactory engineGetServerSocketFactory();
		private static global::MonoJavaBridge.MethodId _m3;
		protected abstract global::javax.net.ssl.SSLEngine engineCreateSSLEngine(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m4;
		protected abstract global::javax.net.ssl.SSLEngine engineCreateSSLEngine();
		private static global::MonoJavaBridge.MethodId _m5;
		protected abstract global::javax.net.ssl.SSLSessionContext engineGetServerSessionContext();
		private static global::MonoJavaBridge.MethodId _m6;
		protected abstract global::javax.net.ssl.SSLSessionContext engineGetClientSessionContext();
		private static global::MonoJavaBridge.MethodId _m7;
		public SSLContextSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLContextSpi._m7.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLContextSpi._m7 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLContextSpi.staticClass, global::javax.net.ssl.SSLContextSpi._m7);
			Init(@__env, handle);
		}
		static SSLContextSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLContextSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLContextSpi"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLContextSpi))]
	internal sealed partial class SSLContextSpi_ : javax.net.ssl.SSLContextSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SSLContextSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void engineInit(javax.net.ssl.KeyManager[] arg0, javax.net.ssl.TrustManager[] arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLContextSpi_.staticClass, "engineInit", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRandom;)V", ref global::javax.net.ssl.SSLContextSpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override global::javax.net.ssl.SSLSocketFactory engineGetSocketFactory()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLContextSpi_.staticClass, "engineGetSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", ref global::javax.net.ssl.SSLContextSpi_._m1) as javax.net.ssl.SSLSocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override global::javax.net.ssl.SSLServerSocketFactory engineGetServerSocketFactory()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLContextSpi_.staticClass, "engineGetServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;", ref global::javax.net.ssl.SSLContextSpi_._m2) as javax.net.ssl.SSLServerSocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override global::javax.net.ssl.SSLEngine engineCreateSSLEngine(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLContextSpi_.staticClass, "engineCreateSSLEngine", "(Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;", ref global::javax.net.ssl.SSLContextSpi_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as javax.net.ssl.SSLEngine;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override global::javax.net.ssl.SSLEngine engineCreateSSLEngine()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ssl.SSLContextSpi_.staticClass, "engineCreateSSLEngine", "()Ljavax/net/ssl/SSLEngine;", ref global::javax.net.ssl.SSLContextSpi_._m4) as javax.net.ssl.SSLEngine;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override global::javax.net.ssl.SSLSessionContext engineGetServerSessionContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSessionContext>(this, global::javax.net.ssl.SSLContextSpi_.staticClass, "engineGetServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", ref global::javax.net.ssl.SSLContextSpi_._m5) as javax.net.ssl.SSLSessionContext;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override global::javax.net.ssl.SSLSessionContext engineGetClientSessionContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.net.ssl.SSLSessionContext>(this, global::javax.net.ssl.SSLContextSpi_.staticClass, "engineGetClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;", ref global::javax.net.ssl.SSLContextSpi_._m6) as javax.net.ssl.SSLSessionContext;
		}
		static SSLContextSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLContextSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLContextSpi"));
		}
	}
}
