namespace java.security.cert 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class X509Certificate : java.security.cert.Certificate, X509Extension
	{ 
		internal new static global::java.lang.Class staticClass; 
		static X509Certificate() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.security.cert.X509Certificate), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected X509Certificate(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasUnsupportedCriticalExtension11622; 
		public abstract bool hasUnsupportedCriticalExtension(); 
		internal static global::net.sf.jni4net.jni.MethodId _getCriticalExtensionOIDs11623; 
		public abstract java.util.Set getCriticalExtensionOIDs(); 
		internal static global::net.sf.jni4net.jni.MethodId _getNonCriticalExtensionOIDs11624; 
		public abstract java.util.Set getNonCriticalExtensionOIDs(); 
		internal static global::net.sf.jni4net.jni.MethodId _getExtensionValue11625; 
		public abstract byte[] getExtensionValue(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getSignature11626; 
		public abstract byte[] getSignature(); 
		internal static global::net.sf.jni4net.jni.MethodId _getVersion11627; 
		public abstract int getVersion(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSerialNumber11628; 
		public abstract java.math.BigInteger getSerialNumber(); 
		internal static global::net.sf.jni4net.jni.MethodId _getIssuerDN11629; 
		public abstract java.security.Principal getIssuerDN(); 
		internal static global::net.sf.jni4net.jni.MethodId _getTBSCertificate11630; 
		public abstract byte[] getTBSCertificate(); 
		internal static global::net.sf.jni4net.jni.MethodId _checkValidity11631; 
		public abstract void checkValidity(); 
		internal static global::net.sf.jni4net.jni.MethodId _checkValidity11632; 
		public abstract void checkValidity(java.util.Date arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getIssuerX500Principal11633; 
		public virtual javax.security.auth.x500.X500Principal getIssuerX500Principal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.X509Certificate)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.security.auth.x500.X500Principal>(@__env, @__env.CallObjectMethodPtr(this, _getIssuerX500Principal11633)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.security.auth.x500.X500Principal>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.cert.X509Certificate.staticClass, _getIssuerX500Principal11633)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubjectDN11634; 
		public abstract java.security.Principal getSubjectDN(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSubjectX500Principal11635; 
		public virtual javax.security.auth.x500.X500Principal getSubjectX500Principal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.X509Certificate)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.security.auth.x500.X500Principal>(@__env, @__env.CallObjectMethodPtr(this, _getSubjectX500Principal11635)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.security.auth.x500.X500Principal>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.cert.X509Certificate.staticClass, _getSubjectX500Principal11635)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNotBefore11636; 
		public abstract java.util.Date getNotBefore(); 
		internal static global::net.sf.jni4net.jni.MethodId _getNotAfter11637; 
		public abstract java.util.Date getNotAfter(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSigAlgName11638; 
		public abstract java.lang.String getSigAlgName(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSigAlgOID11639; 
		public abstract java.lang.String getSigAlgOID(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSigAlgParams11640; 
		public abstract byte[] getSigAlgParams(); 
		internal static global::net.sf.jni4net.jni.MethodId _getIssuerUniqueID11641; 
		public abstract bool[] getIssuerUniqueID(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSubjectUniqueID11642; 
		public abstract bool[] getSubjectUniqueID(); 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyUsage11643; 
		public abstract bool[] getKeyUsage(); 
		internal static global::net.sf.jni4net.jni.MethodId _getExtendedKeyUsage11644; 
		public virtual java.util.List getExtendedKeyUsage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.X509Certificate)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getExtendedKeyUsage11644)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.cert.X509Certificate.staticClass, _getExtendedKeyUsage11644)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBasicConstraints11645; 
		public abstract int getBasicConstraints(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSubjectAlternativeNames11646; 
		public virtual java.util.Collection getSubjectAlternativeNames() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.X509Certificate)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, _getSubjectAlternativeNames11646)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.cert.X509Certificate.staticClass, _getSubjectAlternativeNames11646)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIssuerAlternativeNames11647; 
		public virtual java.util.Collection getIssuerAlternativeNames() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.cert.X509Certificate)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, _getIssuerAlternativeNames11647)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.cert.X509Certificate.staticClass, _getIssuerAlternativeNames11647)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _X509Certificate11648; 
		protected X509Certificate()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.cert.X509Certificate.staticClass, _X509Certificate11648, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.cert.X509Certificate.staticClass = @__class; 
			global::java.security.cert.X509Certificate._hasUnsupportedCriticalExtension11622 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "hasUnsupportedCriticalExtension", "()Z"); 
			global::java.security.cert.X509Certificate._getCriticalExtensionOIDs11623 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;"); 
			global::java.security.cert.X509Certificate._getNonCriticalExtensionOIDs11624 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;"); 
			global::java.security.cert.X509Certificate._getExtensionValue11625 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B"); 
			global::java.security.cert.X509Certificate._getSignature11626 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSignature", "()[B"); 
			global::java.security.cert.X509Certificate._getVersion11627 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getVersion", "()I"); 
			global::java.security.cert.X509Certificate._getSerialNumber11628 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;"); 
			global::java.security.cert.X509Certificate._getIssuerDN11629 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getIssuerDN", "()Ljava/security/Principal;"); 
			global::java.security.cert.X509Certificate._getTBSCertificate11630 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getTBSCertificate", "()[B"); 
			global::java.security.cert.X509Certificate._checkValidity11631 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "checkValidity", "()V"); 
			global::java.security.cert.X509Certificate._checkValidity11632 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "checkValidity", "(Ljava/util/Date;)V"); 
			global::java.security.cert.X509Certificate._getIssuerX500Principal11633 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;"); 
			global::java.security.cert.X509Certificate._getSubjectDN11634 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSubjectDN", "()Ljava/security/Principal;"); 
			global::java.security.cert.X509Certificate._getSubjectX500Principal11635 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSubjectX500Principal", "()Ljavax/security/auth/x500/X500Principal;"); 
			global::java.security.cert.X509Certificate._getNotBefore11636 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getNotBefore", "()Ljava/util/Date;"); 
			global::java.security.cert.X509Certificate._getNotAfter11637 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getNotAfter", "()Ljava/util/Date;"); 
			global::java.security.cert.X509Certificate._getSigAlgName11638 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSigAlgName", "()Ljava/lang/String;"); 
			global::java.security.cert.X509Certificate._getSigAlgOID11639 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSigAlgOID", "()Ljava/lang/String;"); 
			global::java.security.cert.X509Certificate._getSigAlgParams11640 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSigAlgParams", "()[B"); 
			global::java.security.cert.X509Certificate._getIssuerUniqueID11641 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getIssuerUniqueID", "()[Z"); 
			global::java.security.cert.X509Certificate._getSubjectUniqueID11642 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSubjectUniqueID", "()[Z"); 
			global::java.security.cert.X509Certificate._getKeyUsage11643 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getKeyUsage", "()[Z"); 
			global::java.security.cert.X509Certificate._getExtendedKeyUsage11644 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getExtendedKeyUsage", "()Ljava/util/List;"); 
			global::java.security.cert.X509Certificate._getBasicConstraints11645 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getBasicConstraints", "()I"); 
			global::java.security.cert.X509Certificate._getSubjectAlternativeNames11646 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSubjectAlternativeNames", "()Ljava/util/Collection;"); 
			global::java.security.cert.X509Certificate._getIssuerAlternativeNames11647 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getIssuerAlternativeNames", "()Ljava/util/Collection;"); 
			global::java.security.cert.X509Certificate._X509Certificate11648 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "<init>", "()V"); 
		} 
	} 
} 
