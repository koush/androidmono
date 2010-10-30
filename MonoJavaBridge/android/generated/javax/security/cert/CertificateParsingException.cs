namespace javax.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateParsingException : javax.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertificateParsingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateParsingException30245;
		public CertificateParsingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.cert.CertificateParsingException._CertificateParsingException30245.native == global::System.IntPtr.Zero)
				global::javax.security.cert.CertificateParsingException._CertificateParsingException30245 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateParsingException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateParsingException.staticClass, global::javax.security.cert.CertificateParsingException._CertificateParsingException30245);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateParsingException30246;
		public CertificateParsingException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.cert.CertificateParsingException._CertificateParsingException30246.native == global::System.IntPtr.Zero)
				global::javax.security.cert.CertificateParsingException._CertificateParsingException30246 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateParsingException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateParsingException.staticClass, global::javax.security.cert.CertificateParsingException._CertificateParsingException30246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CertificateParsingException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.CertificateParsingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/CertificateParsingException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
