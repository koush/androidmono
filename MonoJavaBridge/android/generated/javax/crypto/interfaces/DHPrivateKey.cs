namespace javax.crypto.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.crypto.interfaces.DHPrivateKey_))]
	public partial interface DHPrivateKey : DHKey, java.security.PrivateKey
	{
		global::java.math.BigInteger getX();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.interfaces.DHPrivateKey))]
	internal sealed partial class DHPrivateKey_ : java.lang.Object, DHPrivateKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DHPrivateKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.math.BigInteger javax.crypto.interfaces.DHPrivateKey.getX()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.interfaces.DHPrivateKey_.staticClass, "getX", "()Ljava/math/BigInteger;", ref global::javax.crypto.interfaces.DHPrivateKey_._m0) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::javax.crypto.spec.DHParameterSpec javax.crypto.interfaces.DHKey.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.interfaces.DHPrivateKey_.staticClass, "getParams", "()Ljavax/crypto/spec/DHParameterSpec;", ref global::javax.crypto.interfaces.DHPrivateKey_._m1) as javax.crypto.spec.DHParameterSpec;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.interfaces.DHPrivateKey_.staticClass, "getEncoded", "()[B", ref global::javax.crypto.interfaces.DHPrivateKey_._m2) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.interfaces.DHPrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.interfaces.DHPrivateKey_._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.interfaces.DHPrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::javax.crypto.interfaces.DHPrivateKey_._m4) as java.lang.String;
		}
		static DHPrivateKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.interfaces.DHPrivateKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/interfaces/DHPrivateKey"));
		}
	}
}
