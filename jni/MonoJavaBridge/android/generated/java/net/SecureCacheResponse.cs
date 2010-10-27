namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.SecureCacheResponse_))]
	public abstract partial class SecureCacheResponse : java.net.CacheResponse
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SecureCacheResponse()
		{
			InitJNI();
		}
		protected SecureCacheResponse(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCipherSuite21684;
		public abstract global::java.lang.String getCipherSuite();
		internal static global::MonoJavaBridge.MethodId _getLocalCertificateChain21685;
		public abstract global::java.util.List getLocalCertificateChain();
		internal static global::MonoJavaBridge.MethodId _getServerCertificateChain21686;
		public abstract global::java.util.List getServerCertificateChain();
		internal static global::MonoJavaBridge.MethodId _getPeerPrincipal21687;
		public abstract global::java.security.Principal getPeerPrincipal();
		internal static global::MonoJavaBridge.MethodId _getLocalPrincipal21688;
		public abstract global::java.security.Principal getLocalPrincipal();
		internal static global::MonoJavaBridge.MethodId _SecureCacheResponse21689;
		public SecureCacheResponse() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SecureCacheResponse.staticClass, global::java.net.SecureCacheResponse._SecureCacheResponse21689);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SecureCacheResponse.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SecureCacheResponse"));
			global::java.net.SecureCacheResponse._getCipherSuite21684 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse.staticClass, "getCipherSuite", "()Ljava/lang/String;");
			global::java.net.SecureCacheResponse._getLocalCertificateChain21685 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse.staticClass, "getLocalCertificateChain", "()Ljava/util/List;");
			global::java.net.SecureCacheResponse._getServerCertificateChain21686 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse.staticClass, "getServerCertificateChain", "()Ljava/util/List;");
			global::java.net.SecureCacheResponse._getPeerPrincipal21687 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;");
			global::java.net.SecureCacheResponse._getLocalPrincipal21688 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;");
			global::java.net.SecureCacheResponse._SecureCacheResponse21689 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.SecureCacheResponse))]
	internal sealed partial class SecureCacheResponse_ : java.net.SecureCacheResponse
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SecureCacheResponse_()
		{
			InitJNI();
		}
		internal SecureCacheResponse_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCipherSuite21690;
		public override global::java.lang.String getCipherSuite()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_._getCipherSuite21690)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_.staticClass, global::java.net.SecureCacheResponse_._getCipherSuite21690)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalCertificateChain21691;
		public override global::java.util.List getLocalCertificateChain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_._getLocalCertificateChain21691)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_.staticClass, global::java.net.SecureCacheResponse_._getLocalCertificateChain21691)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getServerCertificateChain21692;
		public override global::java.util.List getServerCertificateChain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_._getServerCertificateChain21692)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_.staticClass, global::java.net.SecureCacheResponse_._getServerCertificateChain21692)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getPeerPrincipal21693;
		public override global::java.security.Principal getPeerPrincipal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_._getPeerPrincipal21693)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_.staticClass, global::java.net.SecureCacheResponse_._getPeerPrincipal21693)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPrincipal21694;
		public override global::java.security.Principal getLocalPrincipal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_._getLocalPrincipal21694)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_.staticClass, global::java.net.SecureCacheResponse_._getLocalPrincipal21694)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders21695;
		public override global::java.util.Map getHeaders()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_._getHeaders21695)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_.staticClass, global::java.net.SecureCacheResponse_._getHeaders21695)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getBody21696;
		public override global::java.io.InputStream getBody()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_._getBody21696)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_.staticClass, global::java.net.SecureCacheResponse_._getBody21696)) as java.io.InputStream;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SecureCacheResponse_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SecureCacheResponse"));
			global::java.net.SecureCacheResponse_._getCipherSuite21690 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse_.staticClass, "getCipherSuite", "()Ljava/lang/String;");
			global::java.net.SecureCacheResponse_._getLocalCertificateChain21691 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse_.staticClass, "getLocalCertificateChain", "()Ljava/util/List;");
			global::java.net.SecureCacheResponse_._getServerCertificateChain21692 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse_.staticClass, "getServerCertificateChain", "()Ljava/util/List;");
			global::java.net.SecureCacheResponse_._getPeerPrincipal21693 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse_.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;");
			global::java.net.SecureCacheResponse_._getLocalPrincipal21694 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse_.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;");
			global::java.net.SecureCacheResponse_._getHeaders21695 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse_.staticClass, "getHeaders", "()Ljava/util/Map;");
			global::java.net.SecureCacheResponse_._getBody21696 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse_.staticClass, "getBody", "()Ljava/io/InputStream;");
		}
	}
}
