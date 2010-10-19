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
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension18118;
		public abstract bool hasUnsupportedCriticalExtension();
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs18119;
		public abstract global::java.util.Set getCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs18120;
		public abstract global::java.util.Set getNonCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getExtensionValue18121;
		public abstract byte[] getExtensionValue(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getSignature18122;
		public abstract byte[] getSignature();
		internal static global::MonoJavaBridge.MethodId _getBasicConstraints18123;
		public abstract int getBasicConstraints();
		internal static global::MonoJavaBridge.MethodId _getVersion18124;
		public abstract int getVersion();
		internal static global::MonoJavaBridge.MethodId _getSerialNumber18125;
		public abstract global::java.math.BigInteger getSerialNumber();
		internal static global::MonoJavaBridge.MethodId _getIssuerDN18126;
		public abstract global::java.security.Principal getIssuerDN();
		internal static global::MonoJavaBridge.MethodId _getTBSCertificate18127;
		public abstract byte[] getTBSCertificate();
		internal static global::MonoJavaBridge.MethodId _checkValidity18128;
		public abstract void checkValidity();
		internal static global::MonoJavaBridge.MethodId _checkValidity18129;
		public abstract void checkValidity(java.util.Date arg0);
		internal static global::MonoJavaBridge.MethodId _getIssuerX500Principal18130;
		public virtual global::javax.security.auth.x500.X500Principal getIssuerX500Principal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getIssuerX500Principal18130)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getIssuerX500Principal18130)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectDN18131;
		public abstract global::java.security.Principal getSubjectDN();
		internal static global::MonoJavaBridge.MethodId _getSubjectX500Principal18132;
		public virtual global::javax.security.auth.x500.X500Principal getSubjectX500Principal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getSubjectX500Principal18132)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getSubjectX500Principal18132)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getNotBefore18133;
		public abstract global::java.util.Date getNotBefore();
		internal static global::MonoJavaBridge.MethodId _getNotAfter18134;
		public abstract global::java.util.Date getNotAfter();
		internal static global::MonoJavaBridge.MethodId _getSigAlgName18135;
		public abstract global::java.lang.String getSigAlgName();
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID18136;
		public abstract global::java.lang.String getSigAlgOID();
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams18137;
		public abstract byte[] getSigAlgParams();
		internal static global::MonoJavaBridge.MethodId _getIssuerUniqueID18138;
		public abstract bool[] getIssuerUniqueID();
		internal static global::MonoJavaBridge.MethodId _getSubjectUniqueID18139;
		public abstract bool[] getSubjectUniqueID();
		internal static global::MonoJavaBridge.MethodId _getKeyUsage18140;
		public abstract bool[] getKeyUsage();
		internal static global::MonoJavaBridge.MethodId _getExtendedKeyUsage18141;
		public virtual global::java.util.List getExtendedKeyUsage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getExtendedKeyUsage18141)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getExtendedKeyUsage18141)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectAlternativeNames18142;
		public virtual global::java.util.Collection getSubjectAlternativeNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getSubjectAlternativeNames18142)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getSubjectAlternativeNames18142)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerAlternativeNames18143;
		public virtual global::java.util.Collection getIssuerAlternativeNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate._getIssuerAlternativeNames18143)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._getIssuerAlternativeNames18143)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _X509Certificate18144;
		protected X509Certificate()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._X509Certificate18144);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509Certificate"));
			global::java.security.cert.X509Certificate._hasUnsupportedCriticalExtension18118 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509Certificate._getCriticalExtensionOIDs18119 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate._getNonCriticalExtensionOIDs18120 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate._getExtensionValue18121 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509Certificate._getSignature18122 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509Certificate._getBasicConstraints18123 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getBasicConstraints", "()I");
			global::java.security.cert.X509Certificate._getVersion18124 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getVersion", "()I");
			global::java.security.cert.X509Certificate._getSerialNumber18125 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509Certificate._getIssuerDN18126 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate._getTBSCertificate18127 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getTBSCertificate", "()[B");
			global::java.security.cert.X509Certificate._checkValidity18128 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "checkValidity", "()V");
			global::java.security.cert.X509Certificate._checkValidity18129 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::java.security.cert.X509Certificate._getIssuerX500Principal18130 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509Certificate._getSubjectDN18131 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate._getSubjectX500Principal18132 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509Certificate._getNotBefore18133 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate._getNotAfter18134 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate._getSigAlgName18135 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate._getSigAlgOID18136 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate._getSigAlgParams18137 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509Certificate._getIssuerUniqueID18138 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerUniqueID", "()[Z");
			global::java.security.cert.X509Certificate._getSubjectUniqueID18139 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectUniqueID", "()[Z");
			global::java.security.cert.X509Certificate._getKeyUsage18140 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getKeyUsage", "()[Z");
			global::java.security.cert.X509Certificate._getExtendedKeyUsage18141 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getExtendedKeyUsage", "()Ljava/util/List;");
			global::java.security.cert.X509Certificate._getSubjectAlternativeNames18142 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getSubjectAlternativeNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509Certificate._getIssuerAlternativeNames18143 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "getIssuerAlternativeNames", "()Ljava/util/Collection;");
			global::java.security.cert.X509Certificate._X509Certificate18144 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension18145;
		public override bool hasUnsupportedCriticalExtension() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._hasUnsupportedCriticalExtension18145);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._hasUnsupportedCriticalExtension18145);
		}
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs18146;
		public override global::java.util.Set getCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getCriticalExtensionOIDs18146)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getCriticalExtensionOIDs18146)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs18147;
		public override global::java.util.Set getNonCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getNonCriticalExtensionOIDs18147)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getNonCriticalExtensionOIDs18147)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionValue18148;
		public override byte[] getExtensionValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getExtensionValue18148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getExtensionValue18148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getSignature18149;
		public override byte[] getSignature() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSignature18149)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSignature18149)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getBasicConstraints18150;
		public override int getBasicConstraints() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getBasicConstraints18150);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getBasicConstraints18150);
		}
		internal static global::MonoJavaBridge.MethodId _getVersion18151;
		public override int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getVersion18151);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getVersion18151);
		}
		internal static global::MonoJavaBridge.MethodId _getSerialNumber18152;
		public override global::java.math.BigInteger getSerialNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSerialNumber18152)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSerialNumber18152)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerDN18153;
		public override global::java.security.Principal getIssuerDN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getIssuerDN18153)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getIssuerDN18153)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getTBSCertificate18154;
		public override byte[] getTBSCertificate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getTBSCertificate18154)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getTBSCertificate18154)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity18155;
		public override void checkValidity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._checkValidity18155);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._checkValidity18155);
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity18156;
		public override void checkValidity(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._checkValidity18156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._checkValidity18156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectDN18157;
		public override global::java.security.Principal getSubjectDN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSubjectDN18157)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSubjectDN18157)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getNotBefore18158;
		public override global::java.util.Date getNotBefore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getNotBefore18158)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getNotBefore18158)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getNotAfter18159;
		public override global::java.util.Date getNotAfter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getNotAfter18159)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getNotAfter18159)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName18160;
		public override global::java.lang.String getSigAlgName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSigAlgName18160)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSigAlgName18160)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID18161;
		public override global::java.lang.String getSigAlgOID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSigAlgOID18161)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSigAlgOID18161)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams18162;
		public override byte[] getSigAlgParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSigAlgParams18162)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSigAlgParams18162)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerUniqueID18163;
		public override bool[] getIssuerUniqueID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getIssuerUniqueID18163)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getIssuerUniqueID18163)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectUniqueID18164;
		public override bool[] getSubjectUniqueID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getSubjectUniqueID18164)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getSubjectUniqueID18164)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getKeyUsage18165;
		public override bool[] getKeyUsage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getKeyUsage18165)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getKeyUsage18165)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _toString18166;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._toString18166)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._toString18166)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded18167;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getEncoded18167)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getEncoded18167)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify18168;
		public override void verify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._verify18168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._verify18168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify18169;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._verify18169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._verify18169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey18170;
		public override global::java.security.PublicKey getPublicKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_._getPublicKey18170)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509Certificate_.staticClass, global::java.security.cert.X509Certificate_._getPublicKey18170)) as java.security.PublicKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509Certificate"));
			global::java.security.cert.X509Certificate_._hasUnsupportedCriticalExtension18145 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509Certificate_._getCriticalExtensionOIDs18146 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate_._getNonCriticalExtensionOIDs18147 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509Certificate_._getExtensionValue18148 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509Certificate_._getSignature18149 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509Certificate_._getBasicConstraints18150 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getBasicConstraints", "()I");
			global::java.security.cert.X509Certificate_._getVersion18151 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getVersion", "()I");
			global::java.security.cert.X509Certificate_._getSerialNumber18152 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509Certificate_._getIssuerDN18153 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate_._getTBSCertificate18154 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getTBSCertificate", "()[B");
			global::java.security.cert.X509Certificate_._checkValidity18155 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "checkValidity", "()V");
			global::java.security.cert.X509Certificate_._checkValidity18156 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::java.security.cert.X509Certificate_._getSubjectDN18157 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509Certificate_._getNotBefore18158 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate_._getNotAfter18159 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::java.security.cert.X509Certificate_._getSigAlgName18160 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate_._getSigAlgOID18161 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate_._getSigAlgParams18162 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509Certificate_._getIssuerUniqueID18163 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getIssuerUniqueID", "()[Z");
			global::java.security.cert.X509Certificate_._getSubjectUniqueID18164 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getSubjectUniqueID", "()[Z");
			global::java.security.cert.X509Certificate_._getKeyUsage18165 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getKeyUsage", "()[Z");
			global::java.security.cert.X509Certificate_._toString18166 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509Certificate_._getEncoded18167 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509Certificate_._verify18168 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.X509Certificate_._verify18169 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.X509Certificate_._getPublicKey18170 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
		}
	}
}
