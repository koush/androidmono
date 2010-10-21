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
		internal static global::MonoJavaBridge.MethodId _getInstance30128;
		public static global::javax.security.cert.X509Certificate getInstance(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._getInstance30128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.security.cert.X509Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance30129;
		public static global::javax.security.cert.X509Certificate getInstance(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._getInstance30129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.security.cert.X509Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion30130;
		public abstract int getVersion();
		internal static global::MonoJavaBridge.MethodId _getSerialNumber30131;
		public abstract global::java.math.BigInteger getSerialNumber();
		internal static global::MonoJavaBridge.MethodId _getIssuerDN30132;
		public abstract global::java.security.Principal getIssuerDN();
		internal static global::MonoJavaBridge.MethodId _checkValidity30133;
		public abstract void checkValidity();
		internal static global::MonoJavaBridge.MethodId _checkValidity30134;
		public abstract void checkValidity(java.util.Date arg0);
		internal static global::MonoJavaBridge.MethodId _getSubjectDN30135;
		public abstract global::java.security.Principal getSubjectDN();
		internal static global::MonoJavaBridge.MethodId _getNotBefore30136;
		public abstract global::java.util.Date getNotBefore();
		internal static global::MonoJavaBridge.MethodId _getNotAfter30137;
		public abstract global::java.util.Date getNotAfter();
		internal static global::MonoJavaBridge.MethodId _getSigAlgName30138;
		public abstract global::java.lang.String getSigAlgName();
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID30139;
		public abstract global::java.lang.String getSigAlgOID();
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams30140;
		public abstract byte[] getSigAlgParams();
		internal static global::MonoJavaBridge.MethodId _X509Certificate30141;
		public X509Certificate()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._X509Certificate30141);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.X509Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/X509Certificate"));
			global::javax.security.cert.X509Certificate._getInstance30128 = @__env.GetStaticMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getInstance", "([B)Ljavax/security/cert/X509Certificate;");
			global::javax.security.cert.X509Certificate._getInstance30129 = @__env.GetStaticMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getInstance", "(Ljava/io/InputStream;)Ljavax/security/cert/X509Certificate;");
			global::javax.security.cert.X509Certificate._getVersion30130 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getVersion", "()I");
			global::javax.security.cert.X509Certificate._getSerialNumber30131 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::javax.security.cert.X509Certificate._getIssuerDN30132 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::javax.security.cert.X509Certificate._checkValidity30133 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "checkValidity", "()V");
			global::javax.security.cert.X509Certificate._checkValidity30134 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::javax.security.cert.X509Certificate._getSubjectDN30135 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::javax.security.cert.X509Certificate._getNotBefore30136 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::javax.security.cert.X509Certificate._getNotAfter30137 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::javax.security.cert.X509Certificate._getSigAlgName30138 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate._getSigAlgOID30139 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate._getSigAlgParams30140 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getSigAlgParams", "()[B");
			global::javax.security.cert.X509Certificate._X509Certificate30141 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _getVersion30142;
		public override int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getVersion30142);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getVersion30142);
		}
		internal static global::MonoJavaBridge.MethodId _getSerialNumber30143;
		public override global::java.math.BigInteger getSerialNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getSerialNumber30143)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getSerialNumber30143)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerDN30144;
		public override global::java.security.Principal getIssuerDN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getIssuerDN30144)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getIssuerDN30144)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity30145;
		public override void checkValidity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._checkValidity30145);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._checkValidity30145);
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity30146;
		public override void checkValidity(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._checkValidity30146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._checkValidity30146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectDN30147;
		public override global::java.security.Principal getSubjectDN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getSubjectDN30147)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getSubjectDN30147)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getNotBefore30148;
		public override global::java.util.Date getNotBefore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getNotBefore30148)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getNotBefore30148)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getNotAfter30149;
		public override global::java.util.Date getNotAfter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getNotAfter30149)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getNotAfter30149)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName30150;
		public override global::java.lang.String getSigAlgName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getSigAlgName30150)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getSigAlgName30150)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID30151;
		public override global::java.lang.String getSigAlgOID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getSigAlgOID30151)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getSigAlgOID30151)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams30152;
		public override byte[] getSigAlgParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getSigAlgParams30152)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getSigAlgParams30152)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _toString30153;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._toString30153)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._toString30153)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded30154;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getEncoded30154)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getEncoded30154)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify30155;
		public override void verify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._verify30155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._verify30155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify30156;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._verify30156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._verify30156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey30157;
		public override global::java.security.PublicKey getPublicKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getPublicKey30157)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getPublicKey30157)) as java.security.PublicKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.X509Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/X509Certificate"));
			global::javax.security.cert.X509Certificate_._getVersion30142 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getVersion", "()I");
			global::javax.security.cert.X509Certificate_._getSerialNumber30143 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::javax.security.cert.X509Certificate_._getIssuerDN30144 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::javax.security.cert.X509Certificate_._checkValidity30145 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "checkValidity", "()V");
			global::javax.security.cert.X509Certificate_._checkValidity30146 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::javax.security.cert.X509Certificate_._getSubjectDN30147 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::javax.security.cert.X509Certificate_._getNotBefore30148 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::javax.security.cert.X509Certificate_._getNotAfter30149 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::javax.security.cert.X509Certificate_._getSigAlgName30150 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate_._getSigAlgOID30151 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate_._getSigAlgParams30152 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getSigAlgParams", "()[B");
			global::javax.security.cert.X509Certificate_._toString30153 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate_._getEncoded30154 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getEncoded", "()[B");
			global::javax.security.cert.X509Certificate_._verify30155 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::javax.security.cert.X509Certificate_._verify30156 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::javax.security.cert.X509Certificate_._getPublicKey30157 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
		}
	}
}
