namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.X509CRL_))]
	public abstract partial class X509CRL : java.security.cert.CRL, X509Extension
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509CRL()
		{
			InitJNI();
		}
		protected X509CRL(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23700;
		public abstract bool hasUnsupportedCriticalExtension();
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23701;
		public abstract global::java.util.Set getCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23702;
		public abstract global::java.util.Set getNonCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23703;
		public abstract byte[] getExtensionValue(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _equals23704;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL._equals23704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._equals23704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23705;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509CRL._hashCode23705);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._hashCode23705);
		}
		internal static global::MonoJavaBridge.MethodId _getSignature23706;
		public abstract byte[] getSignature();
		internal static global::MonoJavaBridge.MethodId _getEncoded23707;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _verify23708;
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _verify23709;
		public abstract void verify(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _getVersion23710;
		public abstract int getVersion();
		internal static global::MonoJavaBridge.MethodId _getIssuerDN23711;
		public abstract global::java.security.Principal getIssuerDN();
		internal static global::MonoJavaBridge.MethodId _getIssuerX500Principal23712;
		public virtual global::javax.security.auth.x500.X500Principal getIssuerX500Principal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL._getIssuerX500Principal23712)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._getIssuerX500Principal23712)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName23713;
		public abstract global::java.lang.String getSigAlgName();
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID23714;
		public abstract global::java.lang.String getSigAlgOID();
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams23715;
		public abstract byte[] getSigAlgParams();
		internal static global::MonoJavaBridge.MethodId _getThisUpdate23716;
		public abstract global::java.util.Date getThisUpdate();
		internal static global::MonoJavaBridge.MethodId _getNextUpdate23717;
		public abstract global::java.util.Date getNextUpdate();
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificate23718;
		public virtual global::java.security.cert.X509CRLEntry getRevokedCertificate(java.security.cert.X509Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL._getRevokedCertificate23718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509CRLEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._getRevokedCertificate23718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509CRLEntry;
		}
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificate23719;
		public abstract global::java.security.cert.X509CRLEntry getRevokedCertificate(java.math.BigInteger arg0);
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificates23720;
		public abstract global::java.util.Set getRevokedCertificates();
		internal static global::MonoJavaBridge.MethodId _getTBSCertList23721;
		public abstract byte[] getTBSCertList();
		internal static global::MonoJavaBridge.MethodId _X509CRL23722;
		protected X509CRL()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._X509CRL23722);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRL.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRL"));
			global::java.security.cert.X509CRL._hasUnsupportedCriticalExtension23700 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509CRL._getCriticalExtensionOIDs23701 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL._getNonCriticalExtensionOIDs23702 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL._getExtensionValue23703 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509CRL._equals23704 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.cert.X509CRL._hashCode23705 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "hashCode", "()I");
			global::java.security.cert.X509CRL._getSignature23706 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509CRL._getEncoded23707 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509CRL._verify23708 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.X509CRL._verify23709 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.X509CRL._getVersion23710 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getVersion", "()I");
			global::java.security.cert.X509CRL._getIssuerDN23711 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509CRL._getIssuerX500Principal23712 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509CRL._getSigAlgName23713 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL._getSigAlgOID23714 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL._getSigAlgParams23715 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509CRL._getThisUpdate23716 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getThisUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL._getNextUpdate23717 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getNextUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL._getRevokedCertificate23718 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getRevokedCertificate", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509CRLEntry;");
			global::java.security.cert.X509CRL._getRevokedCertificate23719 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;");
			global::java.security.cert.X509CRL._getRevokedCertificates23720 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getRevokedCertificates", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL._getTBSCertList23721 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getTBSCertList", "()[B");
			global::java.security.cert.X509CRL._X509CRL23722 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.X509CRL))]
	internal sealed partial class X509CRL_ : java.security.cert.X509CRL
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509CRL_()
		{
			InitJNI();
		}
		internal X509CRL_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23723;
		public override bool hasUnsupportedCriticalExtension() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL_._hasUnsupportedCriticalExtension23723);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._hasUnsupportedCriticalExtension23723);
		}
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23724;
		public override global::java.util.Set getCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getCriticalExtensionOIDs23724)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getCriticalExtensionOIDs23724)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23725;
		public override global::java.util.Set getNonCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getNonCriticalExtensionOIDs23725)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getNonCriticalExtensionOIDs23725)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23726;
		public override byte[] getExtensionValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getExtensionValue23726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getExtensionValue23726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getSignature23727;
		public override byte[] getSignature() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSignature23727)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getSignature23727)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23728;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getEncoded23728)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getEncoded23728)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify23729;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRL_._verify23729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._verify23729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _verify23730;
		public override void verify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRL_._verify23730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._verify23730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVersion23731;
		public override int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getVersion23731);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getVersion23731);
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerDN23732;
		public override global::java.security.Principal getIssuerDN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getIssuerDN23732)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getIssuerDN23732)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName23733;
		public override global::java.lang.String getSigAlgName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSigAlgName23733)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getSigAlgName23733)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID23734;
		public override global::java.lang.String getSigAlgOID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSigAlgOID23734)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getSigAlgOID23734)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams23735;
		public override byte[] getSigAlgParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSigAlgParams23735)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getSigAlgParams23735)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getThisUpdate23736;
		public override global::java.util.Date getThisUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getThisUpdate23736)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getThisUpdate23736)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getNextUpdate23737;
		public override global::java.util.Date getNextUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getNextUpdate23737)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getNextUpdate23737)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificate23738;
		public override global::java.security.cert.X509CRLEntry getRevokedCertificate(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getRevokedCertificate23738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509CRLEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getRevokedCertificate23738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509CRLEntry;
		}
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificates23739;
		public override global::java.util.Set getRevokedCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getRevokedCertificates23739)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getRevokedCertificates23739)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getTBSCertList23740;
		public override byte[] getTBSCertList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getTBSCertList23740)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getTBSCertList23740)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _toString23741;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._toString23741)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._toString23741)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isRevoked23742;
		public override bool isRevoked(java.security.cert.Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL_._isRevoked23742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._isRevoked23742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRL_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRL"));
			global::java.security.cert.X509CRL_._hasUnsupportedCriticalExtension23723 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509CRL_._getCriticalExtensionOIDs23724 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL_._getNonCriticalExtensionOIDs23725 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL_._getExtensionValue23726 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509CRL_._getSignature23727 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509CRL_._getEncoded23728 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509CRL_._verify23729 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.X509CRL_._verify23730 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.X509CRL_._getVersion23731 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getVersion", "()I");
			global::java.security.cert.X509CRL_._getIssuerDN23732 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509CRL_._getSigAlgName23733 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL_._getSigAlgOID23734 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL_._getSigAlgParams23735 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509CRL_._getThisUpdate23736 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getThisUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL_._getNextUpdate23737 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getNextUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL_._getRevokedCertificate23738 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;");
			global::java.security.cert.X509CRL_._getRevokedCertificates23739 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getRevokedCertificates", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL_._getTBSCertList23740 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getTBSCertList", "()[B");
			global::java.security.cert.X509CRL_._toString23741 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL_._isRevoked23742 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "isRevoked", "(Ljava/security/cert/Certificate;)Z");
		}
	}
}
