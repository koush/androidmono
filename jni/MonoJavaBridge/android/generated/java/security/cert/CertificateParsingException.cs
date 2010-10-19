namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateParsingException : java.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertificateParsingException()
		{
			InitJNI();
		}
		protected CertificateParsingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateParsingException17890;
		public CertificateParsingException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateParsingException.staticClass, global::java.security.cert.CertificateParsingException._CertificateParsingException17890);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateParsingException17891;
		public CertificateParsingException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateParsingException.staticClass, global::java.security.cert.CertificateParsingException._CertificateParsingException17891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateParsingException17892;
		public CertificateParsingException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateParsingException.staticClass, global::java.security.cert.CertificateParsingException._CertificateParsingException17892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateParsingException17893;
		public CertificateParsingException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateParsingException.staticClass, global::java.security.cert.CertificateParsingException._CertificateParsingException17893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateParsingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateParsingException"));
			global::java.security.cert.CertificateParsingException._CertificateParsingException17890 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateParsingException.staticClass, "<init>", "()V");
			global::java.security.cert.CertificateParsingException._CertificateParsingException17891 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateParsingException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.cert.CertificateParsingException._CertificateParsingException17892 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateParsingException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.cert.CertificateParsingException._CertificateParsingException17893 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateParsingException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
