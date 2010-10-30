namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.CertStoreSpi_))]
	public abstract partial class CertStoreSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertStoreSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCertificates23549;
		public abstract global::java.util.Collection engineGetCertificates(java.security.cert.CertSelector arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetCRLs23550;
		public abstract global::java.util.Collection engineGetCRLs(java.security.cert.CRLSelector arg0);
		internal static global::MonoJavaBridge.MethodId _CertStoreSpi23551;
		public CertStoreSpi(java.security.cert.CertStoreParameters arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertStoreSpi._CertStoreSpi23551.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertStoreSpi._CertStoreSpi23551 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreSpi.staticClass, "<init>", "(Ljava/security/cert/CertStoreParameters;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertStoreSpi.staticClass, global::java.security.cert.CertStoreSpi._CertStoreSpi23551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CertStoreSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertStoreSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertStoreSpi"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertStoreSpi))]
	internal sealed partial class CertStoreSpi_ : java.security.cert.CertStoreSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CertStoreSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCertificates23552;
		public override global::java.util.Collection engineGetCertificates(java.security.cert.CertSelector arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.CertStoreSpi_.staticClass, "engineGetCertificates", "(Ljava/security/cert/CertSelector;)Ljava/util/Collection;", ref global::java.security.cert.CertStoreSpi_._engineGetCertificates23552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCRLs23553;
		public override global::java.util.Collection engineGetCRLs(java.security.cert.CRLSelector arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.CertStoreSpi_.staticClass, "engineGetCRLs", "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;", ref global::java.security.cert.CertStoreSpi_._engineGetCRLs23553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Collection;
		}
		static CertStoreSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertStoreSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertStoreSpi"));
		}
		internal static void InitJNI()
		{
		}
	}
}
