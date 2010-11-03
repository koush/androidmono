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
		internal ECKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.security.spec.ECParameterSpec java.security.interfaces.ECKey.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.interfaces.ECKey_.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;", ref global::java.security.interfaces.ECKey_._m0) as java.security.spec.ECParameterSpec;
		}
		static ECKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.ECKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/ECKey"));
		}
	}
}
