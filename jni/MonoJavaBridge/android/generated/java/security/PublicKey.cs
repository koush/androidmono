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
		internal static global::MonoJavaBridge.MethodId _getEncoded14913;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PublicKey_._getEncoded14913)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PublicKey_.staticClass, global::java.security.PublicKey_._getEncoded14913)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm14914;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PublicKey_._getAlgorithm14914)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PublicKey_.staticClass, global::java.security.PublicKey_._getAlgorithm14914)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat14915;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PublicKey_._getFormat14915)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PublicKey_.staticClass, global::java.security.PublicKey_._getFormat14915)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PublicKey"));
			global::java.security.PublicKey_._getEncoded14913 = @__env.GetMethodIDNoThrow(global::java.security.PublicKey_.staticClass, "getEncoded", "()[B");
			global::java.security.PublicKey_._getAlgorithm14914 = @__env.GetMethodIDNoThrow(global::java.security.PublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.PublicKey_._getFormat14915 = @__env.GetMethodIDNoThrow(global::java.security.PublicKey_.staticClass, "getFormat", "()Ljava/lang/String;");
		}
	}
}
