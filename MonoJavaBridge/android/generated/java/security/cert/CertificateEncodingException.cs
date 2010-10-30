namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateEncodingException : java.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertificateEncodingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateEncodingException23571;
		public CertificateEncodingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateEncodingException._CertificateEncodingException23571.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateEncodingException._CertificateEncodingException23571 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateEncodingException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateEncodingException.staticClass, global::java.security.cert.CertificateEncodingException._CertificateEncodingException23571);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateEncodingException23572;
		public CertificateEncodingException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateEncodingException._CertificateEncodingException23572.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateEncodingException._CertificateEncodingException23572 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateEncodingException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateEncodingException.staticClass, global::java.security.cert.CertificateEncodingException._CertificateEncodingException23572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateEncodingException23573;
		public CertificateEncodingException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateEncodingException._CertificateEncodingException23573.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateEncodingException._CertificateEncodingException23573 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateEncodingException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateEncodingException.staticClass, global::java.security.cert.CertificateEncodingException._CertificateEncodingException23573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateEncodingException23574;
		public CertificateEncodingException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateEncodingException._CertificateEncodingException23574.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateEncodingException._CertificateEncodingException23574 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateEncodingException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateEncodingException.staticClass, global::java.security.cert.CertificateEncodingException._CertificateEncodingException23574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CertificateEncodingException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateEncodingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateEncodingException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
