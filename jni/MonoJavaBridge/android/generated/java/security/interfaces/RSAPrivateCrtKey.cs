namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.RSAPrivateCrtKey_))]
	public interface RSAPrivateCrtKey : RSAPrivateKey
	{
		global::java.math.BigInteger getPublicExponent();
		global::java.math.BigInteger getPrimeP();
		global::java.math.BigInteger getPrimeQ();
		global::java.math.BigInteger getPrimeExponentP();
		global::java.math.BigInteger getPrimeExponentQ();
		global::java.math.BigInteger getCrtCoefficient();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.RSAPrivateCrtKey))]
	public sealed partial class RSAPrivateCrtKey_ : java.lang.Object, RSAPrivateCrtKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RSAPrivateCrtKey_()
		{
			InitJNI();
		}
		internal RSAPrivateCrtKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPublicExponent18215;
		 global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPublicExponent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getPublicExponent18215)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getPublicExponent18215)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeP18216;
		 global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeP() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeP18216)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeP18216)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeQ18217;
		 global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeQ() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeQ18217)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeQ18217)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentP18218;
		 global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeExponentP() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeExponentP18218)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeExponentP18218)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentQ18219;
		 global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getPrimeExponentQ() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeExponentQ18219)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeExponentQ18219)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getCrtCoefficient18220;
		 global::java.math.BigInteger java.security.interfaces.RSAPrivateCrtKey.getCrtCoefficient() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getCrtCoefficient18220)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getCrtCoefficient18220)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateExponent18221;
		 global::java.math.BigInteger java.security.interfaces.RSAPrivateKey.getPrivateExponent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getPrivateExponent18221)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getPrivateExponent18221)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded18222;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getEncoded18222)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getEncoded18222)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm18223;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getAlgorithm18223)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getAlgorithm18223)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat18224;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getFormat18224)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getFormat18224)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getModulus18225;
		 global::java.math.BigInteger java.security.interfaces.RSAKey.getModulus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_._getModulus18225)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, global::java.security.interfaces.RSAPrivateCrtKey_._getModulus18225)) as java.math.BigInteger;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.RSAPrivateCrtKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/RSAPrivateCrtKey"));
			global::java.security.interfaces.RSAPrivateCrtKey_._getPublicExponent18215 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeP18216 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeP", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeQ18217 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeQ", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeExponentP18218 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeExponentP", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getPrimeExponentQ18219 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrimeExponentQ", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getCrtCoefficient18220 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getCrtCoefficient", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getPrivateExponent18221 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getPrivateExponent", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getEncoded18222 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getEncoded", "()[B");
			global::java.security.interfaces.RSAPrivateCrtKey_._getAlgorithm18223 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getFormat18224 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.interfaces.RSAPrivateCrtKey_._getModulus18225 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateCrtKey_.staticClass, "getModulus", "()Ljava/math/BigInteger;");
		}
	}
}
