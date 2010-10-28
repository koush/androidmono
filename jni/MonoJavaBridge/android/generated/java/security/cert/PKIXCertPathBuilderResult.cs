namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PKIXCertPathBuilderResult : java.security.cert.PKIXCertPathValidatorResult, CertPathBuilderResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PKIXCertPathBuilderResult()
		{
			InitJNI();
		}
		protected PKIXCertPathBuilderResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23631;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXCertPathBuilderResult._toString23631)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXCertPathBuilderResult.staticClass, global::java.security.cert.PKIXCertPathBuilderResult._toString23631)) as java.lang.String;
		}
		public new global::java.security.cert.CertPath CertPath
		{
			get
			{
				return getCertPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCertPath23632;
		public virtual global::java.security.cert.CertPath getCertPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.PKIXCertPathBuilderResult._getCertPath23632)) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.PKIXCertPathBuilderResult.staticClass, global::java.security.cert.PKIXCertPathBuilderResult._getCertPath23632)) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _PKIXCertPathBuilderResult23633;
		public PKIXCertPathBuilderResult(java.security.cert.CertPath arg0, java.security.cert.TrustAnchor arg1, java.security.cert.PolicyNode arg2, java.security.PublicKey arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXCertPathBuilderResult.staticClass, global::java.security.cert.PKIXCertPathBuilderResult._PKIXCertPathBuilderResult23633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PKIXCertPathBuilderResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PKIXCertPathBuilderResult"));
			global::java.security.cert.PKIXCertPathBuilderResult._toString23631 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathBuilderResult.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.PKIXCertPathBuilderResult._getCertPath23632 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathBuilderResult.staticClass, "getCertPath", "()Ljava/security/cert/CertPath;");
			global::java.security.cert.PKIXCertPathBuilderResult._PKIXCertPathBuilderResult23633 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathBuilderResult.staticClass, "<init>", "(Ljava/security/cert/CertPath;Ljava/security/cert/TrustAnchor;Ljava/security/cert/PolicyNode;Ljava/security/PublicKey;)V");
		}
	}
}
