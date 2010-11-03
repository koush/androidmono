namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.ECPublicKey_))]
	public partial interface ECPublicKey : PublicKey, ECKey
	{
		global::java.security.spec.ECPoint getW();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.ECPublicKey))]
	internal sealed partial class ECPublicKey_ : java.lang.Object, ECPublicKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ECPublicKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.security.spec.ECPoint java.security.interfaces.ECPublicKey.getW()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.ECPublicKey_.staticClass, "getW", "()Ljava/security/spec/ECPoint;", ref global::java.security.interfaces.ECPublicKey_._m0) as java.security.spec.ECPoint;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.interfaces.ECPublicKey_.staticClass, "getEncoded", "()[B", ref global::java.security.interfaces.ECPublicKey_._m1) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.ECPublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.interfaces.ECPublicKey_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.interfaces.ECPublicKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.interfaces.ECPublicKey_._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.security.spec.ECParameterSpec java.security.interfaces.ECKey.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.ECPublicKey_.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;", ref global::java.security.interfaces.ECPublicKey_._m4) as java.security.spec.ECParameterSpec;
		}
		static ECPublicKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.ECPublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/ECPublicKey"));
		}
	}
}
