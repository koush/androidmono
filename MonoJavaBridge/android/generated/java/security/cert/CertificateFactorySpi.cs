namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.CertificateFactorySpi_))]
	public abstract partial class CertificateFactorySpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertificateFactorySpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificate23595;
		public abstract global::java.security.cert.Certificate engineGenerateCertificate(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetCertPathEncodings23596;
		public virtual global::java.util.Iterator engineGetCertPathEncodings()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGetCertPathEncodings23596)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertPath23597;
		public virtual global::java.security.cert.CertPath engineGenerateCertPath(java.util.List arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertPath23598;
		public virtual global::java.security.cert.CertPath engineGenerateCertPath(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertPath23599;
		public virtual global::java.security.cert.CertPath engineGenerateCertPath(java.io.InputStream arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificates23600;
		public abstract global::java.util.Collection engineGenerateCertificates(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRL23601;
		public abstract global::java.security.cert.CRL engineGenerateCRL(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRLs23602;
		public abstract global::java.util.Collection engineGenerateCRLs(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _CertificateFactorySpi23603;
		public CertificateFactorySpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._CertificateFactorySpi23603);
			Init(@__env, handle);
		}
		static CertificateFactorySpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateFactorySpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateFactorySpi"));
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertificate23595 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;");
			global::java.security.cert.CertificateFactorySpi._engineGetCertPathEncodings23596 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGetCertPathEncodings", "()Ljava/util/Iterator;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23597 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23598 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23599 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertPath", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertificates23600 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCRL23601 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCRLs23602 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactorySpi._CertificateFactorySpi23603 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertificateFactorySpi))]
	internal sealed partial class CertificateFactorySpi_ : java.security.cert.CertificateFactorySpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CertificateFactorySpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificate23604;
		public override global::java.security.cert.Certificate engineGenerateCertificate(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificate23604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificates23605;
		public override global::java.util.Collection engineGenerateCertificates(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificates23605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRL23606;
		public override global::java.security.cert.CRL engineGenerateCRL(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCRL23606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CRL;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRLs23607;
		public override global::java.util.Collection engineGenerateCRLs(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCRLs23607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		static CertificateFactorySpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateFactorySpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateFactorySpi"));
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificate23604 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;");
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificates23605 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCRL23606 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;");
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCRLs23607 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;");
		}
		internal static void InitJNI()
		{
		}
	}
}
