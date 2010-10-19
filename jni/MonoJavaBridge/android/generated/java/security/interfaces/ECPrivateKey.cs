namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.ECPrivateKey_))]
	public interface ECPrivateKey : PrivateKey, ECKey
	{
		global::java.math.BigInteger getS();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.ECPrivateKey))]
	public sealed partial class ECPrivateKey_ : java.lang.Object, ECPrivateKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ECPrivateKey_()
		{
			InitJNI();
		}
		internal ECPrivateKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getS18192;
		 global::java.math.BigInteger java.security.interfaces.ECPrivateKey.getS() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_._getS18192)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_.staticClass, global::java.security.interfaces.ECPrivateKey_._getS18192)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded18193;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_._getEncoded18193)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_.staticClass, global::java.security.interfaces.ECPrivateKey_._getEncoded18193)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm18194;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_._getAlgorithm18194)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_.staticClass, global::java.security.interfaces.ECPrivateKey_._getAlgorithm18194)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat18195;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_._getFormat18195)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_.staticClass, global::java.security.interfaces.ECPrivateKey_._getFormat18195)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParams18196;
		 global::java.security.spec.ECParameterSpec java.security.interfaces.ECKey.getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_._getParams18196)) as java.security.spec.ECParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_.staticClass, global::java.security.interfaces.ECPrivateKey_._getParams18196)) as java.security.spec.ECParameterSpec;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.ECPrivateKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/ECPrivateKey"));
			global::java.security.interfaces.ECPrivateKey_._getS18192 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPrivateKey_.staticClass, "getS", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.ECPrivateKey_._getEncoded18193 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPrivateKey_.staticClass, "getEncoded", "()[B");
			global::java.security.interfaces.ECPrivateKey_._getAlgorithm18194 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.interfaces.ECPrivateKey_._getFormat18195 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.interfaces.ECPrivateKey_._getParams18196 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPrivateKey_.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;");
		}
	}
}
