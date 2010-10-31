namespace java.security.cert
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.cert.CertPathParameters_))]
	public partial interface CertPathParameters : java.lang.Cloneable
	{
		global::java.lang.Object clone();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertPathParameters))]
	internal sealed partial class CertPathParameters_ : java.lang.Object, CertPathParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CertPathParameters_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object java.security.cert.CertPathParameters.clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertPathParameters_.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.cert.CertPathParameters_._m0) as java.lang.Object;
		}
		static CertPathParameters_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathParameters_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathParameters"));
		}
	}
}
