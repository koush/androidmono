namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateNotYetValidException : java.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertificateNotYetValidException()
		{
			InitJNI();
		}
		protected CertificateNotYetValidException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateNotYetValidException17888;
		public CertificateNotYetValidException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateNotYetValidException.staticClass, global::java.security.cert.CertificateNotYetValidException._CertificateNotYetValidException17888);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateNotYetValidException17889;
		public CertificateNotYetValidException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateNotYetValidException.staticClass, global::java.security.cert.CertificateNotYetValidException._CertificateNotYetValidException17889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateNotYetValidException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateNotYetValidException"));
			global::java.security.cert.CertificateNotYetValidException._CertificateNotYetValidException17888 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateNotYetValidException.staticClass, "<init>", "()V");
			global::java.security.cert.CertificateNotYetValidException._CertificateNotYetValidException17889 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateNotYetValidException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
