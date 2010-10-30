namespace javax.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateNotYetValidException : javax.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertificateNotYetValidException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateNotYetValidException30243;
		public CertificateNotYetValidException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.cert.CertificateNotYetValidException._CertificateNotYetValidException30243.native == global::System.IntPtr.Zero)
				global::javax.security.cert.CertificateNotYetValidException._CertificateNotYetValidException30243 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateNotYetValidException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateNotYetValidException.staticClass, global::javax.security.cert.CertificateNotYetValidException._CertificateNotYetValidException30243);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateNotYetValidException30244;
		public CertificateNotYetValidException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.cert.CertificateNotYetValidException._CertificateNotYetValidException30244.native == global::System.IntPtr.Zero)
				global::javax.security.cert.CertificateNotYetValidException._CertificateNotYetValidException30244 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateNotYetValidException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateNotYetValidException.staticClass, global::javax.security.cert.CertificateNotYetValidException._CertificateNotYetValidException30244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CertificateNotYetValidException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.CertificateNotYetValidException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/CertificateNotYetValidException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
