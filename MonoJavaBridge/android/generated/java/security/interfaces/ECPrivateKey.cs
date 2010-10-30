namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.ECPrivateKey_))]
	public partial interface ECPrivateKey : PrivateKey, ECKey
	{
		global::java.math.BigInteger getS();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.ECPrivateKey))]
	internal sealed partial class ECPrivateKey_ : java.lang.Object, ECPrivateKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ECPrivateKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getS23914;
		global::java.math.BigInteger java.security.interfaces.ECPrivateKey.getS()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.interfaces.ECPrivateKey_._getS23914.native == global::System.IntPtr.Zero)
				global::java.security.interfaces.ECPrivateKey_._getS23914 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPrivateKey_.staticClass, "getS", "()Ljava/math/BigInteger;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_._getS23914)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23915;
		byte[] java.security.Key.getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.interfaces.ECPrivateKey_._getEncoded23915.native == global::System.IntPtr.Zero)
				global::java.security.interfaces.ECPrivateKey_._getEncoded23915 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPrivateKey_.staticClass, "getEncoded", "()[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_._getEncoded23915)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23916;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.interfaces.ECPrivateKey_._getAlgorithm23916.native == global::System.IntPtr.Zero)
				global::java.security.interfaces.ECPrivateKey_._getAlgorithm23916 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_._getAlgorithm23916)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23917;
		global::java.lang.String java.security.Key.getFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.interfaces.ECPrivateKey_._getFormat23917.native == global::System.IntPtr.Zero)
				global::java.security.interfaces.ECPrivateKey_._getFormat23917 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_._getFormat23917)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParams23918;
		global::java.security.spec.ECParameterSpec java.security.interfaces.ECKey.getParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.interfaces.ECPrivateKey_._getParams23918.native == global::System.IntPtr.Zero)
				global::java.security.interfaces.ECPrivateKey_._getParams23918 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECPrivateKey_.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECPrivateKey_._getParams23918)) as java.security.spec.ECParameterSpec;
		}
		static ECPrivateKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.ECPrivateKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/ECPrivateKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
