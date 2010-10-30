namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.DSAPrivateKey_))]
	public partial interface DSAPrivateKey : DSAKey, PrivateKey
	{
		global::java.math.BigInteger getX();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.DSAPrivateKey))]
	internal sealed partial class DSAPrivateKey_ : java.lang.Object, DSAPrivateKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DSAPrivateKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getX23901;
		global::java.math.BigInteger java.security.interfaces.DSAPrivateKey.getX()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.DSAPrivateKey_.staticClass, "getX", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.DSAPrivateKey_._getX23901) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getParams23902;
		global::java.security.interfaces.DSAParams java.security.interfaces.DSAKey.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.interfaces.DSAParams>(this, global::java.security.interfaces.DSAPrivateKey_.staticClass, "getParams", "()Ljava/security/interfaces/DSAParams;", ref global::java.security.interfaces.DSAPrivateKey_._getParams23902) as java.security.interfaces.DSAParams;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23903;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.interfaces.DSAPrivateKey_.staticClass, "getEncoded", "()[B", ref global::java.security.interfaces.DSAPrivateKey_._getEncoded23903) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23904;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.DSAPrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.interfaces.DSAPrivateKey_._getAlgorithm23904) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23905;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.DSAPrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.interfaces.DSAPrivateKey_._getFormat23905) as java.lang.String;
		}
		static DSAPrivateKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.DSAPrivateKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/DSAPrivateKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
