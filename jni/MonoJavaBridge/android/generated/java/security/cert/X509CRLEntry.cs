namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.X509CRLEntry_))]
	public abstract partial class X509CRLEntry : java.lang.Object, X509Extension
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509CRLEntry()
		{
			InitJNI();
		}
		protected X509CRLEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23743;
		public abstract bool hasUnsupportedCriticalExtension();
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23744;
		public abstract global::java.util.Set getCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23745;
		public abstract global::java.util.Set getNonCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23746;
		public abstract byte[] getExtensionValue(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _equals23747;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry._equals23747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry.staticClass, global::java.security.cert.X509CRLEntry._equals23747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23748;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _hashCode23749;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry._hashCode23749);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry.staticClass, global::java.security.cert.X509CRLEntry._hashCode23749);
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23750;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _getSerialNumber23751;
		public abstract global::java.math.BigInteger getSerialNumber();
		internal static global::MonoJavaBridge.MethodId _getCertificateIssuer23752;
		public virtual global::javax.security.auth.x500.X500Principal getCertificateIssuer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry._getCertificateIssuer23752)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry.staticClass, global::java.security.cert.X509CRLEntry._getCertificateIssuer23752)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getRevocationDate23753;
		public abstract global::java.util.Date getRevocationDate();
		internal static global::MonoJavaBridge.MethodId _hasExtensions23754;
		public abstract bool hasExtensions();
		internal static global::MonoJavaBridge.MethodId _X509CRLEntry23755;
		public X509CRLEntry()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CRLEntry.staticClass, global::java.security.cert.X509CRLEntry._X509CRLEntry23755);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRLEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRLEntry"));
			global::java.security.cert.X509CRLEntry._hasUnsupportedCriticalExtension23743 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509CRLEntry._getCriticalExtensionOIDs23744 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRLEntry._getNonCriticalExtensionOIDs23745 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRLEntry._getExtensionValue23746 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509CRLEntry._equals23747 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.cert.X509CRLEntry._toString23748 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CRLEntry._hashCode23749 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "hashCode", "()I");
			global::java.security.cert.X509CRLEntry._getEncoded23750 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509CRLEntry._getSerialNumber23751 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509CRLEntry._getCertificateIssuer23752 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getCertificateIssuer", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509CRLEntry._getRevocationDate23753 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getRevocationDate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRLEntry._hasExtensions23754 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "hasExtensions", "()Z");
			global::java.security.cert.X509CRLEntry._X509CRLEntry23755 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.X509CRLEntry))]
	internal sealed partial class X509CRLEntry_ : java.security.cert.X509CRLEntry
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509CRLEntry_()
		{
			InitJNI();
		}
		internal X509CRLEntry_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23756;
		public override bool hasUnsupportedCriticalExtension() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._hasUnsupportedCriticalExtension23756);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._hasUnsupportedCriticalExtension23756);
		}
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23757;
		public override global::java.util.Set getCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getCriticalExtensionOIDs23757)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getCriticalExtensionOIDs23757)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23758;
		public override global::java.util.Set getNonCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getNonCriticalExtensionOIDs23758)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getNonCriticalExtensionOIDs23758)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23759;
		public override byte[] getExtensionValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getExtensionValue23759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getExtensionValue23759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _toString23760;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._toString23760)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._toString23760)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23761;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getEncoded23761)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getEncoded23761)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getSerialNumber23762;
		public override global::java.math.BigInteger getSerialNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getSerialNumber23762)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getSerialNumber23762)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getRevocationDate23763;
		public override global::java.util.Date getRevocationDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getRevocationDate23763)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getRevocationDate23763)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _hasExtensions23764;
		public override bool hasExtensions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._hasExtensions23764);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._hasExtensions23764);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRLEntry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRLEntry"));
			global::java.security.cert.X509CRLEntry_._hasUnsupportedCriticalExtension23756 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509CRLEntry_._getCriticalExtensionOIDs23757 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRLEntry_._getNonCriticalExtensionOIDs23758 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRLEntry_._getExtensionValue23759 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509CRLEntry_._toString23760 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CRLEntry_._getEncoded23761 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509CRLEntry_._getSerialNumber23762 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509CRLEntry_._getRevocationDate23763 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getRevocationDate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRLEntry_._hasExtensions23764 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "hasExtensions", "()Z");
		}
	}
}
