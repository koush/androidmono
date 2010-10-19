namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.DSAPublicKey_))]
	public interface DSAPublicKey : DSAKey, PublicKey
	{
		global::java.math.BigInteger getY();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.DSAPublicKey))]
	public sealed partial class DSAPublicKey_ : java.lang.Object, DSAPublicKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DSAPublicKey_()
		{
			InitJNI();
		}
		internal DSAPublicKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getY18186;
		 global::java.math.BigInteger java.security.interfaces.DSAPublicKey.getY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_._getY18186)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_.staticClass, global::java.security.interfaces.DSAPublicKey_._getY18186)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getParams18187;
		 global::java.security.interfaces.DSAParams java.security.interfaces.DSAKey.getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.interfaces.DSAParams>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_._getParams18187)) as java.security.interfaces.DSAParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.interfaces.DSAParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_.staticClass, global::java.security.interfaces.DSAPublicKey_._getParams18187)) as java.security.interfaces.DSAParams;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded18188;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_._getEncoded18188)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_.staticClass, global::java.security.interfaces.DSAPublicKey_._getEncoded18188)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm18189;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_._getAlgorithm18189)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_.staticClass, global::java.security.interfaces.DSAPublicKey_._getAlgorithm18189)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat18190;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_._getFormat18190)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAPublicKey_.staticClass, global::java.security.interfaces.DSAPublicKey_._getFormat18190)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.DSAPublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/DSAPublicKey"));
			global::java.security.interfaces.DSAPublicKey_._getY18186 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAPublicKey_.staticClass, "getY", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.DSAPublicKey_._getParams18187 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAPublicKey_.staticClass, "getParams", "()Ljava/security/interfaces/DSAParams;");
			global::java.security.interfaces.DSAPublicKey_._getEncoded18188 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAPublicKey_.staticClass, "getEncoded", "()[B");
			global::java.security.interfaces.DSAPublicKey_._getAlgorithm18189 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAPublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.interfaces.DSAPublicKey_._getFormat18190 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAPublicKey_.staticClass, "getFormat", "()Ljava/lang/String;");
		}
	}
}
