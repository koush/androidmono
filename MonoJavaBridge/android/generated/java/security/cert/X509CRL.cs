namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.X509CRL_))]
	public abstract partial class X509CRL : java.security.cert.CRL, X509Extension
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected X509CRL(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509CRL.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.cert.X509CRL._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.X509CRL.staticClass, "hashCode", "()I", ref global::java.security.cert.X509CRL._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract byte[] getSignature();
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract byte[] getEncoded();
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract void verify(java.security.PublicKey arg0);
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract int getVersion();
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract global::java.security.Principal getIssuerDN();
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::javax.security.auth.x500.X500Principal getIssuerX500Principal()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<javax.security.auth.x500.X500Principal>(this, global::java.security.cert.X509CRL.staticClass, "getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;", ref global::java.security.cert.X509CRL._m12) as javax.security.auth.x500.X500Principal;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract global::java.lang.String getSigAlgName();
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract global::java.lang.String getSigAlgOID();
		private static global::MonoJavaBridge.MethodId _m15;
		public abstract byte[] getSigAlgParams();
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract global::java.util.Date getThisUpdate();
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract global::java.util.Date getNextUpdate();
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.security.cert.X509CRLEntry getRevokedCertificate(java.security.cert.X509Certificate arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRL.staticClass, "getRevokedCertificate", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509CRLEntry;", ref global::java.security.cert.X509CRL._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.X509CRLEntry;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public abstract global::java.security.cert.X509CRLEntry getRevokedCertificate(java.math.BigInteger arg0);
		private static global::MonoJavaBridge.MethodId _m20;
		public abstract global::java.util.Set getRevokedCertificates();
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract byte[] getTBSCertList();
		private static global::MonoJavaBridge.MethodId _m22;
		protected X509CRL() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.X509CRL._m22.native == global::System.IntPtr.Zero)
				global::java.security.cert.X509CRL._m22 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._m22);
			Init(@__env, handle);
		}
		static X509CRL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRL.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRL"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.X509CRL))]
	internal sealed partial class X509CRL_ : java.security.cert.X509CRL
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal X509CRL_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool hasUnsupportedCriticalExtension()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509CRL_.staticClass, "hasUnsupportedCriticalExtension", "()Z", ref global::java.security.cert.X509CRL_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.util.Set getCriticalExtensionOIDs()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.X509CRL_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;", ref global::java.security.cert.X509CRL_._m1) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.util.Set getNonCriticalExtensionOIDs()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.X509CRL_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;", ref global::java.security.cert.X509CRL_._m2) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override byte[] getExtensionValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509CRL_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B", ref global::java.security.cert.X509CRL_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override byte[] getSignature()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509CRL_.staticClass, "getSignature", "()[B", ref global::java.security.cert.X509CRL_._m4) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509CRL_.staticClass, "getEncoded", "()[B", ref global::java.security.cert.X509CRL_._m5) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRL_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V", ref global::java.security.cert.X509CRL_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void verify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.X509CRL_.staticClass, "verify", "(Ljava/security/PublicKey;)V", ref global::java.security.cert.X509CRL_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override int getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.X509CRL_.staticClass, "getVersion", "()I", ref global::java.security.cert.X509CRL_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.security.Principal getIssuerDN()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::java.security.cert.X509CRL_.staticClass, "getIssuerDN", "()Ljava/security/Principal;", ref global::java.security.cert.X509CRL_._m9) as java.security.Principal;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.lang.String getSigAlgName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509CRL_.staticClass, "getSigAlgName", "()Ljava/lang/String;", ref global::java.security.cert.X509CRL_._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::java.lang.String getSigAlgOID()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509CRL_.staticClass, "getSigAlgOID", "()Ljava/lang/String;", ref global::java.security.cert.X509CRL_._m11) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override byte[] getSigAlgParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509CRL_.staticClass, "getSigAlgParams", "()[B", ref global::java.security.cert.X509CRL_._m12) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override global::java.util.Date getThisUpdate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRL_.staticClass, "getThisUpdate", "()Ljava/util/Date;", ref global::java.security.cert.X509CRL_._m13) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override global::java.util.Date getNextUpdate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRL_.staticClass, "getNextUpdate", "()Ljava/util/Date;", ref global::java.security.cert.X509CRL_._m14) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override global::java.security.cert.X509CRLEntry getRevokedCertificate(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRL_.staticClass, "getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;", ref global::java.security.cert.X509CRL_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.X509CRLEntry;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override global::java.util.Set getRevokedCertificates()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.X509CRL_.staticClass, "getRevokedCertificates", "()Ljava/util/Set;", ref global::java.security.cert.X509CRL_._m16) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override byte[] getTBSCertList()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509CRL_.staticClass, "getTBSCertList", "()[B", ref global::java.security.cert.X509CRL_._m17) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509CRL_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.X509CRL_._m18) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override bool isRevoked(java.security.cert.Certificate arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509CRL_.staticClass, "isRevoked", "(Ljava/security/cert/Certificate;)Z", ref global::java.security.cert.X509CRL_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static X509CRL_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRL_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRL"));
		}
	}
}
