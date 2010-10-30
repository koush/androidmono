namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.RSAPrivateCrtKey_))]
	public partial interface RSAPrivateCrtKey : RSAPrivateKey
	{
		global::java.math.BigInteger getPublicExponent();
		global::java.math.BigInteger getPrimeP();
		global::java.math.BigInteger getPrimeQ();
		global::java.math.BigInteger getPrimeExponentP();
		global::java.math.BigInteger getPrimeExponentQ();
		global::java.math.BigInteger getCrtCoefficient();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.RSAPrivateCrtKey))]
	internal sealed partial class RSAPrivateCrtKey_ : java.lang.Object, RSAPrivateCrtKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RSAPrivateCrtKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPublicExponent23940;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPublicExponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._getPublicExponent23940) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeP23941;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeP()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeP", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeP23941) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeQ23942;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeQ()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeQ", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeQ23942) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentP23943;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeExponentP()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeExponentP", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeExponentP23943) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentQ23944;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeExponentQ()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeExponentQ", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeExponentQ23944) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getCrtCoefficient23945;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getCrtCoefficient()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getCrtCoefficient", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._getCrtCoefficient23945) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateExponent23946;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateKey.getPrivateExponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrivateExponent", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._getPrivateExponent23946) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23947;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getEncoded", "()[B", ref global::java.security.interfaces.RSAPrivateCrtKey_._getEncoded23947) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23948;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.interfaces.RSAPrivateCrtKey_._getAlgorithm23948) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23949;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.interfaces.RSAPrivateCrtKey_._getFormat23949) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getModulus23950;
		global::java.math.BigInteger java.security.interfaces.RSAKey.getModulus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getModulus", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._getModulus23950) as java.math.BigInteger;
		}
		static RSAPrivateCrtKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.RSAPrivateCrtKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/RSAPrivateCrtKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
