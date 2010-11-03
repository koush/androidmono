namespace java.security.cert
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.cert.CertPathValidatorResult_))]
	public partial interface CertPathValidatorResult : java.lang.Cloneable
	{
		global::java.lang.Object clone();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertPathValidatorResult))]
	internal sealed partial class CertPathValidatorResult_ : java.lang.Object, CertPathValidatorResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CertPathValidatorResult_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object java.security.cert.CertPathValidatorResult.clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertPathValidatorResult_.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.cert.CertPathValidatorResult_._m0) as java.lang.Object;
		}
		static CertPathValidatorResult_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathValidatorResult_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathValidatorResult"));
		}
	}
}
