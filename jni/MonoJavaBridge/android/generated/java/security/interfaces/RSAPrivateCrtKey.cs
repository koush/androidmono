namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.RSAPrivateCrtKey_))]
	public partial interface RSAPrivateCrtKey : RSAPrivateKey
	{
		global::java.math.BigInteger getPublicExponent();
		global::java.math.BigInteger getPrimeP();
		global::java.math.BigInteger getPrimeQ();
		global::java.math.BigInteger getPrimeExponentP();
		global::java.math.BigInteger getPrimeExponentQ();
		global::java.math.BigInteger getCrtCoefficient();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.RSAPrivateCrtKey))]
	internal sealed partial class RSAPrivateCrtKey_ : java.lang.Object, RSAPrivateCrtKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RSAPrivateCrtKey_()
		{
			InitJNI();
		}
		internal RSAPrivateCrtKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPublicExponent23939;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPublicExponent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getPublicExponent23939)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getPublicExponent23939)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeP23940;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeP()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeP23940)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeP23940)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeQ23941;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeQ()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeQ23941)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeQ23941)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentP23942;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeExponentP()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeExponentP23942)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeExponentP23942)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentQ23943;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeExponentQ()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeExponentQ23943)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeExponentQ23943)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getCrtCoefficient23944;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getCrtCoefficient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getCrtCoefficient23944)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getCrtCoefficient23944)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateExponent23945;
		global::java.math.BigInteger java.security.interfaces.RSAPrivateKey.getPrivateExponent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getPrivateExponent23945)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getPrivateExponent23945)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23946;
		byte[] java.security.Key.getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getEncoded23946)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getEncoded23946)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23947;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getAlgorithm23947)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getAlgorithm23947)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23948;
		global::java.lang.String java.security.Key.getFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getFormat23948)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getFormat23948)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getModulus23949;
		global::java.math.BigInteger java.security.interfaces.RSAKey.getModulus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getModulus23949)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getModulus23949)) as java.math.BigInteger;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.RSAPrivateCrtKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/RSAPrivateCrtKey"));
			global::java.security.interfaces.RSAPrivateCrtKey_._getPublicExponent23939 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeP23940 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeP", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeQ23941 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeQ", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeExponentP23942 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeExponentP", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeExponentQ23943 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeExponentQ", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getCrtCoefficient23944 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getCrtCoefficient", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getPrivateExponent23945 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrivateExponent", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getEncoded23946 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getEncoded", "()[B");
			global::java.security.interfaces.RSAPrivateCrtKey_._getAlgorithm23947 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getFormat23948 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getModulus23949 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getModulus", "()Ljava/math/BigInteger;");
		}
	}
}
