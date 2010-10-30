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
		internal static global::MonoJavaBridge.MethodId _getParams23913;
		global::java.security.spec.ECParameterSpec java.security.interfaces.ECKey.getParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.interfaces.ECKey_._getParams23913.native == global::System.IntPtr.Zero)
				global::java.security.interfaces.ECKey_._getParams23913 = @__env.GetMethodIDNoThrow(global::java.security.interfaces.ECKey_.staticClass, "getParams", "()Ljava/security/spec/ECParameterSpec;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.interfaces.ECKey_._getParams23913)) as java.security.spec.ECParameterSpec;
		}
		static ECKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.interfaces.ECKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/interfaces/ECKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
