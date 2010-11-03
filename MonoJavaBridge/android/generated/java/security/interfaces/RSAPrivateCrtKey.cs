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
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPublicExponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._m0) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeP()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeP", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._m1) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeQ()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeQ", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._m2) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeExponentP()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeExponentP", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._m3) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeExponentQ()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeExponentQ", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._m4) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getCrtCoefficient()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getCrtCoefficient", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._m5) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateKey.getPrivateExponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrivateExponent", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._m6) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getEncoded", "()[B", ref global::java.security.interfaces.RSAPrivateCrtKey_._m7) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.interfaces.RSAPrivateCrtKey_._m8) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.interfaces.RSAPrivateCrtKey_._m9) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.math.BigInteger java.security.interfaces.RSAKey.getModulus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getModulus", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateCrtKey_._m10) as java.math.BigInteger;
		}
		static RSAPrivateCrtKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.RSAPrivateCrtKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/RSAPrivateCrtKey"));
		}
	}
}
