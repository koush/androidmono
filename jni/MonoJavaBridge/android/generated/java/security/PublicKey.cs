namespace java.security
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.PublicKey_))]
	public interface PublicKey : Key
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.PublicKey))]
	public sealed partial class PublicKey_ : java.lang.Object, PublicKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PublicKey_()
		{
			InitJNI();
		}
		internal PublicKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23176;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PublicKey_._getEncoded23176)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PublicKey_.staticClass, global::java.security.PublicKey_._getEncoded23176)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23177;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PublicKey_._getAlgorithm23177)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PublicKey_.staticClass, global::java.security.PublicKey_._getAlgorithm23177)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23178;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PublicKey_._getFormat23178)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PublicKey_.staticClass, global::java.security.PublicKey_._getFormat23178)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PublicKey"));
			global::java.security.PublicKey_._getEncoded23176 = @__env.GetMethodIDNoThrow(global::java.security.PublicKey_.staticClass, "getEncoded", "()[B");
			global::java.security.PublicKey_._getAlgorithm23177 = @__env.GetMethodIDNoThrow(global::java.security.PublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.PublicKey_._getFormat23178 = @__env.GetMethodIDNoThrow(global::java.security.PublicKey_.staticClass, "getFormat", "()Ljava/lang/String;");
		}
	}
}
