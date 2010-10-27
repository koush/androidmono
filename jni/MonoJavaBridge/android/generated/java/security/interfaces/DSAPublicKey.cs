namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.DSAPublicKey_))]
	public partial interface DSAPublicKey : DSAKey, PublicKey
	{
		global::java.math.BigInteger getY();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.DSAPublicKey))]
	internal sealed partial class DSAPublicKey_ : java.lang.Object, DSAPublicKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DSAPublicKey_()
		{
			InitJNI();
		}
		internal DSAPublicKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getY23906;
		global::java.math.BigInteger java.security.interfaces.DSAPublicKey.getY()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_._getY23906)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_.staticClass, global::java.security.interfaces.DSAPublicKey_._getY23906)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getParams23907;
		global::java.security.interfaces.DSAParams java.security.interfaces.DSAKey.getParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.interfaces.DSAParams>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_._getParams23907)) as java.security.interfaces.DSAParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.interfaces.DSAParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_.staticClass, global::java.security.interfaces.DSAPublicKey_._getParams23907)) as java.security.interfaces.DSAParams;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23908;
		byte[] java.security.Key.getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_._getEncoded23908)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_.staticClass, global::java.security.interfaces.DSAPublicKey_._getEncoded23908)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23909;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_._getAlgorithm23909)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_.staticClass, global::java.security.interfaces.DSAPublicKey_._getAlgorithm23909)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23910;
		global::java.lang.String java.security.Key.getFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_._getFormat23910)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_.staticClass, global::java.security.interfaces.DSAPublicKey_._getFormat23910)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.DSAPublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/DSAPublicKey"));
			global::java.security.interfaces.DSAPublicKey_._getY23906 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAPublicKey_.staticClass, "getY", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.DSAPublicKey_._getParams23907 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAPublicKey_.staticClass, "getParams", "()Ljava/security/interfaces/DSAParams;");
			global::java.security.interfaces.DSAPublicKey_._getEncoded23908 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAPublicKey_.staticClass, "getEncoded", "()[B");
			global::java.security.interfaces.DSAPublicKey_._getAlgorithm23909 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAPublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.interfaces.DSAPublicKey_._getFormat23910 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAPublicKey_.staticClass, "getFormat", "()Ljava/lang/String;");
		}
	}
}
