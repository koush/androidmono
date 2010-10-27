namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.CertificateFactorySpi_))]
	public abstract partial class CertificateFactorySpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertificateFactorySpi()
		{
			InitJNI();
		}
		protected CertificateFactorySpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificate23594;
		public abstract global::java.security.cert.Certificate engineGenerateCertificate(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetCertPathEncodings23595;
		public virtual global::java.util.Iterator engineGetCertPathEncodings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi._engineGetCertPathEncodings23595)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGetCertPathEncodings23595)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertPath23596;
		public virtual global::java.security.cert.CertPath engineGenerateCertPath(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertPath23597;
		public virtual global::java.security.cert.CertPath engineGenerateCertPath(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertPath23598;
		public virtual global::java.security.cert.CertPath engineGenerateCertPath(java.io.InputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificates23599;
		public abstract global::java.util.Collection engineGenerateCertificates(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRL23600;
		public abstract global::java.security.cert.CRL engineGenerateCRL(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRLs23601;
		public abstract global::java.util.Collection engineGenerateCRLs(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _CertificateFactorySpi23602;
		public CertificateFactorySpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._CertificateFactorySpi23602);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateFactorySpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateFactorySpi"));
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertificate23594 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;");
			global::java.security.cert.CertificateFactorySpi._engineGetCertPathEncodings23595 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGetCertPathEncodings", "()Ljava/util/Iterator;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23596 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23597 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23598 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertPath", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertificates23599 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCRL23600 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCRLs23601 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactorySpi._CertificateFactorySpi23602 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertificateFactorySpi))]
	internal sealed partial class CertificateFactorySpi_ : java.security.cert.CertificateFactorySpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertificateFactorySpi_()
		{
			InitJNI();
		}
		internal CertificateFactorySpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificate23603;
		public override global::java.security.cert.Certificate engineGenerateCertificate(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificate23603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_.staticClass, global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificate23603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificates23604;
		public override global::java.util.Collection engineGenerateCertificates(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificates23604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_.staticClass, global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificates23604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRL23605;
		public override global::java.security.cert.CRL engineGenerateCRL(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCRL23605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CRL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_.staticClass, global::java.security.cert.CertificateFactorySpi_._engineGenerateCRL23605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CRL;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRLs23606;
		public override global::java.util.Collection engineGenerateCRLs(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCRLs23606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_.staticClass, global::java.security.cert.CertificateFactorySpi_._engineGenerateCRLs23606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateFactorySpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateFactorySpi"));
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificate23603 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;");
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificates23604 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCRL23605 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;");
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCRLs23606 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;");
		}
	}
}
