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
		static ECPrivateKey_()
		{
			InitJNI();
		}
		internal ECPrivateKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getS23913;
		global::java.math.BigInteger java.security.interfaces.ECPrivateKey.getS()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_._getS23913)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_.staticClass, global::java.security.interfaces.ECPrivateKey_._getS23913)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23914;
		byte[] java.security.Key.getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_._getEncoded23914)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_.staticClass, global::java.security.interfaces.ECPrivateKey_._getEncoded23914)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23915;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_._getAlgorithm23915)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_.staticClass, global::java.security.interfaces.ECPrivateKey_._getAlgorithm23915)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23916;
		global::java.lang.String java.security.Key.getFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_._getFormat23916)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_.staticClass, global::java.security.interfaces.ECPrivateKey_._getFormat23916)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParams23917;
		global::java.security.spec.ECParameterSpec java.security.interfaces.ECKey.getParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_._getParams23917)) as java.security.spec.ECParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_.staticClass, global::java.security.interfaces.ECPrivateKey_._getParams23917)) as java.security.spec.ECParameterSpec;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.ECPrivateKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/ECPrivateKey"));
			global::java.security.interfaces.ECPrivateKey_._getS23913 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPrivateKey_.staticClass, "getS", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.ECPrivateKey_._getEncoded23914 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPrivateKey_.staticClass, "getEncoded", "()[B");
			global::java.security.interfaces.ECPrivateKey_._getAlgorithm23915 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.interfaces.ECPrivateKey_._getFormat23916 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.interfaces.ECPrivateKey_._getParams23917 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPrivateKey_.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;");
		}
	}
}
