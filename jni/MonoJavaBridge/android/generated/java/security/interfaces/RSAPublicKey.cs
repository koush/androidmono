namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.RSAPublicKey_))]
	public partial interface RSAPublicKey : PublicKey, RSAKey
	{
		global::java.math.BigInteger getPublicExponent();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.RSAPublicKey))]
	internal sealed partial class RSAPublicKey_ : java.lang.Object, RSAPublicKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RSAPublicKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPublicExponent23958;
		global::java.math.BigInteger java.security.interfaces.RSAPublicKey.getPublicExponent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_._getPublicExponent23958)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_.staticClass, global::java.security.interfaces.RSAPublicKey_._getPublicExponent23958)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23959;
		byte[] java.security.Key.getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_._getEncoded23959)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_.staticClass, global::java.security.interfaces.RSAPublicKey_._getEncoded23959)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23960;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_._getAlgorithm23960)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_.staticClass, global::java.security.interfaces.RSAPublicKey_._getAlgorithm23960)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23961;
		global::java.lang.String java.security.Key.getFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_._getFormat23961)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_.staticClass, global::java.security.interfaces.RSAPublicKey_._getFormat23961)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getModulus23962;
		global::java.math.BigInteger java.security.interfaces.RSAKey.getModulus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_._getModulus23962)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_.staticClass, global::java.security.interfaces.RSAPublicKey_._getModulus23962)) as java.math.BigInteger;
		}
		static RSAPublicKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.RSAPublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/RSAPublicKey"));
			global::java.security.interfaces.RSAPublicKey_._getPublicExponent23958 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPublicKey_.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPublicKey_._getEncoded23959 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPublicKey_.staticClass, "getEncoded", "()[B");
			global::java.security.interfaces.RSAPublicKey_._getAlgorithm23960 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.interfaces.RSAPublicKey_._getFormat23961 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPublicKey_.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.interfaces.RSAPublicKey_._getModulus23962 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPublicKey_.staticClass, "getModulus", "()Ljava/math/BigInteger;");
		}
		internal static void InitJNI()
		{
		}
	}
}
