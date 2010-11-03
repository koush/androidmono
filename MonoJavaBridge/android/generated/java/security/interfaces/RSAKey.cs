namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.RSAKey_))]
	public partial interface RSAKey  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.math.BigInteger getModulus();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.RSAKey))]
	internal sealed partial class RSAKey_ : java.lang.Object, RSAKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RSAKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.math.BigInteger java.security.interfaces.RSAKey.getModulus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.RSAKey_.staticClass, "getModulus", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.RSAKey_._m0) as java.math.BigInteger;
		}
		static RSAKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.RSAKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/RSAKey"));
		}
	}
}
