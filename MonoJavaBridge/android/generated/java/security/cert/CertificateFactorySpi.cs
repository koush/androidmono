namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.CertificateFactorySpi_))]
	public abstract partial class CertificateFactorySpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertificateFactorySpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.security.cert.Certificate engineGenerateCertificate(java.io.InputStream arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.util.Iterator engineGetCertPathEncodings()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.security.cert.CertificateFactorySpi.staticClass, "engineGetCertPathEncodings", "()Ljava/util/Iterator;", ref global::java.security.cert.CertificateFactorySpi._m1) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.security.cert.CertPath engineGenerateCertPath(java.util.List arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;", ref global::java.security.cert.CertificateFactorySpi._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.CertPath;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.security.cert.CertPath engineGenerateCertPath(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;", ref global::java.security.cert.CertificateFactorySpi._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.CertPath;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.security.cert.CertPath engineGenerateCertPath(java.io.InputStream arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertPath", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/security/cert/CertPath;", ref global::java.security.cert.CertificateFactorySpi._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.cert.CertPath;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.util.Collection engineGenerateCertificates(java.io.InputStream arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::java.security.cert.CRL engineGenerateCRL(java.io.InputStream arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::java.util.Collection engineGenerateCRLs(java.io.InputStream arg0);
		private static global::MonoJavaBridge.MethodId _m8;
		public CertificateFactorySpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateFactorySpi._m8.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateFactorySpi._m8 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._m8);
			Init(@__env, handle);
		}
		static CertificateFactorySpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateFactorySpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateFactorySpi"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertificateFactorySpi))]
	internal sealed partial class CertificateFactorySpi_ : java.security.cert.CertificateFactorySpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CertificateFactorySpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.security.cert.Certificate engineGenerateCertificate(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;", ref global::java.security.cert.CertificateFactorySpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.Certificate;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.util.Collection engineGenerateCertificates(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;", ref global::java.security.cert.CertificateFactorySpi_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.security.cert.CRL engineGenerateCRL(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;", ref global::java.security.cert.CertificateFactorySpi_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.CRL;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.util.Collection engineGenerateCRLs(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;", ref global::java.security.cert.CertificateFactorySpi_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Collection;
		}
		static CertificateFactorySpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateFactorySpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateFactorySpi"));
		}
	}
}
