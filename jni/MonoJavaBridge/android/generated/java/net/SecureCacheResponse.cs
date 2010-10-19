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
		internal static global::MonoJavaBridge.MethodId _getCipherSuite15986;
		public abstract global::java.lang.String getCipherSuite();
		internal static global::MonoJavaBridge.MethodId _getLocalCertificateChain15987;
		public abstract global::java.util.List getLocalCertificateChain();
		internal static global::MonoJavaBridge.MethodId _getServerCertificateChain15988;
		public abstract global::java.util.List getServerCertificateChain();
		internal static global::MonoJavaBridge.MethodId _getPeerPrincipal15989;
		public abstract global::java.security.Principal getPeerPrincipal();
		internal static global::MonoJavaBridge.MethodId _getLocalPrincipal15990;
		public abstract global::java.security.Principal getLocalPrincipal();
		internal static global::MonoJavaBridge.MethodId _SecureCacheResponse15991;
		public SecureCacheResponse()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SecureCacheResponse.staticClass, global::java.net.SecureCacheResponse._SecureCacheResponse15991);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SecureCacheResponse.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SecureCacheResponse"));
			global::java.net.SecureCacheResponse._getCipherSuite15986 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse.staticClass, "getCipherSuite", "()Ljava/lang/String;");
			global::java.net.SecureCacheResponse._getLocalCertificateChain15987 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse.staticClass, "getLocalCertificateChain", "()Ljava/util/List;");
			global::java.net.SecureCacheResponse._getServerCertificateChain15988 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse.staticClass, "getServerCertificateChain", "()Ljava/util/List;");
			global::java.net.SecureCacheResponse._getPeerPrincipal15989 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;");
			global::java.net.SecureCacheResponse._getLocalPrincipal15990 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;");
			global::java.net.SecureCacheResponse._SecureCacheResponse15991 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.SecureCacheResponse))]
	public sealed partial class SecureCacheResponse_ : java.net.SecureCacheResponse
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SecureCacheResponse_()
		{
			InitJNI();
		}
		internal SecureCacheResponse_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCipherSuite15992;
		public override global::java.lang.String getCipherSuite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_._getCipherSuite15992)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_.staticClass, global::java.net.SecureCacheResponse_._getCipherSuite15992)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalCertificateChain15993;
		public override global::java.util.List getLocalCertificateChain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_._getLocalCertificateChain15993)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_.staticClass, global::java.net.SecureCacheResponse_._getLocalCertificateChain15993)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getServerCertificateChain15994;
		public override global::java.util.List getServerCertificateChain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_._getServerCertificateChain15994)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_.staticClass, global::java.net.SecureCacheResponse_._getServerCertificateChain15994)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getPeerPrincipal15995;
		public override global::java.security.Principal getPeerPrincipal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_._getPeerPrincipal15995)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_.staticClass, global::java.net.SecureCacheResponse_._getPeerPrincipal15995)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPrincipal15996;
		public override global::java.security.Principal getLocalPrincipal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_._getLocalPrincipal15996)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_.staticClass, global::java.net.SecureCacheResponse_._getLocalPrincipal15996)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders15997;
		public override global::java.util.Map getHeaders() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_._getHeaders15997)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_.staticClass, global::java.net.SecureCacheResponse_._getHeaders15997)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getBody15998;
		public override global::java.io.InputStream getBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_._getBody15998)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.SecureCacheResponse_.staticClass, global::java.net.SecureCacheResponse_._getBody15998)) as java.io.InputStream;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SecureCacheResponse_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SecureCacheResponse"));
			global::java.net.SecureCacheResponse_._getCipherSuite15992 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse_.staticClass, "getCipherSuite", "()Ljava/lang/String;");
			global::java.net.SecureCacheResponse_._getLocalCertificateChain15993 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse_.staticClass, "getLocalCertificateChain", "()Ljava/util/List;");
			global::java.net.SecureCacheResponse_._getServerCertificateChain15994 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse_.staticClass, "getServerCertificateChain", "()Ljava/util/List;");
			global::java.net.SecureCacheResponse_._getPeerPrincipal15995 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse_.staticClass, "getPeerPrincipal", "()Ljava/security/Principal;");
			global::java.net.SecureCacheResponse_._getLocalPrincipal15996 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse_.staticClass, "getLocalPrincipal", "()Ljava/security/Principal;");
			global::java.net.SecureCacheResponse_._getHeaders15997 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse_.staticClass, "getHeaders", "()Ljava/util/Map;");
			global::java.net.SecureCacheResponse_._getBody15998 = @__env.GetMethodIDNoThrow(global::java.net.SecureCacheResponse_.staticClass, "getBody", "()Ljava/io/InputStream;");
		}
	}
}
