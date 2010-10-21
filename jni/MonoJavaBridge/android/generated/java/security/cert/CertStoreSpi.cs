namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.CertStoreSpi_))]
	public abstract partial class CertStoreSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertStoreSpi()
		{
			InitJNI();
		}
		protected CertStoreSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCertificates23430;
		public abstract global::java.util.Collection engineGetCertificates(java.security.cert.CertSelector arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetCRLs23431;
		public abstract global::java.util.Collection engineGetCRLs(java.security.cert.CRLSelector arg0);
		internal static global::MonoJavaBridge.MethodId _CertStoreSpi23432;
		public CertStoreSpi(java.security.cert.CertStoreParameters arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertStoreSpi.staticClass, global::java.security.cert.CertStoreSpi._CertStoreSpi23432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertStoreSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertStoreSpi"));
			global::java.security.cert.CertStoreSpi._engineGetCertificates23430 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreSpi.staticClass, "engineGetCertificates", "(Ljava/security/cert/CertSelector;)Ljava/util/Collection;");
			global::java.security.cert.CertStoreSpi._engineGetCRLs23431 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreSpi.staticClass, "engineGetCRLs", "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;");
			global::java.security.cert.CertStoreSpi._CertStoreSpi23432 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreSpi.staticClass, "<init>", "(Ljava/security/cert/CertStoreParameters;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertStoreSpi))]
	public sealed partial class CertStoreSpi_ : java.security.cert.CertStoreSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertStoreSpi_()
		{
			InitJNI();
		}
		internal CertStoreSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCertificates23433;
		public override global::java.util.Collection engineGetCertificates(java.security.cert.CertSelector arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertStoreSpi_._engineGetCertificates23433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertStoreSpi_.staticClass, global::java.security.cert.CertStoreSpi_._engineGetCertificates23433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetCRLs23434;
		public override global::java.util.Collection engineGetCRLs(java.security.cert.CRLSelector arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertStoreSpi_._engineGetCRLs23434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertStoreSpi_.staticClass, global::java.security.cert.CertStoreSpi_._engineGetCRLs23434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertStoreSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertStoreSpi"));
			global::java.security.cert.CertStoreSpi_._engineGetCertificates23433 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreSpi_.staticClass, "engineGetCertificates", "(Ljava/security/cert/CertSelector;)Ljava/util/Collection;");
			global::java.security.cert.CertStoreSpi_._engineGetCRLs23434 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreSpi_.staticClass, "engineGetCRLs", "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;");
		}
	}
}
