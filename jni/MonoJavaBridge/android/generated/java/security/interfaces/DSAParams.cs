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
		static DSAParams_()
		{
			InitJNI();
		}
		internal DSAParams_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getP23897;
		global::java.math.BigInteger java.security.interfaces.DSAParams.getP()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAParams_._getP23897)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAParams_.staticClass, global::java.security.interfaces.DSAParams_._getP23897)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getQ23898;
		global::java.math.BigInteger java.security.interfaces.DSAParams.getQ()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAParams_._getQ23898)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAParams_.staticClass, global::java.security.interfaces.DSAParams_._getQ23898)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getG23899;
		global::java.math.BigInteger java.security.interfaces.DSAParams.getG()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAParams_._getG23899)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAParams_.staticClass, global::java.security.interfaces.DSAParams_._getG23899)) as java.math.BigInteger;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.DSAParams_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/DSAParams"));
			global::java.security.interfaces.DSAParams_._getP23897 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAParams_.staticClass, "getP", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.DSAParams_._getQ23898 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAParams_.staticClass, "getQ", "()Ljava/math/BigInteger;");
			global::java.security.interfaces.DSAParams_._getG23899 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAParams_.staticClass, "getG", "()Ljava/math/BigInteger;");
		}
	}
}
