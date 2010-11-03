namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.ECPrivateKey_))]
	public partial interface ECPrivateKey : PrivateKey, ECKey
	{
		global::java.math.BigInteger getS();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.ECPrivateKey))]
	internal sealed partial class ECPrivateKey_ : java.lang.Object, ECPrivateKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ECPrivateKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.math.BigInteger java.security.interfaces.ECPrivateKey.getS()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.ECPrivateKey_.staticClass, "getS", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.ECPrivateKey_._m0) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.interfaces.ECPrivateKey_.staticClass, "getEncoded", "()[B", ref global::java.security.interfaces.ECPrivateKey_._m1) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.ECPrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.interfaces.ECPrivateKey_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.ECPrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.interfaces.ECPrivateKey_._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.security.spec.ECParameterSpec java.security.interfaces.ECKey.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.ECPrivateKey_.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;", ref global::java.security.interfaces.ECPrivateKey_._m4) as java.security.spec.ECParameterSpec;
		}
		static ECPrivateKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.ECPrivateKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/ECPrivateKey"));
		}
	}
}
