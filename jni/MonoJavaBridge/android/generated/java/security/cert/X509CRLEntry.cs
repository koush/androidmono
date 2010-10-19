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
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension18024;
		public abstract bool hasUnsupportedCriticalExtension();
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs18025;
		public abstract global::java.util.Set getCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs18026;
		public abstract global::java.util.Set getNonCriticalExtensionOIDs();
		internal static global::MonoJavaBridge.MethodId _getExtensionValue18027;
		public abstract byte[] getExtensionValue(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _equals18028;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry._equals18028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry.staticClass, global::java.security.cert.X509CRLEntry._equals18028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString18029;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _hashCode18030;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry._hashCode18030);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry.staticClass, global::java.security.cert.X509CRLEntry._hashCode18030);
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded18031;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _getSerialNumber18032;
		public abstract global::java.math.BigInteger getSerialNumber();
		internal static global::MonoJavaBridge.MethodId _getCertificateIssuer18033;
		public virtual global::javax.security.auth.x500.X500Principal getCertificateIssuer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry._getCertificateIssuer18033)) as javax.security.auth.x500.X500Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry.staticClass, global::java.security.cert.X509CRLEntry._getCertificateIssuer18033)) as javax.security.auth.x500.X500Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getRevocationDate18034;
		public abstract global::java.util.Date getRevocationDate();
		internal static global::MonoJavaBridge.MethodId _hasExtensions18035;
		public abstract bool hasExtensions();
		internal static global::MonoJavaBridge.MethodId _X509CRLEntry18036;
		public X509CRLEntry()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CRLEntry.staticClass, global::java.security.cert.X509CRLEntry._X509CRLEntry18036);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRLEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRLEntry"));
			global::java.security.cert.X509CRLEntry._hasUnsupportedCriticalExtension18024 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509CRLEntry._getCriticalExtensionOIDs18025 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRLEntry._getNonCriticalExtensionOIDs18026 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRLEntry._getExtensionValue18027 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509CRLEntry._equals18028 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.cert.X509CRLEntry._toString18029 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CRLEntry._hashCode18030 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "hashCode", "()I");
			global::java.security.cert.X509CRLEntry._getEncoded18031 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509CRLEntry._getSerialNumber18032 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509CRLEntry._getCertificateIssuer18033 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getCertificateIssuer", "()Ljavax/security/auth/x500/X500Principal;");
			global::java.security.cert.X509CRLEntry._getRevocationDate18034 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "getRevocationDate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRLEntry._hasExtensions18035 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "hasExtensions", "()Z");
			global::java.security.cert.X509CRLEntry._X509CRLEntry18036 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _hasUnsupportedCriticalExtension18037;
		public override bool hasUnsupportedCriticalExtension() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._hasUnsupportedCriticalExtension18037);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._hasUnsupportedCriticalExtension18037);
		}
		internal static global::MonoJavaBridge.MethodId _getCriticalExtensionOIDs18038;
		public override global::java.util.Set getCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getCriticalExtensionOIDs18038)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getCriticalExtensionOIDs18038)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getNonCriticalExtensionOIDs18039;
		public override global::java.util.Set getNonCriticalExtensionOIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getNonCriticalExtensionOIDs18039)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getNonCriticalExtensionOIDs18039)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getExtensionValue18040;
		public override byte[] getExtensionValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getExtensionValue18040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getExtensionValue18040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _toString18041;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._toString18041)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._toString18041)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded18042;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getEncoded18042)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getEncoded18042)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getSerialNumber18043;
		public override global::java.math.BigInteger getSerialNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getSerialNumber18043)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getSerialNumber18043)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getRevocationDate18044;
		public override global::java.util.Date getRevocationDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._getRevocationDate18044)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._getRevocationDate18044)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _hasExtensions18045;
		public override bool hasExtensions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_._hasExtensions18045);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.X509CRLEntry_.staticClass, global::java.security.cert.X509CRLEntry_._hasExtensions18045);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRLEntry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRLEntry"));
			global::java.security.cert.X509CRLEntry_._hasUnsupportedCriticalExtension18037 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.X509CRLEntry_._getCriticalExtensionOIDs18038 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRLEntry_._getNonCriticalExtensionOIDs18039 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.X509CRLEntry_._getExtensionValue18040 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B");
			global::java.security.cert.X509CRLEntry_._toString18041 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.X509CRLEntry_._getEncoded18042 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.X509CRLEntry_._getSerialNumber18043 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::java.security.cert.X509CRLEntry_._getRevocationDate18044 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "getRevocationDate", "()Ljava/util/Date;");
			global::java.security.cert.X509CRLEntry_._hasExtensions18045 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry_.staticClass, "hasExtensions", "()Z");
		}
	}
}
