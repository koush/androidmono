namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.DSAPublicKey_))]
	public partial interface DSAPublicKey : DSAKey, PublicKey
	{
		global::java.math.BigInteger getY();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.DSAPublicKey))]
	internal sealed partial class DSAPublicKey_ : java.lang.Object, DSAPublicKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DSAPublicKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getY23907;
		global::java.math.BigInteger java.security.interfaces.DSAPublicKey.getY()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.DSAPublicKey_.staticClass, "getY", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.DSAPublicKey_._getY23907) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getParams23908;
		global::java.security.interfaces.DSAParams java.security.interfaces.DSAKey.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.interfaces.DSAParams>(this, global::java.security.interfaces.DSAPublicKey_.staticClass, "getParams", "()Ljava/security/interfaces/DSAParams;", ref global::java.security.interfaces.DSAPublicKey_._getParams23908) as java.security.interfaces.DSAParams;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23909;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.interfaces.DSAPublicKey_.staticClass, "getEncoded", "()[B", ref global::java.security.interfaces.DSAPublicKey_._getEncoded23909) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23910;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.DSAPublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.interfaces.DSAPublicKey_._getAlgorithm23910) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23911;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.DSAPublicKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.interfaces.DSAPublicKey_._getFormat23911) as java.lang.String;
		}
		static DSAPublicKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.DSAPublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/DSAPublicKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
