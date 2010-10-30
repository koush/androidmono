namespace javax.crypto.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.crypto.interfaces.DHKey_))]
	public partial interface DHKey  : global::MonoJavaBridge.IJavaObject 
	{
		global::javax.crypto.spec.DHParameterSpec getParams();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.interfaces.DHKey))]
	internal sealed partial class DHKey_ : java.lang.Object, DHKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DHKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::javax.crypto.spec.DHParameterSpec javax.crypto.interfaces.DHKey.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.interfaces.DHKey_.staticClass, "getParams", "()Ljavax/crypto/spec/DHParameterSpec;", ref global::javax.crypto.interfaces.DHKey_._m0) as javax.crypto.spec.DHParameterSpec;
		}
		static DHKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.interfaces.DHKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/interfaces/DHKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
