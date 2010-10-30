namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.SecureCacheResponse_))]
	public abstract partial class SecureCacheResponse : java.net.CacheResponse
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SecureCacheResponse(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCipherSuite21685;
		public abstract global::java.lang.String getCipherSuite();
		internal static global::MonoJavaBridge.MethodId _getLocalCertificateChain21686;
		public abstract global::java.util.List getLocalCertificateChain();
		internal static global::MonoJavaBridge.MethodId _getServerCertificateChain21687;
		public abstract global::java.util.List getServerCertificateChain();
		internal static global::MonoJavaBridge.MethodId _getPeerPrincipal21688;
		public abstract global::java.security.Principal getPeerPrincipal();
		internal static global::MonoJavaBridge.MethodId _getLocalPrincipal21689;
		public abstract global::java.security.Principal getLocalPrincipal();
		internal static global::MonoJavaBridge.MethodId _SecureCacheResponse21690;
		public SecureCacheResponse() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.SecureCacheResponse._SecureCacheResponse21690.native == global::System.IntPtr.Zero)
				global::java.net.SecureCacheResponse._SecureCacheResponse21690 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SecureCacheResponse.staticClass, global::java.net.SecureCacheResponse._SecureCacheResponse21690);
			Init(@__env, handle);
		}
		static SecureCacheResponse()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SecureCacheResponse.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SecureCacheResponse"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.SecureCacheResponse))]
	internal sealed partial class SecureCacheResponse_ : java.net.SecureCacheResponse
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SecureCacheResponse_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCipherSuite21691;
		public override global::java.lang.String getCipherSuite()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.SecureCacheResponse_.staticClass, "getCipherSuite", "()Ljava/lang/String;", ref global::java.net.SecureCacheResponse_._getCipherSuite21691) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalCertificateChain21692;
		public override global::java.util.List getLocalCertificateChain()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.net.SecureCacheResponse_.staticClass, "getLocalCertificateChain", "()Ljava/util/List;", ref global::java.net.SecureCacheResponse_._getLocalCertificateChain21692) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getServerCertificateChain21693;
		public override global::java.util.List getServerCertificateChain()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.net.SecureCacheResponse_.staticClass, "getServerCertificateChain", "()Ljava/util/List;", ref global::java.net.SecureCacheResponse_._getServerCertificateChain21693) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getPeerPrincipal21694;
		public override global::java.security.Principal getPeerPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::java.net.SecureCacheResponse_.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;", ref global::java.net.SecureCacheResponse_._getPeerPrincipal21694) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPrincipal21695;
		public override global::java.security.Principal getLocalPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::java.net.SecureCacheResponse_.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;", ref global::java.net.SecureCacheResponse_._getLocalPrincipal21695) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders21696;
		public override global::java.util.Map getHeaders()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::java.net.SecureCacheResponse_.staticClass, "getHeaders", "()Ljava/util/Map;", ref global::java.net.SecureCacheResponse_._getHeaders21696) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getBody21697;
		public override global::java.io.InputStream getBody()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.SecureCacheResponse_.staticClass, "getBody", "()Ljava/io/InputStream;", ref global::java.net.SecureCacheResponse_._getBody21697) as java.io.InputStream;
		}
		static SecureCacheResponse_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SecureCacheResponse_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SecureCacheResponse"));
		}
		internal static void InitJNI()
		{
		}
	}
}
