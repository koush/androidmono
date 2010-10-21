namespace javax.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateParsingException : javax.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertificateParsingException()
		{
			InitJNI();
		}
		protected CertificateParsingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateParsingException30126;
		public CertificateParsingException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateParsingException.staticClass, global::javax.security.cert.CertificateParsingException._CertificateParsingException30126);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateParsingException30127;
		public CertificateParsingException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateParsingException.staticClass, global::javax.security.cert.CertificateParsingException._CertificateParsingException30127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.CertificateParsingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/CertificateParsingException"));
			global::javax.security.cert.CertificateParsingException._CertificateParsingException30126 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateParsingException.staticClass, "<init>", "()V");
			global::javax.security.cert.CertificateParsingException._CertificateParsingException30127 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateParsingException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
