namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertificateFactory()
		{
			InitJNI();
		}
		protected CertificateFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23581;
		public static global::java.security.cert.CertificateFactory getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getInstance23581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertificateFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23582;
		public static global::java.security.cert.CertificateFactory getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getInstance23582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertificateFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23583;
		public static global::java.security.cert.CertificateFactory getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getInstance23583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertificateFactory;
		}
		public new global::java.lang.String Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType23584;
		public virtual global::java.lang.String getType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._getType23584)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getType23584)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _generateCertificate23585;
		public virtual global::java.security.cert.Certificate generateCertificate(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCertificate23585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCertificate23585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _generateCertPath23586;
		public virtual global::java.security.cert.CertPath generateCertPath(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCertPath23586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCertPath23586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _generateCertPath23587;
		public virtual global::java.security.cert.CertPath generateCertPath(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCertPath23587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCertPath23587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _generateCertPath23588;
		public virtual global::java.security.cert.CertPath generateCertPath(java.io.InputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCertPath23588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCertPath23588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPath;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23589;
		public virtual global::java.security.Provider getProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._getProvider23589)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getProvider23589)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _generateCRL23590;
		public virtual global::java.security.cert.CRL generateCRL(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCRL23590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CRL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCRL23590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CRL;
		}
		public new global::java.util.Iterator CertPathEncodings
		{
			get
			{
				return getCertPathEncodings();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCertPathEncodings23591;
		public virtual global::java.util.Iterator getCertPathEncodings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._getCertPathEncodings23591)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getCertPathEncodings23591)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _generateCertificates23592;
		public virtual global::java.util.Collection generateCertificates(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCertificates23592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCertificates23592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _generateCRLs23593;
		public virtual global::java.util.Collection generateCRLs(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCRLs23593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCRLs23593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _CertificateFactory23594;
		protected CertificateFactory(java.security.cert.CertificateFactorySpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._CertificateFactory23594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateFactory"));
			global::java.security.cert.CertificateFactory._getInstance23581 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertificateFactory;");
			global::java.security.cert.CertificateFactory._getInstance23582 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertificateFactory;");
			global::java.security.cert.CertificateFactory._getInstance23583 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertificateFactory;");
			global::java.security.cert.CertificateFactory._getType23584 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.cert.CertificateFactory._generateCertificate23585 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;");
			global::java.security.cert.CertificateFactory._generateCertPath23586 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactory._generateCertPath23587 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactory._generateCertPath23588 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCertPath", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactory._getProvider23589 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.cert.CertificateFactory._generateCRL23590 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;");
			global::java.security.cert.CertificateFactory._getCertPathEncodings23591 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getCertPathEncodings", "()Ljava/util/Iterator;");
			global::java.security.cert.CertificateFactory._generateCertificates23592 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactory._generateCRLs23593 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactory._CertificateFactory23594 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "<init>", "(Ljava/security/cert/CertificateFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
