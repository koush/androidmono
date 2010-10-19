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
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension17981;
		public abstract bool hasUnsupportedCriticalExtension();
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs17982;
		public abstract global::java.util.Set getCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs17983;
		public abstract global::java.util.Set getNonCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getExtensionValue17984;
		public abstract byte[] getExtensionValue(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _equals17985;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL._equals17985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._equals17985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode17986;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509CRL._hashCode17986);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._hashCode17986);
		}
		internal static global::MonoJavaBridge.MethodId _getSignature17987;
		public abstract byte[] getSignature();
		internal static global::MonoJavaBridge.MethodId _getEncoded17988;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _verify17989;
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _verify17990;
		public abstract void verify(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _getVersion17991;
		public abstract int getVersion();
		internal static global::MonoJavaBridge.MethodId _getIssuerDN17992;
		public abstract global::java.security.Principal getIssuerDN();
		internal static global::MonoJavaBridge.MethodId _getIssuerX500Principal17993;
		public virtual global::javax.security.auth.x500.X500Principal getIssuerX500Principal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL._getIssuerX500Principal17993)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._getIssuerX500Principal17993)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName17994;
		public abstract global::java.lang.String getSigAlgName();
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID17995;
		public abstract global::java.lang.String getSigAlgOID();
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams17996;
		public abstract byte[] getSigAlgParams();
		internal static global::MonoJavaBridge.MethodId _getThisUpdate17997;
		public abstract global::java.util.Date getThisUpdate();
		internal static global::MonoJavaBridge.MethodId _getNextUpdate17998;
		public abstract global::java.util.Date getNextUpdate();
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificate17999;
		public virtual global::java.security.cert.X509CRLEntry getRevokedCertificate(java.security.cert.X509Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL._getRevokedCertificate17999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509CRLEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._getRevokedCertificate17999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509CRLEntry;
		}
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificate18000;
		public abstract global::java.security.cert.X509CRLEntry getRevokedCertificate(java.math.BigInteger arg0);
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificates18001;
		public abstract global::java.util.Set getRevokedCertificates();
		internal static global::MonoJavaBridge.MethodId _getTBSCertList18002;
		public abstract byte[] getTBSCertList();
		internal static global::MonoJavaBridge.MethodId _X509CRL18003;
		protected X509CRL()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CRL.staticClass, global::java.security.cert.X509CRL._X509CRL18003);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRL.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRL"));
			global::java.security.cert.X509CRL._hasUnsupportedCriticalExtension17981 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509CRL._getCriticalExtensionOIDs17982 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL._getNonCriticalExtensionOIDs17983 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL._getExtensionValue17984 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509CRL._equals17985 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.cert.X509CRL._hashCode17986 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "hashCode", "()I");
			global::java.security.cert.X509CRL._getSignature17987 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509CRL._getEncoded17988 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509CRL._verify17989 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.X509CRL._verify17990 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.X509CRL._getVersion17991 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getVersion", "()I");
			global::java.security.cert.X509CRL._getIssuerDN17992 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509CRL._getIssuerX500Principal17993 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509CRL._getSigAlgName17994 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL._getSigAlgOID17995 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL._getSigAlgParams17996 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509CRL._getThisUpdate17997 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getThisUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL._getNextUpdate17998 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getNextUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL._getRevokedCertificate17999 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getRevokedCertificate", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509CRLEntry;");
			global::java.security.cert.X509CRL._getRevokedCertificate18000 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;");
			global::java.security.cert.X509CRL._getRevokedCertificates18001 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getRevokedCertificates", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL._getTBSCertList18002 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "getTBSCertList", "()[B");
			global::java.security.cert.X509CRL._X509CRL18003 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension18004;
		public override bool hasUnsupportedCriticalExtension() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL_._hasUnsupportedCriticalExtension18004);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._hasUnsupportedCriticalExtension18004);
		}
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs18005;
		public override global::java.util.Set getCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getCriticalExtensionOIDs18005)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getCriticalExtensionOIDs18005)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs18006;
		public override global::java.util.Set getNonCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getNonCriticalExtensionOIDs18006)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getNonCriticalExtensionOIDs18006)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionValue18007;
		public override byte[] getExtensionValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getExtensionValue18007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getExtensionValue18007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getSignature18008;
		public override byte[] getSignature() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSignature18008)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getSignature18008)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded18009;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getEncoded18009)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getEncoded18009)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify18010;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRL_._verify18010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._verify18010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _verify18011;
		public override void verify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.X509CRL_._verify18011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._verify18011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVersion18012;
		public override int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getVersion18012);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getVersion18012);
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerDN18013;
		public override global::java.security.Principal getIssuerDN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getIssuerDN18013)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getIssuerDN18013)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName18014;
		public override global::java.lang.String getSigAlgName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSigAlgName18014)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getSigAlgName18014)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID18015;
		public override global::java.lang.String getSigAlgOID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSigAlgOID18015)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getSigAlgOID18015)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams18016;
		public override byte[] getSigAlgParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getSigAlgParams18016)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getSigAlgParams18016)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getThisUpdate18017;
		public override global::java.util.Date getThisUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getThisUpdate18017)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getThisUpdate18017)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getNextUpdate18018;
		public override global::java.util.Date getNextUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getNextUpdate18018)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getNextUpdate18018)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificate18019;
		public override global::java.security.cert.X509CRLEntry getRevokedCertificate(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getRevokedCertificate18019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509CRLEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getRevokedCertificate18019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509CRLEntry;
		}
		internal static global::MonoJavaBridge.MethodId _getRevokedCertificates18020;
		public override global::java.util.Set getRevokedCertificates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getRevokedCertificates18020)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getRevokedCertificates18020)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getTBSCertList18021;
		public override byte[] getTBSCertList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._getTBSCertList18021)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._getTBSCertList18021)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _toString18022;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_._toString18022)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._toString18022)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isRevoked18023;
		public override bool isRevoked(java.security.cert.Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL_._isRevoked18023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRL_.staticClass, global::java.security.cert.X509CRL_._isRevoked18023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRL_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRL"));
			global::java.security.cert.X509CRL_._hasUnsupportedCriticalExtension18004 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509CRL_._getCriticalExtensionOIDs18005 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL_._getNonCriticalExtensionOIDs18006 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL_._getExtensionValue18007 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509CRL_._getSignature18008 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSignature", "()[B");
			global::java.security.cert.X509CRL_._getEncoded18009 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509CRL_._verify18010 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.X509CRL_._verify18011 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.X509CRL_._getVersion18012 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getVersion", "()I");
			global::java.security.cert.X509CRL_._getIssuerDN18013 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::java.security.cert.X509CRL_._getSigAlgName18014 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL_._getSigAlgOID18015 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL_._getSigAlgParams18016 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getSigAlgParams", "()[B");
			global::java.security.cert.X509CRL_._getThisUpdate18017 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getThisUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL_._getNextUpdate18018 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getNextUpdate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRL_._getRevokedCertificate18019 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;");
			global::java.security.cert.X509CRL_._getRevokedCertificates18020 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getRevokedCertificates", "()Ljava/util/Set;");
			global::java.security.cert.X509CRL_._getTBSCertList18021 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "getTBSCertList", "()[B");
			global::java.security.cert.X509CRL_._toString18022 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CRL_._isRevoked18023 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRL_.staticClass, "isRevoked", "(Ljava/security/cert/Certificate;)Z");
		}
	}
}
