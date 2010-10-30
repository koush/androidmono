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
		internal static global::MonoJavaBridge.MethodId _getX28737;
		global::java.math.BigInteger javax.crypto.interfaces.DHPrivateKey.getX()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPrivateKey_._getX28737)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getParams28738;
		global::javax.crypto.spec.DHParameterSpec javax.crypto.interfaces.DHKey.getParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPrivateKey_._getParams28738)) as javax.crypto.spec.DHParameterSpec;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded28739;
		byte[] java.security.Key.getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPrivateKey_._getEncoded28739)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28740;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPrivateKey_._getAlgorithm28740)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat28741;
		global::java.lang.String java.security.Key.getFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPrivateKey_._getFormat28741)) as java.lang.String;
		}
		static DHPrivateKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.interfaces.DHPrivateKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/interfaces/DHPrivateKey"));
			global::javax.crypto.interfaces.DHPrivateKey_._getX28737 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHPrivateKey_.staticClass, "getX", "()Ljava/math/BigInteger;");
			global::javax.crypto.interfaces.DHPrivateKey_._getParams28738 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHPrivateKey_.staticClass, "getParams", "()Ljavax/crypto/spec/DHParameterSpec;");
			global::javax.crypto.interfaces.DHPrivateKey_._getEncoded28739 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHPrivateKey_.staticClass, "getEncoded", "()[B");
			global::javax.crypto.interfaces.DHPrivateKey_._getAlgorithm28740 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHPrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.interfaces.DHPrivateKey_._getFormat28741 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHPrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
