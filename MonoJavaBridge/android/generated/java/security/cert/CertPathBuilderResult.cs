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
		internal static global::MonoJavaBridge.MethodId _clone23507;
		global::java.lang.Object java.security.cert.CertPathBuilderResult.clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPathBuilderResult_._clone23507)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPathBuilderResult_.staticClass, global::java.security.cert.CertPathBuilderResult_._clone23507)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getCertPath23508;
		global::java.security.cert.CertPath java.security.cert.CertPathBuilderResult.getCertPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPathBuilderResult_._getCertPath23508)) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPathBuilderResult_.staticClass, global::java.security.cert.CertPathBuilderResult_._getCertPath23508)) as java.security.cert.CertPath;
		}
		static CertPathBuilderResult_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathBuilderResult_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathBuilderResult"));
			global::java.security.cert.CertPathBuilderResult_._clone23507 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilderResult_.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.cert.CertPathBuilderResult_._getCertPath23508 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilderResult_.staticClass, "getCertPath", "()Ljava/security/cert/CertPath;");
		}
		internal static void InitJNI()
		{
		}
	}
}
