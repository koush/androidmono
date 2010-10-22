namespace javax.crypto
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.crypto.SecretKey_))]
	public interface SecretKey : java.security.Key
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.SecretKey))]
	public sealed partial class SecretKey_ : java.lang.Object, SecretKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SecretKey_()
		{
			InitJNI();
		}
		internal SecretKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded28595;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKey_._getEncoded28595)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SecretKey_.staticClass, global::javax.crypto.SecretKey_._getEncoded28595)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28596;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKey_._getAlgorithm28596)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SecretKey_.staticClass, global::javax.crypto.SecretKey_._getAlgorithm28596)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat28597;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKey_._getFormat28597)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SecretKey_.staticClass, global::javax.crypto.SecretKey_._getFormat28597)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.SecretKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/SecretKey"));
			global::javax.crypto.SecretKey_._getEncoded28595 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKey_.staticClass, "getEncoded", "()[B");
			global::javax.crypto.SecretKey_._getAlgorithm28596 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.SecretKey_._getFormat28597 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKey_.staticClass, "getFormat", "()Ljava/lang/String;");
		}
	}
}
