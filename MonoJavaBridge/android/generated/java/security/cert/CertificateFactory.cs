namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertificateFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.security.cert.CertificateFactory getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateFactory._m0.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertificateFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertificateFactory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.security.cert.CertificateFactory getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateFactory._m1.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateFactory._m1 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertificateFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertificateFactory;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.security.cert.CertificateFactory getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateFactory._m2.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateFactory._m2 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertificateFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertificateFactory;
		}
		public new global::java.lang.String Type
		{
			get
			{
				return getType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.CertificateFactory.staticClass, "getType", "()Ljava/lang/String;", ref global::java.security.cert.CertificateFactory._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.security.cert.Certificate generateCertificate(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertificateFactory.staticClass, "generateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;", ref global::java.security.cert.CertificateFactory._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.Certificate;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.security.cert.CertPath generateCertPath(java.util.List arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertificateFactory.staticClass, "generateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;", ref global::java.security.cert.CertificateFactory._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.CertPath;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.security.cert.CertPath generateCertPath(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertificateFactory.staticClass, "generateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;", ref global::java.security.cert.CertificateFactory._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.CertPath;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.security.cert.CertPath generateCertPath(java.io.InputStream arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertificateFactory.staticClass, "generateCertPath", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/security/cert/CertPath;", ref global::java.security.cert.CertificateFactory._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.cert.CertPath;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertificateFactory.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::java.security.cert.CertificateFactory._m8) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.security.cert.CRL generateCRL(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertificateFactory.staticClass, "generateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;", ref global::java.security.cert.CertificateFactory._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.CRL;
		}
		public new global::java.util.Iterator CertPathEncodings
		{
			get
			{
				return getCertPathEncodings();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.util.Iterator getCertPathEncodings()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.security.cert.CertificateFactory.staticClass, "getCertPathEncodings", "()Ljava/util/Iterator;", ref global::java.security.cert.CertificateFactory._m10) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.util.Collection generateCertificates(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.CertificateFactory.staticClass, "generateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;", ref global::java.security.cert.CertificateFactory._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.util.Collection generateCRLs(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.CertificateFactory.staticClass, "generateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;", ref global::java.security.cert.CertificateFactory._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected CertificateFactory(java.security.cert.CertificateFactorySpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateFactory._m13.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateFactory._m13 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateFactory.staticClass, "<init>", "(Ljava/security/cert/CertificateFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateFactory.staticClass, global::java.security.cert.CertificateFactory._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static CertificateFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateFactory"));
		}
	}
}
