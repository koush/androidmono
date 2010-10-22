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
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23719;
		public abstract bool hasUnsupportedCriticalExtension();
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23720;
		public abstract global::java.util.Set getCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23721;
		public abstract global::java.util.Set getNonCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23722;
		public abstract byte[] getExtensionValue(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getSignature23723;
		public abstract byte[] getSignature();
		internal static global::MonoJavaBridge.MethodId _getBasicConstraints23724;
		public abstract int getBasicConstraints();
		internal static global::MonoJavaBridge.MethodId _getVersion23725;
		public abstract int getVersion();
		internal static global::MonoJavaBridge.MethodId _getSerialNumber23726;
		public abstract global::java.math.BigInteger getSerialNumber();
		internal static global::MonoJavaBridge.MethodId _getIssuerDN23727;
		public abstract global::java.security.Principal getIssuerDN();
		internal static global::MonoJavaBridge.MethodId _getTBSCertificate23728;
		public abstract byte[] getTBSCertificate();
		internal static global::MonoJavaBridge.MethodId _checkValidity23729;
		public abstract void checkValidity();
		internal static global::MonoJavaBridge.MethodId _checkValidity23730;
		public abstract void checkValidity(java.util.Date arg0);
		internal static global::MonoJavaBridge.MethodId _getIssuerX500Principal23731;
		public virtual global::javax.security.auth.x500.X500Principal getIssuerX500Principal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getIssuerX500Principal23731)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getIssuerX500Principal23731)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectDN23732;
		public abstract global::java.security.Principal getSubjectDN();
		internal static global::MonoJavaBridge.MethodId _getSubjectX500Principal23733;
		public virtual global::javax.security.auth.x500.X500Principal getSubjectX500Principal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getSubjectX500Principal23733)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getSubjectX500Principal23733)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getNotBefore23734;
		public abstract global::java.util.Date getNotBefore();
		internal static global::MonoJavaBridge.MethodId _getNotAfter23735;
		public abstract global::java.util.Date getNotAfter();
		internal static global::MonoJavaBridge.MethodId _getSigAlgName23736;
		public abstract global::java.lang.String getSigAlgName();
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID23737;
		public abstract global::java.lang.String getSigAlgOID();
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams23738;
		public abstract byte[] getSigAlgParams();
		internal static global::MonoJavaBridge.MethodId _getIssuerUniqueID23739;
		public abstract bool[] getIssuerUniqueID();
		internal static global::MonoJavaBridge.MethodId _getSubjectUniqueID23740;
		public abstract bool[] getSubjectUniqueID();
		internal static global::MonoJavaBridge.MethodId _getKeyUsage23741;
		public abstract bool[] getKeyUsage();
		internal static global::MonoJavaBridge.MethodId _getExtendedKeyUsage23742;
		public virtual global::java.util.List getExtendedKeyUsage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getExtendedKeyUsage23742)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getExtendedKeyUsage23742)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectAlternativeNames23743;
		public virtual global::java.util.Collection getSubjectAlternativeNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getSubjectAlternativeNames23743)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getSubjectAlternativeNames23743)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerAlternativeNames23744;
		public virtual global::java.util.Collection getIssuerAlternativeNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getIssuerAlternativeNames23744)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getIssuerAlternativeNames23744)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _X509Certificate23745;
		protected X509Certificate()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._X509Certificate23745);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509Certificate"));
			global::java.security.cert.X509Certificate._hasUnsupportedCriticalExtension23719 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509Certificate._getCriticalExtensionOIDs23720 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate._getNonCriticalExtensionOIDs23721 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate._getExtensionValue23722 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509Certificate._getSignature23723 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509Certificate._getBasicConstraints23724 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getBasicConstraints", "()I");
			global::java.security.cert.X509Certificate._getVersion23725 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getVersion", "()I");
			global::java.security.cert.X509Certificate._getSerialNumber23726 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509Certificate._getIssuerDN23727 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate._getTBSCertificate23728 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getTBSCertificate", "()[B");
			global::java.security.cert.X509Certificate._checkValidity23729 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "checkValidity", "()V");
			global::java.security.cert.X509Certificate._checkValidity23730 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::java.security.cert.X509Certificate._getIssuerX500Principal23731 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509Certificate._getSubjectDN23732 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate._getSubjectX500Principal23733 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509Certificate._getNotBefore23734 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate._getNotAfter23735 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate._getSigAlgName23736 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate._getSigAlgOID23737 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate._getSigAlgParams23738 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509Certificate._getIssuerUniqueID23739 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerUniqueID", "()[Z");
			global::java.security.cert.X509Certificate._getSubjectUniqueID23740 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectUniqueID", "()[Z");
			global::java.security.cert.X509Certificate._getKeyUsage23741 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getKeyUsage", "()[Z");
			global::java.security.cert.X509Certificate._getExtendedKeyUsage23742 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getExtendedKeyUsage", "()Ljava/util/List;");
			global::java.security.cert.X509Certificate._getSubjectAlternativeNames23743 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectAlternativeNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509Certificate._getIssuerAlternativeNames23744 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerAlternativeNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509Certificate._X509Certificate23745 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.X509Certificate))]
	public sealed partial class X509Certificate_ : java.security.cert.X509Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509Certificate_()
		{
			InitJNI();
		}
		internal X509Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23746;
		public override bool hasUnsupportedCriticalExtension() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._hasUnsupportedCriticalExtension23746);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._hasUnsupportedCriticalExtension23746);
		}
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23747;
		public override global::java.util.Set getCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getCriticalExtensionOIDs23747)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getCriticalExtensionOIDs23747)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23748;
		public override global::java.util.Set getNonCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getNonCriticalExtensionOIDs23748)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getNonCriticalExtensionOIDs23748)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23749;
		public override byte[] getExtensionValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getExtensionValue23749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getExtensionValue23749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getSignature23750;
		public override byte[] getSignature() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSignature23750)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSignature23750)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getBasicConstraints23751;
		public override int getBasicConstraints() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getBasicConstraints23751);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getBasicConstraints23751);
		}
		internal static global::MonoJavaBridge.MethodId _getVersion23752;
		public override int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getVersion23752);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getVersion23752);
		}
		internal static global::MonoJavaBridge.MethodId _getSerialNumber23753;
		public override global::java.math.BigInteger getSerialNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSerialNumber23753)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSerialNumber23753)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerDN23754;
		public override global::java.security.Principal getIssuerDN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getIssuerDN23754)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getIssuerDN23754)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getTBSCertificate23755;
		public override byte[] getTBSCertificate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getTBSCertificate23755)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getTBSCertificate23755)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity23756;
		public override void checkValidity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._checkValidity23756);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._checkValidity23756);
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity23757;
		public override void checkValidity(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._checkValidity23757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._checkValidity23757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectDN23758;
		public override global::java.security.Principal getSubjectDN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSubjectDN23758)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSubjectDN23758)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getNotBefore23759;
		public override global::java.util.Date getNotBefore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getNotBefore23759)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getNotBefore23759)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getNotAfter23760;
		public override global::java.util.Date getNotAfter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getNotAfter23760)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getNotAfter23760)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName23761;
		public override global::java.lang.String getSigAlgName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSigAlgName23761)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSigAlgName23761)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID23762;
		public override global::java.lang.String getSigAlgOID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSigAlgOID23762)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSigAlgOID23762)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams23763;
		public override byte[] getSigAlgParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSigAlgParams23763)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSigAlgParams23763)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerUniqueID23764;
		public override bool[] getIssuerUniqueID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getIssuerUniqueID23764)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getIssuerUniqueID23764)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectUniqueID23765;
		public override bool[] getSubjectUniqueID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSubjectUniqueID23765)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSubjectUniqueID23765)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getKeyUsage23766;
		public override bool[] getKeyUsage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getKeyUsage23766)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getKeyUsage23766)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _toString23767;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._toString23767)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._toString23767)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23768;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getEncoded23768)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getEncoded23768)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify23769;
		public override void verify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._verify23769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._verify23769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify23770;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._verify23770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._verify23770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey23771;
		public override global::java.security.PublicKey getPublicKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getPublicKey23771)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getPublicKey23771)) as java.security.PublicKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509Certificate"));
			global::java.security.cert.X509Certificate_._hasUnsupportedCriticalExtension23746 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509Certificate_._getCriticalExtensionOIDs23747 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate_._getNonCriticalExtensionOIDs23748 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate_._getExtensionValue23749 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509Certificate_._getSignature23750 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509Certificate_._getBasicConstraints23751 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getBasicConstraints", "()I");
			global::java.security.cert.X509Certificate_._getVersion23752 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getVersion", "()I");
			global::java.security.cert.X509Certificate_._getSerialNumber23753 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509Certificate_._getIssuerDN23754 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate_._getTBSCertificate23755 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getTBSCertificate", "()[B");
			global::java.security.cert.X509Certificate_._checkValidity23756 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "checkValidity", "()V");
			global::java.security.cert.X509Certificate_._checkValidity23757 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::java.security.cert.X509Certificate_._getSubjectDN23758 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate_._getNotBefore23759 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate_._getNotAfter23760 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate_._getSigAlgName23761 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate_._getSigAlgOID23762 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate_._getSigAlgParams23763 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509Certificate_._getIssuerUniqueID23764 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getIssuerUniqueID", "()[Z");
			global::java.security.cert.X509Certificate_._getSubjectUniqueID23765 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSubjectUniqueID", "()[Z");
			global::java.security.cert.X509Certificate_._getKeyUsage23766 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getKeyUsage", "()[Z");
			global::java.security.cert.X509Certificate_._toString23767 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate_._getEncoded23768 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509Certificate_._verify23769 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.X509Certificate_._verify23770 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.X509Certificate_._getPublicKey23771 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
		}
	}
}
