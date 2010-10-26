namespace java.security.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.interfaces.ECKey_))]
	public partial interface ECKey  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.security.spec.ECParameterSpec getParams();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.interfaces.ECKey))]
	internal sealed partial class ECKey_ : java.lang.Object, ECKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ECKey_()
		{
			InitJNI();
		}
		internal ECKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParams23912;
		 global::java.security.spec.ECParameterSpec java.security.interfaces.ECKey.getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECKey_._getParams23912)) as java.security.spec.ECParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.interfaces.ECKey_.staticClass, global::java.security.interfaces.ECKey_._getParams23912)) as java.security.spec.ECParameterSpec;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.ECKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/ECKey"));
			global::java.security.interfaces.ECKey_._getParams23912 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECKey_.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;");
		}
	}
}
