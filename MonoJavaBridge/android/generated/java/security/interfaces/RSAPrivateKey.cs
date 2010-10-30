namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.RSAPrivateKey_))]
	public partial interface RSAPrivateKey : PrivateKey, RSAKey
	{
		global::java.math.BigInteger getPrivateExponent();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.RSAPrivateKey))]
	internal sealed partial class RSAPrivateKey_ : java.lang.Object, RSAPrivateKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RSAPrivateKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateExponent23952;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateKey.getPrivateExponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateKey_.staticClass, "getPrivateExponent", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateKey_._getPrivateExponent23952) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23953;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.interfaces.RSAPrivateKey_.staticClass, "getEncoded", "()[B", ref global::java.security.interfaces.RSAPrivateKey_._getEncoded23953) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23954;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.RSAPrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.interfaces.RSAPrivateKey_._getAlgorithm23954) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23955;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.RSAPrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.interfaces.RSAPrivateKey_._getFormat23955) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getModulus23956;
		global::java.math.BigInteger java.security.interfaces.RSAKey.getModulus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPrivateKey_.staticClass, "getModulus", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPrivateKey_._getModulus23956) as java.math.BigInteger;
		}
		static RSAPrivateKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.RSAPrivateKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/RSAPrivateKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
