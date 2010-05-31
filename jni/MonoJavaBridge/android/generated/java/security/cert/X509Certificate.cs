namespace java.security.cert
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class X509Certificate : java.security.cert.Certificate, X509Extension
	{
		internal new static global::java.lang.Class staticClass;
		static X509Certificate()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.cert.X509Certificate), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected X509Certificate(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasUnsupportedCriticalExtension12497;
		public abstract bool hasUnsupportedCriticalExtension();
		internal static global::net.sf.jni4net.jni.MethodId _getCriticalExtensionOIDs12498;
		public abstract global::java.util.Set getCriticalExtensionOIDs();
		internal static global::net.sf.jni4net.jni.MethodId _getNonCriticalExtensionOIDs12499;
		public abstract global::java.util.Set getNonCriticalExtensionOIDs();
		internal static global::net.sf.jni4net.jni.MethodId _getExtensionValue12500;
		public abstract byte[] getExtensionValue(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getSignature12501;
		public abstract byte[] getSignature();
		internal static global::net.sf.jni4net.jni.MethodId _getVersion12502;
		public abstract int getVersion();
		internal static global::net.sf.jni4net.jni.MethodId _getSerialNumber12503;
		public abstract global::java.math.BigInteger getSerialNumber();
		internal static global::net.sf.jni4net.jni.MethodId _getIssuerDN12504;
		public abstract global::java.security.Principal getIssuerDN();
		internal static global::net.sf.jni4net.jni.MethodId _getTBSCertificate12505;
		public abstract byte[] getTBSCertificate();
		internal static global::net.sf.jni4net.jni.MethodId _checkValidity12506;
		public abstract void checkValidity();
		internal static global::net.sf.jni4net.jni.MethodId _checkValidity12507;
		public abstract void checkValidity(java.util.Date arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getIssuerX500Principal12508;
		public virtual global::javax.security.auth.x500.X500Principal getIssuerX500Principal() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.security.auth.x500.X500Principal>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.X509Certificate._getIssuerX500Principal12508));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.security.auth.x500.X500Principal>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getIssuerX500Principal12508));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSubjectDN12509;
		public abstract global::java.security.Principal getSubjectDN();
		internal static global::net.sf.jni4net.jni.MethodId _getSubjectX500Principal12510;
		public virtual global::javax.security.auth.x500.X500Principal getSubjectX500Principal() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.security.auth.x500.X500Principal>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.X509Certificate._getSubjectX500Principal12510));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.security.auth.x500.X500Principal>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getSubjectX500Principal12510));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNotBefore12511;
		public abstract global::java.util.Date getNotBefore();
		internal static global::net.sf.jni4net.jni.MethodId _getNotAfter12512;
		public abstract global::java.util.Date getNotAfter();
		internal static global::net.sf.jni4net.jni.MethodId _getSigAlgName12513;
		public abstract global::java.lang.String getSigAlgName();
		internal static global::net.sf.jni4net.jni.MethodId _getSigAlgOID12514;
		public abstract global::java.lang.String getSigAlgOID();
		internal static global::net.sf.jni4net.jni.MethodId _getSigAlgParams12515;
		public abstract byte[] getSigAlgParams();
		internal static global::net.sf.jni4net.jni.MethodId _getIssuerUniqueID12516;
		public abstract bool[] getIssuerUniqueID();
		internal static global::net.sf.jni4net.jni.MethodId _getSubjectUniqueID12517;
		public abstract bool[] getSubjectUniqueID();
		internal static global::net.sf.jni4net.jni.MethodId _getKeyUsage12518;
		public abstract bool[] getKeyUsage();
		internal static global::net.sf.jni4net.jni.MethodId _getExtendedKeyUsage12519;
		public virtual global::java.util.List getExtendedKeyUsage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.X509Certificate._getExtendedKeyUsage12519));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getExtendedKeyUsage12519));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBasicConstraints12520;
		public abstract int getBasicConstraints();
		internal static global::net.sf.jni4net.jni.MethodId _getSubjectAlternativeNames12521;
		public virtual global::java.util.Collection getSubjectAlternativeNames() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.X509Certificate._getSubjectAlternativeNames12521));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getSubjectAlternativeNames12521));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIssuerAlternativeNames12522;
		public virtual global::java.util.Collection getIssuerAlternativeNames() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.X509Certificate._getIssuerAlternativeNames12522));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getIssuerAlternativeNames12522));
		}
		internal static global::net.sf.jni4net.jni.MethodId _X509Certificate12523;
		protected X509Certificate()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._X509Certificate12523, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.cert.X509Certificate.staticClass = @__class;
			global::java.security.cert.X509Certificate._hasUnsupportedCriticalExtension12497 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509Certificate._getCriticalExtensionOIDs12498 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate._getNonCriticalExtensionOIDs12499 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate._getExtensionValue12500 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509Certificate._getSignature12501 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509Certificate._getVersion12502 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getVersion", "()I");
			global::java.security.cert.X509Certificate._getSerialNumber12503 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509Certificate._getIssuerDN12504 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate._getTBSCertificate12505 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getTBSCertificate", "()[B");
			global::java.security.cert.X509Certificate._checkValidity12506 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "checkValidity", "()V");
			global::java.security.cert.X509Certificate._checkValidity12507 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::java.security.cert.X509Certificate._getIssuerX500Principal12508 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509Certificate._getSubjectDN12509 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate._getSubjectX500Principal12510 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSubjectX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509Certificate._getNotBefore12511 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate._getNotAfter12512 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate._getSigAlgName12513 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate._getSigAlgOID12514 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate._getSigAlgParams12515 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509Certificate._getIssuerUniqueID12516 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getIssuerUniqueID", "()[Z");
			global::java.security.cert.X509Certificate._getSubjectUniqueID12517 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSubjectUniqueID", "()[Z");
			global::java.security.cert.X509Certificate._getKeyUsage12518 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getKeyUsage", "()[Z");
			global::java.security.cert.X509Certificate._getExtendedKeyUsage12519 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getExtendedKeyUsage", "()Ljava/util/List;");
			global::java.security.cert.X509Certificate._getBasicConstraints12520 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getBasicConstraints", "()I");
			global::java.security.cert.X509Certificate._getSubjectAlternativeNames12521 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSubjectAlternativeNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509Certificate._getIssuerAlternativeNames12522 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getIssuerAlternativeNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509Certificate._X509Certificate12523 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "<init>", "()V");
		}
	}
}
