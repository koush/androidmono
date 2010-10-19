namespace javax.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertificateException()
		{
			InitJNI();
		}
		protected CertificateException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateException23686;
		public CertificateException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateException.staticClass, global::javax.security.cert.CertificateException._CertificateException23686);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateException23687;
		public CertificateException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateException.staticClass, global::javax.security.cert.CertificateException._CertificateException23687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.CertificateException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/CertificateException"));
			global::javax.security.cert.CertificateException._CertificateException23686 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateException.staticClass, "<init>", "()V");
			global::javax.security.cert.CertificateException._CertificateException23687 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
