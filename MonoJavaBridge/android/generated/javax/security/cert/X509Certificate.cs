namespace javax.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.security.cert.X509Certificate_))]
	public abstract partial class X509Certificate : javax.security.cert.Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected X509Certificate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance30247;
		public static global::javax.security.cert.X509Certificate getInstance(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.cert.X509Certificate._getInstance30247.native == global::System.IntPtr.Zero)
				global::javax.security.cert.X509Certificate._getInstance30247 = @__env.GetStaticMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getInstance", "([B)Ljavax/security/cert/X509Certificate;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._getInstance30247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.security.cert.X509Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance30248;
		public static global::javax.security.cert.X509Certificate getInstance(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.cert.X509Certificate._getInstance30248.native == global::System.IntPtr.Zero)
				global::javax.security.cert.X509Certificate._getInstance30248 = @__env.GetStaticMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getInstance", "(Ljava/io/InputStream;)Ljavax/security/cert/X509Certificate;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._getInstance30248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.security.cert.X509Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion30249;
		public abstract int getVersion();
		internal static global::MonoJavaBridge.MethodId _getSerialNumber30250;
		public abstract global::java.math.BigInteger getSerialNumber();
		internal static global::MonoJavaBridge.MethodId _getIssuerDN30251;
		public abstract global::java.security.Principal getIssuerDN();
		internal static global::MonoJavaBridge.MethodId _checkValidity30252;
		public abstract void checkValidity();
		internal static global::MonoJavaBridge.MethodId _checkValidity30253;
		public abstract void checkValidity(java.util.Date arg0);
		internal static global::MonoJavaBridge.MethodId _getSubjectDN30254;
		public abstract global::java.security.Principal getSubjectDN();
		internal static global::MonoJavaBridge.MethodId _getNotBefore30255;
		public abstract global::java.util.Date getNotBefore();
		internal static global::MonoJavaBridge.MethodId _getNotAfter30256;
		public abstract global::java.util.Date getNotAfter();
		internal static global::MonoJavaBridge.MethodId _getSigAlgName30257;
		public abstract global::java.lang.String getSigAlgName();
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID30258;
		public abstract global::java.lang.String getSigAlgOID();
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams30259;
		public abstract byte[] getSigAlgParams();
		internal static global::MonoJavaBridge.MethodId _X509Certificate30260;
		public X509Certificate() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.cert.X509Certificate._X509Certificate30260.native == global::System.IntPtr.Zero)
				global::javax.security.cert.X509Certificate._X509Certificate30260 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._X509Certificate30260);
			Init(@__env, handle);
		}
		static X509Certificate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.X509Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/X509Certificate"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.security.cert.X509Certificate))]
	internal sealed partial class X509Certificate_ : javax.security.cert.X509Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal X509Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getVersion30261;
		public override int getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "getVersion", "()I", ref global::javax.security.cert.X509Certificate_._getVersion30261);
		}
		internal static global::MonoJavaBridge.MethodId _getSerialNumber30262;
		public override global::java.math.BigInteger getSerialNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;", ref global::javax.security.cert.X509Certificate_._getSerialNumber30262) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerDN30263;
		public override global::java.security.Principal getIssuerDN()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::javax.security.cert.X509Certificate_.staticClass, "getIssuerDN", "()Ljava/security/Principal;", ref global::javax.security.cert.X509Certificate_._getIssuerDN30263) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity30264;
		public override void checkValidity()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "checkValidity", "()V", ref global::javax.security.cert.X509Certificate_._checkValidity30264);
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity30265;
		public override void checkValidity(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "checkValidity", "(Ljava/util/Date;)V", ref global::javax.security.cert.X509Certificate_._checkValidity30265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectDN30266;
		public override global::java.security.Principal getSubjectDN()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::javax.security.cert.X509Certificate_.staticClass, "getSubjectDN", "()Ljava/security/Principal;", ref global::javax.security.cert.X509Certificate_._getSubjectDN30266) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getNotBefore30267;
		public override global::java.util.Date getNotBefore()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "getNotBefore", "()Ljava/util/Date;", ref global::javax.security.cert.X509Certificate_._getNotBefore30267) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getNotAfter30268;
		public override global::java.util.Date getNotAfter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "getNotAfter", "()Ljava/util/Date;", ref global::javax.security.cert.X509Certificate_._getNotAfter30268) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName30269;
		public override global::java.lang.String getSigAlgName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.security.cert.X509Certificate_.staticClass, "getSigAlgName", "()Ljava/lang/String;", ref global::javax.security.cert.X509Certificate_._getSigAlgName30269) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID30270;
		public override global::java.lang.String getSigAlgOID()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.security.cert.X509Certificate_.staticClass, "getSigAlgOID", "()Ljava/lang/String;", ref global::javax.security.cert.X509Certificate_._getSigAlgOID30270) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams30271;
		public override byte[] getSigAlgParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.security.cert.X509Certificate_.staticClass, "getSigAlgParams", "()[B", ref global::javax.security.cert.X509Certificate_._getSigAlgParams30271) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _toString30272;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.security.cert.X509Certificate_.staticClass, "toString", "()Ljava/lang/String;", ref global::javax.security.cert.X509Certificate_._toString30272) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded30273;
		public override byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.security.cert.X509Certificate_.staticClass, "getEncoded", "()[B", ref global::javax.security.cert.X509Certificate_._getEncoded30273) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify30274;
		public override void verify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V", ref global::javax.security.cert.X509Certificate_._verify30274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify30275;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V", ref global::javax.security.cert.X509Certificate_._verify30275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey30276;
		public override global::java.security.PublicKey getPublicKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::javax.security.cert.X509Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;", ref global::javax.security.cert.X509Certificate_._getPublicKey30276) as java.security.PublicKey;
		}
		static X509Certificate_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.X509Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/X509Certificate"));
		}
		internal static void InitJNI()
		{
		}
	}
}
