namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateExpiredException : java.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertificateExpiredException()
		{
			InitJNI();
		}
		protected CertificateExpiredException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateExpiredException23578;
		public CertificateExpiredException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateExpiredException.staticClass, global::java.security.cert.CertificateExpiredException._CertificateExpiredException23578);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateExpiredException23579;
		public CertificateExpiredException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateExpiredException.staticClass, global::java.security.cert.CertificateExpiredException._CertificateExpiredException23579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateExpiredException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateExpiredException"));
			global::java.security.cert.CertificateExpiredException._CertificateExpiredException23578 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateExpiredException.staticClass, "<init>", "()V");
			global::java.security.cert.CertificateExpiredException._CertificateExpiredException23579 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateExpiredException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
