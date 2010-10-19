namespace java.security.cert
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.cert.CertPathValidatorResult_))]
	public interface CertPathValidatorResult : java.lang.Cloneable
	{
		global::java.lang.Object clone();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertPathValidatorResult))]
	public sealed partial class CertPathValidatorResult_ : java.lang.Object, CertPathValidatorResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertPathValidatorResult_()
		{
			InitJNI();
		}
		internal CertPathValidatorResult_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone17808;
		 global::java.lang.Object java.security.cert.CertPathValidatorResult.clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPathValidatorResult_._clone17808)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPathValidatorResult_.staticClass, global::java.security.cert.CertPathValidatorResult_._clone17808)) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathValidatorResult_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathValidatorResult"));
			global::java.security.cert.CertPathValidatorResult_._clone17808 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorResult_.staticClass, "clone", "()Ljava/lang/Object;");
		}
	}
}
