namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PKIXCertPathValidatorResult : java.lang.Object, CertPathValidatorResult
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PKIXCertPathValidatorResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23644;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PKIXCertPathValidatorResult._toString23644.native == global::System.IntPtr.Zero)
				global::java.security.cert.PKIXCertPathValidatorResult._toString23644 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathValidatorResult.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.PKIXCertPathValidatorResult.staticClass, global::java.security.cert.PKIXCertPathValidatorResult._toString23644) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23645;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PKIXCertPathValidatorResult._clone23645.native == global::System.IntPtr.Zero)
				global::java.security.cert.PKIXCertPathValidatorResult._clone23645 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathValidatorResult.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.PKIXCertPathValidatorResult.staticClass, global::java.security.cert.PKIXCertPathValidatorResult._clone23645) as java.lang.Object;
		}
		public new global::java.security.PublicKey PublicKey
		{
			get
			{
				return getPublicKey();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey23646;
		public virtual global::java.security.PublicKey getPublicKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PKIXCertPathValidatorResult._getPublicKey23646.native == global::System.IntPtr.Zero)
				global::java.security.cert.PKIXCertPathValidatorResult._getPublicKey23646 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathValidatorResult.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::java.security.cert.PKIXCertPathValidatorResult.staticClass, global::java.security.cert.PKIXCertPathValidatorResult._getPublicKey23646) as java.security.PublicKey;
		}
		public new global::java.security.cert.TrustAnchor TrustAnchor
		{
			get
			{
				return getTrustAnchor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTrustAnchor23647;
		public virtual global::java.security.cert.TrustAnchor getTrustAnchor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PKIXCertPathValidatorResult._getTrustAnchor23647.native == global::System.IntPtr.Zero)
				global::java.security.cert.PKIXCertPathValidatorResult._getTrustAnchor23647 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathValidatorResult.staticClass, "getTrustAnchor", "()Ljava/security/cert/TrustAnchor;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.PKIXCertPathValidatorResult.staticClass, global::java.security.cert.PKIXCertPathValidatorResult._getTrustAnchor23647) as java.security.cert.TrustAnchor;
		}
		public new global::java.security.cert.PolicyNode PolicyTree
		{
			get
			{
				return getPolicyTree();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPolicyTree23648;
		public virtual global::java.security.cert.PolicyNode getPolicyTree()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PKIXCertPathValidatorResult._getPolicyTree23648.native == global::System.IntPtr.Zero)
				global::java.security.cert.PKIXCertPathValidatorResult._getPolicyTree23648 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathValidatorResult.staticClass, "getPolicyTree", "()Ljava/security/cert/PolicyNode;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.cert.PolicyNode>(this, global::java.security.cert.PKIXCertPathValidatorResult.staticClass, global::java.security.cert.PKIXCertPathValidatorResult._getPolicyTree23648) as java.security.cert.PolicyNode;
		}
		internal static global::MonoJavaBridge.MethodId _PKIXCertPathValidatorResult23649;
		public PKIXCertPathValidatorResult(java.security.cert.TrustAnchor arg0, java.security.cert.PolicyNode arg1, java.security.PublicKey arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.PKIXCertPathValidatorResult._PKIXCertPathValidatorResult23649.native == global::System.IntPtr.Zero)
				global::java.security.cert.PKIXCertPathValidatorResult._PKIXCertPathValidatorResult23649 = @__env.GetMethodIDNoThrow(global::java.security.cert.PKIXCertPathValidatorResult.staticClass, "<init>", "(Ljava/security/cert/TrustAnchor;Ljava/security/cert/PolicyNode;Ljava/security/PublicKey;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.PKIXCertPathValidatorResult.staticClass, global::java.security.cert.PKIXCertPathValidatorResult._PKIXCertPathValidatorResult23649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static PKIXCertPathValidatorResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.PKIXCertPathValidatorResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/PKIXCertPathValidatorResult"));
		}
		internal static void InitJNI()
		{
		}
	}
}
