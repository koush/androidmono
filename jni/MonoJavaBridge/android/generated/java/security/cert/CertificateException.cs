namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertificateException()
		{
			InitJNI();
		}
		protected CertificateException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateException23456;
		public CertificateException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateException.staticClass, global::java.security.cert.CertificateException._CertificateException23456);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateException23457;
		public CertificateException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateException.staticClass, global::java.security.cert.CertificateException._CertificateException23457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateException23458;
		public CertificateException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateException.staticClass, global::java.security.cert.CertificateException._CertificateException23458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateException23459;
		public CertificateException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateException.staticClass, global::java.security.cert.CertificateException._CertificateException23459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateException"));
			global::java.security.cert.CertificateException._CertificateException23456 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateException.staticClass, "<init>", "()V");
			global::java.security.cert.CertificateException._CertificateException23457 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.cert.CertificateException._CertificateException23458 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.cert.CertificateException._CertificateException23459 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
