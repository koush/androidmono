namespace javax.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateEncodingException : javax.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertificateEncodingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateEncodingException30237;
		public CertificateEncodingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateEncodingException.staticClass, global::javax.security.cert.CertificateEncodingException._CertificateEncodingException30237);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateEncodingException30238;
		public CertificateEncodingException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateEncodingException.staticClass, global::javax.security.cert.CertificateEncodingException._CertificateEncodingException30238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CertificateEncodingException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.CertificateEncodingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/CertificateEncodingException"));
			global::javax.security.cert.CertificateEncodingException._CertificateEncodingException30237 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateEncodingException.staticClass, "<init>", "()V");
			global::javax.security.cert.CertificateEncodingException._CertificateEncodingException30238 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateEncodingException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
