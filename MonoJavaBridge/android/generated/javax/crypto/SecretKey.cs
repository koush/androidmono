namespace javax.crypto
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.crypto.SecretKey_))]
	public partial interface SecretKey : java.security.Key
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.SecretKey))]
	internal sealed partial class SecretKey_ : java.lang.Object, SecretKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SecretKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded28714;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.SecretKey_.staticClass, "getEncoded", "()[B", ref global::javax.crypto.SecretKey_._getEncoded28714) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28715;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.SecretKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.SecretKey_._getAlgorithm28715) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat28716;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.SecretKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::javax.crypto.SecretKey_._getFormat28716) as java.lang.String;
		}
		static SecretKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.SecretKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/SecretKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
