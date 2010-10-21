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
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificate23476;
		public abstract global::java.security.cert.Certificate engineGenerateCertificate(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetCertPathEncodings23477;
		public virtual global::java.util.Iterator engineGetCertPathEncodings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi._engineGetCertPathEncodings23477)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGetCertPathEncodings23477)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertPath23478;
		public virtual global::java.security.cert.CertPath engineGenerateCertPath(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertPath23479;
		public virtual global::java.security.cert.CertPath engineGenerateCertPath(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertPath23480;
		public virtual global::java.security.cert.CertPath engineGenerateCertPath(java.io.InputStream arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificates23481;
		public abstract global::java.util.Collection engineGenerateCertificates(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRL23482;
		public abstract global::java.security.cert.CRL engineGenerateCRL(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRLs23483;
		public abstract global::java.util.Collection engineGenerateCRLs(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _CertificateFactorySpi23484;
		public CertificateFactorySpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._CertificateFactorySpi23484);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateFactorySpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateFactorySpi"));
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertificate23476 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;");
			global::java.security.cert.CertificateFactorySpi._engineGetCertPathEncodings23477 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGetCertPathEncodings", "()Ljava/util/Iterator;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23478 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23479 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath23480 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertPath", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertificates23481 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCRL23482 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCRLs23483 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactorySpi._CertificateFactorySpi23484 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertificateFactorySpi))]
	public sealed partial class CertificateFactorySpi_ : java.security.cert.CertificateFactorySpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertificateFactorySpi_()
		{
			InitJNI();
		}
		internal CertificateFactorySpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificate23485;
		public override global::java.security.cert.Certificate engineGenerateCertificate(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificate23485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_.staticClass, global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificate23485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificates23486;
		public override global::java.util.Collection engineGenerateCertificates(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificates23486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_.staticClass, global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificates23486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRL23487;
		public override global::java.security.cert.CRL engineGenerateCRL(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCRL23487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CRL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_.staticClass, global::java.security.cert.CertificateFactorySpi_._engineGenerateCRL23487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CRL;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRLs23488;
		public override global::java.util.Collection engineGenerateCRLs(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCRLs23488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_.staticClass, global::java.security.cert.CertificateFactorySpi_._engineGenerateCRLs23488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateFactorySpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateFactorySpi"));
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificate23485 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;");
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificates23486 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCRL23487 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;");
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCRLs23488 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;");
		}
	}
}
