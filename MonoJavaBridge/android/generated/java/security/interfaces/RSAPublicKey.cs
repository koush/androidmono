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
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.math.BigInteger java.security.interfaces.RSAPublicKey.getPublicExponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPublicKey_.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPublicKey_._m0) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.interfaces.RSAPublicKey_.staticClass, "getEncoded", "()[B", ref global::java.security.interfaces.RSAPublicKey_._m1) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.RSAPublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.interfaces.RSAPublicKey_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.RSAPublicKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.interfaces.RSAPublicKey_._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.math.BigInteger java.security.interfaces.RSAKey.getModulus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAPublicKey_.staticClass, "getModulus", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAPublicKey_._m4) as java.math.BigInteger;
		}
		static RSAPublicKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.RSAPublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/RSAPublicKey"));
		}
	}
}
