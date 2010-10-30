namespace java.security
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.PublicKey_))]
	public partial interface PublicKey : Key
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.PublicKey))]
	internal sealed partial class PublicKey_ : java.lang.Object, PublicKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PublicKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.PublicKey_.staticClass, "getEncoded", "()[B", ref global::java.security.PublicKey_._m0) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.PublicKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.PublicKey_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.PublicKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.PublicKey_._m2) as java.lang.String;
		}
		static PublicKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PublicKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PublicKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
