namespace javax.crypto.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.crypto.interfaces.PBEKey_))]
	public partial interface PBEKey : SecretKey
	{
		char[] getPassword();
		int getIterationCount();
		byte[] getSalt();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.interfaces.PBEKey))]
	internal sealed partial class PBEKey_ : java.lang.Object, PBEKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PBEKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		char[] javax.crypto.interfaces.PBEKey.getPassword()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::javax.crypto.interfaces.PBEKey_.staticClass, "getPassword", "()[C", ref global::javax.crypto.interfaces.PBEKey_._m0) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int javax.crypto.interfaces.PBEKey.getIterationCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.interfaces.PBEKey_.staticClass, "getIterationCount", "()I", ref global::javax.crypto.interfaces.PBEKey_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		byte[] javax.crypto.interfaces.PBEKey.getSalt()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.interfaces.PBEKey_.staticClass, "getSalt", "()[B", ref global::javax.crypto.interfaces.PBEKey_._m2) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		byte[] java.security.Key.getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.interfaces.PBEKey_.staticClass, "getEncoded", "()[B", ref global::javax.crypto.interfaces.PBEKey_._m3) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.String java.security.Key.getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.interfaces.PBEKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.interfaces.PBEKey_._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.lang.String java.security.Key.getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.interfaces.PBEKey_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::javax.crypto.interfaces.PBEKey_._m5) as java.lang.String;
		}
		static PBEKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.interfaces.PBEKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/interfaces/PBEKey"));
		}
	}
}
