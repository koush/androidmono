namespace javax.crypto.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.crypto.interfaces.DHPublicKey_))]
	public partial interface DHPublicKey : DHKey, java.security.PublicKey
	{
		global::java.math.BigInteger getY();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.interfaces.DHPublicKey))]
	public sealed partial class DHPublicKey_ : java.lang.Object, DHPublicKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DHPublicKey_()
		{
			InitJNI();
		}
		internal DHPublicKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getY28624;
		 global::java.math.BigInteger javax.crypto.interfaces.DHPublicKey.getY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPublicKey_._getY28624)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPublicKey_.staticClass, global::javax.crypto.interfaces.DHPublicKey_._getY28624)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getParams28625;
		 global::javax.crypto.spec.DHParameterSpec javax.crypto.interfaces.DHKey.getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPublicKey_._getParams28625)) as javax.crypto.spec.DHParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPublicKey_.staticClass, global::javax.crypto.interfaces.DHPublicKey_._getParams28625)) as javax.crypto.spec.DHParameterSpec;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded28626;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPublicKey_._getEncoded28626)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPublicKey_.staticClass, global::javax.crypto.interfaces.DHPublicKey_._getEncoded28626)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28627;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPublicKey_._getAlgorithm28627)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPublicKey_.staticClass, global::javax.crypto.interfaces.DHPublicKey_._getAlgorithm28627)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat28628;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPublicKey_._getFormat28628)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHPublicKey_.staticClass, global::javax.crypto.interfaces.DHPublicKey_._getFormat28628)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.interfaces.DHPublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/interfaces/DHPublicKey"));
			global::javax.crypto.interfaces.DHPublicKey_._getY28624 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHPublicKey_.staticClass, "getY", "()Ljava/math/BigInteger;");
			global::javax.crypto.interfaces.DHPublicKey_._getParams28625 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHPublicKey_.staticClass, "getParams", "()Ljavax/crypto/spec/DHParameterSpec;");
			global::javax.crypto.interfaces.DHPublicKey_._getEncoded28626 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHPublicKey_.staticClass, "getEncoded", "()[B");
			global::javax.crypto.interfaces.DHPublicKey_._getAlgorithm28627 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHPublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.interfaces.DHPublicKey_._getFormat28628 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHPublicKey_.staticClass, "getFormat", "()Ljava/lang/String;");
		}
	}
}
