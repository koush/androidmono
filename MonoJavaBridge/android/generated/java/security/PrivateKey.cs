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
		private static global::MonoJavaBridge.MethodId _m0;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.PrivateKey_.staticClass, "getEncoded", "()[B", ref global::java.security.PrivateKey_._m0) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.PrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.PrivateKey_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.PrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.PrivateKey_._m2) as java.lang.String;
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
