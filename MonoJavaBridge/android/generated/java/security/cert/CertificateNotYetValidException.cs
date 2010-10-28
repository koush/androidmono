namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateNotYetValidException : java.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertificateNotYetValidException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateNotYetValidException23608;
		public CertificateNotYetValidException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateNotYetValidException.staticClass, global::java.security.cert.CertificateNotYetValidException._CertificateNotYetValidException23608);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateNotYetValidException23609;
		public CertificateNotYetValidException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateNotYetValidException.staticClass, global::java.security.cert.CertificateNotYetValidException._CertificateNotYetValidException23609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CertificateNotYetValidException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateNotYetValidException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateNotYetValidException"));
			global::java.security.cert.CertificateNotYetValidException._CertificateNotYetValidException23608 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateNotYetValidException.staticClass, "<init>", "()V");
			global::java.security.cert.CertificateNotYetValidException._CertificateNotYetValidException23609 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateNotYetValidException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
