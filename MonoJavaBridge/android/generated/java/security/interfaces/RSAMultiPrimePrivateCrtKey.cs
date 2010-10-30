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
		internal RSAMultiPrimePrivateCrtKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPublicExponent23927;
		global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getPublicExponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPublicExponent23927) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeP23928;
		global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getPrimeP()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPrimeP", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeP23928) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeQ23929;
		global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getPrimeQ()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPrimeQ", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeQ23929) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentP23930;
		global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getPrimeExponentP()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPrimeExponentP", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeExponentP23930) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentQ23931;
		global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getPrimeExponentQ()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPrimeExponentQ", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeExponentQ23931) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getCrtCoefficient23932;
		global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getCrtCoefficient()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getCrtCoefficient", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getCrtCoefficient23932) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getOtherPrimeInfo23933;
		global::java.security.spec.RSAOtherPrimeInfo[] java.security.interfaces.RSAMultiPrimePrivateCrtKey.getOtherPrimeInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.spec.RSAOtherPrimeInfo>(this, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getOtherPrimeInfo", "()[Ljava/security/spec/RSAOtherPrimeInfo;", ref global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getOtherPrimeInfo23933) as java.security.spec.RSAOtherPrimeInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateExponent23934;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateKey.getPrivateExponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPrivateExponent", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrivateExponent23934) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23935;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getEncoded", "()[B", ref global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getEncoded23935) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23936;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getAlgorithm23936) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23937;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getFormat23937) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getModulus23938;
		global::java.math.BigInteger java.security.interfaces.RSAKey.getModulus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getModulus", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getModulus23938) as java.math.BigInteger;
		}
		static RSAMultiPrimePrivateCrtKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/RSAMultiPrimePrivateCrtKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
