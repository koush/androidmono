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
			internal static global::MonoJavaBridge.MethodId _readResolve17834;
			protected virtual global::java.lang.Object readResolve() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.Certificate.CertificateRep._readResolve17834)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.Certificate.CertificateRep.staticClass, global::java.security.cert.Certificate.CertificateRep._readResolve17834)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _CertificateRep17835;
			protected CertificateRep(java.lang.String arg0, byte[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.Certificate.CertificateRep.staticClass, global::java.security.cert.Certificate.CertificateRep._CertificateRep17835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.cert.Certificate.CertificateRep.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/Certificate$CertificateRep"));
				global::java.security.cert.Certificate.CertificateRep._readResolve17834 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.CertificateRep.staticClass, "readResolve", "()Ljava/lang/Object;");
				global::java.security.cert.Certificate.CertificateRep._CertificateRep17835 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.CertificateRep.staticClass, "<init>", "(Ljava/lang/String;[B)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals17836;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.cert.Certificate._equals17836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._equals17836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString17837;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _hashCode17838;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.Certificate._hashCode17838);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._hashCode17838);
		}
		internal static global::MonoJavaBridge.MethodId _getType17839;
		public virtual global::java.lang.String getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.Certificate._getType17839)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._getType17839)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded17840;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _verify17841;
		public abstract void verify(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _verify17842;
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _getPublicKey17843;
		public abstract global::java.security.PublicKey getPublicKey();
		internal static global::MonoJavaBridge.MethodId _writeReplace17844;
		protected virtual global::java.lang.Object writeReplace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.Certificate._writeReplace17844)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._writeReplace17844)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _Certificate17845;
		protected Certificate(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.Certificate.staticClass, global::java.security.cert.Certificate._Certificate17845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/Certificate"));
			global::java.security.cert.Certificate._equals17836 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.cert.Certificate._toString17837 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.Certificate._hashCode17838 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "hashCode", "()I");
			global::java.security.cert.Certificate._getType17839 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.cert.Certificate._getEncoded17840 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "getEncoded", "()[B");
			global::java.security.cert.Certificate._verify17841 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.Certificate._verify17842 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.Certificate._getPublicKey17843 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
			global::java.security.cert.Certificate._writeReplace17844 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "writeReplace", "()Ljava/lang/Object;");
			global::java.security.cert.Certificate._Certificate17845 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.Certificate))]
	public sealed partial class Certificate_ : java.security.cert.Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Certificate_()
		{
			InitJNI();
		}
		internal Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString17846;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.Certificate_._toString17846)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.Certificate_.staticClass, global::java.security.cert.Certificate_._toString17846)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded17847;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.Certificate_._getEncoded17847)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.Certificate_.staticClass, global::java.security.cert.Certificate_._getEncoded17847)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify17848;
		public override void verify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.Certificate_._verify17848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.Certificate_.staticClass, global::java.security.cert.Certificate_._verify17848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify17849;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.cert.Certificate_._verify17849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.cert.Certificate_.staticClass, global::java.security.cert.Certificate_._verify17849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey17850;
		public override global::java.security.PublicKey getPublicKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.Certificate_._getPublicKey17850)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.Certificate_.staticClass, global::java.security.cert.Certificate_._getPublicKey17850)) as java.security.PublicKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/Certificate"));
			global::java.security.cert.Certificate_._toString17846 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.Certificate_._getEncoded17847 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate_.staticClass, "getEncoded", "()[B");
			global::java.security.cert.Certificate_._verify17848 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::java.security.cert.Certificate_._verify17849 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::java.security.cert.Certificate_._getPublicKey17850 = @__env.GetMethodIDNoThrow(global::java.security.cert.Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
		}
	}
}
