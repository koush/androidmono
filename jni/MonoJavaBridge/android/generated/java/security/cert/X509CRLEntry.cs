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
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23625;
		public abstract bool hasUnsupportedCriticalExtension();
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23626;
		public abstract global::java.util.Set getCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23627;
		public abstract global::java.util.Set getNonCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23628;
		public abstract byte[] getExtensionValue(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _equals23629;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry._equals23629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry.staticClass, global::java.security.cert.X509CRLEntry._equals23629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23630;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _hashCode23631;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry._hashCode23631);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry.staticClass, global::java.security.cert.X509CRLEntry._hashCode23631);
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23632;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _getSerialNumber23633;
		public abstract global::java.math.BigInteger getSerialNumber();
		internal static global::MonoJavaBridge.MethodId _getCertificateIssuer23634;
		public virtual global::javax.security.auth.x500.X500Principal getCertificateIssuer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry._getCertificateIssuer23634)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.x500.X500Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry.staticClass, global::java.security.cert.X509CRLEntry._getCertificateIssuer23634)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getRevocationDate23635;
		public abstract global::java.util.Date getRevocationDate();
		internal static global::MonoJavaBridge.MethodId _hasExtensions23636;
		public abstract bool hasExtensions();
		internal static global::MonoJavaBridge.MethodId _X509CRLEntry23637;
		public X509CRLEntry()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CRLEntry.staticClass, global::java.security.cert.X509CRLEntry._X509CRLEntry23637);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRLEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRLEntry"));
			global::java.security.cert.X509CRLEntry._hasUnsupportedCriticalExtension23625 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509CRLEntry._getCriticalExtensionOIDs23626 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRLEntry._getNonCriticalExtensionOIDs23627 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRLEntry._getExtensionValue23628 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509CRLEntry._equals23629 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.cert.X509CRLEntry._toString23630 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CRLEntry._hashCode23631 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "hashCode", "()I");
			global::java.security.cert.X509CRLEntry._getEncoded23632 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509CRLEntry._getSerialNumber23633 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509CRLEntry._getCertificateIssuer23634 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getCertificateIssuer", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509CRLEntry._getRevocationDate23635 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getRevocationDate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRLEntry._hasExtensions23636 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "hasExtensions", "()Z");
			global::java.security.cert.X509CRLEntry._X509CRLEntry23637 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.X509CRLEntry))]
	public sealed partial class X509CRLEntry_ : java.security.cert.X509CRLEntry
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509CRLEntry_()
		{
			InitJNI();
		}
		internal X509CRLEntry_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension23638;
		public override bool hasUnsupportedCriticalExtension() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._hasUnsupportedCriticalExtension23638);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._hasUnsupportedCriticalExtension23638);
		}
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs23639;
		public override global::java.util.Set getCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getCriticalExtensionOIDs23639)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getCriticalExtensionOIDs23639)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs23640;
		public override global::java.util.Set getNonCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getNonCriticalExtensionOIDs23640)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getNonCriticalExtensionOIDs23640)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionValue23641;
		public override byte[] getExtensionValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getExtensionValue23641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getExtensionValue23641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _toString23642;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._toString23642)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._toString23642)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23643;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getEncoded23643)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getEncoded23643)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getSerialNumber23644;
		public override global::java.math.BigInteger getSerialNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getSerialNumber23644)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getSerialNumber23644)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getRevocationDate23645;
		public override global::java.util.Date getRevocationDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getRevocationDate23645)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getRevocationDate23645)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _hasExtensions23646;
		public override bool hasExtensions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._hasExtensions23646);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._hasExtensions23646);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRLEntry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRLEntry"));
			global::java.security.cert.X509CRLEntry_._hasUnsupportedCriticalExtension23638 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509CRLEntry_._getCriticalExtensionOIDs23639 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRLEntry_._getNonCriticalExtensionOIDs23640 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRLEntry_._getExtensionValue23641 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509CRLEntry_._toString23642 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CRLEntry_._getEncoded23643 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509CRLEntry_._getSerialNumber23644 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509CRLEntry_._getRevocationDate23645 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getRevocationDate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRLEntry_._hasExtensions23646 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "hasExtensions", "()Z");
		}
	}
}
