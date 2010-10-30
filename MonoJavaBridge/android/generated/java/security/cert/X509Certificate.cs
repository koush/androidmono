namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.X509Certificate_))]
	public abstract partial class X509Certificate : java.security.cert.Certificate, X509Extension
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected X509Certificate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23838;
		public abstract bool hasUnsupportedCriticalExtension();
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23839;
		public abstract global::java.util.Set getCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23840;
		public abstract global::java.util.Set getNonCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23841;
		public abstract byte[] getExtensionValue(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getSignature23842;
		public abstract byte[] getSignature();
		internal static global::MonoJavaBridge.MethodId _getBasicConstraints23843;
		public abstract int getBasicConstraints();
		internal static global::MonoJavaBridge.MethodId _getVersion23844;
		public abstract int getVersion();
		internal static global::MonoJavaBridge.MethodId _getSerialNumber23845;
		public abstract global::java.math.BigInteger getSerialNumber();
		internal static global::MonoJavaBridge.MethodId _getIssuerDN23846;
		public abstract global::java.security.Principal getIssuerDN();
		internal static global::MonoJavaBridge.MethodId _getTBSCertificate23847;
		public abstract byte[] getTBSCertificate();
		internal static global::MonoJavaBridge.MethodId _checkValidity23848;
		public abstract void checkValidity();
		internal static global::MonoJavaBridge.MethodId _checkValidity23849;
		public abstract void checkValidity(java.util.Date arg0);
		internal static global::MonoJavaBridge.MethodId _getIssuerX500Principal23850;
		public virtual global::javax.security.auth.x500.X500Principal getIssuerX500Principal()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<javax.security.auth.x500.X500Principal>(this, global::java.security.cert.X509Certificate.staticClass, "getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;", ref global::java.security.cert.X509Certificate._getIssuerX500Principal23850) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectDN23851;
		public abstract global::java.security.Principal getSubjectDN();
		internal static global::MonoJavaBridge.MethodId _getSubjectX500Principal23852;
		public virtual global::javax.security.auth.x500.X500Principal getSubjectX500Principal()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<javax.security.auth.x500.X500Principal>(this, global::java.security.cert.X509Certificate.staticClass, "getSubjectX500Principal", "()Ljavax/security/auth/x500/X500Principal;", ref global::java.security.cert.X509Certificate._getSubjectX500Principal23852) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getNotBefore23853;
		public abstract global::java.util.Date getNotBefore();
		internal static global::MonoJavaBridge.MethodId _getNotAfter23854;
		public abstract global::java.util.Date getNotAfter();
		internal static global::MonoJavaBridge.MethodId _getSigAlgName23855;
		public abstract global::java.lang.String getSigAlgName();
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID23856;
		public abstract global::java.lang.String getSigAlgOID();
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams23857;
		public abstract byte[] getSigAlgParams();
		internal static global::MonoJavaBridge.MethodId _getIssuerUniqueID23858;
		public abstract bool[] getIssuerUniqueID();
		internal static global::MonoJavaBridge.MethodId _getSubjectUniqueID23859;
		public abstract bool[] getSubjectUniqueID();
		internal static global::MonoJavaBridge.MethodId _getKeyUsage23860;
		public abstract bool[] getKeyUsage();
		internal static global::MonoJavaBridge.MethodId _getExtendedKeyUsage23861;
		public virtual global::java.util.List getExtendedKeyUsage()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.security.cert.X509Certificate.staticClass, "getExtendedKeyUsage", "()Ljava/util/List;", ref global::java.security.cert.X509Certificate._getExtendedKeyUsage23861) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectAlternativeNames23862;
		public virtual global::java.util.Collection getSubjectAlternativeNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.X509Certificate.staticClass, "getSubjectAlternativeNames", "()Ljava/util/Collection;", ref global::java.security.cert.X509Certificate._getSubjectAlternativeNames23862) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerAlternativeNames23863;
		public virtual global::java.util.Collection getIssuerAlternativeNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.X509Certificate.staticClass, "getIssuerAlternativeNames", "()Ljava/util/Collection;", ref global::java.security.cert.X509Certificate._getIssuerAlternativeNames23863) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _X509Certificate23864;
		protected X509Certificate() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.X509Certificate._X509Certificate23864.native == global::System.IntPtr.Zero)
				global::java.security.cert.X509Certificate._X509Certificate23864 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._X509Certificate23864);
			Init(@__env, handle);
		}
		static X509Certificate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509Certificate"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.X509Certificate))]
	internal sealed partial class X509Certificate_ : java.security.cert.X509Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal X509Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23865;
		public override bool hasUnsupportedCriticalExtension()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509Certificate_.staticClass, "hasUnsupportedCriticalExtension", "()Z", ref global::java.security.cert.X509Certificate_._hasUnsupportedCriticalExtension23865);
		}
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23866;
		public override global::java.util.Set getCriticalExtensionOIDs()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.X509Certificate_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;", ref global::java.security.cert.X509Certificate_._getCriticalExtensionOIDs23866) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23867;
		public override global::java.util.Set getNonCriticalExtensionOIDs()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.X509Certificate_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;", ref global::java.security.cert.X509Certificate_._getNonCriticalExtensionOIDs23867) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23868;
		public override byte[] getExtensionValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509Certificate_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B", ref global::java.security.cert.X509Certificate_._getExtensionValue23868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getSignature23869;
		public override byte[] getSignature()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509Certificate_.staticClass, "getSignature", "()[B", ref global::java.security.cert.X509Certificate_._getSignature23869) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getBasicConstraints23870;
		public override int getBasicConstraints()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.X509Certificate_.staticClass, "getBasicConstraints", "()I", ref global::java.security.cert.X509Certificate_._getBasicConstraints23870);
		}
		internal static global::MonoJavaBridge.MethodId _getVersion23871;
		public override int getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.X509Certificate_.staticClass, "getVersion", "()I", ref global::java.security.cert.X509Certificate_._getVersion23871);
		}
		internal static global::MonoJavaBridge.MethodId _getSerialNumber23872;
		public override global::java.math.BigInteger getSerialNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509Certificate_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;", ref global::java.security.cert.X509Certificate_._getSerialNumber23872) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerDN23873;
		public override global::java.security.Principal getIssuerDN()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::java.security.cert.X509Certificate_.staticClass, "getIssuerDN", "()Ljava/security/Principal;", ref global::java.security.cert.X509Certificate_._getIssuerDN23873) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getTBSCertificate23874;
		public override byte[] getTBSCertificate()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509Certificate_.staticClass, "getTBSCertificate", "()[B", ref global::java.security.cert.X509Certificate_._getTBSCertificate23874) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity23875;
		public override void checkValidity()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509Certificate_.staticClass, "checkValidity", "()V", ref global::java.security.cert.X509Certificate_._checkValidity23875);
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity23876;
		public override void checkValidity(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509Certificate_.staticClass, "checkValidity", "(Ljava/util/Date;)V", ref global::java.security.cert.X509Certificate_._checkValidity23876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectDN23877;
		public override global::java.security.Principal getSubjectDN()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::java.security.cert.X509Certificate_.staticClass, "getSubjectDN", "()Ljava/security/Principal;", ref global::java.security.cert.X509Certificate_._getSubjectDN23877) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getNotBefore23878;
		public override global::java.util.Date getNotBefore()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509Certificate_.staticClass, "getNotBefore", "()Ljava/util/Date;", ref global::java.security.cert.X509Certificate_._getNotBefore23878) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getNotAfter23879;
		public override global::java.util.Date getNotAfter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509Certificate_.staticClass, "getNotAfter", "()Ljava/util/Date;", ref global::java.security.cert.X509Certificate_._getNotAfter23879) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName23880;
		public override global::java.lang.String getSigAlgName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509Certificate_.staticClass, "getSigAlgName", "()Ljava/lang/String;", ref global::java.security.cert.X509Certificate_._getSigAlgName23880) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID23881;
		public override global::java.lang.String getSigAlgOID()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509Certificate_.staticClass, "getSigAlgOID", "()Ljava/lang/String;", ref global::java.security.cert.X509Certificate_._getSigAlgOID23881) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams23882;
		public override byte[] getSigAlgParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509Certificate_.staticClass, "getSigAlgParams", "()[B", ref global::java.security.cert.X509Certificate_._getSigAlgParams23882) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerUniqueID23883;
		public override bool[] getIssuerUniqueID()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<bool>(this, global::java.security.cert.X509Certificate_.staticClass, "getIssuerUniqueID", "()[Z", ref global::java.security.cert.X509Certificate_._getIssuerUniqueID23883) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectUniqueID23884;
		public override bool[] getSubjectUniqueID()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<bool>(this, global::java.security.cert.X509Certificate_.staticClass, "getSubjectUniqueID", "()[Z", ref global::java.security.cert.X509Certificate_._getSubjectUniqueID23884) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getKeyUsage23885;
		public override bool[] getKeyUsage()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<bool>(this, global::java.security.cert.X509Certificate_.staticClass, "getKeyUsage", "()[Z", ref global::java.security.cert.X509Certificate_._getKeyUsage23885) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _toString23886;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509Certificate_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.X509Certificate_._toString23886) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23887;
		public override byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509Certificate_.staticClass, "getEncoded", "()[B", ref global::java.security.cert.X509Certificate_._getEncoded23887) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify23888;
		public override void verify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V", ref global::java.security.cert.X509Certificate_._verify23888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify23889;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V", ref global::java.security.cert.X509Certificate_._verify23889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey23890;
		public override global::java.security.PublicKey getPublicKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::java.security.cert.X509Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;", ref global::java.security.cert.X509Certificate_._getPublicKey23890) as java.security.PublicKey;
		}
		static X509Certificate_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509Certificate"));
		}
		internal static void InitJNI()
		{
		}
	}
}
