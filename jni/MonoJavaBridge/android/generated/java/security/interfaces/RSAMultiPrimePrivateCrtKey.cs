namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_))]
	public partial interface RSAMultiPrimePrivateCrtKey : RSAPrivateKey
	{
		global::java.math.BigInteger getPublicExponent();
		global::java.math.BigInteger getPrimeP();
		global::java.math.BigInteger getPrimeQ();
		global::java.math.BigInteger getPrimeExponentP();
		global::java.math.BigInteger getPrimeExponentQ();
		global::java.math.BigInteger getCrtCoefficient();
		global::java.security.spec.RSAOtherPrimeInfo[] getOtherPrimeInfo();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey))]
	internal sealed partial class RSAMultiPrimePrivateCrtKey_ : java.lang.Object, RSAMultiPrimePrivateCrtKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RSAMultiPrimePrivateCrtKey_()
		{
			InitJNI();
		}
		internal RSAMultiPrimePrivateCrtKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPublicExponent23926;
		global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getPublicExponent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPublicExponent23926)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPublicExponent23926)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeP23927;
		global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getPrimeP()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeP23927)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeP23927)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeQ23928;
		global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getPrimeQ()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeQ23928)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeQ23928)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentP23929;
		global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getPrimeExponentP()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeExponentP23929)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeExponentP23929)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentQ23930;
		global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getPrimeExponentQ()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeExponentQ23930)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeExponentQ23930)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getCrtCoefficient23931;
		global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getCrtCoefficient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getCrtCoefficient23931)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getCrtCoefficient23931)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getOtherPrimeInfo23932;
		global::java.security.spec.RSAOtherPrimeInfo[] java.security.interfaces.RSAMultiPrimePrivateCrtKey.getOtherPrimeInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.spec.RSAOtherPrimeInfo>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getOtherPrimeInfo23932)) as java.security.spec.RSAOtherPrimeInfo[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.spec.RSAOtherPrimeInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getOtherPrimeInfo23932)) as java.security.spec.RSAOtherPrimeInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateExponent23933;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateKey.getPrivateExponent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrivateExponent23933)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrivateExponent23933)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23934;
		byte[] java.security.Key.getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getEncoded23934)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getEncoded23934)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23935;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getAlgorithm23935)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getAlgorithm23935)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23936;
		global::java.lang.String java.security.Key.getFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getFormat23936)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getFormat23936)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getModulus23937;
		global::java.math.BigInteger java.security.interfaces.RSAKey.getModulus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getModulus23937)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getModulus23937)) as java.math.BigInteger;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/RSAMultiPrimePrivateCrtKey"));
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPublicExponent23926 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeP23927 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPrimeP", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeQ23928 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPrimeQ", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeExponentP23929 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPrimeExponentP", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeExponentQ23930 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPrimeExponentQ", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getCrtCoefficient23931 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getCrtCoefficient", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getOtherPrimeInfo23932 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getOtherPrimeInfo", "()[Ljava/security/spec/RSAOtherPrimeInfo;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrivateExponent23933 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPrivateExponent", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getEncoded23934 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getEncoded", "()[B");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getAlgorithm23935 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getFormat23936 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getModulus23937 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getModulus", "()Ljava/math/BigInteger;");
		}
	}
}
