namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.DSAKey_))]
	public partial interface DSAKey  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.security.interfaces.DSAParams getParams();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.DSAKey))]
	internal sealed partial class DSAKey_ : java.lang.Object, DSAKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DSAKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParams23895;
		global::java.security.interfaces.DSAParams java.security.interfaces.DSAKey.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.interfaces.DSAParams>(this, global::java.security.interfaces.DSAKey_.staticClass, "getParams", "()Ljava/security/interfaces/DSAParams;", ref global::java.security.interfaces.DSAKey_._getParams23895) as java.security.interfaces.DSAParams;
		}
		static DSAKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.DSAKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/DSAKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
