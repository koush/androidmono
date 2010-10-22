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
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23582;
		public abstract bool hasUnsupportedCriticalExtension();
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23583;
		public abstract global::java.util.Set getCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23584;
		public abstract global::java.util.Set getNonCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23585;
		public abstract byte[] getExtensionValue(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _equals23586;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL._equals23586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._equals23586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23587;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509CRL._hashCode23587);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._hashCode23587);
		}
		internal static global::MonoJavaBridge.MethodId _getSignature23588;
		public abstract byte[] getSignature();
		internal static global::MonoJavaBridge.MethodId _getEncoded23589;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _verify23590;
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _verify23591;
		public abstract void verify(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _getVersion23592;
		public abstract int getVersion();
		internal static global::MonoJavaBridge.MethodId _getIssuerDN23593;
		public abstract global::java.security.Principal getIssuerDN();
		internal static global::MonoJavaBridge.MethodId _getIssuerX500Principal23594;
		public virtual global::javax.security.auth.x500.X500Principal getIssuerX500Principal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL._getIssuerX500Principal23594)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._getIssuerX500Principal23594)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName23595;
		public abstract global::java.lang.String getSigAlgName();
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID23596;
		public abstract global::java.lang.String getSigAlgOID();
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams23597;
		public abstract byte[] getSigAlgParams();
		internal static global::MonoJavaBridge.MethodId _getThisUpdate23598;
		public abstract global::java.util.Date getThisUpdate();
		internal static global::MonoJavaBridge.MethodId _getNextUpdate23599;
		public abstract global::java.util.Date getNextUpdate();
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificate23600;
		public virtual global::java.security.cert.X509CRLEntry getRevokedCertificate(java.security.cert.X509Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL._getRevokedCertificate23600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509CRLEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._getRevokedCertificate23600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509CRLEntry;
		}
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificate23601;
		public abstract global::java.security.cert.X509CRLEntry getRevokedCertificate(java.math.BigInteger arg0);
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificates23602;
		public abstract global::java.util.Set getRevokedCertificates();
		internal static global::MonoJavaBridge.MethodId _getTBSCertList23603;
		public abstract byte[] getTBSCertList();
		internal static global::MonoJavaBridge.MethodId _X509CRL23604;
		protected X509CRL()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._X509CRL23604);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRL.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRL"));
			global::java.security.cert.X509CRL._hasUnsupportedCriticalExtension23582 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509CRL._getCriticalExtensionOIDs23583 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL._getNonCriticalExtensionOIDs23584 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL._getExtensionValue23585 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509CRL._equals23586 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.cert.X509CRL._hashCode23587 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "hashCode", "()I");
			global::java.security.cert.X509CRL._getSignature23588 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509CRL._getEncoded23589 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509CRL._verify23590 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.X509CRL._verify23591 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.X509CRL._getVersion23592 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getVersion", "()I");
			global::java.security.cert.X509CRL._getIssuerDN23593 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509CRL._getIssuerX500Principal23594 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509CRL._getSigAlgName23595 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL._getSigAlgOID23596 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL._getSigAlgParams23597 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509CRL._getThisUpdate23598 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getThisUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL._getNextUpdate23599 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getNextUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL._getRevokedCertificate23600 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getRevokedCertificate", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509CRLEntry;");
			global::java.security.cert.X509CRL._getRevokedCertificate23601 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;");
			global::java.security.cert.X509CRL._getRevokedCertificates23602 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getRevokedCertificates", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL._getTBSCertList23603 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getTBSCertList", "()[B");
			global::java.security.cert.X509CRL._X509CRL23604 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.X509CRL))]
	public sealed partial class X509CRL_ : java.security.cert.X509CRL
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509CRL_()
		{
			InitJNI();
		}
		internal X509CRL_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23605;
		public override bool hasUnsupportedCriticalExtension() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL_._hasUnsupportedCriticalExtension23605);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._hasUnsupportedCriticalExtension23605);
		}
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23606;
		public override global::java.util.Set getCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getCriticalExtensionOIDs23606)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getCriticalExtensionOIDs23606)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23607;
		public override global::java.util.Set getNonCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getNonCriticalExtensionOIDs23607)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getNonCriticalExtensionOIDs23607)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23608;
		public override byte[] getExtensionValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getExtensionValue23608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getExtensionValue23608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getSignature23609;
		public override byte[] getSignature() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSignature23609)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getSignature23609)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23610;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getEncoded23610)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getEncoded23610)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify23611;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRL_._verify23611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._verify23611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _verify23612;
		public override void verify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRL_._verify23612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._verify23612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVersion23613;
		public override int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getVersion23613);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getVersion23613);
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerDN23614;
		public override global::java.security.Principal getIssuerDN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getIssuerDN23614)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getIssuerDN23614)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName23615;
		public override global::java.lang.String getSigAlgName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSigAlgName23615)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getSigAlgName23615)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID23616;
		public override global::java.lang.String getSigAlgOID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSigAlgOID23616)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getSigAlgOID23616)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams23617;
		public override byte[] getSigAlgParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSigAlgParams23617)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getSigAlgParams23617)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getThisUpdate23618;
		public override global::java.util.Date getThisUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getThisUpdate23618)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getThisUpdate23618)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getNextUpdate23619;
		public override global::java.util.Date getNextUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getNextUpdate23619)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getNextUpdate23619)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificate23620;
		public override global::java.security.cert.X509CRLEntry getRevokedCertificate(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getRevokedCertificate23620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509CRLEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getRevokedCertificate23620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509CRLEntry;
		}
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificates23621;
		public override global::java.util.Set getRevokedCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getRevokedCertificates23621)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getRevokedCertificates23621)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getTBSCertList23622;
		public override byte[] getTBSCertList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getTBSCertList23622)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getTBSCertList23622)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _toString23623;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._toString23623)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._toString23623)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isRevoked23624;
		public override bool isRevoked(java.security.cert.Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL_._isRevoked23624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._isRevoked23624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRL_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRL"));
			global::java.security.cert.X509CRL_._hasUnsupportedCriticalExtension23605 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509CRL_._getCriticalExtensionOIDs23606 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL_._getNonCriticalExtensionOIDs23607 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL_._getExtensionValue23608 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509CRL_._getSignature23609 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509CRL_._getEncoded23610 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509CRL_._verify23611 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.X509CRL_._verify23612 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.X509CRL_._getVersion23613 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getVersion", "()I");
			global::java.security.cert.X509CRL_._getIssuerDN23614 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509CRL_._getSigAlgName23615 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL_._getSigAlgOID23616 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL_._getSigAlgParams23617 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509CRL_._getThisUpdate23618 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getThisUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL_._getNextUpdate23619 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getNextUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL_._getRevokedCertificate23620 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;");
			global::java.security.cert.X509CRL_._getRevokedCertificates23621 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getRevokedCertificates", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL_._getTBSCertList23622 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getTBSCertList", "()[B");
			global::java.security.cert.X509CRL_._toString23623 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL_._isRevoked23624 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "isRevoked", "(Ljava/security/cert/Certificate;)Z");
		}
	}
}
