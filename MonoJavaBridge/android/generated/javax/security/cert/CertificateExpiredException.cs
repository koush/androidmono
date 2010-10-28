namespace javax.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateExpiredException : javax.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertificateExpiredException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateExpiredException30241;
		public CertificateExpiredException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateExpiredException.staticClass, global::javax.security.cert.CertificateExpiredException._CertificateExpiredException30241);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateExpiredException30242;
		public CertificateExpiredException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateExpiredException.staticClass, global::javax.security.cert.CertificateExpiredException._CertificateExpiredException30242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CertificateExpiredException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.CertificateExpiredException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/CertificateExpiredException"));
			global::javax.security.cert.CertificateExpiredException._CertificateExpiredException30241 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateExpiredException.staticClass, "<init>", "()V");
			global::javax.security.cert.CertificateExpiredException._CertificateExpiredException30242 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateExpiredException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
