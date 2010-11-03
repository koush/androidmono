namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateEncodingException : java.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertificateEncodingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public CertificateEncodingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateEncodingException._m0.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateEncodingException._m0 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateEncodingException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateEncodingException.staticClass, global::java.security.cert.CertificateEncodingException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public CertificateEncodingException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateEncodingException._m1.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateEncodingException._m1 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateEncodingException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateEncodingException.staticClass, global::java.security.cert.CertificateEncodingException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public CertificateEncodingException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateEncodingException._m2.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateEncodingException._m2 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateEncodingException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateEncodingException.staticClass, global::java.security.cert.CertificateEncodingException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public CertificateEncodingException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateEncodingException._m3.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateEncodingException._m3 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateEncodingException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateEncodingException.staticClass, global::java.security.cert.CertificateEncodingException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CertificateEncodingException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateEncodingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateEncodingException"));
		}
	}
}
