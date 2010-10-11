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
		internal static global::MonoJavaBridge.MethodId _getInstance16076;
		public static global::javax.security.cert.X509Certificate getInstance(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._getInstance16076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.security.cert.X509Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance16077;
		public static global::javax.security.cert.X509Certificate getInstance(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._getInstance16077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.security.cert.X509Certificate;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion16078;
		public abstract int getVersion();
		internal static global::MonoJavaBridge.MethodId _getSerialNumber16079;
		public abstract global::java.math.BigInteger getSerialNumber();
		internal static global::MonoJavaBridge.MethodId _getIssuerDN16080;
		public abstract global::java.security.Principal getIssuerDN();
		internal static global::MonoJavaBridge.MethodId _checkValidity16081;
		public abstract void checkValidity();
		internal static global::MonoJavaBridge.MethodId _checkValidity16082;
		public abstract void checkValidity(java.util.Date arg0);
		internal static global::MonoJavaBridge.MethodId _getSubjectDN16083;
		public abstract global::java.security.Principal getSubjectDN();
		internal static global::MonoJavaBridge.MethodId _getNotBefore16084;
		public abstract global::java.util.Date getNotBefore();
		internal static global::MonoJavaBridge.MethodId _getNotAfter16085;
		public abstract global::java.util.Date getNotAfter();
		internal static global::MonoJavaBridge.MethodId _getSigAlgName16086;
		public abstract global::java.lang.String getSigAlgName();
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID16087;
		public abstract global::java.lang.String getSigAlgOID();
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams16088;
		public abstract byte[] getSigAlgParams();
		internal static global::MonoJavaBridge.MethodId _X509Certificate16089;
		public X509Certificate()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.X509Certificate.staticClass, global::javax.security.cert.X509Certificate._X509Certificate16089);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.X509Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/X509Certificate"));
			global::javax.security.cert.X509Certificate._getInstance16076 = @__env.GetStaticMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getInstance", "([B)Ljavax/security/cert/X509Certificate;");
			global::javax.security.cert.X509Certificate._getInstance16077 = @__env.GetStaticMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getInstance", "(Ljava/io/InputStream;)Ljavax/security/cert/X509Certificate;");
			global::javax.security.cert.X509Certificate._getVersion16078 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getVersion", "()I");
			global::javax.security.cert.X509Certificate._getSerialNumber16079 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::javax.security.cert.X509Certificate._getIssuerDN16080 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::javax.security.cert.X509Certificate._checkValidity16081 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "checkValidity", "()V");
			global::javax.security.cert.X509Certificate._checkValidity16082 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::javax.security.cert.X509Certificate._getSubjectDN16083 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::javax.security.cert.X509Certificate._getNotBefore16084 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::javax.security.cert.X509Certificate._getNotAfter16085 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::javax.security.cert.X509Certificate._getSigAlgName16086 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate._getSigAlgOID16087 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate._getSigAlgParams16088 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "getSigAlgParams", "()[B");
			global::javax.security.cert.X509Certificate._X509Certificate16089 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _getVersion16090;
		public override int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getVersion16090);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getVersion16090);
		}
		internal static global::MonoJavaBridge.MethodId _getSerialNumber16091;
		public override global::java.math.BigInteger getSerialNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getSerialNumber16091)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getSerialNumber16091)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getIssuerDN16092;
		public override global::java.security.Principal getIssuerDN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getIssuerDN16092)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getIssuerDN16092)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity16093;
		public override void checkValidity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._checkValidity16093);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._checkValidity16093);
		}
		internal static global::MonoJavaBridge.MethodId _checkValidity16094;
		public override void checkValidity(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._checkValidity16094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._checkValidity16094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSubjectDN16095;
		public override global::java.security.Principal getSubjectDN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getSubjectDN16095)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getSubjectDN16095)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _getNotBefore16096;
		public override global::java.util.Date getNotBefore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getNotBefore16096)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getNotBefore16096)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getNotAfter16097;
		public override global::java.util.Date getNotAfter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getNotAfter16097)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getNotAfter16097)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgName16098;
		public override global::java.lang.String getSigAlgName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getSigAlgName16098)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getSigAlgName16098)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgOID16099;
		public override global::java.lang.String getSigAlgOID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getSigAlgOID16099)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getSigAlgOID16099)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSigAlgParams16100;
		public override byte[] getSigAlgParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getSigAlgParams16100)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getSigAlgParams16100)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _toString16101;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._toString16101)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._toString16101)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded16102;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getEncoded16102)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getEncoded16102)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify16103;
		public override void verify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._verify16103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._verify16103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify16104;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._verify16104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._verify16104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey16105;
		public override global::java.security.PublicKey getPublicKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_._getPublicKey16105)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.X509Certificate_.staticClass, global::javax.security.cert.X509Certificate_._getPublicKey16105)) as java.security.PublicKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.X509Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/X509Certificate"));
			global::javax.security.cert.X509Certificate_._getVersion16090 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getVersion", "()I");
			global::javax.security.cert.X509Certificate_._getSerialNumber16091 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getSerialNumber", "()Ljava/math/BigInteger;");
			global::javax.security.cert.X509Certificate_._getIssuerDN16092 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getIssuerDN", "()Ljava/security/Principal;");
			global::javax.security.cert.X509Certificate_._checkValidity16093 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "checkValidity", "()V");
			global::javax.security.cert.X509Certificate_._checkValidity16094 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "checkValidity", "(Ljava/util/Date;)V");
			global::javax.security.cert.X509Certificate_._getSubjectDN16095 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getSubjectDN", "()Ljava/security/Principal;");
			global::javax.security.cert.X509Certificate_._getNotBefore16096 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getNotBefore", "()Ljava/util/Date;");
			global::javax.security.cert.X509Certificate_._getNotAfter16097 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getNotAfter", "()Ljava/util/Date;");
			global::javax.security.cert.X509Certificate_._getSigAlgName16098 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getSigAlgName", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate_._getSigAlgOID16099 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getSigAlgOID", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate_._getSigAlgParams16100 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getSigAlgParams", "()[B");
			global::javax.security.cert.X509Certificate_._toString16101 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.security.cert.X509Certificate_._getEncoded16102 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getEncoded", "()[B");
			global::javax.security.cert.X509Certificate_._verify16103 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::javax.security.cert.X509Certificate_._verify16104 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::javax.security.cert.X509Certificate_._getPublicKey16105 = @__env.GetMethodIDNoThrow(global::javax.security.cert.X509Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
		}
	}
}
