namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.RSAKey_))]
	public interface RSAKey  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.math.BigInteger getModulus();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.RSAKey))]
	public sealed partial class RSAKey_ : java.lang.Object, RSAKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RSAKey_()
		{
			InitJNI();
		}
		internal RSAKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getModulus23807;
		 global::java.math.BigInteger java.security.interfaces.RSAKey.getModulus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAKey_._getModulus23807)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.RSAKey_.staticClass, global::java.security.interfaces.RSAKey_._getModulus23807)) as java.math.BigInteger;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.RSAKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/RSAKey"));
			global::java.security.interfaces.RSAKey_._getModulus23807 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.RSAKey_.staticClass, "getModulus", "()Ljava/math/BigInteger;");
		}
	}
}
