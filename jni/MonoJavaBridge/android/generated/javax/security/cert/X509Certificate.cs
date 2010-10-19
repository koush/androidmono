namespace javax.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.security.cert.X509Certificate_))]
	public abstract partial class X509Certificate : javax.security.cert.Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509Certificate()
		{
			InitJNI();
		}
		protected X509Certificate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23694;
		public static global::javax.security.cert.X509Certificate getInstance(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._getInstance23694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.security.cert.X509Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23695;
		public static global::javax.security.cert.X509Certificate getInstance(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._getInstance23695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.security.cert.X509Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion23696;
		public abstract int getVersion();
		internal static global::MonoJavaBridge.MethodId _getSerialNumber23697;
		public abstract global::java.math.BigInteger getSerialNumber();
		internal static global::MonoJavaBridge.MethodId _getIssuerDN23698;
		public abstract global::java.security.Principal getIssuerDN();
		internal static global::MonoJavaBridge.MethodId _checkValidity23699;
		public abstract void checkValidity();
		internal static global::MonoJavaBridge.MethodId _checkValidity23700;
		public abstract void checkValidity(java.util.Date arg0);
		internal static global::MonoJavaBridge.MethodId _getSubjectDN23701;
		public abstract global::java.security.Principal getSubjectDN();
		internal static global::MonoJavaBridge.MethodId _getNotBefore23702;
		public abstract global::java.util.Date getNotBefore();
		internal static global::MonoJavaBridge.MethodId _getNotAfter23703;
		public abstract global::java.util.Date getNotAfter();
		internal static global::MonoJavaBridge.MethodId _getSigAlgName23704;
		public abstract global::java.lang.String getSigAlgName();
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID23705;
		public abstract global::java.lang.String getSigAlgOID();
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams23706;
		public abstract byte[] getSigAlgParams();
		internal static global::MonoJavaBridge.MethodId _X509Certificate23707;
		public X509Certificate()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._X509Certificate23707);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.X509Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/X509Certificate"));
			global::javax.security.cert.X509Certificate._getInstance23694 = @__env.GetStaticMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getInstance", "([B)Ljavax/security/cert/X509Certificate;");
			global::javax.security.cert.X509Certificate._getInstance23695 = @__env.GetStaticMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getInstance", "(Ljava/io/InputStream;)Ljavax/security/cert/X509Certificate;");
			global::javax.security.cert.X509Certificate._getVersion23696 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getVersion", "()I");
			global::javax.security.cert.X509Certificate._getSerialNumber23697 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::javax.security.cert.X509Certificate._getIssuerDN23698 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::javax.security.cert.X509Certificate._checkValidity23699 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "checkValidity", "()V");
			global::javax.security.cert.X509Certificate._checkValidity23700 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::javax.security.cert.X509Certificate._getSubjectDN23701 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::javax.security.cert.X509Certificate._getNotBefore23702 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::javax.security.cert.X509Certificate._getNotAfter23703 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::javax.security.cert.X509Certificate._getSigAlgName23704 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate._getSigAlgOID23705 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate._getSigAlgParams23706 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getSigAlgParams", "()[B");
			global::javax.security.cert.X509Certificate._X509Certificate23707 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.security.cert.X509Certificate))]
	public sealed partial class X509Certificate_ : javax.security.cert.X509Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509Certificate_()
		{
			InitJNI();
		}
		internal X509Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getVersion23708;
		public override int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getVersion23708);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getVersion23708);
		}
		internal static global::MonoJavaBridge.MethodId _getSerialNumber23709;
		public override global::java.math.BigInteger getSerialNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getSerialNumber23709)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getSerialNumber23709)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerDN23710;
		public override global::java.security.Principal getIssuerDN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getIssuerDN23710)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getIssuerDN23710)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity23711;
		public override void checkValidity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._checkValidity23711);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._checkValidity23711);
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity23712;
		public override void checkValidity(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._checkValidity23712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._checkValidity23712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectDN23713;
		public override global::java.security.Principal getSubjectDN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getSubjectDN23713)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getSubjectDN23713)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getNotBefore23714;
		public override global::java.util.Date getNotBefore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getNotBefore23714)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getNotBefore23714)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getNotAfter23715;
		public override global::java.util.Date getNotAfter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getNotAfter23715)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getNotAfter23715)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName23716;
		public override global::java.lang.String getSigAlgName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getSigAlgName23716)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getSigAlgName23716)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID23717;
		public override global::java.lang.String getSigAlgOID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getSigAlgOID23717)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getSigAlgOID23717)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams23718;
		public override byte[] getSigAlgParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getSigAlgParams23718)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getSigAlgParams23718)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _toString23719;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._toString23719)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._toString23719)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23720;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getEncoded23720)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getEncoded23720)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify23721;
		public override void verify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._verify23721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._verify23721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify23722;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._verify23722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._verify23722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey23723;
		public override global::java.security.PublicKey getPublicKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getPublicKey23723)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getPublicKey23723)) as java.security.PublicKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.X509Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/X509Certificate"));
			global::javax.security.cert.X509Certificate_._getVersion23708 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getVersion", "()I");
			global::javax.security.cert.X509Certificate_._getSerialNumber23709 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::javax.security.cert.X509Certificate_._getIssuerDN23710 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::javax.security.cert.X509Certificate_._checkValidity23711 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "checkValidity", "()V");
			global::javax.security.cert.X509Certificate_._checkValidity23712 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::javax.security.cert.X509Certificate_._getSubjectDN23713 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::javax.security.cert.X509Certificate_._getNotBefore23714 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::javax.security.cert.X509Certificate_._getNotAfter23715 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::javax.security.cert.X509Certificate_._getSigAlgName23716 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate_._getSigAlgOID23717 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate_._getSigAlgParams23718 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getSigAlgParams", "()[B");
			global::javax.security.cert.X509Certificate_._toString23719 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate_._getEncoded23720 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getEncoded", "()[B");
			global::javax.security.cert.X509Certificate_._verify23721 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::javax.security.cert.X509Certificate_._verify23722 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::javax.security.cert.X509Certificate_._getPublicKey23723 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
		}
	}
}
