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
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificate17875;
		public abstract global::java.security.cert.Certificate engineGenerateCertificate(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetCertPathEncodings17876;
		public virtual global::java.util.Iterator engineGetCertPathEncodings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi._engineGetCertPathEncodings17876)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGetCertPathEncodings17876)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertPath17877;
		public virtual global::java.security.cert.CertPath engineGenerateCertPath(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath17877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath17877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertPath17878;
		public virtual global::java.security.cert.CertPath engineGenerateCertPath(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath17878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath17878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertPath17879;
		public virtual global::java.security.cert.CertPath engineGenerateCertPath(java.io.InputStream arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath17879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath17879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificates17880;
		public abstract global::java.util.Collection engineGenerateCertificates(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRL17881;
		public abstract global::java.security.cert.CRL engineGenerateCRL(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRLs17882;
		public abstract global::java.util.Collection engineGenerateCRLs(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _CertificateFactorySpi17883;
		public CertificateFactorySpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateFactorySpi.staticClass, global::java.security.cert.CertificateFactorySpi._CertificateFactorySpi17883);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateFactorySpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateFactorySpi"));
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertificate17875 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;");
			global::java.security.cert.CertificateFactorySpi._engineGetCertPathEncodings17876 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGetCertPathEncodings", "()Ljava/util/Iterator;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath17877 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath17878 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertPath17879 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertPath", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCertificates17880 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCRL17881 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;");
			global::java.security.cert.CertificateFactorySpi._engineGenerateCRLs17882 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactorySpi._CertificateFactorySpi17883 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificate17884;
		public override global::java.security.cert.Certificate engineGenerateCertificate(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificate17884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_.staticClass, global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificate17884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCertificates17885;
		public override global::java.util.Collection engineGenerateCertificates(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificates17885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_.staticClass, global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificates17885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRL17886;
		public override global::java.security.cert.CRL engineGenerateCRL(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCRL17886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CRL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_.staticClass, global::java.security.cert.CertificateFactorySpi_._engineGenerateCRL17886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CRL;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateCRLs17887;
		public override global::java.util.Collection engineGenerateCRLs(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_._engineGenerateCRLs17887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactorySpi_.staticClass, global::java.security.cert.CertificateFactorySpi_._engineGenerateCRLs17887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateFactorySpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateFactorySpi"));
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificate17884 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;");
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCertificates17885 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCRL17886 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;");
			global::java.security.cert.CertificateFactorySpi_._engineGenerateCRLs17887 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactorySpi_.staticClass, "engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;");
		}
	}
}
