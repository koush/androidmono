namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.X509CRLEntry_))]
	public abstract partial class X509CRLEntry : java.lang.Object, X509Extension
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected X509CRLEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23744;
		public abstract bool hasUnsupportedCriticalExtension();
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23745;
		public abstract global::java.util.Set getCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23746;
		public abstract global::java.util.Set getNonCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23747;
		public abstract byte[] getExtensionValue(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _equals23748;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509CRLEntry.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.cert.X509CRLEntry._equals23748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23749;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _hashCode23750;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.X509CRLEntry.staticClass, "hashCode", "()I", ref global::java.security.cert.X509CRLEntry._hashCode23750);
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23751;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _getSerialNumber23752;
		public abstract global::java.math.BigInteger getSerialNumber();
		internal static global::MonoJavaBridge.MethodId _getCertificateIssuer23753;
		public virtual global::javax.security.auth.x500.X500Principal getCertificateIssuer()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<javax.security.auth.x500.X500Principal>(this, global::java.security.cert.X509CRLEntry.staticClass, "getCertificateIssuer", "()Ljavax/security/auth/x500/X500Principal;", ref global::java.security.cert.X509CRLEntry._getCertificateIssuer23753) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getRevocationDate23754;
		public abstract global::java.util.Date getRevocationDate();
		internal static global::MonoJavaBridge.MethodId _hasExtensions23755;
		public abstract bool hasExtensions();
		internal static global::MonoJavaBridge.MethodId _X509CRLEntry23756;
		public X509CRLEntry() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.X509CRLEntry._X509CRLEntry23756.native == global::System.IntPtr.Zero)
				global::java.security.cert.X509CRLEntry._X509CRLEntry23756 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CRLEntry.staticClass, global::java.security.cert.X509CRLEntry._X509CRLEntry23756);
			Init(@__env, handle);
		}
		static X509CRLEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRLEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRLEntry"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.X509CRLEntry))]
	internal sealed partial class X509CRLEntry_ : java.security.cert.X509CRLEntry
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal X509CRLEntry_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23757;
		public override bool hasUnsupportedCriticalExtension()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509CRLEntry_.staticClass, "hasUnsupportedCriticalExtension", "()Z", ref global::java.security.cert.X509CRLEntry_._hasUnsupportedCriticalExtension23757);
		}
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23758;
		public override global::java.util.Set getCriticalExtensionOIDs()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.X509CRLEntry_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;", ref global::java.security.cert.X509CRLEntry_._getCriticalExtensionOIDs23758) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23759;
		public override global::java.util.Set getNonCriticalExtensionOIDs()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.X509CRLEntry_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;", ref global::java.security.cert.X509CRLEntry_._getNonCriticalExtensionOIDs23759) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23760;
		public override byte[] getExtensionValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509CRLEntry_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B", ref global::java.security.cert.X509CRLEntry_._getExtensionValue23760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _toString23761;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509CRLEntry_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.X509CRLEntry_._toString23761) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23762;
		public override byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509CRLEntry_.staticClass, "getEncoded", "()[B", ref global::java.security.cert.X509CRLEntry_._getEncoded23762) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getSerialNumber23763;
		public override global::java.math.BigInteger getSerialNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLEntry_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;", ref global::java.security.cert.X509CRLEntry_._getSerialNumber23763) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getRevocationDate23764;
		public override global::java.util.Date getRevocationDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLEntry_.staticClass, "getRevocationDate", "()Ljava/util/Date;", ref global::java.security.cert.X509CRLEntry_._getRevocationDate23764) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _hasExtensions23765;
		public override bool hasExtensions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509CRLEntry_.staticClass, "hasExtensions", "()Z", ref global::java.security.cert.X509CRLEntry_._hasExtensions23765);
		}
		static X509CRLEntry_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRLEntry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRLEntry"));
		}
		internal static void InitJNI()
		{
		}
	}
}
