namespace javax.crypto.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.crypto.interfaces.DHPublicKey_))]
	public partial interface DHPublicKey : DHKey, java.security.PublicKey
	{
		global::java.math.BigInteger getY();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.interfaces.DHPublicKey))]
	internal sealed partial class DHPublicKey_ : java.lang.Object, DHPublicKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DHPublicKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getY28743;
		global::java.math.BigInteger javax.crypto.interfaces.DHPublicKey.getY()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.interfaces.DHPublicKey_.staticClass, "getY", "()Ljava/math/BigInteger;", ref global::javax.crypto.interfaces.DHPublicKey_._getY28743) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getParams28744;
		global::javax.crypto.spec.DHParameterSpec javax.crypto.interfaces.DHKey.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.interfaces.DHPublicKey_.staticClass, "getParams", "()Ljavax/crypto/spec/DHParameterSpec;", ref global::javax.crypto.interfaces.DHPublicKey_._getParams28744) as javax.crypto.spec.DHParameterSpec;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded28745;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.interfaces.DHPublicKey_.staticClass, "getEncoded", "()[B", ref global::javax.crypto.interfaces.DHPublicKey_._getEncoded28745) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28746;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.interfaces.DHPublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.interfaces.DHPublicKey_._getAlgorithm28746) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat28747;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.interfaces.DHPublicKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::javax.crypto.interfaces.DHPublicKey_._getFormat28747) as java.lang.String;
		}
		static DHPublicKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.interfaces.DHPublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/interfaces/DHPublicKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
