namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.RSAPrivateKey_))]
	public partial interface RSAPrivateKey : PrivateKey, RSAKey
	{
		global::java.math.BigInteger getPrivateExponent();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.RSAPrivateKey))]
	public sealed partial class RSAPrivateKey_ : java.lang.Object, RSAPrivateKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RSAPrivateKey_()
		{
			InitJNI();
		}
		internal RSAPrivateKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateExponent23833;
		 global::java.math.BigInteger java.security.interfaces.RSAPrivateKey.getPrivateExponent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateKey_._getPrivateExponent23833)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateKey_.staticClass, global::java.security.interfaces.RSAPrivateKey_._getPrivateExponent23833)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23834;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateKey_._getEncoded23834)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateKey_.staticClass, global::java.security.interfaces.RSAPrivateKey_._getEncoded23834)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23835;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateKey_._getAlgorithm23835)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateKey_.staticClass, global::java.security.interfaces.RSAPrivateKey_._getAlgorithm23835)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23836;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateKey_._getFormat23836)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateKey_.staticClass, global::java.security.interfaces.RSAPrivateKey_._getFormat23836)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getModulus23837;
		 global::java.math.BigInteger java.security.interfaces.RSAKey.getModulus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateKey_._getModulus23837)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAPrivateKey_.staticClass, global::java.security.interfaces.RSAPrivateKey_._getModulus23837)) as java.math.BigInteger;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.RSAPrivateKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/RSAPrivateKey"));
			global::java.security.interfaces.RSAPrivateKey_._getPrivateExponent23833 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateKey_.staticClass, "getPrivateExponent", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.RSAPrivateKey_._getEncoded23834 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateKey_.staticClass, "getEncoded", "()[B");
			global::java.security.interfaces.RSAPrivateKey_._getAlgorithm23835 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.interfaces.RSAPrivateKey_._getFormat23836 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.interfaces.RSAPrivateKey_._getModulus23837 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAPrivateKey_.staticClass, "getModulus", "()Ljava/math/BigInteger;");
		}
	}
}
