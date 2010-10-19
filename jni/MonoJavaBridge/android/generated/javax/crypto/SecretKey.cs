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
		internal static global::MonoJavaBridge.MethodId _getEncoded22699;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKey_._getEncoded22699)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SecretKey_.staticClass, global::javax.crypto.SecretKey_._getEncoded22699)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm22700;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKey_._getAlgorithm22700)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SecretKey_.staticClass, global::javax.crypto.SecretKey_._getAlgorithm22700)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat22701;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKey_._getFormat22701)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SecretKey_.staticClass, global::javax.crypto.SecretKey_._getFormat22701)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.SecretKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/SecretKey"));
			global::javax.crypto.SecretKey_._getEncoded22699 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKey_.staticClass, "getEncoded", "()[B");
			global::javax.crypto.SecretKey_._getAlgorithm22700 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.SecretKey_._getFormat22701 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKey_.staticClass, "getFormat", "()Ljava/lang/String;");
		}
	}
}
