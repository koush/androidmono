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
		internal static global::MonoJavaBridge.MethodId _getW23920;
		global::java.security.spec.ECPoint java.security.interfaces.ECPublicKey.getW()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_._getW23920)) as java.security.spec.ECPoint;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23921;
		byte[] java.security.Key.getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_._getEncoded23921)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23922;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_._getAlgorithm23922)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23923;
		global::java.lang.String java.security.Key.getFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_._getFormat23923)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParams23924;
		global::java.security.spec.ECParameterSpec java.security.interfaces.ECKey.getParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPublicKey_._getParams23924)) as java.security.spec.ECParameterSpec;
		}
		static ECPublicKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.ECPublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/ECPublicKey"));
			global::java.security.interfaces.ECPublicKey_._getW23920 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPublicKey_.staticClass, "getW", "()Ljava/security/spec/ECPoint;");
			global::java.security.interfaces.ECPublicKey_._getEncoded23921 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPublicKey_.staticClass, "getEncoded", "()[B");
			global::java.security.interfaces.ECPublicKey_._getAlgorithm23922 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.interfaces.ECPublicKey_._getFormat23923 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPublicKey_.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.interfaces.ECPublicKey_._getParams23924 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPublicKey_.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;");
		}
		internal static void InitJNI()
		{
		}
	}
}
