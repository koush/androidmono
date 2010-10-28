namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLContextSpi_))]
	public abstract partial class SSLContextSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLContextSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit29897;
		protected abstract void engineInit(javax.net.ssl.KeyManager[] arg0, javax.net.ssl.TrustManager[] arg1, java.security.SecureRandom arg2);
		internal static global::MonoJavaBridge.MethodId _engineGetSocketFactory29898;
		protected abstract global::javax.net.ssl.SSLSocketFactory engineGetSocketFactory();
		internal static global::MonoJavaBridge.MethodId _engineGetServerSocketFactory29899;
		protected abstract global::javax.net.ssl.SSLServerSocketFactory engineGetServerSocketFactory();
		internal static global::MonoJavaBridge.MethodId _engineCreateSSLEngine29900;
		protected abstract global::javax.net.ssl.SSLEngine engineCreateSSLEngine(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _engineCreateSSLEngine29901;
		protected abstract global::javax.net.ssl.SSLEngine engineCreateSSLEngine();
		internal static global::MonoJavaBridge.MethodId _engineGetServerSessionContext29902;
		protected abstract global::javax.net.ssl.SSLSessionContext engineGetServerSessionContext();
		internal static global::MonoJavaBridge.MethodId _engineGetClientSessionContext29903;
		protected abstract global::javax.net.ssl.SSLSessionContext engineGetClientSessionContext();
		internal static global::MonoJavaBridge.MethodId _SSLContextSpi29904;
		public SSLContextSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLContextSpi.staticClass, global::javax.net.ssl.SSLContextSpi._SSLContextSpi29904);
			Init(@__env, handle);
		}
		static SSLContextSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLContextSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLContextSpi"));
			global::javax.net.ssl.SSLContextSpi._engineInit29897 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "engineInit", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRandom;)V");
			global::javax.net.ssl.SSLContextSpi._engineGetSocketFactory29898 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "engineGetSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
			global::javax.net.ssl.SSLContextSpi._engineGetServerSocketFactory29899 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "engineGetServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;");
			global::javax.net.ssl.SSLContextSpi._engineCreateSSLEngine29900 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "engineCreateSSLEngine", "(Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;");
			global::javax.net.ssl.SSLContextSpi._engineCreateSSLEngine29901 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "engineCreateSSLEngine", "()Ljavax/net/ssl/SSLEngine;");
			global::javax.net.ssl.SSLContextSpi._engineGetServerSessionContext29902 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "engineGetServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;");
			global::javax.net.ssl.SSLContextSpi._engineGetClientSessionContext29903 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "engineGetClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;");
			global::javax.net.ssl.SSLContextSpi._SSLContextSpi29904 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLContextSpi))]
	internal sealed partial class SSLContextSpi_ : javax.net.ssl.SSLContextSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SSLContextSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit29905;
		protected override void engineInit(javax.net.ssl.KeyManager[] arg0, javax.net.ssl.TrustManager[] arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_._engineInit29905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_.staticClass, global::javax.net.ssl.SSLContextSpi_._engineInit29905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetSocketFactory29906;
		protected override global::javax.net.ssl.SSLSocketFactory engineGetSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_._engineGetSocketFactory29906)) as javax.net.ssl.SSLSocketFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_.staticClass, global::javax.net.ssl.SSLContextSpi_._engineGetSocketFactory29906)) as javax.net.ssl.SSLSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetServerSocketFactory29907;
		protected override global::javax.net.ssl.SSLServerSocketFactory engineGetServerSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_._engineGetServerSocketFactory29907)) as javax.net.ssl.SSLServerSocketFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_.staticClass, global::javax.net.ssl.SSLContextSpi_._engineGetServerSocketFactory29907)) as javax.net.ssl.SSLServerSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _engineCreateSSLEngine29908;
		protected override global::javax.net.ssl.SSLEngine engineCreateSSLEngine(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_._engineCreateSSLEngine29908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_.staticClass, global::javax.net.ssl.SSLContextSpi_._engineCreateSSLEngine29908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngine;
		}
		internal static global::MonoJavaBridge.MethodId _engineCreateSSLEngine29909;
		protected override global::javax.net.ssl.SSLEngine engineCreateSSLEngine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_._engineCreateSSLEngine29909)) as javax.net.ssl.SSLEngine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_.staticClass, global::javax.net.ssl.SSLContextSpi_._engineCreateSSLEngine29909)) as javax.net.ssl.SSLEngine;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetServerSessionContext29910;
		protected override global::javax.net.ssl.SSLSessionContext engineGetServerSessionContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSessionContext>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_._engineGetServerSessionContext29910)) as javax.net.ssl.SSLSessionContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSessionContext>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_.staticClass, global::javax.net.ssl.SSLContextSpi_._engineGetServerSessionContext29910)) as javax.net.ssl.SSLSessionContext;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetClientSessionContext29911;
		protected override global::javax.net.ssl.SSLSessionContext engineGetClientSessionContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSessionContext>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_._engineGetClientSessionContext29911)) as javax.net.ssl.SSLSessionContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSessionContext>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_.staticClass, global::javax.net.ssl.SSLContextSpi_._engineGetClientSessionContext29911)) as javax.net.ssl.SSLSessionContext;
		}
		static SSLContextSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLContextSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLContextSpi"));
			global::javax.net.ssl.SSLContextSpi_._engineInit29905 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi_.staticClass, "engineInit", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRandom;)V");
			global::javax.net.ssl.SSLContextSpi_._engineGetSocketFactory29906 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi_.staticClass, "engineGetSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
			global::javax.net.ssl.SSLContextSpi_._engineGetServerSocketFactory29907 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi_.staticClass, "engineGetServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;");
			global::javax.net.ssl.SSLContextSpi_._engineCreateSSLEngine29908 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi_.staticClass, "engineCreateSSLEngine", "(Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;");
			global::javax.net.ssl.SSLContextSpi_._engineCreateSSLEngine29909 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi_.staticClass, "engineCreateSSLEngine", "()Ljavax/net/ssl/SSLEngine;");
			global::javax.net.ssl.SSLContextSpi_._engineGetServerSessionContext29910 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi_.staticClass, "engineGetServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;");
			global::javax.net.ssl.SSLContextSpi_._engineGetClientSessionContext29911 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi_.staticClass, "engineGetClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;");
		}
		internal static void InitJNI()
		{
		}
	}
}
