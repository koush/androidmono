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
			internal static global::MonoJavaBridge.MethodId _readResolve23554;
			protected virtual global::java.lang.Object readResolve()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.cert.Certificate.CertificateRep._readResolve23554.native == global::System.IntPtr.Zero)
					global::java.security.cert.Certificate.CertificateRep._readResolve23554 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.CertificateRep.staticClass, "readResolve", "()Ljava/lang/Object;");
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.Certificate.CertificateRep.staticClass, global::java.security.cert.Certificate.CertificateRep._readResolve23554) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _CertificateRep23555;
			protected CertificateRep(java.lang.String arg0, byte[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.cert.Certificate.CertificateRep._CertificateRep23555.native == global::System.IntPtr.Zero)
					global::java.security.cert.Certificate.CertificateRep._CertificateRep23555 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.CertificateRep.staticClass, "<init>", "(Ljava/lang/String;[B)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.Certificate.CertificateRep.staticClass, global::java.security.cert.Certificate.CertificateRep._CertificateRep23555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			static CertificateRep()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.cert.Certificate.CertificateRep.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/Certificate$CertificateRep"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals23556;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.Certificate._equals23556.native == global::System.IntPtr.Zero)
				global::java.security.cert.Certificate._equals23556 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._equals23556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23557;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _hashCode23558;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.Certificate._hashCode23558.native == global::System.IntPtr.Zero)
				global::java.security.cert.Certificate._hashCode23558 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._hashCode23558);
		}
		internal static global::MonoJavaBridge.MethodId _getType23559;
		public virtual global::java.lang.String getType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.Certificate._getType23559.native == global::System.IntPtr.Zero)
				global::java.security.cert.Certificate._getType23559 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "getType", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._getType23559) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23560;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _verify23561;
		public abstract void verify(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _verify23562;
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _getPublicKey23563;
		public abstract global::java.security.PublicKey getPublicKey();
		internal static global::MonoJavaBridge.MethodId _writeReplace23564;
		protected virtual global::java.lang.Object writeReplace()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.Certificate._writeReplace23564.native == global::System.IntPtr.Zero)
				global::java.security.cert.Certificate._writeReplace23564 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "writeReplace", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._writeReplace23564) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _Certificate23565;
		protected Certificate(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.Certificate._Certificate23565.native == global::System.IntPtr.Zero)
				global::java.security.cert.Certificate._Certificate23565 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._Certificate23565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Certificate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/Certificate"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.Certificate))]
	internal sealed partial class Certificate_ : java.security.cert.Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23566;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.Certificate_._toString23566.native == global::System.IntPtr.Zero)
				global::java.security.cert.Certificate_._toString23566 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate_.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.Certificate_._toString23566)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23567;
		public override byte[] getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.Certificate_._getEncoded23567.native == global::System.IntPtr.Zero)
				global::java.security.cert.Certificate_._getEncoded23567 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate_.staticClass, "getEncoded", "()[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.Certificate_._getEncoded23567)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify23568;
		public override void verify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.Certificate_._verify23568.native == global::System.IntPtr.Zero)
				global::java.security.cert.Certificate_._verify23568 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.Certificate_._verify23568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify23569;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.Certificate_._verify23569.native == global::System.IntPtr.Zero)
				global::java.security.cert.Certificate_._verify23569 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.Certificate_._verify23569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey23570;
		public override global::java.security.PublicKey getPublicKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.Certificate_._getPublicKey23570.native == global::System.IntPtr.Zero)
				global::java.security.cert.Certificate_._getPublicKey23570 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.Certificate_._getPublicKey23570)) as java.security.PublicKey;
		}
		static Certificate_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/Certificate"));
		}
		internal static void InitJNI()
		{
		}
	}
}
