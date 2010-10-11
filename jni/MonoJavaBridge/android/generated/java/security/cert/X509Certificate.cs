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
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension14972;
		public abstract bool hasUnsupportedCriticalExtension();
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs14973;
		public abstract global::java.util.Set getCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs14974;
		public abstract global::java.util.Set getNonCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getExtensionValue14975;
		public abstract byte[] getExtensionValue(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getSignature14976;
		public abstract byte[] getSignature();
		internal static global::MonoJavaBridge.MethodId _getBasicConstraints14977;
		public abstract int getBasicConstraints();
		internal static global::MonoJavaBridge.MethodId _getVersion14978;
		public abstract int getVersion();
		internal static global::MonoJavaBridge.MethodId _getSerialNumber14979;
		public abstract global::java.math.BigInteger getSerialNumber();
		internal static global::MonoJavaBridge.MethodId _getIssuerDN14980;
		public abstract global::java.security.Principal getIssuerDN();
		internal static global::MonoJavaBridge.MethodId _getTBSCertificate14981;
		public abstract byte[] getTBSCertificate();
		internal static global::MonoJavaBridge.MethodId _checkValidity14982;
		public abstract void checkValidity();
		internal static global::MonoJavaBridge.MethodId _checkValidity14983;
		public abstract void checkValidity(java.util.Date arg0);
		internal static global::MonoJavaBridge.MethodId _getIssuerX500Principal14984;
		public virtual global::javax.security.auth.x500.X500Principal getIssuerX500Principal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getIssuerX500Principal14984)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getIssuerX500Principal14984)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectDN14985;
		public abstract global::java.security.Principal getSubjectDN();
		internal static global::MonoJavaBridge.MethodId _getSubjectX500Principal14986;
		public virtual global::javax.security.auth.x500.X500Principal getSubjectX500Principal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getSubjectX500Principal14986)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getSubjectX500Principal14986)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getNotBefore14987;
		public abstract global::java.util.Date getNotBefore();
		internal static global::MonoJavaBridge.MethodId _getNotAfter14988;
		public abstract global::java.util.Date getNotAfter();
		internal static global::MonoJavaBridge.MethodId _getSigAlgName14989;
		public abstract global::java.lang.String getSigAlgName();
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID14990;
		public abstract global::java.lang.String getSigAlgOID();
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams14991;
		public abstract byte[] getSigAlgParams();
		internal static global::MonoJavaBridge.MethodId _getIssuerUniqueID14992;
		public abstract bool[] getIssuerUniqueID();
		internal static global::MonoJavaBridge.MethodId _getSubjectUniqueID14993;
		public abstract bool[] getSubjectUniqueID();
		internal static global::MonoJavaBridge.MethodId _getKeyUsage14994;
		public abstract bool[] getKeyUsage();
		internal static global::MonoJavaBridge.MethodId _getExtendedKeyUsage14995;
		public virtual global::java.util.List getExtendedKeyUsage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getExtendedKeyUsage14995)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getExtendedKeyUsage14995)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectAlternativeNames14996;
		public virtual global::java.util.Collection getSubjectAlternativeNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getSubjectAlternativeNames14996)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getSubjectAlternativeNames14996)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerAlternativeNames14997;
		public virtual global::java.util.Collection getIssuerAlternativeNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getIssuerAlternativeNames14997)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getIssuerAlternativeNames14997)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _X509Certificate14998;
		protected X509Certificate()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._X509Certificate14998);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509Certificate"));
			global::java.security.cert.X509Certificate._hasUnsupportedCriticalExtension14972 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509Certificate._getCriticalExtensionOIDs14973 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate._getNonCriticalExtensionOIDs14974 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate._getExtensionValue14975 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509Certificate._getSignature14976 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509Certificate._getBasicConstraints14977 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getBasicConstraints", "()I");
			global::java.security.cert.X509Certificate._getVersion14978 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getVersion", "()I");
			global::java.security.cert.X509Certificate._getSerialNumber14979 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509Certificate._getIssuerDN14980 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate._getTBSCertificate14981 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getTBSCertificate", "()[B");
			global::java.security.cert.X509Certificate._checkValidity14982 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "checkValidity", "()V");
			global::java.security.cert.X509Certificate._checkValidity14983 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::java.security.cert.X509Certificate._getIssuerX500Principal14984 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509Certificate._getSubjectDN14985 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate._getSubjectX500Principal14986 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509Certificate._getNotBefore14987 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate._getNotAfter14988 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate._getSigAlgName14989 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate._getSigAlgOID14990 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate._getSigAlgParams14991 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509Certificate._getIssuerUniqueID14992 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerUniqueID", "()[Z");
			global::java.security.cert.X509Certificate._getSubjectUniqueID14993 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectUniqueID", "()[Z");
			global::java.security.cert.X509Certificate._getKeyUsage14994 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getKeyUsage", "()[Z");
			global::java.security.cert.X509Certificate._getExtendedKeyUsage14995 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getExtendedKeyUsage", "()Ljava/util/List;");
			global::java.security.cert.X509Certificate._getSubjectAlternativeNames14996 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectAlternativeNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509Certificate._getIssuerAlternativeNames14997 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerAlternativeNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509Certificate._X509Certificate14998 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension14999;
		public override bool hasUnsupportedCriticalExtension() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._hasUnsupportedCriticalExtension14999);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._hasUnsupportedCriticalExtension14999);
		}
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs15000;
		public override global::java.util.Set getCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getCriticalExtensionOIDs15000)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getCriticalExtensionOIDs15000)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs15001;
		public override global::java.util.Set getNonCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getNonCriticalExtensionOIDs15001)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getNonCriticalExtensionOIDs15001)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionValue15002;
		public override byte[] getExtensionValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getExtensionValue15002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getExtensionValue15002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getSignature15003;
		public override byte[] getSignature() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSignature15003)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSignature15003)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getBasicConstraints15004;
		public override int getBasicConstraints() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getBasicConstraints15004);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getBasicConstraints15004);
		}
		internal static global::MonoJavaBridge.MethodId _getVersion15005;
		public override int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getVersion15005);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getVersion15005);
		}
		internal static global::MonoJavaBridge.MethodId _getSerialNumber15006;
		public override global::java.math.BigInteger getSerialNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSerialNumber15006)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSerialNumber15006)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerDN15007;
		public override global::java.security.Principal getIssuerDN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getIssuerDN15007)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getIssuerDN15007)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getTBSCertificate15008;
		public override byte[] getTBSCertificate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getTBSCertificate15008)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getTBSCertificate15008)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity15009;
		public override void checkValidity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._checkValidity15009);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._checkValidity15009);
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity15010;
		public override void checkValidity(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._checkValidity15010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._checkValidity15010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectDN15011;
		public override global::java.security.Principal getSubjectDN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSubjectDN15011)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSubjectDN15011)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getNotBefore15012;
		public override global::java.util.Date getNotBefore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getNotBefore15012)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getNotBefore15012)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getNotAfter15013;
		public override global::java.util.Date getNotAfter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getNotAfter15013)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getNotAfter15013)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName15014;
		public override global::java.lang.String getSigAlgName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSigAlgName15014)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSigAlgName15014)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID15015;
		public override global::java.lang.String getSigAlgOID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSigAlgOID15015)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSigAlgOID15015)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams15016;
		public override byte[] getSigAlgParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSigAlgParams15016)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSigAlgParams15016)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerUniqueID15017;
		public override bool[] getIssuerUniqueID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getIssuerUniqueID15017)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getIssuerUniqueID15017)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectUniqueID15018;
		public override bool[] getSubjectUniqueID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSubjectUniqueID15018)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSubjectUniqueID15018)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getKeyUsage15019;
		public override bool[] getKeyUsage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getKeyUsage15019)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getKeyUsage15019)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _toString15020;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._toString15020)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._toString15020)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded15021;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getEncoded15021)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getEncoded15021)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify15022;
		public override void verify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._verify15022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._verify15022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify15023;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._verify15023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._verify15023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey15024;
		public override global::java.security.PublicKey getPublicKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getPublicKey15024)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getPublicKey15024)) as java.security.PublicKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509Certificate"));
			global::java.security.cert.X509Certificate_._hasUnsupportedCriticalExtension14999 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509Certificate_._getCriticalExtensionOIDs15000 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate_._getNonCriticalExtensionOIDs15001 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate_._getExtensionValue15002 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509Certificate_._getSignature15003 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509Certificate_._getBasicConstraints15004 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getBasicConstraints", "()I");
			global::java.security.cert.X509Certificate_._getVersion15005 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getVersion", "()I");
			global::java.security.cert.X509Certificate_._getSerialNumber15006 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509Certificate_._getIssuerDN15007 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate_._getTBSCertificate15008 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getTBSCertificate", "()[B");
			global::java.security.cert.X509Certificate_._checkValidity15009 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "checkValidity", "()V");
			global::java.security.cert.X509Certificate_._checkValidity15010 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::java.security.cert.X509Certificate_._getSubjectDN15011 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate_._getNotBefore15012 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate_._getNotAfter15013 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate_._getSigAlgName15014 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate_._getSigAlgOID15015 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate_._getSigAlgParams15016 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509Certificate_._getIssuerUniqueID15017 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getIssuerUniqueID", "()[Z");
			global::java.security.cert.X509Certificate_._getSubjectUniqueID15018 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSubjectUniqueID", "()[Z");
			global::java.security.cert.X509Certificate_._getKeyUsage15019 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getKeyUsage", "()[Z");
			global::java.security.cert.X509Certificate_._toString15020 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate_._getEncoded15021 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509Certificate_._verify15022 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.X509Certificate_._verify15023 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.X509Certificate_._getPublicKey15024 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
		}
	}
}
