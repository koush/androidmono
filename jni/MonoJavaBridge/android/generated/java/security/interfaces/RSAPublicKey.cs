namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.RSAPublicKey_))]
	public interface RSAPublicKey : PublicKey, RSAKey
	{
		global::java.math.BigInteger getPublicExponent();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.RSAPublicKey))]
	public sealed partial class RSAPublicKey_ : java.lang.Object, RSAPublicKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RSAPublicKey_()
		{
			InitJNI();
		}
		internal RSAPublicKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPublicExponent23839;
		 global::java.math.BigInteger java.security.interfaces.RSAPublicKey.getPublicExponent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_._getPublicExponent23839)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_.staticClass, global::java.security.interfaces.RSAPublicKey_._getPublicExponent23839)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23840;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_._getEncoded23840)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_.staticClass, global::java.security.interfaces.RSAPublicKey_._getEncoded23840)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23841;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_._getAlgorithm23841)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_.staticClass, global::java.security.interfaces.RSAPublicKey_._getAlgorithm23841)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23842;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_._getFormat23842)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_.staticClass, global::java.security.interfaces.RSAPublicKey_._getFormat23842)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getModulus23843;
		 global::java.math.BigInteger java.security.interfaces.RSAKey.getModulus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_._getModulus23843)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPublicKey_.staticClass, global::java.security.interfaces.RSAPublicKey_._getModulus23843)) as java.math.BigInteger;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.RSAPublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/RSAPublicKey"));
			global::java.security.interfaces.RSAPublicKey_._getPublicExponent23839 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPublicKey_.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPublicKey_._getEncoded23840 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPublicKey_.staticClass, "getEncoded", "()[B");
			global::java.security.interfaces.RSAPublicKey_._getAlgorithm23841 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.interfaces.RSAPublicKey_._getFormat23842 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPublicKey_.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.interfaces.RSAPublicKey_._getModulus23843 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPublicKey_.staticClass, "getModulus", "()Ljava/math/BigInteger;");
		}
	}
}
