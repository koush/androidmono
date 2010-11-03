namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateNotYetValidException : java.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertificateNotYetValidException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public CertificateNotYetValidException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateNotYetValidException._m0.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateNotYetValidException._m0 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateNotYetValidException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateNotYetValidException.staticClass, global::java.security.cert.CertificateNotYetValidException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public CertificateNotYetValidException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateNotYetValidException._m1.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateNotYetValidException._m1 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateNotYetValidException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateNotYetValidException.staticClass, global::java.security.cert.CertificateNotYetValidException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CertificateNotYetValidException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateNotYetValidException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateNotYetValidException"));
		}
	}
}
