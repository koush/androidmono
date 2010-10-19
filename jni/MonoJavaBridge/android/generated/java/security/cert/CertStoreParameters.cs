namespace java.security.cert
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.cert.CertStoreParameters_))]
	public interface CertStoreParameters : java.lang.Cloneable
	{
		global::java.lang.Object clone();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertStoreParameters))]
	public sealed partial class CertStoreParameters_ : java.lang.Object, CertStoreParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertStoreParameters_()
		{
			InitJNI();
		}
		internal CertStoreParameters_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone17828;
		 global::java.lang.Object java.security.cert.CertStoreParameters.clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertStoreParameters_._clone17828)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertStoreParameters_.staticClass, global::java.security.cert.CertStoreParameters_._clone17828)) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertStoreParameters_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertStoreParameters"));
			global::java.security.cert.CertStoreParameters_._clone17828 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreParameters_.staticClass, "clone", "()Ljava/lang/Object;");
		}
	}
}
