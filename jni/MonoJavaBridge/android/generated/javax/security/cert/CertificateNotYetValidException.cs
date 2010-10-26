namespace javax.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateNotYetValidException : javax.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertificateNotYetValidException()
		{
			InitJNI();
		}
		protected CertificateNotYetValidException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateNotYetValidException30242;
		public CertificateNotYetValidException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateNotYetValidException.staticClass, global::javax.security.cert.CertificateNotYetValidException._CertificateNotYetValidException30242);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateNotYetValidException30243;
		public CertificateNotYetValidException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateNotYetValidException.staticClass, global::javax.security.cert.CertificateNotYetValidException._CertificateNotYetValidException30243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.CertificateNotYetValidException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/CertificateNotYetValidException"));
			global::javax.security.cert.CertificateNotYetValidException._CertificateNotYetValidException30242 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateNotYetValidException.staticClass, "<init>", "()V");
			global::javax.security.cert.CertificateNotYetValidException._CertificateNotYetValidException30243 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateNotYetValidException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
