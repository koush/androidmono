namespace javax.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.security.cert.X509Certificate_))]
	public abstract partial class X509Certificate : javax.security.cert.Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected X509Certificate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.security.cert.X509Certificate getInstance(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.cert.X509Certificate._m0.native == global::System.IntPtr.Zero)
				global::javax.security.cert.X509Certificate._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getInstance", "([B)Ljavax/security/cert/X509Certificate;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.security.cert.X509Certificate;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::javax.security.cert.X509Certificate getInstance(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.cert.X509Certificate._m1.native == global::System.IntPtr.Zero)
				global::javax.security.cert.X509Certificate._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getInstance", "(Ljava/io/InputStream;)Ljavax/security/cert/X509Certificate;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.security.cert.X509Certificate;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract int getVersion();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::java.math.BigInteger getSerialNumber();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.security.Principal getIssuerDN();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract void checkValidity();
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract void checkValidity(java.util.Date arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::java.security.Principal getSubjectDN();
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::java.util.Date getNotBefore();
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract global::java.util.Date getNotAfter();
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract global::java.lang.String getSigAlgName();
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract global::java.lang.String getSigAlgOID();
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract byte[] getSigAlgParams();
		private static global::MonoJavaBridge.MethodId _m13;
		public X509Certificate() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.cert.X509Certificate._m13.native == global::System.IntPtr.Zero)
				global::javax.security.cert.X509Certificate._m13 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._m13);
			Init(@__env, handle);
		}
		static X509Certificate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.X509Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/X509Certificate"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.security.cert.X509Certificate))]
	internal sealed partial class X509Certificate_ : javax.security.cert.X509Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal X509Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "getVersion", "()I", ref global::javax.security.cert.X509Certificate_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.math.BigInteger getSerialNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;", ref global::javax.security.cert.X509Certificate_._m1) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.security.Principal getIssuerDN()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::javax.security.cert.X509Certificate_.staticClass, "getIssuerDN", "()Ljava/security/Principal;", ref global::javax.security.cert.X509Certificate_._m2) as java.security.Principal;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void checkValidity()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "checkValidity", "()V", ref global::javax.security.cert.X509Certificate_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void checkValidity(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "checkValidity", "(Ljava/util/Date;)V", ref global::javax.security.cert.X509Certificate_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.security.Principal getSubjectDN()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::javax.security.cert.X509Certificate_.staticClass, "getSubjectDN", "()Ljava/security/Principal;", ref global::javax.security.cert.X509Certificate_._m5) as java.security.Principal;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.util.Date getNotBefore()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "getNotBefore", "()Ljava/util/Date;", ref global::javax.security.cert.X509Certificate_._m6) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.util.Date getNotAfter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "getNotAfter", "()Ljava/util/Date;", ref global::javax.security.cert.X509Certificate_._m7) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.lang.String getSigAlgName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.security.cert.X509Certificate_.staticClass, "getSigAlgName", "()Ljava/lang/String;", ref global::javax.security.cert.X509Certificate_._m8) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.lang.String getSigAlgOID()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.security.cert.X509Certificate_.staticClass, "getSigAlgOID", "()Ljava/lang/String;", ref global::javax.security.cert.X509Certificate_._m9) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override byte[] getSigAlgParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.security.cert.X509Certificate_.staticClass, "getSigAlgParams", "()[B", ref global::javax.security.cert.X509Certificate_._m10) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.security.cert.X509Certificate_.staticClass, "toString", "()Ljava/lang/String;", ref global::javax.security.cert.X509Certificate_._m11) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.security.cert.X509Certificate_.staticClass, "getEncoded", "()[B", ref global::javax.security.cert.X509Certificate_._m12) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override void verify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V", ref global::javax.security.cert.X509Certificate_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V", ref global::javax.security.cert.X509Certificate_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override global::java.security.PublicKey getPublicKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::javax.security.cert.X509Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;", ref global::javax.security.cert.X509Certificate_._m15) as java.security.PublicKey;
		}
		static X509Certificate_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.X509Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/X509Certificate"));
		}
	}
}
