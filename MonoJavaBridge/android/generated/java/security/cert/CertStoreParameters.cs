namespace java.security.cert
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.cert.CertStoreParameters_))]
	public partial interface CertStoreParameters : java.lang.Cloneable
	{
		global::java.lang.Object clone();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertStoreParameters))]
	internal sealed partial class CertStoreParameters_ : java.lang.Object, CertStoreParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CertStoreParameters_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone23548;
		global::java.lang.Object java.security.cert.CertStoreParameters.clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertStoreParameters_._clone23548)) as java.lang.Object;
		}
		static CertStoreParameters_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertStoreParameters_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertStoreParameters"));
			global::java.security.cert.CertStoreParameters_._clone23548 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreParameters_.staticClass, "clone", "()Ljava/lang/Object;");
		}
		internal static void InitJNI()
		{
		}
	}
}
