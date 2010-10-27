namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.Certificate_))]
	public abstract partial class Certificate : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Certificate()
		{
			InitJNI();
		}
		protected Certificate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class CertificateRep : java.lang.Object, java.io.Serializable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static CertificateRep()
			{
				InitJNI();
			}
			protected CertificateRep(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _readResolve23553;
			protected virtual global::java.lang.Object readResolve()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.Certificate.CertificateRep._readResolve23553)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.Certificate.CertificateRep.staticClass, global::java.security.cert.Certificate.CertificateRep._readResolve23553)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _CertificateRep23554;
			protected CertificateRep(java.lang.String arg0, byte[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.Certificate.CertificateRep.staticClass, global::java.security.cert.Certificate.CertificateRep._CertificateRep23554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.cert.Certificate.CertificateRep.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/Certificate$CertificateRep"));
				global::java.security.cert.Certificate.CertificateRep._readResolve23553 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.CertificateRep.staticClass, "readResolve", "()Ljava/lang/Object;");
				global::java.security.cert.Certificate.CertificateRep._CertificateRep23554 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.CertificateRep.staticClass, "<init>", "(Ljava/lang/String;[B)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals23555;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.Certificate._equals23555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._equals23555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23556;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _hashCode23557;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.Certificate._hashCode23557);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._hashCode23557);
		}
		internal static global::MonoJavaBridge.MethodId _getType23558;
		public virtual global::java.lang.String getType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.Certificate._getType23558)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._getType23558)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23559;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _verify23560;
		public abstract void verify(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _verify23561;
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _getPublicKey23562;
		public abstract global::java.security.PublicKey getPublicKey();
		internal static global::MonoJavaBridge.MethodId _writeReplace23563;
		protected virtual global::java.lang.Object writeReplace()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.Certificate._writeReplace23563)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._writeReplace23563)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _Certificate23564;
		protected Certificate(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._Certificate23564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/Certificate"));
			global::java.security.cert.Certificate._equals23555 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.cert.Certificate._toString23556 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.Certificate._hashCode23557 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "hashCode", "()I");
			global::java.security.cert.Certificate._getType23558 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.cert.Certificate._getEncoded23559 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "getEncoded", "()[B");
			global::java.security.cert.Certificate._verify23560 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.Certificate._verify23561 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.Certificate._getPublicKey23562 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
			global::java.security.cert.Certificate._writeReplace23563 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "writeReplace", "()Ljava/lang/Object;");
			global::java.security.cert.Certificate._Certificate23564 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.Certificate))]
	internal sealed partial class Certificate_ : java.security.cert.Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Certificate_()
		{
			InitJNI();
		}
		internal Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23565;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.Certificate_._toString23565)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.Certificate_.staticClass, global::java.security.cert.Certificate_._toString23565)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23566;
		public override byte[] getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.Certificate_._getEncoded23566)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.Certificate_.staticClass, global::java.security.cert.Certificate_._getEncoded23566)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify23567;
		public override void verify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.Certificate_._verify23567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.Certificate_.staticClass, global::java.security.cert.Certificate_._verify23567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify23568;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.Certificate_._verify23568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.Certificate_.staticClass, global::java.security.cert.Certificate_._verify23568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey23569;
		public override global::java.security.PublicKey getPublicKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.Certificate_._getPublicKey23569)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.Certificate_.staticClass, global::java.security.cert.Certificate_._getPublicKey23569)) as java.security.PublicKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/Certificate"));
			global::java.security.cert.Certificate_._toString23565 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.Certificate_._getEncoded23566 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.Certificate_._verify23567 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.Certificate_._verify23568 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.Certificate_._getPublicKey23569 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
		}
	}
}
