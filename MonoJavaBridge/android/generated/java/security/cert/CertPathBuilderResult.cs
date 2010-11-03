namespace java.security.cert
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.cert.CertPathBuilderResult_))]
	public partial interface CertPathBuilderResult : java.lang.Cloneable
	{
		global::java.lang.Object clone();
		global::java.security.cert.CertPath getCertPath();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertPathBuilderResult))]
	internal sealed partial class CertPathBuilderResult_ : java.lang.Object, CertPathBuilderResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CertPathBuilderResult_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object java.security.cert.CertPathBuilderResult.clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertPathBuilderResult_.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.cert.CertPathBuilderResult_._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.security.cert.CertPath java.security.cert.CertPathBuilderResult.getCertPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertPathBuilderResult_.staticClass, "getCertPath", "()Ljava/security/cert/CertPath;", ref global::java.security.cert.CertPathBuilderResult_._m1) as java.security.cert.CertPath;
		}
		static CertPathBuilderResult_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathBuilderResult_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathBuilderResult"));
		}
	}
}
