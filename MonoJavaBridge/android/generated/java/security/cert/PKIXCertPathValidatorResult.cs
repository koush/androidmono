namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PKIXCertPathValidatorResult : java.lang.Object, CertPathValidatorResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PKIXCertPathValidatorResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.PKIXCertPathValidatorResult.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.PKIXCertPathValidatorResult._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.PKIXCertPathValidatorResult.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.cert.PKIXCertPathValidatorResult._m1) as java.lang.Object;
		}
		public new global::java.security.PublicKey PublicKey
		{
			get
			{
				return getPublicKey();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.security.PublicKey getPublicKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::java.security.cert.PKIXCertPathValidatorResult.staticClass, "getPublicKey", "()Ljava/security/PublicKey;", ref global::java.security.cert.PKIXCertPathValidatorResult._m2) as java.security.PublicKey;
		}
		public new global::java.security.cert.TrustAnchor TrustAnchor
		{
			get
			{
				return getTrustAnchor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.security.cert.TrustAnchor getTrustAnchor()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.PKIXCertPathValidatorResult.staticClass, "getTrustAnchor", "()Ljava/security/cert/TrustAnchor;", ref global::java.security.cert.PKIXCertPathValidatorResult._m3) as java.security.cert.TrustAnchor;
		}
		public new global::java.security.cert.PolicyNode PolicyTree
		{
			get
			{
				return getPolicyTree();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.security.cert.PolicyNode getPolicyTree()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.cert.PolicyNode>(this, global::java.security.cert.PKIXCertPathValidatorResult.staticClass, "getPolicyTree", "()Ljava/security/cert/PolicyNode;", ref global::java.security.cert.PKIXCertPathValidatorResult._m4) as java.security.cert.PolicyNode;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public PKIXCertPathValidatorResult(java.security.cert.TrustAnchor arg0, java.security.cert.PolicyNode arg1, java.security.PublicKey arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PKIXCertPathValidatorResult._m5.native == global::System.IntPtr.Zero)
				global::java.security.cert.PKIXCertPathValidatorResult._m5 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathValidatorResult.staticClass, "<init>", "(Ljava/security/cert/TrustAnchor;Ljava/security/cert/PolicyNode;Ljava/security/PublicKey;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXCertPathValidatorResult.staticClass, global::java.security.cert.PKIXCertPathValidatorResult._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static PKIXCertPathValidatorResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PKIXCertPathValidatorResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PKIXCertPathValidatorResult"));
		}
	}
}
