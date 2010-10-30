namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertStoreException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertStoreException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertStoreException23544;
		public CertStoreException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertStoreException._CertStoreException23544.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertStoreException._CertStoreException23544 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertStoreException.staticClass, global::java.security.cert.CertStoreException._CertStoreException23544);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertStoreException23545;
		public CertStoreException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertStoreException._CertStoreException23545.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertStoreException._CertStoreException23545 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertStoreException.staticClass, global::java.security.cert.CertStoreException._CertStoreException23545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertStoreException23546;
		public CertStoreException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertStoreException._CertStoreException23546.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertStoreException._CertStoreException23546 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertStoreException.staticClass, global::java.security.cert.CertStoreException._CertStoreException23546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertStoreException23547;
		public CertStoreException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertStoreException._CertStoreException23547.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertStoreException._CertStoreException23547 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertStoreException.staticClass, global::java.security.cert.CertStoreException._CertStoreException23547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static CertStoreException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertStoreException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertStoreException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
