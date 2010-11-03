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
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.math.BigInteger java.security.interfaces.DSAPrivateKey.getX()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.DSAPrivateKey_.staticClass, "getX", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.DSAPrivateKey_._m0) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.security.interfaces.DSAParams java.security.interfaces.DSAKey.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.interfaces.DSAParams>(this, global::java.security.interfaces.DSAPrivateKey_.staticClass, "getParams", "()Ljava/security/interfaces/DSAParams;", ref global::java.security.interfaces.DSAPrivateKey_._m1) as java.security.interfaces.DSAParams;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.interfaces.DSAPrivateKey_.staticClass, "getEncoded", "()[B", ref global::java.security.interfaces.DSAPrivateKey_._m2) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.DSAPrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.interfaces.DSAPrivateKey_._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.DSAPrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.interfaces.DSAPrivateKey_._m4) as java.lang.String;
		}
		static DSAPrivateKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.DSAPrivateKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/DSAPrivateKey"));
		}
	}
}
