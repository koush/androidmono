namespace javax.crypto.interfaces
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.crypto.interfaces.DHKey_))]
	public interface DHKey  : global::MonoJavaBridge.IJavaObject 
	{
		global::javax.crypto.spec.DHParameterSpec getParams();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.interfaces.DHKey))]
	public sealed partial class DHKey_ : java.lang.Object, DHKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DHKey_()
		{
			InitJNI();
		}
		internal DHKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParams22720;
		 global::javax.crypto.spec.DHParameterSpec javax.crypto.interfaces.DHKey.getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHKey_._getParams22720)) as javax.crypto.spec.DHParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.interfaces.DHKey_.staticClass, global::javax.crypto.interfaces.DHKey_._getParams22720)) as javax.crypto.spec.DHParameterSpec;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.interfaces.DHKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/interfaces/DHKey"));
			global::javax.crypto.interfaces.DHKey_._getParams22720 = @__env.GetMethodIDNoThrow(global::javax.crypto.interfaces.DHKey_.staticClass, "getParams", "()Ljavax/crypto/spec/DHParameterSpec;");
		}
	}
}
