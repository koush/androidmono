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
		internal static global::MonoJavaBridge.MethodId _getEncoded23006;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.Key_.staticClass, "getEncoded", "()[B", ref global::java.security.Key_._getEncoded23006) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23007;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Key_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.Key_._getAlgorithm23007) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23008;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Key_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.Key_._getFormat23008) as java.lang.String;
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
