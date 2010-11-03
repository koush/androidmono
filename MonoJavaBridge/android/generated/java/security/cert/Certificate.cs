namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.Certificate_))]
	public abstract partial class Certificate : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Certificate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class CertificateRep : java.lang.Object, java.io.Serializable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CertificateRep(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			protected virtual global::java.lang.Object readResolve()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.Certificate.CertificateRep.staticClass, "readResolve", "()Ljava/lang/Object;", ref global::java.security.cert.Certificate.CertificateRep._m0) as java.lang.Object;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			protected CertificateRep(java.lang.String arg0, byte[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.cert.Certificate.CertificateRep._m1.native == global::System.IntPtr.Zero)
					global::java.security.cert.Certificate.CertificateRep._m1 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.CertificateRep.staticClass, "<init>", "(Ljava/lang/String;[B)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.Certificate.CertificateRep.staticClass, global::java.security.cert.Certificate.CertificateRep._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			static CertificateRep()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.cert.Certificate.CertificateRep.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/Certificate$CertificateRep"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.Certificate.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.cert.Certificate._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.lang.String toString();
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.Certificate.staticClass, "hashCode", "()I", ref global::java.security.cert.Certificate._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.Certificate.staticClass, "getType", "()Ljava/lang/String;", ref global::java.security.cert.Certificate._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract byte[] getEncoded();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract void verify(java.security.PublicKey arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::java.security.PublicKey getPublicKey();
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual global::java.lang.Object writeReplace()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.Certificate.staticClass, "writeReplace", "()Ljava/lang/Object;", ref global::java.security.cert.Certificate._m8) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected Certificate(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.Certificate._m9.native == global::System.IntPtr.Zero)
				global::java.security.cert.Certificate._m9 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Certificate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/Certificate"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.Certificate))]
	internal sealed partial class Certificate_ : java.security.cert.Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.Certificate_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.Certificate_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.cert.Certificate_.staticClass, "getEncoded", "()[B", ref global::java.security.cert.Certificate_._m1) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void verify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V", ref global::java.security.cert.Certificate_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V", ref global::java.security.cert.Certificate_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.security.PublicKey getPublicKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::java.security.cert.Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;", ref global::java.security.cert.Certificate_._m4) as java.security.PublicKey;
		}
		static Certificate_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/Certificate"));
		}
	}
}
