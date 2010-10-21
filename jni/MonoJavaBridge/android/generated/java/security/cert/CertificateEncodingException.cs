namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateEncodingException : java.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertificateEncodingException()
		{
			InitJNI();
		}
		protected CertificateEncodingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateEncodingException23452;
		public CertificateEncodingException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateEncodingException.staticClass, global::java.security.cert.CertificateEncodingException._CertificateEncodingException23452);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateEncodingException23453;
		public CertificateEncodingException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateEncodingException.staticClass, global::java.security.cert.CertificateEncodingException._CertificateEncodingException23453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateEncodingException23454;
		public CertificateEncodingException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateEncodingException.staticClass, global::java.security.cert.CertificateEncodingException._CertificateEncodingException23454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateEncodingException23455;
		public CertificateEncodingException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateEncodingException.staticClass, global::java.security.cert.CertificateEncodingException._CertificateEncodingException23455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateEncodingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateEncodingException"));
			global::java.security.cert.CertificateEncodingException._CertificateEncodingException23452 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateEncodingException.staticClass, "<init>", "()V");
			global::java.security.cert.CertificateEncodingException._CertificateEncodingException23453 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateEncodingException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.cert.CertificateEncodingException._CertificateEncodingException23454 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateEncodingException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.cert.CertificateEncodingException._CertificateEncodingException23455 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateEncodingException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
