namespace java.security
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.PrivateKey_))]
	public partial interface PrivateKey : Key
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.PrivateKey))]
	internal sealed partial class PrivateKey_ : java.lang.Object, PrivateKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PrivateKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded23243;
		byte[] java.security.Key.getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.PrivateKey_._getEncoded23243.native == global::System.IntPtr.Zero)
				global::java.security.PrivateKey_._getEncoded23243 = @__env.GetMethodIDNoThrow(global::java.security.PrivateKey_.staticClass, "getEncoded", "()[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PrivateKey_._getEncoded23243)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23244;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.PrivateKey_._getAlgorithm23244.native == global::System.IntPtr.Zero)
				global::java.security.PrivateKey_._getAlgorithm23244 = @__env.GetMethodIDNoThrow(global::java.security.PrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PrivateKey_._getAlgorithm23244)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23245;
		global::java.lang.String java.security.Key.getFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.PrivateKey_._getFormat23245.native == global::System.IntPtr.Zero)
				global::java.security.PrivateKey_._getFormat23245 = @__env.GetMethodIDNoThrow(global::java.security.PrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PrivateKey_._getFormat23245)) as java.lang.String;
		}
		static PrivateKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PrivateKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PrivateKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
