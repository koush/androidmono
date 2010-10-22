namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.DSAPrivateKey_))]
	public interface DSAPrivateKey : DSAKey, PrivateKey
	{
		global::java.math.BigInteger getX();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.DSAPrivateKey))]
	public sealed partial class DSAPrivateKey_ : java.lang.Object, DSAPrivateKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DSAPrivateKey_()
		{
			InitJNI();
		}
		internal DSAPrivateKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getX23782;
		 global::java.math.BigInteger java.security.interfaces.DSAPrivateKey.getX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPrivateKey_._getX23782)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPrivateKey_.staticClass, global::java.security.interfaces.DSAPrivateKey_._getX23782)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getParams23783;
		 global::java.security.interfaces.DSAParams java.security.interfaces.DSAKey.getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.interfaces.DSAParams>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPrivateKey_._getParams23783)) as java.security.interfaces.DSAParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.interfaces.DSAParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPrivateKey_.staticClass, global::java.security.interfaces.DSAPrivateKey_._getParams23783)) as java.security.interfaces.DSAParams;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23784;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPrivateKey_._getEncoded23784)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPrivateKey_.staticClass, global::java.security.interfaces.DSAPrivateKey_._getEncoded23784)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23785;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPrivateKey_._getAlgorithm23785)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPrivateKey_.staticClass, global::java.security.interfaces.DSAPrivateKey_._getAlgorithm23785)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23786;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPrivateKey_._getFormat23786)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPrivateKey_.staticClass, global::java.security.interfaces.DSAPrivateKey_._getFormat23786)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.DSAPrivateKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/DSAPrivateKey"));
			global::java.security.interfaces.DSAPrivateKey_._getX23782 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAPrivateKey_.staticClass, "getX", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.DSAPrivateKey_._getParams23783 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAPrivateKey_.staticClass, "getParams", "()Ljava/security/interfaces/DSAParams;");
			global::java.security.interfaces.DSAPrivateKey_._getEncoded23784 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAPrivateKey_.staticClass, "getEncoded", "()[B");
			global::java.security.interfaces.DSAPrivateKey_._getAlgorithm23785 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAPrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.interfaces.DSAPrivateKey_._getFormat23786 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAPrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;");
		}
	}
}
