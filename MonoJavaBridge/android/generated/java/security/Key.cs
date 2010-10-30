namespace java.security
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.Key_))]
	public partial interface Key : java.io.Serializable
	{
		byte[] getEncoded();
		global::java.lang.String getAlgorithm();
		global::java.lang.String getFormat();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Key))]
	internal sealed partial class Key_ : java.lang.Object, Key
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Key_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.Key_.staticClass, "getEncoded", "()[B", ref global::java.security.Key_._m0) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Key_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.Key_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Key_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.Key_._m2) as java.lang.String;
		}
		static Key_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Key_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Key"));
		}
		internal static void InitJNI()
		{
		}
	}
}
