namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.X509Certificate_))]
	public abstract partial class X509Certificate : java.security.cert.Certificate, X509Extension
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509Certificate()
		{
			InitJNI();
		}
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getIssuerX500Principal23850)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getIssuerX500Principal23850)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectDN23851;
		public abstract global::java.security.Principal getSubjectDN();
		internal static global::MonoJavaBridge.MethodId _getSubjectX500Principal23852;
		public virtual global::javax.security.auth.x500.X500Principal getSubjectX500Principal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getSubjectX500Principal23852)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getSubjectX500Principal23852)) as javax.security.auth.x500.X500Principal;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getExtendedKeyUsage23861)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getExtendedKeyUsage23861)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectAlternativeNames23862;
		public virtual global::java.util.Collection getSubjectAlternativeNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getSubjectAlternativeNames23862)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getSubjectAlternativeNames23862)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerAlternativeNames23863;
		public virtual global::java.util.Collection getIssuerAlternativeNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getIssuerAlternativeNames23863)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getIssuerAlternativeNames23863)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _X509Certificate23864;
		protected X509Certificate() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._X509Certificate23864);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509Certificate"));
			global::java.security.cert.X509Certificate._hasUnsupportedCriticalExtension23838 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509Certificate._getCriticalExtensionOIDs23839 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate._getNonCriticalExtensionOIDs23840 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate._getExtensionValue23841 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509Certificate._getSignature23842 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509Certificate._getBasicConstraints23843 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getBasicConstraints", "()I");
			global::java.security.cert.X509Certificate._getVersion23844 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getVersion", "()I");
			global::java.security.cert.X509Certificate._getSerialNumber23845 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509Certificate._getIssuerDN23846 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate._getTBSCertificate23847 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getTBSCertificate", "()[B");
			global::java.security.cert.X509Certificate._checkValidity23848 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "checkValidity", "()V");
			global::java.security.cert.X509Certificate._checkValidity23849 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::java.security.cert.X509Certificate._getIssuerX500Principal23850 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509Certificate._getSubjectDN23851 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate._getSubjectX500Principal23852 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509Certificate._getNotBefore23853 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate._getNotAfter23854 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate._getSigAlgName23855 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate._getSigAlgOID23856 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate._getSigAlgParams23857 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509Certificate._getIssuerUniqueID23858 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerUniqueID", "()[Z");
			global::java.security.cert.X509Certificate._getSubjectUniqueID23859 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectUniqueID", "()[Z");
			global::java.security.cert.X509Certificate._getKeyUsage23860 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getKeyUsage", "()[Z");
			global::java.security.cert.X509Certificate._getExtendedKeyUsage23861 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getExtendedKeyUsage", "()Ljava/util/List;");
			global::java.security.cert.X509Certificate._getSubjectAlternativeNames23862 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectAlternativeNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509Certificate._getIssuerAlternativeNames23863 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerAlternativeNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509Certificate._X509Certificate23864 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.X509Certificate))]
	internal sealed partial class X509Certificate_ : java.security.cert.X509Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509Certificate_()
		{
			InitJNI();
		}
		internal X509Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23865;
		public override bool hasUnsupportedCriticalExtension()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._hasUnsupportedCriticalExtension23865);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._hasUnsupportedCriticalExtension23865);
		}
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23866;
		public override global::java.util.Set getCriticalExtensionOIDs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getCriticalExtensionOIDs23866)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getCriticalExtensionOIDs23866)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23867;
		public override global::java.util.Set getNonCriticalExtensionOIDs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getNonCriticalExtensionOIDs23867)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getNonCriticalExtensionOIDs23867)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23868;
		public override byte[] getExtensionValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getExtensionValue23868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getExtensionValue23868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getSignature23869;
		public override byte[] getSignature()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSignature23869)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSignature23869)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getBasicConstraints23870;
		public override int getBasicConstraints()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getBasicConstraints23870);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getBasicConstraints23870);
		}
		internal static global::MonoJavaBridge.MethodId _getVersion23871;
		public override int getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getVersion23871);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getVersion23871);
		}
		internal static global::MonoJavaBridge.MethodId _getSerialNumber23872;
		public override global::java.math.BigInteger getSerialNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSerialNumber23872)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSerialNumber23872)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerDN23873;
		public override global::java.security.Principal getIssuerDN()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getIssuerDN23873)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getIssuerDN23873)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getTBSCertificate23874;
		public override byte[] getTBSCertificate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getTBSCertificate23874)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getTBSCertificate23874)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity23875;
		public override void checkValidity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._checkValidity23875);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._checkValidity23875);
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity23876;
		public override void checkValidity(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._checkValidity23876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._checkValidity23876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectDN23877;
		public override global::java.security.Principal getSubjectDN()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSubjectDN23877)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSubjectDN23877)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getNotBefore23878;
		public override global::java.util.Date getNotBefore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getNotBefore23878)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getNotBefore23878)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getNotAfter23879;
		public override global::java.util.Date getNotAfter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getNotAfter23879)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getNotAfter23879)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName23880;
		public override global::java.lang.String getSigAlgName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSigAlgName23880)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSigAlgName23880)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID23881;
		public override global::java.lang.String getSigAlgOID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSigAlgOID23881)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSigAlgOID23881)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams23882;
		public override byte[] getSigAlgParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSigAlgParams23882)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSigAlgParams23882)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerUniqueID23883;
		public override bool[] getIssuerUniqueID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getIssuerUniqueID23883)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getIssuerUniqueID23883)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectUniqueID23884;
		public override bool[] getSubjectUniqueID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSubjectUniqueID23884)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSubjectUniqueID23884)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getKeyUsage23885;
		public override bool[] getKeyUsage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getKeyUsage23885)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getKeyUsage23885)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _toString23886;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._toString23886)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._toString23886)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23887;
		public override byte[] getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getEncoded23887)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getEncoded23887)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify23888;
		public override void verify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._verify23888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._verify23888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify23889;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._verify23889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._verify23889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey23890;
		public override global::java.security.PublicKey getPublicKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getPublicKey23890)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getPublicKey23890)) as java.security.PublicKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509Certificate"));
			global::java.security.cert.X509Certificate_._hasUnsupportedCriticalExtension23865 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509Certificate_._getCriticalExtensionOIDs23866 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate_._getNonCriticalExtensionOIDs23867 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate_._getExtensionValue23868 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509Certificate_._getSignature23869 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509Certificate_._getBasicConstraints23870 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getBasicConstraints", "()I");
			global::java.security.cert.X509Certificate_._getVersion23871 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getVersion", "()I");
			global::java.security.cert.X509Certificate_._getSerialNumber23872 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509Certificate_._getIssuerDN23873 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate_._getTBSCertificate23874 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getTBSCertificate", "()[B");
			global::java.security.cert.X509Certificate_._checkValidity23875 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "checkValidity", "()V");
			global::java.security.cert.X509Certificate_._checkValidity23876 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::java.security.cert.X509Certificate_._getSubjectDN23877 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate_._getNotBefore23878 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate_._getNotAfter23879 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate_._getSigAlgName23880 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate_._getSigAlgOID23881 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate_._getSigAlgParams23882 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509Certificate_._getIssuerUniqueID23883 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getIssuerUniqueID", "()[Z");
			global::java.security.cert.X509Certificate_._getSubjectUniqueID23884 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSubjectUniqueID", "()[Z");
			global::java.security.cert.X509Certificate_._getKeyUsage23885 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getKeyUsage", "()[Z");
			global::java.security.cert.X509Certificate_._toString23886 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate_._getEncoded23887 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509Certificate_._verify23888 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.X509Certificate_._verify23889 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.X509Certificate_._getPublicKey23890 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
		}
	}
}
