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
		internal static global::net.sf.jni4net.jni.MethodId _hasUnsupportedCriticalExtension13325;
		public abstract bool hasUnsupportedCriticalExtension();
		internal static global::net.sf.jni4net.jni.MethodId _getCriticalExtensionOIDs13326;
		public abstract global::java.util.Set getCriticalExtensionOIDs();
		internal static global::net.sf.jni4net.jni.MethodId _getNonCriticalExtensionOIDs13327;
		public abstract global::java.util.Set getNonCriticalExtensionOIDs();
		internal static global::net.sf.jni4net.jni.MethodId _getExtensionValue13328;
		public abstract byte[] getExtensionValue(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getSignature13329;
		public abstract byte[] getSignature();
		internal static global::net.sf.jni4net.jni.MethodId _getBasicConstraints13330;
		public abstract int getBasicConstraints();
		internal static global::net.sf.jni4net.jni.MethodId _getVersion13331;
		public abstract int getVersion();
		internal static global::net.sf.jni4net.jni.MethodId _getSerialNumber13332;
		public abstract global::java.math.BigInteger getSerialNumber();
		internal static global::net.sf.jni4net.jni.MethodId _getIssuerDN13333;
		public abstract global::java.security.Principal getIssuerDN();
		internal static global::net.sf.jni4net.jni.MethodId _getTBSCertificate13334;
		public abstract byte[] getTBSCertificate();
		internal static global::net.sf.jni4net.jni.MethodId _checkValidity13335;
		public abstract void checkValidity();
		internal static global::net.sf.jni4net.jni.MethodId _checkValidity13336;
		public abstract void checkValidity(java.util.Date arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getIssuerX500Principal13337;
		public virtual global::javax.security.auth.x500.X500Principal getIssuerX500Principal() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.security.auth.x500.X500Principal>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.X509Certificate._getIssuerX500Principal13337));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.security.auth.x500.X500Principal>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getIssuerX500Principal13337));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSubjectDN13338;
		public abstract global::java.security.Principal getSubjectDN();
		internal static global::net.sf.jni4net.jni.MethodId _getSubjectX500Principal13339;
		public virtual global::javax.security.auth.x500.X500Principal getSubjectX500Principal() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.security.auth.x500.X500Principal>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.X509Certificate._getSubjectX500Principal13339));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.security.auth.x500.X500Principal>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getSubjectX500Principal13339));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNotBefore13340;
		public abstract global::java.util.Date getNotBefore();
		internal static global::net.sf.jni4net.jni.MethodId _getNotAfter13341;
		public abstract global::java.util.Date getNotAfter();
		internal static global::net.sf.jni4net.jni.MethodId _getSigAlgName13342;
		public abstract global::java.lang.String getSigAlgName();
		internal static global::net.sf.jni4net.jni.MethodId _getSigAlgOID13343;
		public abstract global::java.lang.String getSigAlgOID();
		internal static global::net.sf.jni4net.jni.MethodId _getSigAlgParams13344;
		public abstract byte[] getSigAlgParams();
		internal static global::net.sf.jni4net.jni.MethodId _getIssuerUniqueID13345;
		public abstract bool[] getIssuerUniqueID();
		internal static global::net.sf.jni4net.jni.MethodId _getSubjectUniqueID13346;
		public abstract bool[] getSubjectUniqueID();
		internal static global::net.sf.jni4net.jni.MethodId _getKeyUsage13347;
		public abstract bool[] getKeyUsage();
		internal static global::net.sf.jni4net.jni.MethodId _getExtendedKeyUsage13348;
		public virtual global::java.util.List getExtendedKeyUsage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.X509Certificate._getExtendedKeyUsage13348));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getExtendedKeyUsage13348));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSubjectAlternativeNames13349;
		public virtual global::java.util.Collection getSubjectAlternativeNames() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.X509Certificate._getSubjectAlternativeNames13349));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getSubjectAlternativeNames13349));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIssuerAlternativeNames13350;
		public virtual global::java.util.Collection getIssuerAlternativeNames() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.X509Certificate._getIssuerAlternativeNames13350));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getIssuerAlternativeNames13350));
		}
		internal static global::net.sf.jni4net.jni.MethodId _X509Certificate13351;
		protected X509Certificate()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._X509Certificate13351, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.cert.X509Certificate.staticClass = @__class;
			global::java.security.cert.X509Certificate._hasUnsupportedCriticalExtension13325 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509Certificate._getCriticalExtensionOIDs13326 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate._getNonCriticalExtensionOIDs13327 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate._getExtensionValue13328 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509Certificate._getSignature13329 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509Certificate._getBasicConstraints13330 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getBasicConstraints", "()I");
			global::java.security.cert.X509Certificate._getVersion13331 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getVersion", "()I");
			global::java.security.cert.X509Certificate._getSerialNumber13332 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509Certificate._getIssuerDN13333 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate._getTBSCertificate13334 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getTBSCertificate", "()[B");
			global::java.security.cert.X509Certificate._checkValidity13335 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "checkValidity", "()V");
			global::java.security.cert.X509Certificate._checkValidity13336 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::java.security.cert.X509Certificate._getIssuerX500Principal13337 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509Certificate._getSubjectDN13338 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate._getSubjectX500Principal13339 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSubjectX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509Certificate._getNotBefore13340 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate._getNotAfter13341 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate._getSigAlgName13342 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate._getSigAlgOID13343 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate._getSigAlgParams13344 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509Certificate._getIssuerUniqueID13345 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getIssuerUniqueID", "()[Z");
			global::java.security.cert.X509Certificate._getSubjectUniqueID13346 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSubjectUniqueID", "()[Z");
			global::java.security.cert.X509Certificate._getKeyUsage13347 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getKeyUsage", "()[Z");
			global::java.security.cert.X509Certificate._getExtendedKeyUsage13348 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getExtendedKeyUsage", "()Ljava/util/List;");
			global::java.security.cert.X509Certificate._getSubjectAlternativeNames13349 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getSubjectAlternativeNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509Certificate._getIssuerAlternativeNames13350 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "getIssuerAlternativeNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509Certificate._X509Certificate13351 = @__env.GetMethodID(global::java.security.cert.X509Certificate.staticClass, "<init>", "()V");
		}
	}
}
