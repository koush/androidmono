namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.DSAParams_))]
	public partial interface DSAParams  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.math.BigInteger getP();
		global::java.math.BigInteger getQ();
		global::java.math.BigInteger getG();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.DSAParams))]
	internal sealed partial class DSAParams_ : java.lang.Object, DSAParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DSAParams_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getP23898;
		global::java.math.BigInteger java.security.interfaces.DSAParams.getP()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.DSAParams_.staticClass, "getP", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.DSAParams_._getP23898) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getQ23899;
		global::java.math.BigInteger java.security.interfaces.DSAParams.getQ()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.DSAParams_.staticClass, "getQ", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.DSAParams_._getQ23899) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getG23900;
		global::java.math.BigInteger java.security.interfaces.DSAParams.getG()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.DSAParams_.staticClass, "getG", "()Ljava/math/BigInteger;", ref global::java.security.interfaces.DSAParams_._getG23900) as java.math.BigInteger;
		}
		static DSAParams_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.DSAParams_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/DSAParams"));
		}
		internal static void InitJNI()
		{
		}
	}
}
