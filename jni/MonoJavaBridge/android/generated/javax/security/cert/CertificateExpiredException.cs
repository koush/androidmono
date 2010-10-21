namespace javax.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateExpiredException : javax.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertificateExpiredException()
		{
			InitJNI();
		}
		protected CertificateExpiredException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateExpiredException30122;
		public CertificateExpiredException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateExpiredException.staticClass, global::javax.security.cert.CertificateExpiredException._CertificateExpiredException30122);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateExpiredException30123;
		public CertificateExpiredException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.CertificateExpiredException.staticClass, global::javax.security.cert.CertificateExpiredException._CertificateExpiredException30123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.CertificateExpiredException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/CertificateExpiredException"));
			global::javax.security.cert.CertificateExpiredException._CertificateExpiredException30122 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateExpiredException.staticClass, "<init>", "()V");
			global::javax.security.cert.CertificateExpiredException._CertificateExpiredException30123 = @__env.GetMethodIDNoThrow(global::javax.security.cert.CertificateExpiredException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
