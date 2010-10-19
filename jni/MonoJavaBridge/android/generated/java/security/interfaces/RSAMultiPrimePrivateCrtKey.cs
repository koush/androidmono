namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_))]
	public interface RSAMultiPrimePrivateCrtKey : RSAPrivateKey
	{
		global::java.math.BigInteger getPublicExponent();
		global::java.math.BigInteger getPrimeP();
		global::java.math.BigInteger getPrimeQ();
		global::java.math.BigInteger getPrimeExponentP();
		global::java.math.BigInteger getPrimeExponentQ();
		global::java.math.BigInteger getCrtCoefficient();
		global::java.security.spec.RSAOtherPrimeInfo[] getOtherPrimeInfo();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey))]
	public sealed partial class RSAMultiPrimePrivateCrtKey_ : java.lang.Object, RSAMultiPrimePrivateCrtKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RSAMultiPrimePrivateCrtKey_()
		{
			InitJNI();
		}
		internal RSAMultiPrimePrivateCrtKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPublicExponent18203;
		 global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getPublicExponent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPublicExponent18203)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPublicExponent18203)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeP18204;
		 global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getPrimeP() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeP18204)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeP18204)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeQ18205;
		 global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getPrimeQ() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeQ18205)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeQ18205)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentP18206;
		 global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getPrimeExponentP() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeExponentP18206)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeExponentP18206)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentQ18207;
		 global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getPrimeExponentQ() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeExponentQ18207)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeExponentQ18207)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getCrtCoefficient18208;
		 global::java.math.BigInteger java.security.interfaces.RSAMultiPrimePrivateCrtKey.getCrtCoefficient() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getCrtCoefficient18208)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getCrtCoefficient18208)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getOtherPrimeInfo18209;
		 global::java.security.spec.RSAOtherPrimeInfo[] java.security.interfaces.RSAMultiPrimePrivateCrtKey.getOtherPrimeInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.spec.RSAOtherPrimeInfo>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getOtherPrimeInfo18209)) as java.security.spec.RSAOtherPrimeInfo[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.spec.RSAOtherPrimeInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getOtherPrimeInfo18209)) as java.security.spec.RSAOtherPrimeInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateExponent18210;
		 global::java.math.BigInteger java.security.interfaces.RSAPrivateKey.getPrivateExponent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrivateExponent18210)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrivateExponent18210)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded18211;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getEncoded18211)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getEncoded18211)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm18212;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getAlgorithm18212)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getAlgorithm18212)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat18213;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getFormat18213)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getFormat18213)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getModulus18214;
		 global::java.math.BigInteger java.security.interfaces.RSAKey.getModulus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getModulus18214)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getModulus18214)) as java.math.BigInteger;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/RSAMultiPrimePrivateCrtKey"));
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPublicExponent18203 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeP18204 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPrimeP", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeQ18205 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPrimeQ", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeExponentP18206 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPrimeExponentP", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrimeExponentQ18207 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPrimeExponentQ", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getCrtCoefficient18208 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getCrtCoefficient", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getOtherPrimeInfo18209 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getOtherPrimeInfo", "()[Ljava/security/spec/RSAOtherPrimeInfo;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getPrivateExponent18210 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getPrivateExponent", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getEncoded18211 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getEncoded", "()[B");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getAlgorithm18212 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getFormat18213 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_._getModulus18214 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAMultiPrimePrivateCrtKey_.staticClass, "getModulus", "()Ljava/math/BigInteger;");
		}
	}
}
