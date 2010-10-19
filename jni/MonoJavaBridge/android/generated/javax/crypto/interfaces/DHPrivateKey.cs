namespace javax.crypto.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.crypto.interfaces.DHPrivateKey_))]
	public interface DHPrivateKey : DHKey, java.security.PrivateKey
	{
		global::java.math.BigInteger getX();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.interfaces.DHPrivateKey))]
	public sealed partial class DHPrivateKey_ : java.lang.Object, DHPrivateKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DHPrivateKey_()
		{
			InitJNI();
		}
		internal DHPrivateKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getX22721;
		 global::java.math.BigInteger javax.crypto.interfaces.DHPrivateKey.getX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPrivateKey_._getX22721)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPrivateKey_.staticClass, global::javax.crypto.interfaces.DHPrivateKey_._getX22721)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getParams22722;
		 global::javax.crypto.spec.DHParameterSpec javax.crypto.interfaces.DHKey.getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPrivateKey_._getParams22722)) as javax.crypto.spec.DHParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPrivateKey_.staticClass, global::javax.crypto.interfaces.DHPrivateKey_._getParams22722)) as javax.crypto.spec.DHParameterSpec;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded22723;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPrivateKey_._getEncoded22723)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPrivateKey_.staticClass, global::javax.crypto.interfaces.DHPrivateKey_._getEncoded22723)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm22724;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPrivateKey_._getAlgorithm22724)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPrivateKey_.staticClass, global::javax.crypto.interfaces.DHPrivateKey_._getAlgorithm22724)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat22725;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPrivateKey_._getFormat22725)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPrivateKey_.staticClass, global::javax.crypto.interfaces.DHPrivateKey_._getFormat22725)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.interfaces.DHPrivateKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/interfaces/DHPrivateKey"));
			global::javax.crypto.interfaces.DHPrivateKey_._getX22721 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHPrivateKey_.staticClass, "getX", "()Ljava/math/BigInteger;");
			global::javax.crypto.interfaces.DHPrivateKey_._getParams22722 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHPrivateKey_.staticClass, "getParams", "()Ljavax/crypto/spec/DHParameterSpec;");
			global::javax.crypto.interfaces.DHPrivateKey_._getEncoded22723 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHPrivateKey_.staticClass, "getEncoded", "()[B");
			global::javax.crypto.interfaces.DHPrivateKey_._getAlgorithm22724 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHPrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.interfaces.DHPrivateKey_._getFormat22725 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHPrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;");
		}
	}
}
