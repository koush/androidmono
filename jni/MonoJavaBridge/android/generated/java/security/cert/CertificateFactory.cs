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
		internal static global::MonoJavaBridge.MethodId _getInstance17861;
		public static global::java.security.cert.CertificateFactory getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getInstance17861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertificateFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17862;
		public static global::java.security.cert.CertificateFactory getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getInstance17862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertificateFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17863;
		public static global::java.security.cert.CertificateFactory getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getInstance17863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertificateFactory;
		}
		public new global::java.lang.String Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType17864;
		public virtual global::java.lang.String getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._getType17864)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getType17864)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _generateCertificate17865;
		public virtual global::java.security.cert.Certificate generateCertificate(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCertificate17865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCertificate17865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _generateCertPath17866;
		public virtual global::java.security.cert.CertPath generateCertPath(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCertPath17866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCertPath17866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _generateCertPath17867;
		public virtual global::java.security.cert.CertPath generateCertPath(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCertPath17867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCertPath17867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _generateCertPath17868;
		public virtual global::java.security.cert.CertPath generateCertPath(java.io.InputStream arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCertPath17868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCertPath17868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPath;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider17869;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._getProvider17869)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getProvider17869)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _generateCRL17870;
		public virtual global::java.security.cert.CRL generateCRL(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCRL17870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CRL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCRL17870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CRL;
		}
		public new global::java.util.Iterator CertPathEncodings
		{
			get
			{
				return getCertPathEncodings();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCertPathEncodings17871;
		public virtual global::java.util.Iterator getCertPathEncodings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._getCertPathEncodings17871)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._getCertPathEncodings17871)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _generateCertificates17872;
		public virtual global::java.util.Collection generateCertificates(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCertificates17872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCertificates17872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _generateCRLs17873;
		public virtual global::java.util.Collection generateCRLs(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory._generateCRLs17873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._generateCRLs17873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _CertificateFactory17874;
		protected CertificateFactory(java.security.cert.CertificateFactorySpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._CertificateFactory17874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateFactory"));
			global::java.security.cert.CertificateFactory._getInstance17861 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertificateFactory;");
			global::java.security.cert.CertificateFactory._getInstance17862 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertificateFactory;");
			global::java.security.cert.CertificateFactory._getInstance17863 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertificateFactory;");
			global::java.security.cert.CertificateFactory._getType17864 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.cert.CertificateFactory._generateCertificate17865 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;");
			global::java.security.cert.CertificateFactory._generateCertPath17866 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactory._generateCertPath17867 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactory._generateCertPath17868 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCertPath", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/security/cert/CertPath;");
			global::java.security.cert.CertificateFactory._getProvider17869 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.cert.CertificateFactory._generateCRL17870 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;");
			global::java.security.cert.CertificateFactory._getCertPathEncodings17871 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getCertPathEncodings", "()Ljava/util/Iterator;");
			global::java.security.cert.CertificateFactory._generateCertificates17872 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactory._generateCRLs17873 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "generateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			global::java.security.cert.CertificateFactory._CertificateFactory17874 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "<init>", "(Ljava/security/cert/CertificateFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
