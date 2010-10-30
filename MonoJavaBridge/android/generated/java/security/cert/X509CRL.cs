namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.X509CRL_))]
	public abstract partial class X509CRL : java.security.cert.CRL, X509Extension
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected X509CRL(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23701;
		public abstract bool hasUnsupportedCriticalExtension();
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23702;
		public abstract global::java.util.Set getCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23703;
		public abstract global::java.util.Set getNonCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23704;
		public abstract byte[] getExtensionValue(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _equals23705;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._equals23705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23706;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._hashCode23706);
		}
		internal static global::MonoJavaBridge.MethodId _getSignature23707;
		public abstract byte[] getSignature();
		internal static global::MonoJavaBridge.MethodId _getEncoded23708;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _verify23709;
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _verify23710;
		public abstract void verify(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _getVersion23711;
		public abstract int getVersion();
		internal static global::MonoJavaBridge.MethodId _getIssuerDN23712;
		public abstract global::java.security.Principal getIssuerDN();
		internal static global::MonoJavaBridge.MethodId _getIssuerX500Principal23713;
		public virtual global::javax.security.auth.x500.X500Principal getIssuerX500Principal()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._getIssuerX500Principal23713)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName23714;
		public abstract global::java.lang.String getSigAlgName();
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID23715;
		public abstract global::java.lang.String getSigAlgOID();
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams23716;
		public abstract byte[] getSigAlgParams();
		internal static global::MonoJavaBridge.MethodId _getThisUpdate23717;
		public abstract global::java.util.Date getThisUpdate();
		internal static global::MonoJavaBridge.MethodId _getNextUpdate23718;
		public abstract global::java.util.Date getNextUpdate();
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificate23719;
		public virtual global::java.security.cert.X509CRLEntry getRevokedCertificate(java.security.cert.X509Certificate arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._getRevokedCertificate23719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509CRLEntry;
		}
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificate23720;
		public abstract global::java.security.cert.X509CRLEntry getRevokedCertificate(java.math.BigInteger arg0);
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificates23721;
		public abstract global::java.util.Set getRevokedCertificates();
		internal static global::MonoJavaBridge.MethodId _getTBSCertList23722;
		public abstract byte[] getTBSCertList();
		internal static global::MonoJavaBridge.MethodId _X509CRL23723;
		protected X509CRL() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._X509CRL23723);
			Init(@__env, handle);
		}
		static X509CRL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRL.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRL"));
			global::java.security.cert.X509CRL._hasUnsupportedCriticalExtension23701 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509CRL._getCriticalExtensionOIDs23702 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL._getNonCriticalExtensionOIDs23703 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL._getExtensionValue23704 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509CRL._equals23705 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.cert.X509CRL._hashCode23706 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "hashCode", "()I");
			global::java.security.cert.X509CRL._getSignature23707 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509CRL._getEncoded23708 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509CRL._verify23709 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.X509CRL._verify23710 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.X509CRL._getVersion23711 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getVersion", "()I");
			global::java.security.cert.X509CRL._getIssuerDN23712 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509CRL._getIssuerX500Principal23713 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509CRL._getSigAlgName23714 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL._getSigAlgOID23715 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL._getSigAlgParams23716 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509CRL._getThisUpdate23717 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getThisUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL._getNextUpdate23718 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getNextUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL._getRevokedCertificate23719 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getRevokedCertificate", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509CRLEntry;");
			global::java.security.cert.X509CRL._getRevokedCertificate23720 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;");
			global::java.security.cert.X509CRL._getRevokedCertificates23721 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getRevokedCertificates", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL._getTBSCertList23722 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getTBSCertList", "()[B");
			global::java.security.cert.X509CRL._X509CRL23723 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.X509CRL))]
	internal sealed partial class X509CRL_ : java.security.cert.X509CRL
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal X509CRL_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23724;
		public override bool hasUnsupportedCriticalExtension()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL_._hasUnsupportedCriticalExtension23724);
		}
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23725;
		public override global::java.util.Set getCriticalExtensionOIDs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getCriticalExtensionOIDs23725)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23726;
		public override global::java.util.Set getNonCriticalExtensionOIDs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getNonCriticalExtensionOIDs23726)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23727;
		public override byte[] getExtensionValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getExtensionValue23727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getSignature23728;
		public override byte[] getSignature()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSignature23728)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23729;
		public override byte[] getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getEncoded23729)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify23730;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRL_._verify23730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _verify23731;
		public override void verify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRL_._verify23731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVersion23732;
		public override int getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getVersion23732);
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerDN23733;
		public override global::java.security.Principal getIssuerDN()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getIssuerDN23733)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName23734;
		public override global::java.lang.String getSigAlgName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSigAlgName23734)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID23735;
		public override global::java.lang.String getSigAlgOID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSigAlgOID23735)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams23736;
		public override byte[] getSigAlgParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSigAlgParams23736)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getThisUpdate23737;
		public override global::java.util.Date getThisUpdate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getThisUpdate23737)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getNextUpdate23738;
		public override global::java.util.Date getNextUpdate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getNextUpdate23738)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificate23739;
		public override global::java.security.cert.X509CRLEntry getRevokedCertificate(java.math.BigInteger arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getRevokedCertificate23739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509CRLEntry;
		}
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificates23740;
		public override global::java.util.Set getRevokedCertificates()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getRevokedCertificates23740)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getTBSCertList23741;
		public override byte[] getTBSCertList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getTBSCertList23741)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _toString23742;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._toString23742)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isRevoked23743;
		public override bool isRevoked(java.security.cert.Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL_._isRevoked23743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static X509CRL_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRL_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRL"));
			global::java.security.cert.X509CRL_._hasUnsupportedCriticalExtension23724 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509CRL_._getCriticalExtensionOIDs23725 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL_._getNonCriticalExtensionOIDs23726 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL_._getExtensionValue23727 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509CRL_._getSignature23728 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509CRL_._getEncoded23729 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509CRL_._verify23730 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.X509CRL_._verify23731 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.X509CRL_._getVersion23732 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getVersion", "()I");
			global::java.security.cert.X509CRL_._getIssuerDN23733 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509CRL_._getSigAlgName23734 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL_._getSigAlgOID23735 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL_._getSigAlgParams23736 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509CRL_._getThisUpdate23737 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getThisUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL_._getNextUpdate23738 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getNextUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL_._getRevokedCertificate23739 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;");
			global::java.security.cert.X509CRL_._getRevokedCertificates23740 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getRevokedCertificates", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL_._getTBSCertList23741 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getTBSCertList", "()[B");
			global::java.security.cert.X509CRL_._toString23742 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL_._isRevoked23743 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "isRevoked", "(Ljava/security/cert/Certificate;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
