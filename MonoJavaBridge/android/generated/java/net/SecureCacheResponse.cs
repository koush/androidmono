namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.SecureCacheResponse_))]
	public abstract partial class SecureCacheResponse : java.net.CacheResponse
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SecureCacheResponse(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.String getCipherSuite();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.util.List getLocalCertificateChain();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.util.List getServerCertificateChain();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::java.security.Principal getPeerPrincipal();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.security.Principal getLocalPrincipal();
		private static global::MonoJavaBridge.MethodId _m5;
		public SecureCacheResponse() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.SecureCacheResponse._m5.native == global::System.IntPtr.Zero)
				global::java.net.SecureCacheResponse._m5 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SecureCacheResponse.staticClass, global::java.net.SecureCacheResponse._m5);
			Init(@__env, handle);
		}
		static SecureCacheResponse()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SecureCacheResponse.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SecureCacheResponse"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.SecureCacheResponse))]
	internal sealed partial class SecureCacheResponse_ : java.net.SecureCacheResponse
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SecureCacheResponse_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getCipherSuite()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.SecureCacheResponse_.staticClass, "getCipherSuite", "()Ljava/lang/String;", ref global::java.net.SecureCacheResponse_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.util.List getLocalCertificateChain()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.net.SecureCacheResponse_.staticClass, "getLocalCertificateChain", "()Ljava/util/List;", ref global::java.net.SecureCacheResponse_._m1) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.util.List getServerCertificateChain()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.net.SecureCacheResponse_.staticClass, "getServerCertificateChain", "()Ljava/util/List;", ref global::java.net.SecureCacheResponse_._m2) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.security.Principal getPeerPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::java.net.SecureCacheResponse_.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;", ref global::java.net.SecureCacheResponse_._m3) as java.security.Principal;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.security.Principal getLocalPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::java.net.SecureCacheResponse_.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;", ref global::java.net.SecureCacheResponse_._m4) as java.security.Principal;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.util.Map getHeaders()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::java.net.SecureCacheResponse_.staticClass, "getHeaders", "()Ljava/util/Map;", ref global::java.net.SecureCacheResponse_._m5) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.io.InputStream getBody()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.SecureCacheResponse_.staticClass, "getBody", "()Ljava/io/InputStream;", ref global::java.net.SecureCacheResponse_._m6) as java.io.InputStream;
		}
		static SecureCacheResponse_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SecureCacheResponse_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SecureCacheResponse"));
		}
	}
}
