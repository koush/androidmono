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
		static CertPathParameters_()
		{
			InitJNI();
		}
		internal CertPathParameters_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone23511;
		global::java.lang.Object java.security.cert.CertPathParameters.clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPathParameters_._clone23511)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPathParameters_.staticClass, global::java.security.cert.CertPathParameters_._clone23511)) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathParameters_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathParameters"));
			global::java.security.cert.CertPathParameters_._clone23511 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathParameters_.staticClass, "clone", "()Ljava/lang/Object;");
		}
	}
}
