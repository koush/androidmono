namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.DSAKey_))]
	public interface DSAKey  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.security.interfaces.DSAParams getParams();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.DSAKey))]
	public sealed partial class DSAKey_ : java.lang.Object, DSAKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DSAKey_()
		{
			InitJNI();
		}
		internal DSAKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParams23776;
		 global::java.security.interfaces.DSAParams java.security.interfaces.DSAKey.getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.interfaces.DSAParams>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAKey_._getParams23776)) as java.security.interfaces.DSAParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.interfaces.DSAParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.DSAKey_.staticClass, global::java.security.interfaces.DSAKey_._getParams23776)) as java.security.interfaces.DSAParams;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.DSAKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/DSAKey"));
			global::java.security.interfaces.DSAKey_._getParams23776 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.DSAKey_.staticClass, "getParams", "()Ljava/security/interfaces/DSAParams;");
		}
	}
}
