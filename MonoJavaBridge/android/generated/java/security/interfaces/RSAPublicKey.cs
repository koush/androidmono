namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.RSAPublicKey_))]
	public partial interface RSAPublicKey : PublicKey, RSAKey
	{
		global::java.math.BigInteger getPublicExponent();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.RSAPublicKey))]
	internal sealed partial class RSAPublicKey_ : java.lang.Object, RSAPublicKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RSAPublicKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPublicExponent23958;
		global::java.math.BigInteger java.security.interfaces.RSAPublicKey.getPublicExponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPublicKey_.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPublicKey_._getPublicExponent23958) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23959;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.interfaces.RSAPublicKey_.staticClass, "getEncoded", "()[B", ref global::java.security.interfaces.RSAPublicKey_._getEncoded23959) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23960;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.RSAPublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.interfaces.RSAPublicKey_._getAlgorithm23960) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23961;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.RSAPublicKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.interfaces.RSAPublicKey_._getFormat23961) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getModulus23962;
		global::java.math.BigInteger java.security.interfaces.RSAKey.getModulus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPublicKey_.staticClass, "getModulus", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPublicKey_._getModulus23962) as java.math.BigInteger;
		}
		static RSAPublicKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.RSAPublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/RSAPublicKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
