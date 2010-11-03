namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.X509CRLEntry_))]
	public abstract partial class X509CRLEntry : java.lang.Object, X509Extension
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected X509CRLEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509CRLEntry.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.cert.X509CRLEntry._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.lang.String toString();
		private static global::MonoJavaBridge.MethodId _m6;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.X509CRLEntry.staticClass, "hashCode", "()I", ref global::java.security.cert.X509CRLEntry._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract byte[] getEncoded();
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::java.math.BigInteger getSerialNumber();
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::javax.security.auth.x500.X500Principal getCertificateIssuer()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<javax.security.auth.x500.X500Principal>(this, global::java.security.cert.X509CRLEntry.staticClass, "getCertificateIssuer", "()Ljavax/security/auth/x500/X500Principal;", ref global::java.security.cert.X509CRLEntry._m9) as javax.security.auth.x500.X500Principal;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract global::java.util.Date getRevocationDate();
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract bool hasExtensions();
		private static global::MonoJavaBridge.MethodId _m12;
		public X509CRLEntry() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.X509CRLEntry._m12.native == global::System.IntPtr.Zero)
				global::java.security.cert.X509CRLEntry._m12 = @__env.GetMethodIDNoThrow(global::java.security.cert.X509CRLEntry.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.X509CRLEntry.staticClass, global::java.security.cert.X509CRLEntry._m12);
			Init(@__env, handle);
		}
		static X509CRLEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRLEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRLEntry"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.X509CRLEntry))]
	internal sealed partial class X509CRLEntry_ : java.security.cert.X509CRLEntry
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal X509CRLEntry_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool hasUnsupportedCriticalExtension()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509CRLEntry_.staticClass, "hasUnsupportedCriticalExtension", "()Z", ref global::java.security.cert.X509CRLEntry_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.util.Set getCriticalExtensionOIDs()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.X509CRLEntry_.staticClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;", ref global::java.security.cert.X509CRLEntry_._m1) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.util.Set getNonCriticalExtensionOIDs()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.cert.X509CRLEntry_.staticClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;", ref global::java.security.cert.X509CRLEntry_._m2) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override byte[] getExtensionValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509CRLEntry_.staticClass, "getExtensionValue", "(Ljava/lang/String;)[B", ref global::java.security.cert.X509CRLEntry_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.X509CRLEntry_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.X509CRLEntry_._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.X509CRLEntry_.staticClass, "getEncoded", "()[B", ref global::java.security.cert.X509CRLEntry_._m5) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.math.BigInteger getSerialNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLEntry_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;", ref global::java.security.cert.X509CRLEntry_._m6) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.util.Date getRevocationDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.X509CRLEntry_.staticClass, "getRevocationDate", "()Ljava/util/Date;", ref global::java.security.cert.X509CRLEntry_._m7) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool hasExtensions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.X509CRLEntry_.staticClass, "hasExtensions", "()Z", ref global::java.security.cert.X509CRLEntry_._m8);
		}
		static X509CRLEntry_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.X509CRLEntry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/X509CRLEntry"));
		}
	}
}
