namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.X509Certificate_))]
	public abstract partial class X509Certificate : java.security.cert.Certificate, X509Extension
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected X509Certificate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract bool hasUnsupportedCriticalExtension();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.util.Set getCriticalExtensionOIDs();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.util.Set getNonCriticalExtensionOIDs();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract byte[] getExtensionValue(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract byte[] getSignature();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract int getBasicConstraints();
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract int getVersion();
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::java.math.BigInteger getSerialNumber();
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::java.security.Principal getIssuerDN();
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract byte[] getTBSCertificate();
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract void checkValidity();
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract void checkValidity(java.util.Date arg0);
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::javax.security.auth.x500.X500Principal getIssuerX500Principal()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<javax.security.auth.x500.X500Principal>(this, global::java.security.cert.X509Certificate.staticClass, "getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;", ref global::java.security.cert.X509Certificate._m12) as javax.security.auth.x500.X500Principal;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract global::java.security.Principal getSubjectDN();
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::javax.security.auth.x500.X500Principal getSubjectX500Principal()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<javax.security.auth.x500.X500Principal>(this, global::java.security.cert.X509Certificate.staticClass, "getSubjectX500Principal", "()Ljavax/security/auth/x500/X500Principal;", ref global::java.security.cert.X509Certificate._m14) as javax.security.auth.x500.X500Principal;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public abstract global::java.util.Date getNotBefore();
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract global::java.util.Date getNotAfter();
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract global::java.lang.String getSigAlgName();
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract global::java.lang.String getSigAlgOID();
		private static global::MonoJavaBridge.MethodId _m19;
		public abstract byte[] getSigAlgParams();
		private static global::MonoJavaBridge.MethodId _m20;
		public abstract bool[] getIssuerUniqueID();
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract bool[] getSubjectUniqueID();
		private static global::MonoJavaBridge.MethodId _m22;
		public abstract bool[] getKeyUsage();
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::java.util.List getExtendedKeyUsage()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.security.cert.X509Certificate.staticClass, "getExtendedKeyUsage", "()Ljava/util/List;", ref global::java.security.cert.X509Certificate._m23) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual global::java.util.Collection getSubjectAlternativeNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.X509Certificate.staticClass, "getSubjectAlternativeNames", "()Ljava/util/Collection;", ref global::java.security.cert.X509Certificate._m24) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.util.Collection getIssuerAlternativeNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.cert.X509Certificate.staticClass, "getIssuerAlternativeNames", "()Ljava/util/Collection;", ref global::java.security.cert.X509Certificate._m25) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		protected X509Certificate() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.X509Certificate._m26.native == global::System.IntPtr.Zero)
				global::java.security.cert.X509Certificate._m26 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509Certificate.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509Certificate.staticClass, global::java.security.cert.X509Certificate._m26);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool hasUnsupportedCriticalExtension()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509Certificate_.staticClass, "hasUnsupportedCriticalExtension", "()Z", ref global::java.security.cert.X509Certificate_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.util.Set getCriticalExtensionOIDs()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.X509Certificate_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;", ref global::java.security.cert.X509Certificate_._m1) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.util.Set getNonCriticalExtensionOIDs()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.X509Certificate_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;", ref global::java.security.cert.X509Certificate_._m2) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override byte[] getExtensionValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509Certificate_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B", ref global::java.security.cert.X509Certificate_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override byte[] getSignature()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509Certificate_.staticClass, "getSignature", "()[B", ref global::java.security.cert.X509Certificate_._m4) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int getBasicConstraints()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.X509Certificate_.staticClass, "getBasicConstraints", "()I", ref global::java.security.cert.X509Certificate_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.X509Certificate_.staticClass, "getVersion", "()I", ref global::java.security.cert.X509Certificate_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.math.BigInteger getSerialNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509Certificate_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;", ref global::java.security.cert.X509Certificate_._m7) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.security.Principal getIssuerDN()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::java.security.cert.X509Certificate_.staticClass, "getIssuerDN", "()Ljava/security/Principal;", ref global::java.security.cert.X509Certificate_._m8) as java.security.Principal;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override byte[] getTBSCertificate()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509Certificate_.staticClass, "getTBSCertificate", "()[B", ref global::java.security.cert.X509Certificate_._m9) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void checkValidity()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509Certificate_.staticClass, "checkValidity", "()V", ref global::java.security.cert.X509Certificate_._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override void checkValidity(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509Certificate_.staticClass, "checkValidity", "(Ljava/util/Date;)V", ref global::java.security.cert.X509Certificate_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::java.security.Principal getSubjectDN()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::java.security.cert.X509Certificate_.staticClass, "getSubjectDN", "()Ljava/security/Principal;", ref global::java.security.cert.X509Certificate_._m12) as java.security.Principal;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override global::java.util.Date getNotBefore()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509Certificate_.staticClass, "getNotBefore", "()Ljava/util/Date;", ref global::java.security.cert.X509Certificate_._m13) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override global::java.util.Date getNotAfter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509Certificate_.staticClass, "getNotAfter", "()Ljava/util/Date;", ref global::java.security.cert.X509Certificate_._m14) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override global::java.lang.String getSigAlgName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509Certificate_.staticClass, "getSigAlgName", "()Ljava/lang/String;", ref global::java.security.cert.X509Certificate_._m15) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override global::java.lang.String getSigAlgOID()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509Certificate_.staticClass, "getSigAlgOID", "()Ljava/lang/String;", ref global::java.security.cert.X509Certificate_._m16) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override byte[] getSigAlgParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509Certificate_.staticClass, "getSigAlgParams", "()[B", ref global::java.security.cert.X509Certificate_._m17) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override bool[] getIssuerUniqueID()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<bool>(this, global::java.security.cert.X509Certificate_.staticClass, "getIssuerUniqueID", "()[Z", ref global::java.security.cert.X509Certificate_._m18) as bool[];
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override bool[] getSubjectUniqueID()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<bool>(this, global::java.security.cert.X509Certificate_.staticClass, "getSubjectUniqueID", "()[Z", ref global::java.security.cert.X509Certificate_._m19) as bool[];
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override bool[] getKeyUsage()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<bool>(this, global::java.security.cert.X509Certificate_.staticClass, "getKeyUsage", "()[Z", ref global::java.security.cert.X509Certificate_._m20) as bool[];
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509Certificate_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.X509Certificate_._m21) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public override byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509Certificate_.staticClass, "getEncoded", "()[B", ref global::java.security.cert.X509Certificate_._m22) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public override void verify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V", ref global::java.security.cert.X509Certificate_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V", ref global::java.security.cert.X509Certificate_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public override global::java.security.PublicKey getPublicKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::java.security.cert.X509Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;", ref global::java.security.cert.X509Certificate_._m25) as java.security.PublicKey;
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
